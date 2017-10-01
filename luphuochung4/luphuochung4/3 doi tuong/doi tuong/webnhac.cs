using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doi_tuong
{
    class webnhac
    {
        private string tenweb;
        private string tenbaihat;
        private string casi;
        private string theloai;
        private int luotlike;
        public webnhac()
        {
            tenweb = "";
            tenbaihat = "";
            casi = "";
            theloai = "";
            luotlike = 0;
        }
        public webnhac(string tw,string tbh,string cs,string tl,int ll)
        {
            tenweb = tw;
            tenbaihat = tbh;
            casi = cs;
            theloai = tl;
            luotlike = ll;
        }
        public webnhac(webnhac d)
        {
            tenweb = d.tenweb;
            tenbaihat = d.tenbaihat;
            casi = d.casi;
            theloai = d.theloai;
            luotlike = d.luotlike;
        }
        public void Nhap()
        {
            Console.WriteLine("THONG TIN NHAC");
            Console.WriteLine("ten web: ");
            tenweb = Console.ReadLine();
            Console.WriteLine("ten bai hat: ");
            tenbaihat = Console.ReadLine();
            Console.WriteLine("ca si: ");
            casi = Console.ReadLine();
            Console.WriteLine("the loai: ");
            theloai = Console.ReadLine();
            Console.WriteLine("luot like: ");
            luotlike = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
        }
        public void Xuat()
        {
            Console.WriteLine("THONG TIN NHAC");
            Console.WriteLine("ten web: {0}",tenweb);
            Console.WriteLine("ten bai hat: {0}",tenbaihat);
            Console.WriteLine("ca si: {0}",casi);
            Console.WriteLine("the loai: {0}",theloai);
            Console.WriteLine("luot like: {0}",luotlike);
            Console.WriteLine("http://mp3.zing.vn/");
            Console.ReadKey();
        }
    }
}
