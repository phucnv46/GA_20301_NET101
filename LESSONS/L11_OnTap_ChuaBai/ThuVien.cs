using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_OnTap_ChuaBai
{
    internal class ThuVien : IThuVien
    {
        List<Sach> saches = new List<Sach>();

        public void KeThua()
        {
            SachDienTu sach = new SachDienTu();
            Console.Write("Xin mời nhập mã sách: ");
            sach.MaSach = Console.ReadLine();
            Console.Write("Xin mời nhập Tên sách: ");
            sach.TenSach = Console.ReadLine();
            Console.Write("Xin mời nhập Tác giả: ");
            sach.TacGia = Console.ReadLine();
            Console.Write("Xin mời nhập năm xuất bản: ");
            sach.NamXuatBan = int.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập năm xuất bản: ");
            sach.TheLoai = Console.ReadLine();
            Console.Write("Xin mời nhập kích thước file: ");
            sach.KichThuocFile = double.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập định dạng file: ");
            sach.DinhDangFile = Console.ReadLine();

            sach.InThongTin();

        }

        public void ThemSach()
        {
            Sach sach = new Sach();
            Console.Write("Xin mời nhập mã sách: ");
            sach.MaSach = Console.ReadLine();
            Console.Write("Xin mời nhập Tên sách: ");
            sach.TenSach = Console.ReadLine();
            Console.Write("Xin mời nhập Tác giả: ");
            sach.TacGia = Console.ReadLine();
            Console.Write("Xin mời nhập năm xuất bản: ");
            sach.NamXuatBan = int.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập năm xuất bản: ");
            sach.TheLoai = Console.ReadLine();

            saches.Add(sach);

        }

        public Sach TimSach()
        {
            Console.Write("Xin mời nhập mã sách cần tìm: ");
            string maSach = Console.ReadLine();

            foreach (Sach sach in saches)
            {
                if (sach.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase))
                {
                    return sach;
                }
            }
            Console.WriteLine("Không tìm thấy sách!");
            return null;
        }

        public void Xoa()
        {
            Sach sachCanXoa = TimSach();
            if (sachCanXoa is not null)
            {
                saches.Remove(sachCanXoa);
                Console.WriteLine("Xoa thành công");
            }
        }


    }
}
