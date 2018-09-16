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


    public partial class MKTDanhkhoRight : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }
        public string makho { get; set; }
        public string nhomkhoright { get; set; }
    
       
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


        public MKTDanhkhoRight(int loai, int idkho) // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            InitializeComponent();

            chon = false;



            this.id = idkho;

            if (loai == 4) // xóa + sua
            {
                this.btnew.Visible = false;
                //  this.txtmaNCC.Text = makhachhang;

                txtmakho.Enabled = false;


                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



                var item = (from p in dc.tbl_MKT_StoreRights
                            where p.id == idkho
                         select p).FirstOrDefault();

                if (item != null)
                {


                    txtmakho.Text = item.makho;
                  //  txttenkho.Text = item.tenkho;

                 
                    txtnhomkhoright.Text = item.storeright;//  p.masothue  
               
                 //   txtghichu.Text = item.ghichu;//  p.ghichunganhnghe  
                


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


                txtnhomkhoright.Focus();


            }



        }

        private void txt_vendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtnhomkhoright.Focus();


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



            var rs1 = (from p in dc.tbl_MKT_StoreRights
                       where p.id == this.id
                       select p).FirstOrDefault();

            if (rs1 != null)
            {

                dc.tbl_MKT_StoreRights.DeleteOnSubmit(rs1);
                dc.SubmitChanges();
                this.Close();


            }




        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            //




            this.makho = this.txtmakho.Text;
            this.nhomkhoright = txtnhomkhoright.Text;

        
          

            if (makho == "")
            {
                MessageBox.Show("Bạn chưa có mã kho", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (makho != "")
            {
                chon = true;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

                //   tbl_dstaikhoan tk = new tbl_dstaikhoan();


                //    MeasureItemEventArgs.re
                var rs = (from p in db.tbl_MKT_StoreRights
                          where p.makho == makho
                          //  orderby tbl_dstaikhoan.matk
                          select p).FirstOrDefault();


                if (rs != null)
                {

                    rs.makho = this.makho;// = this.txtmaNCC.Text;
              //      rs.tenkho = this.tenkho;// this.txttenNCC.Text;
      
                    rs.storeright= this.nhomkhoright;// this.txtMasothue.Text;
                 
                
             

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


            this.makho = this.txtmakho.Text;
            this.nhomkhoright = txtnhomkhoright.Text;
      //      this.tenkho = this.txtnhomkhoright.Text;

       
        //    this.diachi = this.txtdiachi.Text;
        
        //    this.ghichu = this.txtghichu.Text;
      

            if (makho == "")
            {
                MessageBox.Show("Bạn chưa có mã kho", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chon = true;
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            tbl_MKT_StoreRight p = new tbl_MKT_StoreRight();


            p.makho = this.makho;// = this.txtmaNCC.Text;
        //    p.tenkho = this.tenkho;// this.txttenNCC.Text;

        
          //  p.diachikho = this.diachi;// this.txtMasothue.Text;
        
            p.storeright = this.nhomkhoright;// this.txtNganhnghe.Text;
      
         
            db.tbl_MKT_StoreRights.InsertOnSubmit(p);
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


            //    txtdiachi.Focus();


            }
        }

      

        private void txtNguoidaidien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


          //      txtghichu.Focus();


            }
        }

       

        private void txttennganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtmakho.Focus();


            }
        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttenkho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


            //    txtdiachi.Focus();


            }
        } 

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


           //     txtghichu.Focus();


            }
        }

        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtmakho.Focus();


            }
        }
    }


}
