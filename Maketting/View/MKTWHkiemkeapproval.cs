﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maketting.Control;

namespace Maketting.View
{


    public partial class MKTWHkiemkeapproval : Form
    {

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public int namchon { get; set; }

        public MKTWHkiemkeapproval(int namchon)
        {
            InitializeComponent();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            this.namchon = namchon;
        

            var kq = from p in dc.CDKT200Daukies
                     where p.nam == namchon
                     select new
                     {
                         Chỉ_tiêu = p.Tenchitieu,
                         Mã_số = p.Machitieu,
                         Cách_ghi = p.Cachghi,
                         Số_đầu_kỳ = p.Sotien,
                         ID = p.id

                     }; ;
            if (kq.Count() > 0)
            {

                Utils ut = new Utils();
                var tble1 = ut.ToDataTable(dc, kq);

                dataGridView1.DataSource = tble1;






            }
            else
            {
                var kq2 = from p in dc.CDKT200Daukies
                          where p.nam == 2006
                          select new
                          {
                              Chỉ_tiêu = p.Tenchitieu,
                              Mã_số = p.Machitieu,
                              Cách_ghi = p.Cachghi,
                              Số_đầu_kỳ = p.Sotien,
                              ID = p.id

                          };

                Utils ut = new Utils();
                var tble2 = ut.ToDataTable(dc, kq2);

                dataGridView1.DataSource = tble2;


            }

            dataGridView1.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.Columns["Mã_số"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Mã_số"].ReadOnly = true;
            dataGridView1.Columns["Cách_ghi"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Cách_ghi"].ReadOnly = true;

            dataGridView1.Columns["Chỉ_tiêu"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Chỉ_tiêu"].ReadOnly = true;

            dataGridView1.Columns["Số_đầu_kỳ"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Số_đầu_kỳ"].DefaultCellStyle.BackColor = Color.BurlyWood;

            //        idtk = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;



            //    }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Bạn phải chọn một xe !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //Model.Nhacungcap.suathongtinxe(idtk);
            //            var rs = Model.Nhacungcap.danhsachxe(dc);
            //dataGridView1.DataSource = rs;

            //            //   Tải_trọng = p.sotantai,
            //            //      Kích_thước_thùng = p.sokhoithungxe,
            //            dataGridView1.Columns["Tải_trọng"].DefaultCellStyle.Format = "N0"; // để hiện số có dấu phảy
            //            dataGridView1.Columns["Kích_thước_thùng"].DefaultCellStyle.Format = "N0"; // để hiện số có dấu phảy

        }


        private void txt_vendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //      cb_subid.Focus();


            }

        }

        private void txt_represennt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //txt_sponsoramt.Focus();


            }
        }

        private void txt_chananame_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                // txt_paidamt.Focus();


            }
        }

        private void txt_houseno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //txt_balance.Focus();


            }
        }

        private void txt_district_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //txt_paymentamount.Focus();


            }
        }

        private void txt_provicen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //txt_balancenew.Focus();


            }
        }

        private void txt_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                //txt_contractno.Focus();


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }


        private void txt_paymentamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_paymentamount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                //txt_note.Focus();
            }








        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Createpayment_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btchangecontractitem_Click(object sender, EventArgs e)
        {

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);



            var kq = (from p in dc.CDKT200Daukies
                      where p.nam == namchon
                      select p);
            if (kq.Count() > 0)
            {
                foreach (var c in dataGridView1.Rows)
                {
                    DataGridViewRow ro = (DataGridViewRow)c;
                    int id2 = (int)ro.Cells["ID"].Value;
                    var ma = (from p in dc.CDKT200Daukies
                              where p.id == id2
                              select p).FirstOrDefault();


                    if (ma != null)
                    {

                        ma.Machitieu = (int)ro.Cells["Mã_số"].Value;
                        ma.Tenchitieu = (string)ro.Cells["Chỉ_tiêu"].Value;
                        ma.Cachghi = (string)ro.Cells["Cách_ghi"].Value;
                        ma.Sotien = (double)ro.Cells["Số_đầu_kỳ"].Value;
                        ma.stat = 0;
                        ma.username = Utils.getname();

                     
                        dc.SubmitChanges();
                    }

                 
                }



               
            }
            else
            {

                foreach (var c in dataGridView1.Rows)
                {

                    // Chỉ_tiêu = p.Tenchitieu,
                    //          Mã_số = p.Machitieu,
                    //          Cách_ghi = p.Cachghi,
                    //          Số_cuối_năm = p.Sotien,
                    //          ID = p.id
                    DataGridViewRow ro = (DataGridViewRow)c;
                    CDKT200Dauky p = new CDKT200Dauky();
                    p.nam = this.namchon;
                  
                    p.Machitieu = (int)ro.Cells["Mã_số"].Value;
                    p.Tenchitieu = (string)ro.Cells["Chỉ_tiêu"].Value;
                    p.Cachghi = (string)ro.Cells["Cách_ghi"].Value;
                    p.Sotien = (double)ro.Cells["Số_đầu_kỳ"].Value;
                    p.stat = 0;
                    p.username = Utils.getname();
                   
                    dc.CDKT200Daukies.InsertOnSubmit(p);
                    dc.SubmitChanges();
                }



                //int id = (int)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value;
                //var 






            }
            MessageBox.Show("Đã cập nhật theo dữ liệu nhập vào ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void txtten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
    }


}
