﻿using Maketting.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Maketting.View
{
    public partial class MKTNhaphangtheoPOredeviceforRegion : Form
    {
        public int statusphieu { get; set; } // mới  // 2 suawra // 3 display //

        public int subID { get; set; }
        public int id { get; set; }

        public string POnumber { get; set; }

        // public string soload { get; set; }
        public string storelocation { get; set; }
        public string Username { get; set; }
        public string Createdby { get; set; }
        //   public float totalinput { get; set; }


        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        public void Loaddetailphieunhapregion()
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            string urs = Utils.getusername();





            var rs = from pp in dc.tbl_MKT_StockendRegionBudgets
                     where pp.POnumber == this.POnumber
                     //    && pp.id == this.id
                       && pp.idsub == this.subID
                     select new
                     {
                         pp.id,
                         pp.Region,
                         //    pp.POnumber,
                         pp.Store_code,
                         pp.Note,
                         pp.SAP_CODE,
                         pp.ITEM_Code,
                         pp.MATERIAL,
                        // pp.UNIT,
                         Reciepted_Quantity = pp.QuantityInputbyPO,



                     };

            if (rs.Count() > 0)
            {
                //  dataGridViewLoaddetail.DataSource = rs;

                //     this.soload = rs.FirstOrDefault().Maketting_load;
                this.storelocation = rs.FirstOrDefault().Store_code;
                //    dateNgaynhaphang.Value = rs.FirstOrDefault().; DateTime.Today;
                Utils ut = new Utils();
                DataTable dataTable = ut.ToDataTable(dc, rs);
                dataTable.Columns.Add(new DataColumn("New_Reciept_Quantity", typeof(float)));


                dataGridViewLoaddetail.DataSource = dataTable;

                dataGridViewLoaddetail.Columns["id"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Region"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Store_code"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Note"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["SAP_CODE"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["ITEM_Code"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["MATERIAL"].ReadOnly = true;
           //     dataGridViewLoaddetail.Columns["UNIT"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Reciepted_Quantity"].ReadOnly = true;

                //    dataGridViewLoaddetail.Columns["ID"].Visible = false;


                dataGridViewLoaddetail.Columns["id"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Region"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Store_code"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Note"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["SAP_CODE"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["ITEM_Code"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["MATERIAL"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
           //     dataGridViewLoaddetail.Columns["UNIT"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Reciepted_Quantity"].DefaultCellStyle.BackColor = Color.LightSkyBlue;


            }


            //dataGridViewTkCo.Columns["Mã_chi_tiết"].DisplayIndex = 1;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].Width = 100;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].ReadOnly = true;
            //dataGridViewTkCo.Columns["Mã_chi_tiết"].DefaultCellStyle.BackColor = Color.LightGray;







        }






        void Control_KeyPress(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.F3)
            {





                //FormCollection fc = System.Windows.Forms.Application.OpenForms;

                //bool kq = false;
                //foreach (Form frm in fc)
                //{
                //    if (frm.Text == "BeeSeach")


                //    {
                //        kq = true;
                //        frm.Focus();

                //    }
                //}

                //if (!kq)
                //{
                //    //  View.BeeSeachtwofield sheaching = new BeeSeachtwofield(this, "Người nôp", "Địa chỉ", "Nội dung");
                //    // sheaching.Show();
                //}




            }


            if (e.Control == true && e.KeyCode == Keys.N)
            {





                //FormCollection fc = System.Windows.Forms.Application.OpenForms;

                //bool kq = false;
                //foreach (Form frm in fc)
                //{
                //    if (frm.Text == "BeeHtoansocaidoiung")


                //    {
                //        kq = true;
                //        frm.Focus();

                //    }
                //}

                //if (!kq)
                //{
                //    //   View.BeeHtoansocaiphieuchi BeeHtoansocaidoiung = new BeeHtoansocaiphieuchi(this, "Địa chỉ", "", "");
                //    //   BeeHtoansocaidoiung.Show();
                //}




            }


        }

        public View.Main main1;

        public MKTNhaphangtheoPOredeviceforRegion(string POnumber, int id, int subid)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);  // để đọc từ bàn phím phím tắt

            this.POnumber = POnumber;
            this.id = id;
            this.subID = subid;



            this.Username = Utils.getusername();
            this.Createdby = Utils.getname();
            this.POnumber = POnumber;
       

            txtPonumber.Text = POnumber;



            datecreated.Value = DateTime.Today;

       //     txtdnnumbar.Text = "";
            btluu.Enabled = true;
            //btinphieu.Enabled = false;

        
            Loaddetailphieunhapregion();


            dataGridViewLoaddetail.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



            this.Close();
            //    main1.clearpannel();
            //    View.Beemainload main = new Beemainload(main1);

            //    main1.clearpannelload(main);
        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
              
                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void datepickngayphieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // datepickngayphieu.
                e.Handled = true;
                //   txttenNVT.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }




        }

        private void cbtennguoinop_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cbtennguoinop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //txttenNVT.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void cbdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbdiengiai_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cbsotien_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //txtsochungtugoc.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }

        }

        private void cbsochungtugoc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                datecreated.Focus();
                //  datepickngayphieu
                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void cbtkno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  e.Handled = true;
                //  cbtaikhoanco.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void cbtaikhoanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  e.Handled = true;
                //   datepickngayphieu.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }



        private void button1_Click(object sender, EventArgs e)  // new phieu 
        {

            bool checkdetail = true;
            //if (txtdnnumbar.Text == "")
            //{


            //    MessageBox.Show("Please input DN Number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    checkdetail = false;

            //    return;
            //}
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //   string urs = Utils.getusername();


            #region // detail
            for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)

            {

                dataGridViewLoaddetail.Rows[idrow].Cells["New_Reciept_Quantity"].Style.BackColor = System.Drawing.Color.White;
                if (dataGridViewLoaddetail.Rows[idrow].Cells["New_Reciept_Quantity"].Value == DBNull.Value)
                {
                    dataGridViewLoaddetail.Rows[idrow].Cells["New_Reciept_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                    MessageBox.Show("Số lượng hàng nhập chia lại chưa input, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkdetail = false;

                    return;


                }

                if (dataGridViewLoaddetail.Rows[idrow].Cells["New_Reciept_Quantity"].Value != DBNull.Value)
                {
                    #region kiểm tra tổng số hàng của 3 sản phẩm đó ở đã chia đúng chưa 1 tổng = tổng thực nhập là đuowjc
                    float tongduocchiacuasanpham = 0;
                    for (int idrow2 = 0; idrow2 < dataGridViewLoaddetail.RowCount; idrow2++)

                    {
                        if (dataGridViewLoaddetail.Rows[idrow2].Cells["ITEM_Code"].Value.ToString().Trim() == dataGridViewLoaddetail.Rows[idrow].Cells["ITEM_Code"].Value.ToString().Trim())
                        {

                            tongduocchiacuasanpham = tongduocchiacuasanpham + (float)dataGridViewLoaddetail.Rows[idrow2].Cells["New_Reciept_Quantity"].Value;

                        }


                    }
                
                    float sothucnhan = (float)(from pp in dc.tbl_MKt_WHstoreissues
                             where pp.POnumber == this.POnumber
                                   && pp.MateriaItemcode == dataGridViewLoaddetail.Rows[idrow].Cells["ITEM_Code"].Value.ToString()
                               && pp.IssueIDsub == this.subID
                             select pp.RecieptQuantity).Sum();



                    if (sothucnhan != tongduocchiacuasanpham)
                    {
                        dataGridViewLoaddetail.Rows[idrow].Cells["New_Reciept_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                        MessageBox.Show("Thực nhận: "+ sothucnhan.ToString() +" khác tổng số nhận sau khi chia lại :  " + tongduocchiacuasanpham.ToString() + "  please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        checkdetail = false;

                        return;
                    }
                    



                    #endregion
                  

                }



            }


            #endregion





            

            if (checkdetail)
            {
                btluu.Enabled = false;
            //    btinphieu.Enabled = true;
               

                for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)
                {
                    if (dataGridViewLoaddetail.Rows[idrow].Cells["id"].Value != DBNull.Value)
                    {
                        //     string Material_SAP_code = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_SAP_code"].Value;

                        int idthis = (int)dataGridViewLoaddetail.Rows[idrow].Cells["id"].Value;

                        #region  update po detail




                        var rs = from pp in dc.tbl_MKT_StockendRegionBudgets
                                 where pp.id  == idthis
                              
                                 select pp;

                        if (rs.Count() > 0)
                        {
                            foreach (var item in rs)
                            {


                                item.QuantityInputbyPO = Math.Round((float)dataGridViewLoaddetail.Rows[idrow].Cells["New_Reciept_Quantity"].Value);

                             //   item.re = item.RecieptedQuantity + Math.Round((float)dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value * (float)item.inputRate);
                              //  item.BalanceQuantity = item.QuantityOrder - item.RecieptedQuantity;
                                dc.SubmitChanges();




                            }


                        }

                        #endregion





                    }
                }




                MessageBox.Show("Done ! " , "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }


        }

        private void dataGridViewListphieuthu_Paint(object sender, PaintEventArgs e)
        {

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            //foreach (var c in dataGridViewListphieu.Columns)
            //{
            //    DataGridViewColumn clm = (DataGridViewColumn)c;
            //    clm.HeaderText = clm.HeaderText.Replace("_", " ");
            //}

            // Next





        }

        private void cbtkno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            //var rs = from tbl_Kafuctionlist in db.tbl_Kafuctionlists
            //         where tbl_Kafuctionlist.Code != "DIS"
            //         orderby tbl_Kafuctionlist.Code
            //         select tbl_Kafuctionlist;
            //foreach (var item2 in rs)
            //{
            //    ComboboxItem cb = new ComboboxItem();
            //    cb.Value = item2.Code.Trim();
            //    cb.Text = item2.Code.Trim() + ": " + item2.Description.Trim() + "    || Example: " + item2.Example;
            //    CombomCollection.Add(cb);
            //}

            //  string taikhoan = (cbtkco.SelectedItem as ComboboxItem).Value.ToString();
            //     this.matk = taikhoan;




            //    dataGridViewTkCo.Focus();

        }


        private void cbtaikhoanco_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    dataGridViewTkCo.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Model.MKT.restatusphieuLoadingtoCRT();

            //   this.cleartoblankphieu();

            //    Model.MKT.DeleteALLphieutamTMP();

            //    this.soload = Model.MKT.getLoadNo();
            //     txtloadnumber.Text = this.soload;


        }

        private void button5_Click(object sender, EventArgs e)
        {

          

        }

        private void dataGridViewListphieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          

        }

        private void dataGridViewListphieuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxoa_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.statusphieu = 2;

            btluu.Enabled = true;


            datecreated.Enabled = true;





            btluu.Enabled = true;

            //   cbtaikhoanco.Enabled = true;


            this.statusphieu = 2;

        }

        private void txtsophieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txttennguoinop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //txttenNVT.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtdiengiai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //  txtsotien.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtsotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //txtsochungtugoc.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtsochungtugoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //cbtkco.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void bthachtoan_Click(object sender, EventArgs e)
        {


            FormCollection fc = System.Windows.Forms.Application.OpenForms;

            bool kq = false;
            foreach (Form frm in fc)
            {
                if (frm.Text == "BeeHtoansocaidoiung")


                {
                    kq = true;
                    frm.Focus();

                }
            }

            if (!kq)
            {
                //   View.BeeHtoansocaiphieuchi BeeHtoansocaidoiung = new BeeHtoansocaiphieuchi(this, "Địa chỉ", "", "");
                //    BeeHtoansocaidoiung.ShowDialog();
            }



        }

        private void txtsotien_TextChanged(object sender, EventArgs e)
        {

            //if (Utils.IsValidnumber(txtsotien.Text.ToString()))
            //{
            //    this.pssotienno = double.Parse(txtsotien.Text);
            //   // txtsotien.Text = pssotienno.pssotienno
            //}
            ////else
            //{
            //    txtsotien.Text = "";
            //}



        }

        private void txtsochungtugoc_TextChanged(object sender, EventArgs e)
        {
            //if (! Utils.IsValidnumber(txtsochungtugoc.Text.ToString()))
            //{
            //    txtsochungtugoc.Text = "";
            //}

        }

        private void dataGridViewTkCo_Paint(object sender, PaintEventArgs e)
        {

            ////   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            ////  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            //foreach (var c in dataGridViewDetail.Columns)
            //{
            //    DataGridViewColumn clm = (DataGridViewColumn)c;
            //    clm.HeaderText = clm.HeaderText.Replace("_", " ");
            //}

            //// Next

        }


        private void dataGridViewTkCo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (e.Control is ComboBox)
            //{

            //    cbm = (ComboBox)e.Control;

            //    if (cbm != null)
            //    {
            //        cbm.SelectedIndexChanged += new EventHandler(cbm_SelectedIndexChanged);
            //    }


            //    currentCell = this.dataGridViewDetail.CurrentCell;




            //}
        }

        private void txtquyenso_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                //txtsophieu.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }




        }

        private void dataGridViewTkCo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView view = (DataGridView)sender;
            int i = e.RowIndex;
            string colname = view.Columns[e.ColumnIndex].Name;

            //       #region if la slect tai khoan co chi tiet

            if (colname == "Tk_Nợ")
            {


                //  string SelectedItem = view.Rows[i].Cells["Tk_Có"].Value.ToString();


            }


            //   if (colname == "Số_tiền")
            //   {


            //  string SelectedItem = view.Rows[i].Cells["Tk_Có"].Value.ToString();








        }

        private void dataGridViewTkCo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //  addDEtailPhieuMKT


        }

        private void dataGridViewTkCo_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridViewTkCo_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridViewTkCo_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

        }

        private void dataGridViewTkCo_DataError_1(object sender, DataGridViewDataErrorEventArgs anError)
        {



            //String errortext = "Lỗi dữ liệu nhập vào ";


            //if (anError.Context == DataGridViewDataErrorContexts.Commit)
            //{
            //    errortext = "Dữ liệu nhập vào không phù hợp";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            //{
            //    errortext = "Lỗi khi sửa dữ liệu ô";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            //{
            //    errortext = "Lỗi khi chuyển kiểu dữ liệu";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            //{
            //    errortext = "Lỗi khi chuyển ô ";
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.Formatting)
            //{
            //    errortext = "Loại dữ liệu nhập vào không đúng";
            //}


            //MessageBox.Show("Lỗi :" + errortext, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //if ((anError.Exception) is ConstraintException)
            //{
            //    DataGridView view = (DataGridView)sender;
            //    view.Rows[anError.RowIndex].ErrorText = "";
            //    view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "";

            //    anError.ThrowException = false;
            //}


        }

        private void dataGridViewTkCo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {



        }

        private void txtsotienco_TextChanged(object sender, EventArgs e)
        {



        }

        private void dataGridViewTkNo_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            //#region  view lai cac tk có

            //String tkcotext = "";


            //int dem = 0;
            //for (int idrow = 0; idrow < dataGridViewTkNo.RowCount - 1; idrow++)
            //{

            //    if (dataGridViewTkNo.Rows[idrow].Cells["Tk_Nợ"].Value != DBNull.Value)
            //    {



            //        dem = dem + 1;
            //        if (dem > 1)
            //        {

            //            tkcotext += ";" + dataGridViewTkNo.Rows[idrow].Cells["Tk_Nợ"].Value.ToString().Trim(); // chính la program

            //        }
            //        else
            //        {
            //            tkcotext += dataGridViewTkNo.Rows[idrow].Cells["Tk_Nợ"].Value.ToString().Trim(); // chính la program
            //                                                                                             //dataGridViewTkCo.Columns["Số_tiền"].DisplayIndex = 3;


            //        }


            //    }


            //}

            //txttaikhoanno.Text = tkcotext;
            //#endregion


            //#region  view lai cac tk nợ


            //double tongcong = 0;


            //for (int idrow = 0; idrow < dataGridViewTkNo.RowCount - 1; idrow++)
            //{


            //    if (dataGridViewTkNo.Rows[idrow].Cells["Số_tiền"].Value != DBNull.Value)

            //    {
            //        if (Utils.IsValidnumber(dataGridViewTkNo.Rows[idrow].Cells["Số_tiền"].Value.ToString()))
            //        {

            //            tongcong += double.Parse(dataGridViewTkNo.Rows[idrow].Cells["Số_tiền"].Value.ToString());
            //        }
            //    }







            //}

            ////txtValueSotienCo.Text = tongcong.ToString();
            //this.pssotienno = tongcong;
            //txtsotienno.Text = tongcong.ToString("#,#", CultureInfo.InvariantCulture);
            //#endregion



        }

        private void txtsotien_Leave(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbtkco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //    string taikhoan = (cbtkco.SelectedItem as ComboboxItem).Value.ToString();
            //     this.matk = taikhoan;




        }

        //private void dataGridViewListphieuchi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{


        //    //var rs = from pp in dc.tbl_MKt_ListLoadheads
        //    //         where pp.ShippingPoint == this.storelocation //pp.Status == "CRT" && 
        //    //         select new
        //    //         {
        //    //             Date = pp.Date_Created,

        //    //             pp.LoadNumber,
        //    //             pp.ShippingPoint,


        //    //             pp.Status,
        //    //             pp.TransposterCode,
        //    //             pp.TransposterName,

        //    //             Created_by = pp.Username,
        //    //             pp.id,

        //    //         };


        //    string shipmentfind = "";
        //    string ShippingPointfind = "";

        //    string connection_string = Utils.getConnectionstr();

        //    //btluu.Enabled = false;
        //    //btsua.Enabled = true;
        //    //btmoi.Enabled = false;


        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //    try
        //    {
        //        shipmentfind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["LoadNumber"].Value.ToString();
        //        ShippingPointfind = this.dataGridViewListphieu.Rows[e.RowIndex].Cells["ShippingPoint"].Value.ToString();

        //    }
        //    catch (Exception)
        //    {
        //        //    MessageBox.Show(ex.ToString());
        //        //     this.phieuchiid = 0;
        //    }

        //    #region loaddead so phieu va location
        //    #region // head 
        //    //    tbl_MKt_Listphieuhead headphieu = new tbl_MKt_Listphieuhead();

        //    var rs = (from pp in dc.tbl_MKt_ListLoadheads
        //              where pp.LoadNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

        //              select pp).FirstOrDefault();

        //    if (rs != null)
        //    {
        //        this.soload = shipmentfind;
        //        txtloadnumber.Text = this.soload;


        //        datecreated.Value = (DateTime)rs.Date_Created;// = ;

        //        this.storelocation = rs.ShippingPoint;// = ;




        //        ////  cbkhohang.Items
        //        //foreach (ComboboxItem item in (List<ComboboxItem>)cbkhohang.DataSource)
        //        //{
        //        //    if (item.Value.ToString().Trim() == rs.ShippingPoint.Trim())
        //        //    {
        //        //        cbkhohang.SelectedItem = item;
        //        //    }
        //        //}

        //        //txtnguoitaoload.Text = rs.Created_by;// = ;
        //        //                                     //   rs.Status = "CRT";
        //        //txtloadnumber.Text = this.soload;




        //    }


        //    #endregion


        //    #endregion
        //    //     public void addDEtailLoad(tbl_MKt_Listphieu PhieuMKT)
        //    //{
        //    dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);

        //    #region load detail so phieu va loacation
        //    var rs2 = from pp in dc.tbl_MKt_Listphieus
        //              where pp.ShipmentNumber == shipmentfind && pp.ShippingPoint == ShippingPointfind

        //              select pp;

        //    if (rs2.Count() > 0)
        //    {
        //        ///cleartoblankDEtailphieu();
        //        foreach (var item in rs2)
        //        {
        //            addDEtailLoad(item);



        //        }

        //    }

        //    #endregion

        //    tabControl1.SelectedTab = tabPage1;
        //}

        private void txtsotien_TextChanged_1(object sender, EventArgs e)
        {







        }

        private void dataGridViewListphieuchi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //dt.Columns.Add(new DataColumn("Material_code", typeof(string)));
            //dt.Columns.Add(new DataColumn("SAP_Code", typeof(string)));
            //dt.Columns.Add(new DataColumn("Description", typeof(string)));
            //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(int)));










        }

        private void dataGridViewDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDetail_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabIndex == 1) //  tao phieu

            {


                //    dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);

            }

            //if (tabControl1.TabIndex == 2) //  Danh sách phiếu

            //{
            //    // string valueinput = cb_customerka.Text;

            //    string connection_string = Utils.getConnectionstr();
            //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //    string username = Utils.getusername();


            //    var rs = from pp in dc.tbl_MKt_ListLoadheads
            //             where pp.ShippingPoint == this.storelocation && pp.Status == "CRT"
            //             select new
            //             {
            //                 Date = pp.Date_Created,

            //                 pp.LoadNumber,
            //                 pp.ShippingPoint,


            //                 pp.Status,
            //                 pp.TransposterCode,
            //                 pp.TransposterName,

            //                 Created_by = pp.Username,
            //                 pp.id,

            //             };
            //    dataGridViewListphieu.DataSource = rs;





            //}
        }

        private void dataGridViewDetail_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridViewDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{



        }

        private void cbkhohang_SelectedValueChanged(object sender, EventArgs e)
        {
            //this.storelocation = (cbkhohang.SelectedItem as ComboboxItem).Value.ToString();

            //cleartoblankphieu();


        }

        private void txtmucdich_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void btmucdich_Click(object sender, EventArgs e)
        {
            //    NPDanhsachnhavantai
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.DanhsachctMKT(dc);


            Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH CHƯƠNG TRÌNH MAKETTING", 13, "MKT_CT");// mã 13 là danh sach CT MKT

            viewtbl.Show();





        }

        private void btcustomer_Click(object sender, EventArgs e)
        {

            //    NPDanhsachnhavantai
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = Model.MKT.DanhsachnhavantaiMKT(dc);
            Viewtable viewtbl = new Viewtable(rs1, dc, "DANH SÁCH NHÀ VẬN TẢI", 14, "MKT_nvt");// mã 14 là danh sach nha van tai  MKT

            viewtbl.Show();




        }

        private void txtmucdichname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            //   bool kq = Model.MKT.Deletephieuload(this.soload, this.storelocation);
            Model.MKT.restatusphieuLoadingtoCRT();

            //  Model.MKT.DeleteALLphieutamTMP();

            //dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);
            dataGridViewLoaddetail = Model.MKT.Getbankdetailload(dataGridViewLoaddetail);




            MessageBox.Show("Delete " + this.POnumber.ToString() + " done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void txtnguoinhan_KeyPress(object sender, KeyPressEventArgs e)
        {







            //  }
        }

        private void dataGridViewDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //     addDEtailPhieuMKT
            //string gatepassfind = "";

            //string connection_string = Utils.getConnectionstr();

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //try
            //{
            //    gatepassfind = this.dataGridViewDetail.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return;
            //}



            ////DataTable dt = new DataTable();


            ////dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Address", typeof(string)));

            //var rs = from pp in dc.tbl_MKt_Listphieus
            //         where pp.Gate_pass == gatepassfind && pp.ShippingPoint == this.storelocation && pp.Status == "CRT"

            //         select pp;

            //if (rs != null)
            //{
            //    foreach (var item in rs)
            //    {
            //        item.Status = "LOADING";
            //        dc.SubmitChanges();

            //        addDEtailLoad(item);
            //    }



            //}

            //dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);




        }

        private void dataGridViewLoaddetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLoaddetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string gatepassfind = "";

            //string connection_string = Utils.getConnectionstr();

            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //try
            //{
            //    gatepassfind = this.dataGridViewLoaddetail.Rows[e.RowIndex].Cells["Gate_pass"].Value.ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return;
            //}



            ////DataTable dt = new DataTable();


            ////dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            ////dt.Columns.Add(new DataColumn("Address", typeof(string)));

            //var rs = from pp in dc.tbl_MKt_Listphieus
            //         where pp.Gate_pass == gatepassfind && pp.ShippingPoint == this.storelocation //&& pp.Status == "LOADING"

            //         select pp;

            //if (rs != null)
            //{
            //    foreach (var item in rs)
            //    {
            //        RemoveDEtailLoad(item);
            //        item.Status = "CRT";
            //        dc.SubmitChanges();


            //    }



            //}

            //dataGridViewDetail.DataSource = Model.MKT.DanhsachPhieuMKTtoDLV(this.storelocation);




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //   string username = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rptMKT = from pp in dc.tbl_MKT_headRpt_Phieuissues
                         where pp.Username == this.Username
                         select pp;

            dc.tbl_MKT_headRpt_Phieuissues.DeleteAllOnSubmit(rptMKT);
            dc.SubmitChanges();


            var rptMKTdetail = from pp in dc.tbl_MKT_DetailRpt_Phieuissues
                               where pp.Username == this.Username
                               select pp;

            dc.tbl_MKT_DetailRpt_Phieuissues.DeleteAllOnSubmit(rptMKTdetail);
            dc.SubmitChanges();

            var rptMKThead = from pp in dc.tbl_MKt_Listphieuheads
                                 //    where pp.LoadNumber == this.soload && pp.ShippingPoint == this.storelocation
                             select pp;

            if (rptMKThead.Count() > 0)
            {

                foreach (var item in rptMKThead)
                {


                    tbl_MKT_headRpt_Phieuissue headpx = new tbl_MKT_headRpt_Phieuissue();

                    headpx.Diachi = item.Address;
                    headpx.Nguoinhancode = item.Customer_SAP_Code.ToString();
                    headpx.Username = this.Username;
                    headpx.Sophieu = item.Gate_pass;
                    headpx.Nguoinhanname = item.Receiver_by;
                    headpx.seri = this.storelocation + item.Gate_pass;

                    BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                    BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                    //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                    Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(this.storelocation + item.Gate_pass), 1, true), typeof(Byte[]));

                    headpx.Barcode = result;
                    headpx.dienthoai = item.Tel;
                    headpx.mucdich = item.Purpose;
                    headpx.Ngaythang = item.Ngaytaophieu;
                    headpx.Nguoiyeucau = item.Requested_by;



                    dc.tbl_MKT_headRpt_Phieuissues.InsertOnSubmit(headpx);
                    dc.SubmitChanges();
                }
            }



            var rptMKTdetailmk = from pp in dc.tbl_MKt_Listphieudetails
                                     //     where pp.ShipmentNumber == this.soload && pp.ShippingPoint == this.storelocation
                                 orderby pp.Gate_pass
                                 select pp;
            int i = 0;
            string lastgatepass = "";
            foreach (var item in rptMKTdetailmk)
            {
                if (lastgatepass != item.Gate_pass)
                {
                    i = 1;
                }
                else
                {
                    i = i + 1;
                }


                tbl_MKT_DetailRpt_Phieuissue detailpx = new tbl_MKT_DetailRpt_Phieuissue();

                detailpx.stt = i.ToString();
                detailpx.soluong = item.Issued;
                detailpx.Username = this.Username;
                detailpx.tensanpham = item.Materialname;
                detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.Issued.ToString()));
                detailpx.Sophieu = item.Gate_pass;
                lastgatepass = item.Gate_pass;
                dc.tbl_MKT_DetailRpt_Phieuissues.InsertOnSubmit(detailpx);
                dc.SubmitChanges();

            }

            var rshead = from pp in dc.tbl_MKT_headRpt_Phieuissues
                         where pp.Username == this.Username
                         //orderby pp.Sophieu
                         select new
                         {

                             //   username = pp.Username,
                             Nguoiyeucau = pp.Nguoiyeucau,
                             Ngaythang = pp.Ngaythang,
                             Sophieu = pp.Sophieu,
                             Nguoinhancode = pp.Nguoinhancode,
                             Nguoinhanname = pp.Nguoinhanname,
                             Diachi = pp.Diachi,
                             mucdich = pp.mucdich,

                             dienthoai = pp.dienthoai,
                             seri = pp.seri,
                             Barcode = pp.Barcode


                         };
            Utils ut = new Utils();
            var dataset1 = ut.ToDataTable(dc, rshead); // head

            //View.Viewtable vx1 = new Viewtable(rshead, dc, "test", 100, "100");
            //vx1.ShowDialog();
            var rsdetail = from pp in dc.tbl_MKT_DetailRpt_Phieuissues
                           where pp.Username == this.Username
                           orderby pp.Sophieu, pp.stt
                           select new
                           {

                               stt = pp.stt,
                               tensanpham = pp.tensanpham,
                               Sophieu = pp.Sophieu,
                               soluong = pp.soluong,
                               //   username = pp.Username,
                               bangchu = pp.bangchu,

                           };

            //View.Viewtable vx = new Viewtable(rsdetail,dc,"test",100,"100");
            //vx.ShowDialog();


            var dataset2 = ut.ToDataTable(dc, rsdetail); // detail


            Reportsview rpt = new Reportsview(dataset1, dataset2, "PhieuMKTlistbyLoad.rdlc");
            rpt.ShowDialog();

            //}

            //#endregion view reports payment request  // 
        }

        private void txtseachgate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;


                //          txtseachaddress.Text = "";
                //        txtseachcode.Text = "";
                //       txtseachgate.Text
                //  this.storelocation
                //    dataGridViewDetail

                //    Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);


            }




        }

        private void txtseachcode_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtseachaddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewLoaddetail_Paint(object sender, PaintEventArgs e)
        {

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridViewLoaddetail.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

            // Next


        }
    }

}
