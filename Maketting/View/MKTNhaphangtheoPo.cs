using Maketting.Control;
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
    public partial class MKTNhaphangtheoPo : Form
    {
        public int statusphieu { get; set; } // mới  // 2 suawra // 3 display //

        public int subID { get; set; }
        public string POnumber { get; set; }
        // public string soload { get; set; }
        public string storelocation { get; set; }
        public string Username { get; set; }
        public string Createdby { get; set; }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        public void loaddetailPNK()
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            string urs = Utils.getusername();


            //var rs6 = (from pp in dc.tbl_MKt_POdetail_TMPs
            //           where pp.POnumber == this.PONumber// && pp.StatusPO != "TMP"
            //       
            //           select new
            //           {
            //               MateriaItemcode = gg.Key,
            //               QuantityOrder = gg.Sum(m => m.QuantityOrder),
            //               Description = gg.Select(m => m.Description).FirstOrDefault(),
            //               Materialname = gg.Select(m => m.Materialname).FirstOrDefault(),
            //               MateriaSAPcode = gg.Select(m => m.MateriaSAPcode).FirstOrDefault(),
            //               POnumber = gg.Select(m => m.POnumber).FirstOrDefault(),
            //               //     StatusPO = gg.Select(m => m.StatusPO).FirstOrDefault(),
            //               Storelocation = gg.Select(m => m.Storelocation).FirstOrDefault(),
            //               Unit = gg.Select(m => m.Unit).FirstOrDefault(),
            //               Username = gg.Select(m => m.Username).FirstOrDefault(),

            //               Unit_price = gg.Sum(m => m.Unit_Price * m.QuantityOrder) / gg.Sum(m => m.QuantityOrder),



            //           });
            //var rs = from pp in dc.tbl_MKt_POdetails
            //         where pp.POnumber == this.POnumber
            //         group pp by new
            //         {
            //             pp.MateriaSAPcode,
            //             //   pp.Region
            //         }
            //         into gg


            var rs = from pp in dc.tbl_MKt_POdetails
                     where pp.POnumber == this.POnumber
                     group pp by pp.MateriaItemcode into gg
                     select new
                     {
                         //    ID = pp.id,
                         PO_number = gg.Select(m => m.POnumber).FirstOrDefault(),
                         Shipping_Point = gg.Select(m => m.Storelocation).FirstOrDefault(),
                         Material_SAP_code = gg.Select(m => m.MateriaSAPcode).FirstOrDefault(),
                         Material_Item_code = gg.Key,
                         Material_name = gg.Select(m => m.Materialname).FirstOrDefault(),
                         Order_Quantity = gg.Sum(m => m.QuantityOrder),
                         Reciepted_Quantity = gg.Sum(m => m.RecieptedQuantity),// pp.RecieptedQuantity,
                         //     Real_issue = 0,



                     };

            if (rs.Count() > 0)
            {
                //  dataGridViewLoaddetail.DataSource = rs;

                //     this.soload = rs.FirstOrDefault().Maketting_load;
                this.storelocation = rs.FirstOrDefault().Shipping_Point;

                Utils ut = new Utils();
                DataTable dataTable = ut.ToDataTable(dc, rs);
                dataTable.Columns.Add(new DataColumn("Reciept_Quantity", typeof(float)));


                dataGridViewLoaddetail.DataSource = dataTable;

                //   dataGridViewLoaddetail.Columns["ID"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["PO_number"].ReadOnly = true;

                dataGridViewLoaddetail.Columns["Shipping_Point"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Material_SAP_code"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Material_Item_code"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Material_name"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Order_Quantity"].ReadOnly = true;
                dataGridViewLoaddetail.Columns["Reciepted_Quantity"].ReadOnly = true;

                //    dataGridViewLoaddetail.Columns["ID"].Visible = false;


                //       dataGridViewLoaddetail.Columns["ID"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["PO_number"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Shipping_Point"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Material_SAP_code"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Material_Item_code"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Material_name"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridViewLoaddetail.Columns["Order_Quantity"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
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





                FormCollection fc = System.Windows.Forms.Application.OpenForms;

                bool kq = false;
                foreach (Form frm in fc)
                {
                    if (frm.Text == "BeeSeach")


                    {
                        kq = true;
                        frm.Focus();

                    }
                }

                if (!kq)
                {
                    //  View.BeeSeachtwofield sheaching = new BeeSeachtwofield(this, "Người nôp", "Địa chỉ", "Nội dung");
                    // sheaching.Show();
                }




            }


            if (e.Control == true && e.KeyCode == Keys.N)
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
                    //   BeeHtoansocaidoiung.Show();
                }




            }


        }

        public View.Main main1;

        public MKTNhaphangtheoPo(View.Main Main, string POnumber)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);  // để đọc từ bàn phím phím tắt


            this.main1 = Main;

            this.Username = Utils.getusername();
            this.Createdby = Utils.getname();
            this.POnumber = POnumber;
            txtnguoinhanhang.Text = "";


            txtnguoinhanhang.Text = Utils.getname();


            txtPonumber.Text = POnumber;



            datecreated.Value = DateTime.Today;
            dateNgaynhaphang.Value = DateTime.Today;
            txtdnnumbar.Text = "";


            loaddetailPNK();

            btluu.Enabled = true;
            btinphieu.Enabled = false;

            txtstorelocation.Text = this.storelocation;
            dataGridViewLoaddetail.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            main1.clearpannel();
            View.Beemainload main = new Beemainload(main1);

            main1.clearpannelload(main);
        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txtnguoinhanhang.Focus();

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
            if (txtdnnumbar.Text == "")
            {


                MessageBox.Show("Please input DN Number !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkdetail = false;

                return;
            }


            #region // detail
            for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)

            {

                dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Style.BackColor = System.Drawing.Color.White;
                if (dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value == DBNull.Value)
                {
                    dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Style.BackColor = System.Drawing.Color.Orange;
                    MessageBox.Show("Số lượng hàng nhập chưa input, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkdetail = false;

                    return;


                }

                if (dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value != DBNull.Value)
                {

                    float Reciep_Quantity = float.Parse(dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value.ToString());
                    float Reciepted_Quantity = float.Parse(dataGridViewLoaddetail.Rows[idrow].Cells["Reciepted_Quantity"].Value.ToString());
                    float Order_Quantity = float.Parse(dataGridViewLoaddetail.Rows[idrow].Cells["Order_Quantity"].Value.ToString());



                    if (Reciep_Quantity > Order_Quantity - Reciepted_Quantity)
                    {
                        dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Style.BackColor = System.Drawing.Color.Orange;


                        MessageBox.Show("Số lượng hàng nhập lớn hơn số order , please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        checkdetail = false;

                        return;
                    }

                    if (Reciep_Quantity < 0)
                    {
                        dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Style.BackColor = System.Drawing.Color.Orange;


                        MessageBox.Show("Số lượng hàng nhập về phải lớn hơn hoặc bằng 0, please check !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        checkdetail = false;

                        return;
                    }


                }



            }


            #endregion







            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            if (checkdetail)
            {
                btluu.Enabled = false;
                btinphieu.Enabled = true;
                int IssueIDsub = 1;
                int subId = (int)(from pp in dc.tbl_MKt_WHstoreissues
                                  where pp.POnumber == this.POnumber
                                  select pp.IssueIDsub).Max().GetValueOrDefault(0);

                if (subId > 0)
                {
                    IssueIDsub = subId + 1;
                }
                this.subID = IssueIDsub;

                //   xx

                string username = Utils.getusername();

                for (int idrow = 0; idrow < dataGridViewLoaddetail.RowCount; idrow++)
                {
                    if (dataGridViewLoaddetail.Rows[idrow].Cells["Material_Item_code"].Value != DBNull.Value)
                    {
                        //     string Material_SAP_code = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_SAP_code"].Value;

                        string Material_Item_code = (string)dataGridViewLoaddetail.Rows[idrow].Cells["Material_Item_code"].Value;

                        #region  update po detail




                        var rs = from pp in dc.tbl_MKt_POdetails
                                 where pp.MateriaItemcode == Material_Item_code
                                 && pp.POnumber == this.POnumber
                                 select pp;

                        if (rs.Count() > 0)
                        {
                            foreach (var item in rs)
                            {
                                item.StatusPO = "IN";
                                item.RecieptedQuantity = item.RecieptedQuantity + Math.Round((float)dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value * (double)item.inputRate);
                                item.BalanceQuantity = item.QuantityOrder - item.RecieptedQuantity;
                                dc.SubmitChanges();



                                tbl_MKT_StockendRegionBudget newregionupdate = new tbl_MKT_StockendRegionBudget();

                                newregionupdate.ITEM_Code = item.MateriaItemcode;
                                newregionupdate.SAP_CODE = item.MateriaSAPcode;
                                newregionupdate.MATERIAL = item.Materialname;
                                newregionupdate.Description = item.Description;
                                newregionupdate.Region = item.Region;
                                newregionupdate.QuantityInputbyPO = Math.Round((float)dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value * (double)item.inputRate);
                                newregionupdate.QuantityInputbyReturn = 0;
                                newregionupdate.QuantityOutput = 0;
                                newregionupdate.QuantitybyDevice = 0;
                                newregionupdate.Note = item.POnumber;
                                newregionupdate.Regionchangedate = datecreated.Value;
                                newregionupdate.Store_code = this.storelocation;

                                dc.tbl_MKT_StockendRegionBudgets.InsertOnSubmit(newregionupdate);
                                dc.SubmitChanges();



                            }


                        }

                        #endregion



                        #region  update gound recieot trong kho



                        var rs2 = from pp in dc.tbl_MKt_POdetails
                                  where pp.MateriaItemcode == Material_Item_code
                                       && pp.POnumber == this.POnumber
                                  group pp by pp.MateriaItemcode into gg
                                  select new
                                  {
                                      //    ID = pp.id,
                                      PO_number = gg.Select(m => m.POnumber).FirstOrDefault(),
                                      Shipping_Point = gg.Select(m => m.Storelocation).FirstOrDefault(),
                                      Material_SAP_code = gg.Select(m => m.MateriaSAPcode).FirstOrDefault(),
                                      Material_Item_code = gg.Key,
                                      Material_name = gg.Select(m => m.Materialname).FirstOrDefault(),
                                      Order_Quantity = gg.Sum(m => m.QuantityOrder),
                                      Reciepted_Quantity = gg.Sum(m => m.RecieptedQuantity),// pp.RecieptedQuantity,
                                                                                            //     Real_issue = 0,

                                      Storelocation = gg.Select(m => m.Storelocation).FirstOrDefault(),
                                      Unit = gg.Select(m => m.Unit).FirstOrDefault(),

                                  };

                        if (rs2.Count() > 0)
                        {
                            foreach (var item in rs2)
                            {


                                tbl_MKt_WHstoreissue newreciepts = new tbl_MKt_WHstoreissue();


                                newreciepts.IssueIDsub = IssueIDsub;
                                newreciepts.RecieptQuantity = (float)dataGridViewLoaddetail.Rows[idrow].Cells["Reciept_Quantity"].Value;
                                newreciepts.Recieptby = txtnguoinhanhang.Text;
                                newreciepts.Materiacode = item.Material_SAP_code;
                                newreciepts.MateriaItemcode = item.Material_Item_code;

                                newreciepts.Materialname = item.Material_name;
                                newreciepts.POnumber = item.PO_number;
                                newreciepts.ShippingPoint = item.Storelocation;
                                newreciepts.Unit = item.Unit;
                                newreciepts.date_input_output = dateNgaynhaphang.Value;
                                newreciepts.DNNumber = txtdnnumbar.Text;
                                //          newreciepts.Serriload

                                //  newreciepts.Status=""
                                newreciepts.Username = username;


                                dc.tbl_MKt_WHstoreissues.InsertOnSubmit(newreciepts);
                                dc.SubmitChanges();


                                var headpo = (from pp in dc.tbl_MKt_POheads
                                              where pp.PONumber == this.POnumber
                                              select pp);
                                if (headpo.Count() > 0)
                                {
                                    foreach (var item2 in headpo)
                                    {
                                        item2.Status = "IN";
                                        dc.SubmitChanges();
                                    }
                                }


                                Model.MKT.tangkhokhinhaphang(newreciepts, this.storelocation);



                            }
                        }


                        #endregion




                    }
                }




                MessageBox.Show("Store reciept of PO :  " + this.POnumber.ToString() + " create done !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);





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

            //   string username = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rptMKT = from pp in dc.tbl_MKT_WHissueHeadRpts
                         where pp.username == this.Username
                         select pp;

            dc.tbl_MKT_WHissueHeadRpts.DeleteAllOnSubmit(rptMKT);
            dc.SubmitChanges();


            var rptMKTdetail = from pp in dc.tbl_MKT_LoaddetailRpts
                               where pp.Username == this.Username
                               select pp;

            dc.tbl_MKT_LoaddetailRpts.DeleteAllOnSubmit(rptMKTdetail);
            dc.SubmitChanges();




            var rptMKThead = (from pp in dc.tbl_MKt_POheads
                              where pp.PONumber == this.POnumber //&& pp.ShippingPoint == this.storelocation
                              select pp).FirstOrDefault();

            if (rptMKThead != null)
            {
                tbl_MKT_WHissueHeadRpt headpx = new tbl_MKT_WHissueHeadRpt();

                headpx.Subid = this.subID.ToString();

                headpx.username = this.Username;
                headpx.Loadnumber = rptMKThead.PONumber;
                //    headpx.nametransporter = rptMKThead.TransposterName;
                headpx.seri = this.storelocation + rptMKThead.PONumber + "-" + this.subID;

                BarcodeGenerator.Code128.Encoder c128 = new BarcodeGenerator.Code128.Encoder();
                BarcodeGenerator.Code128.BarcodeImage barcodeImage = new BarcodeGenerator.Code128.BarcodeImage();
                //     picBarcode.Image = barcodeImage.CreateImage(    c128.Encode(txtInput.Text),   1, true);
                Byte[] result = (Byte[])new ImageConverter().ConvertTo(barcodeImage.CreateImage(c128.Encode(this.storelocation + rptMKThead.PONumber), 1, true), typeof(Byte[]));

                headpx.Barcode = result;
                headpx.Ngaythang = rptMKThead.DatePo;
                headpx.shippingpoint = rptMKThead.StoreLocation;

                headpx.Storeman = this.Createdby;



                dc.tbl_MKT_WHissueHeadRpts.InsertOnSubmit(headpx);
                dc.SubmitChanges();

            }

            //    //var q3 = (from tblEDLP in dc.tblEDLPs
            //    //          group tblEDLP by tblEDLP.Invoice_Doc_Nr into OD//Tương đương GROUP BY trong SQL
            //    //          orderby OD.Key
            //    //          where !(from tblVat in dc.tblVats
            //    //                  select tblVat.SAP_Invoice_Number).Contains(OD.Key)

            //    //          select new
            //    //          {
            //    //              Document_Number = OD.Key,
            //    //              Name = OD.Select(m => m.Cust_Name).FirstOrDefault(),
            //    //              Value_Count = OD.Sum(m => m.Cond_Value)




            //    //          });


            var rshead = from pp in dc.tbl_MKT_WHissueHeadRpts
                         where pp.username == this.Username
                         select new
                         {
                             Storeman = pp.Storeman,
                             Subid = pp.Subid,
                             //     codetransporter = pp.codetransporter,
                             shippingpoint = pp.shippingpoint,
                             Ngaythang = pp.Ngaythang,
                             Loadnumber = pp.Loadnumber,
                             //      nametransporter = pp.nametransporter,
                             //       Truckno = pp.Truckno,
                             //     gatepasslist = pp.gatepasslist,
                             seri = pp.seri,
                             Barcode = pp.Barcode,


                         };
            Utils ut = new Utils();
            var dataset1 = ut.ToDataTable(dc, rshead); // head

            //View.Viewtable vx1 = new Viewtable(rshead, dc, "test", 100, "100");
            //vx1.ShowDialog();

            var rsdetail = from pp in dc.tbl_MKt_WHstoreissues
                           where pp.POnumber == this.POnumber
                           && pp.IssueIDsub == this.subID
                           && pp.RecieptQuantity > 0
                           orderby pp.Materiacode
                           select new
                           {

                               // stt = stt +1,
                               Materiacode = pp.Materiacode,
                               Materialname = pp.Materialname,
                               soluong = pp.RecieptQuantity,
                               //   username = pp.Username,


                           };
            if (rsdetail.Count() > 0)
            {
                int stt = 0;
                foreach (var item in rsdetail)
                {


                    stt = stt + 1;

                    tbl_MKT_LoaddetailRpt detailpx = new tbl_MKT_LoaddetailRpt();

                    detailpx.stt = stt.ToString();
                    detailpx.soluong = item.soluong;
                    detailpx.Username = this.Username;
                    detailpx.materialcode = item.Materiacode;
                    detailpx.tensanpham = item.Materialname;
                    detailpx.bangchu = Utils.ChuyenSo(decimal.Parse(item.soluong.ToString()));


                    dc.tbl_MKT_LoaddetailRpts.InsertOnSubmit(detailpx);
                    dc.SubmitChanges();





                }

            }

            var rsdetail3 = from pp in dc.tbl_MKT_LoaddetailRpts
                            where pp.Username == this.Username
                            orderby pp.stt
                            select new
                            {

                                stt = pp.stt,
                                tensanpham = pp.tensanpham,
                                materialcode = pp.materialcode,
                                soluong = pp.soluong,
                                //   username = pp.Username,
                                bangchu = pp.bangchu,

                            };


            var dataset2 = ut.ToDataTable(dc, rsdetail3); // detail


            Reportsview rpt = new Reportsview(dataset1, dataset2, "PhieuMKWHnhapkhoMKT.rdlc");
            rpt.ShowDialog();

            //}

            //#endregion view reports payment request  // 

        }

        private void dataGridViewListphieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //string connection_string = Utils.getConnectionstr();
            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            //try
            //{
            //    this.soload = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Gate_pass"].Value;
            //    this.storelocation = (string)this.dataGridViewDetail.Rows[this.dataGridViewDetail.CurrentCell.RowIndex].Cells["Store"].Value;

            //    //Date = pp.Ngaytaophieu,
            //    //             pp.Gate_pass,
            //    //             pp.Requested_by,
            //    //             pp.Purpose,


            //    //             pp.Receiver_by,
            //    //             pp.Customer_SAP_Code,
            //    //             pp.Address,
            //    //             pp.Materiacode,
            //    //             //  pp.MateriaSAPcode,
            //    //             pp.Description,
            //    //             pp.Issued,
            //    //             Store = pp.ShippingPoint,
            //    //             Created_by = pp.Username,
            //    //             pp.id,
            //}
            //catch (Exception)
            //{

            //    //     this.phieuchiid = 0;
            //}


            ////List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            ////var rs = from tbl_dstaikhoan in dc.tbl_dstaikhoans
            ////         where tbl_dstaikhoan.loaitkid == "tien" // tien mat la loai 8
            ////         orderby tbl_dstaikhoan.matk
            ////         select tbl_dstaikhoan;
            ////foreach (var item in rs)
            ////{
            ////    ComboboxItem cb = new ComboboxItem();
            ////    cb.Value = item.matk.Trim();
            ////    cb.Text = item.matk.Trim() + ": " + item.tentk;
            ////    CombomCollection.Add(cb);
            ////}

            ////cbtkco.DataSource = CombomCollection;

            ////#endregion load tk nợ



            ////   try
            ////{
            ////    this.phieuchiid = (int)this.dataGridViewListphieuchi.Rows[this.dataGridViewListphieuchi.CurrentCell.RowIndex].Cells["ID"].Value;


            ////}
            ////catch (Exception)
            ////{

            ////    this.phieuchiid = 0;
            ////}

            //if (this.phieuchiid != 0)
            //{

            //    string macty = Model.Username.getmacty();

            //    #region view load form
            //    var phieuchi = (from tbl_SoQuy in dc.tbl_SoQuys
            //                    where tbl_SoQuy.id == this.phieuchiid
            //                    && tbl_SoQuy.macty == macty
            //                    select new
            //                    {

            //                        //     tencongty = Model.Congty.getnamecongty(),
            //                        //     diachicongty = Model.Congty.getdiachicongty(),
            //                        ////     masothue = Model.Congty.getmasothuecongty(),
            //                        //   tengiamdoc = Model.Congty.gettengiamdoccongty(),
            //                        //    tenketoantruong = Model.Congty.gettenketoantruongcongty(),

            //                        sophieuthu = tbl_SoQuy.Sophieu,
            //                        ngaychungtu = tbl_SoQuy.Ngayctu,
            //                        nguoinoptien = tbl_SoQuy.Nguoinopnhantien,
            //                        //    nguoilapphieu = Utils.getname(),
            //                        diachinguoinop = tbl_SoQuy.Diachinguoinhannop,
            //                        lydothu = tbl_SoQuy.Diengiai,
            //                        sotien = tbl_SoQuy.PsCo,
            //                        //   sotienbangchu = Utils.ChuyenSo(tbl_SoQuy.PsNo.ToString()),
            //                        sochungtugoc = tbl_SoQuy.Chungtugockemtheo,
            //                        //    username = Utils.getusername(),


            //                        machitietco = tbl_SoQuy.ChitietTM,
            //                        tentkchitiet = tbl_SoQuy.TenchitietTM,
            //                        tkno = tbl_SoQuy.TKtienmat,

            //                        taikhoandoiung = tbl_SoQuy.TKdoiung,

            //                    }).FirstOrDefault();


            //    if (phieuchi != null)
            //    {
            //        datepickngayphieu.Value = phieuchi.ngaychungtu;

            //        txttennguoinhan.Text = phieuchi.nguoinoptien;
            //        txtdiachi.Text = phieuchi.diachinguoinop;
            //        txtdiengiai.Text = phieuchi.lydothu;


            //        //foreach (ComboboxItem item in (List<ComboboxItem>)cbtkco.DataSource)
            //        //{
            //        //    if (item.Value.ToString().Trim() == phieuchi.tkno.Trim())
            //        //    {
            //        //        cbtkco.SelectedItem = item;
            //        //    }
            //        //}








            //        datepickngayphieu.Enabled = false;

            //        txttennguoinhan.Enabled = false;
            //        txtdiachi.Enabled = false;
            //        txtdiengiai.Enabled = false;

            //        btsua.Enabled = true;







            //        this.statusphieuchi = 3;// View
            // //       Model.Phieuthuchi.reloadnewdetailtaikhoanNo(dataGridViewTkNo);
            //    Model.Phieuthuchi.reloaddetailtaikhoannophieuchi(this.dataGridViewTkNo, this, phieuchi.tkno.Trim(), phieuchi.sophieuthu);
            //        btluu.Visible = false;

            //    }



            //    #endregion view load form









            //}


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




            txtnguoinhanhang.Enabled = true;


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
                txtnguoinhanhang.Focus();

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


        //void cbm_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.BeginInvoke(new MethodInvoker(EndEdit));

        //}

        //     ComboBox cbm;
        //     DataGridViewCell currentCell;

        //  private DateTimePicker cellDateTimePicker = new DateTimePicker();
        // DateTimePicker[] sp = new DateTimePicker[100];

        //void EndEdit()
        //{




        //    //if (cbm != null)
        //    //{
        //    //    if (cbm.SelectedItem != null)
        //    //    {
        //    //        string SelectedItem = (cbm.SelectedItem as ComboboxItem).Value.ToString();// (cbm.SelectedItem as ComboboxItem).Value.ToString();

        //    //        // int i = dataGridProgramdetail.CurrentRow.Index;
        //    //        int i = currentCell.RowIndex;
        //    //        string colname = this.dataGridViewDetail.Columns[this.dataGridViewDetail.CurrentCell.ColumnIndex].Name;

        //    //        dataGridViewDetail.Rows[i].Cells[colname].Value = SelectedItem;





        //    //    }


        //    //}


        //}

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
