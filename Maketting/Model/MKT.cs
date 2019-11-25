using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using Maketting.shared;
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

            //           Material_Description
            // Description_in_Vietnamese

            dt.Columns.Add(new DataColumn("Material_Description", typeof(string)));
            dt.Columns.Add(new DataColumn("Description_in_Vietnamese", typeof(string)));
            dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
            dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            //      dt.Columns.Add(new DataColumn("Material_Name", typeof(string)));
            //        drToAdd["Material_Name"] = PhieuMKT.Materialname;
            dt.Columns.Add(new DataColumn("Issue_Quantity", typeof(float)));
            dt.Columns.Add(new DataColumn("Available_Quantity", typeof(float)));
            dt.Columns.Add(new DataColumn("Region_Balance", typeof(float)));
            //      dt.Columns.Add(new DataColumn("Price", typeof(float)));




            dataGridViewDetail.DataSource = dt;


            //dataGridProgramdetail.Columns["Payment_Control"].DisplayIndex = 1;
            //dataGridProgramdetail.Columns["Payment_Control"].Width = 70;
            //dataGridProgramdetail.Columns["Payment_Control"].HeaderText = "Payment\nControl";
            //this.dataGridProgramdetail.Columns["Payment_Control"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //      dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            //           Material_Description
            // Description_in_Vietnamese

            dataGridViewDetail.Columns["Material_Description"].Width = 300;
            dataGridViewDetail.Columns["Description_in_Vietnamese"].Width = 300;

            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewDetail.Columns["Available_Quantity"].ReadOnly = true;
            dataGridViewDetail.Columns["Available_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            dataGridViewDetail.Columns["Region_Balance"].ReadOnly = true;
            dataGridViewDetail.Columns["Region_Balance"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            //        dataGridViewDetail.Columns["Price"].ReadOnly = true;
            //      dataGridViewDetail.Columns["Price"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;


            //     dataGridViewDetail.Columns["Price"].DefaultCellStyle.Format = "N0";
            dataGridViewDetail.Columns["Available_Quantity"].DefaultCellStyle.Format = "N0";
            dataGridViewDetail.Columns["Issue_Quantity"].DefaultCellStyle.Format = "N0";

            dataGridViewDetail.Columns["Region_Balance"].DefaultCellStyle.Format = "N0";


            #endregion datatable temp


            return dataGridViewDetail;





            //  throw new NotImplementedException();
        }

        public static DataGridView Loadnewdetailcollectrequest(DataGridView dataGridViewDetail)
        {


            dataGridViewDetail.DataSource = null;
            #region datatable temp

            //           Material_Description
            // Description_in_Vietnamese



            DataTable dt = new DataTable();


            dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("ITEM_Code", typeof(string)));
            dt.Columns.Add(new DataColumn("Sap_Code", typeof(string)));

            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            //      dt.Columns.Add(new DataColumn("Material_Name", typeof(string)));
            //        drToAdd["Material_Name"] = PhieuMKT.Materialname;
            dt.Columns.Add(new DataColumn("Request_collect_Quantity", typeof(float)));




            dataGridViewDetail.DataSource = dt;


            //dataGridProgramdetail.Columns["Payment_Control"].DisplayIndex = 1;
            //dataGridProgramdetail.Columns["Payment_Control"].Width = 70;
            //dataGridProgramdetail.Columns["Payment_Control"].HeaderText = "Payment\nControl";
            //this.dataGridProgramdetail.Columns["Payment_Control"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //      dt.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            dataGridViewDetail.Columns["MATERIAL"].Width = 300;
            dataGridViewDetail.Columns["Description"].Width = 300;

            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            dataGridViewDetail.Columns["Request_collect_Quantity"].DefaultCellStyle.Format = "N0";



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
            dt.Columns.Add(new DataColumn("Available_Quantity", typeof(float)));




            dataGridViewDetail.DataSource = dt;
            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewDetail.Columns["Available_Quantity"].ReadOnly = true;
            dataGridViewDetail.Columns["Available_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;



            dataGridViewDetail.Columns["Quantity"].DefaultCellStyle.Format = "N0";
            dataGridViewDetail.Columns["Available_Quantity"].DefaultCellStyle.Format = "N0";


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
            //     dt.Columns.Add(new DataColumn("Available_Quantity", typeof(float)));




            dataGridViewDetail.DataSource = dt;
            dataGridViewDetail.Columns["Unit"].ReadOnly = true;
            dataGridViewDetail.Columns["Unit"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            //  dataGridViewDetail.Columns["Available_Quantity"].ReadOnly = true;
            //   dataGridViewDetail.Columns["Available_Quantity"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;



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

        public static IQueryable DanhsachPhieuMKTtoDLV(string storelocation, LinqtoSQLDataContext dc)
        {
            // string connection_string = Utils.getConnectionstr();
            // LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs = from p in dc.tbl_MKt_Listphieudetails
                     from pp in dc.tbl_MKt_Listphieuheads
                         //        from ppp in dc.tbl_MKT_Soldtocodes
                     where p.ShippingPoint == storelocation && p.Status == "CRT"
                   && p.Gate_pass == pp.Gate_pass
                     //    && ((int)pp.Customer_SAP_Code).ToString().Trim() == ppp.Customer
                     orderby p.Gate_pass
                     select new
                     {
                         Customer_code = p.Customer_SAP_Code,
                         Shipto_code = pp.ShiptoCode,
                         p.Gate_pass,
                         pp.Region,
                         Shipto_City = p.shiptocity,
                         Shipto_Name = pp.ShiptoName, // p.Receiver_by,

                         //    Shipto_Address = pp.ShiptoAddress,//.Address,//.ShiptoAddress,



                         Địa_chỉ = pp.ShiptoAddress,

                         p.Materiacode,
                         p.Materialname,
                         Số_lượng_xuất = p.Issued,
                         Pallet = p.pallet,

                         p.Purpose,
                         p.Receiver_by,
                         p.Ngaytaophieu,
                         Điện_thoại = pp.Tel,

                         p.Description,



                         // p.Tel,

                         ID = p.id,
                     };

            //    grviewlisttk.DataSource = rs;







            return rs;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsacHSTOCKMOVEmentdetail(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string store)
        {
            //  Shippingpoint = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
            //   Itemcode = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["MateriaItemcode"].Value;
            //    shipment = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["LoadNumber"].Value;

            var rs = from p in dc.tbl_MKt_WHstoreissues
                     where p.date_input_output >= fromdate && p.date_input_output <= todate
                     && p.ShippingPoint == store
                     orderby p.date_input_output
                     select new
                     {
                         Input_Output_date = p.date_input_output,
                         p.Document_number,
                         p.DNNumber,
                         p.LoadNumber,
                         p.Materiacode,
                         MateriaItemcode = p.MateriaItemcode,
                         p.Materialname,
                         p.Issued,
                         Receipted = p.RecieptQuantity,
                         Store_code = p.ShippingPoint,


                         p.Username,

                         p.IssueIDsub,
                         p.id,






                     };







            return rs;


            // throw new NotImplementedException();
        }



        public static IQueryable DanhsacHSTOCKMOVEmentdetailonecodebygatepass(LinqtoSQLDataContext dc, string store, string itemcode, string shipment)
        {




            var rs = from p in dc.tbl_MKt_Listphieudetails
                     where p.ShipmentNumber == shipment
                    && p.ShippingPoint == store
                    && p.Materiacode == itemcode
                     //   orderby p.date_input_output
                     select new
                     {

                         Created_date = p.Ngaytaophieu,
                         p.Requested_by,

                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,

                         p.Purpose,
                         p.Note,
                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,
                         Shipment_created_date = p.Delivery_date,
                         p.Shipmentby,

                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Tel,
                         p.Address,

                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         Material_name = p.Materialname,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         Return_request = p.Returnrequest,
                         Pallet = p.pallet,
                         Issued_created_date = p.Issued_dated,
                         Issued_by = p.Loadingby,

                         p.Price,
                         p.Tranposterby,
                         p.Truck,


                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Return_reason,
                         p.Returnby,
                         Incinclude_Shipment = p.Included_Shipment,
                         //         Quantity_Return_request    =    p.Returnrequest

                     };





            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable DanhsacHSTOCKMOVEmentdetailonecode(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string store, string itemcode)
        {


            var rs = from p in dc.tbl_MKt_WHstoreissues
                     where p.date_input_output >= fromdate && p.date_input_output <= todate
                     && p.ShippingPoint == store
                     && p.MateriaItemcode == itemcode
                     orderby p.date_input_output
                     select new
                     {
                         From_date = fromdate,
                         To_date = todate,
                         p.Document_number,


                         Input_Output_date = p.date_input_output,


                         p.Materiacode,
                         p.MateriaItemcode,
                         p.Materialname,
                         p.Issued,
                         Receipted = p.RecieptQuantity,
                         Store_code = p.ShippingPoint,
                         p.DNNumber,
                         p.POnumber,
                         p.Transfer_number,
                         p.LoadNumber,

                         p.Username,

                         //  p.IssueIDsub,
                         p.id,






                     };







            return rs;


            // throw new NotImplementedException();
        }



        public static IQueryable DanhsacHSTOCKMOVEmentdetailbyinputdate(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string store)
        {


            var rs = from p in dc.tbl_MKt_WHstoreissues
                     where p.Doc_date >= fromdate && p.Doc_date <= todate
                     && p.ShippingPoint == store
                     orderby p.Doc_date
                     select new
                     {

                         Input_Output_date = p.date_input_output,
                         p.Document_number,
                         p.DNNumber,
                         p.LoadNumber,
                         p.Materiacode,
                         p.MateriaItemcode,
                         p.Materialname,
                         p.Issued,
                         Receipted = p.RecieptQuantity,
                         Store_code = p.ShippingPoint,


                         p.Username,

                         p.IssueIDsub,
                         p.id,


                         //             Shippingpoint = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Store_code"].Value;
                         //Itemcode = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["MateriaItemcode"].Value;
                         //shipment = (string)this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["LoadNumber"].Value;




                     };







            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable DanhsacHSTOCKMOVEmentdetailbyproduct(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string store, string itemcode)
        {


            var rs = from p in dc.tbl_MKt_WHstoreissues
                     where p.date_input_output >= fromdate && p.date_input_output <= todate
                     && p.ShippingPoint == store
                     && p.MateriaItemcode == itemcode
                     orderby p.date_input_output
                     select new
                     {
                         Input_Output_date = p.date_input_output,
                         p.Document_number,

                         p.Materiacode,
                         p.MateriaItemcode,
                         p.Materialname,
                         p.Issued,
                         Receipted = p.RecieptQuantity,
                         Store_code = p.ShippingPoint,


                         p.Username,

                         p.IssueIDsub,
                         p.id,






                     };







            return rs;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsacHSTOCKMOVEmentsUMMARYbyproduct(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string store, string itemcode)
        {



            var rs = from p in dc.tbl_MKt_WHstoreissues
                     where p.date_input_output >= fromdate && p.date_input_output <= todate
                     && p.ShippingPoint == store
                     && p.MateriaItemcode == itemcode
                     group p by new
                     {
                         //   pp.Region,
                         p.MateriaItemcode,



                     } into gg
                     select new
                     {
                         From_date = fromdate,
                         To_date = todate,
                         Shipping_point = store,

                         MateriaL_Item_code = gg.Key.MateriaItemcode,
                         MateriaL_SAP_code = gg.FirstOrDefault().Materiacode,
                         Material_name = gg.FirstOrDefault().Materialname,
                         Receipted = gg.Sum(m => m.RecieptQuantity).GetValueOrDefault(0),
                         Issued = gg.Sum(m => m.Issued).GetValueOrDefault(0),



                     };


            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable DanhsacHSTOCKMOVEmentsUMMARY(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string store)
        {




            var rs = from p in dc.tbl_MKt_WHstoreissues
                     where p.date_input_output >= fromdate && p.date_input_output <= todate
                     && p.ShippingPoint == store
                     group p by new
                     {
                         //   pp.Region,
                         p.MateriaItemcode,



                     } into gg
                     select new
                     {
                         From_date = fromdate,
                         To_date = todate,
                         Shipping_point = store,

                         MateriaL_Item_code = gg.Key.MateriaItemcode,
                         MateriaL_SAP_code = gg.FirstOrDefault().Materiacode,
                         Material_name = gg.FirstOrDefault().Materialname,
                         Receipted = gg.Sum(m => m.RecieptQuantity).GetValueOrDefault(0),
                         Issued = gg.Sum(m => m.Issued).GetValueOrDefault(0),


                     };


            return rs;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsacStoreOndate(LinqtoSQLDataContext dc, DateTime ondate, string store)
        {



            var rs = from p in dc.tbl_MKT_Stockenddailysaves
                     where p.End_date == ondate.Date && p.Store_code == store
                     select p;







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
                         p.Requested_by,

                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,

                         p.Purpose,
                         p.Note,
                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,
                         Shipment_created_date = p.Delivery_date,
                         p.Shipmentby,

                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Tel,
                         p.Address,

                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         Material_name = p.Materialname,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         Return_request = p.Returnrequest,
                         Pallet = p.pallet,
                         Issued_created_date = p.Issued_dated,
                         Issued_by = p.Loadingby,

                         p.Price,
                         p.Tranposterby,
                         p.Truck,


                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Return_reason,
                         p.Returnby,
                         Incinclude_Shipment = p.Included_Shipment,
                         //         Quantity_Return_request    =    p.Returnrequest



                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsachPhieuMKTandstatustheongaygheoload(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate)
        {


            var rs = from p in dc.tbl_MKt_Listphieudetails
                     where p.Delivery_date >= fromdate && p.Delivery_date <= todate
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Requested_by,

                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,

                         p.Purpose,
                         p.Note,
                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,
                         Shipment_created_date = p.Delivery_date,
                         p.Shipmentby,

                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Tel,
                         p.Address,

                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         Material_name = p.Materialname,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         Return_request = p.Returnrequest,
                         Pallet = p.pallet,
                         Issued_created_date = p.Issued_dated,
                         Issued_by = p.Loadingby,

                         p.Price,
                         p.Tranposterby,
                         p.Truck,


                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Return_reason,
                         p.Returnby,
                         Incinclude_Shipment = p.Included_Shipment,
                         //         Quantity_Return_request    =    p.Returnrequest



                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsachPhieuMKTandstatusbyIssuedate(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate)
        {


            var rs = from p in dc.tbl_MKt_Listphieudetails
                     where p.Issued_dated >= fromdate && p.Issued_dated <= todate
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Requested_by,

                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,
                         p.Note,
                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,
                         Shipment_created_date = p.Delivery_date,
                         p.Shipmentby,

                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Tel,
                         p.Address,

                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         Material_name = p.Materialname,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         Pallet = p.pallet,
                         Issued_created_date = p.Issued_dated,
                         Issued_by = p.Loadingby,
                         Return_request = p.Returnrequest,
                         p.Price,
                         p.Tranposterby,
                         p.Truck,


                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Return_reason,
                         p.Returnby,
                         Incinclude_Shipment = p.Included_Shipment,
                         //         Quantity_Return_request    =    p.Returnrequest

                     };







            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable DanhsachPhieuundelivery(LinqtoSQLDataContext dc, string usernamefind)
        {


            var rs = from p in dc.tbl_MKt_Listphieudetails
                     where p.Username == usernamefind
                     && p.Status == "CRT"
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,

                         p.Requested_by,

                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Address,
                         p.Tel,
                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         Material_name = p.Materialname,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         p.Issued_dated,
                         Pallet = p.pallet,
                         p.Price,
                         p.Tranposterby,
                         p.Truck,
                         p.Loadingby,
                         p.Delivery_date,

                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Returnby,
                         Incinclude_Shipment = p.Included_Shipment,





                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsachPhieuundeliveryhead(LinqtoSQLDataContext dc, string usernamefind)
        {


            var rs = from p in dc.tbl_MKt_Listphieuheads
                     where p.Username == usernamefind
                     && p.Status == "CRT"
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.Note,

                         p.ShippingPoint,

                         p.Requested_by,
                         p.Tel,
                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         Soldto_address = p.Address,
                         Shipto_Address = p.ShiptoAddress,


                         //    Completed_date = p.Date_Received_Issued,





                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsachPhieuundeliveryheadbystore(LinqtoSQLDataContext dc, string store)
        {


            var rs = from p in dc.tbl_MKt_Listphieuheads
                     where p.ShippingPoint == store
                     && (p.Status == "CRT" || p.Status == "LOADING")
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.Note,

                         p.ShippingPoint,

                         p.Requested_by,
                         p.Tel,
                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         Soldto_address = p.Address,
                         Shipto_Address = p.ShiptoAddress,


                         //    Completed_date = p.Date_Received_Issued,





                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }
        public static IQueryable DanhsachPhieuunisuebystore(LinqtoSQLDataContext dc, string store)
        {


            var rs = from p in dc.tbl_MKt_Listphieuheads
                     where p.ShippingPoint == store
                     && p.Status == "LOADING"
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.Note,

                         p.ShippingPoint,

                         p.Requested_by,
                         p.Tel,
                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         Soldto_address = p.Address,
                         Shipto_Address = p.ShiptoAddress,


                         //    Completed_date = p.Date_Received_Issued,





                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }
        public static IQueryable DanhsachPhieudetailblockbystore(LinqtoSQLDataContext dc, string store)
        {


            var rs = from p in dc.tbl_MKt_Listphieudetails
                     where p.ShippingPoint == store
                     && p.Status == "BLOCK"
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.ShippingPoint,
                         p.ShipmentNumber,

                         p.Requested_by,

                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         p.Address,
                         p.Tel,
                         //   Số_lượng_thực_xuất = p.Soluongdaxuat,
                         // Số_lượng_còn_lại = p.Soluongconlai,
                         p.Materiacode,
                         p.MateriaSAPcode,
                         Material_name = p.Materialname,
                         p.Description,
                         p.Unit,
                         Issued = p.Issued,
                         p.Issued_dated,
                         Pallet = p.pallet,
                         p.Price,
                         p.Tranposterby,
                         p.Truck,
                         p.Loadingby,
                         p.Delivery_date,

                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Returnby,
                         Incinclude_Shipment = p.Included_Shipment,





                         //    ID = p.id,
                     };








            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable DanhsachPhieuunloadingheadbystore(LinqtoSQLDataContext dc, string store)
        {


            var rs = from p in dc.tbl_MKt_Listphieuheads
                     where p.ShippingPoint == store
                     && p.Status == "CRT"
                     orderby p.Gate_pass
                     select new
                     {
                         Created_date = p.Ngaytaophieu,
                         p.Region,
                         p.Gate_pass,
                         Date_MKT_Phiếu = p.Ngaytaophieu,
                         IO = p.Purposeid,
                         p.Purpose,

                         p.Status,
                         p.Note,

                         p.ShippingPoint,

                         p.Requested_by,
                         p.Tel,
                         p.Customer_SAP_Code,
                         p.Receiver_by,
                         Soldto_address = p.Address,
                         Shipto_Address = p.ShiptoAddress,


                         //    Completed_date = p.Date_Received_Issued,





                         //    ID = p.id,
                     };







            return rs;


            // throw new NotImplementedException();
        }


        public static IQueryable DanhsachPhieuMKTandstatusbyregion(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string region, string statusphieu)
        {
            //  throw new NotImplementedException();


            var rs = from p in dc.tbl_MKt_Listphieudetails
                     where p.Ngaytaophieu >= fromdate && p.Ngaytaophieu <= todate
                     && p.Region == region && p.Status.Contains(statusphieu)
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
                         p.Tel,
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
                         Pallet = p.pallet,
                         p.Price,
                         p.Tranposterby,
                         p.Truck,
                         p.Loadingby,
                         Completed_date = p.Date_Received_Issued,
                         p.Completed_by,
                         p.ReturnQuantity,
                         p.Returndate,
                         p.Return_reason,
                         p.Returnby,






                         //    ID = p.id,
                     };







            return rs;






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

        public static bool Deletephieu(string sophieu, string kho, string Region) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            //   string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs3 = (from pp in dc.tbl_MKt_Listphieudetails
                       where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                    && pp.ShipmentNumber != ""
                       select pp.ShipmentNumber).FirstOrDefault();

            if (rs3 != null)
            {
                MessageBox.Show("Note " + sophieu + " can not delete detail by load created !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            #region  // giảm order và giảm budget region

            #region       //update giảm ordered

            var rs22 = from pp in dc.tbl_MKt_Listphieudetails
                       where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                       select pp;


            if (rs22.Count() > 0)
            {
                foreach (var item in rs22)
                {
                    Model.MKT.updatetangOrdered(item.Materiacode, -(float)item.Issued.GetValueOrDefault(0), item.ShippingPoint);

                }



            }




            #endregion
            //  xóa butget đã bocck
            var rs24 = from pp in dc.tbl_MKT_StockendRegionBudgets
                       where pp.Gate_pass == sophieu && pp.Store_code == kho && pp.Region == Region
                       select pp;


            if (rs24.Count() > 0)
            {
                dc.tbl_MKT_StockendRegionBudgets.DeleteAllOnSubmit(rs24);
                dc.SubmitChanges();

            }
            //newregionupdate.Store_code = this.storelocation;
            //newregionupdate.Region = this.region;//Model.Username.getuseRegion();
            //newregionupdate.Gate_pass = this.sophieu;



            #endregion



            var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                      where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                      select pp;


            if (rs2.Count() > 0)
            {
                dc.tbl_MKt_Listphieudetails.DeleteAllOnSubmit(rs2);
                dc.SubmitChanges();

            }
            //else
            //{
            //    MessageBox.Show("Please check phiếu: " + sophieu + " can not delete detail!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            var rs = from pp in dc.tbl_MKt_Listphieuheads
                     where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                     select pp;

            if (rs.Count() > 0)
            {
                dc.tbl_MKt_Listphieuheads.DeleteAllOnSubmit(rs);
                dc.SubmitChanges();
            }
            //else
            //{
            //    MessageBox.Show("Please check phiếu: " + sophieu + " can not delete head!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            return true;
        }

        public static bool Deletephieutochange(string sophieu, string kho, string Region) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            //   string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs3 = (from pp in dc.tbl_MKt_Listphieudetails
                       where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                    && pp.ShipmentNumber != ""
                       select pp.ShipmentNumber).FirstOrDefault();

            if (rs3 != null)
            {
                MessageBox.Show("Note " + sophieu + " can not delete detail by load created !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {



                #region  // giảm order và giảm budget region

                #region       //update giảm ordered

                var rs22 = from pp in dc.tbl_MKt_Listphieudetails
                           where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                           select pp;


                if (rs22.Count() > 0)
                {
                    foreach (var item in rs22)
                    {
                        Model.MKT.updatetangOrdered(item.Materiacode, -(float)item.Issued.GetValueOrDefault(0), item.ShippingPoint);

                    }



                }




                #endregion
                //  xóa butget đã bocck
                var rs24 = from pp in dc.tbl_MKT_StockendRegionBudgets
                           where pp.Gate_pass == sophieu && pp.Store_code == kho && pp.Region == Region
                           select pp;


                if (rs24.Count() > 0)
                {
                    dc.tbl_MKT_StockendRegionBudgets.DeleteAllOnSubmit(rs24);
                    dc.SubmitChanges();

                }
                //newregionupdate.Store_code = this.storelocation;
                //newregionupdate.Region = this.region;//Model.Username.getuseRegion();
                //newregionupdate.Gate_pass = this.sophieu;



                #endregion



                var rs2 = from pp in dc.tbl_MKt_Listphieudetails
                          where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                          select pp;


                if (rs2.Count() > 0)
                {
                    dc.tbl_MKt_Listphieudetails.DeleteAllOnSubmit(rs2);
                    dc.SubmitChanges();

                }
                //else
                //{
                //    MessageBox.Show("Please check phiếu: " + sophieu + " can not delete detail!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}

                var rs = from pp in dc.tbl_MKt_Listphieuheads
                         where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                         select pp;

                if (rs.Count() > 0)
                {
                    //    dc.tbl_MKt_Listphieuheads.DeleteAllOnSubmit(rs);
                    foreach (var item in rs)
                    {
                        item.Username = Username.getUsername();
                        item.Status = "TMP";
                        dc.SubmitChanges();
                    }

                }
                else
                {

                    tbl_MKt_Listphieuhead newheaddoc = new tbl_MKt_Listphieuhead();


                    newheaddoc.Ngaytaophieu = DateTime.Today;
                    newheaddoc.Status = "TMP";
                    newheaddoc.Gate_pass = sophieu;
                    newheaddoc.ShippingPoint = kho;
                    newheaddoc.Username = Username.getUsername();
                    dc.tbl_MKt_Listphieuheads.InsertOnSubmit(newheaddoc);
                    dc.SubmitChanges();







                }

                return true;


            }
        }


        public static bool Deletephieuthuchangtochange(string sophieu, string kho, string Region) // vd phieu thu nghiep vu là phieu thu: PT,
        {
            //   string urs = Utils.getusername();

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var rs3 = (from pp in dc.tbl_MKt_Listphieudetails
                       where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                    && pp.ShipmentNumber != ""
                       select pp.ShipmentNumber).FirstOrDefault();

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
            //else
            //{
            //    MessageBox.Show("Please check phiếu: " + sophieu + " can not delete detail!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            var rs = from pp in dc.tbl_MKt_Listphieuheads
                     where pp.Gate_pass == sophieu && pp.ShippingPoint == kho
                     select pp;

            if (rs.Count() > 0)
            {
                //    dc.tbl_MKt_Listphieuheads.DeleteAllOnSubmit(rs);
                foreach (var item in rs)
                {
                    item.Username = Username.getUsername();
                    item.Status = "TMP";
                    dc.SubmitChanges();
                }

            }
            else
            {

                tbl_MKt_Listphieuhead newheaddoc = new tbl_MKt_Listphieuhead();


                newheaddoc.Ngaytaophieu = DateTime.Today;
                newheaddoc.Status = "TMP";
                newheaddoc.Gate_pass = sophieu;
                newheaddoc.ShippingPoint = kho;
                newheaddoc.Username = Username.getUsername();
                dc.tbl_MKt_Listphieuheads.InsertOnSubmit(newheaddoc);
                dc.SubmitChanges();







            }

            return true;
        }


        public static void tangkhokhinhaphang(tbl_MKt_WHstoreissue itemnhap, string storecode)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var item = (from p in dc.tbl_MKT_Stockends
                        where p.ITEM_Code == itemnhap.MateriaItemcode
                                && p.Store_code == storecode
                        select p).FirstOrDefault();

            if (item != null)
            {


                item.END_STOCK = item.END_STOCK + itemnhap.RecieptQuantity.GetValueOrDefault(0);
                dc.SubmitChanges();

            }
            else
            {

                tbl_MKT_Stockend newitem = new tbl_MKT_Stockend();
                newitem.END_STOCK = itemnhap.RecieptQuantity.GetValueOrDefault(0);
                newitem.ITEM_Code = itemnhap.MateriaItemcode;
                newitem.SAP_CODE = itemnhap.Materiacode;
                newitem.MATERIAL = itemnhap.Materialname.Truncate(255);

                newitem.Store_code = storecode;
                newitem.UNIT = itemnhap.Unit;
                //    newitem.END_STOCK = itemnhap.RecieptQuantity;
                //    newitem.END_STOCK = itemnhap.RecieptQuantity;


                dc.tbl_MKT_Stockends.InsertOnSubmit(newitem);

                dc.SubmitChanges();
            }




            //  throw new NotImplementedException();
        }

        public static void updatetangOrdered(string itemCode, float ordered, string Store_code)
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

            var item = (from p in dc.tbl_MKT_Stockends
                        where p.ITEM_Code == itemout.MateriaItemcode
                        && p.Store_code == itemout.Store_OUT
                        select p).FirstOrDefault();

            if (item != null)
            {


                item.END_STOCK = item.END_STOCK.GetValueOrDefault(0) - itemout.Quantity.GetValueOrDefault(0);
                item.TransferingOUT = item.TransferingOUT.GetValueOrDefault(0) + itemout.Quantity.GetValueOrDefault(0);
                dc.SubmitChanges();

            }





            //  throw new NotImplementedException();
        }

        public static void tranferinmakechange(tbl_MKt_TransferINdetail itemIN)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var item = (from p in dc.tbl_MKT_Stockends
                        where p.ITEM_Code == itemIN.MateriaItemcode
                        && p.Store_code == itemIN.Store_OUT
                        select p).FirstOrDefault();

            if (item != null)
            {

                item.TransferingOUT = item.TransferingOUT.GetValueOrDefault(0) - itemIN.Reciepted_Quantity.GetValueOrDefault(0);
                dc.SubmitChanges();


            }


            var item2 = (from p in dc.tbl_MKT_Stockends
                         where p.ITEM_Code == itemIN.MateriaItemcode
                         && p.Store_code == itemIN.Store_IN
                         select p).FirstOrDefault();

            if (item2 != null)
            {

                item2.END_STOCK = item2.END_STOCK.GetValueOrDefault(0) + itemIN.Reciepted_Quantity.GetValueOrDefault(0);
                //   item.TransferingOUT = item.TransferingOUT.GetValueOrDefault(0) - itemIN.Reciepted_Quantity;
                dc.SubmitChanges();

            }
            else
            {

                tbl_MKT_Stockend newproduct = new tbl_MKT_Stockend();

                newproduct.Description = itemIN.Description.Truncate(255);
                newproduct.MATERIAL = itemIN.Materialname.Truncate(255);


                newproduct.END_STOCK = itemIN.Reciepted_Quantity.GetValueOrDefault(0);

                newproduct.ITEM_Code = itemIN.MateriaItemcode;

                newproduct.SAP_CODE = itemIN.MateriaSAPcode;

                newproduct.Store_code = itemIN.Store_IN;

                newproduct.UNIT = itemIN.Unit;

                newproduct.Ordered = 0;

                // newproduct.Description = itemIN.Description;



                dc.tbl_MKT_Stockends.InsertOnSubmit(newproduct);
                dc.SubmitChanges();

            }



            //  throw new NotImplementedException();
        }


        public static void tranferoutrequestdelete(tbl_MKt_Transferoutdetail itemout, string storecode)
        {

            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var item = (from p in dc.tbl_MKT_Stockends
                        where p.ITEM_Code == itemout.MateriaItemcode
                             && p.Store_code == storecode
                        select p).FirstOrDefault();

            if (item != null)
            {

                item.END_STOCK = item.END_STOCK.GetValueOrDefault(0) + itemout.Quantity.GetValueOrDefault(0);
                item.TransferingOUT = item.TransferingOUT.GetValueOrDefault(0) - itemout.Quantity.GetValueOrDefault(0);
                dc.SubmitChanges();

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
                           select p).FirstOrDefault();

            phieuid.Gate_pass = phieuid.id.ToString();
            dc.SubmitChanges();

            return phieuid.Gate_pass;





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

        public static double getgiaPOgannhat(string materiaSAPcode)
        {
            double giaPOgannhat = 0;

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            giaPOgannhat = (double)(from p in dc.tbl_MKt_POdetails
                                    where p.MateriaSAPcode == materiaSAPcode
                                    orderby p.DatePO descending
                                    select p.Unit_Price).FirstOrDefault();


            return giaPOgannhat;
            //  throw new NotImplementedException();
        }

        public static IQueryable danhkhachhangrutgon(LinqtoSQLDataContext dc)
        {
            // throw new NotImplementedException();


            LinqtoSQLDataContext db = dc;
            var rs = (from p in db.tbl_MKT_Soldtocodes
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
                      }).Take(100);

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
                         p.ShiptoCode,
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

        public static IQueryable shiptolistbycustomerrutgon(LinqtoSQLDataContext dc, string customercode)
        {


            // throw new NotImplementedException();


            LinqtoSQLDataContext db = dc;
            var rs = (from p in db.tbl_MKT_Soldtocodes
                      where p.Customer == customercode
                      orderby p.Customer
                      select new
                      {

                          SalesOrg = p.SalesOrg,
                          Region = p.Region,
                          Customer = p.Customer,
                          p.ShiptoCode,
                          FullName = p.FullNameN,
                          Street = p.Street,
                          District = p.District,
                          City = p.City,
                          Telephone = p.Telephone1,
                          Note = p.Note,


                          ID = p.id,
                      }).Take(1000);

            //    grviewlisttk.DataSource = rs;







            return rs;






            //throw new NotImplementedException();
        }

        //   tbl_MKt_WHstoreissue
        public static void giamtrukhokhixuathang(tbl_MKt_WHstoreissue itemxuat)
        {



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var item = (from p in dc.tbl_MKT_Stockends
                        where p.ITEM_Code == itemxuat.MateriaItemcode
                        && p.Store_code == itemxuat.ShippingPoint
                        select p).FirstOrDefault();

            if (item != null)
            {

                item.END_STOCK = item.END_STOCK - itemxuat.Issued.GetValueOrDefault(0);
                dc.SubmitChanges();

                Model.MKT.updatetangOrdered(itemxuat.MateriaItemcode, -(float)itemxuat.Issued.GetValueOrDefault(0), itemxuat.ShippingPoint);

            }

            //     valueitem.Ordered = valueitem.Ordered.GetValueOrDefault(0) + ordered;




        }

        public static void giamtrukhokhirevertgoodreceipt(tbl_MKt_WHstoreissue itemxuat)
        {



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var item = (from p in dc.tbl_MKT_Stockends
                        where p.ITEM_Code == itemxuat.MateriaItemcode
                        && p.Store_code == itemxuat.ShippingPoint
                        select p).FirstOrDefault();

            if (item != null)
            {


                item.END_STOCK = item.END_STOCK.GetValueOrDefault(0) - itemxuat.Issued.GetValueOrDefault(0);

                dc.SubmitChanges();

            }

            //   Giảm ordered khi xuất hàng


            Model.MKT.updatetangOrdered(itemxuat.MateriaItemcode, -(float)itemxuat.RecieptQuantity.GetValueOrDefault(0), itemxuat.ShippingPoint);


        }


        public static void giamtrukhokhireverthangnhamsaive(tbl_MKt_WHstoreissue itemxuat)
        {



            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            var item = (from p in dc.tbl_MKT_Stockends
                        where p.ITEM_Code == itemxuat.MateriaItemcode
                        && p.Store_code == itemxuat.ShippingPoint
                        select p).FirstOrDefault();

            if (item != null)
            {

                item.END_STOCK = item.END_STOCK.GetValueOrDefault(0) - itemxuat.RecieptQuantity.GetValueOrDefault(0);
                dc.SubmitChanges();

            }

            //   Giảm ordered khi xuất hàng


            Model.MKT.updatetangOrdered(itemxuat.MateriaItemcode, -(float)itemxuat.RecieptQuantity.GetValueOrDefault(0), itemxuat.ShippingPoint);





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
                         // from ppp in dc.tbl_MKT_Soldtocodes
                     where p.ShippingPoint == storelocation && p.Status == "CRT"
                            && p.Gate_pass == pp.Gate_pass
                     //    && ((int)pp.Customer_SAP_Code).ToString().Trim() == ppp.Customer
                     && p.Address.Contains(txtseachaddress)
                             && p.Customer_SAP_Code.Contains(txtseachcode)
                               && p.Gate_pass.Contains(txtseachgate)


                     orderby p.Gate_pass
                     select new
                     {

                         Customer_code = p.Customer_SAP_Code,
                         Shipto_code = pp.ShiptoCode,
                         Gate_pass = p.Gate_pass,
                         pp.Region,
                         Shipto_City = p.shiptocity,
                         Shipto_Name = pp.ShiptoName, // p.Receiver_by,

                         Shipto_Address = pp.ShiptoAddress,//.Address,//.ShiptoAddress,

                         p.Materiacode,
                         p.Materialname,
                         Số_lượng_xuất = p.Issued,
                         Pallet = p.pallet,

                         p.Purpose,

                         p.Ngaytaophieu,
                         //   Điện_thoại = pp.Tel,
                         //  Gate_pass = p.Gate_pass,
                         p.Description,
                         p.Note,


                         // p.Tel,

                         ID = p.id,
                     };

            dataGridViewDetail.DataSource = rs;

            dataGridViewDetail.Columns["pallet"].DefaultCellStyle.Format = "N3";



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


            var rs3 = from pp in dc.tbl_MKt_WHstoreissues
                      where pp.Transfer_number == Tranfernumber && pp.ShippingPoint == Store_OUT
                      //  && pp.Status == "CRT"
                      select pp;

            if (rs3.Count() > 0)
            {

                dc.tbl_MKt_WHstoreissues.DeleteAllOnSubmit(rs3);
                dc.SubmitChanges();

                kq = true;
            }
            else
            {
                //  MessageBox.Show("Can not deleted please check ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return kq;
            }


            return kq;


            // throw new NotImplementedException();
        }

        public static IQueryable DanhsachPOnham(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate)
        {





            var rs = from pp in dc.tbl_MKt_POdetails
                     where pp.StatusPO == "IN"
                     where pp.DatePO >= fromdate
                      && pp.DatePO <= todate
                     select new
                     {
                         pp.Region,
                         pp.POnumber,
                         pp.Storelocation,
                         pp.DatePO,
                         pp.MateriaSAPcode,
                         pp.MateriaItemcode,
                         pp.Materialname,

                         Reciepted_Quantity = pp.RecieptedQuantity,
                         pp.Unit,
                         //    ID = pp.id,

                     };

            return rs;

            // throw new NotImplementedException();
        }


        public static IQueryable DanhsachPOListbyregion(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string region)
        {





            var rs = from pp in dc.tbl_MKt_POdetails
                     where pp.DatePO >= fromdate
                     && pp.DatePO <= todate
                      && pp.Region == region
                     select new
                     {
                         pp.Region,
                         pp.POnumber,
                         pp.Storelocation,
                         pp.DatePO,
                         pp.MateriaSAPcode,
                         pp.MateriaItemcode,
                         pp.Materialname,
                         pp.Unit,
                         pp.Unit_Price,

                         pp.QuantityOrder,

                         Reciepted_Quantity = pp.RecieptedQuantity,
                         Unreceipted = pp.QuantityOrder - pp.RecieptedQuantity,

                         //    ID = pp.id,

                     };

            return rs;

            // throw new NotImplementedException();
        }

        public static IQueryable DanhsachPOList(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate)
        {





            var rs = from pp in dc.tbl_MKt_POdetails
                     where pp.DatePO >= fromdate
                     && pp.DatePO <= todate
                     select new
                     {
                         pp.Region,
                         pp.POnumber,
                         pp.Storelocation,
                         pp.DatePO,
                         pp.MateriaSAPcode,
                         pp.MateriaItemcode,
                         pp.Materialname,
                         pp.Unit,
                         pp.Unit_Price,

                         pp.QuantityOrder,

                         Reciepted_Quantity = pp.RecieptedQuantity,
                         Unreceipted = pp.QuantityOrder - pp.RecieptedQuantity,

                         //    ID = pp.id,

                     };

            return rs;

            // throw new NotImplementedException();
        }

        public static IQueryable DanhsachGRList(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string storecode)
        {





            var rs = from pp in dc.tbl_MKt_WHstoreissues
                         // from gg in dc.tbl_MKt_POheads
                     where pp.POnumber != null //&& pp.POnumber == gg.PONumber
                     && pp.date_input_output >= fromdate
                      && pp.date_input_output <= todate
                        && pp.ShippingPoint == storecode
                     select new
                     {
                         // gg.
                         pp.POnumber,
                         Ngày_nhập_kho = pp.date_input_output,
                         DN_Number = pp.DNNumber,
                         pp.Materiacode,
                         pp.MateriaItemcode,
                         pp.Materialname,
                         pp.Unit,
                         pp.RecieptQuantity,
                         pp.Recieptby,


                         pp.Username,
                         pp.ShippingPoint,
                         pp.id,
                         Subid = pp.IssueIDsub,


                     };

            return rs;

            // throw new NotImplementedException();
        }

        public static IQueryable storeimportsreports(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string storecode)
        {





            var rs = from pp in dc.tbl_MKt_WHstoreissues
                         // from gg in dc.tbl_MKt_POheads
                     where pp.RecieptQuantity != null //&& pp.POnumber == gg.PONumber
                     && pp.Doc_date >= fromdate
                      && pp.Doc_date <= todate
                          && pp.ShippingPoint == storecode
                     select new
                     {
                         // gg.
                         DocumentNumber = pp.Document_number,
                         Ngày_nhập_phiếu = pp.Doc_date,
                         Ngày_nhập_kho = pp.date_input_output,
                         DN_Number = pp.DNNumber,
                         pp.Materiacode,
                         pp.MateriaItemcode,
                         pp.Materialname,
                         pp.Unit,
                         pp.RecieptQuantity,
                         pp.Recieptby,


                         pp.Username,
                         pp.ShippingPoint,
                         Shipmnent = pp.Serriload,
                         Transfer_in_number = pp.Transfer_number,
                         pp.POnumber,
                         //   pp.id,
                         //    Subid = pp.IssueIDsub,


                     };

            return rs;

            // throw new NotImplementedException();
        }


        public static IQueryable storeimportsreportsbyregion(LinqtoSQLDataContext dc, DateTime fromdate, DateTime todate, string storecode)
        {



            ///      tbl_MKT_StockendRegionBudget

            var rs = from pp in dc.tbl_MKT_StockendRegionBudgets
                         // from gg in dc.tbl_MKt_POheads
                     where pp.QuantityReceipt > 0

                   && pp.Createdate >= fromdate
                      && pp.Createdate <= todate
                          && pp.Store_code == storecode
                     select new
                     {

                         // gg.
                         pp.Region,
                         DocumentNumber = pp.DocumentNumber,
                         DN_Number = pp.DnNumber,
                         Ngày_nhập_phiếu = pp.Createdate,
                         Ngày_nhập_kho = pp.Regionchangedate,

                         pp.MATERIAL,
                         pp.Description,
                         pp.ITEM_Code,
                         pp.SAP_CODE,
                         //   pp.UNIT,
                         pp.QuantityReceipt,
                         //    pp.s,


                         //
                         pp.Store_code,
                         //   Shipmnent = pp.s,
                         //     Transfer_in_number = pp.Transfer_number,
                         pp.POnumber,

                         //   pp.id,
                         Subid = pp.idsub,

                     };

            return rs;

            // throw new NotImplementedException();
        }

        public static double getAvailable_Quantity(string materialitemcode, string storelocation)
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            double kq = 0;
            var rs5 = (from pp in dc.tbl_MKT_Stockends
                       where pp.Store_code == storelocation
                    && pp.ITEM_Code == materialitemcode
                       group pp by new
                       {
                           //   pp.Region,
                           pp.ITEM_Code,

                       } into gg
                       select new
                       {


                           Balance = gg.Sum(m => m.END_STOCK).GetValueOrDefault(0) - gg.Sum(m => m.Ordered).GetValueOrDefault(0),// + gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0) - gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                       });

            if (rs5.Count() > 0)
            {
                kq = rs5.FirstOrDefault().Balance;
            }


            return kq;

        }


        public static double getBalancebuget(string materialitemcode, string region, string storelocation)
        {
            string connection_string = Utils.getConnectionstr();
            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            double kq = 0;
            var rs5 = (from pp in dc.tbl_MKT_StockendRegionBudgets
                       where pp.Region == region
                       && pp.Store_code == storelocation
                    && pp.ITEM_Code == materialitemcode
                       group pp by new
                       {
                           //   pp.Region,
                           pp.ITEM_Code,

                       } into gg
                       select new
                       {


                           Balance = gg.Sum(m => m.QuantityInputbyPO).GetValueOrDefault(0) + gg.Sum(m => m.QuantitybyDevice).GetValueOrDefault(0) + gg.Sum(m => m.QuantityInputbyReturn).GetValueOrDefault(0) - gg.Sum(m => m.QuantityOutput).GetValueOrDefault(0),
                       });

            if (rs5.Count() > 0)
            {
                kq = rs5.FirstOrDefault().Balance;
            }


            return kq;

        }


        public static void updatePalleCRTorder()
        {

            #region  DeleteTempFBL5nnew DeleteTempFBL5nnew
            SqlConnection conn2 = null;
            SqlDataReader rdr1 = null;

            string destConnString = Utils.getConnectionstr();
            try
            {

                conn2 = new SqlConnection(destConnString);
                conn2.Open();
                SqlCommand cmd1 = new SqlCommand("UpdatePalletforCRTorderdetail", conn2);
                cmd1.CommandType = CommandType.StoredProcedure;

                //    cmd1.Parameters.Add("@location", SqlDbType.NVarChar).Value = storelocation.Trim();
                ///     cmd1.Parameters.Add("@todate", SqlDbType.Date).Value = todate;
                //  System.Data.SqlDbType.DateTime
                try
                {
                    rdr1 = cmd1.ExecuteReader();
                    //  MessageBox.Show("OK, please go to Input verify to reinput !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error  Update Pallet for CRT Orderdetail \n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




                //       rdr1 = cmd1.ExecuteReader();

            }
            finally
            {
                if (conn2 != null)
                {
                    conn2.Close();
                }
                if (rdr1 != null)
                {
                    rdr1.Close();
                }
            }

            #endregion







        }

        public static IQueryable Danhsachphieuchuaxuathoadon(LinqtoSQLDataContext dc, string store)
        {




            var rs = from pp in dc.tbl_MKt_Listphieuheads
                         // from gg in dc.tbl_MKt_POheads
                     where pp.einvoice == false
                     && pp.requestReturn == false

                   && pp.ShippingPoint == store
                   && pp.Status == "Delivering"
                     select pp;
            //  select pp;

            return rs;






            //throw new NotImplementedException();
        }
    }
}