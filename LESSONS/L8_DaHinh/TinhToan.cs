using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_DaHinh
{
    internal class TinhToan
    {
        private Hinh _hinh;
        public TinhToan() { }

        public TinhToan(Hinh hinh)
        {
            _hinh = hinh;
        }

        public void TinhChuVi()
        {
            _hinh.TinhChuVi();
        }

        public void TinhDienTich()
        {
            _hinh.TinhDienTich();
        }
    }
}
