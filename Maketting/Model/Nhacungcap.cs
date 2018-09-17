
using Maketting.View;
using Maketting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maketting.Model
{
    class Nhacungcap
    {
        public IQueryable Danhsach { get; set; }

     


    
        public static void themmoiNVT(int v1, int v2)
        {

            View.MKTVTDanhsachnhavantai p = new MKTVTDanhsachnhavantai(3, -1);  // 3 là thêm ới

            p.ShowDialog();

            //   throw new NotImplementedException();
        }

        public static void suathongtinNVT(int idtk)
        {


            View.MKTVTDanhsachnhavantai p = new MKTVTDanhsachnhavantai(4, idtk);  // 3 là thêm ới

            p.ShowDialog();



            //   throw new NotImplementedException();
        }

      
    
     
        public static void themmoikhachhangvantai()
        {


            View.MKTVTDanhsackhachhang p = new MKTVTDanhsackhachhang(3, -1);  // 3 là thêm ới

            p.ShowDialog();




            // throw new NotImplementedException();
        }



        public static void suadanhsachkhachhangvantai(int idtk)
        {



            View.MKTVTDanhsackhachhang p = new MKTVTDanhsackhachhang(4, idtk);  // 4 là sua

            p.ShowDialog();






            // throw new NotImplementedException();
        }

      





    }
}
