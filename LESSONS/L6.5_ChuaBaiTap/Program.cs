using System.Text;

namespace L6._5_ChuaBaiTap
{

    //Tạo class SinhVien: MaSinhVien,Ten,DiaChi,SĐT,InThongTin();
    //Tạo 1 class Service có vai trò sử lý logic:
    //1 danh sách SinhVien khoi tao 2 sinh vien
    //Hien thi danh sach sinh vien
    //Thực hiện thêm,
    // Tìm sinh viên theo mã sinh viên
    //xoá SinhVien theo mã sinh viên.
    //Tạo menu thực hiện các chức năng
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Service service = new Service();
            service.InDanhSachSinhVien();
            int choice;
            while (true)
            {
                Console.Write("Xin moi chon chức năng");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 0: return;
                    default: Console.WriteLine("Chọn sai chức năng"); break;
                    case 1: service.ThemSinhVien(); break;
                    case 2:
                        {
                           var sv= service.TimSinhVien();
                            sv.InThongTin();
                            break;
                        }
                    case 3: service.XoaSinhVien(); break;
                    case 4: service.InDanhSachSinhVien(); break;
                }

            }
        }
    }
}
