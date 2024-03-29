﻿using Maketting.shared;
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
    public partial class MKTissuereturnRequest : Form
    {
        public int statusphieu { get; set; } // mới  // 2 suawra // 3 display //
                                             //   public string sophieuID { get; set; }
        public string sophieu { get; set; }
        public string storelocation { get; set; }
        public string region { get; set; }
        public string Username { get; set; }
        public string ProgrameIDDocno { get; set; }
        public string IO_number { get; set; }

        //  public string Customercode { get; set; }

        public double POSMisuevalue { get; set; }
        public double Programebudgetbalance { get; set; }
        public double Customerbugetioaproval { get; set; }
        public double Customerbugetioused { get; set; }
        public double Customerbugetiobalance { get; set; }


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
            this.POSMisuevalue = 0;
            this.Programebudgetbalance = 0;
            this.Customerbugetioaproval = 0;
            this.Customerbugetioused = 0;
            this.Customerbugetiobalance = 0;




            #region  list black phiếu


            dataGridViewDetail = Model.MKT.Loadnewdetailcollectrequest(dataGridViewDetail);



            #endregion


        }

        public void addDEtailPhieuMKT(tbl_MKt_Listphieudetail PhieuMKT)
        {




            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            //---------------

            DataTable dataTable = (DataTable)dataGridViewDetail.DataSource;

            DataRow drToAdd = dataTable.NewRow();

            drToAdd["MATERIAL"] = PhieuMKT.Materialname;
            drToAdd["Description"] = PhieuMKT.Description;
            drToAdd["ITEM_Code"] = PhieuMKT.Materiacode;
            drToAdd["Sap_Code"] = PhieuMKT.MateriaSAPcode;
            drToAdd["Unit"] = PhieuMKT.Unit;
            //   drToAdd["Material_Name"] = PhieuMKT.Materialname;

            if (PhieuMKT.Returnrequest != null)
            {
                drToAdd["Request_collect_Quantity"] = PhieuMKT.Returnrequest;
            }
            else
            {
                drToAdd["Request_collect_Quantity"] = 0;
            }
            //     drToAdd["Available_Quantity"] = Model.MKT.getAvailable_Quantity(PhieuMKT.Materiacode, this.storelocation) + PhieuMKT.Issued;
            //   drToAdd["Region_Balance"] = Model.MKT.getBalancebuget(PhieuMKT.Materiacode, this.region, this.storelocation);
            //   drToAdd["Material_Name"] = PhieuMKT.Materialnam

            //     drToAdd["Region_Balance"] = PhieuMKT.Region;


            dataTable.Rows.Add(drToAdd);
            dataTable.AcceptChanges();




        }



        public void reloadseachview(string nguoinop, string diachi, string noidung)
        {



            //     dataGridViewListphieuchi.DataSource = Model.Phieuthuchi.reloadseachview("PC", nguoinop, diachi, noidung);


        }

        public void cleartoblankphieu()
        {

            #region  list black phiếu

            this.IO_number = "";
            this.ProgrameIDDocno = "";

            datepickngayphieu.Enabled = true;
            txtNote.Text = "";


            txtcustcode.Text = "";
            txtcustcode.Enabled = false;


            txtdiachi.Text = "";
            txtdiachi.Enabled = false;


            txtShiptoCode.Text = "";
            txtShiptoCode.Enabled = false;

            txtshiptocodeseach.Text = "";
            txtshiptocodeseach.Enabled = true;

            txtshiptoaddress.Text = "";
            txtshiptoname.Text = "";

            txtshiptoaddress.Enabled = false;

            //       public double POSMisuevalue { get; set; }
            //public double Programebudgetbalance { get; set; }
            //public double Customerbugetioaproval { get; set; }
            //public double Customerbugetioused { get; set; }
            //public double Customerbugetiobalance { get; set; }

            //txtcustomerbudget.Text = this.Customerbugetioaproval.ToString("#,#", CultureInfo.InvariantCulture);
            //txtcustomerbudgetuse.Text = this.Customerbugetioused.ToString("#,#", CultureInfo.InvariantCulture);
            //txtcustomerbudgetbalance.Text = this.Customerbugetiobalance.ToString("#,#", CultureInfo.InvariantCulture);

            txtnguoiyeucau.Enabled = true;
            txtnguoinhan.Enabled = true;


            btluu.Visible = true;
            btluu.Enabled = true;
            //    cbtaikhoanco.Enabled = true;

            //btsua.Enabled = false;

            txtnguoiyeucau.Text = "";
            txtnguoinhan.Text = "";
            txtdiachi.Text = "";
            txtnguoiyeucau.Text = Utils.getname();

            txttel.Text = "";

            lbgatepassno.Text = "";
            datepickngayphieu.Value = DateTime.Today;

            txtnguoiyeucau.Focus();

            dataGridViewDetail = Model.MKT.Loadnewdetailcollectrequest(dataGridViewDetail);

            //     cbkhohang.Items.Clear();

            //   List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            string username = Utils.getusername();
            this.Username = username;
            string rightkho = Model.Username.getmaquyenkho();


            //  if (rightkho == null)
            //  {


            ////      this.Close();

            //      View.MKTNoouthourise view = new MKTNoouthourise();
            //      view.ShowDialog();
            //      return;
            //  }

            List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();

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
            cbkhohang.SelectedIndex = 0;

            this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();
            //this.matk = taikhoan;


            #region // load curent region

            List<ComboboxItem> itemthisregion = new List<ComboboxItem>();

            var rs3 = from pp in dc.tbl_MKT_Regions

                      select pp;
            foreach (var item2 in rs3)
            {
                ComboboxItem cb = new ComboboxItem();
                cb.Value = item2.Region.Trim();
                cb.Text = item2.Region.Trim() + ": " + item2.Note.Trim();
                itemthisregion.Add(cb);

                //  cbkhohang.Items.Add(cb);
                //  CombomCollection.Add(cb);
            }
            cbfromRegion.DataSource = itemthisregion;
            cbfromRegion.SelectedIndex = 0;
            this.region = Model.Username.getuseRegion();

            //   this.region = (cbfromRegion.SelectedItem as ComboboxItem).Value.ToString();

            //  thus region.Items
            foreach (ComboboxItem item in (List<ComboboxItem>)cbfromRegion.DataSource)
            {
                if (item.Value.ToString().Trim() == this.region.Trim())
                {
                    cbfromRegion.SelectedItem = item;
                }
            }

            #endregion


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

        public MKTissuereturnRequest(View.Main Main, string sophieu, string storelocation)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);  // để đọc từ bàn phím phím tắt
            //groupBox1.Visible = true;

            this.main1 = Main;
            cleartoblankphieu();


            if (sophieu == "")
            {
                this.statusphieu = 1; // tạo mới
                this.sophieu = Model.MKT.getMKtNo();
                btcopy.Enabled = false;
                btchange.Enabled = false;
                btluu.Enabled = true;
            }
            else
            {
                this.statusphieu = 3;// display
                this.sophieu = sophieu;
                this.storelocation = storelocation;// = ;
                btcopy.Enabled = true;
                btchange.Enabled = true;
                btluu.Enabled = false;





                #region loaddead so phieu va location
                #region // head 
                //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();
                string connection_string = Utils.getConnectionstr();

                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



                var rs = (from pp in dc.tbl_MKt_Listphieuheads
                          where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation

                          select pp).FirstOrDefault();

                if (rs != null)
                {
                    try
                    {
                        lbgatepassno.Text = this.sophieu;




                        txtnguoinhan.Text = rs.Receiver_by;// = 

                        txtshiptocodeseach.Text = "";
                        txtshiptoname.Text = rs.ShiptoName;

                        if (rs.Ngaytaophieu != null)
                        {
                            datepickngayphieu.Value = (DateTime)rs.Ngaytaophieu;// = ;
                        }
                        else
                        {
                            datepickngayphieu.Value = DateTime.Today;
                        }



                        txtcustcode.Text = rs.Customer_SAP_Code.ToString();// = double.Parse(txtcustcode.Text);
                        txtShiptoCode.Text = rs.ShiptoCode.ToString();
                        txtdiachi.Text = rs.Address;
                        txtshiptoaddress.Text = rs.ShiptoAddress;

                        txtshiptoname.Text = rs.ShiptoName;
                        txtNote.Text = rs.Note;


                        //  cbkhohang.Items
                        foreach (ComboboxItem item in (List<ComboboxItem>)cbkhohang.DataSource)
                        {
                            if (item.Value.ToString().Trim() == rs.ShippingPoint.Trim())
                            {
                                cbkhohang.SelectedItem = item;
                            }
                        }

                        //  thus region.Items
                        if (rs.Region != null)
                        {
                            foreach (ComboboxItem item in (List<ComboboxItem>)cbfromRegion.DataSource)
                            {
                                if (item.Value.ToString().Trim() == rs.Region.Trim())
                                {
                                    cbfromRegion.SelectedItem = item;
                                }
                            }
                        }


                        txtnguoiyeucau.Text = rs.Requested_by;// = ;
                                                              //   rs.Status = "CRT";
                        lbgatepassno.Text = sophieu;

                        txttel.Text = rs.Tel;// = ;
                                             //  rs.Username = this.Username;
                                             //   dc.SubmitChanges();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }


                    //    }


                    #endregion


                    #endregion

                    #region load detail so phieu va loacation
                    var dsphieudetai = from pp in dc.tbl_MKt_Listphieudetails
                                       where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation

                                       select pp;

                    if (dsphieudetai.Count() > 0)
                    {
                        cleartoblankDEtailphieu();



                        foreach (var phieudetail in dsphieudetai)
                        {
                            addDEtailPhieuMKT(phieudetail);
                            //  xxx

                            txtcity.Text = phieudetail.shiptocity;

                        }

                    }

                    #endregion






                }
            }

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




            #region  // check head
            if (txtcustcode.Text == "")
            {
                MessageBox.Show("Pleae select a Benefitciary (Người nhận) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnguoinhan.Focus();
                checkhead = false;
                return;
            }


            if (txtshiptoname.Text == "")
            {
                MessageBox.Show("Pleae check Shipto name !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtshiptoname.Focus();
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
                    //dt.Columns.Add(new DataColumn("Available_Quantity", typeof(float)));

                    dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Style.BackColor = System.Drawing.Color.White;

                    if (dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Value == DBNull.Value)
                    {

                        MessageBox.Show("Please nhập số lượng yêu cầu thu về ở dòng : " + (idrow + 1).ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                        checkdetail = false;
                        return;
                    }

                    if (dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Value != DBNull.Value)
                    {


                        if ((double)dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Value <= 0)
                        {
                            MessageBox.Show("Số lượng phải lớn hơn 0 tại dòng: " + (idrow + 1).ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                            checkdetail = false;
                            return;
                        }

                    }




                }


            }  //for


            #endregion





            if (checkdetail && checkhead)
            {




                if (this.statusphieu == 2) //; nếu là change requaes
                {
                    //  bool kq = Model.MKT.Deletephieutochange(this.sophieu, this.storelocation, this.region);


                    bool kq = Model.MKT.Deletephieuthuchangtochange(this.sophieu, this.storelocation, this.region);






                }


                var rs5 = (from pp in dc.tbl_MKt_Listphieuheads
                           where pp.Gate_pass.ToString() == this.sophieu && pp.Status != "TMP"

                           select pp).FirstOrDefault();
                if (rs5 != null)
                {
                    MessageBox.Show("Can not created, dublicate found !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                    checkhead = false;
                    return;

                }


                #region // head 
                //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();
                btluu.Enabled = false;

                var rs = (from pp in dc.tbl_MKt_Listphieuheads
                          where pp.Gate_pass == this.sophieu && pp.Status == "TMP"
                          && pp.Username == this.Username

                          select pp).FirstOrDefault();

                if (rs != null)
                {
                    rs.Region = this.region;//Model.Username.getuseRegion();
                    rs.Address = txtdiachi.Text.Truncate(225);
                    rs.ShiptoAddress = txtshiptoaddress.Text.Truncate(225);

                    rs.Customer_SAP_Code = double.Parse(txtcustcode.Text);
                    rs.ShiptoCode = double.Parse(txtShiptoCode.Text);

                    rs.Receiver_by = txtnguoinhan.Text.Truncate(225);

                    rs.ShiptoName = txtshiptoname.Text.Truncate(225);
                    //txtshiptoname
                    //   rs.ShiptoName = txtshiptocodeseach.Text.Truncate(225);
                    rs.Note = txtNote.Text.Truncate(225);

                    rs.Ngaytaophieu = datepickngayphieu.Value;

                    rs.ShippingPoint = this.storelocation;
                    rs.Requested_by = txtnguoiyeucau.Text;
                    rs.Status = "CRT";
                    rs.Gate_pass = this.sophieu;
                    rs.requestReturn = true;

                    rs.Tel = txttel.Text.Truncate(50);
                    rs.Username = this.Username;

                    dc.SubmitChanges();

                }


                #endregion

                #region // detail
                for (int idrow = 0; idrow < dataGridViewDetail.RowCount - 1; idrow++)
                {
                    if (dataGridViewDetail.Rows[idrow].Cells["ITEM_Code"].Value != DBNull.Value)
                    {
                        tbl_MKt_Listphieudetail detailphieu = new tbl_MKt_Listphieudetail();
                        string ItemCode = "";
                        double requetedquantity = 0;
                        detailphieu.Address = txtshiptoaddress.Text.Truncate(225);

                        detailphieu.Customer_SAP_Code = txtcustcode.Text;
                        detailphieu.Receiver_by = txtnguoinhan.Text.Truncate(225);

                        detailphieu.Ngaytaophieu = datepickngayphieu.Value;



                        detailphieu.Note = txtNote.Text.Truncate(225);

                        detailphieu.Requested_by = txtnguoiyeucau.Text.Truncate(50);
                        detailphieu.Status = "CRT";
                        detailphieu.Tel = txttel.Text.Truncate(50);
                        detailphieu.shiptocity = txtcity.Text.Truncate(50);


                        detailphieu.Username = this.Username;
                        detailphieu.Gate_pass = this.sophieu;
                        detailphieu.Region = this.region;//Model.Username.getuseRegion();
                        detailphieu.ShippingPoint = this.storelocation;

                        //dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
                        //dt.Columns.Add(new DataColumn("Description", typeof(string)));
                        //dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
                        //dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

                        //dt.Columns.Add(new DataColumn("Unit", typeof(string)));
                        //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
                        //dt.Columns.Add(new DataColumn("Available_Quantity", typeof(float)));

                        if (dataGridViewDetail.Rows[idrow].Cells["MATERIAL"].Value != DBNull.Value)
                        {
                            detailphieu.Materialname = (string)dataGridViewDetail.Rows[idrow].Cells["MATERIAL"].Value.ToString().Truncate(225);
                        }

                        if (dataGridViewDetail.Rows[idrow].Cells["ITEM_Code"].Value != DBNull.Value)
                        {
                            ItemCode = (string)dataGridViewDetail.Rows[idrow].Cells["ITEM_Code"].Value;
                            detailphieu.Materiacode = ItemCode;
                        }


                        if (dataGridViewDetail.Rows[idrow].Cells["SAP_CODE"].Value != DBNull.Value)
                        {

                            detailphieu.MateriaSAPcode = (string)dataGridViewDetail.Rows[idrow].Cells["SAP_CODE"].Value;
                        }
                        detailphieu.Issued = 0;

                        if (dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Value != DBNull.Value)
                        {
                            requetedquantity = (double)dataGridViewDetail.Rows[idrow].Cells["Request_collect_Quantity"].Value;
                            detailphieu.Returnrequest = requetedquantity;
                        }
                        if (dataGridViewDetail.Rows[idrow].Cells["Description"].Value != DBNull.Value)
                        {
                            detailphieu.Description = (string)dataGridViewDetail.Rows[idrow].Cells["Description"].Value.ToString().Truncate(225);
                        }
                        if (dataGridViewDetail.Rows[idrow].Cells["Unit"].Value != DBNull.Value)
                        {
                            detailphieu.Unit = (string)dataGridViewDetail.Rows[idrow].Cells["Unit"].Value;
                        }

                        //if (dataGridViewDetail.Rows[idrow].Cells["Price"].Value != DBNull.Value)
                        //{
                        //    detailphieu.Price = (float)dataGridViewDetail.Rows[idrow].Cells["Price"].Value;
                        //}

                        // detailphieu.NetValue = detailphieu.Price * detailphieu.Issued;


                        dc.tbl_MKt_Listphieudetails.InsertOnSubmit(detailphieu);
                        dc.SubmitChanges();







                    }
                }

                #endregion







                //#endregion                //

                btcopy.Enabled = true;
                btchange.Enabled = true;

                MessageBox.Show("Phiếu thu hàng " + this.sophieu.ToString() + " done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //groupBox1.Visible = true;
            this.cleartoblankphieu();

            Model.MKT.DeleteALLphieutamTMP();

            this.sophieu = Model.MKT.getMKtNo();
            lbgatepassno.Text = this.sophieu;
            btluu.Enabled = true;
            this.statusphieu = 1; // tạo mới
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

                headpx.Diachi = rptMKThead.ShiptoAddress;
                headpx.Nguoinhancode = rptMKThead.ShiptoCode.ToString();
                headpx.Username = this.Username;
                headpx.Sophieu = rptMKThead.Gate_pass;
                headpx.Nguoinhanname = rptMKThead.ShiptoName;
                headpx.seri = rptMKThead.Region + this.storelocation + rptMKThead.Gate_pass;
                headpx.ghichu = rptMKThead.Note;

                BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(rptMKThead.Region + this.storelocation + rptMKThead.Gate_pass), 1, true), typeof(Byte[]));

                headpx.Barcode = result;
                headpx.dienthoai = rptMKThead.Tel;
                headpx.mucdich = rptMKThead.Purpose;
                headpx.Ngaythang = rptMKThead.Ngaytaophieu;
                headpx.Nguoiyeucau = rptMKThead.Requested_by;



                dc.tbl_MKT_headRpt_Phieuissues.InsertOnSubmit(headpx);
                dc.SubmitChanges();

            }

            var rptMKTdetailmk = from pp in dc.tbl_MKt_Listphieudetails
                                 where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation
                                 select pp;
            int i = 0;
            foreach (var item in rptMKTdetailmk)
            {
                i = i + 1;

                tbl_MKT_DetailRpt_Phieuissue detailpx = new tbl_MKT_DetailRpt_Phieuissue();

                detailpx.stt = i.ToString();
                detailpx.soluong = item.Returnrequest;
                detailpx.Username = this.Username;
                detailpx.tensanpham = item.Materialname;
                detailpx.masanpham = item.Materiacode;
                detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Returnrequest.ToString()));


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
                           orderby pp.stt
                           select new
                           {

                               stt = pp.stt,
                               tensanpham = pp.tensanpham,
                               pp.masanpham,

                               soluong = pp.soluong,
                               //   username = pp.Username,
                               bangchu = pp.bangchu,

                           };

            //View.Viewtable vx = new Viewtable(rsdetail,dc,"test",100,"100");
            //vx.ShowDialog();


            var dataset2 = ut.ToDataTable(dc, rsdetail); // detail


            Reportsview rpt = new Reportsview(dataset1, dataset2, "PhieuMKTminutethuhang.rdlc");
            rpt.ShowDialog();

            //}

            //#endregion view reports payment request  // 

        }

        private void dataGridViewListphieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridViewListphieuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxoa_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

            //this.statusphieu = 2;

            //btluu.Enabled = true;
            //btmoi.Enabled = true;
            //btxoa.Enabled = true;

            //datepickngayphieu.Enabled = true;




            //txtnguoiyeucau.Enabled = true;
            //txtnguoinhan.Enabled = true;
            //txtdiachi.Enabled = true;

            //btluu.Enabled = true;

            ////   cbtaikhoanco.Enabled = true;


            //this.statusphieu = 2;

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


            string columhead = dataGridViewDetail.Columns[e.ColumnIndex].HeaderText.ToString();


            #region  hien va chon san pham


            if (!kq && e.RowIndex >= 0)
            {
                string valueseach = "";
                if (dataGridViewDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    valueseach = "";
                }
                else
                {
                    valueseach = dataGridViewDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
                }
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string username = Utils.getusername();


                //var listproduct = from pp in dc.tbl_MKT_Programepriceproducts
                //                  where pp.ProgrameIDDocno == this.ProgrameIDDocno
                //                  select pp.ITEM_Code;




                IQueryable rs = null;


                //var rs1 = from pp in dc.tbl_MKT_khoMKTs
                //          where (from gg in dc.tbl_MKT_StoreRights
                //                 where gg.storeright == rightkho
                //                 select gg.makho).Contains(pp.makho)
                //          select pp;


                if (columhead == "Description")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.Description.Contains(valueseach) && pp.Store_code == this.storelocation
                         //    && listproduct.Contains(pp.ITEM_Code)


                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             //      Avaiable_stock = pp.END_STOCK.GetValueOrDefault(0) - pp.Ordered.GetValueOrDefault(0),

                             pp.id,

                         };

                }

                if (columhead == "ITEM Code")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.ITEM_Code.Contains(valueseach) && pp.Store_code == this.storelocation
                         //     && listproduct.Contains(pp.ITEM_Code)

                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             //   Avaiable_stock = pp.END_STOCK.GetValueOrDefault(0) - pp.Ordered.GetValueOrDefault(0),

                             pp.id,

                         };

                }
                if (columhead == "Sap Code")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.SAP_CODE.Contains(valueseach) && pp.Store_code == this.storelocation
                         //       && listproduct.Contains(pp.ITEM_Code)

                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             //   Avaiable_stock = pp.END_STOCK.GetValueOrDefault(0) - pp.Ordered.GetValueOrDefault(0),

                             pp.id,

                         };

                }

                if (columhead == "MATERIAL")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.MATERIAL.Contains(valueseach) && pp.Store_code == this.storelocation
                         //      && listproduct.Contains(pp.ITEM_Code)

                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             //        Avaiable_stock = pp.END_STOCK.GetValueOrDefault(0) - pp.Ordered.GetValueOrDefault(0),
                             pp.id,

                         };

                }


                if (rs != null)
                {
                    #region
                    View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT PRODUCTS ", columhead);
                    selectkq.ShowDialog();
                    int id = selectkq.id;



                    var valuechon = (from pp in dc.tbl_MKT_Stockends
                                     where pp.id == id
                                     select pp).FirstOrDefault();

                    if (valuechon != null)
                    {
                        dataGridViewDetail.Rows[e.RowIndex].Cells["MATERIAL"].Value = valuechon.MATERIAL;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Description"].Value = valuechon.Description;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ITEM_Code"].Value = valuechon.ITEM_Code;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Sap_Code"].Value = valuechon.SAP_CODE;
                        //          dataGridViewDetail.Rows[e.RowIndex].Cells["Available_Quantity"].Value = valuechon.END_STOCK.GetValueOrDefault(0) - valuechon.Ordered.GetValueOrDefault(0);
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Unit"].Value = valuechon.UNIT;

                        //        dataGridViewDetail.Rows[e.RowIndex].Cells["Region_Balance"].Value = Model.MKT.getBalancebuget(valuechon.ITEM_Code, this.region, this.storelocation);

                        //dataGridViewDetail.Rows[e.RowIndex].Cells["Price"].Value = (from p in dc.tbl_MKT_Programepriceproducts
                        //                                                            where p.ITEM_Code == valuechon.ITEM_Code
                        //                                                            && p.ProgrameIDDocno == this.ProgrameIDDocno
                        //                                                            select p.Price).FirstOrDefault();

                        //          Region_Balance



                    }
                    else
                    {
                        dataGridViewDetail.Rows[e.RowIndex].Cells["MATERIAL"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Description"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ITEM_Code"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Sap_Code"].Value = DBNull.Value;
                        //      dataGridViewDetail.Rows[e.RowIndex].Cells["Available_Quantity"].Value = DBNull.Value;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["Unit"].Value = DBNull.Value;
                        //    dataGridViewDetail.Rows[e.RowIndex].Cells["Region_Balance"].Value = DBNull.Value;

                    }


                    #endregion


                }

                //   }

            }

            #endregion

            #region  tính cột giá thành



            //if (columhead == "Issue Quantity")
            //{
            //    this.POSMisuevalue = 0;
            //    for (int idrow = 0; idrow < dataGridViewDetail.RowCount - 1; idrow++)
            //    {
            //        if (dataGridViewDetail.Rows[idrow].Cells["Price"].Value != DBNull.Value && dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value != DBNull.Value)
            //        {
            //            this.POSMisuevalue = POSMisuevalue + (float)dataGridViewDetail.Rows[idrow].Cells["Price"].Value * (float)dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value;


            //        }
            //    }
            //    txtPOSMissuevalue.Text = this.POSMisuevalue.ToString("#,#", CultureInfo.InvariantCulture);

            //}

            #endregion


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


            string connection_string = Utils.getConnectionstr();

            // string useregion = Model.Username.getuseRegion();          //groupBox1.Visible = false;
            btluu.Enabled = false;
            //btsua.Enabled = true;
            btmoi.Enabled = false;

            btcopy.Enabled = true;
            btchange.Enabled = true;


            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            try
            {
                this.sophieu = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();
                this.storelocation = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["Store"].Value.ToString();
                lbgatepassno.Text = this.sophieu;
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
                      where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation

                      select pp).FirstOrDefault();

            if (rs != null)
            {

                lbgatepassno.Text = this.sophieu;

                txtdiachi.Text = rs.Address;

                //  txtcustcode.Enabled = true;

                //     txtcustcode.Enabled = false;

                //   txtShiptoCode.Enabled = true;


                //   txtShiptoCode.Enabled = false;


                txtnguoinhan.Text = rs.Receiver_by;// = 
                txtshiptoname.Text = rs.ShiptoName;

                datepickngayphieu.Value = rs.Ngaytaophieu.Value;// = ;
                txtcustcode.Text = rs.Customer_SAP_Code.ToString();// = double.Parse(txtcustcode.Text);
                txtShiptoCode.Text = rs.ShiptoCode.ToString();



                // txtcustcode
                //         txtShiptoCode
                txtNote.Text = rs.Note;

                //  cbkhohang.Items
                foreach (ComboboxItem item in (List<ComboboxItem>)cbkhohang.DataSource)
                {
                    if (item.Value.ToString().Trim() == rs.ShippingPoint.Trim())
                    {
                        cbkhohang.SelectedItem = item;
                    }
                }

                //  thus region.Items
                foreach (ComboboxItem item in (List<ComboboxItem>)cbfromRegion.DataSource)
                {
                    if (item.Value.ToString().Trim() == rs.Region.Trim())
                    {
                        cbfromRegion.SelectedItem = item;

                    }
                }

                txtnguoiyeucau.Text = rs.Requested_by;// = ;
                                                      //   rs.Status = "CRT";
                lbgatepassno.Text = this.sophieu;

                txttel.Text = rs.Tel;// = ;
                                     //  rs.Username = this.Username;
                                     //   dc.SubmitChanges();

                txtshiptoaddress.Text = rs.ShiptoAddress;

            }


            #endregion


            #endregion

            #region load detail so phieu va loacation
            var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                      where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation
                      //          && pp.Returnrequest != 0

                      select pp;

            if (rs2.Count() > 0)
            {
                cleartoblankDEtailphieu();
                foreach (var item in rs2)
                {
                    addDEtailPhieuMKT(item);
                    //  xxx


                    txtcity.Text = item.shiptocity;
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


                var rs = from pp in dc.tbl_MKt_Listphieudetails
                         where pp.Status == "CRT" && pp.Username == username
                         && pp.Returnrequest > 0
                         select new
                         {
                             Date = pp.Ngaytaophieu,
                             pp.Region,
                             pp.Gate_pass,

                             pp.Purpose,



                             Material_Item_code = pp.Materiacode,
                             Material_SAP_code = pp.MateriaSAPcode,
                             pp.Materialname,
                             //  pp.MateriaSAPcode,
                             pp.Description,
                             pp.Returnrequest,
                             //pp.Issued,
                             pp.Price,
                             pp.Receiver_by,
                             Customer = pp.Customer_SAP_Code,
                             //   pp.ShiptoCode,
                             //  pp.ShiptoName,
                             //    pp.ShiptoAddress,

                             //     Customer = pp.Customer_SAP_Code,
                             pp.Address,

                             Store = pp.ShippingPoint,
                             Created_by = pp.Username,
                             pp.Requested_by,
                             pp.Note,

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



        }

        private void btmucdich_Click(object sender, EventArgs e)
        {



        }

        private void btcustomer_Click(object sender, EventArgs e)
        {

            //    NPDanhsachnhavantai
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.danhkhachhang(dc);
            Viewtable viewtbl = new Viewtable(rs1, dc, "CUSTOMER LIST ", 12, "MKT_KH");// mã 12 là danh sach khách hàng MKT

            viewtbl.Show();




        }

        private void txtmucdichname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            bool kq = Model.MKT.Deletephieu(this.sophieu, this.storelocation, this.region);
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



                // chanel of IO
                string seachtext = txtnguoinhan.Text;
                string seachcode = txtseachcode.Text;

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //string channelgroup = (from pp in dc.tbl_MKT_IO_Programes
                //                       where pp.ProgrameIDDocno == this.ProgrameIDDocno
                //                       && pp.IO_number == this.IO_number
                //                       select pp.ChannelGroup).FirstOrDefault();


                //          string[] chanelparts = channelgroup.Split(';');

                //st1 = parts[0].Trim();
                //st2 = parts[1].Trim();
                //st3 = parts[2].Trim();
                //st4 = parts[3].Trim();

                var rs = (from pp in dc.tbl_MKT_Soldtocodes
                          where pp.FullNameN.Contains(seachtext)
                          && pp.Customer.Contains(seachcode)
                          && pp.Soldtype == true
                          //      && chanelparts.Contains(pp.Chanel)

                          select new
                          {
                              //     pp.KeyAcc,
                              //   pp.Chanel,
                              //                             pp.Region,
                              pp.SalesOrg,

                              MÃ_KHÁCH_HÀNG = pp.Customer,
                              TÊN_KHÁCH_HÀNG = pp.FullNameN,

                              pp.District,
                              ĐỊA_CHỈ = pp.Street + " " + pp.District + " " + pp.City,
                              QUẬN = pp.District,
                              TỈNH_THÀNH_PHỐ = pp.City,
                              ĐIỆN_THOẠI = pp.Telephone1,
                              GHI_CHÚ = pp.Note,




                              ID = pp.id,

                          }).Take(100);

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT RECIPIENTS", "MKT");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_Soldtocodes
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {
                    txtcustcode.Text = rs2.Customer;
                    //   this.Customercode = rs2.Customer;
                    txtnguoinhan.Text = rs2.FullNameN;
                    txtdiachi.Text = rs2.Street + " ," + rs2.District + " ," + rs2.City;
                    txttel.Text = rs2.Telephone1;


                    txtShiptoCode.Text = rs2.ShiptoCode;
                    txtshiptoname.Text = rs2.FullNameN;
                    txtcity.Text = rs2.City;
                    //  txtshiptocodeseach.Text = rs2.FullNameN;

                    txtshiptocodeseach.Text = "";
                    txtshiptoaddress.Text = rs2.Street + " ," + rs2.District + " ," + rs2.City;
                    txtcustcode.Text = rs2.Customer;
                    //this.Customerbugetioaproval = (from pp in dc.tbl_MKT_Payment_Aprovals
                    //                               where pp.Customercode == rs2.Customer
                    //                               && pp.IO_number == this.IO_number
                    //                               && pp.Approval == "Approved"
                    //                               select pp.AprovalBudget).Sum().GetValueOrDefault(0);



                    //this.Customerbugetioused = (from pp in dc.tbl_MKt_Listphieudetails
                    //                            where pp.Customer_SAP_Code == rs2.Customer
                    //                            && pp.Purposeid == this.IO_number
                    //                            select pp.NetValue).Sum().GetValueOrDefault(0);

                    //this.Customerbugetiobalance = this.Customerbugetioaproval - this.Customerbugetioused;



                    //txtcustomerbudget.Text = this.Customerbugetioaproval.ToString("#,#", CultureInfo.InvariantCulture);
                    //txtcustomerbudgetuse.Text = this.Customerbugetioused.ToString("#,#", CultureInfo.InvariantCulture);
                    //txtcustomerbudgetbalance.Text = this.Customerbugetiobalance.ToString("#,#", CultureInfo.InvariantCulture);

                }








                txtshiptocodeseach.Focus();


            }
        }

        private void txtShiptoname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //  cbsophieu.

                string seachtext = txtshiptocodeseach.Text;
                string customercodefind = txtcustcode.Text;
                if (customercodefind == "")
                {

                    MessageBox.Show("Please select customer code !");
                    return;
                }

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs = (from pp in dc.tbl_MKT_Soldtocodes
                          where pp.Customer == customercodefind
                     && pp.ShiptoCode.Contains(seachtext)
                          //     && pp.Soldtype == false
                          //  &&
                          select new
                          {
                              MÃ_KHÁCH_HÀNG = pp.ShiptoCode,
                              TÊN_KHÁCH_HÀNG = pp.FullNameN,
                              ĐỊA_CHỈ = pp.Street + " " + pp.District + " " + pp.City,
                              QUẬN = pp.District,
                              TỈNH_THÀNH_PHỐ = pp.City,
                              ĐIỆN_THOẠI = pp.Telephone1,
                              GHI_CHÚ = pp.Note,




                              ID = pp.id,

                          }).Take(100);

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT RECIPIENTS", "MKT");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_Soldtocodes
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {
                    //txtcustcode.Text = rs2.Customer;
                    //txtnguoinhan.Text = rs2.FullNameN;
                    //txtdiachi.Text = rs2.Street + " ," + rs2.District + " ," + rs2.City;
                    txttel.Text = rs2.Telephone1;


                    txtShiptoCode.Text = rs2.ShiptoCode;
                    //        this.txtShiptoCode = rs2.ShiptoCode;
                    txtcity.Text = rs2.City;

                    txtshiptoname.Text = rs2.FullNameN;
                    txtshiptoaddress.Text = rs2.Street + " ," + rs2.District + " ," + rs2.City;



                }








                txtNote.Focus();
            }
        }

        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {



                dataGridViewDetail.Focus();

            }

        }

        private void btnewShiptoCode_Click(object sender, EventArgs e)
        {
            //    NPDanhsachnhavantai
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            string customercode = txtcustcode.Text;

            var rs1 = Model.MKT.shiptolistbycustomer(dc, customercode);
            Viewtable viewtbl = new Viewtable(rs1, dc, "SHIPTO CODE LIST", 16, customercode);// mã 12 là danh sach khách hàng MKT

            viewtbl.Show();

        }

        private void txtseachcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //  cbsophieu.



                // chanel of IO
                string seachtext = txtnguoinhan.Text;
                string seachcode = txtseachcode.Text;

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //string channelgroup = (from pp in dc.tbl_MKT_IO_Programes
                //                       where pp.ProgrameIDDocno == this.ProgrameIDDocno
                //                       && pp.IO_number == this.IO_number
                //                       select pp.ChannelGroup).FirstOrDefault();


                //      string[] chanelparts = channelgroup.Split(';');

                //st1 = parts[0].Trim();
                //st2 = parts[1].Trim();
                //st3 = parts[2].Trim();
                //st4 = parts[3].Trim();

                var rs = (from pp in dc.tbl_MKT_Soldtocodes
                          where pp.FullNameN.Contains(seachtext)
                          && pp.Customer.Contains(seachcode)
                          && pp.Soldtype == true
                          //          && chanelparts.Contains(pp.Chanel)

                          select new
                          {
                              //                 pp.KeyAcc,
                              //               pp.Chanel,
                              //             pp.Region,
                              pp.SalesOrg,

                              MÃ_KHÁCH_HÀNG = pp.Customer,
                              TÊN_KHÁCH_HÀNG = pp.FullNameN,
                              ĐỊA_CHỈ = pp.Street + " " + pp.District + " " + pp.City,
                              QUẬN = pp.District,
                              //   pp.District,
                              TỈNH_THÀNH_PHỐ = pp.City,
                              ĐIỆN_THOẠI = pp.Telephone1,
                              GHI_CHÚ = pp.Note,




                              ID = pp.id,

                          }).Take(100);

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT RECIPIENTS", "MKT");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_Soldtocodes
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {

                    //xxx


                    //    txtcustcode


                    txtcustcode.Text = rs2.Customer;

                    txtnguoinhan.Text = rs2.FullNameN;
                    txtdiachi.Text = rs2.Street + " ," + rs2.District + " ," + rs2.City;
                    txttel.Text = rs2.Telephone1;
                    txtshiptoname.Text = rs2.FullNameN;
                    txtcity.Text = rs2.City;

                    txtShiptoCode.Text = rs2.ShiptoCode;
                    txtshiptocodeseach.Text = "";
                    //    txtshiptocodeseach.Text = rs2.FullNameN;
                    txtshiptoaddress.Text = rs2.Street + " ," + rs2.District + " ," + rs2.City;
                    txtcustcode.Text = rs2.Customer;

                    //this.Customerbugetioaproval = (from pp in dc.tbl_MKT_Payment_Aprovals
                    //                               where pp.Customercode == rs2.Customer
                    //                               && pp.IO_number == this.IO_number
                    //                               && pp.Approval == "Approved"
                    //                               select pp.AprovalBudget).Sum().GetValueOrDefault(0);



                    //this.Customerbugetioused = (from pp in dc.tbl_MKt_Listphieudetails
                    //                            where pp.Customer_SAP_Code == rs2.Customer
                    //                            && pp.Purposeid == this.IO_number
                    //                            select pp.NetValue).Sum().GetValueOrDefault(0);

                    //this.Customerbugetiobalance = this.Customerbugetioaproval - this.Customerbugetioused;



                    //txtcustomerbudget.Text = this.Customerbugetioaproval.ToString("#,#", CultureInfo.InvariantCulture);
                    //txtcustomerbudgetuse.Text = this.Customerbugetioused.ToString("#,#", CultureInfo.InvariantCulture);
                    //txtcustomerbudgetbalance.Text = this.Customerbugetiobalance.ToString("#,#", CultureInfo.InvariantCulture);

                }








                txtshiptocodeseach.Focus();


            }
        }

        private void cbfromRegion_SelectedValueChanged(object sender, EventArgs e)
        {
            this.region = (cbfromRegion.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void lbweight_Click(object sender, EventArgs e)
        {

        }

        private void btcopy_Click(object sender, EventArgs e)
        {

            btluu.Enabled = true;
            //btsua.Enabled = true;
            btmoi.Enabled = true;

            btcopy.Enabled = false;
            btchange.Enabled = false;
            this.statusphieu = 2;// change status


            Model.MKT.DeleteALLphieutamTMP();




            this.sophieu = Model.MKT.getMKtNo();
            lbgatepassno.Text = this.sophieu;




            //  btchange.Enabled = true;

        }

        private void btchange_Click(object sender, EventArgs e)
        {



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from pp in dc.tbl_MKt_Listphieudetails
                      where pp.Gate_pass == this.sophieu && pp.ShippingPoint == this.storelocation
                      && pp.ShipmentNumber != ""
                      select pp.ShipmentNumber).FirstOrDefault();

            if (rs != null)
            {

                MessageBox.Show("Phiếu này đã ghép load : " + rs + " không thay đổi được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;



            }

            btluu.Enabled = true;
            //btsua.Enabled = true;
            btmoi.Enabled = true;

            btcopy.Enabled = false;
            btchange.Enabled = false;
            this.statusphieu = 2;// change status





            Model.MKT.DeleteALLphieutamTMP();


            //   this.sophieu = Model.MKT.getMKtNo();
            // lbgatepassno.Text = this.sophieu;

        }

        private void txtseachcode_TextChanged(object sender, EventArgs e)
        {
            txtnguoinhan.Text = "";
            txtshiptocodeseach.Text = "";
            txtShiptoCode.Text = "";
            txtcity.Text = "";
            txtshiptoaddress.Text = "";
        }

        private void txtnguoinhan_TextChanged(object sender, EventArgs e)
        {
            txtcustcode.Text = "";
            txtshiptocodeseach.Text = "";
            txtShiptoCode.Text = "";
            txtcity.Text = "";
            txtshiptoaddress.Text = "";
        }

        private void lbgatepassno_TextChanged(object sender, EventArgs e)
        {
            this.sophieu = lbgatepassno.Text;
        }
    }
}
