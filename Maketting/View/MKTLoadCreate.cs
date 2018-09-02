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
    public partial class MKTLoadCreate : Form
    {
        public int statusphieu { get; set; } // mới  // 2 suawra // 3 display //
        public int sophieuID { get; set; }
        public string sophieuxuathangQC { get; set; }


        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        public void addDEtailPhieuMKT(tbl_MKt_Listphieu PhieuMKT)
        {





            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            //---------------

            //DataTable dataTable = (DataTable)dataGridViewDetail.DataSource;

            //DataRow drToAdd = dataTable.NewRow();

            ////    drToAdd["Tk_Có"] = socaitemp.TkCo;
            //drToAdd["Code"] = PhieuMKT.Materiacode;
            //drToAdd["Description"] = PhieuMKT.Description;
            //drToAdd["Issue"] = PhieuMKT.Issued;




            ////      drToAdd["Số_chứng_từ"] = socaitemp.Soctu;
            ////   drToAdd["Ký_hiêu"] = socaitemp.Kyhieuctu;

            ////if (socaitemp.PsNo != null)
            ////{
            ////    drToAdd["Số_tiền"] = socaitemp.PsNo;
            ////}

            //drToAdd["Mã_chi_tiết"] = socaitemp.MaCTietTKCo;
            //drToAdd["Tên_chi_tiết"] = socaitemp.tenchitietCo;

            //drToAdd["tkNohide"] = socaitemp.TkNo;


            //     drToAdd["ngayctuhide"] = socaitemp.Ngayctu;

            //dataTable.Rows.Add(drToAdd);
            //dataTable.AcceptChanges();



            //int i = dataTable.Rows.Count - 1;
            //   int i = dataGridViewTkCo.RowCount -1;

            //DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridViewTkNo.Rows[i].Cells["Tk_Nợ"];
            //DataGridViewCell dgvc = (DataGridViewCell)dataGridViewTkNo.Rows[i].Cells["Tk_Nợ"];

            //#region tim item comboboc

            //foreach (ComboboxItem item in (List<ComboboxItem>)cb.DataSource)
            //{

            //    if (item.Value.ToString().Trim() == socaitemp.TkNo.ToString().Trim())
            //    {

            //        dataGridViewTkNo.Rows[i].Cells["Tk_Nợ"].Value = item.Value;
            //    }

            //}


            //#endregion tom item comboubox




        }

        public void reloadseachview(string nguoinop, string diachi, string noidung)
        {



            //     dataGridViewListphieuchi.DataSource = Model.Phieuthuchi.reloadseachview("PC", nguoinop, diachi, noidung);


        }

        public void cleartoblankphieu()
        {

            #region  list black phiếu
            datepickngayphieu.Enabled = true;


            txttennguoinhan.Enabled = true;
            txtdiachi.Enabled = true;
            txtdiengiai.Enabled = true;

            btluu.Visible = true;
            btluu.Enabled = true;
            //    cbtaikhoanco.Enabled = true;

            btsua.Enabled = false;


            txttennguoinhan.Text = "";
            txtdiachi.Text = "";
            txtdiengiai.Text = "";



            datepickngayphieu.Focus();

            dataGridViewDetail = Model.MKT.Loadnewdetail(dataGridViewDetail);


            //   dataGridViewTkNo = Model.Phieuthuchi.reloadnewdetailtaikhoanNo(dataGridViewTkNo);


            #endregion


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

        public MKTLoadCreate(View.Main Main)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Control_KeyPress);  // để đọc từ bàn phím phím tắt


            this.main1 = Main;

            this.statusphieu = 1; // tạo mới

            //Model.Username used = new Model.Username();
            //string connection_string = Utils.getConnectionstr();
            //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //string username = Utils.getusername();






            dataGridViewDetail = Model.MKT.Loadnewdetail(dataGridViewDetail);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            // main1.clearpannel();
            //View.Beemainload main = new Beemainload(main1);

            //main1.clearpannelload(main);
        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txttennguoinhan.Focus();

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
                txttennguoinhan.Focus();

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
                txtdiachi.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void cbdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtdiengiai.Focus();


            }
        }

        private void cbdiengiai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //     txtsotien.Focus();



            }
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
                datepickngayphieu.Focus();
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

        public static void ghisoQuy(tbl_SoQuy soquy)
        {

            //      string connection_string = Utils.getConnectionstr();

            //      LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //  dc.tbl_SoQuys.InsertOnSubmit(soquy);
            //       dc.SubmitChanges();

        }

        private void button1_Click(object sender, EventArgs e)  // new phieu 
        {







        }

        private void dataGridViewListphieuthu_Paint(object sender, PaintEventArgs e)
        {

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridViewListphieu.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

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

            this.cleartoblankphieu();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string username = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //var rptphieuchi = from phieuthud in dc.Rpt_PhieuThus
            //                  where phieuthud.username == username
            //                  select phieuthud;

            //dc.Rpt_PhieuThus.DeleteAllOnSubmit(rptphieuchi);
            //dc.SubmitChanges();


            //var phieuchi = (from tbl_SoQuy in dc.tbl_SoQuys
            //                where tbl_SoQuy.id == this.phieuchiid
            //                select new
            //                {

            //                    //     tencongty = Model.Congty.getnamecongty(),
            //                    //     diachicongty = Model.Congty.getdiachicongty(),
            //                    ////     masothue = Model.Congty.getmasothuecongty(),
            //                    //   tengiamdoc = Model.Congty.gettengiamdoccongty(),
            //                    //    tenketoantruong = Model.Congty.gettenketoantruongcongty(),

            //                    sophieuthu = tbl_SoQuy.Sophieu,
            //                    ngaychungtu = tbl_SoQuy.Ngayctu,
            //                    nguoinoptien = tbl_SoQuy.Nguoinopnhantien,
            //                    //    nguoilapphieu = Utils.getname(),
            //                    diachinguoinop = tbl_SoQuy.Diachinguoinhannop,
            //                    lydothu = tbl_SoQuy.Diengiai,
            //                    sotien = tbl_SoQuy.PsCo,
            //                    //   sotienbangchu = Utils.ChuyenSo(tbl_SoQuy.PsNo.ToString()),
            //                    sochungtugoc = tbl_SoQuy.Chungtugockemtheo,
            //                    //    username = Utils.getusername(),
            //                    tkco = tbl_SoQuy.TKtienmat,
            //                    tkno = tbl_SoQuy.TKdoiung,


            //                }).FirstOrDefault();

            //   this.dataGridViewListphieuthu.DataSource = phieuthu;

            //#region  view reports payment request  

            ////Control_ac ctrac = new Control_ac();

            ////var rs1 = ctrac.KArptdataset1(dc);
            ////var rs2 = ctrac.KArptdataset2(dc);



            //if (phieuchi != null)
            //{


            //    #region  insert vao rpt phieu thu

            //    Rpt_PhieuThu pt = new Rpt_PhieuThu();
            //    string macty = Model.Username.getmacty();
            //    pt.tencongty = Model.Congty.getnamecongty(macty);
            //    pt.diachicongty = Model.Congty.getdiachicongty(macty);
            //    pt.masothue = Model.Congty.getmasothuecongty(macty);
            //    pt.tengiamdoc = Model.Congty.gettengiamdoccongty(macty);
            //    pt.tenketoantruong = Model.Congty.gettenketoantruongcongty(macty);
            //    pt.sotienbangchu = phieuchi.sophieuthu;
            //    pt.ngaychungtu = phieuchi.ngaychungtu;
            //    pt.nguoinoptien = phieuchi.nguoinoptien;
            //    pt.nguoilapphieu = Utils.getname();
            //    pt.diachinguoinop = phieuchi.diachinguoinop;
            //    pt.lydothu = phieuchi.lydothu;
            //    pt.sotien = phieuchi.sotien;
            //    pt.sotienbangchu = Utils.ChuyenSo(decimal.Parse(phieuchi.sotien.ToString()));
            //    pt.sochungtugoc = phieuchi.sochungtugoc;
            //    pt.username = Utils.getusername();
            //    pt.tkno = phieuchi.tkno;
            //    pt.tkco = phieuchi.tkco;
            //    pt.phieuthuso = phieuchi.sophieuthu;

            //    dc.Rpt_PhieuThus.InsertOnSubmit(pt);
            //    dc.SubmitChanges();
            //    #endregion

            //    var rsphieuchi = from tblRpt_PhieuThu in dc.Rpt_PhieuThus
            //                     where tblRpt_PhieuThu.username == username
            //                     select tblRpt_PhieuThu;


            //    Utils ut = new Utils();
            //    var dataset1 = ut.ToDataTable(dc, rsphieuchi);

            //    Reportsview rpt = new Reportsview(dataset1, null, "Phieuchi.rdlc");
            //    rpt.ShowDialog();

            //}

            //#endregion view reports payment request  // 

        }

        private void dataGridViewListphieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            //List<ComboboxItem> CombomCollection = new List<ComboboxItem>();
            //var rs = from tbl_dstaikhoan in dc.tbl_dstaikhoans
            //         where tbl_dstaikhoan.loaitkid == "tien" // tien mat la loai 8
            //         orderby tbl_dstaikhoan.matk
            //         select tbl_dstaikhoan;
            //foreach (var item in rs)
            //{
            //    ComboboxItem cb = new ComboboxItem();
            //    cb.Value = item.matk.Trim();
            //    cb.Text = item.matk.Trim() + ": " + item.tentk;
            //    CombomCollection.Add(cb);
            //}

            //cbtkco.DataSource = CombomCollection;

            //#endregion load tk nợ



            //   try
            //{
            //    this.phieuchiid = (int)this.dataGridViewListphieuchi.Rows[this.dataGridViewListphieuchi.CurrentCell.RowIndex].Cells["ID"].Value;


            //}
            //catch (Exception)
            //{

            //    this.phieuchiid = 0;
            //}

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
            ////        Model.Phieuthuchi.reloaddetailtaikhoannophieuchi(this.dataGridViewTkNo, this, phieuchi.tkno.Trim(), phieuchi.sophieuthu);
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
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);






        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.statusphieu = 2;

            btluu.Visible = true;


            datepickngayphieu.Enabled = true;




            txttennguoinhan.Enabled = true;
            txtdiachi.Enabled = true;
            txtdiengiai.Enabled = true;

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
                txttennguoinhan.Focus();

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
                txtdiachi.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                txtdiengiai.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
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

            //   Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
            //  For Each c As DataGridViewColumn In dataGridViewListphieuthu.Columns

            foreach (var c in dataGridViewDetail.Columns)
            {
                DataGridViewColumn clm = (DataGridViewColumn)c;
                clm.HeaderText = clm.HeaderText.Replace("_", " ");
            }

            // Next

        }


        void cbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(EndEdit));

        }
        ComboBox cbm;
        DataGridViewCell currentCell;

        //  private DateTimePicker cellDateTimePicker = new DateTimePicker();
        // DateTimePicker[] sp = new DateTimePicker[100];
        void EndEdit()
        {




            if (cbm != null)
            {
                if (cbm.SelectedItem != null)
                {
                    string SelectedItem = (cbm.SelectedItem as ComboboxItem).Value.ToString();// (cbm.SelectedItem as ComboboxItem).Value.ToString();

                    // int i = dataGridProgramdetail.CurrentRow.Index;
                    int i = currentCell.RowIndex;
                    string colname = this.dataGridViewDetail.Columns[this.dataGridViewDetail.CurrentCell.ColumnIndex].Name;

                    dataGridViewDetail.Rows[i].Cells[colname].Value = SelectedItem;





                }


            }


        }

        private void dataGridViewTkCo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {

                cbm = (ComboBox)e.Control;

                if (cbm != null)
                {
                    cbm.SelectedIndexChanged += new EventHandler(cbm_SelectedIndexChanged);
                }


                currentCell = this.dataGridViewDetail.CurrentCell;




            }
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
            ///
            //    DataGridView view = (DataGridView)sender;
            //     int i = view.CurrentRow.Index;
            //    string colname = view.Columns[view.CurrentCell.ColumnIndex].Name;
            //     string SelectedItem = view.Rows[i].Cells["Tk_Nợ"].Value.ToString();



            FormCollection fc = System.Windows.Forms.Application.OpenForms;

            bool kq = false;
            foreach (Form frm in fc)
            {
                if (frm.Text == "SELECT")


                {
                    kq = true;
                    frm.Focus();

                }
            }

            if (!kq && e.RowIndex >= 0 && dataGridViewDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string username = Utils.getusername();

                string columhead = dataGridViewDetail.Columns[e.ColumnIndex].HeaderText.ToString();
                string valueseach = dataGridViewDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                IQueryable rs = null;
                if (columhead == "Description")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.Description.Contains(valueseach)
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }

                if (columhead == "ITEM Code")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.ITEM_Code.Contains(valueseach)
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }
                if (columhead == "Sap Code")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.SAP_CODE.Contains(valueseach)
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }

                if (columhead == "MATERIAL")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.MATERIAL.Contains(valueseach)
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }

                if (columhead == "Unit")
                {
                    rs = from pp in dc.tbl_MKT_Stockends
                         where pp.UNIT.Contains(valueseach)
                         select new
                         {
                             pp.ITEM_Code,
                             pp.SAP_CODE,
                             pp.MATERIAL,
                             pp.Description,
                             pp.UNIT,
                             Avaiable_stock = pp.END_STOCK,

                             pp.id,

                         };

                }
                //  MessageBox.Show(columhead);
                if (rs != null)
                {
                    View.MKTViewchooseiquery selectkq = new MKTViewchooseiquery(rs, dc, "PLEASE SELECT PRODUCTS ", columhead);
                    selectkq.ShowDialog();
                    int id = selectkq.id;

                    //dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Description", typeof(string)));
                    //dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

                    //dt.Columns.Add(new DataColumn("Unit", typeof(string)));
                    //dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
                    //dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));


                    var valuechon = (from pp in dc.tbl_MKT_Stockends
                                     where pp.id == id
                                     select pp).FirstOrDefault();


                    dataGridViewDetail.Rows[e.RowIndex].Cells["MATERIAL"].Value = valuechon.MATERIAL;
                    dataGridViewDetail.Rows[e.RowIndex].Cells["Description"].Value = valuechon.Description;
                    dataGridViewDetail.Rows[e.RowIndex].Cells["ITEM_Code"].Value = valuechon.ITEM_Code;
                    dataGridViewDetail.Rows[e.RowIndex].Cells["Sap_Code"].Value = valuechon.SAP_CODE;
                    dataGridViewDetail.Rows[e.RowIndex].Cells["Avaiable_Quantity"].Value = valuechon.END_STOCK;
                    dataGridViewDetail.Rows[e.RowIndex].Cells["Unit"].Value = valuechon.UNIT;




                }

                //   }

            }




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

        private void dataGridViewListphieuchi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

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
            if (tabControl1.TabIndex == 2) //  Danh sách phiếu

            {
                // string valueinput = cb_customerka.Text;

                string connection_string = Utils.getConnectionstr();
                LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                string username = Utils.getusername();


                var rs = from pp in dc.tbl_MKt_Listphieus
                         where pp.Status == "CRT"
                         select new
                         {
                             Date = pp.Ngaytaophieu,
                             pp.Gate_pass,
                             pp.Requested_by,
                             pp.Purpose,


                             pp.Receiver_by,
                             pp.Customer_SAP_Code,
                             pp.Address,
                             pp.Materiacode,
                             //  pp.MateriaSAPcode,
                             pp.Description,
                             pp.Issued,
                             pp.id,

                         };
                dataGridViewListphieu.DataSource = rs;





            }
        }

        private void dataGridViewDetail_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridViewDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{



        }
    }
}
