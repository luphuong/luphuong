using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_doi_tuong
{
    class Oxy
    {
        private double x;
        private double y;
        public Oxy()
        {
            x = 0;
            y = 0;
        }
        public Oxy(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public Oxy(Oxy d)
        {
            x = d.x;
            y = d.y;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Toa Do Oxy");
            Console.Write("nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("nhap y: ");
            y = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("({0};{1})", x, y);
            Console.ReadKey();
        }
    }
}
