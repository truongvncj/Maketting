using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using Maketting.Model;
using Maketting.Control;
//using BEEACCOUNT.Entity;

using System.Threading;
using System.Data.SqlClient;
using Maketting.shared;
//using System.Collections.Generic;
//using System.Linq;

namespace Maketting.View
{
    public partial class Main : Form
    {

        // public 
        //   private string rptname;
        //    private IQueryable rs1;
        //      private IQueryable rs2;
        //
        public void messagetext(string message, Color colornen)
        {
            //messageinfor.Text = message;
            //  messageinfor.BackColor = colornen;

        }

        public void clearpannel()
        {


            panelmain.Controls.Clear();


        }

        public void clearpannelload(Form Formload)
        {


            //   View.Beemainload accsup = new Beemainload(this);

            Formload.TopLevel = false;
            Formload.AutoScroll = true;
            //Formload.WindowState = FormWindowState.Maximized;
            //Formload.StartPosition = FormStartPosition.CenterScreen;

            panelmain.Controls.Add(Formload);
            Formload.Show();



        }
        public Main()
        {


            InitializeComponent();

            string username = Utils.getusername();
            lbusername.Text = username;

            if (Model.Username.getsystemright() == true)
            {
                Menusystem.Enabled = true;
            }
            else
            {
                Menusystem.Enabled = false;
            };

            if (Model.Username.getLoadRight() == true)
            {
                Menuload.Enabled = true;
            }
            else
            {
                Menuload.Enabled = false;
            }


            if (Model.Username.getMakettingright() == true)
            {
                MenuMaketting.Enabled = true;
            }
            else
            {
                MenuMaketting.Enabled = false;
            }


            if (Model.Username.getReportsRight() == true)
            {
                Menureports.Enabled = true;
            }
            else
            {
                Menureports.Enabled = false;
            }

            if (Model.Username.getWareHouseRight() == true)
            {
                Menuwavehouse.Enabled = true;
            }
            else
            {
                Menuwavehouse.Enabled = false;
            }



            salesToolStripMenuItem.Visible = false;


            //     string tencty = Model.Username.getnamecty();

            //   panelmain.Size = win

            panelmain.Controls.Clear();

            View.Beemainload accsup = new Beemainload(this);
            accsup.Show();
            accsup.TopLevel = false;
            //   accsup.AutoScroll = true;

            panelmain.Controls.Add(accsup);








        }


        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {







        }

        private void bt_caculating_Click(object sender, EventArgs e)
        {
            //var db = new LinqtoSQLDataContext(connection_string);
            //var cltour = from p in db.tours
            //             where p.TourID != 0
            //             select p;

            //dataGridView1.DataSource = cltour;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //var db = new LinqtoSQLDataContext(connection_string);


            //tour tour = db.tours.Single(p => p.TourID == 20);
            ////  Tourid.TourID =  Convert.ToInt32(cb_id.Text);
            //tour.TourName = cb_name.Text;
            ////   db.
            //db.SubmitChanges();

            //string[] days = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            //foreach (string day in days)
            //{
            //    MessageBox.Show("The day is : " + day, "The day ");


            //           }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void bt_insert_Click(object sender, EventArgs e)
        {

            //var db = new LinqtoSQLDataContext(connection_string);

            //tour tb = new tour();

            //tb.TourID = int.Parse(cb_id.Text);
            //tb.TourName = cb_name.Text;
            //tb.Image = cb_image.Text;
            //tb.Nights = byte.Parse(cb_night.Text);
            //tb.Price = int.Parse(cb_price.Text);


            //db.tours.InsertOnSubmit(tb);

            //db.SubmitChanges();


            //  dataGridView1.Refresh();

        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {



        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var db = new LinqtoSQLDataContext(connection_string);
            //var rs = from Tour in db.tours
            //         select Tour;


            //db.tours.DeleteAllOnSubmit(rs);
            //db.SubmitChanges();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            //Form.ActiveForm(MasterdataInput);


        }

        private void bt_inputcsv_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {







        }

        private void fBL5nInputToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void upLoadProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void updateNewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product md = new Product();
            //   customerinput_ctrl md = new customerinput_ctrl();
            DialogResult kq1 = MessageBox.Show("Xóa tblFBL5n thay thế bằng bảng mới ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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


                    //   this.updateNewAllToolStripMenuItem.Enabled = false;
                    //   this.reportsToolStripMenuItem.Enabled = false;


                    md.productlistinput();


                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }





        }

        private void addCustormerToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void changeProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  fbl5n_ctrl md = new fbl5n_ctrl();
            //   md.Fbl5n_input();





        }

        private void uploadAndChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        //private void viewFBL5NToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string connection_string = Utils.getConnectionstr();

        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

        //    Product md = new Product();
        //    var rs = md.product_select_all(db);

        //    Viewtable viewtbl = new Viewtable(rs, db, "FBL5n data");
        //}

        private void viewCustomerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        //private void viewCustomerDataToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    string connection_string = Utils.getConnectionstr();

        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);
        //    customerinput_ctrl md = new customerinput_ctrl();
        //    var rs = md.customersetlect_all(db);

        //    //  MessageBox.Show("Data add/ change Customer done !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Viewtable viewtbl = new Viewtable(rs, db, "CUSTOMER DATA");

        //}


        private void updateNewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {




        }

