﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maketting.View
{
    public partial class MKTstoredeviceforRegion : Form
    {

        public float addingamount;
        public float balance;
        public bool kq;
        public string Region;
        public string Regionnote;

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }



        public MKTstoredeviceforRegion(String storelocation, String materialcode, String materialname, float balance, List<ComboboxItem> CombomCollection)
        {
            InitializeComponent();

            lbstore.Text = storelocation;
            lbitemcode.Text = materialcode;
            lbmaterialname.Text = materialname;
            lbbalance.Text = balance.ToString();
            this.balance = balance;

            cbregion.DataSource = CombomCollection;
            this.kq = false;














        }

        private void valueinput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //     item.PayType = (cb_program.SelectedItem as ComboboxItem).Value.ToString();



            if (cbregion != null && cbregion.SelectedValue != null)  // update prograne -- cai nay 
            {
                this.Region = (cbregion.SelectedItem as ComboboxItem).Value.ToString();
                this.Regionnote = (cbregion.SelectedItem as ComboboxItem).Text.ToString();
                this.kq = true;
                //   this.Close();

            }
            else
            {

                this.kq = false;

                return;
                //  MessageBox.Show("Please select a value !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (!Utils.IsValidnumber(tbaddingamount.Text))
            {
                MessageBox.Show("Adding amount must be a number !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Utils.IsValidnumber(tbaddingamount.Text))
            {

                try
                {
                    int addingamount = int.Parse(tbaddingamount.Text);


                    if (addingamount <0 )
                    {
                        MessageBox.Show("Adding amount must be a greater than zezo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (addingamount > this.balance )
                    {
                        MessageBox.Show("Adding amount must be a less than balance !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                }
                catch (Exception)
                {

                    MessageBox.Show("Adding amount must be a interger number !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }





            //if (this.kq == true)
            //{
            //    this.Close();

            //}






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
