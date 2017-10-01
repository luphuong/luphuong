using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_3
{
    class Diem
    {
        private double x;
        private double y;
        public Diem()// mac dinh truyen
        {
            x = 0;
            y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Diem(Diem d)
        {
            this.x = d.x;
            this.y = d.y;
        }
        public void Nhap()
        {
            Console.Write("nhap x: ");
            x = double.Parse(Console.ReadLine());
            //Diem d=Diem.Parse(Console.ReadLine()); //(3,4);
            Console.Write("nhap y: ");
            y = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("({0};{1})", x, y);
        }
        
       
    }
}
