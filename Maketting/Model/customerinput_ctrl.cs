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
    class customerinput_ctrl
    {


        //public IQueryable customersetlect_all(LinqtoSQLDataContext db)
        //{

        //    //  var db = new LinqtoSQLDataContext(connection_string);
        //    var rs = from tbl_PosCustomer in db.tbl_PosCustomers
        //             orderby tbl_PosCustomer.Customer
        //             select tbl_PosCustomer;

        //    return rs;

        //}

        public bool customerdeleted()
        {
            #region // xóa data bảng tblCustomer
            string connection_string = Utils.getConnectionstr();
            var db = new LinqtoSQLDataContext(connection_string);

            db.ExecuteCommand("DELETE FROM tbl_PosCustomer");
            //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
            db.SubmitChanges();



            return true;
            #endregion

        }


        class datainportF
        {

            public string filename { get; set; }

        }


        public void importCustomersoldtolist(object obj)
        {




            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            datainportF inf = (datainportF)obj;

            string filename = inf.filename;

            //   string filename = theDialog.FileName.ToString();

            //   string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            dc.ExecuteCommand("DELETE FROM tbl_MKT_Soldtocode");
            //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
            dc.CommandTimeout = 0;
            dc.SubmitChanges();

            //    Customer Sales Organization Name 1  House num &Street  Street 4    City Telephone 1 Sales Office    Delivering Plant    Terms of Payment Price List Key Account No  Sales district  Created on  Created by  VAT Registration No.Central order block Order block for sales area


            //                   


            ExcelProvider ExcelProvide = new ExcelProvider();
            //#endregion
            System.Data.DataTable sourceData = ExcelProvide.GetDataFromExcel(filename);

            System.Data.DataTable batable = new System.Data.DataTable();


            batable.Columns.Add("Customer", typeof(string));
            batable.Columns.Add("FullNameN", typeof(string));
            batable.Columns.Add("Telephone1", typeof(string));
            //batable.Columns.Add("Note", typeof(string));

            batable.Columns.Add("District", typeof(string));
            batable.Columns.Add("SalesOrg", typeof(string));
            batable.Columns.Add("Street", typeof(string));

            batable.Columns.Add("City", typeof(string));
            batable.Columns.Add("Region", typeof(string));
            batable.Columns.Add("PaymentTerms", typeof(string));

            batable.Columns.Add("PriceList", typeof(string));
            batable.Columns.Add("KeyAcc", typeof(double));
            batable.Columns.Add("SalesDistrict", typeof(string));
            batable.Columns.Add("Createdon", typeof(DateTime));
            batable.Columns.Add("Createby", typeof(string));
            batable.Columns.Add("VATregistrationNo", typeof(string));
         




            int Customerid = 0;
            int FullNameNid = 0;
            int Telephone1id = 0;
         
            int Districtid = 0;
            int SalesOrgid = 0;
            int Streetid = 0;
            int Cityid = 0;

            int Regionid = 0;

            int PaymentTermsid = 0;

            int PriceListid = 0;

            int KeyAccid = 0;
            int SalesDistrictid = 0;
            int VATregistrationNoid = 0;
        

       //     View.Viewdatatable vi1 = new View.Viewdatatable(sourceData, "Test");

       //     vi1.ShowDialog();
            int headindex =-2;

            for (int rowid = 0; rowid < 3; rowid++)
            {
               // headindex = 1;
                for (int columid = 0; columid < sourceData.Columns.Count; columid++)
                {

                    string value = sourceData.Rows[rowid][columid].ToString();
      //            MessageBox.Show(value +":"+ rowid);

                    if (value != null )
                    {

                        #region setcolum
                        if (value.Trim().Contains("Customer"))
                        {
                            Customerid = columid;
                            headindex = rowid;
                        }

                        if (value.Trim().Contains("FullNameN") && headindex == rowid)
                        {

                            FullNameNid = columid;
                      //    headindex = 0;

                        }


                        if (value.Trim().Contains("Telephone1") && headindex == rowid)
                        {

                            Telephone1id = columid;
                         //   headindex = 0;



                        }

                        if (value.Trim().Contains("SalesDistrict") && headindex == rowid)
                        {
                            SalesDistrictid = columid;

                        }

                        if (value.Trim().Contains("District") && headindex == rowid )
                        {

                            if (columid != SalesDistrictid)
                            {
                                Districtid = columid;
                            }
                          
                           
                        }

                        if (value.Trim().Contains("SalesOrg") && headindex == rowid)
                        {
                            SalesOrgid = columid;
                           
                        }

                        if (value.Trim().Contains("Street") && headindex == rowid)
                        {
                            Streetid = columid;
                           // headindex = 0;
                        }

                        if (value.Trim().Contains("City") && headindex == rowid)
                        {
                            Cityid = columid;
                            
                        }

                        if (value.Trim().Contains("Region") && headindex == rowid)
                        {
                            Regionid = columid;
                          
                        }
                        if (value.Trim().Contains("PaymentTerms") && headindex == rowid)
                        {
                            PaymentTermsid = columid;
                         
                        }
                        if (value.Trim().Contains("PriceList") && headindex == rowid)
                        {
                            PriceListid = columid;
                          
                        }
                        if (value.Trim().Contains("KeyAcc") && headindex == rowid)
                        {
                            KeyAccid = columid;
                           
                        }
                      
                        if (value.Trim().Contains("VATregistrationNo") && headindex == rowid)
                        {
                            VATregistrationNoid = columid;
                            
                        }

                        

                        #endregion

                    }


                }// colum
                
            }// roww off heatder


            for (int rowixd = 0; rowixd < sourceData.Rows.Count; rowixd++)
            {
                               
                    #region setvalue of pricelist
                    //   string valuepricelist = Utils.GetValueOfCellInExcel(worksheet, rowid, columpricelist);
                  string customer = sourceData.Rows[rowixd][Customerid].ToString();
                if ( customer != "" && Utils.IsValidnumber(customer))
                {


                    

                    DataRow dr = batable.NewRow();
                    dr["Customer"] = sourceData.Rows[rowixd][Customerid].ToString().Trim();
                    dr["FullNameN"] = sourceData.Rows[rowixd][FullNameNid].ToString().Trim();
                      dr["Telephone1"] = sourceData.Rows[rowixd][Telephone1id].ToString().Trim();
                    dr["District"] = sourceData.Rows[rowixd][Districtid].ToString().Trim();
                    dr["SalesOrg"] = sourceData.Rows[rowixd][SalesOrgid].ToString().Trim();
                    dr["Street"] = sourceData.Rows[rowixd][Streetid].ToString().Trim();
                    dr["City"] = sourceData.Rows[rowixd][Cityid].ToString().Trim();

                    dr["Region"] = sourceData.Rows[rowixd][Regionid].ToString().Trim();

                    dr["PaymentTerms"] = sourceData.Rows[rowixd][PaymentTermsid].ToString().Trim();

                    dr["PriceList"] = sourceData.Rows[rowixd][PriceListid].ToString().Trim();

                    dr["KeyAcc"] = sourceData.Rows[rowixd][KeyAccid].ToString().Trim();

                    dr["SalesDistrict"] = sourceData.Rows[rowixd][SalesDistrictid].ToString().Trim();

                    dr["VATregistrationNo"] = sourceData.Rows[rowixd][VATregistrationNoid].ToString().Trim();

            
             
                    dr["Createdon"] =  DateTime.Today;// Utils.GetValueOfCellInExcel(worksheet, rowid, columValid_to);
                    dr["Createby"] = Model.Username.getUsername();



                    batable.Rows.Add(dr);


                }

                #endregion

            }// row

            //conpy to server
            string destConnString = Utils.getConnectionstr();

            //adapter.FillSchema(sourceData, SchemaType.Source);
            //sourceData.Columns["Posting Date"].DataType = typeof(DateTime);

            //batable.Columns.Add("", typeof(string));
        


            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destConnString))
            {

             


                bulkCopy.DestinationTableName = "tbl_MKT_Soldtocode";
                // Write from the source to the destination.
                bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Add("Customer", "Customer");

                bulkCopy.ColumnMappings.Add("FullNameN", "FullNameN");
                bulkCopy.ColumnMappings.Add("Telephone1", "Telephone1");
                bulkCopy.ColumnMappings.Add("District", "District");

                bulkCopy.ColumnMappings.Add("SalesOrg", "SalesOrg");
                bulkCopy.ColumnMappings.Add("Street", "Street");
                bulkCopy.ColumnMappings.Add("City", "City");
           
                bulkCopy.ColumnMappings.Add("Region", "Region");
                bulkCopy.ColumnMappings.Add("PaymentTerms", "PaymentTerms");
                bulkCopy.ColumnMappings.Add("PriceList", "PriceList");
                bulkCopy.ColumnMappings.Add("KeyAcc", "KeyAcc");

                bulkCopy.ColumnMappings.Add("SalesDistrict", "SalesDistrict");
                bulkCopy.ColumnMappings.Add("Createdon", "Createdon");
                bulkCopy.ColumnMappings.Add("Createby", "Createby");
                bulkCopy.ColumnMappings.Add("VATregistrationNo", "VATregistrationNo");
            


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
            //copy to server
            //   string connection_string = Utils.getConnectionstr();

            //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //    var typeffmain = typeof(tbl_KAbaseprice);
            //     var typeffsub = typeof(tbl_KAbaseprice);

            //    VInputchange inputcdata1 = new VInputchange("", "Base price list", dc, "tbl_KAbaseprice", "tbl_KAbaseprice", typeffmain, typeffsub, "id", "id", "");
            //    inputcdata1.ShowDialog();
            //  View.Viewdatatable TB = new View.Viewdatatable(batable, "lIST DATA");
            //  TB.ShowDialog();

            //  }
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


        public void customerinputpriceingupdate()
        {


            //   CultureInfo provider = CultureInfo.InvariantCulture;


            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File ZNKA1 Customer excel";
            theDialog.Filter = "Excel files|*.xlsx; *.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                //  AutoResetEvent autoEvent = new AutoResetEvent(false); //join



                string filename = theDialog.FileName.ToString();
                Thread t1 = new Thread(importCustomersoldtolist);
                t1.IsBackground = true;
                t1.Start(new datainportF() { filename = filename });


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
