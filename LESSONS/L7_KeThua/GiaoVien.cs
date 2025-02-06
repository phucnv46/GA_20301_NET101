using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L7_KeThua
{
    internal class GiaoVien
    {
        private int id;
        private string name;
        private double soGioDay;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public double SoGioDay { get => soGioDay; set => soGioDay = value; }

        public GiaoVien()
        {
            
        }

        public GiaoVien(int id, string name, double soGioDay)
        {
            Id = id;
            Name = name;
            SoGioDay = soGioDay;
        }

        public void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
