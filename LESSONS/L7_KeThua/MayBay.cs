using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_KeThua
{
    internal class MayBay : PhuongTien
    {

        public MayBay()
        {
            
        }
        public MayBay(string iD, string name, int namSX, string hang) 
            : base(iD, name, namSX)
        {

            Hang = hang;
        }

        public string Hang { get; set; }

        public new void DiChuyen()
        {
           
            Console.WriteLine($"{Name} Đang bay");
        }
    }
}
