using Maketting.Control;
using Maketting.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maketting.Model
{
    class Khohang
    {


        public static void themmoikhohang()
        {
            View.MKTDanhsachkho p = new MKTDanhsachkho(3, -1);  // 3 là thêm ới/ 4 là sửa xóa
                                                                //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();






            // throw new NotImplementedException();
        }

        public static void suaxoadanhsachkho(int iddanhscahkho)
        {




            View.MKTDanhsachkho p = new MKTDanhsachkho(4, iddanhscahkho);  // 3 là thêm ới/ 4 là sửa xóa
                                                                           //  View.BeeDanhsachkho p = new View.BeeDanhsachkho
            p.ShowDialog();





            //  throw new NotImplementedException();
        }

   
   
    
     
    
    



    }


}
