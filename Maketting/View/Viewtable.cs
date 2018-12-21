using Microsoft.Office.Interop.Excel;
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
        public int viewcode;
        public IQueryable rs;
        LinqtoSQLDataContext db;
        public DataGridView Dtgridview;


        public static string connection_string = Utils.getConnectionstr();

        LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


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
        //    In your thread, you can call the Invoke method on m_TextBox, passing the delegate to call, as well as the parameters.



        //public void Reloadcustomer(String inutstring)

        //{
        //    string connection_string = Utils.getConnectionstr();
        //    //      UpdateDatagridview
        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    //   LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //    var rsthisperiod = from tbl_KaCustomer in dc.tbl_PosCustomers
        //                       where ((int)tbl_KaCustomer.Customer).ToString().Contains(inutstring)
        //                       select tbl_KaCustomer;

        //    Utils ut = new Utils();
        //    dt = ut.ToDataTable(dc, rsthisperiod);

        //    this.dataGridView1.DataSource = dt;


        //}



        void Control_KeyPress(object sender, KeyEventArgs e)
        {
            // if (viewcode == 2)// nuew la bàng salsetemp update

            //if ((viewcode == 2) && e.KeyCode == Keys.F3)
            //{





            //    FormCollection fc = System.Windows.Forms.Application.OpenForms;

            //    bool kq = false;
            //    foreach (Form frm in fc)
            //    {
            //        if (frm.Text == "tblsales")


            //        {
            //            kq = true;
            //            frm.Focus();

            //        }
            //    }

            //    if (!kq)
            //    {
            //        Seachcode sheaching = new Seachcode(this, "tblsales");
            //        sheaching.Show();
            //    }




            //}


        }


        public BindingSource source2;
        public Viewtable(IQueryable rs, LinqtoSQLDataContext dc, string fornname, int viewcode, string valuesave)
        {
            //    this.dataGridView1.DataSource = rs;
            InitializeComponent();
            this.valuesave = valuesave;


            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);

            this.dataGridView1.DataSource = rs;
            this.Dtgridview = dataGridView1;

            this.db = dc;
            this.viewcode = viewcode;
            this.rs = rs;
            //  this.lb_seach.Text = "F3 TÌM KIẾM";
            //      this.bt_sendinggroup.Visible = false;
            //     this.lb_seach.Visible = false;
            this.Pl_endview.Visible = false;
            //   gboxUnpaid.Visible = false; // an nhom field upaid

            this.formlabel.Text = fornname;
            btaddto.Visible = false;
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


            ctrex.exportexceldatagridtofile(this.rs, this.db, this.Text);




        }

        private void bt_addtomaster_Click(object sender, EventArgs e)
        {

        }

        private void bt_themmoi_Click(object sender, EventArgs e)
        {

            #region  // viewcode ==15  storeright


            if (this.viewcode == 15)
            {


                string makh = valuesave;






                View.MKTDanhkhoRight p = new MKTDanhkhoRight(3, -1);  // 3 là thêm ới

                p.ShowDialog();


                //  var rs = Model.MKT.DanhsachnhavantaiMKT(this.db);
                var rs = Model.MKT.danhsachkhoMKTRight(this.db);
                dataGridView1.DataSource = rs;



            }



            #endregion


            #region  // viewcode ==14  la danh nha van tai MKT


            if (this.viewcode == 14)
            {


                string makh = valuesave;






                View.MKTVTDanhsachnhavantai p = new MKTVTDanhsachnhavantai(3, -1);  // 3 là thêm ới

                p.ShowDialog();


                var rs = Model.MKT.DanhsachnhavantaiMKT(this.db);

                dataGridView1.DataSource = rs;



            }



            #endregion


            #region  // viewcode ==13  la danh ct maketting


            if (this.viewcode == 13)
            {


                string makh = valuesave;






                View.MKTVTDanhsacchuongtrinhMKT p = new MKTVTDanhsacchuongtrinhMKT(3, -1);  // 3 là thêm ới

                p.ShowDialog();


                var rs = Model.MKT.DanhsachctMKT(this.db);

                dataGridView1.DataSource = rs;



            }



            #endregion


            #region  // viewcode ==12  la danh khách hàng


            if (this.viewcode == 12)
            {


                string makh = valuesave;






                View.MKTVTDanhsackhachhang p = new MKTVTDanhsackhachhang(3, -1);  // 3 là thêm ới

                p.ShowDialog();


                var rs = Model.MKT.danhkhachhang(this.db);

                dataGridView1.DataSource = rs;



            }



            #endregion

            #region  // viewcode ==16  la danh khách hàng shipto


            if (this.viewcode == 16)
            {


                string makh = valuesave;






                View.MKTVTDanhsacshipto p = new MKTVTDanhsacshipto(3, -1, makh);  // 3 là thêm ới

                p.ShowDialog();

                var rs = Model.MKT.shiptolistbycustomer(this.db, makh);
                //var rs = Model.MKT.shiptolist(this.db);

                dataGridView1.DataSource = rs;



            }



            #endregion








            #region  // viewcode ==4  lA DANH SACH  maketing
            if (this.viewcode == 4)
            {

                Model.Khohang.themmoikhohang();

                var rs1 = Model.MKT.danhsachkhoMKT(dc);

                //   var rs = Model.Khohang.Danhsachkho(this.db);

                dataGridView1.DataSource = rs1;



            }

            #endregion










        }








        private void button2_Click(object sender, EventArgs e)
        {

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


                var rs = Model.MKT.danhsachkhoMKTRight(this.db);

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


                var rs = Model.MKT.DanhsachnhavantaiMKT(this.db);

                dataGridView1.DataSource = rs;



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






                View.MKTVTDanhsacchuongtrinhMKT p = new MKTVTDanhsacchuongtrinhMKT(4, idtk);  // 4 là là xóa sửa

                p.ShowDialog();


                var rs = Model.MKT.DanhsachctMKT(this.db);

                dataGridView1.DataSource = rs;



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


                var rs = Model.MKT.danhkhachhang(this.db);

                dataGridView1.DataSource = rs;



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
    }



}
