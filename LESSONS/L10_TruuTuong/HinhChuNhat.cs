using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TruuTuong
{
    internal class HinhChuNhat : Hinh2D // Khi kế thừa lớp trừu tượng bắt buộc phải
                                        // ghi đè các phương thức trừu tượng
                                        //virtual: cũng ghi đè nhưng không bắt buộc có thực thi
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public override void ChuVi()
        {
            Console.WriteLine($"Chu Vi HCN: ({ChieuDai}+{ChieuRong})x2 ={ChieuDai+ChieuRong}*2");
        }

        public override void DienTich()
        {
            Console.WriteLine($"Diện tích HCN: {ChieuDai}x{ChieuRong} ={ChieuDai * ChieuRong}");
        }
    }
}
