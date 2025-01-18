using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_OOP_Class_Object_DongGoi
{
    internal class Sung
    {
		private string _ten;

		public string Ten
		{
			get { return _ten; }
			set { _ten = value; }
		}

		public string LoaiDan { get; set; } = "Không biết";

		public string LoaiSung { get; set; }

		public double TocDoBan { get; set; }

        public DoGiat DoGiat { get; set; }

		public int SoLuongDan { get; set; } = 30;

		public int SoLuongDanToiDa { get; set; } = 30;

        public double ThoiGianThayDan { get; set; }

        public void Ban() 
		{
            Console.WriteLine("Bằng...Bằng");
			SoLuongDan--;
			
            Console.WriteLine($"{SoLuongDan}/{SoLuongDanToiDa}");
			if( SoLuongDan == 0)
			{
                Console.WriteLine("Hết đạn, bạn nên thay đạn");
				ThayDan(30);
			}
		}

		public void ThayDan(int sld)
		{
            Console.WriteLine("Đang thay đạn");
			for(double i = 0; i <= ThoiGianThayDan; i+=0.5)
			{
				Thread.Sleep(500);
                Console.WriteLine("{0:f1}",i);
			}
            Console.WriteLine("Thay xong.");
			SoLuongDan = sld;
		}
    }

	public enum DoGiat
	{
		Manh,Nhe,TrungBinh,KhongGiat
	}

}
