using System;
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

        public string customername { get; set; }
        //      txtquan.Text = item.District;
        //                 txttinh.Text = item.Province;
        public string street { get; set; }

        public string city { get; set; }
        public string district { get; set; }


        public string Customercode { get; set; }

        //      public string dienthoai { get; set; }
        public string telephone { get; set; }
        public string note { get; set; }

        public bool chon { get; set; }
        public string SalesOrg { get; set; }
        public string Region { get; set; }

      


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

                //     txtidma.Enabled = false;


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



                var item = (from p in dc.tbl_MKT_Soldtocodes
                            where p.id == id
                            select p).FirstOrDefault();

                if (item != null)
                {


                    //      txtidma.Text = item.idCust;
                    txtname.Text = item.FullNameN;
                    txtdistrict.Text = item.District;
                    txtcity.Text = item.City;

                    // txtdienthoai.Text = item.dienthoaiNVT;
                    txtcustomercode.Text = item.Customer;

                    txtstreet.Text = item.Street;





                    txttelephone.Text = item.Telephone1;//  p.ghichunganhnghe  

                    txtnote.Text = item.Note;

                    txtRegion.Text = item.Region;//  p.ghichunganhnghe  

                    txtSalesOrg.Text = item.SalesOrg;



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


                txtname.Focus();


            }



        }

        private void txt_vendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtname.Focus();


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



            var rs1 = (from p in dc.tbl_MKT_Soldtocodes
                       where p.id == this.id
                       select p).FirstOrDefault();

            if (rs1 != null)
            {

                dc.tbl_MKT_Soldtocodes.DeleteOnSubmit(rs1);
                dc.SubmitChanges();
                this.Close();


            }




        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Pleae input the mane !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();

                return;
            }
            if (txtstreet.Text == "")
            {
                MessageBox.Show("Pleae input the Address !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtstreet.Focus();

                return;
            }
            if (txtcity.Text == "")
            {
                MessageBox.Show("Pleae input the Province (Tỉnh/ Thành Phố) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcity.Focus();

                return;
            }
            if (txtdistrict.Text == "")
            {
                MessageBox.Show("Pleae input the District (Quận / Huyện)!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdistrict.Focus();

                return;
            }
            if (txtcustomercode.Text == "")
            {
                MessageBox.Show("Pleae input the Customer Code", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcustomercode.Focus();

                return;
            }

            if (txtSalesOrg.Text == "")
            {
                MessageBox.Show("Pleae input the SalesOrg", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalesOrg.Focus();

                return;
            }
            if (txtRegion.Text == "")
            {
                MessageBox.Show("Pleae input the Region", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegion.Focus();

                return;
            }

            this.Customercode = txtcustomercode.Text;
            this.customername = txtname.Text;
            this.street = txtstreet.Text;
            this.telephone = txttelephone.Text;
            this.note = txtnote.Text;
            this.district = txtdistrict.Text;
            this.city = txtcity.Text;
            this.Region = txtRegion.Text;
            this.SalesOrg = txtSalesOrg.Text;





            //if (maID == "")
            //{
            //    MessageBox.Show("Bạn chưa có mã khách hàng", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}



            //if (maID != "")
            //{
            chon = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //   tbl_dstaikhoan tk = new tbl_dstaikhoan();


            //    MeasureItemEventArgs.re
            var rs = (from p in db.tbl_MKT_Soldtocodes
                      where p.id == this.id
                      //  orderby tbl_dstaikhoan.matk
                      select p).FirstOrDefault();


            if (rs != null)
            {
                //   rs.idCust = this.maID;//= this.txtma.Text;
                rs.FullNameN = this.customername;//= this.txtten.Text;
                rs.Street = this.street;// = this.txtdiachi.Text;
                rs.Customer = this.Customercode;// = txtmasothue.Text;
                                             //      rs.dienthoaiNVT = this.dienthoai;//= txtdienthoai.Text;
                rs.Telephone1 = this.telephone;// = txttaikhoannganhangso.Text;
                rs.Note = this.note;// = txtdiachitaikhoannganhang.Text;

                rs.District = this.district;// = txtquan.Text;
                rs.City = this.city;// = txttinh.Text;
                rs.SalesOrg = this.SalesOrg;
                rs.Region = this.Region;


                db.SubmitChanges();
                this.Close();
            }



            //    }









        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnew_Click(object sender, EventArgs e)
        {

            if (txtname.Text == "")
            {
                MessageBox.Show("Pleae input the mane !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
             
                return;
            }
            if (txtstreet.Text == "")
            {
                MessageBox.Show("Pleae input the Address !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtstreet.Focus();

                return;
            }
            if (txtcity.Text == "")
            {
                MessageBox.Show("Pleae input the Province (Tỉnh/ Thành Phố) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcity.Focus();

                return;
            }
            if (txtdistrict.Text == "")
            {
                MessageBox.Show("Pleae input the District (Quận / Huyện)!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdistrict.Focus();

                return;
            }
            if (txtcustomercode.Text == "")
            {
                MessageBox.Show("Pleae input the Customer Code", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcustomercode.Focus();

                return;
            }


            this.customername = this.txtname.Text;
            this.street = this.txtstreet.Text;
            this.Customercode = txtcustomercode.Text;
            this.city = txtcity.Text;
            this.district = txtdistrict.Text;

            this.telephone = txttelephone.Text;
            this.note = txtnote.Text;

            this.Region = txtSalesOrg.Text;
            this.SalesOrg = txtSalesOrg.Text;




            chon = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            tbl_MKT_Soldtocode p = new tbl_MKT_Soldtocode();

            //       p.idCust = this.maID;//= this.txtma.Text;
            p.FullNameN = this.customername;//= this.txtten.Text;
            p.Street = this.street;// = this.txtdiachi.Text;
            p.Customer = this.Customercode;// = txtmasothue.Text;
                                        //   p.dienthoaiNVT = this.dienthoai;//= txtdienthoai.Text;
            p.Telephone1 = this.telephone;// = txttaikhoannganhangso.Text;
            p.Note = this.note;// = txtdiachitaikhoannganhang.Text;
            p.District = this.district;// = txtdiachitaikhoannganhang.Text;
            p.City = this.city;// = txtdiachitaikhoannganhang.Text;

            p.SalesOrg = this.SalesOrg;// = txtdiachitaikhoannganhang.Text;
            p.Region = this.Region;// = txtdiachitaikhoannganhang.Text;



            db.tbl_MKT_Soldtocodes.InsertOnSubmit(p);
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


                txtstreet.Focus();


            }
        }



        private void txtNguoidaidien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txttelephone.Focus();


            }
        }



        private void txttennganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{


            //    txtidma.Focus();


            //}
        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttenkho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtstreet.Focus();


            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtdistrict.Focus();


            }
        }

        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{


            //    txtidma.Focus();


            //}
        }

        private void txtmasothue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtname.Focus();


            }
        }

        private void txttaikhoannganhangso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtnote.Focus();


            }
        }

        private void txtdiachitaikhoannganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtcustomercode.Focus();


            }
        }

        private void txtquan_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtcity.Focus();


            }

        }

        private void txttinh_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txttelephone.Focus();


            }

        }
    }


}
