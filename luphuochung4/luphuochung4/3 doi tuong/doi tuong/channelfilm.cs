using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doi_tuong
{
    class channelfilm
    {
        private string tenchannel;
        private string tenphim;
        private int namsanxuat;
        private string thoiluong;
        private string ngonngu;
        private string congtysanxuat;
        private int soluotxem;
        private string noidungphim;
        public channelfilm()
        {
            tenchannel = "";
            tenphim = "";
            namsanxuat = 0;
            thoiluong = "";
            ngonngu = "";
            congtysanxuat = "";
            soluotxem = 0;
            noidungphim = "";
        }
        public channelfilm(string tcn,string tp,int nsx,string tl,string nn,string ctsx,int slx,string ndp)
        {
            tenchannel = tcn;
            tenphim = tp;
            namsanxuat = nsx;
            thoiluong = tl;
            ngonngu = nn;
            congtysanxuat = ctsx;
            soluotxem = slx;
            noidungphim = ndp;
        }
        public channelfilm(channelfilm d)
        {
            tenchannel = d.tenchannel;
            tenphim = d.tenphim;
            namsanxuat = d.namsanxuat;
            thoiluong = d.thoiluong;
            ngonngu = d.ngonngu;
            congtysanxuat = d.congtysanxuat;
            soluotxem = d.soluotxem;
            noidungphim = d.noidungphim;
        }
        public void Nhap()
        {
            Console.WriteLine("THONG TIN PHIM");
            Console.WriteLine("ten channel :");
            tenchannel = Console.ReadLine();
            Console.WriteLine("ten phim :");
            tenphim = Console.ReadLine();
            Console.WriteLine("nam san xuat :");
            namsanxuat = int.Parse(Console.ReadLine());
            Console.WriteLine("thoi luong :");
            thoiluong =Console.ReadLine();
            Console.WriteLine("ngon ngu :");
            ngonngu = Console.ReadLine();
            Console.WriteLine("hang san xuat :");
            congtysanxuat = Console.ReadLine();
            Console.WriteLine("so luot xem :");
            soluotxem = int.Parse(Console.ReadLine());
            Console.WriteLine("noi dung phim :");
            noidungphim = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void Xuat()
        {
            Console.WriteLine("THONG TIN PHIM");
            Console.Write("ten channel: ");
            Console.WriteLine(tenchannel);
            Console.Write("ten phim : ");
            Console.WriteLine(tenphim);
            Console.WriteLine("nam san xuat : {0}",namsanxuat);
            Console.WriteLine("thoi luong : {0}", thoiluong);
            Console.WriteLine("ngon ngu : {0}",ngonngu);
            Console.WriteLine("cong ty san xuat : {0}",congtysanxuat);
            Console.WriteLine("so luot xem : {0}", soluotxem);
            Console.WriteLine("noi dung phim : {0}", noidungphim);
            Console.WriteLine("http://www.phimmoi.net/");
            Console.ReadKey();

        }
    }
}