        //private void viewVATDataToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string connection_string = Utils.getConnectionstr();

        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);
        //    programlist md = new programlist();
        //    var rs = md.setlect_all(db);
        //    Viewtable viewtbl = new Viewtable(rs, db, "VAT ZFI data uploaded ");
        //}

        private void addUpdateAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void setCustomerRecieveReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        //    private void dataCheckToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        string connection_string = Utils.getConnectionstr();

        ////        LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);
        //        LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


        //        Control_ac ct = new Control_ac(); 
        //        DialogResult Kq = MessageBox.Show("Bạn xóa workingdata bởi bản mới hay chỉ add thêm ?" + "\n" + "                 Xóa->Yes/ Add thêm->No !", "Thông báo !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


        //        switch (Kq)
        //        {
        //            case DialogResult.None:
        //                break;
        //            case DialogResult.OK:
        //                break;
        //            case DialogResult.Cancel:
        //                //  this.Close();
        //                break;
        //            case DialogResult.Abort:
        //                break;
        //            case DialogResult.Retry:
        //                break;
        //            case DialogResult.Ignore:
        //                break;
        //            case DialogResult.Yes:
        //                {


        //                    #region // XÓA toàn bộ xóa data cũ
        //                    dc.ExecuteCommand("DELETE FROM tblFBL5Nnewthisperiod");
        //                    //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
        //                    dc.SubmitChanges();

        //                    #endregion



        //                    #region    ClearABbelanceZezoinFbl5n

        //                    SqlConnection conn2 = null;
        //                    SqlDataReader rdr1 = null;
        //                    string destConnString = Utils.getConnectionstr();
        //                    try
        //                    {

        //                        conn2 = new SqlConnection(destConnString);
        //                        conn2.Open();
        //                        SqlCommand cmd1 = new SqlCommand("ClearABbelanceZezo", conn2);
        //                        cmd1.CommandType = CommandType.StoredProcedure;
        //                        //  cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = userupdate;

        //                        rdr1 = cmd1.ExecuteReader();



        //                        //       rdr1 = cmd1.ExecuteReader();

        //                    }
        //                    finally
        //                    {
        //                        if (conn2 != null)
        //                        {
        //                            conn2.Close();
        //                        }
        //                        if (rdr1 != null)
        //                        {
        //                            rdr1.Close();
        //                        }
        //                    }
        //                    //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);





        //                    #endregion



        //                    bool kq1 = ct.checkVATandFBL5n();


        //                    if (kq1)
        //                    {

        //                        ct.UpdateVATregionFromFBL5Nregion();

        //                        bool kq2 = ct.checkVATnameanddtodata();
        //                        // nếu không ok data khong có data trong  fbl5new

        //                        if (kq1 && kq2)// new data ok thi updload data
        //                        {

        //                            Thread t1 = new Thread(new ThreadStart(ct.inputVATandFBL5toFBL5newthisperiod));

        //                            t1.Start();


        //                            Thread t2 = new Thread(showwait);
        //                            t2.Start();

        //                            t1.Join();
        //                            if (t1.ThreadState != ThreadState.Running)
        //                            {
        //                                Thread.Sleep(555);
        //                                t2.Abort();

        //                            }


        //                        }

        //                        //---kiểm tra data nếu khác thì showmessage/ deleted toadn bộ các dòng đó trên thispreriod


        //                        var eror = from tblFBL5Nnewthisperiod in dc.tblFBL5Nnewthisperiods
        //                                   where tblFBL5Nnewthisperiod.COL_value != tblFBL5Nnewthisperiod.Empty_Amount
        //                                   select new
        //                                   {
        //                                       Account_Group = tblFBL5Nnewthisperiod.codeGroup,
        //                                       Account = tblFBL5Nnewthisperiod.Account,
        //                                       Doc_Number = tblFBL5Nnewthisperiod.Document_Number,
        //                                       Customer_Name = tblFBL5Nnewthisperiod.name,
        //                                       coL_EDLP_Value = tblFBL5Nnewthisperiod.COL_value,
        //                                       Empty_AmountinVAT = tblFBL5Nnewthisperiod.Empty_Amount,


        //                                   };
        //                        if (eror.Count() > 0)
        //                        {
        //                            Viewtable viewtbl = new Viewtable(eror, dc, "List các doc chưa update được do có lệch giữ data FBL5n Và VAT/Edlp về phần vỏ , please check !");
        //                        }


        //                        //     xóa trên deleteLisColandEmptydifferentinThis các list không update đuocwj


        //                        #region    deleteLisColandEmptydifferentinThis

        //                        //     SqlConnection conn2 = null;
        //                        //       SqlDataReader rdr1 = null;
        //                        //    string destConnString = Utils.getConnectionstr();
        //                        try
        //                        {

        //                            conn2 = new SqlConnection(destConnString);
        //                            conn2.Open();
        //                            SqlCommand cmd1 = new SqlCommand("deleteLisColandEmptydifferentinThis", conn2);
        //                            cmd1.CommandType = CommandType.StoredProcedure;
        //                            //  cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = userupdate;

        //                            rdr1 = cmd1.ExecuteReader();



        //                            //       rdr1 = cmd1.ExecuteReader();

        //                        }
        //                        finally
        //                        {
        //                            if (conn2 != null)
        //                            {
        //                                conn2.Close();
        //                            }
        //                            if (rdr1 != null)
        //                            {
        //                                rdr1.Close();
        //                            }
        //                        }
        //                        //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);





        //                        #endregion

        //                        //  updatetblFBL5NTempRPtview

        //                        #region    updatetblFBL5NTempRPtview tinh tong va so du luon

        //                        //     SqlConnection conn2 = null;
        //                        //       SqlDataReader rdr1 = null;
        //                        //    string destConnString = Utils.getConnectionstr();
        //                        try
        //                        {

        //                            conn2 = new SqlConnection(destConnString);
        //                            conn2.Open();
        //                            SqlCommand cmd1 = new SqlCommand("updatetblFBL5NTempRPtview", conn2);
        //                            cmd1.CommandType = CommandType.StoredProcedure;
        //                            //  cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = userupdate;

        //                            rdr1 = cmd1.ExecuteReader();



        //                            //       rdr1 = cmd1.ExecuteReader();

        //                        }
        //                        finally
        //                        {
        //                            if (conn2 != null)
        //                            {
        //                                conn2.Close();
        //                            }
        //                            if (rdr1 != null)
        //                            {
        //                                rdr1.Close();
        //                            }
        //                        }
        //                        //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);





        //                        #endregion
        //                        //    xóa trên tblFBL5Nnewthisperiod


        //                        ///-kiểm tra data

        //                    }

        //                    //---------





        //                    break;
        //                }
        //            case DialogResult.No:

        //                {


        //                    #region    ClearABbelanceZezoinFbl5n

        //                    SqlConnection conn2 = null;
        //                    SqlDataReader rdr1 = null;
        //                    string destConnString = Utils.getConnectionstr();
        //                    try
        //                    {

        //                        conn2 = new SqlConnection(destConnString);
        //                        conn2.Open();
        //                        SqlCommand cmd1 = new SqlCommand("ClearABbelanceZezo", conn2);
        //                        cmd1.CommandType = CommandType.StoredProcedure;
        //                        //  cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = userupdate;

        //                        rdr1 = cmd1.ExecuteReader();



        //                        //       rdr1 = cmd1.ExecuteReader();

        //                    }
        //                    finally
        //                    {
        //                        if (conn2 != null)
        //                        {
        //                            conn2.Close();
        //                        }
        //                        if (rdr1 != null)
        //                        {
        //                            rdr1.Close();
        //                        }
        //                    }
        //                    //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);





        //                    #endregion

        //                    // loại toàn bộ các doc trùng trong thispreiod tại cá bảng fbl5m/ vat/ edln

        //                    ct.xoavatEDLPandFBL5nDochaveinFbl5nthis();


        //                    // loại toàn bộ các doc trùng trong thispreiod


        //                    bool kq1 = ct.checkVATandFBL5n();


        //                    if (kq1)
        //                    {

        //                        ct.UpdateVATregionFromFBL5Nregion();

        //                        bool kq2 = ct.checkVATnameanddtodata();


        //                        if (kq1 && kq2)// new data ok thi updload data
        //                        {

        //                            Thread t1 = new Thread(new ThreadStart(ct.inputVATandFBL5toFBL5newthisperiod));

        //                            t1.Start();


        //                            Thread t2 = new Thread(showwait);
        //                            t2.Start();

        //                            t1.Join();
        //                            if (t1.ThreadState != ThreadState.Running)
        //                            {
        //                                Thread.Sleep(555);
        //                                t2.Abort();

        //                            }


        //                        }



        //                    }

        //                    //---------


        //                    break;
        //                }
        //            default:
        //                break;
        //        }







        //    }

        private void uploadCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void addChangeCustomerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerinput_ctrl md = new customerinput_ctrl();





        }

        private void productCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {




            //string connection_string = Utils.getConnectionstr();

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tbl_kaProductlist);

            //VInputchange inputcdata = new VInputchange("", "LIST PRODUCT AND EMPTY GROUP", dc, "tbl_kaProductlist", "tbl_kaProductlist", typeff, typeff, "id", "id","");
            //inputcdata.Show();
            //View.Inputchange kq = new View.Inputchange
        }

        //private void viewProductsListToolStripMenuItem_Click(object sender, EventArgs e)
        //{



        //    string connection_string = Utils.getConnectionstr();

        //    var db = new LinqtoSQLDataContext(connection_string);
        //    var rs = (from tbl_kaProductlist in db.tbl_kaProductlists
        //              join tbl_EmptyGroup in db.tbl_EmptyGroups on tbl_kaProductlist.Empty_Group equals tbl_EmptyGroup.id into tblnew
        //              from cat in tblnew
        //              select new
        //              {

        //                  tbl_kaProductlist.Mat_Number,
        //                  tbl_kaProductlist.Mat_Text,
        //                  tbl_kaProductlist.Empty_Group,
        //                  tbl_kaProductlist.Mat_Group,
        //                  tbl_kaProductlist.Mat_Group_Text,
        //                  cat.Name_Group_Emptty



        //                  //tbl_kaProductlist.Empty_Group


        //              }
        //              );



        //    Viewtable viewtbl = new Viewtable(rs, db, "List of product");






        //}



        private void byMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ////var db = new LinqtoSQLDataContext(connection_string);
            ////      fRM_AROPTION fromoptiong = new fRM_AROPTION("ARletter.rdlc");
            ////     fromoptiong.Show();

            ////
            //string connection_string = Utils.getConnectionstr();

            //var db = new LinqtoSQLDataContext(connection_string);

            //Control_ac ctrac = new Control_ac();

            //rs1 = ctrac.KArptdataset1(db);
            //rs2 = ctrac.KArptdataset2(db);





            //if (rs1 != null && rs2 != null)
            //{

            //    Utils ut = new Utils();
            //    var dataset1 = ut.ToDataTable(db, rs1);
            //    var dataset2 = ut.ToDataTable(db, rs2);
            //    Reportsview rpt = new Reportsview(dataset1, dataset2, "ARletter.rdlc");
            //    rpt.Show();

            //}




        }

        private void byDateFromToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// fRM_AROPTION fromoptiong = new fRM_AROPTION("ARletterdetail.rdlc");
            ////fRM_AROPTION fromoptiong = new fRM_AROPTION("SubARletterdetail.rdlc");

            //string connection_string = Utils.getConnectionstr();

            ////    var db = new LinqtoSQLDataContext(connection_string);
            //var db = new LinqtoSQLDataContext(connection_string);


            //string rptname = "ARletterdetail.rdlc";
            ////      string rptname = "SubARletterdetail.rdlc";
            //Control_ac ctrac = new Control_ac();

            //var rs1 = ctrac.letterdetaildataset1(db);
            //var rs2 = ctrac.letterdetaildataset2(db);


            //if (rs1 != null && rs2 != null)
            //{
            //    //      var db = new LinqtoSQLDataContext(connection_string);
            //    Utils ut = new Utils();
            //    var dataset1 = ut.ToDataTable(db, rs1);
            //    var dataset2 = ut.ToDataTable(db, rs2);
            //    Reportsview rpt = new Reportsview(dataset1, dataset2, rptname);
            //    rpt.Show();

            //}
        }

        private void cOLReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        //private void viewDataLetterReportsToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    string connection_string = Utils.getConnectionstr();
        //    var db = new LinqtoSQLDataContext(connection_string);
        //    var rs = from tbl_ArletterRpt in db.tbl_ArletterRpts
        //             select tbl_ArletterRpt;


        //    Viewtable viewtbl = new Viewtable(rs, db, "Letter data reports");


        //}

        private void groupCustomerSentARLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void viewEdlpDataToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            //LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //edlpinput_ctrl md = new edlpinput_ctrl();
            //var rs = md.Edlpsetlect_all(db);
            //Viewtable viewtbl = new Viewtable(rs, db, "EDLP data uploaded ");
        }

        private void addUpdateAndReplaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ////    bool kq;
            //edlpinput_ctrl md = new edlpinput_ctrl();

            //DialogResult kq1 = MessageBox.Show("Xóa Edlpinput thay thế bằng bảng mới ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //switch (kq1)
            //{
            //    case DialogResult.None:
            //        break;
            //    case DialogResult.OK:


            //        break;
            //    case DialogResult.Cancel:
            //        break;
            //    case DialogResult.Abort:
            //        break;
            //    case DialogResult.Retry:
            //        break;
            //    case DialogResult.Ignore:
            //        break;
            //    case DialogResult.Yes:


            //        //     this.addUpdateAndReplaceToolStripMenuItem1.Enabled = false;
            //        //    this.reportsToolStripMenuItem.Enabled = false;

            //        md.edlpinput();



            //        break;
            //    case DialogResult.No:
            //        break;
            //    default:
            //        break;
            //}






        }

        private void vATInputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDLPInputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void viewDataCOLReportsToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);





        //    var dc = new LinqtoSQLDataContext(connection_string);



        //    IQueryable q3 = from Productlist in dc.tbl_ColdetailRpts
        //                    select Productlist;




        //    Viewtable viewtbl = new Viewtable(q3, dc, "Col Reports detail data");










        //}

        private void viewChangeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            //LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tbl_Remark);

            //VInputchange inputcdata = new VInputchange("", "LIST REMARK TO UPDATE ", dc, "tbl_Remark", "tbl_Remark", typeff, typeff, "id", "id","");
            //inputcdata.Show();
            ////View.Inputchange kq = new View.Inputchange



        }

        private void viewChangeDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tbl_FreGlass);

            //VInputchange inputcdata = new VInputchange("", "LIST FREE GLASS PROGRAM ", dc, "tbl_FreGlass", "tbl_FreGlass", typeff,typeff ,"id", "id","");
            //inputcdata.Show();
            ////View.Inputchange kq = new View.Inputchange
        }

        private void lETTERCOLREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);



            //var db = new LinqtoSQLDataContext(connection_string);


            //string rptname = "ARCOLrpt.rdlc";
            ////      string rptname = "SubARletterdetail.rdlc";
            //Control_ac ctrac = new Control_ac();

            //var rs1 = ctrac.ARcoldataset1(db);
            //var rs2 = ctrac.ARcoldataset2(db);


            //if (rs1 != null && rs2 != null)
            //{
            //    //      var db = new LinqtoSQLDataContext(connection_string);
            //    Utils ut = new Utils();
            //    var dataset1 = ut.ToDataTable(db, rs1);
            //    var dataset2 = ut.ToDataTable(db, rs2);
            //    Reportsview rpt = new Reportsview(dataset1, dataset2, rptname);
            //    rpt.Show();



            //}

        }

        //private void eDITCUSTOMERDATAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //   LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


        //    var typeff = typeof(tblCustomer);

        //    VInputchange inputcdata = new VInputchange("", "LIST MASTER DATA CUSTOMER ", dc, "tblCustomer", "tblCustomer", typeff, "id", "id");
        //    inputcdata.Show();

        //}

        private void eDITLETTERDATAREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////     LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tbl_ArletterRpt);

            //VInputchange inputcdata = new VInputchange("", "DATA ARLETTER REPORTS- CAREFULLY BEFORE CHANGE IT ! ", dc, "tbl_ArletterRpt", "tbl_ArletterRpt", typeff, typeff, "id", "id","");
            //inputcdata.Show();


        }

        private void editFBL5NDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////  LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tblFBL5N);

            //VInputchange inputcdata = new VInputchange("", "FBL5N PREPRAIRE TO UP TO DATA  ", dc, "tblFBL5N", "tblFBL5N", typeff, typeff, "Fbl5nID", "Fbl5nID","");
            //inputcdata.Show();





        }

        private void eDITVATDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   Control_ac ct = new Control_ac();
            // ct.UpdateVATregionFromFBL5Nregion();

            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////  LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tblVat);

            //VInputchange inputcdata = new VInputchange("", "VAT PREPRAIRE TO UP TO DATA  ", dc, "tblVat", "tblVat", typeff, typeff, "id", "id","");
            //inputcdata.Show();

        }

        private void eDITEDLPDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////   LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tblEDLP);

            //VInputchange inputcdata = new VInputchange("", "EDLP PREPRAIRE TO UP TO DATA  ", dc, "tblEDLP", "tblEDLP", typeff, typeff, "id", "id","");
            //inputcdata.Show();
        }

        private void vIEWPRODUCTGROUPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDITPRODUCTSGROUPToolStripMenuItem_Click(object sender, EventArgs e)
        {






        }

        private void beginingBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////  LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tblFBL5beginbalace);

            //VInputchange inputcdata = new VInputchange("", "BEGINNING BALANCE ARCONFIRMATION LETTER", dc, "tblFBL5beginbalace", "tblFBL5beginbalace", typeff, typeff, "id", "id","");
            //inputcdata.Show();

        }

        private void eDITPRODUCTSGROUPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            ////  LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tbl_kaCustomerGroup);

            //VInputchange inputcdata = new VInputchange("", "LIST CUSTOMER GROUP  ", dc, "tbl_kaCustomerGroup", "tbl_kaCustomerGroup", typeff, typeff, "id", "id","");
            //inputcdata.Show();




        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  bool kq;
            Contract md = new Contract();

            DialogResult kq1 = MessageBox.Show("Xóa Remark thay thế bằng bảng mới ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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



                    //this.updateNewAllToolStripMenuItem1.Enabled = false;

                    //this.reportsToolStripMenuItem.Enabled = false;
                    md.inputcontract();


                    //      var rs = md.setlect_all();
                    //        Viewtable viewtbl = new Viewtable(rs, "VAT ZFI data uploaded ");













                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }


        }

        //private void vIEWREMARKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


        //    Contract md = new Contract();
        //    var rs = md.Setlect_all_begin(db);
        //    Viewtable viewtbl = new Viewtable(rs, db, "LIST OF UPDAD REMARKS  ");
        //}

        //private void vIEWREMARKSLISTToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


        //    fuctionprog md = new fuctionprog();
        //    var rs = md.Funtionsetlect_all(db);
        //    Viewtable viewtbl = new Viewtable(rs, db, "LIST OF REEGALSSES TABLE ");




        //}

        private void uploadToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            //  bool kq;
            fuctionprog md = new fuctionprog();

            DialogResult kq1 = MessageBox.Show("Xóa FREEGALSSES  thay thế bằng bảng mới ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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



                    //this.updateNewAllToolStripMenuItem1.Enabled = false;

                    //this.reportsToolStripMenuItem.Enabled = false;
                    md.Fuction_input();


                    //      var rs = md.setlect_all();
                    //        Viewtable viewtbl = new Viewtable(rs, "VAT ZFI data uploaded ");













                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }




        }

        private void rEPORTSMAKEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////var db = new LinqtoSQLDataContext(connection_string);
            //fRM_AROPTION fromoptiong = new fRM_AROPTION();//("ARletter.rdlc");
            //fromoptiong.Show();

        }

        //private void sETLISTCUSTOMERMAKEREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

        //    customerinput_ctrl md = new customerinput_ctrl();
        //    var rs = md.customersetlect_all(db);
        //    Viewtable viewtbl = new Viewtable(rs, db, "Update Customer make reports !");



        //}

        //private void vIEWLISTCUSTMAKEREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    Control_ac ct = new Control_ac();
        //    //    ct.updateCustgoupinListcustmakeRpt();

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //   LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //    var rsCust2 = from tblCustomer in dc.tblCustomers
        //             //     where tblCustomer.Reportsend == true
        //                  orderby tblCustomer.Customer
        //                  select tblCustomer;

        //    //  MessageBox.Show("Data add/ change Customer done !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Viewtable viewtbl = new Viewtable(rsCust2, dc, "LIST CUSTOMER MAKE REPORTS");

        //}

        private void rEPORTSMAKEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {







            ////

        }

        private void eDITLISTCUSTMAKEREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        //private void vIEWALLDATABASEONSERVERToolStripMenuItem_Click(object sender, EventArgs e)
        //{



        //    fromdate fromtochoice = new View.fromdate();
        //    Control_ac ctrac = new Control_ac();

        //    fromtochoice.ShowDialog();


        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //      LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);




        //    DateTime fromdate = fromtochoice.tungay;
        //    DateTime todate = fromtochoice.denngay;
        //    bool choice = fromtochoice.chon;




        //    if (choice == true)
        //    {



        //        LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //        var rs2 = from tblFBL5Nnew in dc.tblFBL5Nnews
        //                  where tblFBL5Nnew.Posting_Date >= fromdate && tblFBL5Nnew.Posting_Date <= todate
        //                  select tblFBL5Nnew;


        //        Viewtable viewtbl = new Viewtable(rs2, dc, "VIEWLIST DATABASE UPLOADED ON SYSYEM FROM-" + fromdate.Day + "/" + fromdate.Month + "/" + fromdate.Year + " -TO- " + todate.Day + "/" + todate.Month + "/" + todate.Year);




        //    }
        //}

        //private void vIEWLETTERDETAILREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //   LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

        //    var db = new LinqtoSQLDataContext(connection_string);
        //    var rs = from tbl_ArletterdetailRpt in db.tbl_ArletterdetailRpts
        //             select tbl_ArletterdetailRpt;


        //    Viewtable viewtbl = new Viewtable(rs, db, "Letter data detail reporst");
        //}

        //private void vIEWLETTERCOLREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


        //    var db = new LinqtoSQLDataContext(connection_string);
        //    var rs = from tbl_ColdetailRpt in db.tbl_ColdetailRpts
        //             select tbl_ColdetailRpt;


        //    Viewtable viewtbl = new Viewtable(rs, db, "Letter COL detail reporst");
        //}

        //private void eDITLETTERDETAILREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //   LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


        //    var typeff = typeof(tbl_ArletterdetailRpt);

        //    VInputchange inputcdata = new VInputchange("", "DATA Arletter DetailRpt REPORTS- CAREFULLY BEFORE CHANGE IT ! ", dc, "tbl_ArletterdetailRpt", "tbl_ArletterdetailRpt", typeff, "id", "id");
        //    inputcdata.Show();

        //}

        ////private void vIEWLETTERCOLREPORTSToolStripMenuItem1_Click(object sender, EventArgs e)
        ////{

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //     LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


        //    var typeff = typeof(tbl_ColdetailRpt);

        //    VInputchange inputcdata = new VInputchange("", "DATA Arletter Col Detail Reports- CAREFULLY BEFORE CHANGE IT ! ", dc, "tbl_ColdetailRpt", "tbl_ColdetailRpt", typeff, "id", "id");
        //    inputcdata.Show();
        //}

        private void eDITALLDATABASEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string connection_string = Utils.getConnectionstr();

            ////  var db = new LinqtoSQLDataContext(connection_string);
            //// LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var typeff = typeof(tblFBL5Nnew);

            //VInputchange inputcdata = new VInputchange("", "ALL DATA FBL5N NEW ON SERVER, BECAREFULLY BEFORE CHANGE IT ! ", dc, "tblFBL5Nnew", "tblFBL5Nnew", typeff, typeff, "id", "id","");
            //inputcdata.Show();
        }

        private void uploadFreeGlassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void iNPUTPERIODDEPOSITAMOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //  LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);



        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //    var rsthisperiod = from tblFBL5Nnewthisperiod in dc.tblFBL5Nnewthisperiods

        //                       select tblFBL5Nnewthisperiod;

        //    if (rsthisperiod.Count() != 0)
        //    {
        //        // fbl5n_ctrl md = new fbl5n_ctrl();
        //        //var rs = md.product_select_all();

        //        Viewtable viewtbl = new Viewtable(rsthisperiod, dc, "iNPUT DEPOSIT AMOUNTT !");

        //    }



        //}
        public void showwait()
        {
            View.MKTCaculating wat = new View.MKTCaculating();


            wat.ShowDialog();






        }




        //private void cLOSETHISPRERIODToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DialogResult kq1 = MessageBox.Show("ENDMONTH DATA CLOSE ? ", "CONFIRN CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


        //    switch (kq1)
        //    {
        //        case DialogResult.None:
        //            break;
        //        case DialogResult.OK:
        //            break;
        //        case DialogResult.Cancel:
        //            break;
        //        case DialogResult.Abort:
        //            break;
        //        case DialogResult.Retry:
        //            break;
        //        case DialogResult.Ignore:
        //            break;
        //        case DialogResult.Yes:

        //            //   string filename = theDialog.FileName.ToString();updatetoFBL5nnew
        //            //    updatetoFBL5nnew(); // teo xoa sau


        //            #region q List các document có trong bảng VAT không có trong bảng FBL5N !
        //            //---

        //            string connection_string = Utils.getConnectionstr();

        //            //  var db = new LinqtoSQLDataContext(connection_string);
        //            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);



        //            var q = from tblFBL5Nnewthisperiod in db.tblFBL5Nnewthisperiods
        //                    where (from tblFBL5Nnew in db.tblFBL5Nnews
        //                           select tblFBL5Nnew.Document_Number).Contains(tblFBL5Nnewthisperiod.Document_Number)
        //                    //Tương đương từ khóa NOT IN trong SQL
        //                    select tblFBL5Nnewthisperiod;



        //            if (q.Count() != 0)
        //            {



        //                Viewtable viewtbl = new Viewtable(q, db, "Data không close được do có List các document sau đã update lên rồi !");

        //            }
        //            if (q.Count() == 0)
        //            {

        //                Control_ac ct = new Control_ac();

        //                Thread t1 = new Thread(ct.inputthisisperiodtoFBL5nnew);
        //                //   t1.IsBackground = true;
        //                t1.Start();


        //                Thread t2 = new Thread(showwait);
        //                t2.Start();

        //                t1.Join();
        //                if (t1.ThreadState != ThreadState.Running)
        //                {
        //                    Thread.Sleep(555);
        //                    t2.Abort();

        //                }





        //            }
        //            #endregion q "List các document có trong bảng VAT không có trong bảng FBL5N !





        //            break;
        //        case DialogResult.No:
        //            break;
        //        default:
        //            break;
        //    }




        //}

        private void bYTIMEPICKERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bYPRERIODToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }


        class Runreports
        {
            public LinqtoSQLDataContext dc { get; set; }
            public DateTime fromdate { get; set; }
            public DateTime todate { get; set; }
            public DateTime returndate { get; set; }


        }


        static void ReportVNRun(object objextRPt)
        {

            //Runreports dat = (Runreports)objextRPt;
            //LinqtoSQLDataContext db = dat.dc;
            //DateTime fromdate = dat.fromdate;
            //DateTime todate = dat.todate;
            //DateTime returndate = dat.returndate;
            //Control_ac ctrac = new Control_ac();
            //ctrac.ARlettermakebyGroupcode2(db, fromdate, todate, returndate);





        }


        static void ReportVNRegiom(object objextRPt)
        {

            //Runreports dat = (Runreports)objextRPt;
            //LinqtoSQLDataContext db = dat.dc;
            //DateTime fromdate = dat.fromdate;
            //DateTime todate = dat.todate;
            //DateTime returndate = dat.returndate;
            //Control_ac ctrac = new Control_ac();
            //ctrac.ARlettermakebyGroupcodeRegion(db, fromdate, todate, returndate);





        }



        private void userAndRightToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void serverNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.MKTServersetup stup = new MKTServersetup();
            stup.Show();
        }



        //private void bEGINBALANCEVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //   LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //    var rsthisperiod = from tblFBL5beginbalace in dc.tblFBL5beginbalaces
        //                       orderby tblFBL5beginbalace.Account
        //                       select tblFBL5beginbalace;

        //    if (rsthisperiod.Count() != 0)
        //    {
        //        // fbl5n_ctrl md = new fbl5n_ctrl();
        //        //var rs = md.product_select_all();

        //        Viewtable viewtbl = new Viewtable(rsthisperiod, dc, "LIST BEGIN BALANCE !");

        //    }


        //}

        private void dELETEALLDATABASEEDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq1 = MessageBox.Show(" XÓA TOÀN BỘ DỮ LIỆU TRÊN SERVER ! ", "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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


                    //   this.updateNewAllToolStripMenuItem.Enabled = false;
                    //   this.reportsToolStripMenuItem.Enabled = false;

                    string connection_string = Utils.getConnectionstr();

                    //  var db = new LinqtoSQLDataContext(connection_string);
                    //     LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


                    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
                    //    var rs2 = from tblFBL5Nnew in dc.tblFBL5Nnews
                    //             select tblFBL5Nnew;

                    dc.ExecuteCommand("DELETE FROM tblFBL5Nnew");
                    //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
                    dc.SubmitChanges();
                    //   dc.tblFBL5Nnews.DeleteAllOnSubmit(rs2);
                    //   dc.SubmitChanges();


                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }

        }

        //   private void pRINTREPORTSBYOPTIONToolStripMenuItem_Click(object sender, EventArgs e)
        //   {
        //       PrintLetterOption PrintOption = new PrintLetterOption();
        //       // Control_ac ctrac = new Control_ac();

        //       PrintOption.ShowDialog();


        // //      int choice = PrintOption.choice;

        ////       double onlycode = PrintOption.onlycode;
        ////       double fromcode = PrintOption.fromcode;
        // //      double tocode = PrintOption.tocode;

        // //      string groupsending = PrintOption.groupsending;


        //       if (choice == 1)//grooup print
        //       {
        //           // string groupsending = PrintOption.groupsending;
        //           //    MessageBox.Show(groupsending + "-groupprint--" );

        //           string connection_string = Utils.getConnectionstr();


        //      //     MessageBox.Show(groupsending + "-groupprint--");


        //           #region  updatepriterinvoice grouppriter
        //           SqlConnection conn2 = null;
        //           SqlDataReader rdr1 = null;

        //           string destConnString = Utils.getConnectionstr();
        //           try
        //           {

        //               conn2 = new SqlConnection(destConnString);
        //               conn2.Open();
        //               SqlCommand cmd1 = new SqlCommand("updategroupprintletterChoice", conn2);
        //               cmd1.CommandType = CommandType.StoredProcedure;
        //               cmd1.Parameters.Add("@groupsending", SqlDbType.VarChar).Value = groupsending;

        //               rdr1 = cmd1.ExecuteReader();



        //               //       rdr1 = cmd1.ExecuteReader();

        //           }
        //           finally
        //           {
        //               if (conn2 != null)
        //               {
        //                   conn2.Close();
        //               }
        //               if (rdr1 != null)
        //               {
        //                   rdr1.Close();
        //               }
        //           }
        //           //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //           #endregion


        //       }
        //       if (choice == 2)//fromcode to code print
        //       {

        //           //double fromcode = PrintOption.fromcode;
        //           //double tocode = PrintOption.tocode;
        //           //         MessageBox.Show(fromcode.ToString() + "-fromto--" + tocode.ToString());


        //           #region  updatepriterinvoice grouppriter
        //           SqlConnection conn2 = null;
        //           SqlDataReader rdr1 = null;

        //           string destConnString = Utils.getConnectionstr();
        //           try
        //           {

        //               conn2 = new SqlConnection(destConnString);
        //               conn2.Open();
        //               SqlCommand cmd1 = new SqlCommand("updategroupprintletterfromcodetocodeChoice", conn2);
        //               cmd1.CommandType = CommandType.StoredProcedure;
        //               cmd1.Parameters.Add("@fromcode", SqlDbType.Float).Value = fromcode;
        //               cmd1.Parameters.Add("@tocode", SqlDbType.Float).Value = tocode;

        //               rdr1 = cmd1.ExecuteReader();



        //               //       rdr1 = cmd1.ExecuteReader();

        //           }
        //           finally
        //           {
        //               if (conn2 != null)
        //               {
        //                   conn2.Close();
        //               }
        //               if (rdr1 != null)
        //               {
        //                   rdr1.Close();
        //               }
        //           }
        //           //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //           #endregion






        //       }

        //       if (choice == 3)   //only code
        //       {
        //           //   MessageBox.Show(onlycode.ToString() + "-onlycepde--");

        //           #region  updatepriterinvoice grouppriter
        //           SqlConnection conn2 = null;
        //           SqlDataReader rdr1 = null;

        //           string destConnString = Utils.getConnectionstr();
        //           try
        //           {

        //               conn2 = new SqlConnection(destConnString);
        //               conn2.Open();
        //               SqlCommand cmd1 = new SqlCommand("updategroupprintletterOnlycodeChoice", conn2);
        //               cmd1.CommandType = CommandType.StoredProcedure;
        //               cmd1.Parameters.Add("@onlycode", SqlDbType.Float).Value = onlycode;

        //               rdr1 = cmd1.ExecuteReader();



        //               //       rdr1 = cmd1.ExecuteReader();

        //           }
        //           finally
        //           {
        //               if (conn2 != null)
        //               {
        //                   conn2.Close();
        //               }
        //               if (rdr1 != null)
        //               {
        //                   rdr1.Close();
        //               }
        //           }
        //           //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //           #endregion




        //       }
        //       if (choice == 4)   //all code
        //       {



        //           #region update cho view heet baso caso

        //           //     updategroupprintletterChoiceALL

        //           #region  updatepriterinvoice updategroupprintletterChoiceALL
        //           SqlConnection conn2 = null;
        //       SqlDataReader rdr1 = null;

        //       string destConnString = Utils.getConnectionstr();
        //       try
        //       {

        //           conn2 = new SqlConnection(destConnString);
        //           conn2.Open();
        //           SqlCommand cmd1 = new SqlCommand("updategroupprintletterChoiceALL", conn2);
        //           cmd1.CommandType = CommandType.StoredProcedure;
        //           //    cmd1.Parameters.Add("@groupsending", SqlDbType.VarChar).Value = groupsending;

        //           rdr1 = cmd1.ExecuteReader();



        //           //       rdr1 = cmd1.ExecuteReader();

        //       }
        //       finally
        //       {
        //           if (conn2 != null)
        //           {
        //               conn2.Close();
        //           }
        //           if (rdr1 != null)
        //           {
        //               rdr1.Close();
        //           }
        //       }
        //           //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //           #endregion


        //           #endregion


        //       }



        //       if (choice ==1 || choice == 2 || choice == 3 || choice == 4)
        //       {
        //           #region print invoce


        //           string connection_string = Utils.getConnectionstr();

        //           var db = new LinqtoSQLDataContext(connection_string);

        //           Control_ac ctrac = new Control_ac();

        //           rs1 = ctrac.KArptdataset1(db);
        //           rs2 = ctrac.KArptdataset2(db);





        //           if (rs1 != null && rs2 != null)
        //           {

        //               Utils ut = new Utils();
        //               var dataset1 = ut.ToDataTable(db, rs1);
        //               var dataset2 = ut.ToDataTable(db, rs2);
        //               Reportsview rpt = new Reportsview(dataset1, dataset2, "ARletter.rdlc");
        //               rpt.Show();

        //           }


        //           #endregion

        //           #region print detail

        //        //   string connection_string = Utils.getConnectionstr();

        //           //    var db = new LinqtoSQLDataContext(connection_string);
        //      //     var db = new LinqtoSQLDataContext(connection_string);


        //        //   string rptname = "ARletterdetail.rdlc";
        //           //      string rptname = "SubARletterdetail.rdlc";
        //       //    Control_ac ctrac = new Control_ac();

        //           var rs3 = ctrac.letterdetaildataset1(db);
        //           var rs4 = ctrac.letterdetaildataset2(db);


        //           if (rs1 != null && rs2 != null)
        //           {
        //               //      var db = new LinqtoSQLDataContext(connection_string);
        //               Utils ut = new Utils();
        //               var dataset1 = ut.ToDataTable(db, rs3);
        //               var dataset2 = ut.ToDataTable(db, rs4);
        //               Reportsview rpt = new Reportsview(dataset1, dataset2, "ARletterdetail.rdlc");
        //               rpt.Show();

        //           }

        //           #endregion

        //           #region print col
        //      //     string connection_string = Utils.getConnectionstr();

        //           //  var db = new LinqtoSQLDataContext(connection_string);
        //           //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);



        //         //  var db = new LinqtoSQLDataContext(connection_string);


        //        //   string rptname3 = "ARCOLrpt.rdlc";
        //           //      string rptname = "SubARletterdetail.rdlc";
        //     //      Control_ac ctrac = new Control_ac();

        //           var rs5 = ctrac.ARcoldataset1(db);
        //           var rs6 = ctrac.ARcoldataset2(db);


        //           if (rs1 != null && rs2 != null)
        //           {
        //               //      var db = new LinqtoSQLDataContext(connection_string);
        //               Utils ut = new Utils();
        //               var dataset1 = ut.ToDataTable(db, rs5);
        //               var dataset2 = ut.ToDataTable(db, rs6);
        //               Reportsview rpt = new Reportsview(dataset1, dataset2, "ARCOLrpt.rdlc");
        //               rpt.Show();



        //           }



        //           #endregion

        //       }




        //   }

        //private void lETTERRETURNUPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        //{



        //    fromdate fromtochoice = new View.fromdate();
        //    Control_ac ctrac = new Control_ac();

        //    fromtochoice.ShowDialog();


        //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    //      LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

        //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);




        //    DateTime fromdate = fromtochoice.tungay;
        //    DateTime todate = fromtochoice.denngay;
        //    bool choice = fromtochoice.chon;




        //    if (choice == true)
        //    {
        //        var rs = from tbl_Preriod in db.tbl_Preriods
        //                 where tbl_Preriod.fromdate >= fromdate && tbl_Preriod.todate <= todate
        //                 select tbl_Preriod;



        //        Viewtable viewtbl = new Viewtable(rs, db, "LETTER RETURN STATUS UPDATE");



        //    }






        //    //    string connection_string = Utils.getConnectionstr();

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        ////    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


        //}

        private void aRBalanceAndReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            View.MKTPasswordchange changep = new MKTPasswordchange();
            changep.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        //private void pictureBox1_MouseHover(object sender, EventArgs e)
        //{
        //   this.phanquyen.Image = global::BEEACCOUNT.Properties.Resources.input21;
        //}

        //private void pictureBox1_MouseLeave(object sender, EventArgs e)
        //{
        // this.phanquyen.Image = global::BEEACCOUNT.Properties.Resources.input1;
        //}

        //private void pictureBox4_MouseHover(object sender, EventArgs e)
        //{
        //  this.inputpayment.Image = global::BEEACCOUNT.Properties.Resources.payment2;
        //}

        //private void pictureBox4_MouseLeave(object sender, EventArgs e)
        //{
        // this.inputpayment.Image = global::BEEACCOUNT.Properties.Resources.payment1;
        //}

        //private void pictureBox6_MouseHover(object sender, EventArgs e)
        //{
        //   this.inputmarterdata.Image = global::BEEACCOUNT.Properties.Resources.master2;
        //}

        //private void pictureBox6_MouseLeave(object sender, EventArgs e)
        //{
        //   this.inputmarterdata.Image = global::BEEACCOUNT.Properties.Resources.master1;
        //}

        //private void pictureBox2_MouseHover(object sender, EventArgs e)
        //{
        //  this.inpucvolume.Image = global::BEEACCOUNT.Properties.Resources.saleupdate2;
        //}

        //private void pictureBox2_MouseLeave(object sender, EventArgs e)
        //{
        //  this.inpucvolume.Image = global::BEEACCOUNT.Properties.Resources.saleupdate1;
        //}

        //private void pictureBox5_MouseHover(object sender, EventArgs e)
        //{
        //  this.reports.Image = global::BEEACCOUNT.Properties.Resources.Reports2;
        //}

        //private void pictureBox5_MouseLeave(object sender, EventArgs e)
        //{
        //  this.reports.Image = global::BEEACCOUNT.Properties.Resources.Reports1;
        //}

        private void pictureBox6_Click(object sender, EventArgs e)
        {






        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormCollection fc = System.Windows.Forms.Application.OpenForms;

            bool kq = false;
            foreach (Form frm in fc)
            {
                ///  KAcontractlisting
                ///    if (frm.Text == "CreatenewContract")
                if (frm.Text == "KAcontractlisting")
                {
                    kq = true;
                    frm.Focus();

                }
            }

            if (!kq)
            {


                //string connection_string = Utils.getConnectionstr();
                //string username = Utils.getusername();

                //LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


                //var rs = Control.Control_ac.getViewcontractMaster(db);


                //View.KAcontractlisting KAcontractlisting = new View.KAcontractlisting(rs,db,"Input Contract");


                //KAcontractlisting.Show();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormCollection fc = System.Windows.Forms.Application.OpenForms;

            bool kq = false;
            foreach (Form frm in fc)
            {
                ///  KAcontractlisting
                ///    if (frm.Text == "CreatenewContract")
                if (frm.Text == "KAcontractlisting")
                {
                    kq = true;
                    frm.Focus();

                }
            }

            if (!kq)
            {

                string connection_string = Utils.getConnectionstr();
                string username = Utils.getusername();

                LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);



                //var rs = Control.Control_ac.getViewcontractMaster(db);

                //View.KAcontractlisting KAcontractlisting = new View.KAcontractlisting(rs, db, "Payment Input");


                //KAcontractlisting.Show();
            }



            //FormCollection fc = System.Windows.Forms.Application.OpenForms;

            //bool kq = false;
            //foreach (Form frm in fc)
            //{
            //    if (frm.Text == "KAinputpayment")
            //    {
            //        kq = true;
            //        frm.Focus();

            //    }
            //}

            //if (!kq)
            //{

            //    View.KAinputpayment KAinputpayment = new View.KAinputpayment();


            //    KAinputpayment.Show();
            //}
        }

        private void iNPUTPERIODDEPOSITAMOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //     View.kapricingcheck pricecheck = new kapricingcheck();

            //     pricecheck.ShowDialog();

        }

        private void btusersetup_Click(object sender, EventArgs e)
        {

        }

        private void btMasterdata_Click(object sender, EventArgs e)
        {



        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dfasfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ádfasdfToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void nhậpSốĐầuKỳToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hủyLoadMKtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtTrạngTháiCácPhiếuMKtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void usersSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mKTLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoGiaoHàngMKtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tạoPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelmain.Controls.Clear();  //PosmCreateTK


            //View.PosmCreateTK PosmCreateTK = new View.PosmCreateTK();

            //PosmCreateTK.TopLevel = false;
            //PosmCreateTK.AutoScroll = true;
            //panelmain.Controls.Add(PosmCreateTK);
            //PosmCreateTK.Show();
        }

        private void fINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sôKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void thêmMơiTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hêThôngTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {







        }

        private void button12_Click(object sender, EventArgs e)
        {




        }

        private void button7_Click(object sender, EventArgs e)
        {
            //panelmain.Controls.Clear();

            // View.BeePhieuThu accsup = new BeePhieuThu();

            // accsup.TopLevel = false;
            // accsup.AutoScroll = true;
            // panelmain.Controls.Add(accsup);
            // accsup.Show();

            // Beemainload

            //  panelmain.Controls.Add(inputcdata);
            // inputcdata.Show();

        }

        private void báoCáoNhậpXuấtTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Model.Soketoan.socaitaikhoan();

        }

        private void inputMinuteTransferPOSMTicketToMKTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Model.Soketoan.soQuy();

        }

        private void báoCáoGiaoHàngHàngTrênĐườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Model.Soketoan.sochitiettaikhoan();
        }

        private void sôNhâtKyToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //    Model.Soketoan.sonhatkychung();



        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //  Model.Soketoan.sotonghoptaikhoanchitiet();
        }

        private void banCânĐôiTaiKhoanPhatSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   Model.Soketoan.bangcandoiphatsinhtaikhoan();
        }//

        private void pHẦNHÀNHKẾTOÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void sổQuỹToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bútToánTổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sổCáiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region  // bcsocai


            //  Model.Soketoan.socaitaikhoan();

            #endregion

        }

        private void sổTàiKhoảnTổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region// bcsotonghop


            //  Model.Soketoan.sotonghoptaikhoanchitiet();



            #endregion

        }

        private void sổChiTiếtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {



            #region//bcsochitiet


            //   Model.Soketoan.sochitiettaikhoan();


            #endregion

        }

        private void sổNhậtKýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region//bcsonhatkychung


            //  Model.Soketoan.sonhatkychung();


            #endregion

        }

        private void sổQuỹToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region//soquy


            //   Model.Soketoan.soQuy();


            #endregion

        }

        private void danhSáchLoạiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinDoanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void hệThốngTàiKhoảnKếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {


















        }

        private void phânQuyềnNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void danhSáchKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void danhSáchNhómSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTínDoanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchLoạiTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void danhSáchLoạiTàiKhoảnToolStripMenuItem2_Click(object sender, EventArgs e)
        {


        }

        private void hệThốngTàiKhoảnKếToánToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }


        private void báoCáoNhậpXuấtTồnKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            #region//bcxuatnhapton


            //   Model.Soketoan.sotonghopbaocaonhapxuatton();

            #endregion

        }

        private void sổKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //   Model.Soketoan();

        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //    Model.Soketoan.sotonghopbaocaonhapxuatton();

        }

        private void báoCáoKQKDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            #region//xem báo cóa ckqkd


            //  Model.Soketoan.baocaokqkd();

            #endregion

        }

        private void nhậpSốĐầuKỳKQKDToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void nhậpSốĐầuKỳCĐKTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bảngCĐKTToolStripMenuItem_Click(object sender, EventArgs e)
        {


            #region//bccan doi ke toan
            //if (name == "bcsonhatkychung")
            //{

            //   Model.Soketoan.baocaocandoiketoantt200lientuc();

            //  }
            #endregion


        }

        private void bảnCấnĐốiTàiKhoảnPhátSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {


            #region//bangsoducd
            //if (name == "bcsonhatkychung")
            //{

            //   Model.Soketoan.Bangcandoiphatsinhketoantt200lientuc();

            //  }
            #endregion


        }

        private void báoCáoLCTTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            #region//bangsoducd
            //if (name == "bcsonhatkychung")
            //{

            //   Model.Soketoan.baocaoluuchuyentiente();

            //  }
            #endregion


        }

        private void nhậpSốĐầuKỳLCTTToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //  Model.Soketoan.nhapsodudaukylctt();




        }

        private void danhSáchNhàXeToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void danhSáchXeToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void danhSáchKháchHàngVậnTảiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoNhậpXuấtTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void bảngGiáVậnTảiTheoTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    List<View.beeselectinput.ComboboxItem> CombomCollection = new List<View.beeselectinput.ComboboxItem>();
        //    string connection_string = Utils.getConnectionstr();

        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

        //    var rs = from p in dc.tbl_NP_khachhangvanchuyens
        //                 //     where p.Code != "DIS"
        //             orderby p.maKH
        //             select p;
        //    foreach (var item2 in rs)
        //    {
        //        View.beeselectinput.ComboboxItem cb = new View.beeselectinput.ComboboxItem();
        //        cb.Value = item2.maKH.Trim();
        //        cb.Text = item2.maKH.Trim() + ": " + item2.tenKH.Trim();// + "    || Example: " + item2.Example;
        //        CombomCollection.Add(cb);
        //    }


        //    beeselectinput choosesl = new beeselectinput("Chọn khách hàng vận tải", CombomCollection);
        //    choosesl.ShowDialog();

        //    if (choosesl.kq == true)
        //    {
        //        string makh = choosesl.value;
        //        String tenkh = choosesl.valuetext;
        //        //string connection_string = Utils.getConnectionstr();

        //        //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

        //        var rs1 = Model.Nhacungcap.danhsachgiatheotuyenvamanhavantai(dc, makh);
        //        Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH GIÁ THEO TUYẾN CỦA KHÁCH HÀNG " + tenkh.ToUpper(), 11, makh);// mã 8 là danh sach nha nha van tai

        //        viewtbl.Show();
        //    }
        //}

        private void danhSáchNhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }


        private void sổCânĐốiTàiKhoảnPhátSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            #region//bccan doi ke toan
            //if (name == "bcsonhatkychung")
            //{

            ///  Model.Soketoan.bangcandoiphatsinhtaikhoan();

            //  }
            #endregion




        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {



        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {


        }

        private void hạchToánKếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngTàiKhoảnKếToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sổQuỹToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void phiếuChiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void phiếuThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {



        }




        private void báoCáoNhậpXuấtTồnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            #region//bcxuatnhapton


            //   Model.Soketoan.sotonghopbaocaonhapxuatton();

            #endregion

        }

        private void bánHàngTạiCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void phiếuTínhGiáVàXácNhậnSảnPhẩmHoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void kếToánTiềnMặtToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

            #region//soquy


            //   Model.Soketoan.soQuy();


            #endregion

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

            #region//soquy


            //    Model.Soketoan.soQuy();


            #endregion

        }



        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void danhSáchNhàCungỨngToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void uploadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoPhiếuMKTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MKTFromdatetodate datepick = new MKTFromdatetodate();
            //datepick.ShowDialog();

            //DateTime fromdate = datepick.fromdate;
            //DateTime todate = datepick.todate;
            //bool kq = datepick.chon;

            //if (kq) // nueeus có chọn
            //{
            //    string connection_string = Utils.getConnectionstr();
            //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //    IQueryable rs = Model.MKT.DanhsachPhieuMKTandstatus(dc, fromdate, todate);


            //    Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU MAKETTING ", 100, "tk");// mã 5 là danh sach nha nha ccaaps

            //    viewtbl.ShowDialog();


            //}


        }







        private void lậpPhiếuXuấtĐồMKTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            #region//tmphieuthu
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTissuephieu2 accsup = new MKTissuephieu2(this, "", "");
            this.clearpannelload(accsup);
            // this.Close();
            #endregion




        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void storeAvaiableListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (!Username.getControlUsernameright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            #region//phanquyen

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var typeff = typeof(tbl_Temp);

            MKTInputchange inputcdata = new MKTInputchange("", "Thiết lập và phân quyền người dùng", dc, "tbl_Temp", "tbl_Temp", typeff, typeff, "id", "id", "");
            inputcdata.TopLevel = false;
            inputcdata.AutoScroll = true;

            //    main1.clearpannel();


            Controls.Add(inputcdata);
            inputcdata.Show();


            //Formload.TopLevel = false;
            //Formload.AutoScroll = true;
            //panelmain.Controls.Add(Formload);
            //Formload.Show();




            #endregion



        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!Username.getloadcreatedright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            #region//tao load
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTLoadcreated accsup = new MKTLoadcreated(this);
            this.clearpannelload(accsup);
            // this.Close();
            #endregion




        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //phiếu xuất kho


            if (!Username.getloadStoreIssueright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT LOADSERI NUMBER");
            pxk.ShowDialog();

            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (kq)
            {

                bool kq2 = true;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = (from pp in dc.tbl_MKt_ListLoadheadDetails
                           where pp.Serriload == Loadnumberserri

                           select pp).FirstOrDefault();
                if (rs5 == null)
                {
                    MessageBox.Show("Wrong serri load !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                    kq2 = false;
                    return;

                }


                var rs6 = (from pp in dc.tbl_MKt_WHstoreissues
                           where pp.Serriload == Loadnumberserri


                           select pp).FirstOrDefault();
                if (rs6 != null)
                {
                    MessageBox.Show("Phiếu đã xuất hàng rồi !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                    kq2 = false;
                    return;

                }



                if (kq2)
                {

                    #region// xuất hagf
                    //if (name == "tmphieuthu")
                    //{

                    //  Main.clearpannel();
                    //   Formload.
                    // clearpannel();
                    this.clearpannel();


                    View.MKTWHxuathang xuatkho = new MKTWHxuathang(this, Loadnumberserri);
                    this.clearpannelload(xuatkho);
                    // this.Close();
                    #endregion


                }


            }



        }

        private void xuấtĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //phiếu xuất kho
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT PO NUMBER ");
            pxk.ShowDialog();

            string POnumber = pxk.valuetext;
            bool kq = pxk.kq;
            if (kq)
            {

                #region// nhập hagf
                //if (name == "tmphieuthu")
                //{
                // MKTNhaphangtheoPo
                //  Main.clearpannel();
                //   Formload.
                // clearpannel();
                this.clearpannel();


                View.MKTNhaphangtheoPo nhaphang = new MKTNhaphangtheoPo(this, POnumber);
                this.clearpannelload(nhaphang);
                // this.Close();
                #endregion


            }





        }

        private void Storerpt_Click(object sender, EventArgs e)
        {


            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();
            string region = Model.Username.getuseRegion();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {



                var rs5 = from pp in dc.tbl_MKT_Stockends
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


                View.Viewtable tbl = new Viewtable(rs5, dc, "STORE REPORTS", 55, "STORERPT");
                tbl.ShowDialog();






            }



        }

        private void storeAvaiableReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            //string connection_string = Utils.getConnectionstr();

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            /////
            //string username = Utils.getusername();
            //string rightkho = Model.Username.getmaquyenkho();
            //string region = Model.Username.getuseRegion();

            ////    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            /////

            //var rs1 = from pp in dc.tbl_MKT_khoMKTs
            //          where (from gg in dc.tbl_MKT_StoreRights
            //                 where gg.storeright == rightkho
            //                 select gg.makho).Contains(pp.makho)
            //          select pp;
            //foreach (var item2 in rs1)


            //{
            //    View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
            //    cb.Value = item2.makho.Trim();
            //    cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
            //    CombomCollection.Add(cb);
            //}


            //MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            //choosesl.ShowDialog();

            //string storelocation = choosesl.value;
            //bool kq = choosesl.kq;
            //if (kq)
            //{



            //    var rs5 = from pp in dc.tbl_MKT_Stockends
            //              where pp.Store_code == storelocation
            //              select new
            //              {

            //                  pp.Store_code,
            //                  pp.SAP_CODE,
            //                  pp.ITEM_Code,

            //                  // pp.RegionBudgeted,


            //                  pp.MATERIAL,

            //                  pp.Description,

            //                  pp.END_STOCK,
            //                  pp.UNIT,

            //                  pp.Ordered,
            //                  pp.TransferingOUT,
            //                  pp.ON_Hold,
            //                  pp.Quantity_Per_Pallet,
            //                  pp.End_Stock_By_Pallet,

            //                  pp.id,


            //              };

            //    //foreach (var item in rs5)
            //    //{

            //    //    item.RegionBudgeted = Model.MKT.getBalancebuget(item.ITEM_Code, region, storelocation);
            //    //    dc.SubmitChanges();

            //    //}

            //    View.Viewtable tbl = new Viewtable(rs5, dc, "STORE REPORTS", 55, "STORERPT");
            //    tbl.ShowDialog();






            //}


        }

        private void statusGatepassReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPhieuMKTandstatus(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU MAKETTING ", 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }





        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Model.Username.getInventoryRight())
            {
                List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
                string connection_string = Utils.getConnectionstr();

                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                ///
                string username = Utils.getusername();
                string rightkho = Model.Username.getmaquyenkho();

                //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


                ///

                var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          where pp.storeright == rightkho
                          select pp;
                foreach (var item2 in rs1)


                {
                    View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                    cb.Value = item2.makho.Trim();
                    cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                    CombomCollection.Add(cb);
                }


                MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
                choosesl.ShowDialog();

                string storelocation = choosesl.value;
                bool kq = choosesl.kq;
                if (kq)
                {

                    #region//tao load
                    //if (name == "tmphieuthu")
                    //{

                    //  Main.clearpannel();
                    //   Formload.
                    // clearpannel();


                    this.clearpannel();


                    View.MKTWHcount demkho = new MKTWHcount(this, storelocation);
                    this.clearpannelload(demkho);
                    // this.Close();
                    #endregion

                }


            }
            else
            {
                View.MKTNoouthourise noright = new View.MKTNoouthourise();
                noright.ShowDialog();

            };


        }

        private void inventoryApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Model.Username.getInventoryAprrovalRight())
            {



                //  MKTViewchooseiquery
                List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
                string connection_string = Utils.getConnectionstr();

                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                ///
                string username = Utils.getusername();
                string rightkho = Model.Username.getmaquyenkho();

                //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


                ///

                var rs2 = from pp in dc.tbl_MKT_khoMKTs
                          where pp.storeright == rightkho
                          select pp;
                foreach (var item2 in rs2)


                {
                    View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                    cb.Value = item2.makho.Trim();
                    cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                    CombomCollection.Add(cb);
                }


                MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
                choosesl.ShowDialog();

                string storelocation = choosesl.value;
                bool kq = choosesl.kq;
                if (kq)
                {
                    #region// view
                    //    string connection_string = Utils.getConnectionstr();

                    //   LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                    var rs1 = from pp in dc.tbl_MKT_Stockcounts
                              where pp.Store_code == storelocation
                              && pp.Aproved == false
                              group pp by new
                              {
                                  pp.CountingDate,
                                  pp.Idsub
                              } into gg
                              select new
                              {
                                  Store = gg.Select(m => m.Store_code).FirstOrDefault(),
                                  Counting_Date = gg.Key.CountingDate,
                                  Counting_times = gg.Key.Idsub,

                                  //                Issued = gg.Sum(m => m.Issued),
                                  //                         Materiacode = gg.Key,//       gg.FirstOrDefault().Materiacode,
                                  //   Counting_times = gg.Select(m => m.Idsub).FirstOrDefault(),
                                  Createdby = gg.Select(m => m.Createdby).FirstOrDefault(),
                                  Aproval_Status = gg.Select(m => m.Aproved).FirstOrDefault(),
                                  Status = gg.Select(m => m.Status).FirstOrDefault(),
                                  Aproval_By = gg.Select(m => m.Aprovedby).FirstOrDefault(),

                                  id = gg.Select(m => m.id).FirstOrDefault(),

                              };


                    this.clearpannel();
                    //          MKTWHcountaproval
                    // STOCK COUNT LIST
                    View.MKTViewchooseiqueryloadtomain approvaldemkho = new MKTViewchooseiqueryloadtomain(this, rs1, dc, "STOCK COUNT WITH APROVAL STATUS ", "Counting_times");
                    this.clearpannelload(approvaldemkho);
                    // this.Close();
                    #endregion



                }

            }
            else
            {
                View.MKTNoouthourise noright = new View.MKTNoouthourise();
                noright.ShowDialog();

            };




        }

        private void storeManageToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void goodReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //phiếu xuất kho
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT LOADSERI NUMBER");
            pxk.ShowDialog();
            //c
            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = (from pp in dc.tbl_MKt_ListLoadheadDetails
                           where pp.Serriload == Loadnumberserri


                           select pp).FirstOrDefault();
                if (rs5 == null)
                {
                    MessageBox.Show("Wrong serri load !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;

                    return;

                }


                var rs6 = (from pp in dc.tbl_MKt_WHstoreissues
                           where pp.Serriload == Loadnumberserri


                           select pp).FirstOrDefault();
                if (rs6 == null)
                {
                    MessageBox.Show("Phiếu chưa làm xuất hàng, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;

                    return;

                }

                var rs7 = (from pp in dc.tbl_MKt_WHstoreissues
                           where pp.Serriload == Loadnumberserri
                           && pp.RecieptQuantity > 0


                           select pp).FirstOrDefault();
                if (rs7 != null)
                {
                    MessageBox.Show("Phiếu đã nhập hàng về rồi, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;

                    return;

                }



                #region// xuất hagf
                //if (name == "tmphieuthu")
                //{
                // MKTNhaphangtheoPo
                //  Main.clearpannel();
                //   Formload.
                // clearpannel();
                this.clearpannel();


                View.MKTNhaphangreturn xuatkho = new MKTNhaphangreturn(this, Loadnumberserri);
                this.clearpannelload(xuatkho);
                // this.Close();
                #endregion



            }




        }

        private void tậpHợpPhiếuMKTTrảVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getupdateGatePassDeliveredright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            #region//tmphieuthu
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTupdateMKTcompleted accsup = new MKTupdateMKTcompleted(this);
            this.clearpannelload(accsup);
            // this.Close();
            #endregion


        }

        private void inputPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //       MKTPOmake


            #region//MKTPOmake
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTPOmake accsup = new MKTPOmake(this);
            this.clearpannelload(accsup);
            // this.Close();
            #endregion







        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MKTPasswordchange change = new MKTPasswordchange();
            change.ShowDialog();
        }

        private void uploadBeginStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {




            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                      where (from gg in dc.tbl_MKT_StoreRights
                             where gg.storeright == rightkho
                             select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("SELECT STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {



                Model.StoreMKT stor = new StoreMKT();
                stor.InputBeginstorefuction(storelocation);




            }


        }

        private void transferOUtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getloadTransferOUtright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }





            this.clearpannel();


            View.MKTWHtransferout storout = new MKTWHtransferout(this);
            this.clearpannelload(storout);





        }

        private void transferInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getloadTransferINright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }
            //phiếu xuất kho
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT TRANSFER IN NUMBER ");
            pxk.ShowDialog();

            string Transfernumber = pxk.valuetext;
            bool kq = pxk.kq;
            if (kq)
            {

                #region// nhập hagf
                //if (name == "tmphieuthu")
                //{
                // MKTNhaphangtheoPo
                //  Main.clearpannel();
                //   Formload.
                // clearpannel();
                this.clearpannel();


                View.MKTTransferin nhaphang = new MKTTransferin(this, Transfernumber);
                this.clearpannelload(nhaphang);


                // this.Close();
                #endregion


            }







        }

        private void uploadCustomerListToolStripMenuItem_Click(object sender, EventArgs e)
        {







        }

        private void uploadCustomerListToolStripMenuItem1_Click(object sender, EventArgs e)
        {









        }

        private void uploadBeginStoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Username.getuploadBeginStoreright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("SELECT STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {



                Model.StoreMKT stor = new StoreMKT();
                stor.InputBeginstorefuction(storelocation);


                MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getCustomerUploadright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }
            Model.customerinput_ctrl inpoutctm = new customerinput_ctrl();


            inpoutctm.customerinputcustomerlist();

            MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void uploadShiptoCodeListToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!Username.getCustomerUploadright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            Model.customerinput_ctrl inpoutctm = new customerinput_ctrl();


            inpoutctm.customerinputshiptocode();

            MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void viewCustomerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Soldtocodes
                      where pp.Soldtype == true
                      select pp;



            View.Viewtable tbl = new Viewtable(rs5, dc, "Soldto List", 111, "STORERPT");
            tbl.ShowDialog();



        }

        private void viewShiptoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Soldtocodes
                          //       where pp.Soldtype == false
                      select pp;



            View.Viewtable tbl = new Viewtable(rs5, dc, "Shipto List", 111, "STORERPT");
            tbl.ShowDialog();


        }

        private void storeLocationManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Model.Username.getStoreLocationmanageRight())
            {



                //    NPDanhsachnhavantai
                string connection_string = Utils.getConnectionstr();

                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs1 = Model.MKT.danhsachkhoMKT(dc);
                Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH KHO MAKETTING ", 4, "MKT_kHOHANG");// mã 4 là danh sach KHO HÀNG

                viewtbl.ShowDialog();
            }
            else
            {
                View.MKTNoouthourise noright = new View.MKTNoouthourise();
                noright.ShowDialog();

            };

        }

        private void addNewProductListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("SELECT STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {



                Model.StoreMKT stor = new StoreMKT();
                stor.ADDnewproductlist(storelocation);





                var rs5 = from pp in dc.tbl_MKT_StockendTMPs
                          where pp.Username == username
                          select pp;



                View.Viewtable tbl = new Viewtable(rs5, dc, "NEW PRODUCT TO UPLOAD", 101, username);
                tbl.ShowDialog();







                //    MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void iOButgetReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerChanelListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerChannelManageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getChannelsalesManageright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_CustomerChanels
                          //   where pp.Soldtype == true
                      select pp;


            View.Viewtable tbl = new Viewtable(rs5, dc, "Channel list", 17, "Channel");
            tbl.ShowDialog();


        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getCustomerEditright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.danhkhachhangrutgon(dc);
            Viewtable viewtbl = new Viewtable(rs1, dc, "CUSTOMER LIST ", 12, "MKT_KH");// mã 12 là danh sach khách hàng MKT

            viewtbl.Show();

        }

        private void iOBudgetSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getIOmanageright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }



            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var rs5 = from pp in dc.tbl_MKT_IO_Programes

            //          select pp;


            var rs5 = Model.MKT.DanhsachctMKT(dc);

            View.Viewtable tbl = new Viewtable(rs5, dc, "Progarme list", 13, "IO");
            tbl.ShowDialog();

        }

        private void channelListToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!Username.getChannelsalesManageright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_CustomerChanels
                          //   where pp.Soldtype == true
                      select pp;


            View.Viewtable tbl = new Viewtable(rs5, dc, "Channel list", 17, "Channel");
            tbl.ShowDialog();

        }

        private void regionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getSalesRegionManageright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Regions
                          //   where pp.Soldtype == true
                      select pp;


            View.Viewtable tbl = new Viewtable(rs5, dc, "Region list", 18, "Region");
            tbl.ShowDialog();




        }

        private void salesOrgListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getSalesLocationright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_SaleOrgs
                          //   where pp.Soldtype == true
                      select pp;


            View.Viewtable tbl = new Viewtable(rs5, dc, "SaleOrg list", 19, "SaleOrg");
            tbl.ShowDialog();



        }

        private void setIOButgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getSetPOSMprogrameright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            View.MKTProgramemakeandsetIObutger accsup = new MKTProgramemakeandsetIObutger();
            accsup.Show();



        }

        private void viewProgrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getViewProgramePDFright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Programepdfdatas
                          //   where pp.Soldtype == true
                      select new
                      {
                          pp.ProgrameIDDocno,
                          pp.Name,
                          //   pp.Contentype


                      };



            View.Viewtable tbl = new Viewtable(rs5, dc, "PROGRAME POSM SCHEME FILE LIST", 100, "Schemeprograme");
            tbl.ShowDialog();

        }

        private void paymentApprovalSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getAprovalPaymentRequestright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            //View.MKTProgramepaymentaproval accsup = new MKTProgramepaymentaproval();
            //accsup.Show();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Payment_Aproval_heads
                      where pp.payID != null && pp.Approval == "Not Approved"
                      select new
                      {
                          pp.payID,
                          pp.IO_number,
                          pp.ProgrameIDDocno,
                          pp.ProgrameName,
                          Budge_Requested = pp.TotalAprovalBudget,
                          pp.Account,
                          pp.costcenter,
                          pp.Requestby,
                          pp.Approval,


                      };



            View.Viewtable tbl = new Viewtable(rs5, dc, "LIST PAYMENTs REQUEST For APPROVAl", 100, "PaymentRequest");
            tbl.ShowDialog();

        }

        private void paymentApprovalRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void viewPaymentRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateGatePassDeliveredToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getAprovalPaymentRequestright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }
            #region//tmphieuthu
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTupdateMKTcompleted accsup = new MKTupdateMKTcompleted(this);
            this.clearpannelload(accsup);
            // this.Close();
            #endregion

        }

        private void viewAllPaymentRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Payment_Aproval_heads
                      where pp.payID != null
                      select new
                      {
                          pp.payID,
                          pp.IO_number,
                          pp.ProgrameIDDocno,
                          pp.ProgrameName,
                          Budge_Requested = pp.TotalAprovalBudget,
                          pp.Account,
                          pp.costcenter,
                          pp.Requestby,
                          pp.Approval,


                      };



            View.Viewtable tbl = new Viewtable(rs5, dc, "LIST PAYMENTs REQUEST", 100, "PaymentRequestview");
            tbl.ShowDialog();
        }

        private void setPOSMProgrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getSetPOSMprogrameright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }



            View.MKTProgramemakeandsetIObutger accsup = new MKTProgramemakeandsetIObutger();
            accsup.Show();

        }

        private void setPOSMProgrameToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void approvalPaymentRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateGatePassDeliveredToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Username.getupdateGatePassDeliveredright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }
            #region//tmphieuthu
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTupdateMKTcompleted accsup = new MKTupdateMKTcompleted(this);
            this.clearpannelload(accsup);
            // this.Close();
            #endregion

        }

        private void reportsRegionProgramBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //  MKTViewchooseiquery
            List<View.MKTselectStoreandRegion.ComboboxItem> CombomCollection1 = new List<View.MKTselectStoreandRegion.ComboboxItem>();
            List<View.MKTselectStoreandRegion.ComboboxItem> CombomCollection2 = new List<View.MKTselectStoreandRegion.ComboboxItem>();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs2 = from pp in dc.tbl_MKT_khoMKTs
                      where pp.storeright == rightkho
                      select pp;
            foreach (var item2 in rs2)


            {
                View.MKTselectStoreandRegion.ComboboxItem cb = new View.MKTselectStoreandRegion.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection1.Add(cb);
            }
            //

            var rs3 = from pp in dc.tbl_MKT_Regions
                          //  where pp.Region == rightkho
                      select pp;
            foreach (var item2 in rs3)


            {
                View.MKTselectStoreandRegion.ComboboxItem cb = new View.MKTselectStoreandRegion.ComboboxItem();
                cb.Value = item2.Region.Trim();
                cb.Text = item2.Region.Trim() + ": " + item2.Note.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection2.Add(cb);
            }

            MKTselectStoreandRegion choosesl = new MKTselectStoreandRegion("PLEASE SELECT A STORE ", "STORE", "REGION", CombomCollection1, CombomCollection2);
            choosesl.ShowDialog();

            string storelocation = choosesl.value1;
            string region = choosesl.value2;
            bool kq = choosesl.kq;
            if (kq)
            {




                var rs5 = from pp in dc.tbl_MKT_StockendRegionBudgets
                          where pp.Region == region
                          && pp.Store_code == storelocation
                          group pp by new
                          {
                              pp.Region,
                              pp.ITEM_Code,

                          } into gg
                          select new
                          {
                              Region = gg.Key.Region,
                              Shipping_Point = storelocation,
                              Material_Item_Code = gg.Key.ITEM_Code,
                              Material_SAP_Code = gg.Select(m => m.SAP_CODE).FirstOrDefault(),
                              Material_Name = gg.Select(m => m.MATERIAL).FirstOrDefault(),
                              Description = gg.Select(m => m.Description).FirstOrDefault(),
                              UNIT = gg.Select(m => m.UNIT).FirstOrDefault(),
                              Quantity_PO_Reciepted = gg.Sum(m => m.QuantityInputbyPO).GetValueOrDefault(0),
                              Issued = gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                              Return_Ticket = gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0),

                              Adjusted_Device_Stock = gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0),





                              Balance = gg.Sum(m => m.QuantityInputbyPO).GetValueOrDefault(0) + gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0) + gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0) - gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                          };


                View.Viewtable tbl = new Viewtable(rs5, dc, "REGION STOCK BUDGET ON STORE ", 55, "rEgIONBUTGETINSTORE");
                tbl.ShowDialog();



            }




        }

        private void gatepassHavePOSMReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getReturnticketRight())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            //phiueeys gatpaste
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT GATEPASS SERRI");
            pxk.ShowDialog();
            //c
            string Gatepassseru = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = (from pp in dc.tbl_MKt_Listphieuheads
                           where pp.Region + pp.ShippingPoint + pp.Gate_pass == Gatepassseru
                           // && pp.completed == true


                           select pp).FirstOrDefault();
                if (rs5 == null)
                {
                    MessageBox.Show("Wrong serri Gatepass !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;

                    return;

                }
                //tbl_MKT_StockendRegionBudget newregionupdate = new tbl_MKT_StockendRegionBudget();

                //newregionupdate.ITEM_Code = item.Materiacode;
                //newregionupdate.SAP_CODE = item.Materiacode;
                //newregionupdate.MATERIAL = item.Materialname;
                //newregionupdate.Description = item.;
                //newregionupdate.Region = item.Region;
                //newregionupdate.QuantityInputbyPO = 0;// Math.Round((float)dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value * (float)item.inputRate);
                //newregionupdate.QuantityInputbyReturn = float.Parse(dataGridViewLoaddetail.Rows[idrow].Cells["Return_Quantity"].Value.ToString());// 0;

                //newregionupdate.QuantityReceipt = float.Parse(dataGridViewLoaddetail.Rows[idrow].Cells["Return_Quantity"].Value.ToString());// 0;
                //newregionupdate.DnNumber = this.ticketserri.Truncate(50);
                //newregionupdate.DocumentNumber = this.ticketserri.Truncate(50);

                var rs6 = (from pp in dc.tbl_MKT_StockendRegionBudgets
                           where pp.DocumentNumber == Gatepassseru
                           //  && (pp.Status != "Delivering" || pp.Status != "completed")

                           select pp).FirstOrDefault();
                if (rs6 != null)
                {
                    MessageBox.Show("Phiếu đã nhập hàng về rồi !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }




                #region// xuất hagf
                //if (name == "tmphieuthu")
                //{
                // MKTNhaphangtheoPo
                //  Main.clearpannel();
                //   Formload.
                // clearpannel();
                this.clearpannel();


                View.MKTNhaphangreturnbyTicket xuatkho = new MKTNhaphangreturnbyTicket(this, Gatepassseru);
                this.clearpannelload(xuatkho);
                // this.Close();
                #endregion



            }


        }

        private void viewStockCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Model.Username.getviewCountingright())
            {



                //  MKTViewchooseiquery
                List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
                string connection_string = Utils.getConnectionstr();

                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                ///
                string username = Utils.getusername();
                string rightkho = Model.Username.getmaquyenkho();

                //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


                ///

                var rs2 = from pp in dc.tbl_MKT_khoMKTs
                          where pp.storeright == rightkho
                          select pp;
                foreach (var item2 in rs2)


                {
                    View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                    cb.Value = item2.makho.Trim();
                    cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                    CombomCollection.Add(cb);
                }


                MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
                choosesl.ShowDialog();

                string storelocation = choosesl.value;
                bool kq = choosesl.kq;
                if (kq)
                {
                    #region// view
                    //    string connection_string = Utils.getConnectionstr();

                    //   LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                    var rs1 = from pp in dc.tbl_MKT_Stockcounts
                              where pp.Store_code == storelocation
                              && pp.Aproved == true
                              group pp by new
                              {
                                  pp.CountingDate,
                                  pp.Idsub
                              } into gg
                              select new
                              {
                                  Store = gg.Select(m => m.Store_code).FirstOrDefault(),
                                  Counting_Date = gg.Key.CountingDate,
                                  Counting_times = gg.Key.Idsub,

                                  //                Issued = gg.Sum(m => m.Issued),
                                  //                         Materiacode = gg.Key,//       gg.FirstOrDefault().Materiacode,
                                  //   Counting_times = gg.Select(m => m.Idsub).FirstOrDefault(),
                                  Createdby = gg.Select(m => m.Createdby).FirstOrDefault(),
                                  Aproval_Status = gg.Select(m => m.Aproved).FirstOrDefault(),
                                  Status = gg.Select(m => m.Status).FirstOrDefault(),
                                  Aproval_By = gg.Select(m => m.Aprovedby).FirstOrDefault(),

                                  id = gg.Select(m => m.id).FirstOrDefault(),

                              };


                    this.clearpannel();
                    //          MKTWHcountaproval

                    View.MKTViewchooseiqueryloadtomain approvaldemkho = new MKTViewchooseiqueryloadtomain(this, rs1, dc, "STOCK COUNT LIST", "Counting_view");
                    this.clearpannelload(approvaldemkho);
                    // this.Close();
                    #endregion



                }

            }
            else
            {
                View.MKTNoouthourise noright = new View.MKTNoouthourise();
                noright.ShowDialog();

            };



        }

        private void storeDiviceByRegiomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Model.Username.getInventoryRight())
            {
                View.MKTNoouthourise noright = new View.MKTNoouthourise();
                noright.ShowDialog();
                return;
            }



            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                      where pp.storeright == rightkho
                      select pp;
            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {

                //------------



                #region//chia budget
                //if (name == "tmphieuthu")
                //{

                //  Main.clearpannel();
                //   Formload.
                // clearpannel();


                this.clearpannel();


                View.MKTWHDeviceRegion demkho = new MKTWHDeviceRegion(this, storelocation);
                this.clearpannelload(demkho);
                // this.Close();
                #endregion












                //---------


            }




        }

        private void channelManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getChannelsalesManageright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_CustomerChanels
                          //   where pp.Soldtype == true
                      select pp;


            View.Viewtable tbl = new Viewtable(rs5, dc, "Channel list", 17, "Channel");
            tbl.ShowDialog();
        }

        private void paymentRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getRequestpaymentApprovalright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            View.MKTProgramepaymentaproval accsup = new MKTProgramepaymentaproval();
            accsup.Show();

        }

        private void viewPaymentRequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Payment_Aproval_heads
                      where pp.payID != null
                      select new
                      {
                          pp.payID,
                          pp.IO_number,
                          pp.ProgrameIDDocno,
                          pp.ProgrameName,
                          Budget_Requested = pp.TotalAprovalBudget,
                          pp.Account,
                          pp.costcenter,
                          pp.Requestby,
                          pp.Approval,


                      };



            View.Viewtable tbl = new Viewtable(rs5, dc, "LIST PAYMENTS REQUEST", 100, "PaymentRequestview");
            tbl.ShowDialog();
        }

        private void massInputPOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iOListManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getIOmanageright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }



            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var rs5 = from pp in dc.tbl_MKT_IO_Programes

            //          select pp;


            var rs5 = Model.MKT.DanhsachctMKT(dc);

            View.Viewtable tbl = new Viewtable(rs5, dc, "Progarme list", 13, "IO");
            tbl.ShowDialog();
        }

        private void pOSMProgramCreatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getSetPOSMprogrameright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            View.MKTProgramemake2 accsup = new MKTProgramemake2();
            accsup.Show();

        }

        private void setPOSMProgarm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getSetPOSMprogrameright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            View.MKTProgramemake2 accsup = new MKTProgramemake2();
            accsup.Show();

        }

        private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem1_Click_3(object sender, EventArgs e)
        {
            //MKTFromdatetodateRegion datepick = new MKTFromdatetodateRegion();
            //datepick.ShowDialog();

            //DateTime fromdate = datepick.fromdate;
            //DateTime todate = datepick.todate;
            //string region = datepick.region;
            //string statusphieu = datepick.ststusphieu.Trim();

            //bool kq = datepick.chon;

            //if (kq) // nueeus có chọn
            //{
            //    string connection_string = Utils.getConnectionstr();
            //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //    IQueryable rs = Model.MKT.DanhsachPhieuMKTandstatusbyregion(dc, fromdate, todate, region, statusphieu);


            //    Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU MAKETTING ", 100, "tk");// mã 100 là danh sach nha nha phiếu

            //    viewtbl.ShowDialog();


            //}






        }

        private void storeInputDetailByPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPOnham(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU PHIẾU NHẬP KHO THEO PO ", 55, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void pOListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPOList(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "PO LIST ", 55, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void inputPOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //       MKTPOmake


            #region//MKTPOmake
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTPOmake accsup = new MKTPOmake(this);
            this.clearpannelload(accsup);
            // this.Close();
            #endregion



        }

        private void pOListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPOList(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "PO LIST ", 55, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void recieptedReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPOnham(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PO NHẬP KHO", 55, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void gRListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachGRList(dc, fromdate, todate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "Good Receipt list", 1000, "GR List");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void goodReceiptListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachGRList(dc, fromdate, todate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "Good Receipt list", 1000, "GR List");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void stockMovementDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentdetail(dc, fromdate, todate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL ", 1000, "tkdetailnhapxuattheosanpham");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void pODetailListReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPOList(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "PO LIST ", 55, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void inOutStoreReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentsUMMARY(dc, fromdate, todate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT SUMMARY ", 1000, "tksumarystoremovement");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void storeBalanceOnDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdateandstore datepick = new MKTFromdateandstore();
            datepick.ShowDialog();

            DateTime Ondate = datepick.Ondate.Date;
            //   DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsacStoreOndate(dc, Ondate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "Inventory report on date: " + Ondate.ToShortDateString(), 1000, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }






        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {



            MKTFromdateandStoreandRegion choosesl = new MKTFromdateandStoreandRegion();

            choosesl.ShowDialog();

            string storelocation = choosesl.store;
            string region = choosesl.region;
            DateTime Fromdate = choosesl.fromdate;
            DateTime Todate = choosesl.todate;




            bool kq = choosesl.kq;
            if (kq)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);




                var rs5 = from gg in dc.tbl_MKT_StockendRegionBudgets
                          where gg.Region == region
                          && gg.Store_code == storelocation
                          && gg.Regionchangedate >= Fromdate
                          && gg.Regionchangedate <= Todate
                          //group pp by new
                          //{
                          //    pp.Region,
                          //    pp.ITEM_Code,

                          //} into gg
                          select new
                          {
                              Region = gg.Region,
                              gg.DocumentNumber,
                              gg.DnNumber,

                              Shipping_Point = storelocation,
                              Material_Item_Code = gg.ITEM_Code,
                              Material_SAP_Code = gg.SAP_CODE,
                              Material_Name = gg.MATERIAL,
                              Description = gg.Description,
                              UNIT = gg.UNIT,
                              Quantity_PO_Reciepted = gg.QuantityInputbyPO,
                              Issued = gg.QuantityOutput,//gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                              Return_Ticket = gg.QuantityInputbyReturn,// gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0),
                              Transfer_in = gg.QuantityInputbytransferin,
                              Adjusted_Device_Stock = gg.QuantitybyDevice,// gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0),





                              //  Balance = gg.Sum(m => m.QuantityInputbyPO).GetValueOrDefault(0) + gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0) + gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0) - gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                          };


                View.Viewtable tbl = new Viewtable(rs5, dc, "REGION STOCK MOVEMENT REPORTS FROM DATE: " + Fromdate.ToShortDateString() + " TO DATE: " + Todate.ToShortDateString(), 1000, "reginmovementstock");
                tbl.ShowDialog();



            }

        }

        private void pOListReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPOList(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "PO LIST ", 55, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void pODetailByRegionListReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdateandStoreandRegion choosesl = new MKTFromdateandStoreandRegion();

            choosesl.ShowDialog();

            string storelocation = choosesl.store;
            string region = choosesl.region;
            DateTime Fromdate = choosesl.fromdate;
            DateTime Todate = choosesl.todate;




            bool kq = choosesl.kq;
            if (kq)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);




                IQueryable rs = Model.MKT.DanhsachPOListbyregion(dc, Fromdate, Todate, region);




                View.Viewtable tbl = new Viewtable(rs, dc, "PO Detail by region list Reports FROM DATE: " + Fromdate.ToShortDateString() + " TO DATE: " + Todate.ToShortDateString(), 1000, "reginmovementstock");
                tbl.ShowDialog();



            }

        }

        private void pORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdateandStoreandRegion choosesl = new MKTFromdateandStoreandRegion();

            choosesl.ShowDialog();

            string storelocation = choosesl.store;
            string region = choosesl.region;
            DateTime Fromdate = choosesl.fromdate;
            DateTime Todate = choosesl.todate;




            bool kq = choosesl.kq;
            if (kq)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);




                IQueryable rs = Model.MKT.DanhsachPOListbyregion(dc, Fromdate, Todate, region);




                View.Viewtable tbl = new Viewtable(rs, dc, "REGION STOCK MOVEMENT REPORTS FROM DATE: " + Fromdate.ToShortDateString() + " TO DATE: " + Todate.ToShortDateString(), 1000, "reginmovementstock");
                tbl.ShowDialog();



            }
        }

        private void customerEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Username.getCustomerEditright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.danhkhachhang(dc);
            Viewtable viewtbl = new Viewtable(rs1, dc, "CUSTOMER LIST ", 12, "MKT_KH");// mã 12 là danh sach khách hàng MKT

            viewtbl.Show();
        }

        private void viewCustomerListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Soldtocodes
                      where pp.Soldtype == true
                      select pp;



            View.Viewtable tbl = new Viewtable(rs5, dc, "Soldto List", 1000, "STORERPT");
            tbl.ShowDialog();

        }

        private void viewShiptoListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Soldtocodes
                          //       where pp.Soldtype == false
                      select pp;



            View.Viewtable tbl = new Viewtable(rs5, dc, "Shipto List", 111, "STORERPT");
            tbl.ShowDialog();
        }

        private void findMakettingTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            IQueryable rs = Model.MKT.DanhsachPhieuMKTandstatus(dc, DateTime.Today, DateTime.Today);


            Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU MAKETTING ", 100, "tk");// mã 5 là danh sach nha nha ccaaps

            viewtbl.Show();



        }

        private void danhSaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MKTFromdatetodate datepick = new MKTFromdatetodate();
            //  datepick.ShowDialog();

            //    DateTime fromdate = datepick.fromdate;
            //    DateTime todate = datepick.todate;
            //  bool kq = datepick.chon;

            //  if (kq) // nueeus có chọn
            //   {
            string usernamefind = Utils.getusername();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            IQueryable rs = Model.MKT.DanhsachPhieuundelivery(dc, usernamefind);


            Viewtable viewtbl = new Viewtable(rs, dc, "Gate pass Undelivery detail list", 100, "tk");// mã 5 là danh sach nha nha ccaaps

            viewtbl.ShowDialog();


            //  }

        }

        private void viewMasterDataProductListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerAndShiptoListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Username.getCustomerUploadright())
            {
                View.MKTNoouthourise view = new MKTNoouthourise();
                view.ShowDialog();
                return;
            }


            Model.customerinput_ctrl inpoutctm = new customerinput_ctrl();


            inpoutctm.addcustomerinputshiptocode();

            MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gatePassUndeliveryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MKTFromdatetodate datepick = new MKTFromdatetodate();
            //  datepick.ShowDialog();

            //    DateTime fromdate = datepick.fromdate;
            //    DateTime todate = datepick.todate;
            //  bool kq = datepick.chon;

            //  if (kq) // nueeus có chọn
            //   {
            string usernamefind = Utils.getusername();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            IQueryable rs = Model.MKT.DanhsachPhieuundeliveryhead(dc, usernamefind);


            Viewtable viewtbl = new Viewtable(rs, dc, "Gate pass Undelivery list", 100, "tkhead");// mã 5 là danh sach nha nha ccaaps

            viewtbl.ShowDialog();

        }

        private void mKTCollectedRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {


            #region//MKTissuereturnRequest
            //if (name == "tmphieuthu")
            //{

            //  Main.clearpannel();
            //   Formload.
            // clearpannel();
            this.clearpannel();


            View.MKTissuereturnRequest accsup = new MKTissuereturnRequest(this, "", "");
            this.clearpannelload(accsup);
            // this.Close();
            #endregion







        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {




            ////    xx
            //             if (!Username.getaddNewProductRight())
            //    {
            //        //   View.MKTsanphammoi view = new MKTsanphammoi();

            //        List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            //        string connection_string = Utils.getConnectionstr();

            //        LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //        ///
            //        string username = Utils.getusername();
            //        string rightkho = Model.Username.getmaquyenkho();
            //        string region = Model.Username.getuseRegion();

            //        //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            //        ///

            //        var rs1 = from pp in dc.tbl_MKT_khoMKTs
            //                      //   where (from gg in dc.tbl_MKT_StoreRights
            //                      //        where gg.storeright == rightkho
            //                      //      select gg.makho).Contains(pp.makho)
            //                  select pp;

            //        foreach (var item2 in rs1)


            //        {
            //            View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
            //            cb.Value = item2.makho.Trim();
            //            cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
            //            CombomCollection.Add(cb);
            //        }


            //        MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            //        choosesl.ShowDialog();

            //        string storelocation = choosesl.value;
            //        bool kq = choosesl.kq;
            //        if (kq)
            //        {



            //            var rs5 = from pp in dc.tbl_MKT_Stockends
            //                      where pp.Store_code == storelocation
            //                      select new
            //                      {

            //                          pp.Store_code,
            //                          pp.SAP_CODE,
            //                          pp.ITEM_Code,

            //                          // pp.RegionBudgeted,


            //                          pp.MATERIAL,

            //                          pp.Description,

            //                          pp.END_STOCK,
            //                          pp.UNIT,

            //                          pp.Ordered,

            //                          pp.TransferingOUT,
            //                          pp.ON_Hold,
            //                          pp.Quantity_Per_Pallet,
            //                          pp.End_Stock_By_Pallet,

            //                          pp.id,


            //                      };


            //            View.Viewtable tbl = new Viewtable(rs5, dc, "STORE REPORTS", 55, "STORERPT");
            //            tbl.Show();



            //            View.MKTsanphammoi view = new MKTsanphammoi(1,0,"", tbl);
            //            view.ShowDialog();

            //        }

            //    }


            //    Model.customerinput_ctrl inpoutctm = new customerinput_ctrl();


            //    inpoutctm.customerinputshiptocode();

            //    MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void checkAndUpdateStatusAfterIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///

            var rs = from pp in dc.tbl_MKt_WHstoreissues
                     where pp.LoadNumber != ""
                     select pp.LoadNumber;


            var rs2 = from p in dc.tbl_MKt_ListLoadheads
                      where rs.Contains(p.LoadNumber)
                      && (p.Status == "Shipping" || p.Status == "CRT")
                      select p;

            if (rs2.Count() > 0)
            {
                foreach (var item in rs2)
                {

                    item.Status = "Delivering";
                    dc.SubmitChanges();
                    //                        All
                    //CRT
                    //Shipping
                    //Delivering
                    //completed
                }
            }

            //var rs = from pp in dc.tbl_MKt_WHstoreissues
            //         where pp.LoadNumber != ""
            //         select pp.LoadNumber;


            var rs3 = from p in dc.tbl_MKt_Listphieudetails
                      where rs.Contains(p.ShipmentNumber)
                      && (p.Status == "Shipping" || p.Status == "CRT")
                      select p;

            if (rs2.Count() > 0)
            {
                foreach (var item in rs2)
                {

                    item.Status = "Delivering";
                    dc.SubmitChanges();
                    //                        All
                    //CRT
                    //Shipping
                    //Delivering
                    //completed
                }
            }





            MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        var q = from tblVat in dc.tblVats
            //                where !(from tblFBL5N in dc.tblFBL5Ns
            //                        select tblFBL5N.Document_Number).Contains(tblVat.SAP_Invoice_Number)
            //                && tblVat.Invoice_Amount_Before_VAT > 0
            //                select tblVat;



            //if (q.Count() != 0)
            //{

            //    Viewtable viewtbl = new Viewtable(q, dc, "List các document có trong bảng VAT không có trong bảng FBL5N ! Please check ", 1, DateTime.Today, DateTime.Today);
            //    viewtbl.ShowDialog();
            //    return false;
            //}


            //                      where pp.Store_code == storelocation


            //tbl_MKt_WHstoreissue phieuxuat = new tbl_MKt_WHstoreissue();

            //phieuxuat.IssueBy = txtnguoixuathang.Text;
            //phieuxuat.Issued = (float)dataGridViewLoaddetail.Rows[idrow].Cells["Real_issue"].Value;
            //phieuxuat.IssueDate = datecreated.Value;
            //phieuxuat.date_input_output = datecreated.Value;
            //phieuxuat.Document_number = this.Loadnumberserri;
            ////          phieuxuat.Unit = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_code"].Value;
            //phieuxuat.IssueIDsub = IssueIDsub;
            //phieuxuat.LoadNumber = this.soload;
            //phieuxuat.MateriaItemcode = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_code"].Value.ToString().Trim();

            //phieuxuat.Materiacode = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_code"].Value.ToString().Trim();
            //phieuxuat.Materialname = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_name"].Value.ToString().Truncate(50);
            //phieuxuat.Serriload = this.Loadnumberserri;
            //phieuxuat.ShippingPoint = this.storelocation;
            //phieuxuat.Status = "CRT";
            //phieuxuat.Username = this.Username;

            //dc.tbl_MKt_WHstoreissues.InsertOnSubmit(phieuxuat);
            //dc.SubmitChanges();







        }

        private void revertWrongReturnTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //phiếu xuất kho
            MKTvalueinput pxk = new MKTvalueinput("LOADSERI NUMBER To Return Revert");
            pxk.ShowDialog();
            //c
            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = (from pp in dc.tbl_MKt_ListLoadheadDetails
                           where pp.Serriload == Loadnumberserri


                           select pp).FirstOrDefault();
                if (rs5 == null)
                {
                    MessageBox.Show("Wrong serri load !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;

                    return;

                }


                var rs6 = (from pp in dc.tbl_MKt_WHstoreissues
                           where pp.Serriload == Loadnumberserri


                           select pp).FirstOrDefault();
                if (rs6 == null)
                {
                    MessageBox.Show("Phiếu chưa làm xuất hàng, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;

                    return;

                }

                var rs7 = (from pp in dc.tbl_MKt_WHstoreissues
                           where pp.Serriload == Loadnumberserri
                           && pp.RecieptQuantity >= 0


                           select pp);
                if (rs7.Count() > 0)
                {
                    // MessageBox.Show("Phiếu đã nhập hàng về rồi, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;

                    // return;
                    foreach (var item in rs7)
                    {



                        Model.MKT.giamtrukhokhireverthangnhamsaive(item);
                        dc.tbl_MKt_WHstoreissues.DeleteOnSubmit(item);
                        dc.SubmitChanges();



                        //      Model.MKT.tangkhokhinhaphang(item, this.storelocation);




                    }






                }


                MessageBox.Show("Revert Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //#region// xuất hagf
                ////if (name == "tmphieuthu")
                ////{
                //// MKTNhaphangtheoPo
                ////  Main.clearpannel();
                ////   Formload.
                //// clearpannel();
                //this.clearpannel();


                //View.MKTNhaphangreturn xuatkho = new MKTNhaphangreturn(this, Loadnumberserri);
                //this.clearpannelload(xuatkho);
                //// this.Close();
                //#endregion



            }


        }

        private void gatepassIssueFormDateToDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPhieuMKTandstatusbyIssuedate(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU MAKETTING ISSUE FROM : " + fromdate.ToShortDateString() + " TO: " + todate.ToShortDateString(), 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }


        }

        private void deleteShiptoCodeIsNotANumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKT_Soldtocodes
                         //   where Utils.IsValidnumber(p.ShiptoCode) == false
                     select p;
            if (rs.Count() > 0)
            {

                foreach (var item in rs)
                {

                    if (!Utils.IsValidnumber(item.ShiptoCode))
                    {

                        item.Createby = "0";
                        dc.SubmitChanges();


                    }


                }

            }

            var rs2 = from p in dc.tbl_MKT_Soldtocodes
                      where p.Createby == "0"
                      select p;

            if (rs2.Count() > 0)
            {
                dc.tbl_MKT_Soldtocodes.DeleteAllOnSubmit(rs2);
                dc.SubmitChanges();

            }

            //Viewtable viewtbl = new Viewtable(rs2, dc, "Danh sách shipto code sai", 100, "shiptocodewrong");// mã 5 là danh sach nha nha ccaaps

            //viewtbl.ShowDialog();

            MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void reDeviceGoodRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;


            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachGRList(dc, fromdate, todate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "Detail Goodreceipt List - Double click to redevice for each region ", 1000, "tkRedeviceGRforRegion");// mã 5 là danh sach nha nha ccaaps

                viewtbl.Show();


            }







        }

        private void findGatepassOfShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT LOADSERI NUMBER");
            pxk.ShowDialog();

            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = from pp in dc.tbl_MKt_Listphieudetails
                          where pp.ShippingPoint + pp.ShipmentNumber == Loadnumberserri


                          select new
                          {
                              Created_date = pp.Ngaytaophieu,
                              pp.Region,
                              pp.Gate_pass,
                              Date_MKT_Phiếu = pp.Ngaytaophieu,
                              IO = pp.Purposeid,
                              pp.Purpose,
                              pp.Note,
                              pp.Status,
                              pp.ShippingPoint,
                              pp.ShipmentNumber,

                              pp.Requested_by,

                              pp.Customer_SAP_Code,
                              pp.Receiver_by,
                              pp.Tel,
                              pp.Address,

                              //   Số_lượng_thực_xuất = pp.Soluongdaxuat,
                              // Số_lượng_còn_lại = pp.Soluongconlai,
                              pp.Materiacode,
                              pp.MateriaSAPcode,
                              Material_name = pp.Materialname,
                              pp.Description,
                              pp.Unit,
                              Issued = pp.Issued,
                              Pallet = pp.pallet,
                              pp.Issued_dated,
                              Return_request = pp.Returnrequest,
                              pp.Price,
                              pp.Tranposterby,
                              pp.Truck,
                              pp.Loadingby,
                              pp.Delivery_date,

                              Completed_date = pp.Date_Received_Issued,
                              pp.Completed_by,
                              pp.ReturnQuantity,
                              pp.Returndate,
                              pp.Return_reason,
                              pp.Returnby,
                              Incinclude_Shipment = pp.Included_Shipment,
                              //  Quantity_Return_request = pp.Returnrequest





                              //    ID = p.id,
                          };

                Viewtable viewtbl = new Viewtable(rs5, dc, "DANH SÁCH PHIẾU MAKETTING TRONG LOAD: " + Loadnumberserri, 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.Show();
            }
        }

        private void revertStoreErrorIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT LOADSERI NUMBER ! ");
            //pxk.ShowDialog();

            //string Loadnumberserri = pxk.valuetext;
            //bool kq = pxk.kq;

            //if (true)
            //{


            //    string connection_string = Utils.getConnectionstr();
            //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //    var rs5 = from pp in dc.tbl_MKt_WHstoreissues
            //              where pp.Serriload == Loadnumberserri
            //              select pp;



            //    dc.tbl_MKt_WHstoreissues.DeleteAllOnSubmit(rs5);
            //    dc.SubmitChanges();

            //    MessageBox.Show("Revert Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}





        }

        private void revertWrongTransferInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTvalueinput pxk = new MKTvalueinput("Please nhập số transer in  ");
            pxk.ShowDialog();
            //c
            string transfernumber = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs = from pp in dc.tbl_MKt_Transferoutdetails
                         where pp.Tranfernumber == transfernumber
                         select pp;

                if (rs.Count() > 0)
                {
                    foreach (var item in rs)
                    {
                        item.Status = "CRT";
                        item.Reciepted_Quantity = 0;


                        dc.SubmitChanges();


                    }




                }

                MessageBox.Show("Revert Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

        }

        private void storeInportReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;


            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.storeimportsreports(dc, fromdate, todate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "By input date store import detail reports", 1000, "storeimportList");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void goodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Username.getloadTransferINright())
            //{
            //    View.MKTNoouthourise view = new MKTNoouthourise();
            //    view.ShowDialog();
            //    return;
            //}
            //phiếu xuất kho
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT MINUTE SERRI NUMBER ");
            pxk.ShowDialog();
            bool kq = pxk.kq;
            string serinumer = pxk.valuetext;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var checknhaproi = (from pp in dc.tbl_MKt_WHstoreissues
                                where pp.Document_number == serinumer
                                && pp.RecieptQuantity > 0
                                select pp).FirstOrDefault();

            if (checknhaproi != null)
            {


                MessageBox.Show("Biên bản này đã nhập hàng trả về rồi !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kq = false;
                return;
            }


            if (kq)
            {

                #region// nhập hagf
                //if (name == "tmphieuthu")
                //{
                // MKTNhaphangtheoPo
                //  Main.clearpannel();
                //   Formload.
                // clearpannel();
                this.clearpannel();


                View.MKTNhaphancollectfrommaket nhaphang = new MKTNhaphancollectfrommaket(this, serinumer);
                this.clearpannelload(nhaphang);


                // this.Close();
                #endregion


            }
        }

        private void storeRegionImportDetailReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;


            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.storeimportsreportsbyregion(dc, fromdate, todate, store);


                Viewtable viewtbl = new Viewtable(rs, dc, "By input date region store import detail reports ", 1000, "storeimportList");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void stockMovementDetailByRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {


            MKTFromdateandStoreandRegion choosesl = new MKTFromdateandStoreandRegion();

            choosesl.ShowDialog();

            string storelocation = choosesl.store;
            string region = choosesl.region;
            DateTime Fromdate = choosesl.fromdate;
            DateTime Todate = choosesl.todate;




            bool kq = choosesl.kq;
            if (kq)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);




                var rs5 = from gg in dc.tbl_MKT_StockendRegionBudgets
                          where gg.Region == region
                          && gg.Store_code == storelocation
                          && gg.Regionchangedate >= Fromdate
                          && gg.Regionchangedate <= Todate
                          //group pp by new
                          //{
                          //    pp.Region,
                          //    pp.ITEM_Code,

                          //} into gg
                          select new
                          {
                              Region = gg.Region,
                              Shipping_Point = storelocation,
                              Material_Item_Code = gg.ITEM_Code,
                              Material_SAP_Code = gg.SAP_CODE,
                              Material_Name = gg.MATERIAL,
                              Description = gg.Description,
                              UNIT = gg.UNIT,
                              Quantity_PO_Reciepted = gg.QuantityInputbyPO,
                              Issued = gg.QuantityOutput,//gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                              Return_Ticket = gg.QuantityInputbyReturn,// gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0),
                              Transfer_in = gg.QuantityInputbytransferin,
                              Adjusted_Device_Stock = gg.QuantitybyDevice,// gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0),





                              //  Balance = gg.Sum(m => m.QuantityInputbyPO).GetValueOrDefault(0) + gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0) + gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0) - gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                          };


                View.Viewtable tbl = new Viewtable(rs5, dc, "REGION STOCK MOVEMENT REPORTS FROM DATE: " + Fromdate.ToShortDateString() + " TO DATE: " + Todate.ToShortDateString(), 1000, "reginmovementstock");
                tbl.ShowDialog();



            }
        }

        private void goodReceiptColletedFromMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Username.getloadTransferINright())
            //{
            //    View.MKTNoouthourise view = new MKTNoouthourise();
            //    view.ShowDialog();
            //    return;
            //}
            //phiếu xuất kho
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT MINUTE SERRI NUMBER ");
            pxk.ShowDialog();
            bool kq = pxk.kq;
            string serinumer = pxk.valuetext;

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //    newregionupdate.DocumentNumber = this.serinumer;

            var checknhaproi = (from pp in dc.tbl_MKT_StockendRegionBudgets
                                where pp.DocumentNumber == serinumer
                                //    && pp.RecieptQuantity > 0
                                select pp).FirstOrDefault();

            if (checknhaproi != null)
            {


                MessageBox.Show("Biên bản này đã nhập hàng trả về rồi !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kq = false;
                return;
            }

            //        string connection_string = Utils.getConnectionstr();
            //      LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs5 = (from pp in dc.tbl_MKt_Listphieuheads
                       where pp.Region + pp.ShippingPoint + pp.Gate_pass == serinumer
                       // && pp.completed == true


                       select pp).FirstOrDefault();
            if (rs5 == null)
            {
                MessageBox.Show("Wrong minute !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //      dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                kq = false;
                return;

            }


            if (kq)
            {

                #region// nhập hagf
                //if (name == "tmphieuthu")
                //{
                // MKTNhaphangtheoPo
                //  Main.clearpannel();
                //   Formload.
                // clearpannel();
                this.clearpannel();


                View.MKTNhaphancollectfrommaket nhaphang = new MKTNhaphancollectfrommaket(this, serinumer);
                this.clearpannelload(nhaphang);


                // this.Close();
                #endregion


            }
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void byInputDateStockMovementDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodatestore datepick = new MKTFromdatetodatestore();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            string store = datepick.Store;

            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentdetailbyinputdate(dc, fromdate, todate, store);

                //    IQueryable rs = Model.MKT.DanhsacHSTOCKMOVEmentdetail(dc, fromdate, todate, store);


                //Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL ", 1000, "tkdetailnhapxuattheosanpham");// mã 5 là danh sach nha nha ccaaps

                //viewtbl.ShowDialog();
                Viewtable viewtbl = new Viewtable(rs, dc, "STOCK MOVEMENT DETAIL ", 1000, "tkdetailnhapxuattheosanpham");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

        }

        private void byInputDateStockMovementDetailByRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MKTFromdateandStoreandRegion choosesl = new MKTFromdateandStoreandRegion();

            choosesl.ShowDialog();

            string storelocation = choosesl.store;
            string region = choosesl.region;
            DateTime Fromdate = choosesl.fromdate;
            DateTime Todate = choosesl.todate;




            bool kq = choosesl.kq;
            if (kq)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);




                var rs5 = from gg in dc.tbl_MKT_StockendRegionBudgets
                          where gg.Region == region
                          && gg.Store_code == storelocation
                          && gg.Createdate >= Fromdate
                          && gg.Createdate <= Todate
                          //group pp by new
                          //{
                          //    pp.Region,
                          //    pp.ITEM_Code,

                          //} into gg
                          select new
                          {
                              Region = gg.Region,
                              gg.DocumentNumber,
                              input_date = gg.Regionchangedate,
                              gg.DnNumber,
                              //     LoadNumber = gg.,
                              Store_code = storelocation,
                              gg.Gate_pass,


                              MateriaItemcode = gg.ITEM_Code,
                              Material_SAP_Code = gg.SAP_CODE,
                              Material_Name = gg.MATERIAL,
                              Description = gg.Description,
                              UNIT = gg.UNIT,
                              Quantity_PO_Reciepted = gg.QuantityInputbyPO,
                              Issued = gg.QuantityOutput,//gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                              Return_Ticket = gg.QuantityInputbyReturn,// gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0),
                              Transfer_in = gg.QuantityInputbytransferin,
                              Adjusted_Device_Stock = gg.QuantitybyDevice,// gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0),

                              //             Shippingpoint = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                              //Itemcode = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["MateriaItemcode"].Value;
                              //shipment = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["LoadNumber"].Value;




                              //  Balance = gg.Sum(m => m.QuantityInputbyPO).GetValueOrDefault(0) + gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0) + gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0) - gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                          };


                View.Viewtable tbl = new Viewtable(rs5, dc, "REGION STOCK MOVEMENT BY INPUT DATE REPORTS FROM DATE: " + Fromdate.ToShortDateString() + " TO DATE: " + Todate.ToShortDateString(), 1000, "tk");
                tbl.ShowDialog();
            }

        }

        private void revertTransferInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTvalueinput pxk = new MKTvalueinput("Please nhập số transer out need revert!  ");
            pxk.ShowDialog();
            //c
            string transfernumber = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs = from pp in dc.tbl_MKt_WHstoreissues
                         where pp.Transfer_number == transfernumber
                         select pp;

                if (rs.Count() > 0)
                {

                    View.Viewtable tbl = new Viewtable(rs, dc, "Double click on transer in need to revert", 100, "reverttransferin");
                    tbl.ShowDialog();
                    //foreach (var item in rs)
                    //{
                    //  //  item.Status = "CRT";
                    //   // item.Reciepted_Quantity = 0;


                    //    //dc.SubmitChanges();


                    //}

                }
                else
                {
                    MessageBox.Show("Wrong PO number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void revertGoodReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTvalueinput pxk = new MKTvalueinput("Please nhập số PO  ");
            pxk.ShowDialog();
            //c
            string ponumber = pxk.valuetext;
            bool kq = pxk.kq;

            if (kq)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


                var rs = from pp in dc.tbl_MKt_WHstoreissues
                             // from gg in dc.tbl_MKt_POheads
                         where pp.POnumber == ponumber
                         // && pp.date_input_output >= fromdate
                         // && pp.date_input_output <= todate
                         //     && pp.ShippingPoint == storecode
                         select new
                         {
                             // gg.
                             pp.ShippingPoint,
                             pp.POnumber,
                             Ngày_nhập_kho = pp.date_input_output,
                             DN_Number = pp.DNNumber,
                             pp.Materiacode,
                             pp.MateriaItemcode,
                             pp.Materialname,
                             pp.Unit,
                             pp.RecieptQuantity,
                             pp.Recieptby,


                             pp.Username,

                             pp.id,
                             Subid = pp.IssueIDsub,


                         };


                if (rs.Count() > 0)
                {

                    View.Viewtable tbl = new Viewtable(rs, dc, "Double click on good receipt to revert", 100, "revertPogoodreceipt");
                    tbl.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Wrong PO number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void statusShippingButHaveDeliveringToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_WHstoreissues
                     from gg in dc.tbl_MKt_Listphieudetails
                     where pp.ShippingPoint + pp.LoadNumber == gg.ShippingPoint + gg.ShipmentNumber
                     && (gg.Status == "CRT" || gg.Status == "Shipping")
                     select pp;

            if (rs.Count() > 0)
            {

                View.Viewtable tbl = new Viewtable(rs, dc, "List các bộ đã cộng số xuất nhưng chua chuyển trạng thái ", 1000, "kiemtrashipmentxuat");
                tbl.ShowDialog();


            }
            else
            {
                MessageBox.Show("There have no shipment wrong of issue !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void trackingWrongDocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void revertStoreIssueNotWithThatEffectEndstockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT LOADSERI NUMBER ! ");
            pxk.ShowDialog();

            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = from pp in dc.tbl_MKt_WHstoreissues
                          where pp.Serriload == Loadnumberserri
                          select pp;
                foreach (var item in rs5)
                {

                    Model.MKT.tangkhokhinhaphang(item, item.ShippingPoint);

                }


                dc.tbl_MKt_WHstoreissues.DeleteAllOnSubmit(rs5);
                dc.SubmitChanges();


                var rs6 = from pp in dc.tbl_MKT_StockendRegionBudgets
                          where pp.DocumentNumber == Loadnumberserri
                          select pp;

                dc.tbl_MKT_StockendRegionBudgets.DeleteAllOnSubmit(rs6);
                dc.SubmitChanges();


                MessageBox.Show("Revert Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void revertReturnCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //phiếu xuất kho
            MKTvalueinput pxk = new MKTvalueinput("Please input Minute serrinumber : ");
            pxk.ShowDialog();
            //c
            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = from pp in dc.tbl_MKT_StockendRegionBudgets
                          where pp.DocumentNumber == Loadnumberserri
                          select pp;

                if (rs5.Count() > 0)
                {
                    dc.tbl_MKT_StockendRegionBudgets.DeleteAllOnSubmit(rs5);
                    dc.SubmitChanges();


                }
                else
                {
                    MessageBox.Show("Wrong Minute serrinumber !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }


                MessageBox.Show("Revert Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }
        }

        private void revertWrongUpdateDeliveredOfTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //phiueeys gatpaste
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT GATEPASS SERRI");
            pxk.ShowDialog();
            //c
            string Gatepassseru = pxk.valuetext;
            bool kq = pxk.kq;
            bool check = false;
            if (true)
            {


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
                #region save




                var rs = from pp in dc.tbl_MKt_Listphieuheads
                         where pp.Region + pp.ShippingPoint + pp.Gate_pass == Gatepassseru
                         select pp;
                if (rs.Count() > 0)
                {
                    foreach (var item in rs)
                    {
                        if (item.Status == "completed")
                        {
                            item.Status = "Delivering";
                            item.completed = false;
                            item.Date_Received_Issued = DateTime.Today;
                            //    item.completedby = txtupdateby.Text;
                            item.completedby = Utils.getusername();


                            dc.SubmitChanges();


                            check = true;




                        }



                    }
                }
                else
                {

                    MessageBox.Show("Wrong ticket serri number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }




                if (check == true)
                {

                    #region detai


                    var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                              where pp.Region + pp.ShippingPoint + pp.Gate_pass == Gatepassseru
                              select pp;
                    if (rs.Count() > 0)
                    {
                        foreach (var item in rs2)
                        {

                            item.Status = "Delivering";
                            item.Date_Received_Issued = DateTime.Today;
                            //    item.completedby = txtupdateby.Text;
                            item.Completed_by = Utils.getusername();


                            dc.SubmitChanges();

                        }
                    }

                    #endregion


                }




                #endregion


                MessageBox.Show("Revert Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);






            }
        }

        private void reprintGatePassOfShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usernamme = Utils.getusername();
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT LOADSERI NUMBER");
            pxk.ShowDialog();

            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (kq)
            {
                #region in phiếu MKT
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rptMKT = from pp in dc.tbl_MKT_headRpt_Phieuissues
                             where pp.Username == usernamme
                             select pp;

                dc.tbl_MKT_headRpt_Phieuissues.DeleteAllOnSubmit(rptMKT);
                dc.SubmitChanges();


                var rptMKTdetail = from pp in dc.tbl_MKT_DetailRpt_Phieuissues
                                   where pp.Username == usernamme
                                   select pp;

                dc.tbl_MKT_DetailRpt_Phieuissues.DeleteAllOnSubmit(rptMKTdetail);
                dc.SubmitChanges();

                var rptMKThead = from pp in dc.tbl_MKt_Listphieuheads

                                 where pp.ShippingPoint + pp.LoadNumber == Loadnumberserri
                                 //   && pp.requestReturn == false
                                 select pp;

                if (rptMKThead.Count() > 0)
                {

                    foreach (var item in rptMKThead)
                    {


                        tbl_MKT_headRpt_Phieuissue headpx = new tbl_MKT_headRpt_Phieuissue();

                        headpx.Diachi = item.ShiptoAddress;
                        headpx.Nguoinhancode = item.ShiptoCode.ToString();
                        headpx.Username = usernamme;
                        headpx.Sophieu = item.Gate_pass;
                        headpx.Nguoinhanname = item.ShiptoName;
                        headpx.seri = item.Region + item.ShippingPoint + item.Gate_pass;

                        BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                        BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                        //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                        Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(item.Region + item.ShippingPoint + item.Gate_pass), 1, true), typeof(Byte[]));

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
                                     where // pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation
                                           pp.ShippingPoint + pp.ShipmentNumber == Loadnumberserri
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

                    detailpx.Username = usernamme;
                    detailpx.tensanpham = item.Materialname;

                    detailpx.Sophieu = item.Gate_pass;
                    lastgatepass = item.Gate_pass;


                    if (item.Returnrequest > 0)
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
                             where pp.Username == usernamme
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
                               where pp.Username == usernamme
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
                              where pp.Username == usernamme
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
                                    where pp.Username == usernamme
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




            }






        }

        private void ticketUndeliveryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();
            string region = Model.Username.getuseRegion();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {

                IQueryable rs = Model.MKT.DanhsachPhieuunloadingheadbystore(dc, storelocation);


                Viewtable viewtbl = new Viewtable(rs, dc, "Gate pass Unloading list", 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void ticketUndeliveryReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();
            string region = Model.Username.getuseRegion();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {

                IQueryable rs = Model.MKT.DanhsachPhieuundeliveryheadbystore(dc, storelocation);


                Viewtable viewtbl = new Viewtable(rs, dc, "Gate pass Undelivery list", 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void maketingTicketUnissueStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();
            string region = Model.Username.getuseRegion();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {

                IQueryable rs = Model.MKT.DanhsachPhieuunisuebystore(dc, storelocation);


                Viewtable viewtbl = new Viewtable(rs, dc, "Gate pass Un issue list", 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void maketingTicketBlockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();
            string region = Model.Username.getuseRegion();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {

                IQueryable rs = Model.MKT.DanhsachPhieudetailblockbystore(dc, storelocation);


                Viewtable viewtbl = new Viewtable(rs, dc, "Gate pass block list", 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }
        }

        private void statusGatepassReportsByLoadingDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTFromdatetodate datepick = new MKTFromdatetodate();
            datepick.ShowDialog();

            DateTime fromdate = datepick.fromdate;
            DateTime todate = datepick.todate;
            bool kq = datepick.chon;

            if (kq) // nueeus có chọn
            {
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                IQueryable rs = Model.MKT.DanhsachPhieuMKTandstatustheongaygheoload(dc, fromdate, todate);


                Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU MAKETTING THEO NGÀY GHÉP LOAD ", 100, "tk");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }




        }

        private void correctShipmentHaveCreatedToIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MKTvalueinput pxk = new MKTvalueinput("PLEASE INPUT LOADSERI NUMBER");
            pxk.ShowDialog();

            string Loadnumberserri = pxk.valuetext;
            bool kq = pxk.kq;

            if (kq)
            {

                bool kq2 = true;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs5 = (from pp in dc.tbl_MKt_ListLoadheadDetails
                           where pp.Serriload == Loadnumberserri

                           select pp).FirstOrDefault();
                if (rs5 == null)

                {

                    #region  update tbl_MKt_ListLoadheadDetail
                    //     btluu.Enabled = false;

                    var rs4 = from pp in dc.tbl_MKt_Listphieudetails
                              where pp.ShippingPoint  + pp.ShipmentNumber == Loadnumberserri
                             
                              group pp by pp.Materiacode into gg

                              select new
                              {
                                  Issued = gg.Sum(m => m.Issued),
                                  Materiacode = gg.Key,//       gg.FirstOrDefault().Materiacode,
                                  Materialname = gg.Select(m => m.Materialname).FirstOrDefault(),
                                  soload = gg.Select(m => m.ShipmentNumber).FirstOrDefault(),

                                  storelocation = gg.Select(m => m.ShippingPoint).FirstOrDefault(),
                              };
                    //   int i = 0;
                    foreach (var item in rs4)
                    {
                        //   i = i + 1;

                        tbl_MKt_ListLoadheadDetail loaddetail = new tbl_MKt_ListLoadheadDetail();

                        //   loaddetail.stt = i.ToString();
                        loaddetail.LoadNumber = item.soload;
                        loaddetail.Username = Utils.getusername();
                        loaddetail.Materiacode = item.Materiacode.Truncate(50);
                        loaddetail.Materialname = item.Materialname.Truncate(225);
                        // loaddetail.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));
                        loaddetail.Serriload = Loadnumberserri;
                        loaddetail.ShippingPoint = item.storelocation;
                        loaddetail.Issued = item.Issued;
                        loaddetail.Status = "CRT";



                        dc.tbl_MKt_ListLoadheadDetails.InsertOnSubmit(loaddetail);
                        dc.SubmitChanges();

                    }




                    #endregion

                    MessageBox.Show("Done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show("Wrong load or have no error !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void correctOrderedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listExportForIssueEinvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<View.MKTselectinput.ComboboxItem> CombomCollection = new List<View.MKTselectinput.ComboboxItem>();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            string username = Utils.getusername();
            string rightkho = Model.Username.getmaquyenkho();
            string region = Model.Username.getuseRegion();

            //    List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();


            ///

            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //   where (from gg in dc.tbl_MKT_StoreRights
                          //        where gg.storeright == rightkho
                          //      select gg.makho).Contains(pp.makho)
                      select pp;

            foreach (var item2 in rs1)


            {
                View.MKTselectinput.ComboboxItem cb = new View.MKTselectinput.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection.Add(cb);
            }


            MKTselectinput choosesl = new MKTselectinput("PLEASE SELECT A STORE ", CombomCollection);
            choosesl.ShowDialog();

            string storelocation = choosesl.value;
            bool kq = choosesl.kq;
            if (kq)
            {

          
              
                IQueryable rs = Model.MKT.Danhsachphieuchuaxuathoadon(dc, storelocation);


                Viewtable viewtbl = new Viewtable(rs, dc, "DANH SÁCH PHIẾU MKT CHƯA XUẤT HÓA ĐƠN ", 1000, "Danhsachchuaxuathoadon");// mã 5 là danh sach nha nha ccaaps

                viewtbl.ShowDialog();


            }

            //
          

        }
    }


}


