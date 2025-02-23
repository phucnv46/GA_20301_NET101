using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_ChuaLab78
{
    internal class SanPham
    {
        public SanPham()
        {
        }

        public int MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public double GiaSanPham { get; set; }

        public int SoLuong { get; set; }

        public string LoaiSanPham { get; set; }

        public SanPham(int maSanPham, string tenSanPham, double giaSanPham, int soLuong, string loaiSanPham)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            GiaSanPham = giaSanPham;
            SoLuong = soLuong;
            LoaiSanPham = loaiSanPham;
        }

        internal void InThongTin()
        {
            Console.Write($"Mã Sản phẩm: {MaSanPham}, Tên sản phẩm: {TenSanPham}" +
                $", Giá Sản phẩm: {GiaSanPham}, Số Lượng: {SoLuong}, Loại Sản Phẩm");

           
        }
    }
}
