using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maketting.shared;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Data.OleDb;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Maketting.Model
{
    class Aprovalpayment
    {



        public static int getNewPaymentid()
        {
            string connection_string = Utils.getConnectionstr();
            string urs = Utils.getusername();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            tbl_MKT_Payment_Aproval_head newtmp = new tbl_MKT_Payment_Aproval_head();
            //------------

            var tmpdelete = from p in dc.tbl_MKT_Payment_Aproval_heads
                           where p.IO_number == "TMP" && p.username == urs
                           select p;

            dc.tbl_MKT_Payment_Aproval_heads.DeleteAllOnSubmit(tmpdelete);
            dc.SubmitChanges();



            //----------
            newtmp.username = urs;
            newtmp.IO_number = "TMP";

            dc.tbl_MKT_Payment_Aproval_heads.InsertOnSubmit(newtmp);

            dc.SubmitChanges();


            var phieuid = (from p in dc.tbl_MKT_Payment_Aproval_heads
                           where p.IO_number == "TMP" && p.username == urs
                           select p.id).FirstOrDefault();


            return phieuid;







            //  throw new NotImplementedException();
        }


        class datainportF
        {

            public string filename { get; set; }
            public string username { get; set; }

        }



        public void Inputapprovalpaymentcode(object obj)
        {




            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            datainportF inf = (datainportF)obj;

            string filename = inf.filename;
           string username = inf.username;


            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            dc.ExecuteCommand("DELETE FROM tbl_MKT_Payment_AprovalTMP   where  tbl_MKT_Payment_AprovalTMP.username = '" + username + "'");
            //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
            dc.CommandTimeout = 0;
            dc.SubmitChanges();




            ExcelProvider ExcelProvide = new ExcelProvider();
            //#endregion
            System.Data.DataTable sourceData = ExcelProvide.GetDataFromExcel(filename);

            System.Data.DataTable batable = new System.Data.DataTable();
           
            batable.Columns.Add("Customercode", typeof(string));
            batable.Columns.Add("CustomerName", typeof(string));
            batable.Columns.Add("CustomerAddress", typeof(string));
            batable.Columns.Add("AprovalBudget", typeof(float));


            batable.Columns.Add("username", typeof(string));


            int Customercodeid = 0;
            int CustomerNameid = 0;
            int CustomerAddressid = 0;
            int AprovalBudgetid = 0;
      

            int rowheadindex = -2;

            for (int rowid = 0; rowid < 3; rowid++)
            {
                // headindex = 1;
                for (int columid = 0; columid < sourceData.Columns.Count; columid++)
                {

                    string value = sourceData.Rows[rowid][columid].ToString();
                    //            MessageBox.Show(value +":"+ rowid);

                    if (value != null)
                    {

                        #region setcolum

                        if (value.Trim().Contains("Customercode"))
                        {

                            Customercodeid = columid;
                            rowheadindex = rowid;
                            //    headindex = 0;

                        }


                        if (value.Trim().Contains("CustomerName"))
                        {

                            CustomerNameid = columid;
                            //   headindex = 0;



                        }


                        if (value.Trim().Contains("CustomerAddress"))
                        {
                            CustomerAddressid = columid;

                        }

                        if (value.Trim().Contains("AprovalBudget"))
                        {
                            AprovalBudgetid = columid;

                        }

                    


                        #endregion

                    }


                }// colum

            }// roww off heatder


            for (int rowixd = 0; rowixd < sourceData.Rows.Count; rowixd++)
            {

                #region setvalue of pricelist
                //   string valuepricelist = Utils.GetValueOfCellInExcel(worksheet, rowid, columpricelist);
                string Customercode = sourceData.Rows[rowixd][Customercodeid].ToString();
                if (Customercode != "" && rowheadindex != rowixd)
                {



                    DataRow dr = batable.NewRow();

                    dr["Customercode"] = sourceData.Rows[rowixd][Customercodeid].ToString().Trim();

                    if (Utils.IsValidnumber(sourceData.Rows[rowixd][AprovalBudgetid].ToString()))
                    {
                        dr["AprovalBudget"] = double.Parse(sourceData.Rows[rowixd][AprovalBudgetid].ToString());
                    }
                    else
                    {
                        dr["AprovalBudget"] = 0;
                    }

                    dr["CustomerName"] = sourceData.Rows[rowixd][CustomerNameid].ToString().Trim();
                    dr["CustomerAddress"] = sourceData.Rows[rowixd][CustomerAddressid].ToString().Trim();

                    //dr["Description"] = sourceData.Rows[rowixd][Descriptionid].ToString().Trim();
                    //dr["UNIT"] = sourceData.Rows[rowixd][UNITid].ToString().Trim();

                    dr["username"] = username;

                    batable.Rows.Add(dr);


                }

                #endregion

            }// row

            //conpy to server
            string destConnString = Utils.getConnectionstr();

            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destConnString))
            {
                //batable.Columns.Add("SAPCODE", typeof(string));
                //batable.Columns.Add("ITEMCode", typeof(string));
                //batable.Columns.Add("MATERIAL", typeof(string));
                //batable.Columns.Add("Description", typeof(string));
                //batable.Columns.Add("UNIT", typeof(string));
                //batable.Columns.Add("ENDSTOCK", typeof(float));


                //batable.Columns.Add("Store_code", typeof(string));

                bulkCopy.DestinationTableName = "tbl_MKT_Payment_AprovalTMP";
                // Write from the source to the destination.
                bulkCopy.BulkCopyTimeout = 0;

            
                bulkCopy.ColumnMappings.Add("Customercode", "[Customercode]");
                bulkCopy.ColumnMappings.Add("AprovalBudget", "[AprovalBudget]");
                bulkCopy.ColumnMappings.Add("CustomerName", "[CustomerName]");
                bulkCopy.ColumnMappings.Add("CustomerAddress", "[CustomerAddress]");
                bulkCopy.ColumnMappings.Add("username", "[username]");
              

                try
                {
                    bulkCopy.WriteToServer(batable);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Thông báo lỗi Bulk Copy !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.CurrentThread.Abort();
                }


            }



        }


 

        class datashowwait
        {

            public View.MKTCaculating wat { get; set; }


        }



        private void showwait(object obj)
        {
            // View.Caculating wat = new View.Caculating();

            //            View.Caculating wat = (View.Caculating)obj;
            datashowwait obshow = (datashowwait)obj;

            View.MKTCaculating wat = obshow.wat;

            wat.ShowDialog();


        }


        public  void Inputapprovalpayment()
        {


            //   CultureInfo provider = CultureInfo.InvariantCulture;


            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File aproval payment excel";
            theDialog.Filter = "Excel files|*.xlsx; *.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                //  AutoResetEvent autoEvent = new AutoResetEvent(false); //join



                string filename = theDialog.FileName.ToString();
                string username = Utils.getusername();

                Thread t1 = new Thread(Inputapprovalpaymentcode);
                t1.IsBackground = true;
                t1.Start(new datainportF() { filename = filename, username = username });


                View.MKTCaculating wat = new View.MKTCaculating();
                Thread t2 = new Thread(showwait);
                t2.Start(new datashowwait() { wat = wat });


                t1.Join();
                if (t1.ThreadState != ThreadState.Running)
                {

                    // t2.Abort();

                    wat.Invoke(wat.myDelegate);



                }



            }





        }

  






    }
}
