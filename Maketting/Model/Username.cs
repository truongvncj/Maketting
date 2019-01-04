using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maketting.Model
{





    class Username
    {

        public string Name { get; set; }
        public Boolean right { get; set; }
        public int Version { get; set; }
        public bool phanquyen { get; set; }
        public Boolean inputcontractconfirm { get; set; }
        public Boolean paymentdisplay { get; set; }
        public Boolean paymentcreate { get; set; }
        public Boolean saleupdate { get; set; }
        public Boolean saleview { get; set; }
        public Boolean saledeleted { get; set; }
        public Boolean salechange { get; set; }
        public Boolean reports { get; set; }
        public Boolean masterdata { get; set; }
        public Boolean masterbegin { get; set; }

        public Boolean userssetup { get; set; }
        public Boolean pricingcheckview { get; set; }

        public Boolean pricingcheckupdate { get; set; }

        public Boolean inputcontractfinalcontrol { get; set; }

        public Boolean masterdatafuction { get; set; }

        public Boolean changeitem { get; set; }

        public Boolean btaddnewItem { get; set; }

        public static string getUsername()
        {

            string Name = Utils.getusername();

            return Name;



        }
        //  public int Version { get; set; }

        public static int getVersion()
        {
            string Name = Utils.getusername();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            int rs = (int)(from tbl_Temp in dc.tbl_Temps
                           where tbl_Temp.Username == Name
                           select tbl_Temp.Version).FirstOrDefault();





            return rs;



        }

        public static string getmaquyenkho()
        {

            string Name = Utils.getusername();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            string storeright = (string)(from pp in dc.tbl_Temps
                                         where pp.Username == Name
                                         select pp.storeright).FirstOrDefault();







            return storeright;




            //throw new NotImplementedException();
        }

        public static string getuseRegion()
        {

            string Name = Utils.getusername();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            string storeright = (string)(from pp in dc.tbl_Temps
                                         where pp.Username == Name
                                         select pp.Region).FirstOrDefault();







            return storeright;




            //throw new NotImplementedException();
        }
        public static bool getSalesRegionManageright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.SalesRegionManageright).FirstOrDefault();





            return (bool)rs;





        }
        public static bool getCustomerEditright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.CustomerEdit).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getCustomerUploadright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.CustomerUploadright).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getSalesLocationright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.SalesLocationright).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getChannelsalesManageright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.ChannelsalesManageright).FirstOrDefault();





            return (bool)rs;





        }
        public static bool getIOmanageright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.IOmanageright).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getSetPOSMprogrameright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.SetPOSMprogrameright).FirstOrDefault();





            return (bool)rs;





        }


        public static bool getViewProgramePDFright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.ViewProgramePDFright).FirstOrDefault();





            return (bool)rs;





        }
        public static bool getAprovalPaymentRequestright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.AprovalPaymentRequestright).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getRequestpaymentApprovalright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.RequestpaymentApproval).FirstOrDefault();





            return (bool)rs;





        }


        public static bool getuploadBeginStoreright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.uploadBeginStoreright).FirstOrDefault();





            return (bool)rs;





        }


        public static bool getupdateGatePassDeliveredright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.updateGatePassDeliveredright).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getloadTransferOUtright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.TransferOut).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getloadTransferINright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.TransferIN).FirstOrDefault();





            return (bool)rs;





        }



        public static bool getloadStoreIssueright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.StoreIssue).FirstOrDefault();





            return (bool)rs;





        }


        public static bool getloadcreatedright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.Loadcreated).FirstOrDefault();





            return (bool)rs;





        }


        public static bool getsystemright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.System).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getControlUsernameright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.ControlUsername).FirstOrDefault();





            return (bool)rs;





        }


        public static bool getMakettingright()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.MakettingRight).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getWareHouseRight()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.WareHouseRight).FirstOrDefault();





            return (bool)rs;





        }


        public static bool getIOcreateRight()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.IOprogamecreatRight).FirstOrDefault();





            return (bool)rs;





        }



        public static bool getLoadRight()
        {

            string Name = Utils.getusername();

            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.LoadRight).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getReportsRight()
        {


            string Name = Utils.getusername();
            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.ReportsRight).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getInventoryRight()
        {



            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
            string Name = Utils.getusername();

            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.Inventory).FirstOrDefault();





            return (bool)rs;





        }
        public static bool getInventoryAprrovalRight()
        {



            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

            string Name = Utils.getusername();

            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.InventoryAprroval).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getStoreLocationmanageRight()
        {

            string Name = Utils.getusername();


            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.StoreLocationmanage).FirstOrDefault();





            return (bool)rs;





        }

        public static bool getaddNewProductRight()
        {

            string Name = Utils.getusername();


            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.addNewProduct).FirstOrDefault();





            return (bool)rs;





        }



        public static bool getReturnticketRight()
        {

            string Name = Utils.getusername();


            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.ReturnTicket).FirstOrDefault();





            return (bool)rs;





        }




        public static bool getDomoreReturnticketRight()
        {

            string Name = Utils.getusername();


            string connection_string = Utils.getConnectionstr();

            LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


            var rs = (from tbl_Temp in dc.tbl_Temps
                      where tbl_Temp.Username == Name
                      select tbl_Temp.doMoreReturnticket).FirstOrDefault();





            return (bool)rs;





        }
















    }















}
