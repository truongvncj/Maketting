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
using System.IO;
using System.Data.SqlClient;

using System.Configuration;
using System.Diagnostics;
using System.Globalization;

namespace Maketting.View
{
    public partial class MKTProgramepaymentbyFI : Form
    {

        //    public string Valuechoose { get; set; }

        public string kqstring { get; set; }
        public int id { get; set; }

        public string username { get; set; }

        //public string ProgrameIDDocno { get; set; }
        //public string ionumber { get; set; }
        public double totalBudget { get; set; }
        public int payID { get; set; }
        DataGridView dataGridView1head { get; set; }


        public void blanknewpayment(int payID)
        {
            //    lbfileupload.Text = "";

            txtsohieuct.Enabled = false;
            txtionumber.Enabled = false;
            txttenct.Enabled = false;
            txtchargetoaccount.Enabled = false;
            txtcostcenter.Enabled = false;
            txtcostcenter.Enabled = false;

          
            txtpaymentID.Text = payID.ToString();

            

            this.username = Utils.getusername();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            ////---------------------
            var Programelist2 = (from pp in dc.tbl_MKT_Payment_Aproval_heads
                                where pp.payID == payID
                                select pp.Approval).FirstOrDefault();
            if (Programelist2!= null)
            {

                lbapprovalstatus.Text = Programelist2;



            }

           

            var Programelist = from pp in dc.tbl_MKT_Payment_Aprovals
                               where pp.payID == payID
                               select new
                               {
                                
                                   pp.Customercode,
                                   pp.CustomerName,

                                   pp.CustomerAddress,
                                   pp.AprovalBudget,

                                   pp.id,



                               };




            this.dataGridviewpaymentapprval.DataSource = Programelist;
            dataGridviewpaymentapprval.Columns["id"].Visible = false;

            this.totalBudget = (float)Programelist.Sum(x => x.AprovalBudget);

            txttotalbudget.Text = this.totalBudget.ToString("#,#", CultureInfo.InvariantCulture);

        }
        //  IQueryable rs, LinqtoSQLDataContext d
        public MKTProgramepaymentbyFI(int paymentrequestID, DataGridView dataGridView1head)
        {
            InitializeComponent();
            this.dataGridView1head = dataGridView1head;

            blanknewpayment(paymentrequestID);

            this.payID = paymentrequestID;
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

            foreach (var c in dataGridviewpaymentapprval.Columns)
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
            string colheadertext = this.dataGridviewpaymentapprval.Columns[this.dataGridviewpaymentapprval.CurrentCell.ColumnIndex].HeaderText;

            //      bbb



            if (colheadertext == "Select channel")// nếu kích ô Select_channel 
            {



                if (dataGridviewpaymentapprval.Rows[this.dataGridviewpaymentapprval.CurrentRow.Index].Cells["ID"].Value != null && dataGridviewpaymentapprval.Rows[this.dataGridviewpaymentapprval.CurrentRow.Index].Cells["Select_channel"].Value != null)
                {
                    int indexID = int.Parse(dataGridviewpaymentapprval.Rows[this.dataGridviewpaymentapprval.CurrentRow.Index].Cells["ID"].Value.ToString());


                    bool currentvalue = (bool)dataGridviewpaymentapprval.Rows[this.dataGridviewpaymentapprval.CurrentRow.Index].Cells["Select_channel"].Value;

                    dataGridviewpaymentapprval.EditMode = DataGridViewEditMode.EditProgrammatically;
                    dataGridviewpaymentapprval.ReadOnly = false;


                    dataGridviewpaymentapprval.Rows[this.dataGridviewpaymentapprval.CurrentRow.Index].Cells["Select_channel"].Value = !currentvalue;
                    dataGridviewpaymentapprval.ReadOnly = true;
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

            string username = Utils.getusername();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            // ghi file   [tbl_MKT_Programe]


            var Programelist = from pp in dc.tbl_MKT_IO_ProgrameTMPs
                               where pp.Username == username
                               select pp;


            if (Programelist.Count() <= 0)
            {
                MessageBox.Show("Please setup IO of this progarme !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

         //       btiosetup.Focus();
                return;
            }

            var programelist = from pp in dc.tbl_MKT_IO_ProgrameTMPs
                               where pp.Username == username
                               select pp;


            //if (programelist.Count() <= 0)
            //{
            //    MessageBox.Show("Please setup product of this progarme !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    btprodutadd.Focus();
            //    return;
            //}

            tbl_MKT_Programe newprograme = new tbl_MKT_Programe();
            //if (Utils.IsValidnumber(txttotalbudget.Text))
            //{
            //    newprograme.TotalBudget = double.Parse(txttotalbudget.Text);
            //    newprograme.BalanceBudget = double.Parse(txttotalbudget.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Budget must be a munber ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    newprograme = null;
            //    txttotalbudget.Focus();
            //    return;
            //}


            newprograme.tenCT = txttenct.Text;

            newprograme.ProgrameIDDocno = txtsohieuct.Text;


            dc.tbl_MKT_Programes.InsertOnSubmit(newprograme);
            dc.SubmitChanges();




            // ghi file  [tbl_MKT_Programepriceproduct]
            var productlist = from pp in dc.tbl_MKT_ProgramepriceproductTMPs
                              where pp.Username == username
                              select pp;


            foreach (var item in productlist)
            {

                tbl_MKT_Programepriceproduct newitem2 = new tbl_MKT_Programepriceproduct();

                newitem2.Description = item.Description;
                newitem2.ITEM_Code = item.ITEM_Code;
                newitem2.MATERIAL = item.MATERIAL;
                newitem2.Price = item.Price;
                newitem2.ProgrameIDDocno = item.ProgrameIDDocno;
                newitem2.SAP_CODE = item.SAP_CODE;
                newitem2.UNIT = item.UNIT;

                dc.tbl_MKT_Programepriceproducts.InsertOnSubmit(newitem2);
                dc.SubmitChanges();



            }



            // ghi file   [tbl_MKT_IO_Programe]

            var programe = from pp in dc.tbl_MKT_IO_ProgrameTMPs
                           where pp.Username == username
                           select pp;


            foreach (var item in programe)
            {

                tbl_MKT_IO_Programe newitem = new tbl_MKT_IO_Programe();

                newitem.Budget = item.Budget;
                newitem.ChannelGroup = item.ChannelGroup;
                newitem.ghichu = item.ghichu;
                newitem.IO_Name = item.IO_Name;
                newitem.IO_number = item.IO_number;
                newitem.ProgrameIDDocno = item.ProgrameIDDocno;
                newitem.Region = item.Region;
                newitem.Sales_Org = item.Sales_Org;

                dc.tbl_MKT_IO_Programes.InsertOnSubmit(newitem);
                dc.SubmitChanges();



            }



            this.Close();





        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lbfileupload.Visible = true;


            //if (this.ProgrameIDDocno == "")
            //{

            //    MessageBox.Show("Please nhập số hiệu chương trình trước khi upload file scheme ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    txtsohieuct.Focus();
            //    return;
            //}

            //OpenFileDialog theDialog = new OpenFileDialog();
            //theDialog.Title = "Open PDF File scheme programe";
            //theDialog.Filter = "PDF files|*.pdf";
            //theDialog.InitialDirectory = @"C:\";
            //if (theDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string filePath = theDialog.FileName.ToString();




            //    // getting the file path of uploaded file  
            //    string filename1 = Path.GetFileName(filePath); // getting the file name of uploaded file  
            //    string type = Path.GetExtension(filename1); // getting the file extension of uploaded file  
            //                                                //     string type = String.Empty;
            //                                                //   string ProgrameIDDocno = txtsohieuct.Text;

            //    string connection_string = Utils.getConnectionstr();
            //    var db = new LinqtoSQLDataContext(connection_string);

            //    try
            //    {



            //        byte[] bytes;
            //        using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //        {
            //            using (var reader = new BinaryReader(stream))
            //            {
            //                bytes = reader.ReadBytes((Int32)stream.Length);
            //            }
            //        }
            //        using (var varConnection = new SqlConnection(connection_string))
            //        {
            //            varConnection.Open();


            //            using (var sqlWrite = new SqlCommand("insert into tbl_MKT_Programepdfdata (Name,Contentype,Data,ProgrameIDDocno)" + " values (@Name, @type, @Data, @ProgrameIDDocno)", varConnection))

            //            {
            //                sqlWrite.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Utils.Truncate(filename1, 225);
            //                sqlWrite.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            //                sqlWrite.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
            //                sqlWrite.Parameters.Add("@ProgrameIDDocno", SqlDbType.NVarChar).Value = Utils.Truncate(this.ProgrameIDDocno, 50);

            //                sqlWrite.ExecuteNonQuery();
            //            }
            //        }


            //        lbfileupload.ForeColor = System.Drawing.Color.Green;
            //        lbfileupload.Text = "File Uploaded Successfully";


            //    }
            //    catch (Exception)
            //    {

            //        lbfileupload.ForeColor = System.Drawing.Color.Red;
            //        lbfileupload.Text = "File Uploaded Error";

            //    }




            //}





        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //if (this.ProgrameIDDocno == "")
            //{

            //    MessageBox.Show("Please nhập số hiệu chương trình trước khi upload file scheme ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    txtsohieuct.Focus();
            //    return;
            //}

            //View.MKTProgrameinputproductandprice spchon = new MKTProgrameinputproductandprice(this.dataGridViewProduct, this.ProgrameIDDocno);
            //spchon.ShowDialog();

        }

        private void txtsohieuct_TextChanged(object sender, EventArgs e)
        {
       //     this.ProgrameIDDocno = txtsohieuct.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //txtsohieuct.Text = "";
            //txtionumber.Text = "";
            //txttenct.Text = "";
            //txtchargetoaccount.Text = "";
            //txtcostcenter.Text = "";

      

            if (txtchargetoaccount.Text == "")
            {

                MessageBox.Show("Please nhập Account charge to ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtchargetoaccount.Focus();
                return;
            }

            if (txtcostcenter.Text == "")
            {

                MessageBox.Show("Please nhập Cost center ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtcostcenter.Focus();
                return;
            }

            Model.Aprovalpayment approvapayment = new Model.Aprovalpayment();
            approvapayment.Inputapprovalpayment();


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var Programelist = from pp in dc.tbl_MKT_Payment_AprovalTMPs
                               where pp.username == username
                               select new
                               {
                                   //      pp.IO_number,
                                   //      pp.ProgrameIDDocno,
                                   //     pp.Account,
                                   //     pp.costcenter,
                                   pp.Customercode,
                                   pp.CustomerName,

                                   pp.CustomerAddress,
                                   pp.AprovalBudget,

                                   pp.id,

                                   pp.username,



                               };




            this.dataGridviewpaymentapprval.DataSource = Programelist;
            if (Programelist.Count() > 0)
            {
             //   this.totalBudget = (float)Programelist.Sum(x => x.AprovalBudget);

                txttotalbudget.Text = ((float)Programelist.Sum(x => x.AprovalBudget)).ToString("#,#", CultureInfo.InvariantCulture);

            }


        }

        private void btreviewfile_Click(object sender, EventArgs e)
        {
            //if (this.ProgrameIDDocno == "")
            //{

            //    MessageBox.Show("Please nhập số hiệu chương trình và upload trước khi view ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    txtsohieuct.Focus();
            //    return;
            //}

            ////
            ////   string filePath = theDialog.FileName.ToString();

            //SaveFileDialog thedialog = new SaveFileDialog();
            ////


            ////   datagridview datagridview1 = new datagridview();
            ////   datagridview1.datasource = datagrid.datasource;

            //thedialog.Title = "export to PDF file";
            //thedialog.Filter = "PDF files|*.pdf";
            //thedialog.InitialDirectory = @"c:\";
            //thedialog.FileName = this.ProgrameIDDocno;


            //if (thedialog.ShowDialog() == DialogResult.OK)
            //{

            //    string filePath = thedialog.FileName.ToString();

            //    //     string id;
            //    FileStream FS = null;
            //    byte[] dbbyte;
            //    try
            //    {
            //        //Get a stored PDF bytes
            //        //   dbbyte = (byte[])dr["UploadFiles"];


            //        //store file Temporarily 
            //        string connection_string = Utils.getConnectionstr();
            //        var db = new LinqtoSQLDataContext(connection_string);

            //        //          using (var sqlWrite = new SqlCommand("insert into tbl_MKT_Programepdfdata (Name,Contentype,Data,ProgrameIDDocno)" + " values (@Name, @type, @Data, @ProgrameIDDocno)", varConnection))

            //        using (SqlConnection sqlconnection = new SqlConnection(connection_string))
            //        {
            //            sqlconnection.Open();

            //            string selectQuery = string.Format(@"Select tbl_MKT_Programepdfdata.Data   From tbl_MKT_Programepdfdata  Where tbl_MKT_Programepdfdata.ProgrameIDDocno = @ProgrameIDDocno");

            //            // Read File content from Sql Table 
            //            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlconnection);

            //            selectCommand.Parameters.Add("@ProgrameIDDocno", SqlDbType.NVarChar).Value = Utils.Truncate(this.ProgrameIDDocno, 50);


            //            SqlDataReader reader = selectCommand.ExecuteReader();
            //            if (reader.Read())
            //            {
            //                byte[] fileData = (byte[])reader[0];

            //                // Write/Export File content into new text file
            //                File.WriteAllBytes(filePath, fileData);
            //            }
            //        }


            //        //Assign File path create file


            //   //     FS = new FileStream(filepath, System.IO.FileMode.Create);



            //        //Write bytes to create file
            //    //    FS.Write(dbbyte, 0, dbbyte.Length);



            //        // Open file after write 
            //        //Create instance for process class
            //        Process Proc = new Process();
            //        //assign file path for process
            //        Proc.StartInfo.FileName = filePath;
            //        Proc.Start();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new System.ArgumentException(ex.Message);
            //    }
            //    finally
            //    {
            //        //Close FileStream instance
            //     //   FS.Close();
            //    }






            //}









            //// getting the file path of uploaded file  
            ////   string filename1 = Path.GetFileName(filePath); // getting the file name of uploaded file  
            ////   string type = Path.GetExtension(filename1); // getting the file extension of uploaded file  
            ////     string type = String.Empty;
            ////   string ProgrameIDDocno = txtsohieuct.Text;







        }

        private void txtionumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;

                string seachtext = txtionumber.Text;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //var rs = from pp in dc.tbl_MKT_IO_Programes
                //         where pp.tenCT.Contains(seachtext)
                //         select new
                //         {
                //             MÃ_CHƯƠNG_TRÌNH = pp.macT,
                //             TÊN_CHƯƠNG_TRÌNH = pp.tenCT,



                //             pp.id,

                //         };

                var rs = Model.MKT.DanhsachctMKTSeachbyIOseach(dc, txtionumber.Text);

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT PURPOSE ", "MKT");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_IO_Programes
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {

                    txtionumber.Text = rs2.IO_number;
                    txttenct.Text = rs2.IO_Name;
                    txtsohieuct.Text = rs2.ProgrameIDDocno;
                
                }




                txtchargetoaccount.Focus();


                //    dataGridViewDetail.Focus();

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            var Programelist1 = from pp in dc.tbl_MKT_Payment_AprovalTMPs
                                where pp.username == username
                                select pp;

            dc.tbl_MKT_Payment_AprovalTMPs.DeleteAllOnSubmit(Programelist1);
            dc.SubmitChanges();

            var Programelist = from pp in dc.tbl_MKT_Payment_AprovalTMPs
                               where pp.username == username
                               select new
                               {
                                   //      pp.IO_number,
                                   //      pp.ProgrameIDDocno,
                                   //     pp.Account,
                                   //     pp.costcenter,
                                   pp.Customercode,
                                   pp.CustomerName,

                                   pp.CustomerAddress,
                                   pp.AprovalBudget,

                                   pp.id,

                                   pp.username,



                               };



            this.dataGridviewpaymentapprval.DataSource = Programelist;

            if (Programelist.Count()>0)
            {
                this.totalBudget = (float)Programelist.Sum(x => x.AprovalBudget);

                txttotalbudget.Text = this.totalBudget.ToString("#,#", CultureInfo.InvariantCulture);

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.username = Utils.getusername();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            ////---------------------


            var Programelist = from pp in dc.tbl_MKT_Payment_Aprovals
                               where pp.payID == this.payID
                               select pp;

            if (Programelist.Count()>0)
            {

                foreach (var item in Programelist)
                {
                    item.Approvaldate = DateTime.Today;
                    item.Approvalby = username;
                    item.Approval = "Approved";
                    dc.SubmitChanges();


                }

            }

            var Programelist2 = from pp in dc.tbl_MKT_Payment_Aproval_heads
                               where pp.payID == this.payID
                                select pp;

            if (Programelist2.Count() > 0)
            {

                foreach (var item in Programelist2)
                {
                    
                    item.Approval = "Approved";
                    dc.SubmitChanges();


                }

            }
             
            lbapprovalstatus.Text = "Approved";


            MessageBox.Show("Aproval done !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //   blanknewpayment();

            //string connection_string = Utils.getConnectionstr();
            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs5 = from pp in dc.tbl_MKT_Payment_Aproval_heads
                      where pp.payID != null && pp.Approval == "Not Approved"
            select new
                      {
                          pp.payID,
                          pp.IO_number,
                          pp.ProgrameIDDocno,
                          pp.ProgrameName,
                          Budge_Requested = pp.TotalAprovalBudget,
                          pp.Account,
                          pp.costcenter,
                          pp.Requestby,
                          pp.Approval,


                      };
            this.dataGridView1head.DataSource = rs5;

        }

        private void button2_Click_2(object sender, EventArgs e)
        {





            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var Programelist = from pp in dc.tbl_MKT_Payment_AprovalTMPs
                               where pp.username == username
                               select new
                               {
                                   //      pp.IO_number,
                                   //      pp.ProgrameIDDocno,
                                   //     pp.Account,
                                   //     pp.costcenter,
                                   pp.Customercode,
                                   pp.CustomerName,

                                   pp.CustomerAddress,
                                   pp.AprovalBudget,

                                   pp.id,

                                   pp.username,



                               };


            if (Programelist.Count() > 0)
            {
                this.totalBudget = (float)Programelist.Sum(x => x.AprovalBudget);

                txttotalbudget.Text = this.totalBudget.ToString("#,#", CultureInfo.InvariantCulture);

            }
        }

        private void txtchargetoaccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtcostcenter.Focus();
            }
        }

        private void txtcostcenter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
           ///     btiosetup.Focus();
            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            this.username = Utils.getusername();
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            ////---------------------


            var Programelist = from pp in dc.tbl_MKT_Payment_Aprovals
                               where pp.payID == this.payID
                               select pp;

            if (Programelist.Count() > 0)
            {

                foreach (var item in Programelist)
                {
                    item.Approvalby = username;
                    item.Approval = "Not Approved";
                    dc.SubmitChanges();


                }

            }

            var Programelist2 = from pp in dc.tbl_MKT_Payment_Aproval_heads
                                where pp.payID == this.payID
                                select pp;

            if (Programelist2.Count() > 0)
            {

                foreach (var item in Programelist2)
                {

                    item.Approval = "Not Approved";
                    dc.SubmitChanges();


                }

            }

            lbapprovalstatus.Text = "Not Approved";



            MessageBox.Show("Not Approval done !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var rs5 = from pp in dc.tbl_MKT_Payment_Aproval_heads
                      where pp.payID != null && pp.Approval == "Not Approved"
                      select new
                      {
                          pp.payID,
                          pp.IO_number,
                          pp.ProgrameIDDocno,
                          pp.ProgrameName,
                          Budge_Requested = pp.TotalAprovalBudget,
                          pp.Account,
                          pp.costcenter,
                          pp.Requestby,
                          pp.Approval,


                      };
            this.dataGridView1head.DataSource = rs5;
        }
    }
}
