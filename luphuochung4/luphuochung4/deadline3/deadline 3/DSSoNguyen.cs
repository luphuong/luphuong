using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_3
{
    class DSSoNguyen
    {
        private List<int> DS;
        public DSSoNguyen()
        {
            DS = new List<int>();
        }
        public DSSoNguyen(int[] ds)
        {
            this.DS = new List<int>();
            for (int i = 0; i < ds.Length; i++)
            {
                int t = ds[i];
                this.DS.Add(t);
            }
        }
        public DSSoNguyen(List<int> ds)
        {
            this.DS = ds;
        }
        public DSSoNguyen(DSSoNguyen dssn)
        {
            DS = new List<int>();
            for (int i = 0; i < dssn.Count(); i++)
            {
                int t = dssn.getAt(i);
                DS.Add(t);
            }

        }
        public int Count()
        {
            return DS.Count();
        }
        public int getAt(int i)
        {
            return DS[i];
        }
        public void Nhap()
        {
            Console.Write("nhap so luong so nguyen : ");
            int n = int.Parse(Console.ReadLine());
            DS = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int str;
                Console.Write("so nguyen thu {0} : ", i + 1);
                str = int.Parse(Console.ReadLine());
                DS.Add(str);
            }
        }
        public void Xuat()
        {
            Console.WriteLine("DS co {0} so nguyen", DS.Count);
            for (int i = 0; i < DS.Count; i++)
            {
                Console.WriteLine("{0} ", DS[i]);
            }
            Console.ReadKey();
        }
}
}
