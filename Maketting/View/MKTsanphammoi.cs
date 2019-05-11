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


    public partial class MKTsanphammoi : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }
        public string itemcode { get; set; }
        public string sapcode { get; set; }
        public string materialname { get; set; }

        public float QuantityPerPallet { get; set; }

        public string storelocation { get; set; }
        //   public string tenkho { get; set; }

        public Viewtable Fromviewable;
        public string unit { get; set; }


        public string description { get; set; }


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


        public MKTsanphammoi(int loai, int idsanpham, string storelocation, Viewtable Fromviewable) // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            InitializeComponent();
            this.Fromviewable = Fromviewable;
            this.storelocation = storelocation;
            chon = false;
            //    cbkhohang
            txtstorelocation.Text = storelocation;
            txtstorelocation.Enabled = false;
            this.storelocation = storelocation;

            this.id = idsanpham;
            if (loai == 2) // xóa + sua
            {
                this.btnew.Visible = false;
                this.btxoa.Visible = false;
                //  this.txtmaNCC.Text = makhachhang;
                //txtitemcode.Text = idsanpham.ToString();
                //      txtitemcode.Enabled = false;
                ///





                //      string connection_string = Utils.getConnectionstr();
                //      LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
                LinqtoSQLDataContext dc = this.Fromviewable.dc;


                var item = (from p in dc.tbl_MKT_Stockends
                            where p.id == idsanpham
                            select p).FirstOrDefault();

                if (item != null)
                {
                    //    txttondaukysoluong.Text = item.tondksoluong.ToString();
                    //    txtthanhtienton.Text = item.tondkthanhtien.ToString();

                    //txtitemcode.Text = item.ITEM_Code;
                    txttensanpham.Text = item.MATERIAL;

                  

                    txtsapcode.Text = item.SAP_CODE;
                    //   txtsapcode.Enabled = false;

                    txtdescription.Text = item.Description;
                    txtItemcode.Text = item.ITEM_Code;

                    if (txtItemcode.Text == "")
                    {
                        txtItemcode.Text = item.SAP_CODE;
                    }

                    txtunit.Text = item.UNIT;

                    txtsapcode.Enabled = false;

                 //   txtstorelocation.Text = item.Store_code;
                   // txtunit.Text = item.UNIT;
                   // txtdescription.Text = item.Description;
                   // txtItemcode.Text = item.ITEM_Code;
                    txtQuantityPerPallet.Text = item.Quantity_Per_Pallet.ToString();




                }


            }


            if (loai == 4) // xóa + sua
            {
                this.btnew.Visible = false;
                //  this.txtmaNCC.Text = makhachhang;
                //txtitemcode.Text = idsanpham.ToString();
                //      txtitemcode.Enabled = false;
                ///





                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

             

                var item = (from p in dc.tbl_MKT_Stockends
                            where p.id == idsanpham
                            select p).FirstOrDefault();

                if (item != null)
                {
                    //    txttondaukysoluong.Text = item.tondksoluong.ToString();
                    //    txtthanhtienton.Text = item.tondkthanhtien.ToString();

                    //txtitemcode.Text = item.ITEM_Code;
                    txttensanpham.Text = item.MATERIAL;


                    txtsapcode.Text = item.SAP_CODE;


                    txtstorelocation.Text = item.Store_code;
                    txtunit.Text = item.UNIT;
                    txtdescription.Text = item.Description;
                    txtItemcode.Text = item.ITEM_Code;
                    txtQuantityPerPallet.Text = item.Quantity_Per_Pallet.ToString();



                }


            }






            if (loai == 3) // tạo mới
            {
                this.btupdate.Visible = false;
                this.btxoa.Visible = false;





            }




        }

        private void txtCustcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtsapcode.Focus();


            }



        }






        private void btxoa_Click(object sender, EventArgs e)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            var rs1 = (from p in dc.tbl_MKT_Stockends
                       where p.id == this.id
                       select p).FirstOrDefault();

            if (rs1 != null)
            {

                dc.tbl_MKT_Stockends.DeleteOnSubmit(rs1);
                dc.SubmitChanges();
                this.Close();


            }




        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            //


            //     this.id = idsanpham;

            this.itemcode = this.txtItemcode.Text;
            this.materialname = this.txttensanpham.Text;


            this.sapcode = txtsapcode.Text;
            this.unit = txtunit.Text;
            this.description = txtdescription.Text;

          
          
          


            //  this.ghichu = txtghichu.Text;

            //if (cbkhohang.SelectedItem != null)
            //{
            //    this.makho = (string)(cbkhohang.SelectedItem as ComboboxItem).Value;// (cbm.SelectedItem as ComboboxItem).Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Kiểm tra kho hàng!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}


            //this.tenkho = (string)(cbkhohang.SelectedItem as ComboboxItem).Text;




            if (Utils.IsValidnumber(txtQuantityPerPallet.Text) == false)
            {
                MessageBox.Show("Bạn chưa có số sản phẩm để xếp đủ 1 pallet của sản phẩm này !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantityPerPallet.Focus();

                return;
            }

            this.QuantityPerPallet = float.Parse(txtQuantityPerPallet.Text);



            if (itemcode == "")
            {
                MessageBox.Show("Bạn chưa có mã sản phẩm", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (itemcode != "")
            {
                chon = true;
                //        string connection_string = Utils.getConnectionstr();
                //        LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);
                LinqtoSQLDataContext db = this.Fromviewable.dc;
                //   tbl_dstaikhoan tk = new tbl_dstaikhoan();


                //    MeasureItemEventArgs.re
                var rs = (from p in db.tbl_MKT_Stockends
                          where p.id == this.id
                          //  orderby tbl_dstaikhoan.matk
                          select p).FirstOrDefault();


                if (rs != null)
                {

                    rs.ITEM_Code = this.itemcode;// = this.txtmaNCC.Text;
                    rs.MATERIAL = this.materialname;// this.txttenNCC.Text;

                    rs.Description = this.description;
                    rs.Quantity_Per_Pallet = this.QuantityPerPallet;
                    rs.End_Stock_By_Pallet = rs.END_STOCK * (1 / this.QuantityPerPallet);
                    rs.SAP_CODE = this.sapcode;
                    rs.UNIT = this.unit;
                    rs.Store_code = this.storelocation;


                    db.SubmitChanges();
                    
            
                    this.Close();

                  

                    //   Fromviewable.Reloadtonkhotheolocation(Fromviewable, this.storelocation);
                }



        //        Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text, this.region, this.statusphieu);




                //Reloadtonkhotheolocation( this.storelocation);

            }









        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnew_Click(object sender, EventArgs e)
        {
            //if (itemcode == "")
            //{
            //    MessageBox.Show("Bạn kiểm tra mã sản phẩm", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            this.description = txtdescription.Text;
            this.sapcode = txtsapcode.Text;
            this.itemcode = txtsapcode.Text;
            this.materialname = this.txttensanpham.Text;
            this.itemcode = txtItemcode.Text;
            this.unit = txtunit.Text;
            this.storelocation = txtstorelocation.Text;


            if (this.sapcode == "")
            {
                MessageBox.Show("Please input SAp code", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.itemcode == "")
            {
                MessageBox.Show("Please input itemcode code", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.materialname == "")
            {
                MessageBox.Show("Please input material name ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.storelocation == "")
            {
                MessageBox.Show("Please input storelocation ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.unit == "")
            {
                MessageBox.Show("Please input unit ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.description == "")
            {
                MessageBox.Show("Please input description ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKT_Stockends
                     where pp.ITEM_Code == this.itemcode
                     select pp;

            if (rs.Count() > 0)
            {

                MessageBox.Show("Mã Item code bị trùng, please check ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            var rs2 = from pp in dc.tbl_MKT_Stockends
                      where pp.SAP_CODE == this.sapcode
                      && pp.ITEM_Code == this.itemcode
                      select pp;

            if (rs2.Count() > 0)
            {

                MessageBox.Show("Mã SAP code bị trùng, please check ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }


            chon = true;

            tbl_MKT_Stockend newproduct = new tbl_MKT_Stockend();

            newproduct.END_STOCK = 0;
            newproduct.SAP_CODE = this.sapcode;
            newproduct.ITEM_Code = this.itemcode;// = this.txtmaNCC.Text;
            newproduct.Description = this.description;
            newproduct.MATERIAL = this.materialname;
            newproduct.Store_code = this.storelocation;

            newproduct.UNIT = this.unit;




            dc.tbl_MKT_Stockends.InsertOnSubmit(newproduct);
            dc.SubmitChanges();
            MessageBox.Show("New Product MKT create done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();






        }








        private void txtQuocgia_TextChanged(object sender, EventArgs e)
        {

        }








        private void txttennganhang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txttensanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtdescription.Focus();


            }

        }

        private void txtmavach_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txttensanpham.Focus();


            }

        }

        private void txtdonvi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //    txttrongluong.Focus();


            }

        }

        private void txttrongluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //   txtkhoiluong.Focus();


            }

        }

        private void txtkhoiluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //   txtnhomsanpham.Focus();


            }

        }

        private void txtnhomsanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //      txtghichu.Focus();


            }

        }

        private void txtghichu_KeyPress_1(object sender, KeyPressEventArgs e)
        {



        }

        private void txtdescription_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtunit.Focus();


            }
        }

        private void txtunit_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
    }


}
