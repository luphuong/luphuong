using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachSoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            QLDSSoNguyen qlsn = new QLDSSoNguyen();
            qlsn.Nhap();
            qlsn.Xuat();
            Console.WriteLine("Cac Lua Chon ");
            Console.WriteLine("1.Them Mot Phan Tu Vao Dau Danh Sach");
            Console.WriteLine("2.Them Mot Phan Tu Vao Cuoi Danh Sach");
            Console.WriteLine("3.Them Mot Phan Tu Vao Vi Tri Thu i");
            Console.WriteLine("4.Xoa Tat Ca Phan Tu Co Gia Tri x");
            Console.WriteLine("5.Xoa Phan Tu Tai Vi Tri i");
            Console.WriteLine("6.Doc File");
            Console.WriteLine("Moi Ban Chon So");
            int n=int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:qlsn.ThemDau();
                    break;
                case 2:qlsn.ThemCuoi();
                    break;
                case 3:qlsn.ThemViTriThui();
                    break;
                case 4:qlsn.XoaTatCaPhanTux();
                    break;
                case 5:qlsn.XoaPhanTuTaiViTrii();
                    break;
                case 6:qlsn.DocFile();
                    break;
                
            }
        }
    }
}
