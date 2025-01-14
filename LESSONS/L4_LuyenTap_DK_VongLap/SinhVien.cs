using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_LuyenTap_DK_VongLap
{
    internal class SinhVien
    {
		private string _mssv;

		public string Mssv
		{
			get { return _mssv; }
			set { _mssv = value; }
		}

		private string _ten;

		public string Ten
		{
			get { return _ten; }
			set { _ten = value; }
		}

		private DateTime _ngaySinh;

		public DateTime NgaySinh
		{
			get { return _ngaySinh; }
			set { _ngaySinh = value; }
		}


		public int Tuoi
		{
			get { return DateTime.Now.Year - NgaySinh.Year; }
		}

		public void XinChao()
		{
            Console.WriteLine($"{Ten} xin chào các bạn");
		}

		public static void DiHoc()
		{
            Console.WriteLine("đang di hoc");
		}

       
    }
}
