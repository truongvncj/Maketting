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
    public partial class BeeCaculating : Form
    {

        public void CloseMyForm()
        {
            this.Close();
        }
        public delegate void CloseFormDelegate();
        public CloseFormDelegate myDelegate;



        public BeeCaculating()
        {
            InitializeComponent();

            myDelegate = new CloseFormDelegate(CloseMyForm);

        }

    

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void Caculating_Load(object sender, EventArgs e)
        {
         //   myDelegate new CloseFormDelegate(closeMyFrom);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
