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


    public partial class MKTVTDanhsacchuongtrinhMKT : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }
        public string maCT { get; set; }
        public string tenCT { get; set; }

        public string region { get; set; }
        public string salesorg { get; set; }
        public string channelgroup { get; set; }

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


        public MKTVTDanhsacchuongtrinhMKT(int lainghiepvu, int id) // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            InitializeComponent();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            chon = false;

            // list region
            List<ComboboxItem> listRegion = new List<ComboboxItem>();

            var regionlist = from pp in dc.tbl_MKT_Regions

                             select pp;
            foreach (var item2 in regionlist)
            {
                ComboboxItem cb = new ComboboxItem();
                cb.Value = item2.Region;
                cb.Text = item2.Region + ": " + item2.Note.Trim();
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
            cbsales_org.DataSource = listSaleOrg;
            //   cbSaleOrg.SelectedIndex = 0;





            this.id = id;

            if (lainghiepvu == 4) // xóa + sua
            {
                this.btnew.Visible = false;
                //  this.txtmaNCC.Text = makhachhang;

                txtma.Enabled = false;


               


                var item = (from p in dc.tbl_MKT_IO_Programes
                            where p.id == id
                            select p).FirstOrDefault();

                if (item != null)
                {


                    txtma.Text = item.macT;
                    txtten.Text = item.tenCT;

                    // txtdienthoai.Text = item.dienthoaiNVT;
                 

                    txtghichu.Text = item.ghichu;

                    cbregion.Text = item.Region;// 
                    cbsales_org.Text = item.Sales_Org;
                    txtchannelgroup.Text = item.ChannelGroup;

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

            this.maCT = this.txtma.Text;
            this.tenCT = this.txtten.Text;

            this.ghichu = txtghichu.Text;

            this.salesorg = (cbsales_org.SelectedItem as ComboboxItem).Value.ToString();
            this.region = (cbregion.SelectedItem as ComboboxItem).Value.ToString();

            this.channelgroup = txtchannelgroup.Text;


            if (maCT == "")
            {
                MessageBox.Show("Bạn chưa có mã nhà chương trình", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbsales_org.Text == "")
            {
                MessageBox.Show("Bạn chưa có mã sales Org", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbregion.Text == "")
            {
                MessageBox.Show("Bạn chưa có mã Region", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtchannelgroup.Text == "")
            {
                MessageBox.Show("Bạn chưa có channel ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (maCT != "")
            {
                chon = true;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

                //   tbl_dstaikhoan tk = new tbl_dstaikhoan();


                //    MeasureItemEventArgs.re
                var rs = (from p in db.tbl_MKT_IO_Programes
                          where p.macT == maCT
                          //  orderby tbl_dstaikhoan.matk
                          select p).FirstOrDefault();


                if (rs != null)
                {
                    rs.macT = this.maCT;//= this.txtma.Text;
                    rs.tenCT = this.tenCT;//= this.txtten.Text;
              
                    rs.ghichu = this.ghichu;// = txtdiachitaikhoannganhang.Text;
                    rs.Region = this.region;
                    rs.Sales_Org = this.salesorg;
                    rs.ChannelGroup = this.channelgroup;


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


            this.maCT = this.txtma.Text;
            this.tenCT = this.txtten.Text;
      
            this.ghichu = txtghichu.Text;

            this.salesorg = (cbsales_org.SelectedItem as ComboboxItem).Value.ToString();
            this.region = (cbregion.SelectedItem as ComboboxItem).Value.ToString();

            this.channelgroup = txtchannelgroup.Text;


            if (maCT == "")
            {
                MessageBox.Show("Bạn chưa có mã chương trình", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbsales_org.Text == "")
            {
                MessageBox.Show("Bạn chưa có mã sales Org", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbregion.Text == "")
            {
                MessageBox.Show("Bạn chưa có mã Region", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtchannelgroup.Text == "")
            {
                MessageBox.Show("Bạn chưa có channel ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            chon = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            tbl_MKT_IO_Programe p = new tbl_MKT_IO_Programe();

            p.macT = this.maCT;//= this.txtma.Text;
            p.tenCT = this.tenCT;//= this.txtten.Text;
       
            p.ghichu = this.ghichu;// = txtdiachitaikhoannganhang.Text;


            p.Region = this.region;
            p.Sales_Org = this.salesorg;
            p.ChannelGroup = this.channelgroup;


            db.tbl_MKT_IO_Programes.InsertOnSubmit(p);
            db.SubmitChanges();
            this.Close();






        }








        private void txtQuocgia_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }



        private void txtNguoidaidien_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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


                cbregion.Focus();


            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
           
        }

        private void txttaikhoannganhangso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtghichu.Focus();


            }
        }

        private void txtdiachitaikhoannganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtma.Focus();


            }
        }

        private void cbregion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                cbsales_org.Focus();


            }
        }

        private void cbsales_org_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtghichu.Focus();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.MKTViewselectchannel accsup = new MKTViewselectchannel();
            accsup.ShowDialog();
            txtchannelgroup.Text = accsup.kqstring;
        }
    }


}
