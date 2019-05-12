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
    public partial class MKTFromdateandStoreandRegion : Form
    {
          public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public string store ;
        public string region;
        public bool kq;
  
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }



        public MKTFromdateandStoreandRegion()
        {
            InitializeComponent();

            this.label1.Text = "Please nhập thông tin";

            List<View.MKTFromdateandStoreandRegion.ComboboxItem> CombomCollection2 = new List<View.MKTFromdateandStoreandRegion.ComboboxItem>();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                var rs3 = from pp in dc.tbl_MKT_Regions
                          //  where pp.Region == rightkho
                      select pp;
            foreach (var item2 in rs3)


            {
                View.MKTFromdateandStoreandRegion.ComboboxItem cb = new View.MKTFromdateandStoreandRegion.ComboboxItem();
                cb.Value = item2.Region.Trim();
                cb.Text = item2.Region.Trim() + ": " + item2.Note.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection2.Add(cb);
            }

            cbregion.DataSource = CombomCollection2;
            cbregion.SelectedIndex = 0;

            //----------------
            List<View.MKTFromdateandStoreandRegion.ComboboxItem> CombomCollection1 = new List<View.MKTFromdateandStoreandRegion.ComboboxItem>();

         
            var rs1 = from pp in dc.tbl_MKT_khoMKTs
                          //  where pp.Region == rightkho
                      select pp;
            foreach (var item2 in rs1)


            {
                View.MKTFromdateandStoreandRegion.ComboboxItem cb = new View.MKTFromdateandStoreandRegion.ComboboxItem();
                cb.Value = item2.makho.Trim();
                cb.Text = item2.makho.Trim() + ": " + item2.tenkho.Trim().ToUpper();// + "    || Example: " + item2.Example;
                CombomCollection1.Add(cb);
            }

            cbstore.DataSource = CombomCollection1;
            cbstore.SelectedIndex = 0;


            //------------





            fromdatepicker.Value = DateTime.Today;
            todatepicker.Value = DateTime.Today;
            this.fromdate = fromdatepicker.Value;
            this.todate = todatepicker.Value;

            //cbregion.DataSource = CombomCollection2;
            //cbstore.DataSource = CombomCollection1;
            this.kq = false;

        }

        private void valueinput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //     item.PayType = (cb_program.SelectedItem as ComboboxItem).Value.ToString();

            if (cbstore != null && cbstore.SelectedValue != null)  // update prograne -- cai nay 
            {
            //    this.value1 = (cbstore.SelectedItem as ComboboxItem).Value.ToString();
                this.store = (cbstore.SelectedItem as ComboboxItem).Value.ToString();
                this.kq = true;
             
            }
            else
            {

                this.kq = false;
               MessageBox.Show("Please chọn kho !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbregion != null && cbregion.SelectedValue != null)  // update prograne -- cai nay 
            {
           //     this.value2 = (cbregion.SelectedItem as ComboboxItem).Value.ToString();
                this.region = (cbregion.SelectedItem as ComboboxItem).Value.ToString();
                this.kq = true;
             //   this.Close();

            }
            else
            {

                this.kq = false;
                MessageBox.Show("Please chọn vùng !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (this.fromdate <= this.todate)
            {
                this.fromdate = fromdatepicker.Value;
                this.todate = todatepicker.Value;


            }
            else
            {
                this.kq = false;
                MessageBox.Show("Kiểm tra lại, từ ngày phải nhỏ hơn hoặc bằng đến ngày !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (this.kq == true)
            {
                this.Close();

            }






        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.Focus();
            }

           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.Focus();
            }
        }

        private void cbselect_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                button1.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }
    }
}
