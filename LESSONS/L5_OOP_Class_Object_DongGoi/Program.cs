using System.Text;

namespace L5_OOP_Class_Object_DongGoi
{
    internal class Program
    {

        // Cu phap tao doi tuong <Ten class> <Ten doi tuong> = new <constructor>()
        static void Main(string[] args)
        {
           /*  Hero yasuo = new Hero() { Ten= "Yasuo",TaiNguyen = 100, 
                 X= 32.5, Y = 23.756, HP= 1546, Stpt =0,Stvl = 321,}; // Khoi tao properties voi constuctor 0 tham so

            yasuo.Ten = "Yone";

            yasuo.DiChuyen();
            yasuo.InThongTin();

            Hero alok = new Hero("Alok",200,null,14.53,32,null,0,0);*/ // Khoi tao properties voi constructor co tham so


            Console.OutputEncoding = Encoding.UTF8;
            Sung sung = new Sung() {Ten = "AKM",LoaiSung="Trường",LoaiDan="7.62x39mm",TocDoBan=0.5
                ,SoLuongDanToiDa = 30,SoLuongDan=1,DoGiat= DoGiat.Manh,ThoiGianThayDan=2.5 };
            sung.Ban();
            sung.Ban();

            Console.WriteLine(Toan.Tong(3, 6, 12, 32, 3, -23.4));
        }

        //Tao lop sung: co cac thuoc tinh Ten,LoaiDan,TocDoBan,DoGiat, List<PhuKien>, LoaiSung
        // Co phuong thuc ban: In ra ban bang sung gi, dan gi

        // Tao class SinhVien tu mo ta ban than: Ten, Mssv, NgaySinh,Tuoi(suy ra tu ngay sinh),SoThich,...
    }
}
