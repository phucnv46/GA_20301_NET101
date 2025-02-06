using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_KeThua
{
    internal class PhuongTien
    {
        public PhuongTien(string iD, string name, int namSX)
        {
            ID = iD;
            Name = name;
            NamSX = namSX;
        }

        public PhuongTien()
        {
            
        }

        public string ID { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public int NamSX { get; set; }

        public void DiChuyen()
        {
            Console.WriteLine($"{Name} Đang di chuyển");
        }

        
    }
}
