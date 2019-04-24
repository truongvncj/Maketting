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

        public string region { get; set; }
        public string statusphieu { get; set; }

        public LinqtoSQLDataContext dc { get; set; }





        public string tablename;

        public SeachphieuMKT(Viewtable Fromviewable, string tablename)
        {


            InitializeComponent();
            this.Fromviewable = Fromviewable;

            this.tablename = tablename;


            List<View.MKTselectStoreandRegion.ComboboxItem> CombomCollection2 = new List<View.MKTselectStoreandRegion.ComboboxItem>();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            this.dc = dc;
            ///
            //       string username = Utils.getusername();
            //     string rightkho = Model.Username.getmaquyenkho();

            View.MKTselectStoreandRegion.ComboboxItem cb1 = new View.MKTselectStoreandRegion.ComboboxItem();
            cb1.Value = "";
            cb1.Text = "All Regions";// + "    || Example: " + item2.Example;
            CombomCollection2.Add(cb1);

            var rs3 = from pp in dc.tbl_MKT_Regions
                          //  where pp.Region == rightkho
                      select pp;
            foreach (var item2 in rs3)


            {
                View.MKTselectStoreandRegion.ComboboxItem cb = new View.MKTselectStoreandRegion.ComboboxItem();
                cb.Value = item2.Region.Trim();
                cb.Text = item2.Region.Trim() + ": " + item2.Note.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection2.Add(cb);
            }

            cbselect2.DataSource = CombomCollection2;
            cbstatusphieu.SelectedIndex = 0;
            //    this.ststusphieu = cbstatusphieu.SelectedValue.ToString();

            this.region = "";// (cbselect2.SelectedItem as View.MKTselectStoreandRegion.ComboboxItem).Value.ToString();
            this.statusphieu = "";


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




                    Fromviewable.ReloadPhieuMKTtheoso(Fromviewable,  this.txtmktnumber.Text, this.txtname.Text, this.region, this.statusphieu);
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





                    Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text, this.region, this.statusphieu);
                }



            }
        }

        private void cbstatusphieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {




                if (tablename == "Tìm phiếu MKT")
                {


                    //      static void ReloadPhieuMKTtheoso(DataGridView DataGridView1, string MKTnumber)





                    Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text, this.region, this.statusphieu);
                }



            }
        }

        private void cbselect2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {




                if (tablename == "Tìm phiếu MKT")
                {


                    //      static void ReloadPhieuMKTtheoso(DataGridView DataGridView1, string MKTnumber)




                    Fromviewable.ReloadPhieuMKTtheoso(Fromviewable, this.txtmktnumber.Text, this.txtname.Text, this.region, this.statusphieu);
                }



            }
        }

        private void cbselect2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbselect2 != null && cbselect2.SelectedValue != null)  // update prograne -- cai nay 
            {
                this.region = (cbselect2.SelectedItem as View.MKTselectStoreandRegion.ComboboxItem).Value.ToString();

            }



        }

        private void cbstatusphieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbstatusphieu != null && cbstatusphieu.SelectedItem != null)  // update prograne -- cai nay 
            {
                this.statusphieu = cbstatusphieu.GetItemText(cbstatusphieu.SelectedItem);
                if (this.statusphieu == "All")
                {
                    this.statusphieu = "";
                }

                //   ComboBox1.GetItemText(ComboBox1.SelectedItem)
                //  string temp = cboTypeOfMaterial.ValueMember.ToString();
            }
        }
    }
}
