using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_3
{
    class TamGiac
    {
        private Diem A, B, C;
        public TamGiac()
        {
            A = new Diem();
            B = new Diem();
            C = new Diem();
        }
        public TamGiac(Diem x, Diem y, Diem z)
        {
            A = x;
            B = y;
            C = z;
        }
        public TamGiac(TamGiac tg)
        {
            A = new Diem(tg.A);
            B = new Diem(tg.B);
            C = new Diem(tg.C);
        }
        public void Nhap()
        {
            Console.WriteLine("nhap thong tin tam giac");
            Console.WriteLine("nhap dinh A ");
            this.A = new Diem();
            this.A.Nhap();
            Console.WriteLine("nhap dinh B ");
            this.B = new Diem();
            this.B.Nhap();
            Console.WriteLine("nhap dinh C ");
            this.C = new Diem();
            this.C.Nhap();

        }
        public void Xuat()
        {
            Console.WriteLine("tam giac co 3 dinh : ");
            Console.Write("A");
            this.A.Xuat();
            Console.Write("B");
            this.B.Xuat();
            Console.Write("C");
            this.C.Xuat();
            Console.ReadKey();
        }
        }
}
