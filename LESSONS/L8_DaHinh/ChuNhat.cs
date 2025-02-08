using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_DaHinh
{
    internal class ChuNhat : Hinh
    {

        public double Dai { get; set; }
        public double Rong { get; set; }


        public override void TinhChuVi()
        {
            Console.WriteLine($"Chu vi hình CN: {(Dai + Rong) * 2}");
        }

        public override void TinhDienTich()
        {
            Console.WriteLine($"Chu vi hình CN: {Dai * Rong}");
        }
    }
}
