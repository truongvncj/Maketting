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
    public partial class MKTViewselectchannel : Form
    {

        //    public string Valuechoose { get; set; }

        public string kqstring { get; set; }
        public int id { get; set; }

        public string username  { get; set; }



    //  IQueryable rs, LinqtoSQLDataContext d
    public MKTViewselectchannel()
        {
            InitializeComponent();

            label7.Text = "Select one or more channel ";

            this.username = Utils.getusername();



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            Model.MKT.DeleteALLChannelTMP(dc);


            var channelist = from pp in dc.tbl_MKT_CustomerChanels
                             select pp;
            foreach (var item in channelist)
            {
                tbl_MKT_CustomerChaneltmp newchanel = new tbl_MKT_CustomerChaneltmp();

                newchanel.Chanel_code = item.Chanel_code;
                newchanel.Chanel_name = item.Chanel_name;
                newchanel.Note = item.Note;
                newchanel.Select_channel = false;
                newchanel.ID = item.id;
                newchanel.username = username;
                dc.tbl_MKT_CustomerChaneltmps.InsertOnSubmit(newchanel);
                dc.SubmitChanges();


            }
            var channelisttmp = from pp in dc.tbl_MKT_CustomerChaneltmps
                                where pp.username == username
                                select pp;



            this.dataGridView1.DataSource = channelisttmp;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["username"].Visible = false;
            //   Valuechoose = "";
            kqstring = "";



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


            //            kqstring = "";

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

        private void btaddnew_Click(object sender, EventArgs e)
        {

            //Sanpham











        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colheadertext = this.dataGridView1.Columns[this.dataGridView1.CurrentCell.ColumnIndex].HeaderText;

            //      bbb



            if (colheadertext == "Select channel")// nếu kích ô Select_channel 
            {



                if (dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["ID"].Value != null && dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["Select_channel"].Value != null)
                {
                    int indexID = int.Parse(dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString());


                    bool currentvalue = (bool)dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["Select_channel"].Value;

                    dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                    dataGridView1.ReadOnly = false;


                    dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["Select_channel"].Value = !currentvalue;
                    dataGridView1.ReadOnly = true;
                    // upvaof server

                    //update to server

                 //   string username = Utils.getusername();



                    string connection_string = Utils.getConnectionstr();
                    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                    var channelisttmp = from pp in dc.tbl_MKT_CustomerChaneltmps
                                        where pp.ID == indexID
                                        select pp;
                    foreach (var item in channelisttmp)
                    {

                        item.Select_channel = !currentvalue;
                        dc.SubmitChanges();
                    }





                    // update to servwr








                }








            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        //    string username = Utils.getusername();



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var channelisttmp = from pp in dc.tbl_MKT_CustomerChaneltmps
                                where pp.username == username
                                select pp;
            foreach (var item in channelisttmp)
            {

                if (item.Select_channel == true)
                {
                    if (kqstring !="")
                    {
                        this.kqstring = item.Chanel_code + ";" + this.kqstring;
                    }
                    else
                    {
                        this.kqstring = item.Chanel_code;
                    }
                    

                }

            }

            this.Close();
        }
    }
}
