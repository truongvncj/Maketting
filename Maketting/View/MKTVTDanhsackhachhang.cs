﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maketting.Control;

namespace Maketting.View
{


    public partial class MKTVTDanhsackhachhang : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }
        public string maID { get; set; }
        public string tenKH { get; set; }

        public string diachiKH { get; set; }

        public string MaKH { get; set; }

        //      public string dienthoai { get; set; }
        public string dienthoai { get; set; }
        public string ghichu { get; set; }

        public bool chon { get; set; }


        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }


            public override string ToString()
            {
                return Text;
            }
        }


        public MKTVTDanhsackhachhang(int lainghiepvu, int id) // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            InitializeComponent();

            chon = false;



            this.id = id;

            if (lainghiepvu == 4) // xóa + sua
            {
                this.btnew.Visible = false;
                //  this.txtmaNCC.Text = makhachhang;

                txtma.Enabled = false;


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



                var item = (from p in dc.tbl_MKT_khachhangs
                            where p.id == id
                            select p).FirstOrDefault();

                if (item != null)
                {


                    txtma.Text = item.maKH;
                    txtten.Text = item.tenKH;

                    // txtdienthoai.Text = item.dienthoaiNVT;
                    txtmakhachhang.Text = item.masothueKH;

                    txtdiachi.Text = item.diachiKH;//  p.masothue  

                    txttaikhoannganhangso.Text = item.dienthoai;//  p.ghichunganhnghe  

                    txtdiachitaikhoannganhang.Text = item.ghichu;




                }


            }






            if (lainghiepvu == 3) // tạo mới
            {
                this.btupdate.Visible = false;
                this.btxoa.Visible = false;





            }




        }

        private void txtCustcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtten.Focus();


            }



        }

        private void txt_vendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtten.Focus();


            }

        }




        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {





        }

        private void cbtkmother_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (e.KeyChar == (char)Keys.Enter)
            {


                btnew.Focus();


            }



        }

        private void btxoa_Click(object sender, EventArgs e)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            var rs1 = (from p in dc.tbl_MKT_khachhangs
                       where p.id == this.id
                       select p).FirstOrDefault();

            if (rs1 != null)
            {

                dc.tbl_MKT_khachhangs.DeleteOnSubmit(rs1);
                dc.SubmitChanges();
                this.Close();


            }




        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            //

            //txtma.Text = item.maNVT;
            //txtten.Text = item.tenNVT;

            //txtdienthoai.Text = item.dienthoaiNVT;
            //txtmasothue.Text = item.masothueNVT;

            //txtdiachi.Text = item.diachiNVT;//  p.masothue  

            //txttaikhoannganhangso.Text = item.sotaikhoannganhangNVT;//  p.ghichunganhnghe  

            //txtdiachitaikhoannganhang.Text = item.diachinganhangNVT;



            this.maID = this.txtma.Text;
            this.tenKH = this.txtten.Text;
            this.diachiKH = this.txtdiachi.Text;
            this.MaKH = txtmakhachhang.Text;
            //   this.dienthoai = txtdienthoai.Text;
            this.dienthoai = txttaikhoannganhangso.Text;
            this.ghichu = txtdiachitaikhoannganhang.Text;


            //this.usertao = Utils.getusername();

            //this.ngaytao = DateTime.Today;


            if (maID == "")
            {
                MessageBox.Show("Bạn chưa có mã nhà cung cấp", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (maID != "")
            {
                chon = true;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

                //   tbl_dstaikhoan tk = new tbl_dstaikhoan();


                //    MeasureItemEventArgs.re
                var rs = (from p in db.tbl_MKT_khachhangs
                          where p.maKH == maID
                          //  orderby tbl_dstaikhoan.matk
                          select p).FirstOrDefault();


                if (rs != null)
                {
                    rs.maKH = this.maID;//= this.txtma.Text;
                    rs.tenKH = this.tenKH;//= this.txtten.Text;
                    rs.diachiKH = this.diachiKH;// = this.txtdiachi.Text;
                    rs.masothueKH = this.MaKH;// = txtmasothue.Text;
                                                    //      rs.dienthoaiNVT = this.dienthoai;//= txtdienthoai.Text;
                    rs.dienthoai = this.dienthoai;// = txttaikhoannganhangso.Text;
                    rs.ghichu = this.ghichu;// = txtdiachitaikhoannganhang.Text;



                    db.SubmitChanges();
                    this.Close();
                }



            }









        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnew_Click(object sender, EventArgs e)
        {


            this.maID = this.txtma.Text;
            this.tenKH = this.txtten.Text;
            this.diachiKH = this.txtdiachi.Text;
            this.MaKH = txtmakhachhang.Text;
            //   this.dienthoai = txtdienthoai.Text;
            this.dienthoai = txttaikhoannganhangso.Text;
            this.ghichu = txtdiachitaikhoannganhang.Text;



            if (maID == "")
            {
                MessageBox.Show("Bạn chưa có mã nhà cung cấp", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chon = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            tbl_MKT_khachhang p = new tbl_MKT_khachhang();

            p.maKH = this.maID;//= this.txtma.Text;
            p.tenKH = this.tenKH;//= this.txtten.Text;
            p.diachiKH = this.diachiKH;// = this.txtdiachi.Text;
            p.masothueKH = this.MaKH;// = txtmasothue.Text;
                                           //   p.dienthoaiNVT = this.dienthoai;//= txtdienthoai.Text;
            p.dienthoai = this.dienthoai;// = txttaikhoannganhangso.Text;
            p.ghichu = this.ghichu;// = txtdiachitaikhoannganhang.Text;





            db.tbl_MKT_khachhangs.InsertOnSubmit(p);
            db.SubmitChanges();
            this.Close();






        }








        private void txtQuocgia_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtdiachi.Focus();


            }
        }



        private void txtNguoidaidien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txttaikhoannganhangso.Focus();


            }
        }



        private void txttennganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtma.Focus();


            }
        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttenkho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtdiachi.Focus();


            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtmakhachhang.Focus();


            }
        }

        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtma.Focus();


            }
        }

        private void txtmasothue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txttaikhoannganhangso.Focus();


            }
        }

        private void txttaikhoannganhangso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtdiachitaikhoannganhang.Focus();


            }
        }

        private void txtdiachitaikhoannganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtma.Focus();


            }
        }
    }


}
