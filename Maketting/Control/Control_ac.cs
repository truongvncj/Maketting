using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cExcel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Maketting.shared;
using Maketting.View;
using System.Threading;

using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

//BEEACCOUNT.LinqtoSQLDataContext

namespace Maketting.Control
{
    class Control_ac
    {


        public static void messagetomanin(Main main, string messagetext, Color maunen )
        {
            main.messagetext(messagetext, maunen);



        }

 
        class datashowwait
        {

            public View.MKTCaculating wat { get; set; }


        }



        private void showwait(object obj)
        {
            // View.Caculating wat = new View.Caculating();

            //            View.Caculating wat = (View.Caculating)obj;
            datashowwait obshow = (datashowwait)obj;

            View.MKTCaculating wat = obshow.wat;

            wat.ShowDialog();


        }


        //     // ARlettermakebyGroupcodeRegion
        //     //public static void VolumeupdateperContract(string Contractno)
        //     //{

        //     //    string ContractNo = Contractno.Trim();
        //     //    string connection_string = Utils.getConnectionstr();

        //     //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //     //    dc.CommandTimeout = 0;

        //     //    #region    //   xoa datavolume conytrac
        //     //    dc.ExecuteCommand("DELETE FROM tbl_kacontractsvolume Where  tbl_kacontractsvolume.ContractNo = '" + ContractNo + "'");

        //     //    //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
        //     //    dc.SubmitChanges();

        //     //    #endregion//   xoa datavolume conytrac

        //     //    // var q9 = from tblCustomer in db.tblCustomers
        //     //    //          where !(from tblFBL5beginbalace in db.tblFBL5beginbalaces
        //     //    //                  select tblFBL5beginbalace.Account.ToString() + tblFBL5beginbalace.Business_Area).Contains(tblCustomer.Customer.ToString() + tblCustomer.SOrg) && (tblCustomer.Reportsend == true)
        //     //    //          orderby tblCustomer.Customer
        //     //    //          group tblCustomer by new
        //     //    //          {
        //     //    //         tblCustomer.Customer,
        //     //    //         tblCustomer.SOrg,
        //     //    //          }
        //     //    //          into g
        //     //    //          select g;



        //     //    var contract = (from tbl_kacontractdata in dc.tbl_kacontractdatas
        //     //                    where tbl_kacontractdata.ContractNo .Equals( ContractNo)
        //     //                    select tbl_kacontractdata).FirstOrDefault();


        //     //    if (contract != null)
        //     //    {
        //     //        var achivementrs = from tbl_kasale in dc.tbl_kasales
        //     //                           where tbl_kasale.Invoice_Date <= contract.ExtDate && tbl_kasale.Invoice_Date >= contract.EffDate &&
        //     //                           tbl_kasale.Sold_to == contract.Customer
        //     //                           group tbl_kasale by tbl_kasale.Priod into g

        //     //                           select new
        //     //                           {

        //     //                               priod = g.Key,
        //     //                               EC = g.Sum(gg => gg.EC).GetValueOrDefault(0),
        //     //                               PC = g.Sum(gg => gg.PC).GetValueOrDefault(0),
        //     //                               UC = g.Sum(gg => gg.UC).GetValueOrDefault(0),
        //     //                               Litter = g.Sum(gg => gg.Litter).GetValueOrDefault(0),
        //     //                               GSR = g.Sum(gg => gg.GSR).GetValueOrDefault(0),
        //     //                               NSR = g.Sum(gg => gg.NSR).GetValueOrDefault(0),
        //     //                               //    PrdGrp = HandledMouseEventArgs.ke

        //     //                           };



        //     //        foreach (var item in achivementrs)
        //     //        {
        //     //            tbl_kacontractsvolume contractvolume = new tbl_kacontractsvolume();
        //     //            contractvolume.ContractNo = contract.ContractNo;
        //     //            contractvolume.Priod = item.priod;
        //     //            contractvolume.EC = item.EC;
        //     //            contractvolume.NSR = item.NSR;
        //     //            contractvolume.Litter = item.Litter;
        //     //            contractvolume.GSR = item.GSR;
        //     //            contractvolume.PC = item.PC;
        //     //            contractvolume.UC = item.UC;

