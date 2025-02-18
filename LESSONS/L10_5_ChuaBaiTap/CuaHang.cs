using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L10_5_ChuaBaiTap
{
    public class CuaHang
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();

        public string? Name { get; set; }

        public string? SDT { get; set; }

        public string? DiaChi { get; set; }

        public List<XeMay> XeMays { get; set; } = new List<XeMay>();

        public void InThongTin() 
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
