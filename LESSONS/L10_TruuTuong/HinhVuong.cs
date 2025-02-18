using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TruuTuong
{
    internal class HinhVuong : Hinh2D
    {
        public double Canh { get; set; }
        public override void ChuVi()
        {
            Console.WriteLine($"Chu vi hình vuông = {Canh}x4 = {Canh*4}"); // Những class
                                                                           // khác nhau sẽ định nghĩa class khác nhau
        }

        public override void DienTich()
        {
            Console.WriteLine($"Chu vi hình vuông = {Canh}x{Canh} = {Canh * Canh}");

        }
    }
}
