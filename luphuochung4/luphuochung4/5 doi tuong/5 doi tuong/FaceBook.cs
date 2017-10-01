using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_doi_tuong
{
    class FaceBook
    {
        private string status;
        private string nguoidang;
        private int share;
        private int like;
        private string binhluan;
        private DateTime ngaydang;
        public FaceBook()
        {
            status = "";
            nguoidang = "";
            share = 0;
            like = 0;
            binhluan = "";
            ngaydang = DateTime.Now;
        }
        public FaceBook(string tt,string nd,int s,int l,string bl,DateTime ndd)
        {
            status = tt;
            nguoidang = nd;
            share = s;
            like = l;
            binhluan = bl;
            ngaydang = ndd;
        }
        public FaceBook(FaceBook d)
        {
            status = d.status;
            nguoidang = d.nguoidang;
            share = d.share;
            like = d.like;
            binhluan = d.binhluan;
            ngaydang = d.ngaydang;
        }
        public void Nhap()
        {
            Console.WriteLine(" THONG TIN STATUS ");
            Console.WriteLine("nguoi dang: ");
            nguoidang = Console.ReadLine();
            Console.WriteLine("Nhap status:");
            status = Console.ReadLine();
            Console.Write("Nhap luot Share: ");
            share = int.Parse(Console.ReadLine());
            Console.Write("Nhap luot Like: ");
            like = int.Parse(Console.ReadLine());
            Console.Write("Nhap luot BinhLuan: ");
            int nam, thang, ngay, gio, phut, giay;
            Console.Write("Ngay:");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Thang:");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nam:");
            nam = int.Parse(Console.ReadLine());
            Console.Write("Gio:");
            gio = int.Parse(Console.ReadLine());
            Console.Write("Phut:");
            phut = int.Parse(Console.ReadLine());
            Console.Write("Giay:");
            giay = int.Parse(Console.ReadLine());
            ngaydang = new DateTime(nam, thang, ngay, gio, phut, giay);
        }
        public void Xuat()
        {
            Console.WriteLine();
            Console.WriteLine("THONG TIN STATUS");
            Console.WriteLine("nguoi dang: {0}", nguoidang);
            Console.WriteLine("ngay dang :{0}", ngaydang);
            Console.WriteLine("noi dung status: {0}", status);
            Console.WriteLine("so luong share: {0}", share);
            Console.WriteLine("so luong like: {0}", like);
            Console.ReadKey();
        }
    }
}
