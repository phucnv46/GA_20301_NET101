using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L11_1_Assignment2_Support
{
    internal class TaiKhoan
    {
        public string STK { get; set; }

        public double SoDu { get; set; }

        public bool TrangThai { get; set; }

        public List<GiaoDich> GiaoDiches { get; set; } = new List<GiaoDich>();

        public KhachHang ChuTaiKhoan { get; set; }

        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