        //     //            dc.CommandTimeout = 0;
        //     //            dc.tbl_kacontractsvolumes.InsertOnSubmit(contractvolume);
        //     //            dc.SubmitChanges();

        //     //        }




        //     //    }// nue khac nunl tuc la co con tract do thi thuc hienj





        //     //}

        //     //// ARlettermakebyGroupcodeRegion
        //     public static void VolumeupdateperContractbyPRdgrp(string Contractno)
        //     {

        //         string ContractNo = Contractno.Trim();
        //         string connection_string = Utils.getConnectionstr();

        //         LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

        //         #region    //   xoa datavolume conytrac
        //         dc.CommandTimeout = 0;
        //         dc.ExecuteCommand("DELETE FROM tbl_kacontractsvolumePrductGRP Where  tbl_kacontractsvolumePrductGRP.ContractNo = '" + ContractNo + "'");
        //         //    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
        //         dc.SubmitChanges();

        //         #endregion//   xoa datavolume conytrac

        //         #region // example


        //         //  tbl_kacontractsvolumePrductGRP

        //         // var q9 = from tblCustomer in db.tblCustomers
        //         //          where !(from tblFBL5beginbalace in db.tblFBL5beginbalaces
        //         //                  select tblFBL5beginbalace.Account.ToString() + tblFBL5beginbalace.Business_Area).Contains(tblCustomer.Customer.ToString() + tblCustomer.SOrg) && (tblCustomer.Reportsend == true)
        //         //          orderby tblCustomer.Customer
        //         //          group tblCustomer by new
        //         //          {
        //         //         tblCustomer.Customer,
        //         //         tblCustomer.SOrg,
        //         //          }
        //         //          into g
        //         //          select g;

        //         //var results = from c in db.Companies
        //         //              join cn in db.Countries on c.CountryID equals cn.ID
        //         //              join ct in db.Cities on c.CityID equals ct.ID
        //         //              join sect in db.Sectors on c.SectorID equals sect.ID
        //         //              where (c.CountryID == cn.ID) && (c.CityID == ct.ID) && (c.SectorID == company.SectorID) && (company.SectorID == sect.ID)
        //         //              select new { country = cn.Name, city = ct.Name, c.ID, c.Name, c.Address1, c.Address2, c.Address3, c.CountryID, c.CityID, c.Region, c.PostCode, c.Telephone, c.Website, c.SectorID, Status = (ContactStatus)c.StatusID, sector = sect.Name };


        //         //return results.ToList();
        //         #endregion example


        //         var contract = (from tbl_kacontractdata in dc.tbl_kacontractdatas
        //                         where tbl_kacontractdata.ContractNo.Equals( ContractNo)
        //                         select tbl_kacontractdata).FirstOrDefault();


        //         if (contract != null)
        //         {
        //             var achivementrs = from tbl_kasale in dc.tbl_kasales

        //                                join tbl_kaProductGRDetail in dc.tbl_kaProductGRDetails on tbl_kasale.Mat_Number equals tbl_kaProductGRDetail.MatNumber
        //                                select new
        //                                {
        //                                    Invoice_Date = tbl_kasale.Invoice_Date,
        //                                    Sold_to = tbl_kasale.Sold_to,
        //                                    priod = tbl_kasale.Priod,
        //                                    PrdGrp = tbl_kaProductGRDetail.PrdGrp,
        //                                    EC = tbl_kasale.EC,
        //                                    PC = tbl_kasale.PC,
        //                                    UC = tbl_kasale.UC,
        //                                    Litter = tbl_kasale.Litter,
        //                                    GSR = tbl_kasale.GSR,
        //                                    NSR = tbl_kasale.NSR,
        //                                    //    PrdGrp = HandledMouseEventArgs.ke

        //                                } into cc
        //                                where (cc.Invoice_Date <= contract.ExtDate && cc.Invoice_Date >= contract.EffDate) && cc.Sold_to == contract.Customer // && 
        //                                                                                                                                                            //    select cc.Sold_to;

        //                                //View.Viewtable viewtbl = new View.Viewtable(achivementrs, dc, "test!",3);
        //                                //viewtbl.Show();

        //                                group cc by new
        //                                {
        //                                    cc.priod,
        //                                    cc.PrdGrp
        //                                } into g


        //                                select new

