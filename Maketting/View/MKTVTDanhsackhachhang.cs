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
        public string SaleRegion { get; set; }

      public string channel { get; set; }


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

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);




            // list channel

            List<ComboboxItem> itemstorecolect = new List<ComboboxItem>();

            var channelll = from pp in dc.tbl_MKT_CustomerChanels
                    
                      select pp;
            foreach (var item2 in channelll)
            {
                ComboboxItem cb = new ComboboxItem();
                cb.Value = item2.Chanel_code.Trim();
                cb.Text = item2.Chanel_code.Trim() + ": " + item2.Chanel_name.Trim();
                itemstorecolect.Add(cb);

                //  cbkhohang.Items.Add(cb);
                //  CombomCollection.Add(cb);
            }
            cbchannel.DataSource = itemstorecolect;
        //    cbchannel.SelectedIndex = 0;

            // list region
            List<ComboboxItem> listRegion = new List<ComboboxItem>();

            var regionlist = from pp in dc.tbl_MKT_Regions

                            select pp;
            foreach (var item2 in regionlist)
            {
                ComboboxItem cb = new ComboboxItem();
                cb.Value = item2.Region;
                cb.Text = item2.Region +": " + item2.Note.Trim();
                listRegion.Add(cb);

                //  cbkhohang.Items.Add(cb);
                //  CombomCollection.Add(cb);
            }
            cbregion.DataSource = listRegion;
          //  cbregion.SelectedIndex = 0;


            //list saleorrge

        //    cbSaleOrg

                    List<ComboboxItem> listSaleOrg = new List<ComboboxItem>();

            var SaleOrglist = from pp in dc.tbl_MKT_SaleOrgs

                             select pp;
            foreach (var item2 in SaleOrglist)
            {
                ComboboxItem cb = new ComboboxItem();
                cb.Value = item2.SaleOrg;
                cb.Text = item2.SaleOrg + ": " + item2.Note.Trim();
                listSaleOrg.Add(cb);

                //  cbkhohang.Items.Add(cb);
                //  CombomCollection.Add(cb);
            }
            cbSaleOrg.DataSource = listSaleOrg;
         //   cbSaleOrg.SelectedIndex = 0;




            this.id = id;

            if (lainghiepvu == 4) // xóa + sua
            {
                this.btnew.Visible = false;
                //  this.txtmaNCC.Text = makhachhang;

                //     txtidma.Enabled = false;



                var item = (from p in dc.tbl_MKT_Soldtocodes
                            where p.id == id
                            select p).FirstOrDefault();

                if (item != null)
                {

                    txtname.Text = item.FullNameN;
                    txtdistrict.Text = item.District;
                    cbcity.Text = item.City;
                    txtcustomercode.Text = item.Customer;

                    txtstreet.Text = item.Street;
                    txttelephone.Text = item.Telephone1;
                    txtnote.Text = item.Note;

                    cbregion.Text = item.Region;// 
                    cbSaleOrg.Text = item.SalesOrg;
                    cbchannel.Text = item.Chanel;


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
            if (cbcity.Text == "")
            {
                MessageBox.Show("Pleae input the Province (Tỉnh/ Thành Phố) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcity.Focus();

                return;
            }


            if (cbchannel.Text == "")
            {
                MessageBox.Show("Pleae input the channel", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbchannel.Focus();

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

            if (cbSaleOrg.Text == "")
            {
                MessageBox.Show("Pleae input the SalesOrg", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSaleOrg.Focus();

                return;
            }
            if (cbregion.Text == "")
            {
                MessageBox.Show("Pleae input the Region", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbregion.Focus();

                return;
            }

            if (!Utils.IsValidnumber(txtcustomercode.Text.ToString().Trim()))
            {
                MessageBox.Show("Pleae check, customer code must be a number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcustomercode.Focus();

                return;
            }

            this.Customercode = txtcustomercode.Text.ToString().Trim().Truncate(50);
            this.customername = txtname.Text.Truncate(225);
            this.street = txtstreet.Text.Truncate(225);
            this.telephone = txttelephone.Text.Truncate(50);
            this.note = txtnote.Text.Truncate(225);
            this.district = txtdistrict.Text.Truncate(50);
            this.city = cbcity.Text.Truncate(50);
            this.SaleRegion = (cbregion.SelectedItem as ComboboxItem).Value.ToString();
            this.SalesOrg =  (cbSaleOrg.SelectedItem as ComboboxItem).Value.ToString();
            this.channel =  (cbchannel.SelectedItem as ComboboxItem).Value.ToString();




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
                rs.Region = this.SaleRegion;

                rs.Chanel = this.channel;
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
            if (cbcity.Text == "")
            {
                MessageBox.Show("Pleae input the Province (Tỉnh/ Thành Phố) !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcity.Focus();

                return;
            }

            if (cbchannel.Text == "")
            {
                MessageBox.Show("Pleae input channel ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbchannel.Focus();

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

            if (!Utils.IsValidnumber(txtcustomercode.Text.ToString().Trim()))
            {
                MessageBox.Show("Pleae check, customer code must be a number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcustomercode.Focus();

                return;
            }


            this.customername = this.txtname.Text.ToString().Trim().Truncate(225);
         
            this.street = this.txtstreet.Text.Truncate(225);
            this.Customercode = txtcustomercode.Text.Truncate(50);
            this.city = cbcity.Text.Truncate(50);
            this.district = txtdistrict.Text.Truncate(50);

            this.telephone = txttelephone.Text.Truncate(50);
            this.note = txtnote.Text.Truncate(225);

            this.SaleRegion = (cbregion.SelectedItem as ComboboxItem).Value.ToString();
            this.SalesOrg =  (cbSaleOrg.SelectedItem as ComboboxItem).Value.ToString();

            this.channel =  (cbchannel.SelectedItem as ComboboxItem).Value.ToString();


            chon = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            tbl_MKT_Soldtocode p = new tbl_MKT_Soldtocode();

            //       p.idCust = this.maID;//= this.txtma.Text;
            p.FullNameN = this.customername;//= this.txtten.Text;
            p.Street = this.street;// = this.txtdiachi.Text;
            p.Customer = this.Customercode;// = txtmasothue.Text;
            p.ShiptoCode = this.Customercode;// = txtmasothue.Text;
                                           //   p.dienthoaiNVT = this.dienthoai;//= txtdienthoai.Text;
            p.Telephone1 = this.telephone;// = txttaikhoannganhangso.Text;
            p.Note = this.note;// = txtdiachitaikhoannganhang.Text;
            p.District = this.district;// = txtdiachitaikhoannganhang.Text;
            p.City = this.city;// = txtdiachitaikhoannganhang.Text;

            p.SalesOrg = this.SalesOrg;// = txtdiachitaikhoannganhang.Text;
            p.Region = this.SaleRegion;// = txtdiachitaikhoannganhang.Text;
            p.Soldtype = true;
            p.Createdon = DateTime.Today;
            p.Createby = Model.Username.getUsername();
            p.Chanel = this.channel;// = txtdiachitaikhoannganhang.Text;

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


                cbcity.Focus();


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
