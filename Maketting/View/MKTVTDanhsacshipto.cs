using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maketting.shared;

namespace Maketting.View
{


    public partial class MKTVTDanhsacshipto : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }

        public string customername { get; set; }
      
        //      txtquan.Text = item.District;
        //                 txttinh.Text = item.Province;
        public string street { get; set; }

        public string city { get; set; }
        public string district { get; set; }

        public string shiptocode { get; set; }

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


        public MKTVTDanhsacshipto(int lainghiepvu, int id, string customercode) // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            InitializeComponent();

            chon = false;
            txtcustomercode.Text = customercode;
            txtcustomercode.Enabled = false;



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
                    txtShiptocode.Text = item.ShiptoCode;

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

            if (txtShiptocode.Text == "")
            {
                MessageBox.Show("Pleae input the Shipto Code", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiptocode.Focus();

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

            if (!Utils.IsValidnumber(txtShiptocode.Text.ToString().Trim()))
            {
                MessageBox.Show("Please check, ship to code must be a number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiptocode.Focus();

                return;
            }

            if (!Utils.IsValidnumber(txtcustomercode.Text.ToString().Trim()))
            {
                MessageBox.Show("Please check, Customer code must be a number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiptocode.Focus();

                return;
            }

            this.customername = this.txtname.Text.ToString().Trim().Truncate(225);
            this.shiptocode = this.txtShiptocode.Text.ToString().Trim().Truncate(50);
            this.street = txtstreet.Text;
            this.telephone = txttelephone.Text;
            this.note = txtnote.Text;
            this.district = txtdistrict.Text;
            this.city = txtcity.Text;
            this.Region = txtRegion.Text;
            this.SalesOrg = txtSalesOrg.Text;
            this.Customercode = txtcustomercode.Text.ToString().Trim().Truncate(50); 




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
                rs.ShiptoCode = this.shiptocode;

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
            if (txtShiptocode.Text == "")
            {
                MessageBox.Show("Pleae input the Shipto  Code", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiptocode.Focus();

                return;
            }

            if (!Utils.IsValidnumber(txtShiptocode.Text.ToString().Trim()) )
            {
                MessageBox.Show("Please check, ship to code must be a number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiptocode.Focus();

                return;
            }

            if (!Utils.IsValidnumber(txtcustomercode.Text.ToString().Trim()))
            {
                MessageBox.Show("Please check, Customer code must be a number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiptocode.Focus();

                return;
            }

            this.customername = this.txtname.Text.ToString().Trim().Truncate(225);
            this.shiptocode = this.txtShiptocode.Text.ToString().Trim().Truncate(50);

            this.street = this.txtstreet.Text.Truncate(225);
            this.Customercode = txtcustomercode.Text.Truncate(50);
            this.city = txtcity.Text.Truncate(50);
            this.district = txtdistrict.Text.Truncate(50);

            this.telephone = txttelephone.Text.Truncate(50);
            this.note = txtnote.Text.Truncate(225);

            this.Region = txtSalesOrg.Text.Truncate(50);
            this.SalesOrg = txtSalesOrg.Text.Truncate(50);




            chon = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            tbl_MKT_Soldtocode p = new tbl_MKT_Soldtocode();

            //       p.idCust = this.maID;//= this.txtma.Text;
            p.FullNameN = this.customername;//= this.txtten.Text;
            p.Street = this.street;// = this.txtdiachi.Text;
            p.Customer = this.Customercode;// = txtmasothue.Text;
            p.ShiptoCode = this.shiptocode;// = txtmasothue.Text;
                                           //   p.dienthoaiNVT = this.dienthoai;//= txtdienthoai.Text;
            p.Telephone1 = this.telephone;// = txttaikhoannganhangso.Text;
            p.Note = this.note;// = txtdiachitaikhoannganhang.Text;
            p.District = this.district;// = txtdiachitaikhoannganhang.Text;
            p.City = this.city;// = txtdiachitaikhoannganhang.Text;

            p.SalesOrg = this.SalesOrg;// = txtdiachitaikhoannganhang.Text;
            p.Region = this.Region;// = txtdiachitaikhoannganhang.Text;
            p.Soldtype = false;
            p.Createdon = DateTime.Today;
            p.Createby = Model.Username.getUsername();


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