        //                                {

        //                                    priod = g.Key.priod,
        //                                    PrdGrp = g.Key.PrdGrp,//.PrdGrp,
        //                                    EC = g.Sum(gg => gg.EC).GetValueOrDefault(0),
        //                                    PC = g.Sum(gg => gg.PC).GetValueOrDefault(0),
        //                                    UC = g.Sum(gg => gg.UC).GetValueOrDefault(0),
        //                                    Litter = g.Sum(gg => gg.Litter).GetValueOrDefault(0),
        //                                    GSR = g.Sum(gg => gg.GSR).GetValueOrDefault(0),
        //                                    NSR = g.Sum(gg => gg.NSR).GetValueOrDefault(0),


        //                                };



        //             foreach (var item in achivementrs)
        //             {
        //                 tbl_kacontractsvolumePrductGRP contractvolume = new tbl_kacontractsvolumePrductGRP();
        //                 contractvolume.ContractNo = contract.ContractNo;
        //                 contractvolume.Priod = item.priod;
        //                 contractvolume.ProductGRP = item.PrdGrp;
        //                 contractvolume.EC = item.EC;
        //                 contractvolume.NSR = item.NSR;
        //                 contractvolume.Litter = item.Litter;
        //                 contractvolume.GSR = item.GSR;
        //                 contractvolume.PC = item.PC;
        //                 contractvolume.UC = item.UC;

        //                 dc.tbl_kacontractsvolumePrductGRPs.InsertOnSubmit(contractvolume);
        //                 dc.SubmitChanges();

        //             }





        //         }// nue khac nunl tuc la co con tract do thi thuc hienj





        //     }


        //     public static void DeleteALLConvertContract()
        //     {
        //         // string ContractNo = Contractno;
        //         string connection_string = Utils.getConnectionstr();

        //         LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //         dc.CommandTimeout = 0;
        //         //#region    //   xoa datavolume conytrac
        //         //dc.ExecuteCommand("DELETE FROM tbl_kacontractdata Where  tbl_kacontractdata.SystemCont = 'THI'");
        //         ////    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
        //         //dc.CommandTimeout = 0;
        //         //dc.SubmitChanges();

        //         //dc.ExecuteCommand("DELETE FROM tbl_kacontractsdatadetail Where  tbl_kacontractsdatadetail.SystemCont = 'THI'");
        //         ////    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
        //         //dc.CommandTimeout = 0;
        //         //dc.SubmitChanges();

        //         //dc.ExecuteCommand("DELETE FROM tbl_kacontractsdetailpayment Where  tbl_kacontractsdetailpayment.SystemCont = 'THI'");
        //         ////    dc.tblFBL5Nnewthisperiods.DeleteAllOnSubmit(rsthisperiod);
        //         //dc.CommandTimeout = 0;
        //         //dc.SubmitChanges();

        //         //#endregion//   xoa datavolume conytrac


        //     }


        //     public static IQueryable getViewcontractMaster(LinqtoSQLDataContext db)
        //     {


        //         string username = Utils.getusername();

        //         var regioncode = (from tbl_Temp in db.tbl_Temps
        //                           where tbl_Temp.username == username
        //                           select tbl_Temp.RegionCode).FirstOrDefault();
        //         var typecontract = from Tka_RightContracttypeview in db.Tka_RightContracttypeviews
        //                            where Tka_RightContracttypeview.UserName == username
        //                            select Tka_RightContracttypeview.Contracttype;

        //         var rs = from tbl_kacontractdata in db.tbl_kacontractdatas
        //                  where (from Tka_RegionRight in db.Tka_RegionRights
        //                         where Tka_RegionRight.RegionCode == regioncode
        //                         select Tka_RegionRight.Region
        //                         ).Contains(tbl_kacontractdata.SALORG_CTR) && tbl_kacontractdata.Consts == "ALV"
        //                         && typecontract.Contains(tbl_kacontractdata.ConType)
        //                  orderby tbl_kacontractdata.ConType, tbl_kacontractdata.ContractNo

