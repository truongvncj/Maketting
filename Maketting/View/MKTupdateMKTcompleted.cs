﻿using Maketting.Control;
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
    public partial class MKTupdateMKTcompleted : Form
    {
        public int statusphieu { get; set; } // mới  // 2 suawra // 3 display //

        //  public int subID { get; set; } // mới  // 2 suawra // 3 display //
        //     public string Loadnumberserri { get; set; }
        public string Maketting_Seri { get; set; }
        public string storelocation { get; set; }
        public string Username { get; set; }
        public string Createdby { get; set; }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        public void clearbankdetail()
        {


            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Region", typeof(string)));
            dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            dt.Columns.Add(new DataColumn("Shipping_Point", typeof(string)));
            dt.Columns.Add(new DataColumn("Customer_code", typeof(string)));
            dt.Columns.Add(new DataColumn("Customer_name", typeof(string)));

            dt.Columns.Add(new DataColumn("Maketting_Status", typeof(string)));
            dt.Columns.Add(new DataColumn("Maketting_load", typeof(float)));
            dt.Columns.Add(new DataColumn("Update_time", typeof(DateTime)));



            dataGridViewLoaddetail.DataSource = dt;
            //  dataGridViewLoaddetail.Columns["Unit"].ReadOnly = true;
            //  dataGridViewLoaddetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            //      dataGridViewLoaddetail.Columns["Available_Quantity"].ReadOnly = true;
            //      dataGridViewLoaddetail.Columns["Available_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;




        }

        public void addDEtailPhieuMKT(tbl_MKt_Listphieudetail PhieuMKT)
        {




            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //     dt.Columns.Add(new DataColumn("Region", typeof(string)));
            //---------------

            DataTable dataTable = (DataTable)dataGridViewLoaddetail.DataSource;

            DataRow drToAdd = dataTable.NewRow();

            drToAdd["Region"] = PhieuMKT.Region;
            drToAdd["Gate_pass"] = PhieuMKT.Gate_pass;
            drToAdd["Shipping_Point"] = PhieuMKT.ShippingPoint;
            drToAdd["Customer_code"] = PhieuMKT.Customer_SAP_Code;
            drToAdd["Customer_name"] = PhieuMKT.Requested_by;
            drToAdd["Maketting_Status"] = PhieuMKT.Status;

            if (PhieuMKT.ShipmentNumber != null)
            {
                drToAdd["Maketting_load"] = PhieuMKT.ShipmentNumber;
            }

            drToAdd["Update_time"] = DateTime.Now;


            dataTable.Rows.Add(drToAdd);
            dataTable.AcceptChanges();

            //// Create DataView
            //DataView view = new DataView(yourDataTable);

            //// Sort by Program column in ascending order
            //view.Sort = "Program ASC";
            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            //foreach (var c in dataGridViewListphieu.Columns)
            //{
            //    DataGridViewColumn clm = (DataGridViewColumn)c;
            //    clm.HeaderText = clm.HeaderText.Replace("_", " ");
            //}

            // Next

            dataGridViewLoaddetail.Sort(dataGridViewLoaddetail.Columns["Update_time"], ListSortDirection.Descending);

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

        public MKTupdateMKTcompleted(View.Main Main)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);  // để đọc từ bàn phím phím tắt


            this.main1 = Main;

            this.Username = Utils.getusername();
            this.Createdby = Utils.getname();
            //       this.Loadnumberserri = Loadnumberserri;
            txtupdateby.Text = "";



            txtupdateby.Text = Utils.getname();


            btsave.Enabled = true;
            btinphieu.Enabled = false;



            dateupdate.Value = DateTime.Today;


            clearbankdetail();

            //    btluu.Enabled = true;
            //   btinphieu.Enabled = false;
            tabControl1.Focus();

            txtmktseri.TabIndex = 0;
            txtmktseri.Text = "";
            txtmktseri.Focus();


            //    txtmktseri

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
                txtupdateby.Focus();

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
                //   txttenNVT.Focus();

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
                //txttenNVT.Focus();

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
                dateupdate.Focus();
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


        //private void button1_Click(object sender, EventArgs e)  // new phieu 
        //{

        //    bool checkdetail = true;


        //    //            Maketting_load = pp.LoadNumber,
        //    //             Shipping_Point = pp.ShippingPoint,
        //    //             Material_code = pp.Materiacode,
        //    //             Material_name = pp.Materialname,
        //    //             Requested_issue = pp.Issued,
        //    //        //     Real_issue = 0,


        //    #region // detail
        //    for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)

        //    {

        //        dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Style.BackColor = System.Drawing.Color.White;
        //        if (dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Value == DBNull.Value)
        //        {
        //            dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Style.BackColor = System.Drawing.Color.Orange;
        //            MessageBox.Show("Số lượng hàng xuất thiếu, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            checkdetail = false;

        //            return;


        //        }

        //        if (dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Value != DBNull.Value)
        //        {

        //            float xuat = (float)dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Value;
        //            float yeucau = float.Parse(dataGridViewLoaddetail.Rows[idrow].Cells["Requested_issue"].Value.ToString());
        //            if (yeucau != xuat)
        //            {
        //                dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Style.BackColor = System.Drawing.Color.Orange;


        //                MessageBox.Show("Số lượng hàng xuất khác lượng hàng yêu cầu, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                checkdetail = false;

        //                return;
        //            }




        //        }



        //    }


        //    #endregion







        //    string connection_string = Utils.getConnectionstr();
        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



        //    if (checkdetail)
        //    {




        //        #region // head 
        //        //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();
        //        //btluu.Enabled = false;
        //        btinphieu.Enabled = true;
        //        int IssueIDsub = 1;
        //        int subId = (int)(from pp in dc.tbl_MKt_WHstoreissues
        //                       //   where pp.Serriload == this.Loadnumberserri
        //                          select pp.IssueIDsub).Max().GetValueOrDefault(0);

        //        if (subId > 0)
        //        {
        //            IssueIDsub = subId + 1;
        //        }
        //        this.subID = IssueIDsub;

        //        for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)
        //        {
        //            if (dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Value != DBNull.Value)
        //            {
        //                tbl_MKt_WHstoreissue phieuxuat = new tbl_MKt_WHstoreissue();

        //                phieuxuat.IssueBy = txtupdateby.Text;
        //                phieuxuat.Issued = (float)dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Value;
        //                phieuxuat.IssueDate = dateupdate.Value;
        //                phieuxuat.IssueIDsub = IssueIDsub;
        //                phieuxuat.LoadNumber = this.soload;
        //                phieuxuat.Materiacode = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_code"].Value;
        //                phieuxuat.Materialname = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_name"].Value;
        //         //       phieuxuat.Serriload = this.Loadnumberserri;
        //                phieuxuat.ShippingPoint = this.storelocation;
        //                phieuxuat.Status = "CRT";
        //                phieuxuat.Username = this.Username;

        //                dc.tbl_MKt_WHstoreissues.InsertOnSubmit(phieuxuat);
        //                dc.SubmitChanges();


        //                Model.MKT.giamtrukhokhixuathang(phieuxuat);



        //            }
        //        }

        //        #endregion


        // //       MessageBox.Show("StoreIssue:  " + this.Loadnumberserri.ToString() + " create done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        var phieuMKT = (from pp in dc.tbl_MKt_Listphieus
        //                        where pp.ShipmentNumber == this.soload
        //                        && pp.ShippingPoint == this.storelocation
        //                        select pp);



        //        if (phieuMKT.Count()>0)
        //        {
        //            foreach (var item in phieuMKT)
        //            {
        //                item.Status = "Delivering";
        //                dc.SubmitChanges();
        //            }
        //        }



        //    }


        //}

        private void dataGridViewListphieuthu_Paint(object sender, PaintEventArgs e)
        {

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            //foreach (var c in dataGridViewListphieu.Columns)
            //{
            //    DataGridViewColumn clm = (DataGridViewColumn)c;
            //    clm.HeaderText = clm.HeaderText.Replace("_", " ");
            //}

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
            // Model.MKT.restatusphieuLoadingtoCRT();

            //   this.cleartoblankphieu();

            //    Model.MKT.DeleteALLphieutamTMP();

            //    this.soload = Model.MKT.getLoadNo();
            //     txtloadnumber.Text = this.soload;


        }

        //private void button5_Click(object sender, EventArgs e)
        //{

        //    //   string username = Utils.getusername();

        //    string connection_string = Utils.getConnectionstr();
        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

        //    var rptMKT = from pp in dc.tbl_MKT_WHissueHeadRpts
        //                 where pp.username == this.Username
        //                 select pp;

        //    dc.tbl_MKT_WHissueHeadRpts.DeleteAllOnSubmit(rptMKT);
        //    dc.SubmitChanges();


        //    var rptMKTdetail = from pp in dc.tbl_MKT_LoaddetailRpts
        //                       where pp.Username == this.Username
        //                       select pp;

        //    dc.tbl_MKT_LoaddetailRpts.DeleteAllOnSubmit(rptMKTdetail);
        //    dc.SubmitChanges();


        //    //string gatepasslist = "";
        //    //var rptMKTdetailmk1 = from pp in dc.tbl_MKt_Listphieus
        //    //                      where pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation
        //    //                      group pp by pp.Gate_pass into gg
        //    //                      select gg;
        //    //int dem = 0;
        //    //foreach (var item in rptMKTdetailmk1)
        //    //{
        //    //    dem = dem + 1;
        //    //    if (dem == 1)
        //    //    {
        //    //        gatepasslist = gatepasslist + item.Key;
        //    //    }
        //    //    if (dem > 1)
        //    //    {
        //    //        gatepasslist = gatepasslist + ", " + item.Key;
        //    //    }

        //    //}


        //    //var rptMKTdetailmk = from pp in dc.tbl_MKt_Listphieus
        //    //                     where pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation
        //    //                     group pp by pp.Materiacode into gg
        //    //                     select new
        //    //                     {
        //    //                         Issued = gg.Sum(m => m.Issued),
        //    //                         Materiacode = gg.Key,//       gg.FirstOrDefault().Materiacode,
        //    //                         Materialname = gg.Select(m => m.Materialname).FirstOrDefault(),



        //    //                     };
        //    //int i = 0;
        //    //foreach (var item in rptMKTdetailmk)
        //    //{
        //    //    i = i + 1;

        //    //    tbl_MKT_LoaddetailRpt detailpx = new tbl_MKT_LoaddetailRpt();

        //    //    detailpx.stt = i.ToString();
        //    //    detailpx.soluong = item.Issued;
        //    //    detailpx.Username = this.Username;
        //    //    detailpx.materialcode = item.Materiacode;
        //    //    detailpx.tensanpham = item.Materialname;
        //    //    detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));


        //    //    dc.tbl_MKT_LoaddetailRpts.InsertOnSubmit(detailpx);
        //    //    dc.SubmitChanges();

        //    //}








        //    var rptMKThead = (from pp in dc.tbl_MKt_ListLoadheads
        //                      where pp.LoadNumber == this.soload && pp.ShippingPoint == this.storelocation
        //                      select pp).FirstOrDefault();

        //    if (rptMKThead != null)
        //    {
        //        tbl_MKT_WHissueHeadRpt headpx = new tbl_MKT_WHissueHeadRpt();

        //        headpx.Subid = this.subID.ToString();

        //        headpx.username = this.Username;
        //        headpx.Loadnumber = rptMKThead.LoadNumber;
        //        //    headpx.nametransporter = rptMKThead.TransposterName;
        //        headpx.seri = this.storelocation + rptMKThead.LoadNumber + "-" + this.subID;

        //        BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
        //        BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
        //        //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
        //        Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(this.storelocation + rptMKThead.LoadNumber), 1, true), typeof(Byte[]));

        //        headpx.Barcode = result;
        //        headpx.Ngaythang = rptMKThead.Date_Created;
        //        headpx.shippingpoint = rptMKThead.ShippingPoint;

        //        headpx.Storeman = this.Createdby;



        //        dc.tbl_MKT_WHissueHeadRpts.InsertOnSubmit(headpx);
        //        dc.SubmitChanges();

        //    }

        //    //    //var q3 = (from tblEDLP in dc.tblEDLPs
        //    //    //          group tblEDLP by tblEDLP.Invoice_Doc_Nr into OD//Tương đương GROUP BY trong SQL
        //    //    //          orderby OD.Key
        //    //    //          where !(from tblVat in dc.tblVats
        //    //    //                  select tblVat.SAP_Invoice_Number).Contains(OD.Key)

        //    //    //          select new
        //    //    //          {
        //    //    //              Document_Number = OD.Key,
        //    //    //              Name = OD.Select(m => m.Cust_Name).FirstOrDefault(),
        //    //    //              Value_Count = OD.Sum(m => m.Cond_Value)




        //    //    //          });


        //    var rshead = from pp in dc.tbl_MKT_WHissueHeadRpts
        //                 where pp.username == this.Username
        //                 select new
        //                 {
        //                     Storeman = pp.Storeman,
        //                     Subid =    pp.Subid,
        //                     //     codetransporter = pp.codetransporter,
        //                     shippingpoint = pp.shippingpoint,
        //                     Ngaythang = pp.Ngaythang,
        //                     Loadnumber = pp.Loadnumber,
        //                     //      nametransporter = pp.nametransporter,
        //                     //       Truckno = pp.Truckno,
        //                     //     gatepasslist = pp.gatepasslist,
        //                     seri = pp.seri,
        //                     Barcode = pp.Barcode,


        //                 };
        //    Utils ut = new Utils();
        //    var dataset1 = ut.ToDataTable(dc, rshead); // head

        //    //View.Viewtable vx1 = new Viewtable(rshead, dc, "test", 100, "100");
        //    //vx1.ShowDialog();

        //    var rsdetail = from pp in dc.tbl_MKt_WHstoreissues
        //             //      where pp.Serriload == this.Loadnumberserri && pp.IssueIDsub == this.subID
        //                   orderby pp.Materiacode
        //                   select new
        //                   {

        //                       // stt = stt +1,
        //                       Materiacode = pp.Materiacode,
        //                       Materialname = pp.Materialname,
        //                       soluong = pp.Issued,
        //                       //   username = pp.Username,


        //                   };
        //    if (rsdetail.Count()>0)
        //    {
        //        int stt = 0;
        //        foreach (var item in rsdetail)
        //        {


        //            stt = stt + 1;

        //                tbl_MKT_LoaddetailRpt detailpx = new tbl_MKT_LoaddetailRpt();

        //                detailpx.stt = stt.ToString();
        //                detailpx.soluong = item.soluong;
        //                detailpx.Username = this.Username;
        //                detailpx.materialcode = item.Materiacode;
        //                detailpx.tensanpham = item.Materialname;
        //                detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.soluong.ToString()));


        //                dc.tbl_MKT_LoaddetailRpts.InsertOnSubmit(detailpx);
        //                dc.SubmitChanges();





        //        }

        //    }

        //    var rsdetail3 = from pp in dc.tbl_MKT_LoaddetailRpts
        //                   where pp.Username == this.Username
        //                   orderby pp.stt
        //                   select new
        //                   {

        //                       stt = pp.stt,
        //                       tensanpham = pp.tensanpham,
        //                       materialcode = pp.materialcode,
        //                       soluong = pp.soluong,
        //                       //   username = pp.Username,
        //                       bangchu = pp.bangchu,

        //                   };


        //    var dataset2 = ut.ToDataTable(dc, rsdetail3); // detail


        //    Reportsview rpt = new Reportsview(dataset1, dataset2, "PhieuMKWHphieuxuat.rdlc");
        //    rpt.ShowDialog();

        //    //}

        //    //#endregion view reports payment request  // 

        //}

        private void dataGridViewListphieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //string connection_string = Utils.getConnectionstr();
            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //try
            //{
            //    this.soload = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Gate_pass"].Value;
            //    this.storelocation = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Store"].Value;

            //    //Date = pp.Ngaytaophieu,
            //    //             pp.Gate_pass,
            //    //             pp.Requested_by,
            //    //             pp.Purpose,


            //    //             pp.Receiver_by,
            //    //             pp.Customer_SAP_Code,
            //    //             pp.Address,
            //    //             pp.Materiacode,
            //    //             //  pp.MateriaSAPcode,
            //    //             pp.Description,
            //    //             pp.Issued,
            //    //             Store = pp.ShippingPoint,
            //    //             Created_by = pp.Username,
            //    //             pp.id,
            //}
            //catch (Exception)
            //{

            //    //     this.phieuchiid = 0;
            //}


            ////List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            ////var rs = from tbl_dstaikhoan in dc.tbl_dstaikhoans
            ////         where tbl_dstaikhoan.loaitkid == "tien" // tien mat la loai 8
            ////         orderby tbl_dstaikhoan.matk
            ////         select tbl_dstaikhoan;
            ////foreach (var item in rs)
            ////{
            ////    ComboboxItem cb = new ComboboxItem();
            ////    cb.Value = item.matk.Trim();
            ////    cb.Text = item.matk.Trim() + ": " + item.tentk;
            ////    CombomCollection.Add(cb);
            ////}

            ////cbtkco.DataSource = CombomCollection;

            ////#endregion load tk nợ



            ////   try
            ////{
            ////    this.phieuchiid = (int)this.dataGridViewListphieuchi.Rows[this.dataGridViewListphieuchi.CurrentCell.RowIndex].Cells["ID"].Value;


            ////}
            ////catch (Exception)
            ////{

            ////    this.phieuchiid = 0;
            ////}

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

            //    btluu.Enabled = true;


            dateupdate.Enabled = true;




            txtupdateby.Enabled = true;


            //     btluu.Enabled = true;

            //   cbtaikhoanco.Enabled = true;


            this.statusphieu = 2;

        }

        private void txtsophieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txtupdateby.Focus();

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
                //txttenNVT.Focus();

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

            ////   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            ////  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            //foreach (var c in dataGridViewDetail.Columns)
            //{
            //    DataGridViewColumn clm = (DataGridViewColumn)c;
            //    clm.HeaderText = clm.HeaderText.Replace("_", " ");
            //}

            //// Next

        }


        //void cbm_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.BeginInvoke(new MethodInvoker(EndEdit));

        //}

        //     ComboBox cbm;
        //     DataGridViewCell currentCell;

        //  private DateTimePicker cellDateTimePicker = new DateTimePicker();
        // DateTimePicker[] sp = new DateTimePicker[100];

        //void EndEdit()
        //{




        //    //if (cbm != null)
        //    //{
        //    //    if (cbm.SelectedItem != null)
        //    //    {
        //    //        string SelectedItem = (cbm.SelectedItem as ComboboxItem).Value.ToString();// (cbm.SelectedItem as ComboboxItem).Value.ToString();

        //    //        // int i = dataGridProgramdetail.CurrentRow.Index;
        //    //        int i = currentCell.RowIndex;
        //    //        string colname = this.dataGridViewDetail.Columns[this.dataGridViewDetail.CurrentCell.ColumnIndex].Name;

        //    //        dataGridViewDetail.Rows[i].Cells[colname].Value = SelectedItem;





        //    //    }


        //    //}


        //}

        private void dataGridViewTkCo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (e.Control is ComboBox)
            //{

            //    cbm = (ComboBox)e.Control;

            //    if (cbm != null)
            //    {
            //        cbm.SelectedIndexChanged += new EventHandler(cbm_SelectedIndexChanged);
            //    }


            //    currentCell = this.dataGridViewDetail.CurrentCell;




            //}
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

        //private void dataGridViewListphieuchi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{


        //    //var rs = from pp in dc.tbl_MKt_ListLoadheads
        //    //         where pp.ShippingPoint == this.storelocation //pp.Status == "CRT" && 
        //    //         select new
        //    //         {
        //    //             Date = pp.Date_Created,

        //    //             pp.LoadNumber,
        //    //             pp.ShippingPoint,


        //    //             pp.Status,
        //    //             pp.TransposterCode,
        //    //             pp.TransposterName,

        //    //             Created_by = pp.Username,
        //    //             pp.id,

        //    //         };


        //    string shipmentfind = "";
        //    string ShippingPointfind = "";

        //    string connection_string = Utils.getConnectionstr();

        //    //btluu.Enabled = false;
        //    //btsua.Enabled = true;
        //    //btmoi.Enabled = false;


        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //    try
        //    {
        //        shipmentfind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["LoadNumber"].Value.ToString();
        //        ShippingPointfind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["ShippingPoint"].Value.ToString();

        //    }
        //    catch (Exception)
        //    {
        //        //    MessageBox.Show(ex.ToString());
        //        //     this.phieuchiid = 0;
        //    }

        //    #region loaddead so phieu va location
        //    #region // head 
        //    //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();

        //    var rs = (from pp in dc.tbl_MKt_ListLoadheads
        //              where pp.LoadNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

        //              select pp).FirstOrDefault();

        //    if (rs != null)
        //    {
        //        this.soload = shipmentfind;
        //        txtloadnumber.Text = this.soload;


        //        datecreated.Value = (DateTime)rs.Date_Created;// = ;

        //        this.storelocation = rs.ShippingPoint;// = ;




        //        ////  cbkhohang.Items
        //        //foreach (ComboboxItem item in (List<ComboboxItem>)cbkhohang.DataSource)
        //        //{
        //        //    if (item.Value.ToString().Trim() == rs.ShippingPoint.Trim())
        //        //    {
        //        //        cbkhohang.SelectedItem = item;
        //        //    }
        //        //}

        //        //txtnguoitaoload.Text = rs.Created_by;// = ;
        //        //                                     //   rs.Status = "CRT";
        //        //txtloadnumber.Text = this.soload;




        //    }


        //    #endregion


        //    #endregion
        //    //     public void addDEtailLoad(tbl_MKt_Listphieu PhieuMKT)
        //    //{
        //    dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);

        //    #region load detail so phieu va loacation
        //    var rs2 = from pp in dc.tbl_MKt_Listphieus
        //              where pp.ShipmentNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

        //              select pp;

        //    if (rs2.Count() > 0)
        //    {
        //        ///cleartoblankDEtailphieu();
        //        foreach (var item in rs2)
        //        {
        //            addDEtailLoad(item);



        //        }

        //    }

        //    #endregion

        //    tabControl1.SelectedTab = tabPage1;
        //}

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
            if (tabControl1.TabIndex == 1) //  tao phieu

            {


                //    dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);

            }

            //if (tabControl1.TabIndex == 2) //  Danh sách phiếu

            //{
            //    // string valueinput = cb_customerka.Text;

            //    string connection_string = Utils.getConnectionstr();
            //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //    string username = Utils.getusername();


            //    var rs = from pp in dc.tbl_MKt_ListLoadheads
            //             where pp.ShippingPoint == this.storelocation && pp.Status == "CRT"
            //             select new
            //             {
            //                 Date = pp.Date_Created,

            //                 pp.LoadNumber,
            //                 pp.ShippingPoint,


            //                 pp.Status,
            //                 pp.TransposterCode,
            //                 pp.TransposterName,

            //                 Created_by = pp.Username,
            //                 pp.id,

            //             };
            //    dataGridViewListphieu.DataSource = rs;





            //}
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
            //this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();

            //cleartoblankphieu();


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

        //private void btxoa_Click(object sender, EventArgs e)
        //{
        //    bool kq = Model.MKT.Deletephieuload(this.soload, this.storelocation);
        //    Model.MKT.restatusphieuLoadingtoCRT();

        //    //  Model.MKT.DeleteALLphieutamTMP();

        //    //dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);
        //    dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);



        //    if (kq)
        //    {
        //        MessageBox.Show("Delete " + this.soload.ToString() + " done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }

        //}

        private void txtnguoinhan_KeyPress(object sender, KeyPressEventArgs e)
        {







            //  }
        }

        private void dataGridViewDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //     addDEtailPhieuMKT
            //string gatepassfind = "";

            //string connection_string = Utils.getConnectionstr();

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //try
            //{
            //    gatepassfind = this.dataGridViewDetail.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return;
            //}



            ////DataTable dt = new DataTable();


            ////dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Address", typeof(string)));

            //var rs = from pp in dc.tbl_MKt_Listphieus
            //         where pp.Gate_pass == gatepassfind && pp.ShippingPoint == this.storelocation && pp.Status == "CRT"

            //         select pp;

            //if (rs != null)
            //{
            //    foreach (var item in rs)
            //    {
            //        item.Status = "LOADING";
            //        dc.SubmitChanges();

            //        addDEtailLoad(item);
            //    }



            //}

            //dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);




        }

        private void dataGridViewLoaddetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLoaddetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTable dataTable = (DataTable)dataGridViewLoaddetail.DataSource;
            int i = e.RowIndex;

            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    if ((string)dataTable.Rows[i]["Gate_pass"] == PhieuMKT.Gate_pass)
            //    {
            dataTable.Rows.RemoveAt(i);
            //    }
            //}
            dataTable.AcceptChanges();

            //string gatepassfind = "";

            //string connection_string = Utils.getConnectionstr();

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //try
            //{
            //    gatepassfind = this.dataGridViewLoaddetail.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return;
            //}



            ////DataTable dt = new DataTable();


            ////dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Address", typeof(string)));

            //var rs = from pp in dc.tbl_MKt_Listphieus
            //         where pp.Gate_pass == gatepassfind && pp.ShippingPoint == this.storelocation //&& pp.Status == "LOADING"

            //         select pp;

            //if (rs != null)
            //{
            //    foreach (var item in rs)
            //    {
            //        RemoveDEtailLoad(item);
            //        item.Status = "CRT";
            //        dc.SubmitChanges();


            //    }



            //}

            //dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //   string username = Utils.getusername();

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
                                 //       where pp.LoadNumber == this.soload && pp.ShippingPoint == this.storelocation
                             select pp;

            if (rptMKThead.Count() > 0)
            {

                foreach (var item in rptMKThead)
                {


                    tbl_MKT_headRpt_Phieuissue headpx = new tbl_MKT_headRpt_Phieuissue();

                    headpx.Diachi = item.Address;
                    headpx.Nguoinhancode = item.Customer_SAP_Code.ToString();
                    headpx.Username = this.Username;
                    headpx.Sophieu = item.Gate_pass;
                    headpx.Nguoinhanname = item.Receiver_by;
                    headpx.seri = this.storelocation + item.Gate_pass;

                    BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                    BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                    //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                    Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(this.storelocation + item.Gate_pass), 1, true), typeof(Byte[]));

                    headpx.Barcode = result;
                    headpx.dienthoai = item.Tel;
                    headpx.mucdich = item.Purpose;
                    headpx.Ngaythang = item.Ngaytaophieu;
                    headpx.Nguoiyeucau = item.Requested_by;



                    dc.tbl_MKT_headRpt_Phieuissues.InsertOnSubmit(headpx);
                    dc.SubmitChanges();
                }
            }



            var rptMKTdetailmk = from pp in dc.tbl_MKt_Listphieudetails
                                     //    where pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation
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
                detailpx.soluong = item.Issued;
                detailpx.Username = this.Username;
                detailpx.tensanpham = item.Materialname;
                detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));
                detailpx.Sophieu = item.Gate_pass;
                lastgatepass = item.Gate_pass;
                dc.tbl_MKT_DetailRpt_Phieuissues.InsertOnSubmit(detailpx);
                dc.SubmitChanges();

            }

            var rshead = from pp in dc.tbl_MKT_headRpt_Phieuissues
                         where pp.Username == this.Username
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
            Utils ut = new Utils();
            var dataset1 = ut.ToDataTable(dc, rshead); // head

            //View.Viewtable vx1 = new Viewtable(rshead, dc, "test", 100, "100");
            //vx1.ShowDialog();
            var rsdetail = from pp in dc.tbl_MKT_DetailRpt_Phieuissues
                           where pp.Username == this.Username
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
            rpt.ShowDialog();

            //}

            //#endregion view reports payment request  // 
        }

        private void txtseachgate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;


                //          txtseachaddress.Text = "";
                //        txtseachcode.Text = "";
                //       txtseachgate.Text
                //  this.storelocation
                //    dataGridViewDetail

                //    Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);


            }




        }

        private void txtseachcode_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtseachaddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewLoaddetail_Paint(object sender, PaintEventArgs e)
        {

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridViewLoaddetail.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

            // Next


        }

        private void txtmktseri_KeyPress(object sender, KeyPressEventArgs e)
        {

            //   addDEtailPhieuMKT
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //  cbsophieu.

                string seachtext = txtmktseri.Text;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


                #region newwu là phiếu đã tich trong list ở dưới
                for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)
                {
                    try
                    {
                        if (dataGridViewLoaddetail.Rows[idrow].Cells["Gate_pass"].Value != DBNull.Value)
                        {

                            string Gate_pass = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Gate_pass"].Value.ToString().Trim();
                            string Shipping_Point = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Shipping_Point"].Value.ToString().Trim();
                            string Region = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Region"].Value.ToString().Trim();


                            if (Region + Shipping_Point + Gate_pass == seachtext)
                            {
                                txtmktseri.Text = "";


                                MessageBox.Show("Updated as below list ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtmktseri.Focus();



                            }


                        }
                    }
                    catch (Exception)
                    {

                        return;


                    }




                }

                #endregion


                var item = (from pp in dc.tbl_MKt_Listphieudetails
                            where (pp.Region + pp.ShippingPoint + pp.Gate_pass) == seachtext
                            select pp).FirstOrDefault();

                if (item != null)
                {
                    //if (item.Status == "Delivering")// 
                    //{
                        addDEtailPhieuMKT(item);

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Please check, this POSM ticket status is : " + item.Status + " please issue Load: " + item.ShippingPoint + item.ShipmentNumber, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    txtmktseri.Text = "";
                }
                else
                {
                    MessageBox.Show("Please check, wrong POSM ticket !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }







            }
        }

        private void btinphieu_Click(object sender, EventArgs e)
        {



            //dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            //dt.Columns.Add(new DataColumn("Shipping_Point", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_name", typeof(string)));

            //dt.Columns.Add(new DataColumn("Maketting_Status", typeof(string)));
            //dt.Columns.Add(new DataColumn("Maketting_load", typeof(float)));



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            //---------------

            DataTable dataset2 = (DataTable)dataGridViewLoaddetail.DataSource;



            //       PhieuMKTcompleted  dataset2

            Reportsview rpt = new Reportsview(null, dataset2, "PhieuMKTcompleted.rdlc");
            rpt.ShowDialog();

            //  x





        }

        private void btsave_Click(object sender, EventArgs e)
        {

            //dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            //dt.Columns.Add(new DataColumn("Shipping_Point", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Customer_name", typeof(string)));

            //dt.Columns.Add(new DataColumn("Maketting_Status", typeof(string)));
            //dt.Columns.Add(new DataColumn("Maketting_load", typeof(float)));

            #region save


            for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)
            {
                if (dataGridViewLoaddetail.Rows[idrow].Cells["Gate_pass"].Value != DBNull.Value)
                {

                    string Gate_pass = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Gate_pass"].Value;
                    string Shipping_Point = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Shipping_Point"].Value;

                    string connection_string = Utils.getConnectionstr();
                    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                    var rs = from pp in dc.tbl_MKt_Listphieuheads
                             where pp.ShippingPoint == Shipping_Point && pp.Gate_pass == Gate_pass
                             select pp;
                    if (rs.Count() > 0)
                    {
                        foreach (var item in rs)
                        {

                            item.Status = "completed";

                            item.completed = true;
                            item.Date_Received_Issued = dateupdate.Value;
                            //    item.completedby = txtupdateby.Text;
                            item.completedby = this.Username;


                            dc.SubmitChanges();

                        }
                    }

                    #region detai


                    var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                              where pp.ShippingPoint == Shipping_Point && pp.Gate_pass == Gate_pass
                              select pp;
                    if (rs.Count() > 0)
                    {
                        foreach (var item in rs2)
                        {

                            item.Status = "completed";
                            item.Date_Received_Issued = dateupdate.Value;
                            //    item.completedby = txtupdateby.Text;
                            item.Completed_by = this.Username;


                            dc.SubmitChanges();

                        }
                    }

                    #endregion



                }
            } // for


            #endregion 

            btsave.Enabled = false;
            btinphieu.Enabled = true;
            MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  clearbankdetail();


        }

        private void txtmktseri_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
