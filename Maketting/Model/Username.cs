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

        public Username()
        {

            string Name = Utils.getusername();




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

        //public static string getmacty()
        //{
        //    string Username = Utils.getusername();

        //    string connection_string = Utils.getConnectionstr();

        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


        //    string rs = (from tbl_Temp in dc.tbl_Temps
        //                   where tbl_Temp.Username == Username
        //                   select tbl_Temp.Macty).FirstOrDefault();





        //    return rs;



        //}


        //public static string getnamecty()
        //{
        // //   string macty = getmacty();

        //    string connection_string = Utils.getConnectionstr();

        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);


        //    string rs = (from p in dc.tbl_congties
        //                 where p.macty == macty
        //                 select p.tencongty).FirstOrDefault();





        //    return rs;



        //}


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

    }















}