        //                  select new
        //                  {
        //                      tbl_kacontractdata.ContractNo,
        //                      tbl_kacontractdata.SalesOrg,
        //                      tbl_kacontractdata.ConType,//contract type
        //                      tbl_kacontractdata.Consts, //contract status
        //                      tbl_kacontractdata.Currency,
        //                      Validfrom = tbl_kacontractdata.EffDate,
        //                      Validto = tbl_kacontractdata.EftDate,
        //                      extDate = tbl_kacontractdata.ExtDate,

        //                      tbl_kacontractdata.Customer,
        //                      tbl_kacontractdata.Fullname,
        //                      Address = tbl_kacontractdata.HouseNo + " " + tbl_kacontractdata.District + " " + tbl_kacontractdata.Province,
        //                      tbl_kacontractdata.Channel,
        //                      FullCommitment = tbl_kacontractdata.TotSponsoredcommit,
        //                      tbl_kacontractdata.PCVolAched,
        //                      tbl_kacontractdata.NSRAched,
        //                      tbl_kacontractdata.UCVolAched,
        //                      tbl_kacontractdata.Revenue,

        //                      tbl_kacontractdata.Cash,
        //                      tbl_kacontractdata.FreeGood,
        //                      tbl_kacontractdata.POS,

        //                      tbl_kacontractdata.Promotion,
        //                      tbl_kacontractdata.MKTFun,

        //                      AchivedCommitment = tbl_kacontractdata.TotDeal,
        //                      tbl_kacontractdata.Tot_paid,
        //                      tbl_kacontractdata.Cash_paid,
        //                      tbl_kacontractdata.FreeGood_paid,
        //                      tbl_kacontractdata.POS_paid,

        //                      tbl_kacontractdata.Promotion_paid,
        //                      tbl_kacontractdata.MKTFun_paid,

        //                      Balance = tbl_kacontractdata.TotDeal - tbl_kacontractdata.Tot_paid,

        //                      PosBalance = tbl_kacontractdata.POS - tbl_kacontractdata.POS_paid,

        //                      OthersBalance = tbl_kacontractdata.TotDeal - tbl_kacontractdata.Tot_paid - tbl_kacontractdata.POS + tbl_kacontractdata.POS_paid,
        //                      VolumeCommit = tbl_kacontractdata.VolComm,


        //                      tbl_kacontractdata.Remarks,
        //                      tbl_kacontractdata.DeliveredBy,
        //                      tbl_kacontractdata.Representative,
        //                      tbl_kacontractdata.VATregistrationNo,
        //                      tbl_kacontractdata.CRDDAT,
        //                      tbl_kacontractdata.CRDUSR,
        //                      //      tbl_kacontractdata.VolComm,


        //                  };

        //         return rs;

        //     }

        //     public static void FormatViewcontractmaster(DataGridView dataGridView1)
        //     {

        //         #region  format


        //         //tbl_kacontractdata.ContractNo,
        //         //dataGridView1.Columns["ContractNo"].DisplayIndex = 0;
        //         ////             tbl_kacontractdata.SalesOrg,
        //         //dataGridView1.Columns["SalesOrg"].DisplayIndex = 1;
        //         ////             tbl_kacontractdata.ConType,//contract type
        //         //dataGridView1.Columns["ConType"].DisplayIndex = 2;
        //         ////             tbl_kacontractdata.Consts, //contract status
        //         //dataGridView1.Columns["Consts"].DisplayIndex = 3;
        //         ////             tbl_kacontractdata.Currency,
        //         //dataGridView1.Columns["Currency"].DisplayIndex = 4;
        //         ////             Validfrom = tbl_kacontractdata.EffDate,
        //         //dataGridView1.Columns["Validfrom"].DisplayIndex = 5;
        //         ////             Validto = tbl_kacontractdata.EftDate,
        //         //dataGridView1.Columns["Validto"].DisplayIndex = 6;
        //         ////  extDate
        //         //dataGridView1.Columns["extDate"].DisplayIndex = 7;

