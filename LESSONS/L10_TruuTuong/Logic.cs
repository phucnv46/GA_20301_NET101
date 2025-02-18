using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TruuTuong
{
    internal class Logic
    {
        private Hinh2D _hinh2D;

        public IFlyable FlyObject { get; set; }

        public Logic(Hinh2D hinh2D) // Tiêm phụ thuộc
        {
            _hinh2D = hinh2D;
        }

        public void ChuVi()
        {
            _hinh2D.ChuVi();
        }

        public void DienTich()
        {
            _hinh2D.DienTich();
        }

        public void FlyBy()
        {
            FlyObject.Bay();
        }

    }
}
