using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cExcel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Maketting.shared;
using Maketting.View;
using System.Threading;

using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

//BEEACCOUNT.LinqtoSQLDataContext

namespace Maketting.Control
{
    class Control_ac
    {


        public static void messagetomanin(Main main, string messagetext, Color maunen)
        {
            main.messagetext(messagetext, maunen);



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






        class datatoExport
        {
            public System.Data.DataTable dataGrid1 { get; set; }
            public string filename { get; set; }
            public string tittle { get; set; }
        }





        public static void exportsexcel(object objextoEl)
        {

            datatoExport dat = (datatoExport)objextoEl;


            //      DataTable table, string filename
            DataTable dt = dat.dataGrid1;
            string filename = dat.filename;
            //   SpreadsheetDocument spse = SpreadsheetDocument.Create(filename, SpreadsheetDocumentType.Workbook);
            //Exporting to Excel

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            //ExcelDocument xls = new ExcelDocument();
            //xls.easy_WriteXLSFile_FromDataSet("datatable.xls", ds,
            //           new ExcelAutoFormat(DocumentFormat.OpenXml.Wordprocessing.Styles.AUTOFORMAT_EASYXLS1), "DataTable");


            //string folderPath = "C:\\Excel\\";
            //if (!Directory.Exists(folderPath))
            //{
            //    Directory.CreateDirectory(folderPath);
            //}
            try
            {
                //using (XLWorkbook wb = new XLWorkbook())
                //{

                ExportToExcel.ExportToExcel.ExportDataSet(ds, filename);
                //    wb.Worksheets.Add(ds);
                //    wb.SaveAs(filename);
                //}
                MessageBox.Show(filename + " exported !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Thông báo không excel export được ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public static void exportsexcel2old(object objextoEl)
        {

            datatoExport dat = (datatoExport)objextoEl;

            //    DataTable dataTble = new DataTable();
            //   DataSet dataSet, string outputPath

            // Create the Excel Application object
            cExcel.ApplicationClass excelApp = new cExcel.ApplicationClass();

            // Create a new Excel Workbook
            cExcel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

            int sheetIndex = 0;
            System.Data.DataTable dt = dat.dataGrid1;


            var tittle = dat.tittle;
            var filename = dat.filename;

            // Copy the DataTable to an object array
            object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];

            // Copy the column names to the first row of the object array
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                rawData[0, col] = dt.Columns[col].ColumnName.Replace("_", " ");
            }

            // Copy the values to the object array
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    rawData[row + 1, col] = dt.Rows[row].ItemArray[col];
                }
            }

            // Calculate the final column letter
            string finalColLetter = string.Empty;
            string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int colCharsetLen = colCharset.Length;

            if (dt.Columns.Count > colCharsetLen)
            {
                finalColLetter = colCharset.Substring(
                    (dt.Columns.Count - 1) / colCharsetLen - 1, 1);
            }

            finalColLetter += colCharset.Substring(
                    (dt.Columns.Count - 1) % colCharsetLen, 1);

            // Create a new Sheet
            cExcel.Worksheet excelSheet = (cExcel.Worksheet)excelWorkbook.Sheets.Add(
                excelWorkbook.Sheets.get_Item(++sheetIndex),
                Type.Missing, 1, cExcel.XlSheetType.xlWorksheet);

            //         excelSheet.Name = dt.TableName;

            // Fast data export to Excel
            string excelRange = string.Format("A1:{0}{1}",
                finalColLetter, dt.Rows.Count + 1);

            excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;

            // Mark the first row as BOLD
            ((cExcel.Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;


            // Save and Close the Workbook


            excelWorkbook.SaveAs(filename, cExcel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, cExcel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelWorkbook.Close(true, Type.Missing, Type.Missing);
            //   xlApp.Quit();



            //excelWorkbook.SaveAs(outputPath, cExcel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            //    Type.Missing, Type.Missing, Type.Missing, cExcel.XlSaveAsAccessMode.xlExclusive,
            //    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //excelWorkbook.Close(true, Type.Missing, Type.Missing);
            //excelWorkbook = null;

            // Release the Application object
            excelApp.Quit();
            excelApp = null;

            // Collect the unreferenced objects
            GC.Collect();
            GC.WaitForPendingFinalizers();



            MessageBox.Show(filename + " exported !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public void exportexceldatagridtofile(IQueryable iquery, LinqtoSQLDataContext db, string tittle)
        {
            System.Data.DataTable datatable1 = new System.Data.DataTable();
            //

            Utils ul = new Utils();

            datatable1 = ul.ToDataTable(db, iquery);
            SaveFileDialog thedialog = new SaveFileDialog();
            //


            //   datagridview datagridview1 = new datagridview();
            //   datagridview1.datasource = datagrid.datasource;

            thedialog.Title = "export to excel file";
            thedialog.Filter = "excel files|*.xlsx; *.xls";
            thedialog.InitialDirectory = @"c:\";


            if (thedialog.ShowDialog() == DialogResult.OK)
            {

                string filename = thedialog.FileName.ToString();
                Thread t1 = new Thread(exportsexcel);
                t1.IsBackground = true;
                t1.Start(new datatoExport() { dataGrid1 = datatable1, filename = filename, tittle = tittle });
                // t1.join();
            }



        }

        public void exportexceldatagridtoEinvoice(IQueryable iquery, LinqtoSQLDataContext db, string tittle)
        {



            //throw new NotImplementedException();
        }
    }

}