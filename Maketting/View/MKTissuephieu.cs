using Maketting.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Maketting.View
{
    public partial class MKTissuephieu : Form
    {
        public int statusphieu { get; set; } // mới  // 2 suawra // 3 display //
                                             //   public string sophieuID { get; set; }
        public string sophieu { get; set; }
        public string storelocation { get; set; }
        public string Username { get; set; }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public void cleartoblankDEtailphieu()
        {

            #region  list black phiếu


            dataGridViewDetail = Model.MKT.Loadnewdetail(dataGridViewDetail);



            #endregion


        }

        public void addDEtailPhieuMKT(tbl_MKt_Listphieu PhieuMKT)
        {


            //dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            //dt.Columns.Add(new DataColumn("Description", typeof(string)));
            //dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

            //dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
            //dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            //---------------

            DataTable dataTable = (DataTable)dataGridViewDetail.DataSource;

            DataRow drToAdd = dataTable.NewRow();

            drToAdd["MATERIAL"] = PhieuMKT.Materiacode;
            drToAdd["Description"] = PhieuMKT.Description;
            drToAdd["ITEM_Code"] = PhieuMKT.Materiacode;
            drToAdd["Sap_Code"] = PhieuMKT.MateriaSAPcode;
            drToAdd["Unit"] = PhieuMKT.Unit;
            drToAdd["Issue_Quantity"] = PhieuMKT.Issued;


            dataTable.Rows.Add(drToAdd);
            dataTable.AcceptChanges();

            //  dataGridViewDetail.DataSource = dataTable;

            ////      drToAdd["Số_chứng_từ"] = socaitemp.Soctu;
            ////   drToAdd["Ký_hiêu"] = socaitemp.Kyhieuctu;

            ////if (socaitemp.PsNo != null)
            ////{
            ////    drToAdd["Số_tiền"] = socaitemp.PsNo;
            ////}

            //drToAdd["Mã_chi_tiết"] = socaitemp.MaCTietTKCo;
            //drToAdd["Tên_chi_tiết"] = socaitemp.tenchitietCo;

            //drToAdd["tkNohide"] = socaitemp.TkNo;


            //     drToAdd["ngayctuhide"] = socaitemp.Ngayctu;

            //dataTable.Rows.Add(drToAdd);
            //dataTable.AcceptChanges();



            //int i = dataTable.Rows.Count - 1;
            //   int i = dataGridViewTkCo.RowCount -1;

            //DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridViewTkNo.Rows[i].Cells["Tk_Nợ"];
            //DataGridViewCell dgvc = (DataGridViewCell)dataGridViewTkNo.Rows[i].Cells["Tk_Nợ"];

            //#region tim item comboboc

            //foreach (ComboboxItem item in (List<ComboboxItem>)cb.DataSource)
            //{

            //    if (item.Value.ToString().Trim() == socaitemp.TkNo.ToString().Trim())
            //    {

            //        dataGridViewTkNo.Rows[i].Cells["Tk_Nợ"].Value = item.Value;
            //    }

            //}


            //#endregion tom item comboubox




        }



        public void reloadseachview(string nguoinop, string diachi, string noidung)
        {



            //     dataGridViewListphieuchi.DataSource = Model.Phieuthuchi.reloadseachview("PC", nguoinop, diachi, noidung);


        }

        public void cleartoblankphieu()
        {

            #region  list black phiếu
            datepickngayphieu.Enabled = true;
            txtmact.Text = "";
            txtmact.Enabled = false;

            txtcustcode.Text = "";
            txtcustcode.Enabled = false;

            txtdiachi.Text = "";
            txtdiachi.Enabled = false;

            txtnguoiyeucau.Enabled = true;
            txtnguoinhan.Enabled = true;


            btluu.Visible = true;
            btluu.Enabled = true;
            //    cbtaikhoanco.Enabled = true;

            btsua.Enabled = false;

            txtmucdichname.Text = "";
            txtnguoiyeucau.Text = "";
            txtnguoinhan.Text = "";
            txtdiachi.Text = "";
            txtnguoiyeucau.Text = Utils.getname();

            lbtel.Text = "";
            lbweight.Text = "";
            lbgatepassno.Text = "";
            datepickngayphieu.Value = DateTime.Today;

            txtnguoiyeucau.Focus();

            dataGridViewDetail = Model.MKT.Loadnewdetail(dataGridViewDetail);

            //     cbkhohang.Items.Clear();

            //   List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            string username = Utils.getusername();
            this.Username = username;
            string rightkho = Model.Username.getmaquyenkho();

            List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                      where   ( from   gg in dc.tbl_MKT_StoreRights 
                                          where gg.storeright == rightkho
                                          select gg.makho).Contains(pp.makho)
                      select pp;
            foreach (var item2 in rs1)
            {
                ComboboxItem cb = new ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim();
                itemstorecolect.Add(cb);

                //  cbkhohang.Items.Add(cb);
                //  CombomCollection.Add(cb);
            }
            cbkhohang.DataSource = itemstorecolect;
            cbkhohang.SelectedIndex = 0;

            this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();
            //this.matk = taikhoan;


            Model.MKT.DeleteALLphieutamTMP();

          

            #endregion


        }


        void Control_KeyPress(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.F3)
            {





                FormCollection fc = System.Windows.Forms.Application.OpenForms;

                bool kq = false;
                foreach (Form frm in fc)
                {
                    if (frm.Text == "BeeSeach")


                    {
                        kq = true;
                        frm.Focus();

                    }
                }

                if (!kq)
                {
                    //  View.BeeSeachtwofield sheaching = new BeeSeachtwofield(this, "Người nôp", "Địa chỉ", "Nội dung");
                    // sheaching.Show();
                }




            }


            if (e.Control == true && e.KeyCode == Keys.N)
            {





                FormCollection fc = System.Windows.Forms.Application.OpenForms;

                bool kq = false;
                foreach (Form frm in fc)
                {
                    if (frm.Text == "BeeHtoansocaidoiung")


                    {
                        kq = true;
                        frm.Focus();

                    }
                }

                if (!kq)
                {
                    //   View.BeeHtoansocaiphieuchi BeeHtoansocaidoiung = new BeeHtoansocaiphieuchi(this, "Địa chỉ", "", "");
                    //   BeeHtoansocaidoiung.Show();
                }




            }


        }

        public View.Main main1;

        public MKTissuephieu(View.Main Main)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);  // để đọc từ bàn phím phím tắt


            this.main1 = Main;



            this.statusphieu = 1; // tạo mới

            cleartoblankphieu();
            this.sophieu = Model.MKT.getMKtNo();
            lbgatepassno.Text = this.sophieu;




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            main1.clearpannel();
            View.Beemainload main = new Beemainload(main1);

            main1.clearpannelload(main);
        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txtnguoiyeucau.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void datepickngayphieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // datepickngayphieu.
                e.Handled = true;
                txtnguoinhan.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }




        }

        private void cbtennguoinop_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cbtennguoinop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnguoinhan.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void cbdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbdiengiai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtmucdichname.Focus();



            }
        }

        private void cbsotien_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //txtsochungtugoc.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }

        }

        private void cbsochungtugoc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                datepickngayphieu.Focus();
                //  datepickngayphieu
                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void cbtkno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  e.Handled = true;
                //  cbtaikhoanco.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void cbtaikhoanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  e.Handled = true;
                //   datepickngayphieu.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

       

        private void button1_Click(object sender, EventArgs e)  // new phieu 
        {

            bool checkdetail = true;
            bool checkhead = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs5 = (from pp in dc.tbl_MKt_Listphieuheads
                       where pp.id.ToString() == this.sophieu && pp.Status != "TMP"

                       select pp).FirstOrDefault();
            if (rs5 != null)
            {
                MessageBox.Show("Can not created, dublicate found !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                checkhead = false;
                return;

            }


            #region  // check head
            if (txtcustcode.Text == "")
            {
                MessageBox.Show("Pleae select a Benefitciary (Người nhận) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnguoinhan.Focus();
                checkhead = false;
                return;
            }

            if (txtmact.Text == "")
            {
                MessageBox.Show("Pleae select a Purpose (Mục đích) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmucdichname.Focus();
                checkhead = false;
                return;
            }


            if (cbkhohang.Text == "")
            {
                MessageBox.Show("Pleae select a Location Wave House (Chọn Kho) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbkhohang.Focus();
                checkhead = false;
                return;
            }
            #endregion


            #region  //check detai từng dòng

            if (dataGridViewDetail.RowCount == 0)
            {
                MessageBox.Show("Bạn chưa nhập chi tiết phiếu ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                checkdetail = false;
                return;
            }
            for (int idrow = 0; idrow < dataGridViewDetail.RowCount - 1; idrow++)
            {
                if (dataGridViewDetail.Rows[idrow].Cells["ITEM_Code"].Value != DBNull.Value)
                {

                    //dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Description", typeof(string)));
                    //dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

                    //dt.Columns.Add(new DataColumn("Unit", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
                    //dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));

                    dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.White;

                    if (dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value == DBNull.Value)
                    {

                        MessageBox.Show("Please nhập số lượng xuất dòng : " + (idrow + 1).ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                        checkdetail = false;
                        return;
                    }

                    if (dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value != DBNull.Value && dataGridViewDetail.Rows[idrow].Cells["Avaiable_Quantity"].Value != DBNull.Value)
                    {
                        if ((float)dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value > (float)dataGridViewDetail.Rows[idrow].Cells["Avaiable_Quantity"].Value)
                        {
                            MessageBox.Show("Please số lượng lớn hơn số avaiable, please check dòng:  " + (idrow + 1).ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                            checkdetail = false;
                            return;
                        }

                    }


                }


            }  //for


            #endregion

            if (checkdetail && checkhead)
            {

                #region // head 
                //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();
                btluu.Enabled = false;

                var rs = (from pp in dc.tbl_MKt_Listphieuheads
                          where pp.id.ToString() == this.sophieu && pp.Status == "TMP"

                          select pp).FirstOrDefault();

                if (rs != null)
                {
                    rs.Region = Model.Username.getuseRegion();
                    rs.Address = txtdiachi.Text;
                    rs.Customer_SAP_Code = double.Parse(txtcustcode.Text);
                    rs.Receiver_by = txtnguoinhan.Text;

                    rs.Ngaytaophieu = datepickngayphieu.Value;
                    rs.Purpose = txtmucdichname.Text;
                    rs.Purposeid = txtmact.Text;
                    rs.ShippingPoint = this.storelocation;
                    rs.Requested_by = txtnguoiyeucau.Text;
                    rs.Status = "CRT";
                    rs.Gate_pass = this.sophieu;

                    rs.Tel = lbtel.Text;
                    rs.Username = this.Username;
                    dc.SubmitChanges();

                }


                #endregion

                #region // detail
                for (int idrow = 0; idrow < dataGridViewDetail.RowCount - 1; idrow++)
                {
                    if (dataGridViewDetail.Rows[idrow].Cells["ITEM_Code"].Value != DBNull.Value)
                    {
                        tbl_MKt_Listphieu detailphieu = new tbl_MKt_Listphieu();

                        detailphieu.Address = txtdiachi.Text;
                        detailphieu.Customer_SAP_Code = double.Parse(txtcustcode.Text);
                        detailphieu.Receiver_by = txtnguoinhan.Text;

                        detailphieu.Ngaytaophieu = datepickngayphieu.Value;
                        detailphieu.Purpose = txtmucdichname.Text;
                        detailphieu.Purposeid = txtmact.Text;
                        detailphieu.ShippingPoint = this.storelocation;
                        detailphieu.Requested_by = txtnguoiyeucau.Text;
                        detailphieu.Status = "CRT";
                        detailphieu.Tel = lbtel.Text;
                        detailphieu.Username = this.Username;
                        detailphieu.Gate_pass = this.sophieu;
                        detailphieu.Region = Model.Username.getuseRegion();
                        //dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
                        //dt.Columns.Add(new DataColumn("Description", typeof(string)));
                        //dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
                        //dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

                        //dt.Columns.Add(new DataColumn("Unit", typeof(string)));
                        //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
                        //dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));

                        if (dataGridViewDetail.Rows[idrow].Cells["MATERIAL"].Value != DBNull.Value)
                        {
                            detailphieu.Materialname = (string)dataGridViewDetail.Rows[idrow].Cells["MATERIAL"].Value;
                        }

                        if (dataGridViewDetail.Rows[idrow].Cells["ITEM_Code"].Value != DBNull.Value)
                        {
                            detailphieu.Materiacode = (string)dataGridViewDetail.Rows[idrow].Cells["ITEM_Code"].Value;
                        }


                        if (dataGridViewDetail.Rows[idrow].Cells["SAP_CODE"].Value != DBNull.Value)
                        {

                            detailphieu.MateriaSAPcode = (string)dataGridViewDetail.Rows[idrow].Cells["SAP_CODE"].Value;
                        }
                        if (dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value != DBNull.Value)
                        {

                            detailphieu.Issued = (float)dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value;
                        }
                        if (dataGridViewDetail.Rows[idrow].Cells["Description"].Value != DBNull.Value)
                        {
                            detailphieu.Description = (string)dataGridViewDetail.Rows[idrow].Cells["Description"].Value;
                        }
                        if (dataGridViewDetail.Rows[idrow].Cells["Unit"].Value != DBNull.Value)
                        {
                            detailphieu.Unit = (string)dataGridViewDetail.Rows[idrow].Cells["Unit"].Value;
                        }
                        dc.tbl_MKt_Listphieus.InsertOnSubmit(detailphieu);
                        dc.SubmitChanges();



                    }
                }

                #endregion

                MessageBox.Show("Phiếu " + this.sophieu.ToString() + " done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cleartoblankphieu();
            }


        }

        private void dataGridViewListphieuthu_Paint(object sender, PaintEventArgs e)
        {

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridViewListphieu.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

            // Next





        }

        private void cbtkno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            //var rs = from tbl_Kafuctionlist in db.tbl_Kafuctionlists
            //         where tbl_Kafuctionlist.Code != "DIS"
            //         orderby tbl_Kafuctionlist.Code
            //         select tbl_Kafuctionlist;
            //foreach (var item2 in rs)
            //{
            //    ComboboxItem cb = new ComboboxItem();
            //    cb.Value = item2.Code.Trim();
            //    cb.Text = item2.Code.Trim() + ": " + item2.Description.Trim() + "    || Example: " + item2.Example;
            //    CombomCollection.Add(cb);
            //}

            //  string taikhoan = (cbtkco.SelectedItem as ComboboxItem).Value.ToString();
            //     this.matk = taikhoan;




            //    dataGridViewTkCo.Focus();

        }


        private void cbtaikhoanco_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    dataGridViewTkCo.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.cleartoblankphieu();

            Model.MKT.DeleteALLphieutamTMP();

            this.sophieu = Model.MKT.getMKtNo();
            lbgatepassno.Text = this.sophieu;
            btluu.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string username = Utils.getusername();
            this.Username = username;

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rptMKT = from pp in dc.tbl_MKT_headRpt_Phieuissues
                         where pp.Username == this.Username
                         select pp;

            dc.tbl_MKT_headRpt_Phieuissues.DeleteAllOnSubmit(rptMKT);
            dc.SubmitChanges();


            var rptMKTdetail = from pp in dc.tbl_MKT_DetailRpt_Phieuissues
                               where pp.Username == this.Username
                               select pp;

            dc.tbl_MKT_DetailRpt_Phieuissues.DeleteAllOnSubmit(rptMKTdetail);
            dc.SubmitChanges();

            var rptMKThead = (from pp in dc.tbl_MKt_Listphieuheads
                              where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation
                              select pp).FirstOrDefault();

            if (rptMKThead != null)
            {
                tbl_MKT_headRpt_Phieuissue headpx = new tbl_MKT_headRpt_Phieuissue();

                headpx.Diachi = rptMKThead.Address;
                headpx.Nguoinhancode = rptMKThead.Customer_SAP_Code.ToString();
                headpx.Username = this.Username;
                headpx.Sophieu = rptMKThead.Gate_pass;
                headpx.Nguoinhanname = rptMKThead.Receiver_by;
                headpx.seri = rptMKThead.Region+this.storelocation + rptMKThead.Gate_pass;

                BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(rptMKThead.Region+this.storelocation + rptMKThead.Gate_pass), 1, true), typeof(Byte[]));

                headpx.Barcode = result;
                headpx.dienthoai = rptMKThead.Tel;
                headpx.mucdich = rptMKThead.Purpose;
                headpx.Ngaythang = rptMKThead.Ngaytaophieu;
                headpx.Nguoiyeucau = rptMKThead.Requested_by;



                dc.tbl_MKT_headRpt_Phieuissues.InsertOnSubmit(headpx);
                dc.SubmitChanges();

            }

            var rptMKTdetailmk = from pp in dc.tbl_MKt_Listphieus
                                 where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation
                                 select pp;
            int i = 0;
            foreach (var item in rptMKTdetailmk)
            {
                i = i + 1;

                tbl_MKT_DetailRpt_Phieuissue detailpx = new tbl_MKT_DetailRpt_Phieuissue();

                detailpx.stt = i.ToString();
                detailpx.soluong = item.Issued;
                detailpx.Username = this.Username;
                detailpx.tensanpham = item.Materialname;
                detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));


                dc.tbl_MKT_DetailRpt_Phieuissues.InsertOnSubmit(detailpx);
                dc.SubmitChanges();

            }
          
            var rshead = from pp in dc.tbl_MKT_headRpt_Phieuissues
                         where pp.Username == this.Username
                         select new
                         {

                          //   username = pp.Username,
                             Nguoiyeucau = pp.Nguoiyeucau,
                             Ngaythang = pp.Ngaythang,
                             Sophieu = pp.Sophieu,
                             Nguoinhancode = pp.Nguoinhancode,
                             Nguoinhanname = pp.Nguoinhanname,
                             Diachi = pp.Diachi,
                             mucdich = pp.mucdich,

                             dienthoai = pp.dienthoai,
                             seri = pp.seri,
                             Barcode = pp.Barcode


                         };
            Utils ut = new Utils();
            var dataset1 = ut.ToDataTable(dc, rshead); // head

            //View.Viewtable vx1 = new Viewtable(rshead, dc, "test", 100, "100");
            //vx1.ShowDialog();
            var rsdetail = from pp in dc.tbl_MKT_DetailRpt_Phieuissues
                           where pp.Username == this.Username
                           orderby pp.stt
                           select new
                           {

                               stt = pp.stt,
                               tensanpham = pp.tensanpham,

                               soluong = pp.soluong,
                            //   username = pp.Username,
                               bangchu = pp.bangchu,

                           };

            //View.Viewtable vx = new Viewtable(rsdetail,dc,"test",100,"100");
            //vx.ShowDialog();
          
           
            var dataset2 = ut.ToDataTable(dc, rsdetail); // detail


            Reportsview rpt = new Reportsview(dataset1, dataset2, "PhieuMKTissue.rdlc");
            rpt.ShowDialog();

            //}

            //#endregion view reports payment request  // 

        }

        private void dataGridViewListphieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            try
            {
                this.sophieu = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Gate_pass"].Value;
                this.storelocation = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Store"].Value;

                //Date = pp.Ngaytaophieu,
                //             pp.Gate_pass,
                //             pp.Requested_by,
                //             pp.Purpose,


                //             pp.Receiver_by,
                //             pp.Customer_SAP_Code,
                //             pp.Address,
                //             pp.Materiacode,
                //             //  pp.MateriaSAPcode,
                //             pp.Description,
                //             pp.Issued,
                //             Store = pp.ShippingPoint,
                //             Created_by = pp.Username,
                //             pp.id,
            }
            catch (Exception)
            {

                //     this.phieuchiid = 0;
            }


            //List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            //var rs = from tbl_dstaikhoan in dc.tbl_dstaikhoans
            //         where tbl_dstaikhoan.loaitkid == "tien" // tien mat la loai 8
            //         orderby tbl_dstaikhoan.matk
            //         select tbl_dstaikhoan;
            //foreach (var item in rs)
            //{
            //    ComboboxItem cb = new ComboboxItem();
            //    cb.Value = item.matk.Trim();
            //    cb.Text = item.matk.Trim() + ": " + item.tentk;
            //    CombomCollection.Add(cb);
            //}

            //cbtkco.DataSource = CombomCollection;

            //#endregion load tk nợ



            //   try
            //{
            //    this.phieuchiid = (int)this.dataGridViewListphieuchi.Rows[this.dataGridViewListphieuchi.CurrentCell.RowIndex].Cells["ID"].Value;


            //}
            //catch (Exception)
            //{

            //    this.phieuchiid = 0;
            //}

            //if (this.phieuchiid != 0)
            //{

            //    string macty = Model.Username.getmacty();

            //    #region view load form
            //    var phieuchi = (from tbl_SoQuy in dc.tbl_SoQuys
            //                    where tbl_SoQuy.id == this.phieuchiid
            //                    && tbl_SoQuy.macty == macty
            //                    select new
            //                    {

            //                        //     tencongty = Model.Congty.getnamecongty(),
            //                        //     diachicongty = Model.Congty.getdiachicongty(),
            //                        ////     masothue = Model.Congty.getmasothuecongty(),
            //                        //   tengiamdoc = Model.Congty.gettengiamdoccongty(),
            //                        //    tenketoantruong = Model.Congty.gettenketoantruongcongty(),

            //                        sophieuthu = tbl_SoQuy.Sophieu,
            //                        ngaychungtu = tbl_SoQuy.Ngayctu,
            //                        nguoinoptien = tbl_SoQuy.Nguoinopnhantien,
            //                        //    nguoilapphieu = Utils.getname(),
            //                        diachinguoinop = tbl_SoQuy.Diachinguoinhannop,
            //                        lydothu = tbl_SoQuy.Diengiai,
            //                        sotien = tbl_SoQuy.PsCo,
            //                        //   sotienbangchu = Utils.ChuyenSo(tbl_SoQuy.PsNo.ToString()),
            //                        sochungtugoc = tbl_SoQuy.Chungtugockemtheo,
            //                        //    username = Utils.getusername(),


            //                        machitietco = tbl_SoQuy.ChitietTM,
            //                        tentkchitiet = tbl_SoQuy.TenchitietTM,
            //                        tkno = tbl_SoQuy.TKtienmat,

            //                        taikhoandoiung = tbl_SoQuy.TKdoiung,

            //                    }).FirstOrDefault();


            //    if (phieuchi != null)
            //    {
            //        datepickngayphieu.Value = phieuchi.ngaychungtu;

            //        txttennguoinhan.Text = phieuchi.nguoinoptien;
            //        txtdiachi.Text = phieuchi.diachinguoinop;
            //        txtdiengiai.Text = phieuchi.lydothu;


            //        //foreach (ComboboxItem item in (List<ComboboxItem>)cbtkco.DataSource)
            //        //{
            //        //    if (item.Value.ToString().Trim() == phieuchi.tkno.Trim())
            //        //    {
            //        //        cbtkco.SelectedItem = item;
            //        //    }
            //        //}








            //        datepickngayphieu.Enabled = false;

            //        txttennguoinhan.Enabled = false;
            //        txtdiachi.Enabled = false;
            //        txtdiengiai.Enabled = false;

            //        btsua.Enabled = true;







            //        this.statusphieuchi = 3;// View
            // //       Model.Phieuthuchi.reloadnewdetailtaikhoanNo(dataGridViewTkNo);
            //    Model.Phieuthuchi.reloaddetailtaikhoannophieuchi(this.dataGridViewTkNo, this, phieuchi.tkno.Trim(), phieuchi.sophieuthu);
            //        btluu.Visible = false;

            //    }



            //    #endregion view load form









            //}


        }

        private void dataGridViewListphieuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxoa_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.statusphieu = 2;

            btluu.Enabled = true;
            btmoi.Enabled = true;
            btxoa.Enabled = true;

            datepickngayphieu.Enabled = true;




            txtnguoiyeucau.Enabled = true;
            txtnguoinhan.Enabled = true;
            txtdiachi.Enabled = true;

            btluu.Enabled = true;

            //   cbtaikhoanco.Enabled = true;


            this.statusphieu = 2;

        }

        private void txtsophieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txtnguoiyeucau.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txttennguoinop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txtnguoinhan.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txtdiachi.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtdiengiai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //  txtsotien.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtsotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //txtsochungtugoc.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtsochungtugoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //cbtkco.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void bthachtoan_Click(object sender, EventArgs e)
        {


            FormCollection fc = System.Windows.Forms.Application.OpenForms;

            bool kq = false;
            foreach (Form frm in fc)
            {
                if (frm.Text == "BeeHtoansocaidoiung")


                {
                    kq = true;
                    frm.Focus();

                }
            }

            if (!kq)
            {
                //   View.BeeHtoansocaiphieuchi BeeHtoansocaidoiung = new BeeHtoansocaiphieuchi(this, "Địa chỉ", "", "");
                //    BeeHtoansocaidoiung.ShowDialog();
            }



        }

        private void txtsotien_TextChanged(object sender, EventArgs e)
        {

            //if (Utils.IsValidnumber(txtsotien.Text.ToString()))
            //{
            //    this.pssotienno = double.Parse(txtsotien.Text);
            //   // txtsotien.Text = pssotienno.pssotienno
            //}
            ////else
            //{
            //    txtsotien.Text = "";
            //}



        }

        private void txtsochungtugoc_TextChanged(object sender, EventArgs e)
        {
            //if (! Utils.IsValidnumber(txtsochungtugoc.Text.ToString()))
            //{
            //    txtsochungtugoc.Text = "";
            //}

        }

        private void dataGridViewTkCo_Paint(object sender, PaintEventArgs e)
        {

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridViewDetail.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

            // Next

        }


        void cbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(EndEdit));

        }
        ComboBox cbm;
        DataGridViewCell currentCell;

        //  private DateTimePicker cellDateTimePicker = new DateTimePicker();
        // DateTimePicker[] sp = new DateTimePicker[100];
        void EndEdit()
        {




            if (cbm != null)
            {
                if (cbm.SelectedItem != null)
                {
                    string SelectedItem = (cbm.SelectedItem as ComboboxItem).Value.ToString();// (cbm.SelectedItem as ComboboxItem).Value.ToString();

                    // int i = dataGridProgramdetail.CurrentRow.Index;
                    int i = currentCell.RowIndex;
                    string colname = this.dataGridViewDetail.Columns[this.dataGridViewDetail.CurrentCell.ColumnIndex].Name;

                    dataGridViewDetail.Rows[i].Cells[colname].Value = SelectedItem;





                }


            }


        }

        private void dataGridViewTkCo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {

                cbm = (ComboBox)e.Control;

                if (cbm != null)
                {
                    cbm.SelectedIndexChanged += new EventHandler(cbm_SelectedIndexChanged);
                }


                currentCell = this.dataGridViewDetail.CurrentCell;




            }
        }

        private void txtquyenso_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //txtsophieu.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }




        }

        private void dataGridViewTkCo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView view = (DataGridView)sender;
            int i = e.RowIndex;
            string colname = view.Columns[e.ColumnIndex].Name;

            //       #region if la slect tai khoan co chi tiet

            if (colname == "Tk_Nợ")
            {


                //  string SelectedItem = view.Rows[i].Cells["Tk_Có"].Value.ToString();


            }


            //   if (colname == "Số_tiền")
            //   {


            //  string SelectedItem = view.Rows[i].Cells["Tk_Có"].Value.ToString();








        }

        private void dataGridViewTkCo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ///
            //    DataGridView view = (DataGridView)sender;
            //     int i = view.CurrentRow.Index;
            //    string colname = view.Columns[view.CurrentCell.ColumnIndex].Name;
            //     string SelectedItem = view.Rows[i].Cells["Tk_Nợ"].Value.ToString();



            FormCollection fc = System.Windows.Forms.Application.OpenForms;

            bool kq = false;
            foreach (Form frm in fc)
            {
                if (frm.Text == "SELECT")


                {
                    kq = true;
                    frm.Focus();

                }
            }

            if (!kq && e.RowIndex >= 0 && dataGridViewDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string username = Utils.getusername();

                string columhead = dataGridViewDetail.Columns[e.ColumnIndex].HeaderText.ToString();
                string valueseach = dataGridViewDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                IQueryable rs = null;

                if (columhead == "Description")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.Description.Contains(valueseach) && pp.Store_code == this.storelocation
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }

                if (columhead == "ITEM Code")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.ITEM_Code.Contains(valueseach) && pp.Store_code == this.storelocation
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }
                if (columhead == "Sap Code")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.SAP_CODE.Contains(valueseach) && pp.Store_code == this.storelocation
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }

                if (columhead == "MATERIAL")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.MATERIAL.Contains(valueseach) && pp.Store_code == this.storelocation
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }

                //if (columhead == "Unit")
                //{
                //    rs = from pp in dc.tbl_MKT_Stockends
                //         where pp.UNIT.Contains(valueseach)
                //         select new
                //         {
                //             pp.ITEM_Code,
                //             pp.SAP_CODE,
                //             pp.MATERIAL,
                //             pp.Description,
                //             pp.UNIT,
                //             Avaiable_stock = pp.END_STOCK,

                //             pp.id,

                //         };

                //}
                //  MessageBox.Show(columhead);
                if (rs != null)
                {
                    View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT PRODUCTS ", columhead);
                    selectkq.ShowDialog();
                    int id = selectkq.id;

                    //dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Description", typeof(string)));
                    //dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

                    //dt.Columns.Add(new DataColumn("Unit", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
                    //dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));


                    var valuechon = (from pp in dc.tbl_MKT_Stockends
                                     where pp.id == id
                                     select pp).FirstOrDefault();

                    if (valuechon != null)
                    {
                        dataGridViewDetail.Rows[e.RowIndex].Cells["MATERIAL"].Value = valuechon.MATERIAL;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Description"].Value = valuechon.Description;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ITEM_Code"].Value = valuechon.ITEM_Code;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Sap_Code"].Value = valuechon.SAP_CODE;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Avaiable_Quantity"].Value = valuechon.END_STOCK;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Unit"].Value = valuechon.UNIT;

                    }
                    else
                    {
                        dataGridViewDetail.Rows[e.RowIndex].Cells["MATERIAL"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Description"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ITEM_Code"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Sap_Code"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Avaiable_Quantity"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Unit"].Value = DBNull.Value;

                    }



                }

                //   }

            }




        }

        private void dataGridViewTkCo_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridViewTkCo_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridViewTkCo_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

        }

        private void dataGridViewTkCo_DataError_1(object sender, DataGridViewDataErrorEventArgs anError)
        {



            //String errortext = "Lỗi dữ liệu nhập vào ";


            //if (anError.Context == DataGridViewDataErrorContexts.Commit)
            //{
            //    errortext = "Dữ liệu nhập vào không phù hợp";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            //{
            //    errortext = "Lỗi khi sửa dữ liệu ô";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            //{
            //    errortext = "Lỗi khi chuyển kiểu dữ liệu";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            //{
            //    errortext = "Lỗi khi chuyển ô ";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.Formatting)
            //{
            //    errortext = "Loại dữ liệu nhập vào không đúng";
            //}


            //MessageBox.Show("Lỗi :" + errortext, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //if ((anError.Exception) is ConstraintException)
            //{
            //    DataGridView view = (DataGridView)sender;
            //    view.Rows[anError.RowIndex].ErrorText = "";
            //    view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "";

            //    anError.ThrowException = false;
            //}


        }

        private void dataGridViewTkCo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {



        }

        private void txtsotienco_TextChanged(object sender, EventArgs e)
        {



        }

        private void dataGridViewTkNo_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            //#region  view lai cac tk có

            //String tkcotext = "";


            //int dem = 0;
            //for (int idrow = 0; idrow < dataGridViewTkNo.RowCount - 1; idrow++)
            //{

            //    if (dataGridViewTkNo.Rows[idrow].Cells["Tk_Nợ"].Value != DBNull.Value)
            //    {



            //        dem = dem + 1;
            //        if (dem > 1)
            //        {

            //            tkcotext += ";" + dataGridViewTkNo.Rows[idrow].Cells["Tk_Nợ"].Value.ToString().Trim(); // chính la program

            //        }
            //        else
            //        {
            //            tkcotext += dataGridViewTkNo.Rows[idrow].Cells["Tk_Nợ"].Value.ToString().Trim(); // chính la program
            //                                                                                             //dataGridViewTkCo.Columns["Số_tiền"].DisplayIndex = 3;


            //        }


            //    }


            //}

            //txttaikhoanno.Text = tkcotext;
            //#endregion


            //#region  view lai cac tk nợ


            //double tongcong = 0;


            //for (int idrow = 0; idrow < dataGridViewTkNo.RowCount - 1; idrow++)
            //{


            //    if (dataGridViewTkNo.Rows[idrow].Cells["Số_tiền"].Value != DBNull.Value)

            //    {
            //        if (Utils.IsValidnumber(dataGridViewTkNo.Rows[idrow].Cells["Số_tiền"].Value.ToString()))
            //        {

            //            tongcong += double.Parse(dataGridViewTkNo.Rows[idrow].Cells["Số_tiền"].Value.ToString());
            //        }
            //    }







            //}

            ////txtValueSotienCo.Text = tongcong.ToString();
            //this.pssotienno = tongcong;
            //txtsotienno.Text = tongcong.ToString("#,#", CultureInfo.InvariantCulture);
            //#endregion



        }

        private void txtsotien_Leave(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbtkco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //    string taikhoan = (cbtkco.SelectedItem as ComboboxItem).Value.ToString();
            //     this.matk = taikhoan;




        }

        private void dataGridViewListphieuchi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sophieufind = "";
            string storelocationfind = "";
            string connection_string = Utils.getConnectionstr();

            btluu.Enabled = false;
            btsua.Enabled = true;
            btmoi.Enabled = false;


            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            try
            {
                sophieufind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();
                storelocationfind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["Store"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //     this.phieuchiid = 0;
            }

            #region loaddead so phieu va location
            #region // head 
            //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();

            var rs = (from pp in dc.tbl_MKt_Listphieuheads
                      where pp.Gate_pass == sophieufind && pp.ShippingPoint == storelocationfind

                      select pp).FirstOrDefault();

            if (rs != null)
            {
                this.sophieu = sophieufind;
                lbgatepassno.Text = this.sophieu;

                txtdiachi.Text = rs.Address;
                txtcustcode.Text = rs.Customer_SAP_Code.ToString();// = double.Parse(txtcustcode.Text);
                txtnguoinhan.Text = rs.Receiver_by;// = 

                datepickngayphieu.Value = (DateTime)rs.Ngaytaophieu;// = ;
                txtmucdichname.Text = rs.Purpose;//= ;
                txtmact.Text = rs.Purposeid;//=;
                this.storelocation = rs.ShippingPoint;// = ;




                //  cbkhohang.Items
                foreach (ComboboxItem item in (List<ComboboxItem>)cbkhohang.DataSource)
                {
                    if (item.Value.ToString().Trim() == rs.ShippingPoint.Trim())
                    {
                        cbkhohang.SelectedItem = item;
                    }
                }

                txtnguoiyeucau.Text = rs.Requested_by;// = ;
                                                      //   rs.Status = "CRT";
                lbgatepassno.Text = this.sophieu;

                lbtel.Text = rs.Tel;// = ;
                                    //  rs.Username = this.Username;
                                    //   dc.SubmitChanges();


            }


            #endregion


            #endregion

            #region load detail so phieu va loacation
            var rs2 = from pp in dc.tbl_MKt_Listphieus
                      where pp.Gate_pass == sophieufind && pp.ShippingPoint == storelocationfind

                      select pp;

            if (rs2.Count() > 0)
            {
                cleartoblankDEtailphieu();
                foreach (var item in rs2)
                {
                    addDEtailPhieuMKT(item);
                    //  xxx



                }

            }

            #endregion

            tabControl1.SelectedTab = tabPage1;
        }

        private void txtsotien_TextChanged_1(object sender, EventArgs e)
        {







        }

        private void dataGridViewListphieuchi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //dt.Columns.Add(new DataColumn("Material_code", typeof(string)));
            //dt.Columns.Add(new DataColumn("SAP_Code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Description", typeof(string)));
            //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(int)));










        }

        private void dataGridViewDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDetail_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabIndex == 2) //  Danh sách phiếu

            {
                // string valueinput = cb_customerka.Text;

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string username = Utils.getusername();


                var rs = from pp in dc.tbl_MKt_Listphieus
                         where pp.Status == "CRT"
                         select new
                         {
                             Date = pp.Ngaytaophieu,
                             pp.Region,
                             pp.Gate_pass,
                             pp.Requested_by,
                             pp.Purpose,


                             pp.Receiver_by,
                             pp.Customer_SAP_Code,
                             pp.Address,
                             pp.Materiacode,
                             //  pp.MateriaSAPcode,
                             pp.Description,
                             pp.Issued,

                             Store = pp.ShippingPoint,
                             Created_by = pp.Username,
                             pp.id,

                         };
                dataGridViewListphieu.DataSource = rs;





            }
        }

        private void dataGridViewDetail_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridViewDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{



        }

        private void cbkhohang_SelectedValueChanged(object sender, EventArgs e)
        {
            this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();

            cleartoblankDEtailphieu();
        }

        private void txtmucdich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;

                string seachtext = txtmucdichname.Text;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs = from pp in dc.tbl_MKT_Mucdiches
                         where pp.tenCT.Contains(seachtext)
                         select new
                         {
                             MÃ_CHƯƠNG_TRÌNH = pp.macT,
                             TÊN_CHƯƠNG_TRÌNH = pp.tenCT,



                             pp.id,

                         };

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT PURPOSE ", "MKT");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_Mucdiches
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {

                    txtmact.Text = rs2.macT;
                    txtmucdichname.Text = rs2.tenCT;

                }







                dataGridViewDetail.Focus();

            }

        }

        private void btmucdich_Click(object sender, EventArgs e)
        {
            if (Model.Username.getIOcreateRight() == true)
            {

                string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.DanhsachctMKT(dc);


            Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH CHƯƠNG TRÌNH MAKETTING", 13, "MKT_CT");// mã 13 là danh sach CT MKT

            viewtbl.Show();

            }
            else
            {
                View.MKTNoouthourise noquyen = new MKTNoouthourise();
                noquyen.ShowDialog();
            };





        }

        private void btcustomer_Click(object sender, EventArgs e)
        {

            //    NPDanhsachnhavantai
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.danhkhachhang(dc);
            Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH NGƯỜI NHẬN ", 12, "MKT_KH");// mã 12 là danh sach khách hàng MKT

            viewtbl.Show();



           
        }

        private void txtmucdichname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            bool kq = Model.MKT.Deletephieu(this.sophieu, this.storelocation);
            if (kq)
            {
                MessageBox.Show("Delete " + this.sophieu.ToString() + " done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtnguoinhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //  cbsophieu.

                string seachtext = txtnguoinhan.Text;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs = from pp in dc.tbl_MKT_Soldtocodes
                         where pp.FullNameN.Contains(seachtext)
                         select new
                         {
                             MÃ_KHÁCH_HÀNG = pp.Customer,
                             TÊN_KHÁCH_HÀNG = pp.FullNameN,
                             ĐỊA_CHỈ = pp.Street+" "+ pp.District +" "+pp.City,
                             QUẬN = pp.District,
                             TỈNH_THÀNH_PHỐ = pp.City,
                             ĐIỆN_THOẠI = pp.Telephone1,
                             GHI_CHÚ = pp.Note,




                             ID =    pp.id,

                         };

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT RECIPIENTS", "MKT");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_Soldtocodes
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {
                    txtcustcode.Text = rs2.Customer;
                    txtnguoinhan.Text = rs2.FullNameN;
                    txtdiachi.Text = rs2.Street +" ,"+ rs2.District+" ,"+ rs2.City;
                    lbtel.Text = rs2.Telephone1;
             


                }





                txtmucdichname.Focus();


            }
        }
    }
}
