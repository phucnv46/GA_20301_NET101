using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_ChuaLab78
{
    internal interface IQuanLySanPham
    {
        void ThemSanPham();

        SanPham TimSanPham();

        void XoaSanPham();

        void HienThiDanhSach();

        void KeThua();
    }
}
