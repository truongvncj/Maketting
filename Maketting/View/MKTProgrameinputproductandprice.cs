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


    public partial class MKTProgrameinputproductandprice : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }
        public string sapcodePOSM { get; set; }
        public string name { get; set; }
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


        public MKTProgrameinputproductandprice() // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            InitializeComponent();

            chon = false;










        }

        private void txtCustcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
                string valueseach = txtposmproduct.Text;

                var rs = from pp in dc.tbl_MKT_Stockends
                         where pp.MATERIAL.Contains(valueseach) || pp.Description.Contains(valueseach) || pp.SAP_CODE.Contains(valueseach) || pp.ITEM_Code.Contains(valueseach)
                         group pp by pp.ITEM_Code into g
                         select new
                         {

                             ITEM_Code = g.Key,
                             SAP_CODE = g.Select(x => x.SAP_CODE.FirstOrDefault()),
                             MATERIAL = g.Select(x => x.MATERIAL.FirstOrDefault()),
                             Description = g.Select(x => x.Description.FirstOrDefault()),
                             UNIT = g.Select(x => x.UNIT.FirstOrDefault()),

                             id = g.Select(x => x.id),

                         };




                if (rs != null)
                {
                    View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT PRODUCTS ", "id");
                    selectkq.ShowDialog();
                    int id = selectkq.id;

                    //dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Description", typeof(string)));
                    //dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

                    //dt.Columns.Add(new DataColumn("Unit", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
                    //dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));


                    var valuechon = (from pp in dc.tbl_MKT_Stockends
                                     where pp.id == id
                                     select pp).FirstOrDefault();

                    if (valuechon != null)
                    {
                        txtsapcode.Text = valuechon.ITEM_Code;
                        txtid.Text = valuechon.id.ToString();
                        txtname.Text = valuechon.MATERIAL;
                        txtdescription.Text = valuechon.Description;
                        txtprice.Focus();
                    }

                }


            }



        }

        private void txt_vendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtprice.Focus();


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





        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            ////




            //this.makho = this.txtmakho.Text;
            //this.nhomkhoright = txtnhomkhoright.Text;




            //if (makho == "")
            //{
            //    MessageBox.Show("Bạn chưa có mã kho", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}



            //if (makho != "")
            //{
            //    chon = true;
            //    string connection_string = Utils.getConnectionstr();
            //    LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);

            //    //   tbl_dstaikhoan tk = new tbl_dstaikhoan();


            //    //    MeasureItemEventArgs.re
            //    var rs = (from p in db.tbl_MKT_StoreRights
            //              where p.makho == makho
            //              //  orderby tbl_dstaikhoan.matk
            //              select p).FirstOrDefault();


            //    if (rs != null)
            //    {

            //        rs.makho = this.makho;// = this.txtmaNCC.Text;
            //  //      rs.tenkho = this.tenkho;// this.txttenNCC.Text;

            //        rs.storeright= this.nhomkhoright;// this.txtMasothue.Text;




            //        db.SubmitChanges();
            //        this.Close();
            //    }



            //}









        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnew_Click(object sender, EventArgs e)
        {





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


                txtposmproduct.Focus();


            }
        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttenkho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtposmproduct.Focus();


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


                txtposmproduct.Focus();


            }
        }
    }


}
