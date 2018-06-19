﻿using Maketting.Control;
using Maketting.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maketting.Model
{
    class Khohang
    {


        public static IQueryable Danhsachkho(Maketting.LinqtoSQLDataContext dc)
        {


            Maketting.LinqtoSQLDataContext db = dc;


            var rs = from p in dc.tbl_khohangs
                     select new
                     {

                         Mã_kho = p.makho,
                         Tên_kho = p.tenkho,
                         Địa_chỉ = p.diachikho,

                         ID = p.id
                     };





            return rs;





        }

        public static void themmoikhohang()
        {
            View.BeeDanhsachkho p = new BeeDanhsachkho(3, -1);  // 3 là thêm ới/ 4 là sửa xóa
                                                                //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();






            // throw new NotImplementedException();
        }

        public static void suaxoadanhsachkho(int iddanhscahkho)
        {




            View.BeeDanhsachkho p = new BeeDanhsachkho(4, iddanhscahkho);  // 3 là thêm ới/ 4 là sửa xóa
                                                                           //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();





            //  throw new NotImplementedException();
        }

        public static IQueryable danhsachnhomsanpham(Maketting.LinqtoSQLDataContext dc)
        {



            Maketting.LinqtoSQLDataContext db = dc;


            var rs = from p in dc.tbl_kho_nhomsanphams
                     select new
                     {

                         Mã_nhóm = p.manhomsanpham,
                         Tên_nhóm_sản_phẩm = p.tennhomsanpham,


                         ID = p.id
                     };





            return rs;










            //  throw new NotImplementedException();
        }

        public static void themmoinhomsanpham()
        {

            View.BeeDanhsachnhomsanpham p = new BeeDanhsachnhomsanpham(3, -1);  // 3 là thêm ới/ 4 là sửa xóa
                                                                                //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();







            //throw new NotImplementedException();
        }

        public static void suanhomsanpham(int idtk)
        {


            View.BeeDanhsachnhomsanpham p = new BeeDanhsachnhomsanpham(4, idtk);  // 3 là thêm ới/ 4 là sửa xóa
                                                                                  //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();



            //throw new NotImplementedException();
        }

        public static IQueryable danhsachsanpham(Maketting.LinqtoSQLDataContext dc)
        {


            Maketting.LinqtoSQLDataContext db = dc;


            var rs = from p in dc.tbl_kho_sanphams
                     select new
                     {

                         Mã_sản_phẩm = p.masp,
                         Mã_kho_hàng = p.makho,
                         Tên_kho_hàng = p.tenkho,
                         Tên_sản_phẩm = p.tensp,
                         Mã_vạch = p.mavach,
                         Đơn_vị = p.donvi,
                         KHối_lượng = p.khoiluong,
                         Trọng_lượng = p.trongluong,
                         Mã_nhóm_sản_phẩm = p.idmanhomsp,
                         Số_lượng_tồn_đầu = p.tondksoluong,
                         Thành_tiên_tồn_đầu = p.tondkthanhtien,
                         Ghi_chú = p.ghichu,



                         ID = p.id
                     };





            return rs;






            //    throw new NotImplementedException();
        }

        public static void themmoisanpham()
        {

            View.BeeDanhsachsanpham p = new BeeDanhsachsanpham(3, -1);  // 3 là thêm ới/ 4 là sửa xóa
                                                                        //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();





            //  throw new NotImplementedException();
        }

        public static void suasanpham(int idtk)
        {

            View.BeeDanhsachsanpham p = new BeeDanhsachsanpham(4, idtk);  // 3 là thêm ới/ 4 là sửa xóa
                                                                          //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();

            //  throw new NotImplementedException();
        }

        public static IQueryable danhsachphieunhapkho(Maketting.LinqtoSQLDataContext dc)
        {


            Maketting.LinqtoSQLDataContext db = dc;


            var rs = from p in dc.tbl_kho_phieunhap_heads

                     select new
                     {

                         Ngày_phiếu_nhập = p.ngayphieunhap,
                         Mã_kho = p.makho,
                         Tên_kho = p.tenkho,
                         Phiếu_số = p.phieuso,
                         Người_giao = p.nguoigiao,
                         Theo_đơn_hàng = p.theodonhang,
                         Diễn_giải = p.diengiai,
                         Có_TK = p.cotk,
                         Chi_tiết_TK_Có = p.MaCTietTKCo,
                         Tên_TK_chi_tiết_Có = p.TenCTietTKCo,

                         Nợ_TK = p.notk,
                         Chi_tiết_TK_Nợ = p.MaCTietTKNo,
                         Tên_TK_chi_tiết_Nợ = p.TenCTietTKNo,

                         Số_tiền = p.sotien,

                         Tạo_bởi = p.createby,



                         ID = p.id
                     };





            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable danhsachphieuxuatkho(Maketting.LinqtoSQLDataContext dc)
        {


            Maketting.LinqtoSQLDataContext db = dc;


            var rs = from p in dc.tbl_kho_phieuxuat_heads

                     select new
                     {

                         Ngày_phiếu_xuất = p.ngayphieuxuat,
                         Mã_kho = p.makho,
                         Tên_kho = p.tenkho,
                         Phiếu_số = p.phieuso,
                         Người_nhận = p.nguoinhanhang,
                  //       Theo_đơn_hàng = p.theodonhang,
                         Diễn_giải = p.diengiai,
                         Có_TK = p.cotk,
                         Chi_tiết_TK_Có = p.MaCTietTKCo,
                         Tên_TK_chi_tiết_Có = p.TenCTietTKCo,

                         Nợ_TK = p.notk,
                         Chi_tiết_TK_Nợ = p.MaCTietTKNo,
                         Tên_TK_chi_tiết_Nợ = p.TenCTietTKNo,

                         Số_tiền = p.sotien,

                         Tạo_bởi = p.createby,



                         ID = p.id
                     };





            return rs;


            // throw new NotImplementedException();
        }


        public static DataGridView reloaddetailnewPNK(DataGridView dataGridViewdetailPNK, string makho)
        {



            dataGridViewdetailPNK.DataSource = null;
            #region datatable temp




            DataTable dt = new DataTable();



            //   dt.Columns.Add(new DataColumn("Ngày_chứng_từ", typeof(DGV_DateTimePicker.DateTimePickerCell)));
            dt.Columns.Add(new DataColumn("masanpham", typeof(string)));
            dt.Columns.Add(new DataColumn("Tên_sản_phẩm", typeof(string)));

            dt.Columns.Add(new DataColumn("Đơn_vị", typeof(string)));
            dt.Columns.Add(new DataColumn("Số_lượng_nhập", typeof(double)));

            //Threahold
            //      dt.Columns.Add(new DataColumn("Tk_Có", typeof(double)));
            dt.Columns.Add(new DataColumn("Đơn_giá", typeof(double)));
            dt.Columns.Add(new DataColumn("Thành_tiền", typeof(double)));
            //     dt.Columns.Add(new DataColumn("tkidhide", typeof(string))); //comnoxxon
            //  dt.Columns.Add(new DataColumn("Tk_Có", typeof(double)));
            //    dt.Columns.Add(new DataColumn("ngayctuhide", typeof(DateTime))); //adding column for combobox





            dataGridViewdetailPNK.DataSource = dt;


            //DGV_DateTimePicker.DateTimePickerColumn col = new DGV_DateTimePicker.DateTimePickerColumn();
            //col.HeaderText = "Ngày chứng từ";
            //col.Name = "Ngày_chứng_từ";
            //col.DataPropertyName = "ngayctuhide";
            //dataGridViewdetailPNK.Columns.Add(col);


            //    dataGridViewTkCo.Columns.Remove("Tk_Có");

            #region  //  mã sản phẩm
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();


            List<View.BeeKhophieunhap.ComboboxItem> CombomCollection = new List<View.BeeKhophieunhap.ComboboxItem>();

            var rs = from p in dc.tbl_kho_sanphams
                     where p.makho == makho
                     orderby p.masp
                     select p;
            foreach (var item in rs)
            {
                View.BeeKhophieunhap.ComboboxItem cb = new View.BeeKhophieunhap.ComboboxItem();
                cb.Value = item.masp;
                cb.Text = item.masp.Trim() + ": " + item.tensp;
                CombomCollection.Add(cb);
            }

            cmbdgv.DataSource = CombomCollection;
            cmbdgv.HeaderText = "Mã_sản_phẩm";
            cmbdgv.Name = "Mã_sản_phẩm";
            cmbdgv.ValueMember = "Value";
            cmbdgv.DisplayMember = "Text";
            cmbdgv.Width = 300;
            cmbdgv.DropDownWidth = 300;
            cmbdgv.DataPropertyName = "masanpham"; //Bound value to the datasource


            dataGridViewdetailPNK.Columns.Add(cmbdgv);





            #endregion binddata

            dataGridViewdetailPNK.Columns["masanpham"].Visible = false;
            dataGridViewdetailPNK.Columns["Mã_sản_phẩm"].DisplayIndex = 0;

            dataGridViewdetailPNK.Columns["Tên_sản_phẩm"].ReadOnly = true;
            dataGridViewdetailPNK.Columns["Đơn_vị"].ReadOnly = true;

            dataGridViewdetailPNK.Columns["Tên_sản_phẩm"].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewdetailPNK.Columns["Đơn_vị"].DefaultCellStyle.BackColor = Color.LightGray;

            dataGridViewdetailPNK.Columns["Số_lượng_nhập"].DefaultCellStyle.Format = "N0"; // để hiện số có dấu phảy
            dataGridViewdetailPNK.Columns["Đơn_giá"].DefaultCellStyle.Format = "N0";
            dataGridViewdetailPNK.Columns["Thành_tiền"].DefaultCellStyle.Format = "N0";


            dataGridViewdetailPNK.Columns["Số_lượng_nhập"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // để hiện số có dấu phảy
            dataGridViewdetailPNK.Columns["Đơn_giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewdetailPNK.Columns["Thành_tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        //    this.dataGridView1.Columns["CustomerCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            //this.dataGridView1.Columns["CustomerCode"].DefaultCellStyle.Format = "N0";
            //this.dataGridView1.Columns["CustomerCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

            //   dataGridViewdetailPNK.Columns["Đơn_giá"].DefaultCellStyle = datag  ;

            //    dataGridViewdetailPNK.Columns["Tk_Có"].Visible = false;
            // dataGridViewdetailPNK.Columns["masanpham"].Visible = false;

            //     dataGridViewdetailPNK.Columns["Tk_Nợ"].DisplayIndex = 0;
            //    dataGridViewdetailPNK.Columns["Tk_Nợ"].Width = 100;
            //    dataGridViewdetailPNK.Columns["Tk_Nợ"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].DisplayIndex = 1;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].Width = 100;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].ReadOnly = true;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].DefaultCellStyle.BackColor = Color.LightGray;

            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].DisplayIndex = 2;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].Width = 200;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].ReadOnly = true;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].DefaultCellStyle.BackColor = Color.LightGray;


            //dataGridViewdetailPNK.Columns["Số_tiền"].DisplayIndex = 3;
            //dataGridViewdetailPNK.Columns["Số_tiền"].Width = 100;
            //dataGridViewdetailPNK.Columns["Số_tiền"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewdetailPNK.Columns["Số_tiền"].DefaultCellStyle.Format = "N0";


            //dataGridViewdetailPNK.Columns["Diễn_giải"].DisplayIndex = 4;
            //dataGridViewdetailPNK.Columns["Diễn_giải"].Width = 300;
            //dataGridViewdetailPNK.Columns["Diễn_giải"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //dataGridViewdetailPNK.Columns["Ký_hiêu"].DisplayIndex = 5;
            //dataGridViewdetailPNK.Columns["Ký_hiêu"].Width = 100;
            //dataGridViewdetailPNK.Columns["Ký_hiêu"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //dataGridViewdetailPNK.Columns["Ngày_chứng_từ"].DisplayIndex = 6;
            //dataGridViewdetailPNK.Columns["Ngày_chứng_từ"].Width = 100;
            //dataGridViewdetailPNK.Columns["Ngày_chứng_từ"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //dataGridViewdetailPNK.Columns["Số_chứng_từ"].DisplayIndex = 7;
            //dataGridViewdetailPNK.Columns["Số_chứng_từ"].Width = 200;
            //dataGridViewdetailPNK.Columns["Số_chứng_từ"].SortMode = DataGridViewColumnSortMode.NotSortable;






            #endregion datatable temp


            return dataGridViewdetailPNK;





            //  throw new NotImplementedException();
        }

        public static DataGridView reloaddetailnewPXK(DataGridView dataGridViewdetailPXK, string makho)
        {



            dataGridViewdetailPXK.DataSource = null;
            #region datatable temp




            DataTable dt = new DataTable();



            //   dt.Columns.Add(new DataColumn("Ngày_chứng_từ", typeof(DGV_DateTimePicker.DateTimePickerCell)));
            dt.Columns.Add(new DataColumn("masanpham", typeof(string)));
            dt.Columns.Add(new DataColumn("Tên_sản_phẩm", typeof(string)));

            dt.Columns.Add(new DataColumn("Đơn_vị", typeof(string)));
            dt.Columns.Add(new DataColumn("Số_lượng_xuất", typeof(double)));

            //Threahold
            //      dt.Columns.Add(new DataColumn("Tk_Có", typeof(double)));
            dt.Columns.Add(new DataColumn("Đơn_giá", typeof(double)));
            dt.Columns.Add(new DataColumn("Thành_tiền", typeof(double)));
            //     dt.Columns.Add(new DataColumn("tkidhide", typeof(string))); //comnoxxon
            //  dt.Columns.Add(new DataColumn("Tk_Có", typeof(double)));
            //    dt.Columns.Add(new DataColumn("ngayctuhide", typeof(DateTime))); //adding column for combobox





            dataGridViewdetailPXK.DataSource = dt;


            //DGV_DateTimePicker.DateTimePickerColumn col = new DGV_DateTimePicker.DateTimePickerColumn();
            //col.HeaderText = "Ngày chứng từ";
            //col.Name = "Ngày_chứng_từ";
            //col.DataPropertyName = "ngayctuhide";
            //dataGridViewdetailPNK.Columns.Add(col);


            //    dataGridViewTkCo.Columns.Remove("Tk_Có");

            #region  //  mã sản phẩm
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();


            List<View.BeeKhophieuxuat.ComboboxItem> CombomCollection = new List<View.BeeKhophieuxuat.ComboboxItem>();

            var rs = from p in dc.tbl_kho_sanphams
                     where p.makho == makho

                     orderby p.masp
                     select p;
            foreach (var item in rs)
            {
                View.BeeKhophieuxuat.ComboboxItem cb = new View.BeeKhophieuxuat.ComboboxItem();
                cb.Value = item.masp;
                cb.Text = item.masp.Trim() + ": " + item.tensp;
                CombomCollection.Add(cb);
            }

            cmbdgv.DataSource = CombomCollection;
            cmbdgv.HeaderText = "Mã_sản_phẩm";
            cmbdgv.Name = "Mã_sản_phẩm";
            cmbdgv.ValueMember = "Value";
            cmbdgv.DisplayMember = "Text";
            cmbdgv.Width = 300;
            cmbdgv.DropDownWidth = 300;
            cmbdgv.DataPropertyName = "masanpham"; //Bound value to the datasource


            dataGridViewdetailPXK.Columns.Add(cmbdgv);





            #endregion binddata

            dataGridViewdetailPXK.Columns["masanpham"].Visible = false;
            dataGridViewdetailPXK.Columns["Mã_sản_phẩm"].DisplayIndex = 0;

            dataGridViewdetailPXK.Columns["Tên_sản_phẩm"].ReadOnly = true;
            dataGridViewdetailPXK.Columns["Đơn_vị"].ReadOnly = true;

            dataGridViewdetailPXK.Columns["Tên_sản_phẩm"].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewdetailPXK.Columns["Đơn_vị"].DefaultCellStyle.BackColor = Color.LightGray;

            dataGridViewdetailPXK.Columns["Số_lượng_xuất"].DefaultCellStyle.Format = "N0"; // để hiện số có dấu phảy
            dataGridViewdetailPXK.Columns["Đơn_giá"].DefaultCellStyle.Format = "N0";
            dataGridViewdetailPXK.Columns["Thành_tiền"].DefaultCellStyle.Format = "N0";


            dataGridViewdetailPXK.Columns["Số_lượng_xuất"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // để hiện số có dấu phảy
            dataGridViewdetailPXK.Columns["Đơn_giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewdetailPXK.Columns["Thành_tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //    this.dataGridView1.Columns["CustomerCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            //this.dataGridView1.Columns["CustomerCode"].DefaultCellStyle.Format = "N0";
            //this.dataGridView1.Columns["CustomerCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

            //   dataGridViewdetailPNK.Columns["Đơn_giá"].DefaultCellStyle = datag  ;

            //    dataGridViewdetailPNK.Columns["Tk_Có"].Visible = false;
            // dataGridViewdetailPNK.Columns["masanpham"].Visible = false;

            //     dataGridViewdetailPNK.Columns["Tk_Nợ"].DisplayIndex = 0;
            //    dataGridViewdetailPNK.Columns["Tk_Nợ"].Width = 100;
            //    dataGridViewdetailPNK.Columns["Tk_Nợ"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].DisplayIndex = 1;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].Width = 100;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].ReadOnly = true;
            //dataGridViewdetailPNK.Columns["Mã_chi_tiết"].DefaultCellStyle.BackColor = Color.LightGray;

            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].DisplayIndex = 2;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].Width = 200;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].ReadOnly = true;
            //dataGridViewdetailPNK.Columns["Tên_chi_tiết"].DefaultCellStyle.BackColor = Color.LightGray;


            //dataGridViewdetailPNK.Columns["Số_tiền"].DisplayIndex = 3;
            //dataGridViewdetailPNK.Columns["Số_tiền"].Width = 100;
            //dataGridViewdetailPNK.Columns["Số_tiền"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewdetailPNK.Columns["Số_tiền"].DefaultCellStyle.Format = "N0";


            //dataGridViewdetailPNK.Columns["Diễn_giải"].DisplayIndex = 4;
            //dataGridViewdetailPNK.Columns["Diễn_giải"].Width = 300;
            //dataGridViewdetailPNK.Columns["Diễn_giải"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //dataGridViewdetailPNK.Columns["Ký_hiêu"].DisplayIndex = 5;
            //dataGridViewdetailPNK.Columns["Ký_hiêu"].Width = 100;
            //dataGridViewdetailPNK.Columns["Ký_hiêu"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //dataGridViewdetailPNK.Columns["Ngày_chứng_từ"].DisplayIndex = 6;
            //dataGridViewdetailPNK.Columns["Ngày_chứng_từ"].Width = 100;
            //dataGridViewdetailPNK.Columns["Ngày_chứng_từ"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //dataGridViewdetailPNK.Columns["Số_chứng_từ"].DisplayIndex = 7;
            //dataGridViewdetailPNK.Columns["Số_chứng_từ"].Width = 200;
            //dataGridViewdetailPNK.Columns["Số_chứng_từ"].SortMode = DataGridViewColumnSortMode.NotSortable;






            #endregion datatable temp


            return dataGridViewdetailPXK;





            //  throw new NotImplementedException();
        }


    }


}
