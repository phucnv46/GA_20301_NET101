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
        public string MaGiaoDich { get; set; } = Guid.NewGuid().ToString();

        public TaiKhoan TaiKhoanGui { get; set; }
        public TaiKhoan TaiKhoanNhan { get; set; }

        public double SoTien { get; set; }

        public LoaiGiaoDich LoaiGiaoDich { get; set; }

        public void InThongTin()
        {
            if (LoaiGiaoDich == LoaiGiaoDich.Nhan)
                Console.ForegroundColor = ConsoleColor.Green;
            else Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Mã Giao Dich: {MaGiaoDich}, STK Gửi {TaiKhoanGui.STK}, STK Nhận: {TaiKhoanNhan.STK} " +
                $"Số Tiền {(LoaiGiaoDich==LoaiGiaoDich.Nhan ? "+" : "-")}{SoTien}");
           
        }
    }

    public enum LoaiGiaoDich
    {
        Nhan=0,Gui=1
    }
}
