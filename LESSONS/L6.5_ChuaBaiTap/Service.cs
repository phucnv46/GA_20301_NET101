using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6._5_ChuaBaiTap
{
    internal class Service
    {
        List<SinhVien> sinhViens = new List<SinhVien>() {
        new SinhVien(){MaSV="PH9991",HoVaTen="Phuc",DiaChi="HaiDuong",SDT="113"},
        new SinhVien(){MaSV="PH9992",HoVaTen="Huy",DiaChi="HaiPhong",SDT="114"},

        };

        public void ThemSinhVien()
        {
            SinhVien sinhVien = new SinhVien();
            Console.Write("Xin mời bạn nhập Mã sinh viên:");
            sinhVien.MaSV = Console.ReadLine();

            Console.Write("Xin mời bạn nhập tên sinh viên:");
            sinhVien.HoVaTen = Console.ReadLine();

            Console.Write("Xin mời bạn nhập địa chỉ sinh viên:");
            sinhVien.DiaChi = Console.ReadLine();

            Console.Write("Xin mời bạn nhập Số ĐT sinh viên:");
            sinhVien.SDT = Console.ReadLine();

            sinhViens.Add(sinhVien);
        }

        public SinhVien TimSinhVien()
        {
            Console.Write("Xin mời bạn nhập Mã sinh viên:");
            string maSV = Console.ReadLine();

            foreach (var sv in sinhViens)
            {
                if (sv.MaSV.Equals(maSV,StringComparison.OrdinalIgnoreCase))
                {
                    return sv;
                }

            }

            return null;
        }


        public void XoaSinhVien()
        {
            SinhVien sinhVienBiXoa = TimSinhVien();

            if (sinhVienBiXoa == null) Console.WriteLine("Không tìm thấy sinh viên");
            else
            {
                sinhViens.Remove(sinhVienBiXoa);
            }

        }

        public void InDanhSachSinhVien()
        {
            foreach (var sv in sinhViens)
            {
                sv.InThongTin();

            }
        }
    }
}
