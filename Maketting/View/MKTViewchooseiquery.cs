﻿using Maketting.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Maketting.View
{
    public partial class MKTViewchooseiquery : Form
    {

    //    public string Valuechoose { get; set; }
        public string columhead { get; set; }
        public bool chon { get; set; }
        public int id { get; set; }





        //  IQueryable rs, LinqtoSQLDataContext d
        public MKTViewchooseiquery(IQueryable rs, LinqtoSQLDataContext dc, string fornname, string columhead)
        {
            InitializeComponent();

            label7.Text = fornname;
            this.columhead = columhead;
            //System.Data.DataTable dt = new System.Data.DataTable();
            //dt = tbl;
            this.dataGridView1.DataSource = rs;

         //   Valuechoose = "";
            chon = false;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.RowCount > 0)
            //{




            //    if (this.dataGridView1.CurrentCell.RowIndex >= 0)
            //    {
            //  //      Valuechoose = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[columhead].Value.ToString();
            //     //   region = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Region"].Value.ToString();

            //        chon = true;

            //        this.Close();
            //    }



            //}





        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.RowCount > 0)
                {




                    if (this.dataGridView1.CurrentCell.RowIndex >= 0)
                    {

                        if (this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value != DBNull.Value)
                        {
                            this.id = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value.ToString());

                        }


                        chon = true;

                        this.Close();
                    }

                }



            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        
        }
    }
}