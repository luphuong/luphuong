using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_3
{
    class PhanSo
    {
        private int tuso;
        private int mauso;
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int ts, int ms)
        {
            tuso = ts;
            mauso = ms;
        }
        public PhanSo(PhanSo ps)
        {
            tuso = ps.tuso;
            mauso = ps.mauso;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap Tu So : ", tuso);
            tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Mau So : ", mauso);
            mauso = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("{0}/{1}", tuso, mauso);
        }
    }
}
