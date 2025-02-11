namespace L9_OnTap_DongGoi_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo 1 menu dùng lại cho đến khi chọn thoát
            /*
             1.Thêm 1 Game
             2.Tìm Game theo Id hoặc tên, (hiển thị)
             3.Xoá game theo Id hoặc tên hiển thị danh sách trước và sau khi xoá
             4.Kế thừa: Tạo được object class GameNhapVai
             5.Hiển thị danh sách game
             0.Thoát

             Tạo class Game có các thuộc tính và phương thức sau:
             Các thuộc tính viết dạng đầy đủ ( có cả field lẫn get;set;)
             có 2 constructor không tham số, và có tham số:
             Id: int, string(Guid.ToString()) : tự tăng
             TenGame:string
             NamSX:int
             NhaPhatTrien:string

             phương thức: InThongTin(): in ra thông tin của game

             class con: GameNhapVai:
             Thêm thuộc tính: GocNhin: int;
             IsGacha: bool;


             class Services: chưa danh sách Game;
            Thực hiện logic

             Kế thừa constructor có tham số

             kế thừa phương thức InThongTin();

             */
            int chon;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine(" 1.Thêm 1 Game\r\n" +
                    " 2.Tìm Game theo Id hoặc tên" +
                    "\r\n 3.Xoá game theo Id hoặc tên\r\n " +
                    "4.Kế thừa: Tạo được object class GameNhapVai\r\n" +
                    "\r\n5.Hiển thị" +
                    " 0.Thoát");
                Console.Write("Xin mời nhập lựa chọn: ");
                int.TryParse(Console.ReadLine(), out chon);

                switch (chon)
                {
                    default:
                        Console.WriteLine("Chọn ngu!");
                        break;
                    case 0: Console.WriteLine("Thoát");
                        return;
                    case 1:  Service.ThemGame(); break;
                    case 2:  Service.TimGame(); break;
                    case 3:  Service.XoaGame(); break;
                    case 4:  Service.KeThua(); break;
                    case 5: Service.HienThiDSGame(); break;

                }
            }
        }
    }
}
