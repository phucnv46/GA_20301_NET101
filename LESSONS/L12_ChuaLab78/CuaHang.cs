using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_ChuaLab78
{
    internal class CuaHang : IQuanLySanPham
    {
        List<SanPham>  products = new List<SanPham>();
        public void HienThiDanhSach()
        {
            throw new NotImplementedException();
        }

        public void KeThua()
        {
            throw new NotImplementedException();
        }

        public void ThemSanPham()
        {
            SanPham sanPham = new SanPham();
            Console.Write("Xin mời nhập mã: ");
            sanPham.MaSanPham = int.Parse(Console.ReadLine());
            //...

            products.Add(sanPham);
        }

        public SanPham TimSanPham()
        {
            throw new NotImplementedException();
        }

        public void XoaSanPham()
        {
            throw new NotImplementedException();
        }
    }
}
