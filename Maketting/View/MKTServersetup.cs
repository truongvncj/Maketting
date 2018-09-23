using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Maketting.View
{
    public partial class MKTServersetup : Form
    {
        public MKTServersetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String current = System.IO.Directory.GetCurrentDirectory();
            Model.SercurityFucntion bm = new Model.SercurityFucntion();
          


            string fileName = current + "\\String.txt";

            if (textBox1.Text != "" && textBox3.Text != "" && textBox2.Text != "")
            {


                //   string[] names = new string[] { "Zara Ali", "Nuha Ali" };
                string s = textBox1.Text + ";" + textBox3.Text + ";" + textBox2.Text + ";" + textBox4.Text;

                Model.SercurityFucntion bm2 = new Model.SercurityFucntion();
                string s2 = bm2.Encryption(s);

                bm2.WritestringtoFile(fileName, s2);



                this.Close();
                //  MessageBox.Show(s);
            }
        }

        private void Serversetup_Deactivate(object sender, EventArgs e)
        {
            //    this.Close();
        }
    }
}
