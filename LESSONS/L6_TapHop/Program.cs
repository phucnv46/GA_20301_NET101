using System.Collections;

namespace L6_TapHop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Lap trinh C <Kieu Du lieu> tenmang[slpt];
            // Lap trinh C#: Có nhiều loại tập hơp:mảng, danh sách,
            // mảng danh sách, từ điển ...

            // Khai bao mang
            // C1: sử dụng new
            int[] nguyens = new int[5] ; //kich thuoc mang co dinh
            //C2:
            double[] d = { 2.4, 5,1.6,-9,10,23.3} ; // kich thuoc mang phu thuoc vao slpt

            //Truy cap 1 phan tu
            Console.WriteLine(d[2]);

            //duyệt cả mảng
            //C1
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i]+" ");
            }

            Console.WriteLine();
            //C2: Interation
            foreach (var sothuc in d) // dung cho tat ca cac loai tap hop
            {
                Console.Write(sothuc+" ");
            }
            Console.WriteLine();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Danh sách
            List<string> names = new List<string>() 
            { "Mạnh","Tùng","Thuý" };

            names.Add("Hiếu"); // Thêm phần tử bằng phương thức Add()
            //Truy cập danh sách

            Console.WriteLine(names[2]);

            foreach (var name in names)
            {
                Console.Write(name+ " ");
               
                   
                
            }

            // Xoa phan tu trong danh sach
            names.RemoveAt(0);
            Console.WriteLine(names[0]);

            foreach (var name in names)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();
            //Mang danh sach : ArrayList
            ArrayList chuaLinhTinh = new ArrayList() { 2, 2.5,"Manh", new {Id =3 } }; // Co the chua phan tu khac loai

            Console.WriteLine(chuaLinhTinh[3]);

            //Duyet danh sach
         


            //Tu dien
            Dictionary<string, string> maCacNuoc = new Dictionary<string, string>() { {"vn","Việt Nam" }, {"tl","Thái Lan" } };

            // Sử dụng khoá để truy cập
            Console.WriteLine(maCacNuoc["tl"]);

            foreach (var value in maCacNuoc.Values)
            {
                Console.WriteLine(value);
            }


            //Tạo class SinhVien: MaSinhVien,Ten,DiaChi,SĐT,InThongTin();
            //Tạo 1 class Service có vai trò sử lý logic:
            //1 danh sách SinhVien khoi tao 2 sinh vien
            //Hien thi danh sach sinh vien
            //Thực hiện thêm,
            // Tìm sinh viên theo mã sinh viên
            //xoá SinhVien theo tên.
            //Tạo menu thực hiện các chức năng
            

        }
    }
}
