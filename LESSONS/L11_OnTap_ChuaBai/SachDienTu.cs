using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L11_OnTap_ChuaBai
{
    internal class SachDienTu : Sach
    {
        public SachDienTu(string maSach, string tenSach, string tacGia, int namXuatBan, string theLoai,
         double kichThuocFile, string dinhDangFile) : base(maSach, tenSach, tacGia, namXuatBan, theLoai)
        {
            KichThuocFile = kichThuocFile;
            DinhDangFile = dinhDangFile;
        }

        public SachDienTu()
        {
            
        }

        public double KichThuocFile { get; set; }

        public string DinhDangFile { get; set; }

        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }

    }
}
