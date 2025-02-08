using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_DaHinh
{
    internal class Vuong : Hinh
    {
        public double Canh { get; set; }


        public override void TinhChuVi()
        {
            Console.WriteLine($"Chu vi hình vuong: {4*Canh}");
        }

        public override void TinhDienTich()
        {
            Console.WriteLine($"Chu vi hình vuong: {Canh*Canh}");
        }
    }
}
