namespace L10_TruuTuong
{
    internal class Program
    {

        /*
         Trừu tượng trong lập trình hướng đối tượng là khái quát 
         đơn giản các hành vi thuộc tính của đối tượng:
         + abstract, inteface
        
        // Đã là hình thì phải có chu vi và diện tích
        + tuy nhiên cách tính cụ thể của các hình sẽ khác nhau 
        + Khái quát hoá công việc cần thực thi.
        + Đảm bảo thực thi được các chức năng yêu cầu

         */
        static void Main(string[] args)
        {
            // abstract class không sử dụng được với new

            Logic tinhHinhVuong = new Logic(new HinhVuong());
            tinhHinhVuong.DienTich();
            tinhHinhVuong.ChuVi();

            tinhHinhVuong.FlyObject = new Superman();
            tinhHinhVuong.FlyBy();


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

        }
    }
}
