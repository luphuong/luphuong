using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_doi_tuong
{
    class PhanSo
    {
        private int a;
        private int b;
        public PhanSo()
        {
            a = 0;
            b = 1;
        }
        public PhanSo(int a,int b )
        {
            this.a = a;
            this.b = b;
        }
        public PhanSo(PhanSo d)
        {
            a = d.a;
            b = d.b;
        }
        public void Nhap()
        {
            Console.WriteLine("nhap phan so");
            Console.WriteLine("nhap tu so:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau so:");
            b = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("phanso={0}/{1}", a, b);
            Console.ReadKey();
        }
    }
}
