using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L9_OnTap_DongGoi_KeThua
{
    internal class Service
    {
        static List<Game> _games = new List<Game>()
        {
            new Game(){Id=1,Ten="LMHT",NhaPhatTrien="Riot",NamSX=2008},
            new Game(){Id=2,Ten="Dota2",NhaPhatTrien="Valve",NamSX=2011},
        };

        public static void ThemGame()
        {
            Game game = new Game();
            game.Id = _games.Count == 0 ? 1 : _games[_games.Count - 1].Id + 1;
            Console.Write("Xin mời nhập tên game: ");
            game.Ten = Console.ReadLine();
            Console.Write("Xin mời nhập tên Nhà Phát Triển: ");
            game.NhaPhatTrien = Console.ReadLine();
            Console.Write("Xin mời nhập năm SX: ");
            game.NamSX = int.Parse(Console.ReadLine());

            _games.Add(game);

        }

        public static Game TimGame()
        {
            Console.Write("Xin mời nhập tên hoặc ID: ");
            string input = Console.ReadLine();
            foreach (Game game in _games)
            {
                if (game.Id.ToString().Equals(input) || game.Ten.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    game.InThongTin();
                    return game;
                }
            }

            return null;
        }


        public static void XoaGame()
        {
            HienThiDSGame();
            Game gameBiXoa = TimGame();
            if (gameBiXoa != null)
            {
                _games.Remove(gameBiXoa);

                Console.WriteLine("Danh sách sau khi xoá:");
                HienThiDSGame();
            }
            else
            {
                Console.WriteLine("Không tim được game");
            }
        }

        public static void HienThiDSGame()
        {
            Console.WriteLine(JsonSerializer.Serialize(_games));
        }

        public static void KeThua()
        {
            GameNhapVai game = new GameNhapVai();
            game.Id = _games.Count == 0 ? 1 : _games[_games.Count - 1].Id + 1;
            Console.Write("Xin mời nhập tên game: ");
            game.Ten = Console.ReadLine();
            Console.Write("Xin mời nhập tên Nhà Phát Triển: ");
            game.NhaPhatTrien = Console.ReadLine();
            Console.Write("Xin mời nhập năm SX: ");
            game.NamSX = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập góc nhìn");
            game.GocNhin = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập có gacha hay ko");
            game.IsGacha = Console.ReadKey().KeyChar == 'Y' ? true : false ;

            game.InThongTin();
        }

    }
}
