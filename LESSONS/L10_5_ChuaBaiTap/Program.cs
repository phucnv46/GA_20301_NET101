namespace L10_5_ChuaBaiTap
{

    //Bài tập:
    // Tạo 2 class : CuaHang, XeMay
    //CuaHang:
    /*
     Id : int/ string (tự tăng/ tự tạo) hoặc điền
     TenCuaHang: string
     DiaChi: string
     SDT: string
     XeMays : List<XeMay>

     InThongTin()->void();

     XeMay:
    Id: int/string
    TenXe:string
    HangXe: string
    NamSX: int
    LoaiNhienLieu: enum/ string
    IdCuaHang: int/string
    CuaHang: CuaHang

     InThongTin()-> void;

     Tạo 1 interface: IQuanLy: 
     Them();
     Tim(int/ string ID);
     Xoa(); xoá theo id;
    HienThiDanhSach();

     Tạo class QuanLy implement(triển khai) IQuanly
     ...Program tạo menu
    -Hiển thị danh sách xe của 1 cửa hàng

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
