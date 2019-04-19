using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maketting.View
{
    public partial class SeachphieuMKT : Form
    {
        public Viewtable Fromviewable;


        public string tablename;

        public SeachphieuMKT(Viewtable Fromviewable, string tablename)
        {


            InitializeComponent();
            this.Fromviewable = Fromviewable;

            this.tablename = tablename;

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Seachcode_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (tablename == "tblCustomer")
            //{
            //    Fromviewable.Reloadcustomer("");
            //}
            ////if (tablename == "tblFBL5Nnewthisperiod")
            ////{
            ////    Fromviewable.ReloadtblFBL5Nnewthisperiod("");
            //}



        }

        private void Seachcode_Leave(object sender, EventArgs e)
        {

        }

        private void Seachcode_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendingtext_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmktnumber_Enter(object sender, EventArgs e)
        {

        }

        private void txtmktnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {




                if (tablename == "Tìm phiếu MKT")
                {


                    //      static void ReloadPhieuMKTtheoso(DataGridView DataGridView1, string MKTnumber)




                    Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text);
                }



            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {




                if (tablename == "Tìm phiếu MKT")
                {


                    //      static void ReloadPhieuMKTtheoso(DataGridView DataGridView1, string MKTnumber)




                    Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text);
                }



            }
        }
    }
}
