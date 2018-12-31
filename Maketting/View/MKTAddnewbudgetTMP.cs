using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maketting.Control;
using System.Globalization;

namespace Maketting.View
{


    public partial class MKTAddnewbudgetTMP : Form
    {
        // public View.CreatenewContract contractnew;
        public int id { get; set; }
        public string customercode { get; set; }
        public string customername { get; set; }
        public string customeradress { get; set; }

        public double budget { get; set; }
        //   public string tenkho { get; set; }
        public System.Windows.Forms.Label viewtotal { get; set; }

        public string Ionumber { get; set; }
        public string username { get; set; }

        public bool chon { get; set; }
        public DataGridView DatagridviewTmp { get; set; }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }


            public override string ToString()
            {
                return Text;
            }
        }


      

        public void Blanknewform() // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            this.customercode = "";
            this.customername = "";
            this.customeradress = "";// { get; set; }

            this.budget = 0   ;// { get; set; }

            txtCustomercode.Text = "";
            txtcustomername.Text = "";
            txtcustomeraddress.Text = "";
            txtbudget.Text = "0";


            



        }
        public MKTAddnewbudgetTMP(string Ionumber, DataGridView DatagridviewTmp, System.Windows.Forms.Label viewtotal) // int = 1 xóa; int = 2 sửa ; int = 3 tao mới; int = 4 vừa sửa+ xóa
        {
            InitializeComponent();

            chon = false;
            //    cbkhohang
            this.username = Utils.getusername();

            this.Ionumber = Ionumber;
            this.DatagridviewTmp = DatagridviewTmp;

            this.viewtotal = viewtotal;

            Blanknewform();









        }

        private void txtCustcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // chanel of IO
                string seachtext = txtCustomercode.Text;
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string channelgroup = (from pp in dc.tbl_MKT_IO_Programes
                                       where pp.IO_number == this.Ionumber
                                       select pp.ChannelGroup).FirstOrDefault();


                string[] chanelparts = channelgroup.Split(';');

                //st1 = parts[0].Trim();
                //st2 = parts[1].Trim();
                //st3 = parts[2].Trim();
                //st4 = parts[3].Trim();

                var rs = from pp in dc.tbl_MKT_Soldtocodes
                         where pp.FullNameN.Contains(seachtext)
                         && pp.Soldtype == true
                         && chanelparts.Contains(pp.Chanel)

                         select new
                         {

                             MÃ_KHÁCH_HÀNG = pp.Customer,
                             TÊN_KHÁCH_HÀNG = pp.FullNameN,
                             ĐỊA_CHỈ = pp.Street + " " + pp.District + " " + pp.City,
                             pp.KeyAcc,
                             pp.Chanel,
                             pp.Region,
                             pp.SalesOrg,
                             pp.District,
                             //QUẬN = pp.District,
                             //TỈNH_THÀNH_PHỐ = pp.City,
                             //ĐIỆN_THOẠI = pp.Telephone1,
                             //GHI_CHÚ = pp.Note,




                             ID = pp.id,

                         };

                View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT RECIPIENTS", "MKT");
                selectkq.ShowDialog();
                int id = selectkq.id;

                var rs2 = (from pp in dc.tbl_MKT_Soldtocodes
                           where pp.id == id
                           select pp).FirstOrDefault();

                if (rs2 != null)
                {

                    txtCustomercode.Text = rs2.Customer;
                    txtcustomername.Text = rs2.FullNameN;
                    txtcustomeraddress.Text = rs2.Street + " ," + rs2.District + " ," + rs2.City;
                    txtbudget.Text = "0";

                    this.customercode = rs2.Customer;
                    this.customername = rs2.FullNameN;
                    this.customeradress = rs2.Street + " ," + rs2.District + " ," + rs2.City;
                    this.budget = 0;
                }


                txtbudget.Focus();





            }



        }






        private void btxoa_Click(object sender, EventArgs e)
        {

      


            //var rs1 = (from p in dc.tbl_MKT_Stockends
            //           where p.id == this.id
            //           select p).FirstOrDefault();

            //if (rs1 != null)
            //{

            //    dc.tbl_MKT_Stockends.DeleteOnSubmit(rs1);
            //    dc.SubmitChanges();
            //    this.Close();


            //}




        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            //    //




            //    this.itemcode = this.txtCustomercode.Text;
            //    this.materialname = this.txttensanpham.Text;


            //    this.sapcode = txtsapcode.Text;
            ////    this.donvi = txtdonvi.Text;





            //  this.ghichu = txtghichu.Text;

            //if (cbkhohang.SelectedItem != null)
            //{
            //    this.makho = (string)(cbkhohang.SelectedItem as ComboboxItem).Value;// (cbm.SelectedItem as ComboboxItem).Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Kiểm tra kho hàng!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}


            //this.tenkho = (string)(cbkhohang.SelectedItem as ComboboxItem).Text;














        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnew_Click(object sender, EventArgs e)
        {

            if (Utils.IsValidnumber(txtbudget.Text))
            {

                if (double.Parse(txtbudget.Text) > 0)
                {
                    this.budget = double.Parse(txtbudget.Text);
                    this.chon = true;
                }
                else
                {
                    MessageBox.Show("Budget must be a number greater than 0 !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.chon = false;
                    txtbudget.Focus();
                }

            }
            else
            {
                MessageBox.Show("Budget must be a number greater than 0 !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.chon = false;

                txtbudget.Focus();
            }


            if (this.customercode != "" && this.customername!="" && this.customeradress !="" && chon == true)
            {

               
                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


                tbl_MKT_Payment_AprovalTMP newtemp = new tbl_MKT_Payment_AprovalTMP();

                newtemp.Customercode = this.customercode;
                newtemp.CustomerName =Utils.Truncate( this.customername,225);
                newtemp.CustomerAddress =Utils.Truncate(this.customeradress,225);
                newtemp.AprovalBudget = this.budget;
                newtemp.username = username;

                dc.tbl_MKT_Payment_AprovalTMPs.InsertOnSubmit(newtemp);
                dc.SubmitChanges();




                Blanknewform();


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


                
                this.DatagridviewTmp.DataSource = Programelist;


                if (Programelist.Count() > 0)
                {
                    double totalBudget = (double)Programelist.Sum(x => x.AprovalBudget);

                    viewtotal.Text = totalBudget.ToString("#,#", CultureInfo.InvariantCulture);

                }
              
            }
            //this.customercode = rs2.Customer;
            //this.customername = rs2.FullNameN;
            //this.customeradress = rs2.Street + " ," + rs2.District + " ," + rs2.City;
            //this.budget = 0;


            txtCustomercode.Focus();





        }








        private void txtQuocgia_TextChanged(object sender, EventArgs e)
        {

        }








        private void txttennganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtCustomercode.Focus();


            }
        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                txtCustomercode.Focus();


            }
        }

        private void txttensanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtbudget.Focus();


            }

        }

        private void txtmavach_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtcustomeraddress.Focus();


            }

        }

        private void txtdonvi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //    txttrongluong.Focus();


            }

        }

        private void txttrongluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //   txtkhoiluong.Focus();


            }

        }

        private void txtkhoiluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //   txtnhomsanpham.Focus();


            }

        }

        private void txtnhomsanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                //      txtghichu.Focus();


            }

        }

        private void txtghichu_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtCustomercode.Focus();


            }

        }

        private void txtdescription_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtunit_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                txtCustomercode.Focus();


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtbudget_TextChanged(object sender, EventArgs e)
        {
         

        }
    }


}