        //         ////             tbl_kacontractdata.Customer,
        //         //dataGridView1.Columns["Customer"].DisplayIndex = 8;
        //         ////             tbl_kacontractdata.Fullname,
        //         //dataGridView1.Columns["Fullname"].DisplayIndex = 9;
        //         ////    Address = tbl_kacontractdata.HouseNo + " " + tbl_kacontractdata.District + " " + tbl_kacontractdata.Province,
        //         ////             tbl_kacontractdata.Channel,
        //         //dataGridView1.Columns["Address"].DisplayIndex = 10;
        //         //dataGridView1.Columns["Channel"].DisplayIndex = 11;
        //         ////             FullCommitment = tbl_kacontractdata.TotSponsoredcommit,
        //         //dataGridView1.Columns["FullCommitment"].DisplayIndex = 12;
        //         dataGridView1.Columns["FullCommitment"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["FullCommitment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";
        //         //             tbl_kacontractdata.Cash,
        //     //    dataGridView1.Columns["Cash"].DisplayIndex = 13;
        //         dataGridView1.Columns["Cash"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["Cash"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";
        //         //             tbl_kacontractdata.FreeGood,
        //     //        dataGridView1.Columns["FreeGood"].DisplayIndex = 14;
        //         dataGridView1.Columns["FreeGood"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["FreeGood"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";
        //         //             tbl_kacontractdata.POS,
        ////                dataGridView1.Columns["POS"].DisplayIndex = 15;
        //         dataGridView1.Columns["POS"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["POS"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";
        //         //             tbl_kacontractdata.MKTFun,
        //   //                    dataGridView1.Columns["MKTFun"].DisplayIndex = 16;
        //         dataGridView1.Columns["MKTFun"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["MKTFun"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             AchivedCommitment = tbl_kacontractdata.TotDeal,
        //  //       dataGridView1.Columns["AchivedCommitment"].DisplayIndex = 17;
        //         dataGridView1.Columns["AchivedCommitment"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["AchivedCommitment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";
        //         //             tbl_kacontractdata.Tot_paid,
        //    //          dataGridView1.Columns["Tot_paid"].DisplayIndex = 18;
        //         dataGridView1.Columns["Tot_paid"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["Tot_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";
        //         //             tbl_kacontractdata.Cash_paid,
        //  //                   dataGridView1.Columns["Cash_paid"].DisplayIndex = 19;
        //         dataGridView1.Columns["Cash_paid"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["Cash_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             tbl_kacontractdata.FreeGood_paid,

        // //        dataGridView1.Columns["FreeGood_paid"].DisplayIndex = 20;
        //         dataGridView1.Columns["FreeGood_paid"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["FreeGood_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             tbl_kacontractdata.POS_paid,

        //    //     dataGridView1.Columns["POS_paid"].DisplayIndex = 21;
        //         dataGridView1.Columns["POS_paid"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["POS_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             tbl_kacontractdata.MKTFun_paid,

        //  //       dataGridView1.Columns["MKTFun_paid"].DisplayIndex = 22;
        //         dataGridView1.Columns["MKTFun_paid"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["MKTFun_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             Balance = tbl_kacontractdata.TotDeal - tbl_kacontractdata.Tot_paid,

        //         dataGridView1.Columns["Balance"].DisplayIndex = 23;
        //         dataGridView1.Columns["Balance"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";



        //         dataGridView1.Columns["PosBalance"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["PosBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         dataGridView1.Columns["OthersBalance"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["OthersBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             VolumeCommit = tbl_kacontractdata.VolComm,



        //       //  dataGridView1.Columns["VolumeCommit"].DisplayIndex = 24;
        //         dataGridView1.Columns["VolumeCommit"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["VolumeCommit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";


        //         //             tbl_kacontractdata.PCVolAched,

        //     //    dataGridView1.Columns["PCVolAched"].DisplayIndex = 25;
        //         dataGridView1.Columns["PCVolAched"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["PCVolAched"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             tbl_kacontractdata.NSRAched,
        //      //   dataGridView1.Columns["NSRAched"].DisplayIndex = 26;
        //         dataGridView1.Columns["NSRAched"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["NSRAched"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             tbl_kacontractdata.UCVolAched,
        //      //   dataGridView1.Columns["UCVolAched"].DisplayIndex = 27;
        //         dataGridView1.Columns["UCVolAched"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["UCVolAched"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";


        //    //     dataGridView1.Columns["Revenue"].DisplayIndex = 28;
        //         dataGridView1.Columns["Revenue"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["Revenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";


        //         dataGridView1.Columns["Promotion"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["Promotion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";


        //         dataGridView1.Columns["Promotion_paid"].DefaultCellStyle.Format = "N0";
        //         dataGridView1.Columns["Promotion_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// = "N0";

