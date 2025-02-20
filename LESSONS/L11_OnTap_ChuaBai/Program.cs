namespace L11_OnTap_ChuaBai
{
    internal class Program
    {
        /*
         Xây dựng 1 chương trình quản lý sách trong thư viện:
Tạo class Sach có các thuộc tính và phương thức sau:
(Các thuộc tính viết ở dạng đầy đủ (full-property)):
Thuộc tính:
MaSach:int/string
TenSach:string
TacGia:string
NamXuatBan:uint/int
TheLoai:string

Phương thức: InThongTin(): void -> in ra thông tin sách
2 constructor không tham số và có tham số

- Tạo class SachDienTu kế thừa từ Sach
Thêm 2 thuộc tính:
KichThuocFile: double
DinhDangFile: string

Ghi đè phương thức InThongTin(): void -> in ra thông tin sách điện tử
2 constructor không tham số và có tham số (sử dụng base để kế thừa constructor)

- Tạo class ThuVien để xử lý logic:
- có List<Sach>() (Nên khởi tạo trước data để thuận tiện cho chấm điểm)
-Thực hiện các chức năng chính ở đây menu chỉ để gọi chức năng của ThuVien

Ở Program:
Tạo menu lặp đến khi chọn Thoát thực hiện các chức năng sau:
1.Thêm Sách vào danh sách
2.Tìm sách theo mã sách, thông báo nếu không tìm thấy
3.Xoá sách theo mã sách
4.Tạo 1 SachDienTu mới và in ra thông tin của SachDienTu vừa tạo
0.Thoát
         */

        static void Main(string[] args)
        {
            int luaChon;

            IThuVien thuVien = new ThuVien();
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("1.Thêm Sách vào danh sách" +
                    "\r\n2.Tìm sách theo mã sách, thông báo nếu không tìm thấy" +
                    "\r\n3.Xoá sách theo mã sách" +
                    "\r\n4.Tạo 1 SachDienTu mới và in ra thông tin của SachDienTu vừa tạo" +
                    "\r\n0.Thoát");
                Console.Write("Xin mời nhập lựa chọn");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    default:
                        Console.WriteLine("Chọn sai!");
                        break;
                    case 0: return;
                    case 1: thuVien.ThemSach() ;  break;
                    case 2: thuVien.TimSach() ;  break;
                    case 3: thuVien.Xoa() ;  break;
                    case 4: thuVien.KeThua() ;  break;
                }
            }
        }
    }
}
