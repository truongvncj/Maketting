using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using Maketting.shared;
namespace Maketting.Model
{
    public class Storewithlocation
    {

        //public static double getBalancebugetlocation(string materialitemcode, string location, string storelocation)
        //{

        //    //  MessageBox.Show(storelocation);

        //    string connection_string = Utils.getConnectionstr();
        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);
        //    double kq = 0;
        //    var kqtim = (from pp in dc.tbl_MKT_Stockendlocations
        //                 where pp.location == location
        //                 && pp.Store_code == storelocation
        //              && pp.ITEM_Code == materialitemcode
        //                 select pp.END_STOCK).FirstOrDefault();


        //    if (kqtim != null)
        //    {
        //        kq = (double)kqtim;
        //    }
        //    return kq;

        //}

        //public static void updatetangtocklocation(string itemCode, double ordered, string Store_code, string locationstore)
        //{


        //    string connection_string = Utils.getConnectionstr();
        //    LinqtoSQLDataContext dc = new LinqtoSQLDataContext(connection_string);

        //    var valueitem = (from p in dc.tbl_MKT_Stockendlocations
        //                     where p.ITEM_Code == itemCode
        //                     && p.Store_code == Store_code
        //                     && p.location == locationstore
        //                     select p).FirstOrDefault();

        //    if (valueitem != null)
        //    {
        //        valueitem.END_STOCK = valueitem.END_STOCK.GetValueOrDefault(0) + ordered;

        //        dc.SubmitChanges();

        //    }



        //    //throw new NotImplementedException();
        //}



    }
}