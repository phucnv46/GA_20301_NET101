using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L11_1_Assignment2_Support
{
    internal class KhachHang
    {
        private string name;

        public long Id { get; set; }

        public string Ten { get => name.ToUpper(); set => name = value; }

        public bool GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string SDT { get; set; }

        public string SoCCCD { get; set; }

        public TaiKhoan TaiKhoan { get; set; }

        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
