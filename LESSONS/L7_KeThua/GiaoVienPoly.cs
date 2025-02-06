using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L7_KeThua
{
    internal class GiaoVienPoly : GiaoVien
    {
        private string nganhDay;

        public string NganhDay { get => nganhDay; set => nganhDay = value; }

        public GiaoVienPoly()
        {

        }

        public GiaoVienPoly(int id, string name, double soGioDay, string nganhDay) 
            : base(id, name, soGioDay)
        {
            NganhDay = nganhDay;
        }

        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
