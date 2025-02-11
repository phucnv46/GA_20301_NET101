using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L9_OnTap_DongGoi_KeThua
{
    internal class GameNhapVai : Game
    {
        public int GocNhin { get; set; }

        public bool IsGacha { get; set; }

        public GameNhapVai()
        {
            
        }

        public GameNhapVai(int id, string ten, int namSX, string nhaPhatTrien,int gocNhin,bool isGacha) : base(id, ten, namSX, nhaPhatTrien)
        {
            GocNhin = gocNhin;
            IsGacha  = isGacha;
        }

        public override void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
