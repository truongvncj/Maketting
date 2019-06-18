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
    public partial class MKTstoredeviceforRegion : Form
    {
        public float Region_Budgeted;
        public float addingamount;
        public float balance;
        public bool kq;
        public string Region;
        public string Regionnote;
        public string materialcode;
        public string materialname;
        public string storelocation;
        public int rowindex;

        public DataGridView datagridview;

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }



        public MKTstoredeviceforRegion(String storelocation, String materialcode, String materialname, float balance, float Region_Budgeted, List<ComboboxItem> CombomCollection, DataGridView datagridview, int rowindex)
        {
            InitializeComponent();

            lbstore.Text = storelocation;
            lbitemcode.Text = materialcode;
            lbmaterialname.Text = materialname;
            lbbalance.Text = balance.ToString();
            this.balance = balance;
            this.materialcode = materialcode;
            this.storelocation = storelocation;
            this.materialname = materialname;
            cbregion.DataSource = CombomCollection;
            this.kq = false;
            this.rowindex = rowindex;

            this.datagridview = datagridview;

            this.Region_Budgeted = Region_Budgeted;









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


                    if (addingamount < 0)
                    {
                        MessageBox.Show("Adding amount must be a greater than zezo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (addingamount > this.balance)
                    {
                        MessageBox.Show("Adding amount must be a less than balance !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    this.addingamount = addingamount;
                }
                catch (Exception)
                {

                    MessageBox.Show("Adding amount must be a interger number !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }



            // chia budget

            #region giảm budget region

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            string username = Utils.getusername();

            tbl_MKT_StockendRegionBudget newregionupdate = new tbl_MKT_StockendRegionBudget();

            newregionupdate.ITEM_Code = materialcode;
            newregionupdate.SAP_CODE = materialcode;
            newregionupdate.MATERIAL = materialname;
            //       newregionupdate.Description = (string)dataGridViewDetail.Rows[idrow].Cells["Description"].Value;
            newregionupdate.Region = this.Region;// Model.Username.getuseRegion();
            newregionupdate.QuantityInputbyPO = 0;// Math.Round((float)dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value * (float)item.inputRate);
            newregionupdate.QuantityInputbyReturn = 0;// (float)dataGridViewLoaddetail.Rows[idrow].Cells["Return_Quantity"].Value;// 0;
            newregionupdate.QuantityOutput = 0;// (float)dataGridViewDetail.Rows[idrow].Cells["Issue_Quantity"].Value;// 0;
            newregionupdate.QuantitybyDevice = this.addingamount;
            // newregionupdate.Note = item.n;
            newregionupdate.Regionchangedate = DateTime.Today;
            newregionupdate.Store_code = this.storelocation;

            dc.tbl_MKT_StockendRegionBudgets.InsertOnSubmit(newregionupdate);
            dc.SubmitChanges();


            #endregion




            //chia nudget

            //if (this.kq == true)
            //{
            this.Close();
            //     this.id = (int)this.dataGridViewLoaddetail.Rows[e.RowIndex].Cells["id"].Value;
            //     this.balance = float.Parse(this.dataGridViewLoaddetail.Rows[e.RowIndex].Cells["Balance"].Value.ToString());

            //}
            //      datagridview.Columns["END_STOCK"].ReadOnly = true;
            //       datagridview.Columns["Region_Budgeted"].ReadOnly = true;
            //       datagridview.Columns["Balance"].ReadOnly = true;
            //   this.datagridview.Rows[rowindex].Cells["Region_Budgeted"].ReadOnly = false;
            //      this.datagridview.Rows[rowindex].Cells["Balance"].ReadOnly = false;
            this.datagridview.Rows[rowindex].Cells["Region_Budgeted"].Value = this.Region_Budgeted + this.addingamount;
            this.datagridview.Rows[rowindex].Cells["Balance"].Value = this.balance - this.addingamount;

            //   DataGridViewColumn col = new DataGridViewTextBoxColumn();
            //    col.HeaderText = this.Region;

            try
            {
                if (this.datagridview.Rows[rowindex].Cells[this.Region].Value == null)
                {
                    //     this.datagridview.Rows[rowindex].Cells[this.Region].Value = 0;
                    this.datagridview.Rows[rowindex].Cells[this.Region].Value = this.addingamount;
                }
                else
                {
                    this.datagridview.Rows[rowindex].Cells[this.Region].Value = this.addingamount + float.Parse(this.datagridview.Rows[rowindex].Cells[this.Region].Value.ToString());

                }

            }
            catch (Exception)
            {

                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                //         cell.Value = "0";
                //  cell.
                col.CellTemplate = cell;

                col.HeaderText = this.Region;
                col.Name = this.Region;
                col.Visible = true;
                datagridview.Columns.Add(col);


                this.datagridview.Rows[rowindex].Cells[this.Region].Value = this.addingamount;

                //  throw;
            }



            //     this.datagridview.Rows[rowindex].Cells["Region_Budgeted"].ReadOnly = true;
            //    this.datagridview.Rows[rowindex].Cells["Balance"].ReadOnly = true;

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
