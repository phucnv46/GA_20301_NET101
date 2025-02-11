using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L9_OnTap_DongGoi_KeThua
{
    internal class Game
    {
        private int id;

        public int Id { get => id; set => id = value; }

        private string _ten;
        private int namSX;
        private string nhaPhatTrien;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }

        }

        public int NamSX { get => namSX; set => namSX = value; }

        public string NhaPhatTrien { get => nhaPhatTrien; set => nhaPhatTrien = value; }

        public Game() { }

        public Game(int id, string ten, int namSX, string nhaPhatTrien)
        {
            Id = id;
            Ten = ten;
            NamSX = namSX;
            NhaPhatTrien = nhaPhatTrien;
        }

        public virtual void InThongTin()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
