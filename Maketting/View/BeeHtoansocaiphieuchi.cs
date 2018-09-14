﻿using System;
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
    public partial class BeeHtoansocaiphieuchi : Form
    {
        View.BeePhieuchi phieuchi;
     
        public int tkcochitiet { get; set; }
        public bool click { get; set; }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public double pssotienno { get; set; }
        public double pssotienco { get; set; }

        public BeeHtoansocaiphieuchi(View.BeePhieuchi phieuchi, string labe1, string labe2, string labe3)
        {




            InitializeComponent();
            //if (phieuthu.pssotienno =="")
            //{
            //    phieuthu.pssotienno = "0";
            //}
            //if (phieuthu.pssotienco == "")
            //{
            //    phieuthu.pssotienco = "0";
            //}
            txtTongno.Text = phieuchi.pssotienno.ToString("#,#", CultureInfo.InvariantCulture);
            txtTongco.Text = phieuchi.pssotienco.ToString("#,#", CultureInfo.InvariantCulture);

            this.pssotienco = phieuchi.pssotienco;
            this.pssotienno = phieuchi.pssotienno;

            txtChenlech.Text = (-this.pssotienno + this.pssotienco).ToString("#,#", CultureInfo.InvariantCulture);

            #region clearr to new

            cbtkno.SelectedIndex = -1;
            tbmachitiet.Text = "";
            lbtenchitiet.Text = "";
            txtsotien.Text = "";
            txtdiachi.Text = "";
      //      txtkyhieuctu.Text = "";
       //     txtsochungtu.Text = "";

            #endregion




            this.click = false;
            this.phieuchi = phieuchi;



            #region load tk nợ

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs1 = from tk in dc.tbl_dstaikhoans
                     // where tk.loaitkid == 5 || tk.loaitkid == 9 || tk.loaitkid == 7  // 5.nguon von;  7 phai tra; 9. tam ung
                      select tk;

            //      string drowdownshow = "";

            foreach (var item in rs1)
            {
                ComboboxItem cb = new ComboboxItem();
                cb.Value = item.matk;
                cb.Text = item.matk + ":" + item.tentk;
                this.cbtkno.Items.Add(cb); // CombomCollection.Add(cb);

            }

            #endregion load tk nợ





        }

  


        private void Seachcode_Deactivate(object sender, EventArgs e)
        {
             //   this.Close();
        }


        public void sendingtext_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void sendingcontract_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{


            //    txt03.Focus();

            //    //if (tablename == "KASeachcontract")
            //    //{
            //    //   // Fromviewable.ReloadKASeachcontract(this.sendingcode.Text, this.sendingcontract.Text, this.sendingname.Text, this.txtvat.Text);
            //    //}



            //}
        }

        private void sendingname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtvat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //   if (e.KeyChar == (char)Keys.Enter)
            //   {


            //       this.text01.Focus();

            ////       if (tablename == "KASeachcontract")
            ////       {
            //////           Fromviewable.ReloadKASeachcontract(this.sendingcode.Text, this.sendingcontract.Text, this.sendingname.Text, this.txtvat.Text);
            ////       }



            //   }
        }


        private void bt_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{


            //       this.text01.Focus();
            //   // this.bt_timkiem.Focus();

            //    //if (tablename == "KASeachcontract")
            //    //{
            //    //  //  Fromviewable.ReloadKASeachcontract(this.sendingcode.Text, this.sendingcontract.Text, this.sendingname.Text, this.txtvat.Text);
            //    //}



            //}
        }

        private void BeeHtoansocaidoiungphieuthu_Load(object sender, EventArgs e)
        {

        }

        private void cbtkco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbtenchitiet.Visible = true;

            string taikhoan = (cbtkno.SelectedItem as ComboboxItem).Value.ToString();
            //     this.matk = taikhoan;


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext db = new LinqtoSQLDataContext(connection_string);


            var detail = (from c in db.tbl_dstaikhoans
                          where c.matk.Trim() == taikhoan.Trim()
                          select c).FirstOrDefault();



            if (detail.loaichitiet == true) // là co theo doi chi tiết

            {

                List<MKTselectinput.ComboboxItem> listcb = new List<MKTselectinput.ComboboxItem>();
                var rs = from tbl_machitiettk in db.tbl_machitiettks
                         where tbl_machitiettk.matk.Trim() == taikhoan.Trim()
                         orderby tbl_machitiettk.machitiet
                         select tbl_machitiettk;
                if (rs.Count() > 0)
                {


                    foreach (var item2 in rs)
                    {
                        MKTselectinput.ComboboxItem cb = new MKTselectinput.ComboboxItem();
                        cb.Value = item2.machitiet.ToString().Trim();
                        cb.Text = item2.tenchitiet; //item2.machitiet.ToString().Trim() + ": " +
                        listcb.Add(cb);
                    }



                    View.MKTselectinput selecdetail = new MKTselectinput("Chọn chi tiết tài khoản ", listcb);

                    selecdetail.ShowDialog();
                    bool chon = selecdetail.kq;
                    if (chon)
                    {
                        string machitiet = selecdetail.value;
                        string namechitiet = selecdetail.valuetext;
                        //     lbmachitietco.Visible = true;

                        lbtenchitiet.Visible = true;
                        this.tkcochitiet = int.Parse(selecdetail.value.ToString());


                        tbmachitiet.Text = machitiet;
                        lbtenchitiet.Text = namechitiet;
                    }
                    else
                    {
                        cbtkno.SelectedIndex = -1;
                    }

                }
                else
                {
                    tbmachitiet.Text = "";
                    lbtenchitiet.Text = "";//namechitiet;
                }
                //  selecdetail.Text;

            }
            else
            {
                tbmachitiet.Text = "";
                lbtenchitiet.Text = "";//namechitiet;
            }


            txtsotien.Focus();




        }

        private void txtsotien_KeyPress(object sender, KeyPressEventArgs e)
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
           //     datepickngayphieu.Focus();

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
                //  cbsophieu.
                e.Handled = true;
        //        txtkyhieuctu.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtkyhieuctu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
           //     txtsochungtu.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtsochungtu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  cbsophieu.
                e.Handled = true;
                bt_themvao.Focus();

                //    string valueinput = cb_customerka.Text;

                //    string connection_string = Utils.getConnectionstr();
                //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

                //    string username = Utils.getusername();


            }
        }

        private void txtsotien_TextChanged(object sender, EventArgs e)
        {
            //if (!Utils.IsValidnumber(txtsotien.Text.ToString()))
            //{
            //    txtsotien.Text = "";
            //}

        }

        private void bt_themvao_Click(object sender, EventArgs e)
        {
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            tbl_Socai socaitemp = new tbl_Socai();

            //if (this.cb_channel.SelectedItem != null)
            if (cbtkno.SelectedItem != null)
            {
                socaitemp.TkNo = (cbtkno.SelectedItem as ComboboxItem).Value.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbtkno.Focus();
                return;
            }

            if (Utils.IsValidnumber(txtsotien.Text))
            {
                socaitemp.PsNo = double.Parse(txtsotien.Text.Trim());
            }
            else
            {
                MessageBox.Show("Số tiền gõ vào phải là số !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsotien.Focus();
                return;
            }



            // txtdiachi

            if (txtdiachi.Text != "")
            {
                socaitemp.Diengiai = txtdiachi.Text;
            }
            else
            {
                MessageBox.Show("Bạn chưa gõ diễn giải", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            //datepickngayphieu

            //socaitemp.Ngayctu = datepickngayphieu.Value;

            ////     txtkyhieuctu
            //if (txtkyhieuctu.Text != "")
            //{
            //    socaitemp.Kyhieuctu = txtkyhieuctu.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa gõ Tên chi tiét", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtkyhieuctu.Focus();
            //    return;
            //}

            //lbtenchitiet
            if (lbtenchitiet.Text != "")
            {
                socaitemp.tenchitietCo = lbtenchitiet.Text;
            }
            //else
            //{
            //    MessageBox.Show("Bạn chưa gõ mã chi tiết", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtkyhieuctu.Focus();
            //    return;
            //}


            // tbmachitiet

            if (tbmachitiet.Text != "")
            {
                socaitemp.MaCTietTKCo = int.Parse(tbmachitiet.Text.ToString());
            }



            //   txtsochungtu


            //if (Utils.IsValidnumber(txtsochungtu.Text))
            //{
            //    socaitemp.Soctu = int.Parse(txtsochungtu.Text.Trim());
            //}
            //else
            //{
            //    MessageBox.Show("Kiểm tra lại số chứng từ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtsochungtu.Focus();
            //    return;
            //}




            this.phieuchi.add_detailGridviewTkNophieuchi(socaitemp);

            txtTongco.Text = phieuchi.pssotienco.ToString("#,#", CultureInfo.InvariantCulture);
            txtTongno.Text = phieuchi.pssotienno.ToString("#,#", CultureInfo.InvariantCulture);

            this.pssotienco = phieuchi.pssotienco;
            this.pssotienno = phieuchi.pssotienno;

            txtChenlech.Text = (-phieuchi.pssotienno + phieuchi.pssotienco).ToString("#,#", CultureInfo.InvariantCulture);

            #region clearr to new

            cbtkno.SelectedIndex = -1;
            tbmachitiet.Text = "";
            lbtenchitiet.Text = "";
            txtsotien.Text = "";
            txtdiachi.Text = "";
          
            #endregion






        }

        private void BeeHtoansocaidoiungphieuthu_Deactivate(object sender, EventArgs e)
        {
           // this.Close();
        }
    }
}
