using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_doi_tuong
{
    class CauHoi
    {
        private string cauhoi;
        private string traloi;    
        private string tennguoidang;
        public CauHoi()
        {
            cauhoi = "";
            traloi = "";
            tennguoidang = "";
        }
        public CauHoi(string ch,string tl,string tnd)
        {
            cauhoi = ch;
            traloi = tl;
            tennguoidang = tnd;
        }
        public CauHoi(CauHoi d)
        {
            cauhoi = d.cauhoi;
            traloi = d.traloi;
            tennguoidang = d.tennguoidang;
        }
        public void Nhap()
        {
            Console.WriteLine("TRANG TRA LOI ONLINE");
            Console.WriteLine("ten nguoi dang: ");
            tennguoidang = Console.ReadLine();
            Console.Write("nhap cau hoi: ");
            cauhoi = Console.ReadLine();
            Console.Write("nhap cau hoi: ");
            traloi = Console.ReadLine();

        }

        public void Xuat()
        {
            Console.WriteLine("");
            Console.WriteLine(" TRANG TRA LOI ONLLINE ");
            Console.WriteLine("nguoi dang : {0}", tennguoidang);
            Console.WriteLine("cau hoi {0}", cauhoi);
           Console.WriteLine("tra loi {0}",traloi);
            Console.ReadKey();
        }
    }
}
