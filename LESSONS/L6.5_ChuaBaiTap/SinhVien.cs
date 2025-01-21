using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6._5_ChuaBaiTap
{
    internal class SinhVien
    {
		private string _maSV;

		public string MaSV
		{
			get { return _maSV; }
			set { _maSV = value; }
		}

		private string _hoVaTen;

		public string HoVaTen
		{
			get { return _hoVaTen; }
			set { _hoVaTen = value; }
		}

		private string _DiaChi;

		public string DiaChi
		{
			get { return _DiaChi; }
			set { _DiaChi = value; }
		}

		private string _sdt;

		public string SDT
		{
			get { return _sdt; }
			set { _sdt = value; }
		}

        public SinhVien()
        {
            
        }

        public SinhVien(string maSV, string hoVaTen, string diaChi, string sDT)
        {
            MaSV = maSV;
            HoVaTen = hoVaTen;
            DiaChi = diaChi;
            SDT = sDT;
        }


		public void InThongTin()
		{
            Console.WriteLine($"MaSV:{MaSV}, họ và tên : {HoVaTen}, Địa chỉ: {DiaChi}, SĐT: {SDT}");
		}
    }
}
