using System.Text;

namespace L7_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiaoVienPoly giaoVienPoly = new GiaoVienPoly();
            giaoVienPoly.Id = int.Parse(Console.ReadLine());
            giaoVienPoly.SoGioDay = 72;
            giaoVienPoly.Name = "phucnv";
            giaoVienPoly.NganhDay = "Lap trinh C#";

            giaoVienPoly.InThongTin();
        }
    }
}
