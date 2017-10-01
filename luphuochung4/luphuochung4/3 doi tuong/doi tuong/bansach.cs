using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doi_tuong
{
    class bansach
    {
        private string tenweb;
        private string tensach;
        private string tacgia;
        private int luotlike;
        private string gioithieusach;
        private string nhaxb;
        private DateTime ngayxuatban;
        
        public bansach()
        {
         tenweb="";
         tensach="";
         tacgia="";
         luotlike=0;
         gioithieusach="";
         nhaxb="";
         ngayxuatban=DateTime.Now;
        }
        public bansach(string web,string ts,string tg,int ll,string gts,string nx,DateTime nxb )
        {
           this.tenweb = web;
            this.tensach = ts;
            this.tacgia = tg;
            this.luotlike = ll;
            this.gioithieusach = gts;
            this.nhaxb = nx;
            this.ngayxuatban = nxb;
        }
        public bansach(bansach d)
        {
            this.tenweb =d.tenweb;
            this.tensach = d.tensach;
            this.tacgia = d.tacgia;
            this.luotlike = d.luotlike;
            this.gioithieusach = d.gioithieusach;
            this.nhaxb = d.nhaxb;
            this.ngayxuatban = d.ngayxuatban;
        }
        public void Nhap()
        {
            int ngay, thang, nam;
            Console.WriteLine("THONG TIN SACH");
            Console.WriteLine("ten web: ");
            tenweb = Console.ReadLine();
            Console.WriteLine("ten sach: ");
            tensach = Console.ReadLine();
            Console.WriteLine("tac gia: ");
            tacgia = Console.ReadLine();
            Console.Write("Ngay:");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Thang:");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nam:");
            nam = int.Parse(Console.ReadLine());
            ngayxuatban = new DateTime(nam, thang, ngay);
            Console.WriteLine("so luot like: ");
            luotlike = int.Parse(Console.ReadLine());
            Console.WriteLine("gioi thieu sach: ");
            gioithieusach = Console.ReadLine();
            Console.WriteLine("\n\n");
        }
        public void Xuat()
        {
            Console.WriteLine("THONG TIN SACH");
            Console.WriteLine("ten web: {0}",tenweb);
            Console.WriteLine("ten sach: {0}",tensach);
            Console.WriteLine("tac gia: {0}",tacgia);
            Console.WriteLine("ngay xuat ban: {0}",ngayxuatban);
            Console.WriteLine("so luot like: {0}",luotlike);
            Console.WriteLine("gioi thieu sach: {0}",gioithieusach);
            Console.WriteLine("https://tiki.vn/");
            Console.ReadKey();
        }


    }
}
