using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_DaHinh
{
    internal class QuanLyBay
    {
        public PhuongTienBay PhuongTienBay { get; set; }

        public void Bay()
        {
            PhuongTienBay.Bay();
        }
    }
}
