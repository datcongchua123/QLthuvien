using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLthuvien
{
    internal class Program
    {
        public class Sach
        {
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public string TacGia { get; set; }

            public Sach() { }
            public Sach(string maSach, string tenSach, string tacGia)
            {
                MaSach = maSach;
                TenSach = tenSach;
                TacGia = tacGia;
            }
        }
        public class ThuVien
        {
            private List<Sach> danhSachSach;

            public ThuVien()
            {
                danhSachSach = new List<Sach>();
            }

            public void nhapTT()
            {
                
                Console.Write("Nhap ma sach: ");
                string maSach = Console.ReadLine();

                Console.Write("Nhap ten sach: ");
                string tenSach = Console.ReadLine();

                Console.Write("Nhap ten tac gia: ");
                string tacGia = Console.ReadLine();

                Sach sach = new Sach(maSach, tenSach, tacGia);
                danhSachSach.Add(sach);
                Console.WriteLine("Da them sach vao thu vien.");
            }
            public void XoaSach(string maSachCanXoa)
            {
                Sach sachCanXoa = danhSachSach.Find(sach => sach.MaSach == maSachCanXoa);
                if (sachCanXoa != null)
                {
                    danhSachSach.Remove(sachCanXoa);
                    Console.WriteLine("Da xoa sach ma :"+maSachCanXoa);
                }
                else
                {
                    Console.WriteLine("Khong tim thay sach de xoa ma :"+maSachCanXoa);
                }
            }

            public void xuatTT()
            {
                Console.WriteLine("Danh sach sach trong thu vien ");
                foreach (Sach sach in danhSachSach)
                {
                    Console.WriteLine("Ma Sach | Ten Sach | Tac gia");
                    Console.WriteLine(sach.MaSach + "          " + sach.TenSach +"         "+sach.TacGia);
                }
            }
            static void Main(string[] args)
            {
                ThuVien thuVien = new ThuVien();

                // Thêm sách
                Sach sach = new Sach("1", "abc", "xyz");
                Console.Write("Nhap so luong sach :");
                int n = Convert.ToInt32(Console.ReadLine());
                Sach[] dsS = new Sach[n];
                for (int i = 0; i < n; i++)
                {
                    dsS[i] = new Sach();
                    Console.WriteLine("Nhap thong tin sach " + (i + 1));
                    thuVien.nhapTT();
                    thuVien.xuatTT();
                }
                
                

                // Hiển thị thông tin sách


                // Xóa sách (với mã sách nhập từ bàn phím)
                Console.WriteLine("Nhap ma sach muon xoa :");
                string maSachCanXoa = Console.ReadLine();
                thuVien.XoaSach(maSachCanXoa);

                // Hiển thị thông tin sách sau khi xóa
                thuVien.xuatTT();

                Console.ReadLine();
            }
        }
    }
}
