using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_OOP_Class_Object_DongGoi
{
    internal class Hero // class thuc the
    {
		private string _ten;

		public string Ten
		{
			get { return _ten; }
			set {_ten = value; }}

        public double HP { get; set; }

        public double? TaiNguyen { get; set; }

        public double X { get; set; } = 0;


        public double Y { get; set; } = 0;

        public List<TrangBi> TrangBis { get; set; } = new List<TrangBi>();

        public double Stvl { get; set; }

        public double Stpt { get; set; }

        //...
        
        internal void DiChuyen() // Phuong thuc
        {
            X += 10;
            Y += 10;
        }

        // Ham dac biet constructor
        internal Hero() { } // trung ten voi class, cong thuc tao ra doi tuong

        public Hero(string ten, double hP, double? taiNguyen, double x, double y, List<TrangBi> trangBis, double stvl, double stpt)
        {
            Ten = ten;
            HP = hP;
            TaiNguyen = taiNguyen;
            X = x;
            Y = y;
            TrangBis = trangBis;
            Stvl = stvl;
            Stpt = stpt;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Ten:{Ten}, HP:{HP}, Tai nguyen:{TaiNguyen}, " +
                $"Stvl:{Stvl}, Stpt:{Stpt}, Toa do: :{X},{Y}");
        }
    }
}
