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
using Maketting.shared;

namespace Maketting.View
{
    public partial class MKTLoadcreated : Form
    {
        public int statusphieu { get; set; } // mới  // 2 suawra // 3 display //
                                             //   public string sophieuID { get; set; }
        public string soload { get; set; }
        public string storelocation { get; set; }
        public string Username { get; set; }
        public IQueryable rs { get; set; }
        public LinqtoSQLDataContext dc { get; set; }
        public double palletofLoad { get; set; }
        public string shipmentghep { get; set; }
        //  public string isGheplI { get; set; }





        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        public void addDEtailLoad(tbl_MKt_Listphieudetail PhieuMKT)
        {


            //DataTable dt = new DataTable();


            //dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            //dt.Columns.Add(new DataColumn("Address", typeof(string)));


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            //---------------

            DataTable dataTable = (DataTable)dataGridViewLoaddetail.DataSource;

            DataRow drToAdd = dataTable.NewRow();

            drToAdd["Gate_pass"] = PhieuMKT.Gate_pass;
            drToAdd["Customer_Code"] = PhieuMKT.Customer_SAP_Code;
            drToAdd["Receiver_by"] = PhieuMKT.Receiver_by;
            drToAdd["Address"] = PhieuMKT.Address;
            drToAdd["Materiacode"] = PhieuMKT.Materiacode;
            drToAdd["Materialname"] = PhieuMKT.Materialname;
            drToAdd["Issued"] = PhieuMKT.Issued;
            if (PhieuMKT.pallet != null)
            {
                this.palletofLoad = this.palletofLoad + double.Parse(PhieuMKT.pallet.ToString());
                txtPallet.Text = this.palletofLoad.ToString("0.000", CultureInfo.InvariantCulture);
            }


            dataTable.Rows.Add(drToAdd);
            dataTable.AcceptChanges();

       



        }
        //  RemoveDEtailLoad(item);
        public void RemoveDEtailLoad(tbl_MKt_Listphieudetail PhieuMKT)
        {


            //DataTable dt = new DataTable();


            //dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            //dt.Columns.Add(new DataColumn("Address", typeof(string)));


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            //---------------

            DataTable dataTable = (DataTable)dataGridViewLoaddetail.DataSource;


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if ((string)dataTable.Rows[i]["Gate_pass"] == PhieuMKT.Gate_pass)
                {
                    dataTable.Rows.RemoveAt(i);
                }
            }
            dataTable.AcceptChanges();


            if (PhieuMKT.pallet != null)
            {
                this.palletofLoad = this.palletofLoad - double.Parse(PhieuMKT.pallet.ToString());
                txtPallet.Text = this.palletofLoad.ToString("0.000", CultureInfo.InvariantCulture);
            }



          


        }



        public void reloadseachview(string nguoinop, string diachi, string noidung)
        {



            //     dataGridViewListphieuchi.DataSource = Model.Phieuthuchi.reloadseachview("PC", nguoinop, diachi, noidung);


        }

        public void cleartoblankphieu()
        {

            #region  list black phiếu
            datecreated.Enabled = true;
            cbGhepshipment.CheckState = CheckState.Checked;
            txtShipment.Text = "";

            txtmaNVT.Text = "";
            txtmaNVT.Enabled = false;
            //txttrucno.Text = "";

            txtnguoitaoload.Enabled = true;
            txttenNVT.Enabled = true;


            btluu.Visible = true;
            btluu.Enabled = true;
            //    cbtaikhoanco.Enabled = true;

            btsua.Enabled = false;


            txtnguoitaoload.Text = "";
            txttenNVT.Text = "";
            txttrucnumber.Text = "";

            txtnguoitaoload.Text = Utils.getname();


            //     txtloadnumber.Text = "";
            datecreated.Value = DateTime.Today;

            txtnguoitaoload.Focus();
            //  txtPallet.ForeColor
            //this.lb_totalrecord.Text = dataGridView1.RowCount.ToString("#,#", CultureInfo.InvariantCulture);// ;//String.Format("{0:0,0}", k33q); 
            //                                                                                                //  this.lb_totalrecord.ForeColor = Color.Chocolate;
            //                                                                                                //   this.Show();

            //     cbkhohang.Items.Clear();

            //   List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            string username = Utils.getusername();
            this.Username = username;
            this.shipmentghep = "";
            this.palletofLoad = 0;
            //this.matk = taikhoan;


            Model.MKT.DeleteALLLoadtamTMP();

            //            Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);


            dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation, dc);

            //   dataGridViewDetail.Columns(3).DefaultCellStyle.Format = "#.###";
            dataGridViewDetail.Columns["pallet"].DefaultCellStyle.Format = "N3";



            dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);

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

        public MKTLoadcreated(View.Main Main)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);  // để đọc từ bàn phím phím tắt


            this.main1 = Main;

            //    cbGhepshipment.CheckState = CheckState.Checked;
            cbGhepshipment.Checked = true;

            this.statusphieu = 1; // tạo mới


            Model.MKT.restatusphieuLoadingtoCRT();

            Model.MKT.updatePalleCRTorder();  // để update toàn bộ palet cho crt oeerder

            cleartoblankphieu();

            string rightkho = Model.Username.getmaquyenkho();

            List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            this.dc = dc;
            //   string username = Utils.getusername();
            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                      where (from gg in dc.tbl_MKT_StoreRights
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
           // cbkhohang.SelectedIndex = ;
            this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();


            this.soload = Model.MKT.getLoadNo();
            txtloadnumber.Text = this.soload;
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
                txtnguoitaoload.Focus();

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
                txttenNVT.Focus();

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
                txttenNVT.Focus();

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
                datecreated.Focus();
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
            // ;

            bool checkdetail = true;
            bool checkhead = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);




            if (this.statusphieu == 1)
            {


                var rs5 = (from pp in dc.tbl_MKt_ListLoadheads
                           where pp.id.ToString() == this.soload && pp.Status != "TMP"

                           select pp).FirstOrDefault();
                if (rs5 != null)
                {
                    MessageBox.Show("Can not created, dublicate found !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                    checkhead = false;
                    return;
                  
                }
            }

            #region  // check head

            if (txttrucnumber.Text == "")
            {
                MessageBox.Show("Pleae input truck number", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttrucnumber.Focus();
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


            if (txtmaNVT.Text == "")
            {
                MessageBox.Show("Pleae select a transposter !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenNVT.Focus();
                checkhead = false;
                return;
            }

            if (!Utils.IsValidnumber(txtShipment.Text.ToString()) && cbGhepshipment.Checked == true)
            {
                MessageBox.Show("Pleae nhập số shipmentghep ghép là số shipmentghep chở hàng có ghéo chở đồ MKT !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShipment.Focus();
                checkhead = false;
                return;
            }

            if (txtShipment.Text != "" && cbGhepshipment.Checked == false)
            {
                MessageBox.Show("Please xóa số shipmentghep nếu là xe chạy trực tiếp !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShipment.Focus();
                checkhead = false;
                return;
            }


            if (txtShipment.Text == "" && cbGhepshipment.Checked == true)
            {
                MessageBox.Show("Pleae nhập số shipmentghep ghép !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShipment.Focus();
                checkhead = false;
                return;
            }
            //            txtShipment


            #endregion


            #region  //check detai từng dòng

            if (dataGridViewLoaddetail.RowCount == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                checkdetail = false;
                return;
            }




            #endregion

            if (checkdetail && checkhead)
            {

                #region



                if (this.statusphieu == 2)
                {
                    var updateblank = from pp in dc.tbl_MKt_Listphieudetails
                                      where pp.ShipmentNumber == this.soload
                                      && pp.ShippingPoint == this.storelocation
                                      select pp;
                    foreach (var item in updateblank)
                    {
                        item.Status = "CRT";
                        item.Tranposterby = "";
                        item.Truck = "";
                        item.ShipmentNumber = "";
                        item.Shipmentby = "";
                       
                        dc.SubmitChanges();
                    }

                    var updateblankhead = from pp in dc.tbl_MKt_Listphieuheads
                                          where pp.LoadNumber == this.soload
                                      && pp.ShippingPoint == this.storelocation
                                          select pp;
                    foreach (var item in updateblankhead)
                    {
                        item.Status = "CRT";
                        item.Tranposterby = "";
                        item.LoadNumber = "";
                        item.Trucknumber = "";
                      
                      
                        dc.SubmitChanges();
                    }


                    var deletelistload = from pp in dc.tbl_MKt_ListLoadheadDetails
                                         where pp.LoadNumber == this.soload
                                      && pp.ShippingPoint == this.storelocation
                                      && pp.Status == "CRT"
                                         select pp;

                    dc.tbl_MKt_ListLoadheadDetails.DeleteAllOnSubmit(deletelistload);
                    dc.SubmitChanges();


                }
                #endregion

                #region // head 
                //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();
                btluu.Enabled = false;
                var rs = (from pp in dc.tbl_MKt_ListLoadheads
                          where pp.id.ToString() == this.soload// && pp.Status == "TMP"

                          select pp).FirstOrDefault();

                if (rs != null)
                {

                    rs.TransposterCode = txtmaNVT.Text.Truncate(50);
                    rs.TransposterName = txttenNVT.Text.Truncate(50);
                    rs.Date_Created = datecreated.Value;
                    rs.Truckno = txttrucnumber.Text.Truncate(50);

                    rs.ShippingPoint = this.storelocation;
                    rs.Created_by = txtnguoitaoload.Text.Truncate(50);
                    rs.Status = "CRT";
                    rs.LoadNumber = this.soload;
                    rs.pallet = this.palletofLoad;

                    rs.Username = this.Username;
                    dc.SubmitChanges();

                }


                #endregion

                #region // detail
                for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)
                {
                    if (dataGridViewLoaddetail.Rows[idrow].Cells["Gate_pass"].Value != DBNull.Value)
                    {
                        string gatepass = dataGridViewLoaddetail.Rows[idrow].Cells["Gate_pass"].Value.ToString();

                        var rs3 = from pp in dc.tbl_MKt_Listphieudetails
                                  where pp.Gate_pass == gatepass  && pp.ShippingPoint == this.storelocation
                                  select pp;
                        foreach (var item in rs3)
                        {
                            item.Status = "Shipping";
                            item.Tranposterby = txttenNVT.Text.Truncate(50);
                            item.Truck = txttrucnumber.Text.Truncate(50);
                            item.ShipmentNumber = this.soload;
                            item.Shipmentby = this.Username;
                            item.Delivery_date = DateTime.Today;
                            item.Included_Shipment = this.shipmentghep;
                            //    item.ShipmentNumber = this.soload;

                            dc.SubmitChanges();
                        }



                        #region // head list phieu
                        //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();
                        //    btluu.Enabled = false;
                        var rs2 = from pp in dc.tbl_MKt_Listphieuheads
                                  where pp.Gate_pass == gatepass && pp.ShippingPoint == this.storelocation
                                  select pp;

                        foreach (var item in rs2)
                        {
                            item.LoadNumber = this.soload;
                            item.Status = "Shipping";
                            item.Tranposterby = txttenNVT.Text.Truncate(50);
                            item.Trucknumber = txttrucnumber.Text.Truncate(50);


                            dc.SubmitChanges();

                        }


                        #endregion




                    }
                }

                #endregion

                #region  update tbl_MKt_ListLoadheadDetail
                //     btluu.Enabled = false;

                var rs4 = from pp in dc.tbl_MKt_Listphieudetails
                          where pp.ShipmentNumber == this.soload
                          && pp.ShippingPoint == this.storelocation
                          group pp by pp.Materiacode into gg

                          select new
                          {
                              Issued = gg.Sum(m => m.Issued),
                              Materiacode = gg.Key,//       gg.FirstOrDefault().Materiacode,
                              Materialname = gg.Select(m => m.Materialname).FirstOrDefault(),



                          };
                //   int i = 0;
                foreach (var item in rs4)
                {
                    //   i = i + 1;

                    tbl_MKt_ListLoadheadDetail loaddetail = new tbl_MKt_ListLoadheadDetail();

                    //   loaddetail.stt = i.ToString();
                    loaddetail.LoadNumber = this.soload;
                    loaddetail.Username = this.Username;
                    loaddetail.Materiacode = item.Materiacode.Truncate(50);
                    loaddetail.Materialname = item.Materialname.Truncate(225);
                    // loaddetail.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));
                    loaddetail.Serriload = this.storelocation + this.soload;
                    loaddetail.ShippingPoint = this.storelocation;
                    loaddetail.Issued = item.Issued;
                    loaddetail.Status = "CRT";



                    dc.tbl_MKt_ListLoadheadDetails.InsertOnSubmit(loaddetail);
                    dc.SubmitChanges();

                }




                #endregion



                this.statusphieu = 1;
                MessageBox.Show("Load " + this.soload.ToString() + " create done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  cleartoblankphieu();



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
            Model.MKT.restatusphieuLoadingtoCRT();
            this.statusphieu = 1;
            this.cleartoblankphieu();
            this.palletofLoad = 0;
            txtPallet.Text = this.palletofLoad.ToString("0.000", CultureInfo.InvariantCulture);
            Model.MKT.DeleteALLphieutamTMP();

            this.soload = Model.MKT.getLoadNo();
            txtloadnumber.Text = this.soload;
            btluu.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //   string username = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rptMKT = from pp in dc.tbl_MKT_LoadHeadRpts
                         where pp.username == this.Username
                         select pp;

            dc.tbl_MKT_LoadHeadRpts.DeleteAllOnSubmit(rptMKT);
            dc.SubmitChanges();


            var rptMKTdetail = from pp in dc.tbl_MKT_LoaddetailRpts
                               where pp.Username == this.Username
                               select pp;

            dc.tbl_MKT_LoaddetailRpts.DeleteAllOnSubmit(rptMKTdetail);
            dc.SubmitChanges();


            string gatepasslist = "";
            var rptMKTdetailmk1 = from pp in dc.tbl_MKt_Listphieudetails
                                  where pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation
                                  group pp by pp.Gate_pass into gg
                                  select gg;
            int dem = 0;
            foreach (var item in rptMKTdetailmk1)
            {
                dem = dem + 1;
                if (dem == 1)
                {
                    gatepasslist = gatepasslist + item.Key;
                }
                if (dem > 1)
                {
                    gatepasslist = gatepasslist + ", " + item.Key;
                }

            }


            var rptMKTdetailmk = from pp in dc.tbl_MKt_Listphieudetails
                                 where pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation
                                 group pp by pp.Materiacode into gg
                                 select new
                                 {
                                     Issued = gg.Sum(m => m.Issued),
                                     Materiacode = gg.Key,//       gg.FirstOrDefault().Materiacode,
                                     Materialname = gg.Select(m => m.Materialname).FirstOrDefault(),

                               //      palletnumber = gg.Sum(m => m.pallet),

                                 };

       ///     [pallet]
        int i = 0;
            foreach (var item in rptMKTdetailmk)
            {
                if (item.Issued >0)
                {
                    i = i + 1;

                    tbl_MKT_LoaddetailRpt detailpx = new tbl_MKT_LoaddetailRpt();

                    detailpx.stt = i.ToString();
                    detailpx.soluong = item.Issued;
                    detailpx.Username = this.Username;
                    detailpx.materialcode = item.Materiacode;
                    detailpx.tensanpham = item.Materialname;
                    detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));


                    dc.tbl_MKT_LoaddetailRpts.InsertOnSubmit(detailpx);
                    dc.SubmitChanges();
                }
            

            }








            var rptMKThead = (from pp in dc.tbl_MKt_ListLoadheads
                              where pp.LoadNumber == this.soload && pp.ShippingPoint == this.storelocation
                              select pp).FirstOrDefault();

            if (rptMKThead != null)
            {
                tbl_MKT_LoadHeadRpt headpx = new tbl_MKT_LoadHeadRpt();

                headpx.codetransporter = rptMKThead.TransposterCode;
                headpx.gatepasslist = gatepasslist.Truncate(500);
                headpx.username = this.Username;

                headpx.pallet = rptMKThead.pallet;
                headpx.Loadnumber = rptMKThead.LoadNumber;
                headpx.nametransporter = rptMKThead.TransposterName;
                headpx.seri = this.storelocation + rptMKThead.LoadNumber;

                BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(this.storelocation + rptMKThead.LoadNumber), 1, true), typeof(Byte[]));

                headpx.Barcode = result;
                headpx.Ngaythang = rptMKThead.Date_Created;
                headpx.shippingpoint = rptMKThead.ShippingPoint;

              //   headpx.tr = rptMKThead.Truckno;



                dc.tbl_MKT_LoadHeadRpts.InsertOnSubmit(headpx);
                dc.SubmitChanges();

            }

            //    //var q3 = (from tblEDLP in dc.tblEDLPs
            //    //          group tblEDLP by tblEDLP.Invoice_Doc_Nr into OD//Tương đương GROUP BY trong SQL
            //    //          orderby OD.Key
            //    //          where !(from tblVat in dc.tblVats
            //    //                  select tblVat.SAP_Invoice_Number).Contains(OD.Key)

            //    //          select new
            //    //          {
            //    //              Document_Number = OD.Key,
            //    //              Name = OD.Select(m => m.Cust_Name).FirstOrDefault(),
            //    //              Value_Count = OD.Sum(m => m.Cond_Value)




            //    //          });


            var rshead = from pp in dc.tbl_MKT_LoadHeadRpts
                         where pp.username == this.Username
                         select new
                         {
                             Loadcreatebby = pp.Loadcreatebby,
                             codetransporter = pp.codetransporter,
                             shippingpoint = pp.shippingpoint,
                             Ngaythang = pp.Ngaythang,
                             Loadnumber = pp.Loadnumber,
                             nametransporter = pp.nametransporter,
               //               Truckno = pp.tr,
                             gatepasslist = pp.gatepasslist,
                             seri = pp.seri,
                             Barcode = pp.Barcode,

                             pallet = pp.pallet,
                         };
            Utils ut = new Utils();
            var dataset1 = ut.ToDataTable(dc, rshead); // head

            //View.Viewtable vx1 = new Viewtable(rshead, dc, "test", 100, "100");
            //vx1.ShowDialog();
            var rsdetail = from pp in dc.tbl_MKT_LoaddetailRpts
                           where pp.Username == this.Username
                           orderby pp.stt
                           select new
                           {

                               stt = pp.stt,
                               tensanpham = pp.tensanpham,
                               materialcode = pp.materialcode,
                               soluong = pp.soluong,
                               //   username = pp.Username,
                               bangchu = pp.bangchu,

                           };

            //View.Viewtable vx = new Viewtable(rsdetail,dc,"test",100,"100");
            //vx.ShowDialog();


            var dataset2 = ut.ToDataTable(dc, rsdetail); // detail


            Reportsview rpt = new Reportsview(dataset1, dataset2, "PhieuMKLoad.rdlc");
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
                this.soload = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Gate_pass"].Value;
                this.storelocation = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Store"].Value;

           
            }
            catch (Exception)
            {

                //     this.phieuchiid = 0;
            }




        }

        private void dataGridViewListphieuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxoa_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.soload = txtloadnumber.Text;

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs3 = (from pp in dc.tbl_MKt_WHstoreissues
                       where pp.LoadNumber == this.soload && pp.ShippingPoint == this.storelocation
                       select pp.LoadNumber).FirstOrDefault();

            if (rs3 != null)
            {
                MessageBox.Show("LoadNumber " + soload + " can not change by store issued !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            this.statusphieu = 2;
            btluu.Enabled = true;
            btmoi.Enabled = true;
            btxoa.Enabled = true;

            datecreated.Enabled = true;




            txtnguoitaoload.Enabled = true;
            txttenNVT.Enabled = true;


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
                txtnguoitaoload.Focus();

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
                txttenNVT.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {

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

            //  addDEtailPhieuMKT


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


            //var rs = from pp in dc.tbl_MKt_ListLoadheads
            //         where pp.ShippingPoint == this.storelocation //pp.Status == "CRT" && 
            //         select new
            //         {
            //             Date = pp.Date_Created,

            //             pp.LoadNumber,
            //             pp.ShippingPoint,


            //             pp.Status,
            //             pp.TransposterCode,
            //             pp.TransposterName,

            //             Created_by = pp.Username,
            //             pp.id,

            //         };


            string shipmentfind = "";
            string ShippingPointfind = "";
            this.palletofLoad = 0;
            string connection_string = Utils.getConnectionstr();

            //btluu.Enabled = false;
            //btsua.Enabled = true;
            //btmoi.Enabled = false;


            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            try
            {
                shipmentfind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["LoadNumber"].Value.ToString();
                ShippingPointfind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["ShippingPoint"].Value.ToString();

            }
            catch (Exception)
            {
                //    MessageBox.Show(ex.ToString());
                //     this.phieuchiid = 0;
            }

            #region loaddead so phieu va location
            #region // head 
            //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();

            var rs = (from pp in dc.tbl_MKt_ListLoadheads
                      where pp.LoadNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

                      select pp).FirstOrDefault();

            if (rs != null)
            {
                this.soload = shipmentfind;
                txtloadnumber.Text = this.soload;


                txtmaNVT.Text = rs.TransposterCode.ToString();// = double.Parse(txtcustcode.Text);
                txttenNVT.Text = rs.TransposterName;// = 
                txttrucnumber.Text = rs.Truckno;

                datecreated.Value = (DateTime)rs.Date_Created;// = ;

                this.storelocation = rs.ShippingPoint;// = ;




                //  cbkhohang.Items
                foreach (ComboboxItem item in (List<ComboboxItem>)cbkhohang.DataSource)
                {
                    if (item.Value.ToString().Trim() == rs.ShippingPoint.Trim())
                    {
                        cbkhohang.SelectedItem = item;
                    }
                }

                txtnguoitaoload.Text = rs.Created_by;// = ;
                                                     //   rs.Status = "CRT";
                txtloadnumber.Text = this.soload;




            }


            #endregion


            #endregion
            //     public void addDEtailLoad(tbl_MKt_Listphieu PhieuMKT)
            //{
            dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);

            #region load detail so phieu va loacation
            var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                      where pp.ShipmentNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

                      select pp;

            if (rs2.Count() > 0)
            {
                ///cleartoblankDEtailphieu();
                foreach (var item in rs2)
                {
                    addDEtailLoad(item);



                }

            }

            #endregion
            btluu.Enabled = false;
            btsua.Enabled = true;
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
            if (tabControl1.SelectedTab.Name == "tabPage1") // all Danh sách phiếu

            {


                //    dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);

            }

            if (tabControl1.SelectedTab.Name == "tabPage2") // all Danh sách phiếu

            {
                // string valueinput = cb_customerka.Text;

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string username = Utils.getusername();


                var rs = from pp in dc.tbl_MKt_ListLoadheads
                         where pp.ShippingPoint == this.storelocation //;//&& pp.Status == "CRT"
                         && pp.Status == "CRT"
                         select new
                         {
                             Date = pp.Date_Created,

                             pp.LoadNumber,
                             pp.ShippingPoint,


                             pp.Status,
                             pp.TransposterCode,
                             pp.TransposterName,

                             Created_by = pp.Username,
                             pp.id,

                         };
                dataGridViewListphieu.DataSource = rs;





            }

            if (tabControl1.SelectedTab.Name == "tabPage3") // all Danh sách phiếu

            {
                // string valueinput = cb_customerka.Text;

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string username = Utils.getusername();


                var rs = from pp in dc.tbl_MKt_ListLoadheads
                         where pp.ShippingPoint == this.storelocation //;//&& pp.Status == "CRT"
                        // && pp.Status == "CRT"
                         select new
                         {
                             Date = pp.Date_Created,

                             pp.LoadNumber,
                             pp.ShippingPoint,


                             pp.Status,
                             pp.TransposterCode,
                             pp.TransposterName,

                             Created_by = pp.Username,
                             pp.id,

                         };
                dataGridViewALLLOAD.DataSource = rs;





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
            //   this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();
            this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            string username = Utils.getusername();

            var rs = from pp in dc.tbl_MKt_Listphieudetails
                     where pp.Username == username && pp.Status == "LOADING"
                    && pp.ShippingPoint == this.storelocation

                     select pp;

            if (rs != null)
            {
                foreach (var item in rs)
                {
                    //     item.Username = Username;
                    item.Status = "CRT";
                    dc.SubmitChanges();

                    //     addDEtailLoad(item);
                }



            }

            dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation, dc);
            dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);




        }

        private void txtmucdich_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void btmucdich_Click(object sender, EventArgs e)
        {
            //    NPDanhsachnhavantai
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.DanhsachctMKT(dc);


            Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH CHƯƠNG TRÌNH MAKETTING", 13, "MKT_CT");// mã 13 là danh sach CT MKT

            viewtbl.Show();





        }

        private void btcustomer_Click(object sender, EventArgs e)
        {

            //    NPDanhsachnhavantai
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.DanhsachnhavantaiMKT(dc);
            Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH NHÀ VẬN TẢI", 14, "MKT_nvt");// mã 14 là danh sach nha van tai  MKT

            viewtbl.Show();




        }

        private void txtmucdichname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs3 = (from pp in dc.tbl_MKt_WHstoreissues
                       where pp.LoadNumber == this.soload && pp.ShippingPoint == this.storelocation
                       select pp.LoadNumber).FirstOrDefault();

            if (rs3 != null)
            {
                MessageBox.Show("LoadNumber " + soload + " can not delete  by store issued !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            

            bool kq = Model.MKT.Deletephieuload(this.soload, this.storelocation);
            Model.MKT.restatusphieuLoadingtoCRT();

            //  Model.MKT.DeleteALLphieutamTMP();

            dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation, dc);
            dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);



            if (kq)
            {
                MessageBox.Show("Delete " + this.soload.ToString() + " done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtnguoinhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //  cbsophieu.

                string seachtext = txttenNVT.Text;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs = from pp in dc.tbl_MKT_Nhacungungvantais
                         where pp.tenNVT.Contains(seachtext)
                         select new
                         {
                             MÃ_NHÀ_VẬN_TẢI = pp.maNVT,
                             TÊN_NHÀ_VẬN_TẢI = pp.tenNVT,
                             ĐỊA_CHỈ = pp.diachiNVT,
                             ĐIỆN_THOẠI = pp.dienthoaiNVT,



                             pp.id,

                         };

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT TRANSPORTER", "MKT_vt");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_Nhacungungvantais
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {
                    txtmaNVT.Text = rs2.maNVT;
                    txttenNVT.Text = rs2.tenNVT;



                }





                txttrucnumber.Focus();


            }
        }

        private void dataGridViewDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //     addDEtailPhieuMKT
            string gatepassfind = "";

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            try
            {
                gatepassfind = this.dataGridViewDetail.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }



            //DataTable dt = new DataTable();


            //dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            //dt.Columns.Add(new DataColumn("Address", typeof(string)));

            var rs = from pp in dc.tbl_MKt_Listphieudetails
                     where pp.Gate_pass == gatepassfind && pp.ShippingPoint == this.storelocation && pp.Status == "CRT"

                     select pp;

            if (rs != null)
            {
                foreach (var item in rs)
                {
                    item.Username = Username;
                    item.Shipmentby = Username;
                    item.Status = "LOADING";
                    dc.SubmitChanges();

                    addDEtailLoad(item);


                }



            }

            //     dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);
            //     x
            //   dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);
            Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);

            // String.Format("{0:0.##}", 123.4567);
            txtPallet.Text = this.palletofLoad.ToString("0.000", CultureInfo.InvariantCulture);

        }

        private void dataGridViewLoaddetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLoaddetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.statusphieu != 2)
            {
                return;
            }

            string gatepassfind = "";

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            try
            {
                gatepassfind = this.dataGridViewLoaddetail.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }



            //DataTable dt = new DataTable();


            //dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            //dt.Columns.Add(new DataColumn("Address", typeof(string)));

            var rs = from pp in dc.tbl_MKt_Listphieudetails
                     where pp.Gate_pass == gatepassfind && pp.ShippingPoint == this.storelocation //&& pp.Status == "LOADING"

                     select pp;

            if (rs != null)
            {
                foreach (var item in rs)
                {
                    RemoveDEtailLoad(item);
                    item.Status = "CRT";
                    dc.SubmitChanges();


                }



            }

            dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation, dc);

            //    txtPallet.Text = this.palletofLoad.ToString();
            txtPallet.Text = this.palletofLoad.ToString("0.000", CultureInfo.InvariantCulture);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //   string username = Utils.getusername();
            #region in phiếu MKT
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

            var rptMKThead = from pp in dc.tbl_MKt_Listphieuheads

                             where pp.LoadNumber == this.soload && pp.ShippingPoint == this.storelocation
                          //   && pp.requestReturn == false
                             select pp;

            if (rptMKThead.Count() > 0)
            {

                foreach (var item in rptMKThead)
                {


                    tbl_MKT_headRpt_Phieuissue headpx = new tbl_MKT_headRpt_Phieuissue();

                    headpx.Diachi = item.ShiptoAddress;
                    headpx.Nguoinhancode = item.ShiptoCode.ToString();
                    headpx.Username = this.Username;
                    headpx.Sophieu = item.Gate_pass;
                    headpx.Nguoinhanname = item.ShiptoName;
                    headpx.seri = item.Region + this.storelocation + item.Gate_pass;

                    BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                    BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                    //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                    Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(item.Region + this.storelocation + item.Gate_pass), 1, true), typeof(Byte[]));

                    headpx.Barcode = result;
                    headpx.dienthoai = item.Tel;
                    headpx.mucdich = item.Purpose;
                    headpx.Ngaythang = item.Ngaytaophieu;
                    headpx.Nguoiyeucau = item.Requested_by;
                    headpx.thuhang = item.requestReturn; // có phải thu hàng hay không
                    headpx.ghichu = item.Note;


                    dc.tbl_MKT_headRpt_Phieuissues.InsertOnSubmit(headpx);
                    dc.SubmitChanges();
                }
            }



            var rptMKTdetailmk = from pp in dc.tbl_MKt_Listphieudetails
                                 where pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation

                                 orderby pp.Gate_pass
                                 select pp;
            int i = 0;
            string lastgatepass = "";
            foreach (var item in rptMKTdetailmk)
            {
                if (lastgatepass != item.Gate_pass)
                {
                    i = 1;
                }
                else
                {
                    i = i + 1;
                }


                tbl_MKT_DetailRpt_Phieuissue detailpx = new tbl_MKT_DetailRpt_Phieuissue();

                detailpx.stt = i.ToString();

                detailpx.Username = this.Username;
                detailpx.tensanpham = item.Materialname;
              
                detailpx.Sophieu = item.Gate_pass;
                lastgatepass = item.Gate_pass;


                if (item.Returnrequest >0 )
                {
                    detailpx.thuhang = true;
                    detailpx.soluong = item.Returnrequest;
                    detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Returnrequest.ToString()));
                }

                if (item.Issued > 0)
                {
                    detailpx.thuhang = false;
                    detailpx.soluong = item.Issued;
                    detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));
                }



                dc.tbl_MKT_DetailRpt_Phieuissues.InsertOnSubmit(detailpx);
                dc.SubmitChanges();

            }


            #region view phieu MKT



            var rshead = from pp in dc.tbl_MKT_headRpt_Phieuissues
                         where pp.Username == this.Username
                         && pp.thuhang == false
                         //orderby pp.Sophieu
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
                             ghichu = pp.ghichu,
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
                              && pp.thuhang == false
                           orderby pp.Sophieu, pp.stt
                           select new
                           {

                               stt = pp.stt,
                               tensanpham = pp.tensanpham,
                               Sophieu = pp.Sophieu,
                               soluong = pp.soluong,
                               //   username = pp.Username,
                               bangchu = pp.bangchu,

                           };

            //View.Viewtable vx = new Viewtable(rsdetail,dc,"test",100,"100");
            //vx.ShowDialog();


            var dataset2 = ut.ToDataTable(dc, rsdetail); // detail


            Reportsview rpt = new Reportsview(dataset1, dataset2, "PhieuMKTlistbyLoad.rdlc");
            rpt.Show();

            #endregion viewphieumakting




            #region view bien bản thu hàng



            var rshead2 = from pp in dc.tbl_MKT_headRpt_Phieuissues
                          where pp.Username == this.Username
                          && pp.thuhang == true
                          //orderby pp.Sophieu
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

            if (rshead2.Count() > 0)
            {



                Utils ut2 = new Utils();
                var dataset11 = ut.ToDataTable(dc, rshead2); // head

                //View.Viewtable vx1 = new Viewtable(rshead, dc, "test", 100, "100");
                //vx1.ShowDialog();
                var rsdetail2 = from pp in dc.tbl_MKT_DetailRpt_Phieuissues
                                where pp.Username == this.Username
                                   && pp.thuhang == true
                                orderby pp.Sophieu, pp.stt
                                select new
                                {

                                    stt = pp.stt,
                                    tensanpham = pp.tensanpham,
                                    Sophieu = pp.Sophieu,
                                    soluong = pp.soluong,
                                    //   username = pp.Username,
                                    bangchu = pp.bangchu,

                                };

                //View.Viewtable vx = new Viewtable(rsdetail,dc,"test",100,"100");
                //vx.ShowDialog();


                var dataset21 = ut.ToDataTable(dc, rsdetail2); // detail


                Reportsview rpt2 = new Reportsview(dataset11, dataset21, "PhieuMKTminutethuhanglistbyload.rdlc");
                rpt2.Show();
            }
            #endregion view bien ban thu hàng



            #endregion n phiếu MKT



            //#endregion view reports payment request  // 
        }

        private void txtseachgate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;


                txtseachaddress.Text = "";
                txtseachcode.Text = "";
                //       txtseachgate.Text
                //  this.storelocation
                //    dataGridViewDetail

                Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);


            }




        }

        private void txtseachcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;


                txtseachaddress.Text = "";
                //      txtseachcode.Text = "";
                txtseachgate.Text = "";
                //  this.storelocation
                //    dataGridViewDetail

                Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);


            }

        }

        private void txtseachaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;


                //     txtseachaddress.Text = "";
                txtseachcode.Text = "";
                txtseachgate.Text = "";
                //  this.storelocation
                //    dataGridViewDetail

                Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);


            }

        }

        private void bt_exporttoex_Click(object sender, EventArgs e)
        {
            Control_ac ctrex = new Control_ac();


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKt_Listphieudetails
                     from pp in dc.tbl_MKt_Listphieuheads
                         //        from ppp in dc.tbl_MKT_Soldtocodes
                     where p.ShippingPoint == storelocation && p.Status == "CRT"
                   && p.Gate_pass == pp.Gate_pass
                     //    && ((int)pp.Customer_SAP_Code).ToString().Trim() == ppp.Customer
                     orderby p.Gate_pass
                     select new
                     {
                         Customer_code = p.Customer_SAP_Code,
                         Shipto_code = pp.ShiptoCode,
                         p.Gate_pass,
                         pp.Region,
                         Shipto_City = p.shiptocity,
                         Shipto_Name = pp.ShiptoName, // p.Receiver_by,

                         Shipto_Address = pp.ShiptoAddress,//.Address,//.ShiptoAddress,



                         //    Địa_chỉ = pp.ShiptoAddress,

                         p.Materiacode,
                         p.Materialname,
                         Số_lượng_xuất = p.Issued,
                         Pallet = p.pallet,

                         p.Purpose,
                         p.Receiver_by,
                         p.Ngaytaophieu,
                         Điện_thoại = pp.Tel,

                         p.Description,



                         // p.Tel,

                         //     ID = p.id,
                     };

            ctrex.exportexceldatagridtofile(rs, dc, "DANH SÁCH ĐƠN HÀNG CHƯA GIAO !");





            //   ctrex.exportexceldatagridtofile(rs, dc, this.Text);

        }

        private void txttrucnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtShipment.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtShipment_TextChanged(object sender, EventArgs e)
        {
            // public string shipmentghep { get; set; }
            this.shipmentghep = txtShipment.Text;
            //    cbGhepshipment.Checked = false;
            //      cbGhepshipment.Checked = true;

        }

        private void txtloadnumber_TextChanged(object sender, EventArgs e)
        {
            this.soload = txtloadnumber.Text;
        }

        private void dataGridViewALLLOAD_Paint(object sender, PaintEventArgs e)
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

        private void dataGridViewALLLOAD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //var rs = from pp in dc.tbl_MKt_ListLoadheads
            //         where pp.ShippingPoint == this.storelocation //pp.Status == "CRT" && 
            //         select new
            //         {
            //             Date = pp.Date_Created,

            //             pp.LoadNumber,
            //             pp.ShippingPoint,


            //             pp.Status,
            //             pp.TransposterCode,
            //             pp.TransposterName,

            //             Created_by = pp.Username,
            //             pp.id,

            //         };


            string shipmentfind = "";
            string ShippingPointfind = "";
            this.palletofLoad = 0;
            string connection_string = Utils.getConnectionstr();

            //btluu.Enabled = false;
            //btsua.Enabled = true;
            //btmoi.Enabled = false;


            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            try
            {
                shipmentfind = this.dataGridViewALLLOAD.Rows[e.RowIndex].Cells["LoadNumber"].Value.ToString();
                ShippingPointfind = this.dataGridViewALLLOAD.Rows[e.RowIndex].Cells["ShippingPoint"].Value.ToString();

            }
            catch (Exception)
            {
                //    MessageBox.Show(ex.ToString());
                //     this.phieuchiid = 0;
            }

            #region loaddead so phieu va location
            #region // head 
            //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();

            var rs = (from pp in dc.tbl_MKt_ListLoadheads
                      where pp.LoadNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

                      select pp).FirstOrDefault();

            if (rs != null)
            {
                this.soload = shipmentfind;
                txtloadnumber.Text = this.soload;


                txtmaNVT.Text = rs.TransposterCode.ToString();// = double.Parse(txtcustcode.Text);
                txttenNVT.Text = rs.TransposterName;// = 
                txttrucnumber.Text = rs.Truckno;

                datecreated.Value = (DateTime)rs.Date_Created;// = ;

                this.storelocation = rs.ShippingPoint;// = ;




                //  cbkhohang.Items
                foreach (ComboboxItem item in (List<ComboboxItem>)cbkhohang.DataSource)
                {
                    if (item.Value.ToString().Trim() == rs.ShippingPoint.Trim())
                    {
                        cbkhohang.SelectedItem = item;
                    }
                }

                txtnguoitaoload.Text = rs.Created_by;// = ;
                                                     //   rs.Status = "CRT";
                txtloadnumber.Text = this.soload;




            }


            #endregion


            #endregion
            //     public void addDEtailLoad(tbl_MKt_Listphieu PhieuMKT)
            //{
            dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);

            #region load detail so phieu va loacation
            var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                      where pp.ShipmentNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

                      select pp;

            if (rs2.Count() > 0)
            {
                ///cleartoblankDEtailphieu();
                foreach (var item in rs2)
                {
                    addDEtailLoad(item);



                }

            }

            #endregion
            btluu.Enabled = false;
            btsua.Enabled = true;
            tabControl1.SelectedTab = tabPage1;
        }
    }

}
