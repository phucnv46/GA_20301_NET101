using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TruuTuong
{
    internal class MayBay : IFlyable, IRunable
    {

        public void Bay()
        {
            Console.WriteLine("Bay bằng động cơ");
        }

        public void Run()
        {
            Console.WriteLine("Chạy bằng cánh");
        }
    }
}
