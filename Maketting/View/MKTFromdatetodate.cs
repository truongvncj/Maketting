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
    public partial class MKTFromdatetodate : Form
    {

        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }

        public bool chon { get; set; }



        public MKTFromdatetodate()
        {
            InitializeComponent();
            fromdatepicker.Value = DateTime.Today;
            todatepicker.Value = DateTime.Today;
            this.fromdate = fromdatepicker.Value;
            this.todate = todatepicker.Value;

            chon = false;
          
        }
    
        private void button1_Click(object sender, EventArgs e)
        {


            this.fromdate = fromdatepicker.Value;
            this.todate = todatepicker.Value;


            if (this.fromdate <= this.todate)
            {
                chon = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại, từ ngày phải nhỏ hơn hoặc bằng đến ngày !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