        //         //             tbl_kacontractdata.CRDDAT,
        //         //        dataGridView1.Columns["CRDDAT"].DisplayIndex = 29;

        //         //             tbl_kacontractdata.CRDUSR,
        //         //        dataGridView1.Columns["CRDUSR"].DisplayIndex = 30;





        //         #endregion

        //         // return null;

        //     }
        // public static void ConvertALLBeginMasterCont()
        // {



        //     #region convert masterContract begin to 
        //     SqlConnection conn2 = null;
        //     SqlDataReader rdr1 = null;

        //     string destConnString = Utils.getConnectionstr();
        //     try
        //     {

        //         conn2 = new SqlConnection(destConnString);
        //         conn2.Open();
        //         SqlCommand cmd1 = new SqlCommand("kaInsertConverMasterContract", conn2);
        //         cmd1.CommandType = CommandType.StoredProcedure;
        //         //      cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = userupdate;
        //         cmd1.CommandTimeout = 0;
        //         rdr1 = cmd1.ExecuteReader();



        //         //       rdr1 = cmd1.ExecuteReader();

        //     }
        //     finally
        //     {
        //         if (conn2 != null)
        //         {
        //             conn2.Close();
        //         }
        //         if (rdr1 != null)
        //         {
        //             rdr1.Close();
        //         }
        //     }
        //     //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //     #endregion


        //     #region convert DetailContract begin to 
        //     //SqlConnection conn2 = null;
        //     //SqlDataReader rdr1 = null;

        //     //string destConnString = Utils.getConnectionstr();
        //     try
        //     {

        //         conn2 = new SqlConnection(destConnString);
        //         conn2.Open();
        //         SqlCommand cmd1 = new SqlCommand("kaInsertConvertDetailContract", conn2);
        //         cmd1.CommandType = CommandType.StoredProcedure;
        //         //      cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = userupdate;
        //         cmd1.CommandTimeout = 0;
        //         rdr1 = cmd1.ExecuteReader();



        //         //       rdr1 = cmd1.ExecuteReader();

        //     }
        //     finally
        //     {
        //         if (conn2 != null)
        //         {
        //             conn2.Close();
        //         }
        //         if (rdr1 != null)
        //         {
        //             rdr1.Close();
        //         }
        //     }
        //     //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //     #endregion


        //     #region convert PaymentinforContract begin to 
        //     //SqlConnection conn2 = null;
        //     //SqlDataReader rdr1 = null;

        //     //string destConnString = Utils.getConnectionstr();
        //     try
        //     {

        //         conn2 = new SqlConnection(destConnString);
        //         conn2.Open();
        //         SqlCommand cmd1 = new SqlCommand("kaInsertConvertPaymentContract", conn2);
        //         cmd1.CommandTimeout = 0;
        //         cmd1.CommandType = CommandType.StoredProcedure;
        //         //      cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = userupdate;
        //         //  cmd1.CommandTimeout = 0;
        //         rdr1 = cmd1.ExecuteReader();



        //         //       rdr1 = cmd1.ExecuteReader();

        //     }
        //     finally
        //     {
        //         if (conn2 != null)
        //         {
        //             conn2.Close();
        //         }
        //         if (rdr1 != null)
        //         {
        //             rdr1.Close();
        //         }
        //     }
        //     //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //     #endregion


        // }// end frunction



        // public static void AccrualContractinSQL(DateTime Accrualdate)
        // {
        //     if (Accrualdate != null)
        //     {

        //         #region tính tren sa

        //         //  Control.Control_ac.CaculationALLContractinSQLbySQL();

        //         SqlConnection conn2 = null;

        //         SqlDataReader rdr1 = null;

        //         string destConnString = Utils.getConnectionstr();
        //         try
        //         {

        //             conn2 = new SqlConnection(destConnString);
        //             conn2.Open();
        //             SqlCommand cmd1 = new SqlCommand("AccrualContractinSQLbySQL", conn2);
        //             cmd1.CommandTimeout = 0;
        //             cmd1.CommandType = CommandType.StoredProcedure;
        //             cmd1.Parameters.Add("@Accrualdate", SqlDbType.DateTime).Value = Accrualdate;

