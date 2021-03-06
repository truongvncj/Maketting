﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maketting.Control;
using Maketting.shared;
using System.Globalization;
using System.Threading;
using Maketting.Model;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Maketting.View
{

    //   public static DataGridView dataGridView2;// = new DataGridView();

    public partial class Viewtable : Form
    {

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public string valuesave { get; set; }
        public LinqtoSQLDataContext dc { get; set; }



        public int viewcode;
        public IQueryable rs { get; set; }
        //       LinqtoSQLDataContext db;
        public DataGridView Dtgridview;


        //public static string connection_string = Utils.getConnectionstr();

        //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


        //   public List<ComboboxItem> dataCollectionaccount;

        //  public List<ComboboxItem> dataCollectiongroup;//{ get; private set; }
        //1. Định nghĩa 1 delegate


        class datatoExport
        {
            //public DataGridView dataGrid1 { get; set; }
            public System.Data.DataTable datatble { get; set; } // = new System.Data.DataTable();
        }


        public void sumtitleGrid(object inptgridobjiec)
        {

            datatoExport dat = (datatoExport)inptgridobjiec;
            System.Data.DataTable datatble = dat.datatble;
            //    DataGridView dataGrid1 = new DataGridView();
            //   dataGrid1.DataSource = datatble;
            //      double k = dataGrid1.Rows.Count;
            int k = datatble.Rows.Count;
            double Billed_Qty = 0;
            double GSR = 0;
            double UC = 0;
            double PC = 0;
            double NSR = 0;

            try
            {

                for (int i = 0; i < k; i++)
                {
                    #region forr

                    //  datatble.Columns["Billed_Qty"].v


                    if (datatble.Rows[i]["PCs"] != null && Utils.IsValidnumber(datatble.Rows[i]["PCs"].ToString()))
                    {

                        Billed_Qty += double.Parse(datatble.Rows[i]["PCs"].ToString());
                    }

                    if (datatble.Rows[i]["NSR"] != null && Utils.IsValidnumber(datatble.Rows[i]["NSR"].ToString()))
                    {

                        NSR += double.Parse(datatble.Rows[i]["NSR"].ToString());
                    }
                    if (datatble.Rows[i]["UC"] != null && Utils.IsValidnumber(datatble.Rows[i]["UC"].ToString()))
                    {

                        UC += double.Parse(datatble.Rows[i]["UC"].ToString());
                    }
                    if (datatble.Rows[i]["EC"] != null && Utils.IsValidnumber(datatble.Rows[i]["EC"].ToString()))
                    {

                        PC += double.Parse(datatble.Rows[i]["EC"].ToString());
                    }
                    if (datatble.Rows[i]["GSR"] != null && Utils.IsValidnumber(datatble.Rows[i]["GSR"].ToString()))
                    {

                        GSR += double.Parse(datatble.Rows[i]["GSR"].ToString());
                    }

                    //======



                    #endregion forr
                }



                //     Billed_Qty = 100;
                this.lb_bilingqtt.Invoke(new UpdateTextCallback(this.UpdateText),
                                             new object[] { Billed_Qty.ToString(), NSR.ToString(), UC.ToString(), PC.ToString(), GSR.ToString() });


                this.lb_netvalue.Invoke(new UpdateTextCallback(this.UpdateText),
                                            new object[] { Billed_Qty.ToString(), NSR.ToString(), UC.ToString(), PC.ToString(), GSR.ToString() });



                this.lb_countvalue.Invoke(new UpdateTextCallback(this.UpdateText),
                                            new object[] { Billed_Qty.ToString(), NSR.ToString(), UC.ToString(), PC.ToString(), GSR.ToString() });


                this.lb_pc.Invoke(new UpdateTextCallback(this.UpdateText),
                                            new object[] { Billed_Qty.ToString(), NSR.ToString(), UC.ToString(), PC.ToString(), GSR.ToString() });


                this.lb_uc.Invoke(new UpdateTextCallback(this.UpdateText),
                                                 new object[] { Billed_Qty.ToString(), NSR.ToString(), UC.ToString(), PC.ToString(), GSR.ToString() });

                //   MyGetData( tongamount,  tongdeposit,  fullGoodamount,  sumempty);
            }
            catch (Exception)
            {
                Thread.CurrentThread.Abort();
                //       MessageBox.Show(ex.ToString());

                // MessageBox.Show(hh44.ToString());


            }




        }


        private void UpdateText(string Billed_Qty, string NSR, string UC, string PC, string GSR)
        {


            this.lb_bilingqtt.Text = double.Parse(Billed_Qty).ToString("#,#", CultureInfo.InvariantCulture);
            this.lb_netvalue.Text = double.Parse(GSR).ToString("#,#", CultureInfo.InvariantCulture);
            this.lb_countvalue.Text = double.Parse(NSR).ToString("#,#", CultureInfo.InvariantCulture);
            this.lb_pc.Text = double.Parse(PC).ToString("#,#", CultureInfo.InvariantCulture);
            this.lb_uc.Text = double.Parse(UC).ToString("#,#", CultureInfo.InvariantCulture);

            this.Status.Text = "DONE";
            //  this.dataGridView1.Refresh();
        }

        public delegate void UpdateTextCallback(string Billed_Qty, string NSR, string UC, string PC, string GSR);




        void Control_KeyPress(object sender, KeyEventArgs e)
        {

            //MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            //datepick.ShowDialog();

            //DateTime fromdate = datepick.fromdate;
            //DateTime todate = datepick.todate;
            //string store = datepick.Store;

            //bool kq = datepick.chon;

            //if (kq) // nueeus có chọn
            //{
            //    string connection_string = Utils.getConnectionstr();
            //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //    IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentdetail(dc, fromdate, todate, store);


            //    Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL ", 1000, "tk");// mã 5 là danh sach nha nha ccaaps

            //    viewtbl.ShowDialog();


            //}




            #region f12 xem chi tiên


            if (this.viewcode == 55 && this.valuesave == "STORERPT" && e.KeyCode == Keys.F12) // tìm mas sản phẩm
            {

                //    string store = datepick.Store;




                //   int idsanpham = 0;
                string ITEM_Code;
                string Store_code;

                try
                {
                    //    idsanpham = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
                    ITEM_Code = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ITEM_Code"].Value;
                    Store_code = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                    //       END_STOCK = double.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["END_STOCK"].Value.ToString());
                    //     Ordered = double.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Ordered"].Value.ToString());
                    //   Store_code = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;



                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MKTFromdatetodate datepick = new MKTFromdatetodate();
                datepick.ShowDialog();

                DateTime fromdate = datepick.fromdate;
                DateTime todate = datepick.todate;
                bool kq = datepick.chon;

                if (kq) // nueeus có chọn
                {

                    IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentsUMMARYbyproduct(dc, fromdate, todate, Store_code, ITEM_Code);


                    Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT SUMMARY ", 1000, "tksumarystoremovement");// mã 5 là danh sach nha nha ccaaps

                    viewtbl.ShowDialog();


                }




            }


            #endregion f9 xem chi tiet kho

            #region f9 xem chi tiên


            if (this.viewcode == 55 && this.valuesave == "STORERPT" && e.KeyCode == Keys.F9) // tìm mas sản phẩm
            {

                //    string store = datepick.Store;




                //   int idsanpham = 0;
                string ITEM_Code;
                string Store_code;

                try
                {
                    //    idsanpham = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
                    ITEM_Code = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ITEM_Code"].Value;
                    Store_code = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                    //       END_STOCK = double.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["END_STOCK"].Value.ToString());
                    //     Ordered = double.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Ordered"].Value.ToString());
                    //   Store_code = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;



                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MKTFromdatetodate datepick = new MKTFromdatetodate();
                datepick.ShowDialog();

                DateTime fromdate = datepick.fromdate;
                DateTime todate = datepick.todate;
                bool kq = datepick.chon;

                if (kq) // nueeus có chọn
                {
                    //       string connection_string = Utils.getConnectionstr();
                    //     LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                    IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentdetailbyproduct(dc, fromdate, todate, Store_code, ITEM_Code);


                    Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL ", 1000, "tk");// mã 5 là danh sach nha nha ccaaps

                    viewtbl.ShowDialog();

                }




            }


            #endregion f9 xem chi tiet kho


            #region  f6 xem detail của stock movermet

            if (this.valuesave == "tkdetailnhapxuattheosanpham" && e.KeyCode == Keys.F6)
            {
                //p.Document_number,


                //         Input_Output_date = p.date_input_output,


                //         p.Materiacode,
                //         p.MateriaItemcode,
                //         p.Materialname,
                //         p.Issued,
                //         Receipted = p.RecieptQuantity,
                //         Store_code = p.ShippingPoint,
                //         p.DNNumber,
                //         p.POnumber,
                //         p.Transfer_number,
                //         p.LoadNumber,

                //         p.Username,

                //    DateTime fromdate;
                //     DateTime todate;
                string Itemcode;
                string Shippingpoint;
                string shipment;
                try
                {
                    //    fromdate = (DateTime)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["From_date"].Value;
                    //    todate = (DateTime)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["To_date"].Value;
                    Shippingpoint = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                    Itemcode = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["MateriaItemcode"].Value;
                    shipment = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["LoadNumber"].Value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn phải chọn một có số shipment xuất hàng trước ! " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (shipment != "")
                {
                    IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentdetailonecodebygatepass(dc, Shippingpoint, Itemcode, shipment);


                    Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL by Gate pass For this code as below ", 0, "tk");// mã 5 là danh sach nha nha ccaaps
                                                                                                                                        //  lbloodetailbygatepass
                    viewtbl.ShowDialog();
                }




            }

            #endregion

            #region f6 xem ma san pham



            if (this.viewcode == 55 && this.valuesave == "STORERPT" && e.KeyCode == Keys.F6) // tìm mas sản phẩm
            {


                FormCollection fc = System.Windows.Forms.Application.OpenForms;

                bool kq = false;
                foreach (Form frm in fc)
                {
                    if (frm.Text == "List Ordered Detail")


                    {
                        kq = true;
                        frm.Focus();

                    }
                }

                if (!kq)
                {


                    //   int idsanpham = 0;
                    string ITEM_Code;
                    string Store_code;
                    double END_STOCK;
                    double Ordered;
                    //    int idtk = 0;
                    try
                    {
                        //    idsanpham = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
                        ITEM_Code = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ITEM_Code"].Value.ToString();
                        Store_code = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value.ToString();
                        END_STOCK = (double)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["END_STOCK"].Value;
                        Ordered = (double)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Ordered"].Value;
                        //   Store_code = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;



                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Bạn phải chọn một dòng có ordered !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    Main tempman = new Main();

                    MKTWHlistdetailOrdered viewordered = new MKTWHlistdetailOrdered(ITEM_Code, Store_code, END_STOCK, Ordered);
                    viewordered.ShowDialog();

                }





            }
            #endregion

            #region f3 tìm mã san pham




            if (this.viewcode == 55 && this.valuesave == "STORERPT" && e.KeyCode == Keys.F3) // tìm mas sản phẩm
            {


                FormCollection fc = System.Windows.Forms.Application.OpenForms;

                bool kq = false;
                foreach (Form frm in fc)
                {
                    if (frm.Text == "Tìm theo Material Name")


                    {
                        kq = true;
                        frm.Focus();

                    }
                }

                if (!kq)
                {


                    //   int idsanpham = 0;
                    string storelocation = "";
                    //    int idtk = 0;
                    try
                    {
                        //    idsanpham = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
                        storelocation = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                    }
                    catch (Exception)
                    {

                        // MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    Seachcode sheaching = new Seachcode(this, "Tìm theo Material Name", storelocation);
                    sheaching.Show();
                }





            }


            #endregion


            #region f3  // viewocode là 100 tức là tìm phiếu mkt



            if ((viewcode == 100) && e.KeyCode == Keys.F3)
            {





                FormCollection fc = System.Windows.Forms.Application.OpenForms;

                bool kq = false;
                foreach (Form frm in fc)
                {
                    if (frm.Text == "Tìm phiếu MKT")


                    {
                        kq = true;
                        frm.Focus();

                    }
                }

                if (!kq)
                {
                    SeachphieuMKT sheaching = new SeachphieuMKT(this, "Tìm phiếu MKT", this.valuesave); // tkhead  là tìm theo head - - tk là tìm theo detai
                    sheaching.Show();
                }




            }

            #endregion







        }


        public void ReloadsanphamKhotheoso(Viewtable Viewtable, string materialseachname, string storelocation)
        {

            //   Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text, this.region, this.statusphieu);

            //  string connection_string = Utils.getConnectionstr();

            // LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in this.dc.tbl_MKT_Stockends
                     where p.MATERIAL.Contains(materialseachname) && p.Store_code.Contains(storelocation)  // p.Ngaytaophieu >= fromdate && p.Ngaytaophieu <= todate  &&
                                                                                                           //    && p.Status.Contains(materialseachname) && p.Region.Contains(region)
                     select new
                     {

                         p.Store_code,
                         p.SAP_CODE,
                         p.ITEM_Code,

                         // pp.RegionBudgeted,


                         p.MATERIAL,

                         p.Description,

                         p.END_STOCK,
                         p.UNIT,

                         p.Ordered,
                         p.TransferingOUT,
                         p.ON_Hold,
                         p.Quantity_Per_Pallet,
                         p.End_Stock_By_Pallet,

                         p.id,


                     };




            Viewtable.dataGridView1.DataSource = rs;
            //   dataGridView1.Columns["End_Stock_By_Pallet"].DefaultCellStyle.Format = "N0";


            this.rs = rs;

            //  throw new NotImplementedException();
        }


        public void ReloadPhieuMKTtheoso(Viewtable Viewtable, string MKTnumber, string txtname, string region, string statusphieu)
        {

            //   Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text, this.region, this.statusphieu);

            //  string connection_string = Utils.getConnectionstr();

            // LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in this.dc.tbl_MKt_Listphieudetails
                     where p.Gate_pass.Contains(MKTnumber) && p.Receiver_by.Contains(txtname)  // p.Ngaytaophieu >= fromdate && p.Ngaytaophieu <= todate  &&
                     && p.Status.Contains(statusphieu) && p.Region.Contains(region)
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,

                         p.Requested_by,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Tel,
                         p.Address,

                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         p.pallet,
                         Return_request = p.Returnrequest,
                         p.Price,
                         p.Tranposterby,
                         p.Truck,
                         p.Loadingby,
                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Returnby,
                         p.Return_reason,

                         p.Note,




                         //    ID = p.id,
                     };







            Viewtable.dataGridView1.DataSource = rs;

            this.rs = rs;

            //  throw new NotImplementedException();
        }

        public void ReloadPhieuMKTtheosohead(Viewtable Viewtable, string MKTnumber, string txtname, string region, string statusphieu)
        {



            //  string connection_string = Utils.getConnectionstr();

            // LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in this.dc.tbl_MKt_Listphieuheads
                     where p.Gate_pass.Contains(MKTnumber) && p.Receiver_by.Contains(txtname)  // p.Ngaytaophieu >= fromdate && p.Ngaytaophieu <= todate  &&
                     && p.Status.Contains(statusphieu) && p.Region.Contains(region)
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.Note,

                         p.ShippingPoint,

                         p.Requested_by,
                         p.Tel,

                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         Soldto_address = p.Address,
                         Shipto_Address = p.ShiptoAddress,




                         //    ID = p.id,
                     };







            Viewtable.dataGridView1.DataSource = rs;

            this.rs = rs;

            //  throw new NotImplementedException();
        }




        //   Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT SUMMARY ", 1000, "tk");// mã 5 là danh sach nha nha ccaaps



        public BindingSource source2;


        public Viewtable(IQueryable rs, LinqtoSQLDataContext dc, string fornname, int viewcode, string valuesave)
        {
            //    this.dataGridView1.DataSource = rs;
            InitializeComponent();
            this.valuesave = valuesave;

            this.viewcode = viewcode;
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);

            this.dataGridView1.DataSource = rs;
            this.Dtgridview = dataGridView1;

            lb_lookdetail.Visible = false;

            this.dc = dc;

            this.rs = rs;
            //  this.lb_seach.Text = "F3 TÌM KIẾM";
            //      this.bt_sendinggroup.Visible = false;
            //     this.lb_seach.Visible = false;
            this.Pl_endview.Visible = false;
            //   gboxUnpaid.Visible = false; // an nhom field upaid
            btforEinvoice.Visible = false;
            this.formlabel.Text = fornname;
            btaddto.Visible = false;
            bt_themmoi.Visible = false;
            bt_sua.Visible = false;
            btaddto.Visible = false;


            if (viewcode == 55) // 55 chỉ view và exports
            {
                bt_themmoi.Visible = true;
                bt_sua.Visible = false;
                btaddto.Visible = false;


                //  lbseach.Visible = false;
            }

            if (this.valuesave == "STORERPT")
            {
                lb_lookdetail.Visible = true;
                lbf12stockmovementsum.Visible = true;
                lbf9stocmovementdetail.Visible = true;
            }
            //     Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL For this code as below ", 1000, "tkdetailnhapxuattheosanpham");// mã 5 là danh sach nha nha ccaaps
            //  lbloodetailbygatepass
            if (this.valuesave == "tkdetailnhapxuattheosanpham")
            {
                lbloodetailbygatepass.Visible = true;
            }

            //  



            if (this.valuesave == "tksumarystoremovement")
            {
                lbdobleclickformore.Visible = true;
            }


            if (viewcode == 1000) // 55 chỉ view và exports
            {
                bt_themmoi.Visible = false;
                bt_sua.Visible = false;
                btaddto.Visible = false;
                lbseach.Visible = false;
                btforEinvoice.Visible = true;
            }

            if (viewcode == 100)
            {
                bt_themmoi.Visible = false;
                bt_sua.Visible = false;

            }
            if (viewcode == 101) // là them oi san pham
            {
                bt_themmoi.Visible = false;
                bt_sua.Visible = false;
                btaddto.Visible = true;

            }
            this.lb_totalrecord.Text = dataGridView1.RowCount.ToString("#,#", CultureInfo.InvariantCulture);// ;//String.Format("{0:0,0}", k33q); 
                                                                                                            //  this.lb_totalrecord.ForeColor = Color.Chocolate;
                                                                                                            //   this.Show();
            this.KeyPreview = true;

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridView1.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

            // Next


        }

        private void bt_exporttoex_Click(object sender, EventArgs e)
        {
            Control_ac ctrex = new Control_ac();


            ctrex.exportexceldatagridtofile(this.rs, this.dc, this.Text);




        }


        private void bt_addtomaster_Click(object sender, EventArgs e)
        {

        }

        private void bt_themmoi_Click(object sender, EventArgs e)
        {

            if (this.viewcode == 55)
            {

                //    STORERPT
                string storecode = "";
                #region View.Viewtable tbl = new Viewtable(rs5, dc, "STORE REPORTS", 55, "STORERPT"); tạo sản  phẩm mới của kho
                try
                {
                    storecode = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // mahieuct = "0";
                    return;
                }



                MKTsanphammoi spmaoi = new MKTsanphammoi(1, 0, storecode, this);
                spmaoi.ShowDialog();



                #endregion


            }

            #region  // viewcode ==19  sales orge list


            if (this.viewcode == 19)
            {


                //       string makh = valuesave;






                View.MKTSalesOrglist p = new MKTSalesOrglist(3, -1);  // 3 là thêm ới

                p.ShowDialog();



                var rs = Model.MKT.danhsachsalesorglist(this.dc);
                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion



            #region  // viewcode ==18  region list


            if (this.viewcode == 18)
            {


                //       string makh = valuesave;






                View.MKTRegionllist p = new MKTRegionllist(3, -1);  // 3 là thêm ới

                p.ShowDialog();



                var rs = Model.MKT.danhsachregionlist(this.dc);
                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion



            #region  // viewcode ==17  channel list


            if (this.viewcode == 17)
            {


                //       string makh = valuesave;






                View.MKTCustomerchanellist p = new MKTCustomerchanellist(3, -1);  // 3 là thêm ới

                p.ShowDialog();



                var rs = Model.MKT.danhsachcustomerChannel(this.dc);
                dataGridView1.DataSource = rs;
                this.rs = rs;


            }



            #endregion



            #region  // viewcode ==16  la danh khách hàng shipto


            if (this.viewcode == 16)
            {


                string makh = valuesave;






                View.MKTVTDanhsacshipto p = new MKTVTDanhsacshipto(3, -1, makh);  // 3 là thêm ới

                p.ShowDialog();

                var rs = Model.MKT.shiptolistbycustomer(this.dc, makh);
                //var rs = Model.MKT.shiptolist(this.dc);

                dataGridView1.DataSource = rs;


                this.rs = rs;
            }



            #endregion





            #region  // viewcode ==15  storeright


            if (this.viewcode == 15)
            {


                string makh = valuesave;






                View.MKTDanhkhoRight p = new MKTDanhkhoRight(3, -1);  // 3 là thêm ới

                p.ShowDialog();


                //  var rs = Model.MKT.DanhsachnhavantaiMKT(this.dc);
                var rs = Model.MKT.danhsachkhoMKTRight(this.dc);
                dataGridView1.DataSource = rs;
                this.rs = rs;


            }



            #endregion


            #region  // viewcode ==14  la danh nha van tai MKT


            if (this.viewcode == 14)
            {


                string makh = valuesave;






                View.MKTVTDanhsachnhavantai p = new MKTVTDanhsachnhavantai(3, -1);  // 3 là thêm ới

                p.ShowDialog();


                var rs = Model.MKT.DanhsachnhavantaiMKT(this.dc);

                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion


            #region  // viewcode ==13  la danh ct maketting


            if (this.viewcode == 13)
            {


                string mahieuct = "";

                //      int idtk = 0;
                try
                {
                    mahieuct = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Số_hiệu_CT"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một chương trình !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mahieuct = "0";
                    // return;
                }





                View.MKTVTDanhsacchuongtrinhMKT p = new MKTVTDanhsacchuongtrinhMKT(3, -1, mahieuct);  // 3 là thêm ới

                p.ShowDialog();


                var rs = Model.MKT.DanhsachctMKT(this.dc);

                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion


            #region  // viewcode ==12  la danh khách hàng


            if (this.viewcode == 12)
            {


                string makh = valuesave;






                View.MKTVTDanhsackhachhang p = new MKTVTDanhsackhachhang(3, -1);  // 3 là thêm ới

                p.ShowDialog();


                var rs = Model.MKT.danhkhachhang(this.dc);

                dataGridView1.DataSource = rs;


                this.rs = rs;
            }



            #endregion







            #region  // viewcode ==4  lA DANH SACH  maketing
            if (this.viewcode == 4)
            {

                Model.Khohang.themmoikhohang();

                var rs1 = Model.MKT.danhsachkhoMKT(dc);

                //   var rs = Model.Khohang.Danhsachkho(this.dc);

                dataGridView1.DataSource = rs1;

                this.rs = rs1;

            }

            #endregion










        }








        private void button2_Click(object sender, EventArgs e)
        {

            #region  // viewcode ==19  la sale org


            if (this.viewcode == 19)
            {

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //     string makh = valuesave;






                View.MKTSalesOrglist p = new MKTSalesOrglist(4, idtk);  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.danhsachsalesorglist(this.dc);

                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion


            #region  // viewcode ==18  la region


            if (this.viewcode == 18)
            {

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //     string makh = valuesave;






                View.MKTRegionllist p = new MKTRegionllist(4, idtk);  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.danhsachregionlist(this.dc);

                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion


            #region  // viewcode ==17  la channel


            if (this.viewcode == 17)
            {

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //     string makh = valuesave;






                View.MKTCustomerchanellist p = new MKTCustomerchanellist(4, idtk);  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.danhsachcustomerChannel(this.dc);

                dataGridView1.DataSource = rs;



            }



            #endregion



            #region  // viewcode ==16  la danh khách hàng shipto
            //     Viewtable viewtbl = new Viewtable(rs1, dc, "SHIPTO CODE LIST", 16, customercode);// mã 16 là danh sach shipto list


            if (this.viewcode == 16)
            {


                string makh = valuesave;

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }





                View.MKTVTDanhsacshipto p = new MKTVTDanhsacshipto(4, idtk, makh);  // 4 là sửa

                p.ShowDialog();

                var rs = Model.MKT.shiptolistbycustomer(this.dc, makh);
                //var rs = Model.MKT.shiptolist(this.dc);

                dataGridView1.DataSource = rs;


                this.rs = rs;
            }



            #endregion








            #region  // viewcode ==15 la dannhóm quen kho


            if (this.viewcode == 15)
            {

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //     string makh = valuesave;






                View.MKTDanhkhoRight p = new MKTDanhkhoRight(4, idtk);  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.danhsachkhoMKTRight(this.dc);

                dataGridView1.DataSource = rs;



            }



            #endregion


            #region  // viewcode ==14 la danh nha van tai MKt


            if (this.viewcode == 14)
            {

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một chương trình !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //     string makh = valuesave;






                View.MKTVTDanhsachnhavantai p = new MKTVTDanhsachnhavantai(4, idtk);  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.DanhsachnhavantaiMKT(this.dc);

                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion








            #region  // viewcode ==13 la danh CT MKT


            if (this.viewcode == 13)
            {

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một chương trình !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //     string makh = valuesave;






                View.MKTVTDanhsacchuongtrinhMKT p = new MKTVTDanhsacchuongtrinhMKT(4, idtk, "0");  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.DanhsachctMKT(this.dc);

                dataGridView1.DataSource = rs;


                this.rs = rs;
            }



            #endregion









            #region  // viewcode ==12  la danh khách hàng


            if (this.viewcode == 12)
            {

                int idtk = 0;
                try
                {
                    idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một khách hàng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //     string makh = valuesave;






                View.MKTVTDanhsackhachhang p = new MKTVTDanhsackhachhang(4, idtk);  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.danhkhachhang(this.dc);

                dataGridView1.DataSource = rs;

                this.rs = rs;

            }



            #endregion














            #region viewdco = 4 la danh sahc kho


            if (this.viewcode == 4)  // viewcode ==4  lA DANH SACH  kho hàng
            {
                int iddskho = 0;
                try
                {
                    iddskho = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;



                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một kho !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Model.Khohang.suaxoadanhsachkho(iddskho);



                var rs1 = Model.MKT.danhsachkhoMKT(dc);

                dataGridView1.DataSource = rs1;


                this.rs = rs;
            }
            #endregion














        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Viewtable_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btaddto_Click(object sender, EventArgs e)
        {


            #region      //    this.valuesave  là username của bảng temp




            var rs5 = from pp in dc.tbl_MKT_StockendTMPs
                      where pp.Username == valuesave
                      select pp;

            if (rs5.Count() > 0)
            {

                foreach (var item in rs5)
                {

                    // check có trùng mã code không

                    var checkitemcode = from pp in dc.tbl_MKT_Stockends
                                        where pp.ITEM_Code == item.ITEM_Code
                                        && pp.Store_code == item.Store_code
                                        select pp;

                    var checksapcode = from pp in dc.tbl_MKT_Stockends
                                       where pp.SAP_CODE == item.SAP_CODE
                                          && pp.Store_code == item.Store_code
                                       select pp;

                    // neu ko trung thì xóa từ temp di và add to stornew

                    if (checkitemcode.Count() == 0 && checksapcode.Count() == 0)
                    {
                        tbl_MKT_Stockend newproduct = new tbl_MKT_Stockend();

                        newproduct.ITEM_Code = item.ITEM_Code;
                        newproduct.MATERIAL = item.MATERIAL;

                        newproduct.SAP_CODE = item.SAP_CODE;

                        newproduct.Store_code = item.Store_code;

                        newproduct.UNIT = item.UNIT;

                        newproduct.END_STOCK = item.END_STOCK;

                        newproduct.Description = item.Description;

                        dc.tbl_MKT_Stockends.InsertOnSubmit(newproduct);
                        dc.SubmitChanges();

                        dc.tbl_MKT_StockendTMPs.DeleteOnSubmit(item);// delet tempitem
                        dc.SubmitChanges();


                    }



                }

            }






            #endregion


            var rs6 = from pp in dc.tbl_MKT_StockendTMPs
                      where pp.Username == valuesave
                      select pp;


            this.dataGridView1.DataSource = rs6;

            if (rs6.Count() > 0)
            {
                MessageBox.Show("There are dublicate code can not add to Product list ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            #region viewdetail moverment one code of sumary
            if (this.valuesave == "tksumarystoremovement")
            {



                DateTime fromdate;
                DateTime todate;
                string Itemcode;
                string Shippingpoint;
                try
                {
                    fromdate = (DateTime)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["From_date"].Value;
                    todate = (DateTime)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["To_date"].Value;
                    Shippingpoint = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Shipping_point"].Value;
                    Itemcode = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["MateriaL_Item_code"].Value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn phải chọn 1 sản phẩm trước ! " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentdetailonecode(dc, fromdate, todate, Shippingpoint, Itemcode);


                Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL For this code as below ", 1000, "tkdetailnhapxuattheosanpham");// mã 5 là danh sach nha nha ccaaps
                                                                                                                                                //  lbloodetailbygatepass
                viewtbl.ShowDialog();









            }


            #endregion  viewdetail moverment one code of sumary

            #region   revert transfer in reverttransferin
            //   var rs = from pp in dc.tbl_MKt_WHstoreissues
            //          where pp.t == transfernumber
            //       select pp;

            //     xx
            if (this.valuesave == "reverttransferin")
            {
              //  int id;
                int idsub;
                string Transfer_number;
                try
                {
                    //   id = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
                    idsub = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["IssueIDsub"].Value;
                    Transfer_number = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Transfer_number"].Value;

                }
                catch (Exception)
                {
                    return;
                    //  throw;
                }



                DialogResult kq2 = MessageBox.Show("Bạn có chăc revert doc Transfer number: " + Transfer_number + " Subid " + idsub.ToString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // bool kq;
                switch (kq2)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:

                        string connection_string = Utils.getConnectionstr();
                        LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


                        #region giảm số budget




                        #endregion

                        var headTR = (from pp in dc.tbl_MKt_TransferoutHEADs
                                      where pp.Tranfernumber == Transfer_number
                                      select pp);
                        if (headTR.Count() > 0)
                        {
                            foreach (var item2 in headTR)
                            {
                                item2.Status = "CRT";
                                dc.SubmitChanges();
                            }
                        }


                        #region  giảm ở detail tranfer in 

                        var detaitranferin = from pp in dc.tbl_MKt_TransferINdetails
                                             where pp.Tranfernumber == Transfer_number
                                                      && pp.IssueIDsub == idsub

                                             select pp;

                        if (detaitranferin != null)
                        {

                            dc.tbl_MKt_TransferINdetails.DeleteAllOnSubmit(detaitranferin);
                            dc.SubmitChanges();

                        }

                        #endregion


                        #region  giảm ở kho



                        var khoissue = (from pp in dc.tbl_MKt_WHstoreissues
                                        where pp.Transfer_number == Transfer_number
                                                           && pp.IssueIDsub == idsub

                                        select pp);

                        if (khoissue != null)
                        {




                            #region  xóa tồn kho đã nhập

                            dc.tbl_MKt_WHstoreissues.DeleteAllOnSubmit(khoissue);
                            dc.SubmitChanges();

                            #endregion

                            MessageBox.Show("Revert transfer in " + Transfer_number + " done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        #endregion
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            #endregion


            #region revert good rêcipt



            if (this.valuesave == "revertPogoodreceipt")
            {
                int id;
                int idsub;
                string POnumber;
                try
                {
                    id = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
                    idsub = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Subid"].Value;
                    POnumber = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["POnumber"].Value;

                }
                catch (Exception)
                {
                    return;
                    //  throw;
                }



                DialogResult kq1 = MessageBox.Show("Bạn có chăc revert doc PO: " + POnumber.ToString() + " ID: " + id.ToString() + " Subid " + idsub.ToString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // bool kq;
                switch (kq1)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:

                        string connection_string = Utils.getConnectionstr();
                        LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


                        tbl_MKt_WHstoreissue khoissue = (from pp in dc.tbl_MKt_WHstoreissues
                                                         where pp.POnumber == POnumber
                                                         && pp.id == id
                                                         && pp.IssueIDsub == idsub

                                                         select pp).FirstOrDefault();

                        if (khoissue != null)
                        {
                            #region  giảm ở detail PO

                    //        Model.MKT.giamtrudetailPOkhirevertgoodreceipt(khoissue);







                            #endregion


                            #region giảm budget vùng

                            var budgetvung = from pp in dc.tbl_MKT_StockendRegionBudgets
                                             where pp.POnumber == POnumber
                                                 && pp.idsub == idsub
                                             select pp;

                            dc.tbl_MKT_StockendRegionBudgets.DeleteAllOnSubmit(budgetvung);
                            dc.SubmitChanges();
                            #endregion

                            #region giảm tồn kho 



                            Model.MKT.giamtrukhokhirevertgoodreceipt(khoissue);

                            #endregion


                            #region  xóa tồn kho đã nhập

                            dc.tbl_MKt_WHstoreissues.DeleteOnSubmit(khoissue);
                            dc.SubmitChanges();

                            #endregion

                            MessageBox.Show("Revert done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //   this.updateNewAllToolStripMenuItem.Enabled = false;
                        //   this.reportsToolStripMenuItem.Enabled = false;


                        //     md.productlistinput();


                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }


            }


            #endregion revert good rêcipt

            #region  tìm PO


            if (this.viewcode == 1000 && (this.valuesave == "tkRedeviceGRforRegion"))  // nếu là double clik trong mục po deviec region
            {


                string Ponumber = "";
                int id;
                int subid;
                //pp.POnumber,



                try
                {
                    Ponumber = (string)dataGridView1.Rows[e.RowIndex].Cells["POnumber"].Value.ToString();
                    id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                    subid = (int)dataGridView1.Rows[e.RowIndex].Cells["Subid"].Value;

                    //     this.Close();

                    //  this.Close();

                    //     region = this.dataGridView1.Rows[e.RowIndex].Cells["Region"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tim PO bị lỗi:" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MKTNhaphangtheoPOredeviceforRegion reDevice = new MKTNhaphangtheoPOredeviceforRegion(Ponumber, id, subid);

                reDevice.Show();



            }



            #endregion


            #region  viewdetail 100 tạo phieu               phiếu
            if (this.viewcode == 100 && (this.valuesave == "tk" || this.valuesave == "tkhead"))
            {

                if (!Username.getMakettingright())
                {
                    //  View.MKTNoouthourise view = new MKTNoouthourise();
                    //   view.ShowDialog();
                    return;
                }


                string sophieufind = "";
                // string region = "";
                string storelocationfind = "";
                //      LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
                try
                {
                    sophieufind = this.dataGridView1.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();
                    storelocationfind = this.dataGridView1.Rows[e.RowIndex].Cells["ShippingPoint"].Value.ToString();
                    //  region = this.dataGridView1.Rows[e.RowIndex].Cells["Region"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tìm số phiếu bị lỗi: " + ex.ToString());
                    //     this.phieuchiid = 0;
                }

                View.Main main = new Main();


                //    MKTissuereturnRequest

                var ktrabienban = (from pp in dc.tbl_MKt_Listphieuheads
                                   where pp.ShippingPoint == storelocationfind
                                   && pp.Gate_pass == sophieufind

                                   select pp.requestReturn).FirstOrDefault();



                if (ktrabienban == true)
                {
                    View.MKTissuereturnRequest accsup1 = new MKTissuereturnRequest(main, sophieufind, storelocationfind);
                    accsup1.ShowDialog();

                }
                else
                {
                    View.MKTissuephieu2 accsup = new MKTissuephieu2(main, sophieufind, storelocationfind);
                    accsup.ShowDialog();
                }





                //    MKTissuephieu2 viewphieu = new MKTissuephieu2()


            }
            #endregion

            #region  // viewcode ==55  sửa code sản phẩm


            if (this.viewcode == 55 && this.valuesave == "STORERPT")
            {


                if (!Username.getchangeProductright())
                {
                    //  View.MKTNoouthourise view = new MKTNoouthourise();
                    //   view.ShowDialog();
                    return;
                }




                //       string makh = valuesave;


                int idsanpham = 0;
                string storelocation = "";
                //    int idtk = 0;
                try
                {
                    idsanpham = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
                    storelocation = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn phải chọn một dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }









                View.MKTsanphammoi p = new MKTsanphammoi(4, idsanpham, storelocation, this);  // 3 là thêm ới

                p.ShowDialog();

                //var rs6 = from pp in dc.tbl_MKT_StockendTMPs
                //          where pp.Username == valuesave
                //          select pp;




                //this.dataGridView1.DataSource = rs6;
                // Reloadtonkhotheolocation(this, storelocation);

                var rs6 = from pp in dc.tbl_MKT_Stockends
                          where pp.Store_code == storelocation
                          select new
                          {

                              pp.Store_code,
                              pp.SAP_CODE,
                              pp.ITEM_Code,

                              // pp.RegionBudgeted,


                              pp.MATERIAL,

                              pp.Description,

                              pp.END_STOCK,
                              pp.UNIT,

                              pp.Ordered,
                              pp.TransferingOUT,
                              pp.ON_Hold,
                              pp.Quantity_Per_Pallet,
                              pp.End_Stock_By_Pallet,

                              pp.id,


                          };



                this.dataGridView1.DataSource = rs6;

                //   dataGridView1.Columns["End_Stock_By_Pallet"].DefaultCellStyle.Format = "N0";

                this.rs = rs6;




            }



            #endregion



            #region  view pdf file

            if (this.valuesave == "Schemeprograme")
            {

                //     view file pdf  programe
                {

                    if (this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ProgrameIDDocno"].Value != DBNull.Value )
                    {
                        #region




                        string ProgrameIDDocno = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ProgrameIDDocno"].Value;



                        SaveFileDialog thedialog = new SaveFileDialog();
                        //


                        //   datagridview datagridview1 = new datagridview();
                        //   datagridview1.datasource = datagrid.datasource;

                        thedialog.Title = "export: " + ProgrameIDDocno + "  to PDF file";
                        thedialog.Filter = "PDF files|*.pdf";
                        thedialog.InitialDirectory = @"c:\";
                        thedialog.FileName = "downloadfile";


                        if (thedialog.ShowDialog() == DialogResult.OK)
                        {

                            string filePath = thedialog.FileName.ToString();

                            //     string id;
                            //       FileStream FS = null;

                            //      byte[] dbbyte;
                            try
                            {
                                //Get a stored PDF bytes
                                //   dbbyte = (byte[])dr["UploadFiles"];


                                //store file Temporarily 
                                string connection_string = Utils.getConnectionstr();
                                var db = new LinqtoSQLDataContext(connection_string);

                                //          using (var sqlWrite = new SqlCommand("insert into tbl_MKT_Programepdfdata (Name,Contentype,Data,ProgrameIDDocno)" + " values (@Name, @type, @Data, @ProgrameIDDocno)", varConnection))

                                using (SqlConnection sqlconnection = new SqlConnection(connection_string))
                                {
                                    sqlconnection.Open();

                                    string selectQuery = string.Format(@"Select tbl_MKT_Programepdfdata.Data   From tbl_MKT_Programepdfdata  Where tbl_MKT_Programepdfdata.ProgrameIDDocno = @ProgrameIDDocno");

                                    // Read File content from Sql Table 
                                    SqlCommand selectCommand = new SqlCommand(selectQuery, sqlconnection);

                                    selectCommand.Parameters.Add("@ProgrameIDDocno", SqlDbType.NVarChar).Value = Utils.Truncate(ProgrameIDDocno, 50);


                                    SqlDataReader reader = selectCommand.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        byte[] fileData = (byte[])reader[0];

                                        // Write/Export File content into new text file
                                        File.WriteAllBytes(filePath, fileData);
                                    }
                                }


                                //Assign File path create file


                                //     FS = new FileStream(filepath, System.IO.FileMode.Create);



                                //Write bytes to create file
                                //    FS.Write(dbbyte, 0, dbbyte.Length);



                                // Open file after write 
                                //Create instance for process class
                                Process Proc = new Process();
                                //assign file path for process
                                Proc.StartInfo.FileName = filePath;
                                Proc.Start();
                            }
                            catch (Exception ex)
                            {
                                // throw new System.ArgumentException(ex.Message);

                                //  ex.Message.ToString();
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                //Close FileStream instance
                                //   FS.Close();
                            }










                        }


                        #endregion


                    }

                }

            }
            #endregion









        }

        //private void btforEinvoice_Click(object sender, EventArgs e)
        //{
        //    Control_ac ctrex = new Control_ac();

        //    //xóa file templeate cùng user
        //    string urs = Utils.getusername();

        //    var rs = from pp in dc.EinvoiceExports
        //             where pp.Username == urs // && pp.Status == "TMP"
        //             select pp;

        //    if (rs.Count() > 0)
        //    {

        //        dc.EinvoiceExports.DeleteAllOnSubmit(rs);
        //        dc.SubmitChanges();
        //        //  dc.Connection.Close();
        //    }

        //    //tính file einvoice





        //    //tính file einvoice
        //    int sodem = 0;
        //    for (int idrow = 0; idrow < dataGridView1.RowCount; idrow++)
        //    {

        //      //  MessageBox.Show(" test " + dataGridView1.Rows[idrow].Cells["id"].Value.ToString());


        //        if (dataGridView1.Rows[idrow].Cells["id"].Value != DBNull.Value)
        //        {
        //            int idphieu = (int)dataGridView1.Rows[idrow].Cells["id"].Value;
        //            sodem = sodem + 1;
        //            var headphieu = (from pp in dc.tbl_MKt_Listphieuheads
        //                             where pp.id == idphieu// && pp.Status == "TMP"
        //                             select pp).FirstOrDefault();

        //            var cus = (from pp in dc.tbl_MKT_Soldtocodes
        //                       where pp.Customer == headphieu.Customer_SAP_Code.ToString()
        //                       && pp.Region == headphieu.ShippingPoint
        //                       select pp).FirstOrDefault();

        //            var detailphieu = from pp in dc.tbl_MKt_Listphieudetails
        //                              where pp.Gate_pass == headphieu.Gate_pass && pp.ShippingPoint == headphieu.ShippingPoint
        //                              select pp;

        //            foreach (var phieudetail in detailphieu)
        //            {

        //                EinvoiceExport EinvoiceExport = new EinvoiceExport();
        //                EinvoiceExport.Username = urs;
        //                EinvoiceExport.Nhóm_số_hóa_đơn = sodem.ToString();
        //                EinvoiceExport.Ngày_hóa_đơn = DateTime.Today;
        //                EinvoiceExport.Loại_tiền_tệ = "VND";
        //                EinvoiceExport.Ký_hiệu = "HN/18E";
        //                EinvoiceExport.Mã_khách_hàng = headphieu.Customer_SAP_Code.ToString();
        //                EinvoiceExport.Hình_thức_thanh_toán = "2";
        //                EinvoiceExport.Đvt = "222";


        //                EinvoiceExport.Mã_Hàng_hóa = phieudetail.MateriaSAPcode;
        //                EinvoiceExport.Tên_hành_hóa__dịch_vụ = phieudetail.Materialname;
        //                EinvoiceExport.Số_lượng = phieudetail.Issued;

        //                if (cus != null)
        //                {
        //                    EinvoiceExport.Tên_đơn_vị = cus.FullNameN;
        //                    EinvoiceExport.Mã_số_thuế = cus.VATregistrationNo;

        //                    EinvoiceExport.Địa_chỉ = cus.Street + " " + cus.District + " " + cus.City;
        //                    EinvoiceExport.Số_điện_thoại = cus.Telephone1;
        //                    EinvoiceExport.Email = cus.email1;

        //                }

        //                if (headphieu.DoiD == "")
        //                {
        //                    EinvoiceExport.Đơn_giá = 0;
        //                    EinvoiceExport.Thành_tiền = 0;
        //                    EinvoiceExport.Thuế_suất_GTGT = 0;
        //                    EinvoiceExport.Tiền_Thuế_GTGT = 0;

        //                }
        //                else
        //                {
        //                    double giaPOgannhat = MKT.getgiaPOgannhat(phieudetail.MateriaSAPcode);
        //                    EinvoiceExport.Đơn_giá = giaPOgannhat;
        //                    EinvoiceExport.Thành_tiền = phieudetail.Issued * giaPOgannhat;
        //                    EinvoiceExport.Thuế_suất_GTGT = 10;
        //                    EinvoiceExport.Tiền_Thuế_GTGT = phieudetail.Issued * giaPOgannhat * 0.1;

        //                }


        //                dc.EinvoiceExports.InsertOnSubmit(EinvoiceExport);
        //                dc.SubmitChanges();
        //            } // for ec detial 



        //        } // if  line have makt number

        //    } // for ech line





        //    // kết xuất ra file
        //    IQueryable iquery2 = from pp in dc.EinvoiceExports
        //                         where pp.Username == urs // && pp.Status == "TMP"
        //                         select pp;


        //    ctrex.exportexceldatagridtofile(iquery2, this.dc, this.Text);
        //    // kết xuất ra file

        //}



    }



}
