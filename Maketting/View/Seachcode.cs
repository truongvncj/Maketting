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
    public partial class Seachcode : Form
    {
        public Viewtable Fromviewable;

        public MKTInputchange Fromeditable;
        public string tablename;

        public string varialnew;
        public Seachcode(Viewtable Fromviewable, string tablename, string varialnew)
        {


            InitializeComponent();
            this.Text = tablename;
            this.Fromviewable = Fromviewable;

            this.tablename = tablename;
            this.varialnew = varialnew;
        }


        public Seachcode(MKTInputchange Fromeditable, string tablename)
        {


            //   return false;





            InitializeComponent();


            this.Fromeditable = Fromeditable;

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

        private void sendingtext_Enter(object sender, EventArgs e)
        {

        }

        private void sendingtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {



                if (tablename == "Tìm theo Material Name")
                {


                    Fromviewable.ReloadsanphamKhotheoso(Fromviewable, this.sendingtext.Text, this.varialnew);
                }

                //  tblCustomered

                if (tablename == "tblCustomered")
                {


                    Fromeditable.Reloadeditcustomer(this.sendingtext.Text);
                }


                if (tablename == "tblsales")
                {


                    //      Fromviewable.Reloadsales(this.sendingtext.Text);
                }


                //   tbl_kacontractbegindata
                if (tablename == "tbl_kacontractbegindata")
                {


                    Fromeditable.Reloadtbl_kacontractbegindata(this.sendingtext.Text);
                }
                if (tablename == "tbl_kacontractsdatadetail")
                {


                    Fromeditable.Reloadtbl_kacontractsdatadetail(this.sendingtext.Text);
                }



            }
        }
    }
}
