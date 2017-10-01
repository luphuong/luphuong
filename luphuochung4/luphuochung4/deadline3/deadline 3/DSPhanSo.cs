using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_3
{
    class DSPhanSo
    {
        private List<PhanSo> DS;
        private int n;
        public DSPhanSo()
        {
            DS = new List<PhanSo>();
            n = 0;
        }
        public DSPhanSo(List<PhanSo> ps)
        {
            DS = ps;
        }
        public DSPhanSo(PhanSo[] d)
        {
            DS = new List<PhanSo>();
            for (int i = 0; i < d.Length; i++)
            {
                PhanSo ps = d[i];
                DS.Add(ps);
            }
        }
        public void Nhap()
        {
            Console.WriteLine ("So Luong Phan So: ");
            int n = int.Parse(Console.ReadLine());
            DS = new List<PhanSo>();
            for (int i = 0; i < n; i++)
            {
                PhanSo ps = new PhanSo();
                Console.WriteLine("phan so thu {0}", i + 1);
                ps.nhap();
                DS.Add(ps);
            }
        }
        public void Xuat()
        {
            Console.WriteLine("DS CO {0} phan so", DS.Count);
            for (int i = 0; i < DS.Count; i++)
            {
                Console.Write("Phan So Thu {0}: ",i+1);
                DS[i].xuat();
            }
            Console.ReadKey();
        }
    
}
}
