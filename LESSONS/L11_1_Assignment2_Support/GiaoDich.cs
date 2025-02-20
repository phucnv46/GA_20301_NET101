using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L11_1_Assignment2_Support
{
    internal class GiaoDich
    {
        public string MaGiaoDich { get; set; }

        public TaiKhoan TaiKhoanGui { get; set; }
        public TaiKhoan TaiKhoanNhan { get; set; }

        public LoaiGiaoDich LoaiGiaoDich { get; set; }

        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
            if(LoaiGiaoDich==LoaiGiaoDich.Nhan)
            Console.ForegroundColor = ConsoleColor.Green; 
            else Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    public enum LoaiGiaoDich
    {
        Nhan=0,Gui=1
    }
}
