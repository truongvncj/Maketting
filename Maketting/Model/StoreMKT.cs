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
    class StoreMKT
    {




        class datainportF
        {

            public string filename { get; set; }
            public string storelocation { get; set; }

        }



        public void InputBeginstore(object obj)
        {




            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            datainportF inf = (datainportF)obj;

            string filename = inf.filename;
            string storelocation = inf.storelocation;


            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            dc.ExecuteCommand("DELETE FROM tbl_MKT_Stockend   where  tbl_MKT_Stockend.Store_code = '" + storelocation + "'");
            //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
            dc.CommandTimeout = 0;
            dc.SubmitChanges();




            ExcelProvider ExcelProvide = new ExcelProvider();
            //#endregion
            System.Data.DataTable sourceData = ExcelProvide.GetDataFromExcel(filename);

            System.Data.DataTable batable = new System.Data.DataTable();
            //   batable.Columns.Add("Delivery_No", typeof(double));
            batable.Columns.Add("SAPCODE", typeof(string));
            batable.Columns.Add("ITEMCode", typeof(string));
            batable.Columns.Add("MATERIAL", typeof(string));
            batable.Columns.Add("Description", typeof(string));
            batable.Columns.Add("UNIT", typeof(string));
            batable.Columns.Add("ENDSTOCK", typeof(double));


            batable.Columns.Add("Store_code", typeof(string));


            int SAPCODEid = 0;
            int ITEMCodeid = 0;
            int MATERIALid = 0;
            int Descriptionid = 0;
            int UNITid = 0;
            int ENDSTOCKid = 0;

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

                        if (value.Trim().Contains("ITEMCode"))
                        {

                            ITEMCodeid = columid;
                            rowheadindex = rowid;
                            //    headindex = 0;

                        }


                        if (value.Trim().Contains("SAPCODE"))
                        {

                            SAPCODEid = columid;
                            //   headindex = 0;



                        }


                        if (value.Trim().Contains("MATERIAL"))
                        {
                            MATERIALid = columid;

                        }

                        if (value.Trim().Contains("Description"))
                        {
                            Descriptionid = columid;

                        }

                        if (value.Trim().Contains("UNIT"))
                        {
                            UNITid = columid;

                        }

                        if (value.Trim().Contains("ENDSTOCK"))
                        {
                            ENDSTOCKid = columid;
                            // headindex = 0;
                        }



                        #endregion

                    }


                }// colum

            }// roww off heatder


            for (int rowixd = 0; rowixd < sourceData.Rows.Count; rowixd++)
            {

                #region setvalue of pricelist
                //   string valuepricelist = Utils.GetValueOfCellInExcel(worksheet, rowid, columpricelist);
                string Itemcode = sourceData.Rows[rowixd][ITEMCodeid].ToString();
                if (Itemcode != "" && rowheadindex != rowixd)
                {



                    DataRow dr = batable.NewRow();

                    dr["SAPCODE"] = sourceData.Rows[rowixd][SAPCODEid].ToString().Trim();

                    if (Utils.IsValidnumber(sourceData.Rows[rowixd][ENDSTOCKid].ToString()))
                    {
                        dr["ENDSTOCK"] = double.Parse(sourceData.Rows[rowixd][ENDSTOCKid].ToString());
                    }
                    else
                    {
                        dr["ENDSTOCK"] = 0;
                    }

                    dr["ITEMCode"] = sourceData.Rows[rowixd][ITEMCodeid].ToString().Trim();
                    dr["MATERIAL"] = sourceData.Rows[rowixd][MATERIALid].ToString().Trim();
                    dr["Description"] = sourceData.Rows[rowixd][Descriptionid].ToString().Trim();
                    dr["UNIT"] = sourceData.Rows[rowixd][UNITid].ToString().Trim();

                    dr["Store_code"] = storelocation;

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
                //batable.Columns.Add("ENDSTOCK", typeof(double));


                //batable.Columns.Add("Store_code", typeof(string));

                bulkCopy.DestinationTableName = "tbl_MKT_Stockend";
                // Write from the source to the destination.
                bulkCopy.BulkCopyTimeout = 0;

                //       bulkCopy.ColumnMappings.Add("Delivery_No", "Delivery_No");
                bulkCopy.ColumnMappings.Add("SAPCODE", "[SAP_CODE]");

                bulkCopy.ColumnMappings.Add("ITEMCode", "[ITEM_Code]");
                bulkCopy.ColumnMappings.Add("MATERIAL", "[MATERIAL]");
                bulkCopy.ColumnMappings.Add("Description", "[Description]");
                bulkCopy.ColumnMappings.Add("ENDSTOCK", "[END_STOCK]");
                bulkCopy.ColumnMappings.Add("UNIT", "[UNIT]");
                bulkCopy.ColumnMappings.Add("Store_code", "[Store_code]");


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
        public void Addnewproduct(object obj)
        {




            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            datainportF inf = (datainportF)obj;

            string filename = inf.filename;
            string storelocation = inf.storelocation;


            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            string Username = Utils.getusername();

            dc.ExecuteCommand("DELETE FROM tbl_MKT_StockendTMP   where  tbl_MKT_StockendTMP.Username = '" + Username + "'");

            dc.CommandTimeout = 0;
            dc.SubmitChanges();




            ExcelProvider ExcelProvide = new ExcelProvider();
            //#endregion
            System.Data.DataTable sourceData = ExcelProvide.GetDataFromExcel(filename);

            System.Data.DataTable batable = new System.Data.DataTable();
            //   batable.Columns.Add("Delivery_No", typeof(double));
            batable.Columns.Add("SAPCODE", typeof(string));
            batable.Columns.Add("ITEMCode", typeof(string));
            batable.Columns.Add("MATERIAL", typeof(string));
            batable.Columns.Add("Description", typeof(string));
            batable.Columns.Add("UNIT", typeof(string));
            batable.Columns.Add("ENDSTOCK", typeof(double));

            batable.Columns.Add("Username", typeof(string));


            batable.Columns.Add("Store_code", typeof(string));


            int SAPCODEid = 0;
            int ITEMCodeid = 0;
            int MATERIALid = 0;
            int Descriptionid = 0;
            int UNITid = 0;
            int ENDSTOCKid = 0;

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

                        if (value.Trim().Contains("ITEMCode"))
                        {

                            ITEMCodeid = columid;
                            rowheadindex = rowid;
                            //    headindex = 0;

                        }


                        if (value.Trim().Contains("SAPCODE"))
                        {

                            SAPCODEid = columid;
                            //   headindex = 0;



                        }


                        if (value.Trim().Contains("MATERIAL"))
                        {
                            MATERIALid = columid;

                        }

                        if (value.Trim().Contains("Description"))
                        {
                            Descriptionid = columid;

                        }

                        if (value.Trim().Contains("UNIT"))
                        {
                            UNITid = columid;

                        }

                        if (value.Trim().Contains("ENDSTOCK"))
                        {
                            ENDSTOCKid = columid;
                            // headindex = 0;
                        }



                        #endregion

                    }


                }// colum

            }// roww off heatder


            for (int rowixd = 0; rowixd < sourceData.Rows.Count; rowixd++)
            {

                #region setvalue of pricelist
                //   string valuepricelist = Utils.GetValueOfCellInExcel(worksheet, rowid, columpricelist);
                string Itemcode = sourceData.Rows[rowixd][ITEMCodeid].ToString();
                if (Itemcode != "" && rowheadindex != rowixd)
                {



                    DataRow dr = batable.NewRow();

                    dr["SAPCODE"] = sourceData.Rows[rowixd][SAPCODEid].ToString().Trim();

                    if (Utils.IsValidnumber(sourceData.Rows[rowixd][ENDSTOCKid].ToString()))
                    {
                        dr["ENDSTOCK"] = double.Parse(sourceData.Rows[rowixd][ENDSTOCKid].ToString());
                    }
                    else
                    {
                        dr["ENDSTOCK"] = 0;
                    }

                    dr["ITEMCode"] = sourceData.Rows[rowixd][ITEMCodeid].ToString().Trim();
                    dr["MATERIAL"] = sourceData.Rows[rowixd][MATERIALid].ToString().Trim();
                    dr["Description"] = sourceData.Rows[rowixd][Descriptionid].ToString().Trim();
                    dr["UNIT"] = sourceData.Rows[rowixd][UNITid].ToString().Trim();

                    dr["Store_code"] = storelocation;
                    dr["Username"] = Username;

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
                //batable.Columns.Add("ENDSTOCK", typeof(double));


                //batable.Columns.Add("Store_code", typeof(string));

                bulkCopy.DestinationTableName = "tbl_MKT_StockendTMP";
                // Write from the source to the destination.
                bulkCopy.BulkCopyTimeout = 0;

                //       bulkCopy.ColumnMappings.Add("Delivery_No", "Delivery_No");
                bulkCopy.ColumnMappings.Add("SAPCODE", "[SAP_CODE]");

                bulkCopy.ColumnMappings.Add("ITEMCode", "[ITEM_Code]");
                bulkCopy.ColumnMappings.Add("MATERIAL", "[MATERIAL]");
                bulkCopy.ColumnMappings.Add("Description", "[Description]");
                bulkCopy.ColumnMappings.Add("ENDSTOCK", "[END_STOCK]");
                bulkCopy.ColumnMappings.Add("UNIT", "[UNIT]");
                bulkCopy.ColumnMappings.Add("Store_code", "[Store_code]");
                bulkCopy.ColumnMappings.Add("Username", "Username");

                
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


        public void InputBeginstorefuction(string shipingpoint)
        {


            //   CultureInfo provider = CultureInfo.InvariantCulture;


            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File Store End excel";
            theDialog.Filter = "Excel files|*.xlsx; *.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                //  AutoResetEvent autoEvent = new AutoResetEvent(false); //join



                string filename = theDialog.FileName.ToString();
                string storelocation = shipingpoint;

                Thread t1 = new Thread(InputBeginstore);
                t1.IsBackground = true;
                t1.Start(new datainportF() { filename = filename, storelocation = storelocation });


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

        public void ADDnewproductlist(string shipingpoint)
        {


            //   CultureInfo provider = CultureInfo.InvariantCulture;


            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File Product excel";
            theDialog.Filter = "Excel files|*.xlsx; *.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                //  AutoResetEvent autoEvent = new AutoResetEvent(false); //join



                string filename = theDialog.FileName.ToString();
                string storelocation = shipingpoint;

                Thread t1 = new Thread(Addnewproduct);
                t1.IsBackground = true;
                t1.Start(new datainportF() { filename = filename, storelocation = storelocation });


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
