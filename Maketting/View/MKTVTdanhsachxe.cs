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


    public partial class MKTVTdanhsachxe : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }
        public string _manhavantai { get; set; }
        public string _tenhavantai { get; set; }
        public string _biensoxe { get; set; }


        public float _taitrong { get; set; }
        public float _khoiluong { get; set; }

        public string _hotenlaixe { get; set; }
        public string _sodienthoai { get; set; }
        public string _asochungminhthu { get; set; }
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


    
        private void txtCustcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //   txttensanpham.Focus();


            }



        }






  
   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   






        private void txtQuocgia_TextChanged(object sender, EventArgs e)
        {

        }








        private void txttennganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //     txtmasanpham.Focus();


            }
        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //     txtmasanpham.Focus();


            }
        }

        private void txttensanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                //     txtmavach.Focus();


            }

        }

        private void txtmavach_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //   txtdonvi.Focus();


            }

        }

        private void txtdonvi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txttaitrong.Focus();


            }

        }

        private void txttrongluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtkhoiluong.Focus();


            }

        }

        private void txtkhoiluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                // txtnhomsanpham.Focus();


            }

        }

        private void txtnhomsanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtbienso.Focus();


            }

        }

        private void txtghichu_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                //     txtmasanpham.Focus();


            }

        }
    }


}
