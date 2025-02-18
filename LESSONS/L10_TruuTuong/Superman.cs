using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TruuTuong
{
    internal class Superman : IFlyable, IRunable
    {
        public void Bay()
        {
            Console.WriteLine("Bay bằng supper man");
        }

        public void Run()
        {
            Console.WriteLine("Chạy bằng chân");
        }
    }
}