        //             rdr1 = cmd1.ExecuteReader();



        //             //       rdr1 = cmd1.ExecuteReader();

        //         }
        //         finally
        //         {
        //             if (conn2 != null)
        //             {
        //                 conn2.Close();
        //             }
        //             if (rdr1 != null)
        //             {
        //                 rdr1.Close();
        //             }
        //         }
        //         //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //         //     #endregion


        //         #endregion


        //     }



        // }

        // public static void CaculationALLContractinSQL( )
        // {
        //     #region tính tren sa

        //   //  Control.Control_ac.CaculationALLContractinSQLbySQL();

        //     SqlConnection conn2 = null;
        //     SqlDataReader rdr1 = null;

        //     string destConnString = Utils.getConnectionstr();
        //     try
        //     {

        //         conn2 = new SqlConnection(destConnString);
        //         conn2.Open();
        //         SqlCommand cmd1 = new SqlCommand("CaculationALLContractinSQLbySQL", conn2);
        //         cmd1.CommandType = CommandType.StoredProcedure;
        //         //  cmd1.Parameters.Add("@Contractno", SqlDbType.VarChar).Value = Contractno;
        //         cmd1.CommandTimeout = 0;
        //         rdr1 = cmd1.ExecuteReader();



        //         //       rdr1 = cmd1.ExecuteReader();

        //     }
        //     finally
        //     {
        //         if (conn2 != null)
        //         {
        //             conn2.Close();
        //         }
        //         if (rdr1 != null)
        //         {
        //             rdr1.Close();
        //         }
        //     }
        //     //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        ////     #endregion


        //     #endregion


        //     //#region // tính  hợp đồng trên phương thức 1



        //     //string connection_string = Utils.getConnectionstr();

        //     //LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

        //     //var contractrs = from tbl_kacontractdata in dc.tbl_kacontractdatas
        //     //                 where tbl_kacontractdata.Consts == "ALV"
        //     //                 select tbl_kacontractdata.ContractNo;

        //     //if (contractrs.Count() > 0)
        //     //{
        //     //    foreach (var item in contractrs)
        //     //    {
        //     //   //     CaculationContractinSQLmaster(item);


        //     //        Control_ac.CaculationContract(item); // tinhs toasn contract truo c khi view

        //     //        Control.Control_ac.CaculationContractinSQLmaster(item);


        //     //    }




        //     //}
        //     //#endregion    

        // }
        // public static void CaculationContractinSQLmaster(string Contractno)
        // {

        //     #region convert PaymentinforContract begin to 
        //     SqlConnection conn2 = null;
        //     SqlDataReader rdr1 = null;

        //     string destConnString = Utils.getConnectionstr();
        //     try
        //     {

        //         conn2 = new SqlConnection(destConnString);
        //         conn2.Open();
        //         SqlCommand cmd1 = new SqlCommand("kaCaculationContractinSQLmaster", conn2);
        //         cmd1.CommandType = CommandType.StoredProcedure;
        //         cmd1.Parameters.Add("@Contractno", SqlDbType.VarChar).Value = Contractno;
        //         cmd1.CommandTimeout = 0;
        //         rdr1 = cmd1.ExecuteReader();



        //         //       rdr1 = cmd1.ExecuteReader();

        //     }
        //     finally
        //     {
        //         if (conn2 != null)
        //         {
        //             conn2.Close();
        //         }
        //         if (rdr1 != null)
        //         {
        //             rdr1.Close();
        //         }
        //     }
        //     //     MessageBox.Show("ok", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //     #endregion


        // }









        class datatoExport
        {
            public System.Data.DataTable dataGrid1 { get; set; }
            public string filename { get; set; }
            public string tittle { get; set; }
        }





