using Maketting.Control;
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
    public partial class MKTViewchooseiqueryloadtomain : Form
    {

    //    public string Valuechoose { get; set; }
        public string columhead { get; set; }
        public bool chon { get; set; }
        public int id { get; set; }
        public View.Main main1;




        //  IQueryable rs, LinqtoSQLDataContext d
        public MKTViewchooseiqueryloadtomain(View.Main Main,IQueryable rs, LinqtoSQLDataContext dc, string fornname, string columhead)
        {
            InitializeComponent();
            this.main1 = Main;
            label7.Text = fornname;
            this.columhead = columhead;
            //System.Data.DataTable dt = new System.Data.DataTable();
            //dt = tbl;
            this.dataGridView1.DataSource = rs;
            dataGridView1.Columns["id"].Visible = false;
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
          
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (dataGridView1.RowCount > 0)
            //    {




            //        if (this.dataGridView1.CurrentCell.RowIndex >= 0)
            //        {

            //            if (this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value != DBNull.Value)
            //            {
            //                this.id = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["id"].Value.ToString());

            //            }


            //            chon = true;

            //            this.Close();
            //        }

            //    }



            //}

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridView1.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

            // Next
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            main1.clearpannel();
            View.Beemainload main = new Beemainload(main1);

            main1.clearpannelload(main);





        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    //  viewapprobal balance

                    this.Close();
                    main1.clearpannel();

                    View.MKTWHcountaproval main = new MKTWHcountaproval(main1, this.id);

                    main1.clearpannelload(main);



                    //
                }

            }
        }
    }
}
