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
    public partial class MKTvalueinput : Form
    {

        public string valuetext ;
        public bool kq;
        public string field;
        public MKTvalueinput(String headcolumname)
        {
            InitializeComponent();

            this.label1.Text = headcolumname;
            this.kq = false;

        }

        private void valueinput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.valuetext = textBox1.Text;
            this.field = this.label1.Text;
            this.kq = true;
            this.Hide();




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
    }
}
