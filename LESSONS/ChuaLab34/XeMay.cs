using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaLab34
{
    internal class XeMay
    {

        public string ID { get; set; } = Guid.NewGuid().ToString();

       // public long ID { get; set; }

        public string? Ten { get; set; }

        public int NamSX { get; set; }

        public double Gia { get; set; }

        public string? ThuongHieu { get; set; } 

        public void InID()
        {
            Console.WriteLine(ID);
        }
    }
}