        public static void exportsexcel(object objextoEl)
        {

            datatoExport dat = (datatoExport)objextoEl;


            //      DataTable table, string filename
            DataTable dt = dat.dataGrid1;
            string filename = dat.filename;
            //   SpreadsheetDocument spse = SpreadsheetDocument.Create(filename, SpreadsheetDocumentType.Workbook);
            //Exporting to Excel

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            //ExcelDocument xls = new ExcelDocument();
            //xls.easy_WriteXLSFile_FromDataSet("datatable.xls", ds,
            //           new ExcelAutoFormat(DocumentFormat.OpenXml.Wordprocessing.Styles.AUTOFORMAT_EASYXLS1), "DataTable");


            //string folderPath = "C:\\Excel\\";
            //if (!Directory.Exists(folderPath))
            //{
            //    Directory.CreateDirectory(folderPath);
            //}
            try
            {
                //using (XLWorkbook wb = new XLWorkbook())
                //{

                ExportToExcel.ExportToExcel.ExportDataSet(ds, filename);
                //    wb.Worksheets.Add(ds);
                //    wb.SaveAs(filename);
                //}
                MessageBox.Show(filename + " exported !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Thông báo không excel export được ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public static void exportsexcel2old(object objextoEl)
        {

            datatoExport dat = (datatoExport)objextoEl;

            //    DataTable dataTble = new DataTable();
            //   DataSet dataSet, string outputPath

            // Create the Excel Application object
            cExcel.ApplicationClass excelApp = new cExcel.ApplicationClass();

            // Create a new Excel Workbook
            cExcel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

            int sheetIndex = 0;
            System.Data.DataTable dt = dat.dataGrid1;


            var tittle = dat.tittle;
            var filename = dat.filename;

            // Copy the DataTable to an object array
            object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];

            // Copy the column names to the first row of the object array
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                rawData[0, col] = dt.Columns[col].ColumnName.Replace("_"," ");
            }

            // Copy the values to the object array
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    rawData[row + 1, col] = dt.Rows[row].ItemArray[col];
                }
            }

            // Calculate the final column letter
            string finalColLetter = string.Empty;
            string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int colCharsetLen = colCharset.Length;

            if (dt.Columns.Count > colCharsetLen)
            {
                finalColLetter = colCharset.Substring(
                    (dt.Columns.Count - 1) / colCharsetLen - 1, 1);
            }

            finalColLetter += colCharset.Substring(
                    (dt.Columns.Count - 1) % colCharsetLen, 1);

            // Create a new Sheet
            cExcel.Worksheet excelSheet = (cExcel.Worksheet)excelWorkbook.Sheets.Add(
                excelWorkbook.Sheets.get_Item(++sheetIndex),
                Type.Missing, 1, cExcel.XlSheetType.xlWorksheet);

            //         excelSheet.Name = dt.TableName;

            // Fast data export to Excel
            string excelRange = string.Format("A1:{0}{1}",
                finalColLetter, dt.Rows.Count + 1);

            excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;

            // Mark the first row as BOLD
            ((cExcel.Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;


            // Save and Close the Workbook


            excelWorkbook.SaveAs(filename, cExcel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, cExcel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelWorkbook.Close(true, Type.Missing, Type.Missing);
            //   xlApp.Quit();



            //excelWorkbook.SaveAs(outputPath, cExcel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            //    Type.Missing, Type.Missing, Type.Missing, cExcel.XlSaveAsAccessMode.xlExclusive,
            //    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //excelWorkbook.Close(true, Type.Missing, Type.Missing);
            //excelWorkbook = null;

            // Release the Application object
            excelApp.Quit();
            excelApp = null;

            // Collect the unreferenced objects
            GC.Collect();
            GC.WaitForPendingFinalizers();



            MessageBox.Show(filename + " exported !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public void exportexceldatagridtofile(IQueryable iquery, LinqtoSQLDataContext db, string tittle)
        {
            System.Data.DataTable datatable1 = new System.Data.DataTable();
            //
           
            Utils ul = new Utils();

            datatable1 = ul.ToDataTable(db, iquery);
            SaveFileDialog thedialog = new SaveFileDialog();
            //


            //   datagridview datagridview1 = new datagridview();
            //   datagridview1.datasource = datagrid.datasource;

            thedialog.Title = "export to excel file";
            thedialog.Filter = "excel files|*.xlsx; *.xls";
            thedialog.InitialDirectory = @"c:\";

        
            if (thedialog.ShowDialog() == DialogResult.OK)
            {

                string filename = thedialog.FileName.ToString();
                Thread t1 = new Thread(exportsexcel);
                t1.IsBackground = true;
                t1.Start(new datatoExport() { dataGrid1 = datatable1, filename = filename, tittle = tittle });
                // t1.join();
            }



        }




    }

}