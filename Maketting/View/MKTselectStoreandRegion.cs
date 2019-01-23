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
    public partial class MKTselectStoreandRegion : Form
    {

        public string valuetext1 ;
        public string valuetext2;
        public bool kq;
        public string value1;
        public string value2;

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }



        public MKTselectStoreandRegion(String headcolumname, String label1, String label2, List<ComboboxItem> CombomCollection,  List<ComboboxItem> CombomCollection2)
        {
            InitializeComponent();

            this.label1.Text = headcolumname;

            //List<View.beeselectinput.ComboboxItem> CombomCollection = new List<View.beeselectinput.ComboboxItem>();
            //string connection_string = Utils.getConnectionstr();

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //var rs = from p in dc.tbl_NP_khachhangvanchuyens
            //             //     where p.Code != "DIS"
            //         orderby p.maKH
            //         select p;
            //foreach (var item2 in rs)
            //{
            //    View.beeselectinput.ComboboxItem cb = new View.beeselectinput.ComboboxItem();
            //    cb.Value = item2.maKH.Trim();
            //    cb.Text = item2.maKH.Trim() + ": " + item2.tenKH.Trim();// + "    || Example: " + item2.Example;
            //    CombomCollection.Add(cb);
            //}


            //beeselectinput choosesl = new beeselectinput("Chọn khách hàng vận tải", CombomCollection);
            //choosesl.ShowDialog();
            cbselect2.DataSource = CombomCollection2;
            cbselect.DataSource = CombomCollection;
            this.kq = false;

        }

        private void valueinput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //     item.PayType = (cb_program.SelectedItem as ComboboxItem).Value.ToString();

            if (cbselect != null && cbselect.SelectedValue != null)  // update prograne -- cai nay 
            {
                this.value1 = (cbselect.SelectedItem as ComboboxItem).Value.ToString();
                this.valuetext1 = (cbselect.SelectedItem as ComboboxItem).Text.ToString();
                this.kq = true;
             
            }
            else
            {

                this.kq = false;
              //  MessageBox.Show("Please select a value !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbselect2 != null && cbselect2.SelectedValue != null)  // update prograne -- cai nay 
            {
                this.value2 = (cbselect.SelectedItem as ComboboxItem).Value.ToString();
                this.valuetext2 = (cbselect.SelectedItem as ComboboxItem).Text.ToString();
                this.kq = true;
             //   this.Close();

            }
            else
            {

                this.kq = false;
                //  MessageBox.Show("Please select a value !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
