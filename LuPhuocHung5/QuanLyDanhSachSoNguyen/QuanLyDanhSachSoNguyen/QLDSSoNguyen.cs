using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyDanhSachSoNguyen
{
    class QLDSSoNguyen
    {
        private List<int> DS;
        public void Nhap()
        {
            Console.Write("Nhap So Luong So Nguyen : ");
            int n = int.Parse(Console.ReadLine());
            DS = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int str;
                Console.Write("So Nguyen Thu {0} : ", i + 1);
                str = int.Parse(Console.ReadLine());
                DS.Add(str);
            }
        }
        public void Xuat()
        {
            Console.WriteLine("DS Co {0} So Nguyen", DS.Count);
            for (int i = 0; i < DS.Count; i++)
            {
                Console.Write("{0} ", DS[i]);
            }
            Console.WriteLine("\n");
        }
        public void ThemDau()
        {
            DS.Add(0);
            Console.WriteLine("Nhap So Nguyen Can Them: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = DS.Count - 2; i >= 0; i--)
            {
                DS[i+1] = DS[i];
            }
            DS[0] = a;
            Console.WriteLine("Phan Tu Sau Khi Them");
            for (int i = 0; i < DS.Count; i++)
            {
                Console.Write(" {0} ", DS[i]);
            }
            Console.ReadKey();
        }
        public void ThemCuoi()
        {
            DS.Add(0);
            Console.WriteLine("Nhap So Nguyen Can Them: ");
            int a = int.Parse(Console.ReadLine());
            DS[DS.Count-1] = a;
            Console.WriteLine("Phan Tu Sau Khi Them");
            for (int i = 0; i < DS.Count; i++)
            {
                Console.Write(" {0} ", DS[i]);
            }
            Console.ReadKey();
        }
        public void ThemViTriThui()
        {

            DS.Add(0);
            Console.WriteLine("Nhap Vi Tri Can Them");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So Nguyen Can Them: ");
            int a = int.Parse(Console.ReadLine());
            if (b > DS.Count)
            {
                DS[DS.Count - 1] = a;
            }
            else
            {
                for (int i = DS.Count - 2; i >= (b-1); i--)
                {
                    DS[i + 1] = DS[i];
                }
                DS[b-1] = a;
            }
            Console.WriteLine("Phan Tu Sau Khi Them");
            for (int i = 0; i < DS.Count; i++)
            {
                Console.Write(" {0} ", DS[i]);
            }
            Console.ReadKey();
        }
        public void XoaTatCaPhanTux()
        {
            Console.WriteLine("So Can Xoa");
            int a = int.Parse(Console.ReadLine());
            for(int i=0;i<DS.Count;i++)
            {
                if(DS[i]==a)
                {
                    for (int j = i; j < DS.Count-1; j++)
                        DS[j] = DS[j + 1];
                    DS.RemoveAt(DS.Count-1);
                }
            }
            for(int k=0;k<DS.Count;k++)
            {
                Console.Write("  {0}  ", DS[k]);
            }
            Console.ReadKey();
        }
        public void XoaPhanTuTaiViTrii()
        {
          //  Console.WriteLine("Nhap Vi Tri Bat Dau tu 0 toi DS.Count-1");
            Console.WriteLine("Vi Tri Can Xoa");
            int a = int.Parse(Console.ReadLine());
            for (int j = a-1; j < DS.Count-1 ; j++)
                DS[j] = DS[j + 1];
            DS.RemoveAt(DS.Count-1);
            for (int k = 0; k < DS.Count; k++)
            {
                Console.Write("  {0}  ", DS[k]);
            }
            Console.ReadKey();
        }
        public void DocFile()
        {
             try
            {
                string[] lines = File.ReadAllLines(@"fucji.txt");


                for (int i = 0; i < Convert.ToInt32(lines[0]); i++)
                {
                    int line = Convert.ToInt32(lines[i + 1]);
                    DS.Add(line);
                }
              // for (int j = 0; j < DS.Count; j++)
                   // Console.Write(" {0} ", DS[j]);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Khong tim thay file !");
                Console.ReadKey();
            }
        }
    }
}

