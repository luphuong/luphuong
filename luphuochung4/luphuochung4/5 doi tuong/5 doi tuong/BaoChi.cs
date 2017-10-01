using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_doi_tuong
{
    class BaoChi
    {
        private DateTime ngaydang;
        private string tieude;
        private string noidung;
        private string mota;
        private string tacgia;
        public BaoChi()
        {
            ngaydang =DateTime.Now;
            tieude = "";
            noidung = "";
            mota = "";
            tacgia = "";
        }
        public BaoChi(DateTime nd,string td,string ndd,string mt,string tg)
        {
            ngaydang = nd;
            tieude = td;
            noidung = ndd;
            mota = mt;
            tacgia = tg;
        }
        public BaoChi(BaoChi d)
        {
            ngaydang = d.ngaydang;
            tieude = d.tieude;
            noidung = d.noidung;
            mota = d.mota;
            tacgia = d.tacgia;
        }
        public void Nhap()
        {
            Console.WriteLine(" THONG TIN BAI BAO");
            int nam, thang, ngay, gio, phut, giay;
            Console.Write("ngay:");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("thang:");
            thang = int.Parse(Console.ReadLine());
            Console.Write("nam:");
            nam = int.Parse(Console.ReadLine());
            Console.Write("gio:");
            gio = int.Parse(Console.ReadLine());
            Console.Write("phut:");
            phut = int.Parse(Console.ReadLine());
            Console.Write("giay:");
            giay = int.Parse(Console.ReadLine());
            ngaydang = new DateTime(nam, thang, ngay, gio, phut, giay);
            Console.Write("nhap tieu de:");
            tieude = Console.ReadLine();
            Console.Write("nhap mo ta: ");
            mota = Console.ReadLine();
            Console.Write("nhap noi dung: ");
            noidung = Console.ReadLine();
            Console.Write("nhap tac gia: ");
            tacgia = Console.ReadLine();
            Console.WriteLine("\n\n");
        }
        public void Xuat()
        {
            Console.WriteLine("THONG TIN BAI BAO");
            Console.WriteLine("ngay dang: {0}", ngaydang);
            Console.WriteLine("tieu de: {0}", tieude);
            Console.WriteLine("mo ta: {0}", mota);
            Console.WriteLine("noi dung: {0}", noidung);
            Console.Write("tac gia :{0}", tacgia);
            Console.ReadKey();
        }
        }
}
