using System.Text.Json;

namespace L10_5_ChuaBaiTap
{
    public class XeMay
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Ten { get; set; }

        public string HangXe { get; set; }

        public int NamSX { get; set; }

        public LoaiNhienLieu LoaiNhienLieu { get; set; }

        public int? IdCuaHang { get; set; }

        internal CuaHang? CuaHang { get; set; }


        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }

    public enum LoaiNhienLieu
    {
        Xang = 0, Dien = 1, Hybrid = 2
    }
}