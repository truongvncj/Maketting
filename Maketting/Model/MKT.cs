using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Maketting.Model
{
    public class MKT
    {


        public static bool checkIObudget(string sophieu, string kho) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            //   string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            //var rs3 = (from pp in dc.tbl_MKt_Listphieuheads
            //           where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
            //           select pp.LoadNumber).FirstOrDefault();

            //if (rs3 != null)
            //{
            //    MessageBox.Show("Note " + sophieu + " can not delete detail by load created !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}


            //var rs2 = from pp in dc.tbl_MKt_Listphieudetails
            //          where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
            //          select pp;


            //if (rs2.Count() > 0)
            //{
            //    dc.tbl_MKt_Listphieudetails.DeleteAllOnSubmit(rs2);
            //    dc.SubmitChanges();

            //}
            //else
            //{
            //    MessageBox.Show("Please check phiếu: " + sophieu + " can not delete detail!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            //var rs = from pp in dc.tbl_MKt_Listphieuheads
            //         where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
            //         select pp;

            //if (rs.Count() > 0)
            //{
            //    dc.tbl_MKt_Listphieuheads.DeleteAllOnSubmit(rs);
            //    dc.SubmitChanges();
            //}
            //else
            //{
            //    MessageBox.Show("Please check phiếu: " + sophieu + " can not delete head!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            return true;
        }


        public static DataGridView Loadnewdetail(DataGridView dataGridViewDetail)
        {


            dataGridViewDetail.DataSource = null;
            #region datatable temp




            DataTable dt = new DataTable();


            dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
            dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
            dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));
            dt.Columns.Add(new DataColumn("Price", typeof(float)));




            dataGridViewDetail.DataSource = dt;
            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewDetail.Columns["Avaiable_Quantity"].ReadOnly = true;
            dataGridViewDetail.Columns["Avaiable_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            dataGridViewDetail.Columns["Price"].ReadOnly = true;
            dataGridViewDetail.Columns["Price"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;


            dataGridViewDetail.Columns["Price"].DefaultCellStyle.Format = "N0";
            dataGridViewDetail.Columns["Avaiable_Quantity"].DefaultCellStyle.Format = "N0";
            dataGridViewDetail.Columns["Issue_Quantity"].DefaultCellStyle.Format = "N0";



            #endregion datatable temp


            return dataGridViewDetail;





            //  throw new NotImplementedException();
        }

        public static DataGridView LoadnewdetailTRANSfer(DataGridView dataGridViewDetail)
        {

            //drToAdd["MATERIAL"] = itemdetail.Materialname;
            //drToAdd["Description"] = itemdetail.Description;
            //drToAdd["ITEM_Code"] = itemdetail.MateriaItemcode;
            //drToAdd["Sap_Code"] = itemdetail.MateriaSAPcode;
            //drToAdd["Unit"] = itemdetail.Unit;
            //drToAdd["Quantity"] = itemdetail.Quantity;

            dataGridViewDetail.DataSource = null;
            #region datatable temp




            DataTable dt = new DataTable();


            dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
            dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(float)));
            dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));




            dataGridViewDetail.DataSource = dt;
            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewDetail.Columns["Avaiable_Quantity"].ReadOnly = true;
            dataGridViewDetail.Columns["Avaiable_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;



            dataGridViewDetail.Columns["Quantity"].DefaultCellStyle.Format = "N0";
            dataGridViewDetail.Columns["Avaiable_Quantity"].DefaultCellStyle.Format = "N0";
         

            #endregion datatable temp


            return dataGridViewDetail;



            //  throw new NotImplementedException();
        }

        public static void DeleteALLphieuDetailPOtamTMP()
        {

            string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_POdetail_TMPs
                     where pp.Username == urs && pp.StatusPO == "TMP"
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKt_POdetail_TMPs.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }



            // throw new NotImplementedException();
        }

        public static string getNewTransferNumber()
        {
            string connection_string = Utils.getConnectionstr();
            string urs = Utils.getusername();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            tbl_MKt_TransferoutHEAD newtmp = new tbl_MKt_TransferoutHEAD();

            newtmp.Username = urs;
            newtmp.Status = "TMP";

            dc.tbl_MKt_TransferoutHEADs.InsertOnSubmit(newtmp);

            dc.SubmitChanges();


            var phieuid = (from p in dc.tbl_MKt_TransferoutHEADs
                           where p.Status == "TMP" && p.Username == urs
                           select p.id).FirstOrDefault();


            return phieuid.ToString();







            //  throw new NotImplementedException();
        }

        public static void DeleteALLphieuDetailTransfertamTMP()
        {


            string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_TransferoutdetailTMPs
                     where pp.Username == urs && pp.Status == "TMP"
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKt_TransferoutdetailTMPs.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }



            // throw new NotImplementedException();
        }

        public static DataGridView LoadnewdetailPO(DataGridView dataGridViewDetail)
        {




            dataGridViewDetail.DataSource = null;
            #region datatable temp




            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Region", typeof(string)));
            dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
            dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            dt.Columns.Add(new DataColumn("PO_Quantity", typeof(float)));
            dt.Columns.Add(new DataColumn("Unit_Price", typeof(float)));
            //     dt.Columns.Add(new DataColumn("Avaiable_Quantity", typeof(float)));




            dataGridViewDetail.DataSource = dt;
            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            //  dataGridViewDetail.Columns["Avaiable_Quantity"].ReadOnly = true;
            //   dataGridViewDetail.Columns["Avaiable_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;



            dataGridViewDetail.Columns["Unit_Price"].DefaultCellStyle.Format = "N0";
            dataGridViewDetail.Columns["PO_Quantity"].DefaultCellStyle.Format = "N0";




            #endregion datatable temp


            return dataGridViewDetail;





            // throw new NotImplementedException();
        }

        public static void restatusphieuLoadingtoCRT()
        {
          
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            string urs = Utils.getusername();

            var rs = from pp in dc.tbl_MKt_Listphieudetails
                     where pp.Status == "LOADING" && pp.Username == urs

                     select pp;

            if (rs != null)
            {
                foreach (var item in rs)
                {
                    item.Status = "CRT";
                    dc.SubmitChanges();


                }



            }

        }

        public static IQueryable DanhsachPhieuMKTtoDLV(string storelocation)
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKt_Listphieudetails
                     from pp in dc.tbl_MKt_Listphieuheads
                     where p.ShippingPoint == storelocation && p.Status == "CRT"
                   && p.Gate_pass == pp.Gate_pass
                     orderby p.Gate_pass
                     select new
                     {


                         Gate_pass = p.Gate_pass,
                         Code_KH = p.Customer_SAP_Code,
                         Shipto_code = pp.ShiptoCode,
                         Địa_chỉ = pp.ShiptoAddress,
                         Điện_thoại = pp.Tel,

                         p.Materiacode,
                         p.Materialname,
                         Số_lượng_xuất = p.Issued,
                         p.Ngaytaophieu,
                         p.Purpose,
                         p.Receiver_by,
                         // p.Tel,

                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;







            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable DanhsachPhieuMKTandstatus(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate)
        {


            var rs = from p in dc.tbl_MKt_Listphieudetails
                     where p.Ngaytaophieu >= fromdate && p.Ngaytaophieu <= todate
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,

                         p.Requested_by,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Address,

                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         p.Price,
                         p.Tranposterby,
                         p.Truck,
                         p.Loadingby,
                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,







                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }






        public static DataGridView Getbankdetailload(DataGridView dataGridViewDetailload)
        {


            dataGridViewDetailload.DataSource = null;
            #region datatable temp




            DataTable dt = new DataTable();


            dt.Columns.Add(new DataColumn("Gate_pass", typeof(string)));
            dt.Columns.Add(new DataColumn("Customer_Code", typeof(string)));
            dt.Columns.Add(new DataColumn("Receiver_by", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));
            dt.Columns.Add(new DataColumn("Materiacode", typeof(string)));
            dt.Columns.Add(new DataColumn("Materialname", typeof(string)));
            dt.Columns.Add(new DataColumn("Issued", typeof(string)));

       

            dataGridViewDetailload.DataSource = dt;


        
            #endregion datatable temp


            return dataGridViewDetailload;






        }

        public static void DeleteALLphieutamTMP() // vd phieu thu nghiep vu là phieu thu: PT,
        {
            string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_Listphieuheads
                     where pp.Username == urs && pp.Status == "TMP"
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKt_Listphieuheads.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }
        }


        public static void DeleteALLChannelTMP(LinqtoSQLDataContext dc) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            string urs = Utils.getusername();

            //     string connection_string = Utils.getConnectionstr();
            //     LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKT_CustomerChaneltmps
                     where pp.username == urs
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKT_CustomerChaneltmps.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }
        }



        public static void DeleteALLIOTMP(LinqtoSQLDataContext dc) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            string urs = Utils.getusername();

            //     string connection_string = Utils.getConnectionstr();
            //     LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKT_IO_ProgrameTMPs
                     where pp.Username == urs
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKT_IO_ProgrameTMPs.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }
        }


        public static void DeletePaymentaprovalTMP(LinqtoSQLDataContext dc) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            string urs = Utils.getusername();

            //     string connection_string = Utils.getConnectionstr();
            //     LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKT_Payment_AprovalTMPs
                     where pp.username == urs
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKT_Payment_AprovalTMPs.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }
        }


        public static void DeleteALLIPricelistIOTMP(LinqtoSQLDataContext dc) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            string urs = Utils.getusername();

            //     string connection_string = Utils.getConnectionstr();
            //     LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKT_ProgramepriceproductTMPs
                     where pp.Username == urs
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKT_ProgramepriceproductTMPs.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }
        }


        public static void DeleteALLTransferphieutamTMP(LinqtoSQLDataContext dc, string urs) // vd phieu thu nghiep vu là phieu thu: PT,
        {


            var rs = from pp in dc.tbl_MKt_TransferoutHEADs
                     where pp.Username == urs && pp.Status == "TMP"
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKt_TransferoutHEADs.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
                //  dc.Connection.Close();
            }
        }

        public static void DeleteALLLoadtamTMP() // vd phieu thu nghiep vu là phieu thu: PT,
        {
            string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_ListLoadheads
                     where pp.Username == urs && pp.Status == "TMP"
                     select pp;

            if (rs.Count() > 0)
            {
                dc.tbl_MKt_ListLoadheads.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
            }


        }


        public static string getLoadNo()
        {

            string connection_string = Utils.getConnectionstr();
            string urs = Utils.getusername();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            tbl_MKt_ListLoadhead newtmp = new tbl_MKt_ListLoadhead();

            newtmp.Username = urs;
            newtmp.Status = "TMP";

            dc.tbl_MKt_ListLoadheads.InsertOnSubmit(newtmp);

            dc.SubmitChanges();


            var phieuid = (from p in dc.tbl_MKt_ListLoadheads
                           where p.Status == "TMP" && p.Username == urs
                           select p.id).FirstOrDefault();


            return phieuid.ToString();





            //throw new NotImplementedException();
        }

        public static bool Deletephieu(string sophieu, string kho) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            //   string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs3 = (from pp in dc.tbl_MKt_Listphieuheads
                       where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                       select pp.LoadNumber).FirstOrDefault();

            if (rs3 != null)
            {
                MessageBox.Show("Note " + sophieu + " can not delete detail by load created !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                      where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                      select pp;


            if (rs2.Count() > 0)
            {
                dc.tbl_MKt_Listphieudetails.DeleteAllOnSubmit(rs2);
                dc.SubmitChanges();

            }
            else
            {
                MessageBox.Show("Please check phiếu: " + sophieu + " can not delete detail!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var rs = from pp in dc.tbl_MKt_Listphieuheads
                     where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                     select pp;

            if (rs.Count() > 0)
            {
                dc.tbl_MKt_Listphieuheads.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Please check phiếu: " + sophieu + " can not delete head!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static void tangkhokhinhaphang(tbl_MKt_WHstoreissue itemnhap, string storecode)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKT_Stockends
                     where p.ITEM_Code == itemnhap.Materiacode
                             && p.Store_code == storecode
                     select p;

            if (rs.Count() > 0)
            {
                foreach (var item in rs)
                {
                    item.END_STOCK = item.END_STOCK + itemnhap.RecieptQuantity;
                    dc.SubmitChanges();
                }

            }
            else
            {

                tbl_MKT_Stockend newitem = new tbl_MKT_Stockend();
                newitem.END_STOCK = itemnhap.RecieptQuantity;
                newitem.ITEM_Code = itemnhap.Materiacode;
                newitem.SAP_CODE = itemnhap.Materiacode;
                newitem.Store_code = storecode;
                newitem.UNIT = itemnhap.Unit;
                newitem.END_STOCK = itemnhap.RecieptQuantity;
                newitem.END_STOCK = itemnhap.RecieptQuantity;


                dc.tbl_MKT_Stockends.InsertOnSubmit(newitem);

                dc.SubmitChanges();
            }




            //  throw new NotImplementedException();
        }

        public static void updatetangOrdered(string itemCode, double ordered, string Store_code)
        {


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var valueitem = (from p in dc.tbl_MKT_Stockends
                     where p.ITEM_Code == itemCode
                     && p.Store_code == Store_code
                     select p).FirstOrDefault();

            if (valueitem != null)
            {
                valueitem.Ordered = valueitem.Ordered.GetValueOrDefault(0) + ordered;

                dc.SubmitChanges();

            }










            //throw new NotImplementedException();
        }

        public static void tranferoutrequestmakechange(tbl_MKt_Transferoutdetail itemout)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKT_Stockends
                     where p.ITEM_Code == itemout.MateriaItemcode
                     && p.Store_code == itemout.Store_OUT
                     select p;

            if (rs.Count() > 0)
            {
                foreach (var item in rs)
                {
                    item.END_STOCK = item.END_STOCK.GetValueOrDefault(0) - itemout.Quantity;
                    item.TransferingOUT = item.TransferingOUT.GetValueOrDefault(0) + itemout.Quantity;
                    dc.SubmitChanges();
                }

            }





            //  throw new NotImplementedException();
        }

        public static void tranferinmakechange(tbl_MKt_TransferINdetail itemIN)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKT_Stockends
                     where p.ITEM_Code == itemIN.MateriaItemcode
                     && p.Store_code == itemIN.Store_OUT
                     select p;

            if (rs.Count() > 0)
            {
                foreach (var item in rs)
                {
                    //     item.END_STOCK = item.END_STOCK.GetValueOrDefault(0) - itemIN.Quantity;
                    item.TransferingOUT = item.TransferingOUT.GetValueOrDefault(0) - itemIN.Reciepted_Quantity;
                    dc.SubmitChanges();
                }

            }


            var rs2 = from p in dc.tbl_MKT_Stockends
                      where p.ITEM_Code == itemIN.MateriaItemcode
                      && p.Store_code == itemIN.Store_IN
                      select p;

            if (rs2.Count() > 0)
            {
                foreach (var item in rs2)
                {
                    item.END_STOCK = item.END_STOCK.GetValueOrDefault(0) + itemIN.Reciepted_Quantity;
                    //   item.TransferingOUT = item.TransferingOUT.GetValueOrDefault(0) - itemIN.Reciepted_Quantity;
                    dc.SubmitChanges();
                }

            }
            else
            {

                tbl_MKT_Stockend newproduct = new tbl_MKT_Stockend();

                newproduct.Description = itemIN.Description;
                newproduct.MATERIAL = itemIN.Materialname;


                newproduct.END_STOCK = itemIN.Reciepted_Quantity;

                newproduct.ITEM_Code = itemIN.MateriaItemcode;

                newproduct.SAP_CODE = itemIN.MateriaSAPcode;

                newproduct.Store_code = itemIN.Store_IN;

                newproduct.UNIT = itemIN.Unit;

                newproduct.Ordered = 0;

                newproduct.Description = itemIN.Description;



                dc.tbl_MKT_Stockends.InsertOnSubmit(newproduct);
                dc.SubmitChanges();

            }



            //  throw new NotImplementedException();
        }


        public static void tranferoutrequestdelete(tbl_MKt_Transferoutdetail itemout, string storecode)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKT_Stockends
                     where p.ITEM_Code == itemout.MateriaItemcode
                          && p.Store_code == storecode
                     select p;

            if (rs.Count() > 0)
            {
                foreach (var item in rs)
                {
                    item.END_STOCK = item.END_STOCK + itemout.Quantity;
                    item.TransferingOUT = item.TransferingOUT - itemout.Quantity;
                    dc.SubmitChanges();
                }

            }





            //  throw new NotImplementedException();
        }

        public static string getMKtNo()
        {
            string connection_string = Utils.getConnectionstr();
            string urs = Utils.getusername();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            tbl_MKt_Listphieuhead newtmp = new tbl_MKt_Listphieuhead();

            newtmp.Username = urs;
            newtmp.Status = "TMP";

            dc.tbl_MKt_Listphieuheads.InsertOnSubmit(newtmp);

            dc.SubmitChanges();


            var phieuid = (from p in dc.tbl_MKt_Listphieuheads
                           where p.Status == "TMP" && p.Username == urs
                           select p.id).FirstOrDefault();


            return phieuid.ToString();





        }
        public static string getPOnumberNo()
        {
            string connection_string = Utils.getConnectionstr();
            string urs = Utils.getusername();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            tbl_MKt_POhead newtmp = new tbl_MKt_POhead();

            newtmp.Username = urs;
            newtmp.Status = "TMP";

            dc.tbl_MKt_POheads.InsertOnSubmit(newtmp);

            dc.SubmitChanges();


            var phieuid = (from p in dc.tbl_MKt_POheads
                           where p.Status == "TMP" && p.Username == urs
                           select p.id).FirstOrDefault();


            return phieuid.ToString();





        }


        public static IQueryable danhkhachhang(LinqtoSQLDataContext dc)
        {
            // throw new NotImplementedException();


            LinqtoSQLDataContext db = dc;
            var rs = from p in db.tbl_MKT_Soldtocodes
                     where p.Soldtype == true
                     orderby p.Customer
                     select new
                     {

                         SalesOrg = p.SalesOrg,
                         Region = p.Region,
                         p.Chanel,
                         Customer = p.Customer,
                         FullName = p.FullNameN,
                         Street = p.Street,
                         District = p.District,
                         City = p.City,
                         Telephone = p.Telephone1,
                         Note = p.Note,
                         p.Createby,
                         p.VATregistrationNo,

                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;







            return rs;



        }


        public static IQueryable shiptolist(LinqtoSQLDataContext dc)
        {
            // throw new NotImplementedException();


            LinqtoSQLDataContext db = dc;
            var rs = from p in db.tbl_MKT_Soldtocodes
                         //    where p.Soldtype == fa
                     orderby p.Customer
                     select new
                     {

                         SalesOrg = p.SalesOrg,
                         Region = p.Region,
                         Customer = p.Customer,
                         FullName = p.FullNameN,
                         Street = p.Street,
                         District = p.District,
                         City = p.City,
                         Telephone = p.Telephone1,
                         Note = p.Note,


                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;







            return rs;



        }



        public static IQueryable shiptolistbycustomer(LinqtoSQLDataContext dc, string customercode)
        {


            // throw new NotImplementedException();


            LinqtoSQLDataContext db = dc;
            var rs = from p in db.tbl_MKT_Soldtocodes
                     where p.Customer == customercode
                     orderby p.Customer
                     select new
                     {

                         SalesOrg = p.SalesOrg,
                         Region = p.Region,
                         Customer = p.Customer,
                         FullName = p.FullNameN,
                         Street = p.Street,
                         District = p.District,
                         City = p.City,
                         Telephone = p.Telephone1,
                         Note = p.Note,


                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;







            return rs;






            //throw new NotImplementedException();
        }
        //   tbl_MKt_WHstoreissue
        public static void giamtrukhokhixuathang(tbl_MKt_WHstoreissue itemxuat)
        {


            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKT_Stockends
                     where p.ITEM_Code == itemxuat.Materiacode
                     select p;

            if (rs.Count() > 0)
            {
                foreach (var item in rs)
                {
                    item.END_STOCK = item.END_STOCK - itemxuat.Issued;
                    dc.SubmitChanges();
                }

            }

            //   Giảm ordered khi xuất hàng


            Model.MKT.updatetangOrdered(itemxuat.Materiacode, - (double)itemxuat.Issued, itemxuat.ShippingPoint);


            //   Giảm ordered khi xuất hàng


        }

        public static IQueryable DanhsachctMKT(LinqtoSQLDataContext dc)
        {


      

            LinqtoSQLDataContext db = dc;
            var rs = from p in db.tbl_MKT_IO_Programes
                     orderby p.IO_number
                     select new
                     {
                         Số_hiệu_CT = p.ProgrameIDDocno,
                         IO = p.IO_number,
                         Tên_chương_trình = p.IO_Name,
                         p.Sales_Org,
                         p.Region,
                         p.ChannelGroup,



                         Ghi_chú = p.ghichu,



                         p.Budget,

                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;



            return rs;



            //  throw new NotImplementedException();
        }


        public static IQueryable DanhsachctMKTSeachbyIOseach(LinqtoSQLDataContext dc, string ionumber)
        {


        

            LinqtoSQLDataContext db = dc;
            var rs = from p in db.tbl_MKT_IO_Programes
                     where p.IO_number.Contains(ionumber)
                     orderby p.IO_number
                     select new
                     {
                         Số_hiệu_CT = p.ProgrameIDDocno,
                         IO = p.IO_number,
                         Tên_chương_trình = p.IO_Name,
                         p.Sales_Org,
                         p.Region,
                         p.ChannelGroup,



                         Ghi_chú = p.ghichu,



                         p.Budget,

                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;



            return rs;



            //  throw new NotImplementedException();
        }


        public static IQueryable DanhsachnhavantaiMKT(LinqtoSQLDataContext dc)
        {


            LinqtoSQLDataContext db = dc;
            var rs = from p in db.tbl_MKT_Nhacungungvantais
                     orderby p.maNVT
                     select new
                     {


                         Mã_nhà_vận_tải = p.maNVT,
                         Tên_nhà_vận_tải = p.tenNVT,
                         Địa_chỉ = p.diachiNVT,
                         Điện_thoại = p.dienthoaiNVT,
                         //    Mã_số_thuế = p.masothueNVT,



                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;



            return rs;


            //throw new NotImplementedException();
        }

        public static bool Deletephieuload(string soload, string storelocation)
        {
            // deleead head

            bool kq = false;
            string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_ListLoadheads
                     where pp.LoadNumber == soload && pp.ShippingPoint == storelocation
                     select pp;

            if (rs.Count() > 0)
            {
                foreach (var item in rs)
                {
                    item.Created_by = "";
                    item.Status = "TMP";
                    dc.SubmitChanges();
                }

                kq = true;
            }


            // upload detail


            var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                      where pp.ShipmentNumber == soload && pp.ShippingPoint == storelocation
                      select pp;

            if (rs2.Count() > 0)
            {
                foreach (var item in rs2)
                {
                    item.ShipmentNumber = "";
                    item.Shipmentby = "";
                    item.Status = "CRT";
                    dc.SubmitChanges();


                }
            }




            // tbl_MKt_ListLoadheadDetail


            var rs3 = from pp in dc.tbl_MKt_ListLoadheadDetails
                      where pp.LoadNumber == soload && pp.ShippingPoint == storelocation
                      select pp;

            if (rs3.Count() > 0)
            {

                dc.tbl_MKt_ListLoadheadDetails.DeleteAllOnSubmit(rs3);

                dc.SubmitChanges();


            }

            return kq;
            // throw new NotImplementedException();
        }
        //    Model.MKT.DanhsachPhieuMKTtoDLVseach(this.storelocation, dataGridViewDetail, txtseachaddress.Text, txtseachcode.Text, txtseachgate.Text);

        public static void DanhsachPhieuMKTtoDLVseach(string storelocation, DataGridView dataGridViewDetail, string txtseachaddress, string txtseachcode, string txtseachgate)
        {



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKt_Listphieudetails
                     from pp in dc.tbl_MKt_Listphieuheads
                     where p.ShippingPoint == storelocation && p.Status == "CRT"
                            && p.Gate_pass == pp.Gate_pass
                     && p.Address.Contains(txtseachaddress)
                             && p.Customer_SAP_Code.ToString().Contains(txtseachcode)
                               && (p.ShippingPoint + p.Gate_pass).Contains(txtseachgate)


                     orderby p.Gate_pass
                     select new
                     {


                         Gate_pass = p.Gate_pass,
                         Code_KH = p.Customer_SAP_Code,
                         Shipto_code = pp.ShiptoCode,
                         Địa_chỉ = pp.ShiptoAddress,
                         Điện_thoại = pp.Tel,

                         p.Materiacode,
                         p.Materialname,
                         Số_lượng_xuất = p.Issued,
                         p.Ngaytaophieu,
                         p.Purpose,
                         p.Receiver_by,
                         // p.Tel,

                         ID = p.id,
                     };

            dataGridViewDetail.DataSource = rs;




            // throw new NotImplementedException();
        }

        public static IQueryable danhsachkhoMKT(LinqtoSQLDataContext dc)
        {

            LinqtoSQLDataContext db = dc;
            var rs = from p in db.tbl_MKT_khoMKTs
                     orderby p.makho
                     select new
                     {


                         Mã_kho = p.makho,
                         Tên_kho = p.tenkho,
                         Địa_chỉ = p.diachikho,

                         Ghi_chú = p.ghichu,
                         Nhóm = p.storeright,

                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;



            return rs;





            //  throw new NotImplementedException();
        }

        public static IQueryable danhsachsalesorglist(LinqtoSQLDataContext db)
        {


            LinqtoSQLDataContext dc = db;

            var rs = from pp in dc.tbl_MKT_SaleOrgs
                     select new
                     {
                         SaleOrg = pp.SaleOrg,
                         Note = pp.Note,

                         ID = pp.id,

                     };

            return rs;

            //   throw new NotImplementedException();
        }


        public static IQueryable danhsachregionlist(LinqtoSQLDataContext db)
        {


            LinqtoSQLDataContext dc = db;

            var rs = from pp in dc.tbl_MKT_Regions
                     select new
                     {
                         Region = pp.Region,
                         Note = pp.Note,

                         ID = pp.id,

                     };

            return rs;

            //   throw new NotImplementedException();
        }


        public static IQueryable danhsachcustomerChannel(LinqtoSQLDataContext db)
        {


            LinqtoSQLDataContext dc = db;

            var rs = from pp in dc.tbl_MKT_CustomerChanels
                     select new
                     {
                         Chanel_code = pp.Chanel_code,
                         Chanel_name = pp.Chanel_name,
                         Note = pp.Note,
                         ID = pp.id,

                     };

            return rs;

            //   throw new NotImplementedException();
        }


        public static IQueryable danhsachkhoMKTRight(LinqtoSQLDataContext db)
        {


            LinqtoSQLDataContext dc = db;

            var rs = from pp in dc.tbl_MKT_StoreRights
                     select new
                     {
                         Store_code = pp.makho,
                         Store_Right_Group = pp.storeright,
                         ID = pp.id,

                     };

            return rs;

            //   throw new NotImplementedException();
        }

        public static bool DeletePurchase(string pONumber, string storelocation)
        {
            // deleead head

            bool kq = false;
            string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_POheads
                     where pp.PONumber == pONumber && pp.StoreLocation == storelocation
                     && pp.Status == "CRT"
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKt_POheads.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();

                kq = true;
            }
            else
            {
                //  MessageBox.Show("Can not deleted please check ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return kq;
            }

            // upload detail


            var rs2 = from pp in dc.tbl_MKt_POdetails
                      where pp.POnumber == pONumber && pp.Storelocation == storelocation
                      select pp;

            if (rs2.Count() > 0)
            {
                foreach (var item in rs2)
                {
                    dc.tbl_MKt_POdetails.DeleteAllOnSubmit(rs2);
                    dc.SubmitChanges();


                }
            }



            return kq;


            // throw new NotImplementedException();
        }


        public static bool DeleteTransfernumber(string Tranfernumber, string Store_OUT)
        {
            // deleead head

            bool kq = false;
            string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = from pp in dc.tbl_MKt_TransferoutHEADs
                     where pp.Tranfernumber == Tranfernumber && pp.Store_OUT == Store_OUT
                     && pp.Status == "CRT"
                     select pp;

            if (rs.Count() > 0)
            {

                dc.tbl_MKt_TransferoutHEADs.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();

                kq = true;
            }
            else
            {
                //  MessageBox.Show("Can not deleted please check ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return kq;
            }

            // upload detail


            var rs2 = from pp in dc.tbl_MKt_Transferoutdetails
                      where pp.Tranfernumber == Tranfernumber && pp.Store_OUT == Store_OUT
                      select pp;

            if (rs2.Count() > 0)
            {
                foreach (var item in rs2)
                {
                    Model.MKT.tranferoutrequestdelete(item, Store_OUT);
                    dc.tbl_MKt_Transferoutdetails.DeleteOnSubmit(item);
                    dc.SubmitChanges();


                }
            }



            return kq;


            // throw new NotImplementedException();
        }


    }
}