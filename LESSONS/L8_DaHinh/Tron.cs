using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_DaHinh
{
    internal class Tron : Hinh
    {
        public double BanKinh { get; set; }

        public override void TinhChuVi()
        {
            Console.WriteLine($"Chu vi hình tròn: {2*Math.PI * BanKinh}");
        }

        public override void TinhDienTich()
        {
            Console.WriteLine($"Chu vi hình tròn: { Math.PI * BanKinh*BanKinh}");
        }
    }
}
