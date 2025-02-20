using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L11_OnTap_ChuaBai
{

    
    internal class Sach
    {

        public string MaSach { get; set; }

        public string TenSach { get; set; }

        public string TacGia { get; set; }

        public int NamXuatBan { get; set; }

        public string TheLoai { get; set; }


        public Sach()
        {
            
        }

        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, string theLoai)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            NamXuatBan = namXuatBan;
            TheLoai = theLoai;
        }

        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
