using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_DaHinh
{
    internal class MayBay : PhuongTienBay
    {
        public override void Bay() // override Ghi đè
        {
            Console.WriteLine("Bay bằng máy bay");
        }
    }
}
