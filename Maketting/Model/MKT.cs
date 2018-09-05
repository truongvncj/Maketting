using System;
using System.Data;
using System.Windows.Forms;

namespace Maketting.Model
{
    public class MKT
    {
        public static DataGridView Loadnewdetail(DataGridView dataGridViewDetail)
        {


            dataGridViewDetail.DataSource = null;
            #region datatable temp




            DataTable dt = new DataTable();


             dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
            dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
            dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));




            dataGridViewDetail.DataSource = dt;
            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewDetail.Columns["Avaiable_Quantity"].ReadOnly = true;
            dataGridViewDetail.Columns["Avaiable_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;


            //DGV_DateTimePicker.DateTimePickerColumn col = new DGV_DateTimePicker.DateTimePickerColumn();
            //col.HeaderText = "Ngày chứng từ";
            //col.Name = "Ngày_chứng_từ";
            //col.DataPropertyName = "ngayctuhide";
            //dataGridViewTkCo.Columns.Add(col);


            //    dataGridViewTkCo.Columns.Remove("Tk_Có");

            //#region  //    bindDataToDataGridViewComboPrograme(); Tk_Có
            //string connection_string = Utils.getConnectionstr();
            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();


            //List<View.BeePhieuThu.ComboboxItem> CombomCollection = new List<View.BeePhieuThu.ComboboxItem>();
            //var rs = from tbl_dstaikhoan in dc.tbl_dstaikhoans
            //         orderby tbl_dstaikhoan.matk
            //         select tbl_dstaikhoan;
            //foreach (var item in rs)
            //{
            //    View.BeePhieuThu.ComboboxItem cb = new View.BeePhieuThu.ComboboxItem();
            //    cb.Value = item.matk.Trim();
            //    cb.Text = item.matk.Trim() + ": " + item.tentk;
            //    CombomCollection.Add(cb);
            //}

            //cmbdgv.DataSource = CombomCollection;
            //cmbdgv.HeaderText = "Tk_Có";
            //cmbdgv.Name = "Tk_Có";
            //cmbdgv.ValueMember = "Value";
            //cmbdgv.DisplayMember = "Text";
            //cmbdgv.Width = 100;
            //cmbdgv.DropDownWidth = 300;
            //cmbdgv.DataPropertyName = "tkCohide"; //Bound value to the datasource


            //dataGridViewTkCo.Columns.Add(cmbdgv);





            //#endregion binddata


            //dataGridViewTkCo.Columns["tkCohide"].Visible = false;
            ////     dataGridViewTkCo.Columns["ngayctuhide"].Visible = false;

            //dataGridViewTkCo.Columns["Tk_Có"].DisplayIndex = 0;
            //dataGridViewTkCo.Columns["Tk_Có"].Width = 100;
            //dataGridViewTkCo.Columns["Tk_Có"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //dataGridViewTkCo.Columns["Mã_chi_tiết"].DisplayIndex = 1;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].Width = 100;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].ReadOnly = true;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].DefaultCellStyle.BackColor = Color.LightGray;

            //dataGridViewTkCo.Columns["Tên_chi_tiết"].DisplayIndex = 2;
            //dataGridViewTkCo.Columns["Tên_chi_tiết"].Width = 200;
            //dataGridViewTkCo.Columns["Tên_chi_tiết"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewTkCo.Columns["Tên_chi_tiết"].ReadOnly = true;
            //dataGridViewTkCo.Columns["Tên_chi_tiết"].DefaultCellStyle.BackColor = Color.LightGray;


            //dataGridViewTkCo.Columns["Số_tiền"].DisplayIndex = 3;
            //dataGridViewTkCo.Columns["Số_tiền"].Width = 100;
            //dataGridViewTkCo.Columns["Số_tiền"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewTkCo.Columns["Số_tiền"].DefaultCellStyle.Format = "N0";


            //dataGridViewTkCo.Columns["Diễn_giải"].DisplayIndex = 4;
            //dataGridViewTkCo.Columns["Diễn_giải"].Width = 300;
            //dataGridViewTkCo.Columns["Diễn_giải"].SortMode = DataGridViewColumnSortMode.NotSortable;


            ////dataGridViewTkCo.Columns["Ký_hiêu"].DisplayIndex = 5;
            ////dataGridViewTkCo.Columns["Ký_hiêu"].Width = 100;
            ////dataGridViewTkCo.Columns["Ký_hiêu"].SortMode = DataGridViewColumnSortMode.NotSortable;


            ////dataGridViewTkCo.Columns["Ngày_chứng_từ"].DisplayIndex = 6;
            ////dataGridViewTkCo.Columns["Ngày_chứng_từ"].Width = 100;
            ////dataGridViewTkCo.Columns["Ngày_chứng_từ"].SortMode = DataGridViewColumnSortMode.NotSortable;


            ////dataGridViewTkCo.Columns["Số_chứng_từ"].DisplayIndex = 7;
            //dataGridViewTkCo.Columns["Số_chứng_từ"].Width = 200;
            //dataGridViewTkCo.Columns["Số_chứng_từ"].SortMode = DataGridViewColumnSortMode.NotSortable;






            #endregion datatable temp


            return dataGridViewDetail;





            //  throw new NotImplementedException();
        }

        public static string getmaquyenkho()
        {
           

            string username = Utils.getusername();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in db.tbl_Temps
                      select tbl_Temp.Phân_quyền).FirstOrDefault();





       



            return "";




            //throw new NotImplementedException();
        }
    }
}