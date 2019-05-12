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
    public partial class MKTFromdateandRegion : Form
    {

        public DateTime Ondate { get; set; }
        public string region { get; set; }
    
        public bool chon { get; set; }



        public MKTFromdateandRegion()
        {
            InitializeComponent();

            List<View.MKTselectStoreandRegion.ComboboxItem> CombomCollection2 = new List<View.MKTselectStoreandRegion.ComboboxItem>();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            ///
            //       string username = Utils.getusername();
            //     string rightkho = Model.Username.getmaquyenkho();


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
            fromdatepicker.Value = DateTime.Today;
            //todatepicker.Value = DateTime.Today;
            this.Ondate = fromdatepicker.Value;
           // cbstatusphieu.SelectedIndex = 0;
        //    this.ststusphieu = cbstatusphieu.SelectedValue.ToString();

            this.region = "";// (cbselect2.SelectedItem as View.MKTselectStoreandRegion.ComboboxItem).Value.ToString();
            chon = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {



            //   this.ststusphieu = cbstatusphieu.SelectedValue.ToString();
            chon = true;
        

            if (cbselect2 != null && cbselect2.SelectedValue != null)  // update prograne -- cai nay 
            {
                this.region = (cbselect2.SelectedItem as View.MKTselectStoreandRegion.ComboboxItem).Value.ToString();
             
            }
            else
            {

                chon = false;
                MessageBox.Show("Please select a Region !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //   return;
            }

        


            if (chon == true)
            {
                //;
                this.Close();
            }

        }

        private void Datepick_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbselect2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
