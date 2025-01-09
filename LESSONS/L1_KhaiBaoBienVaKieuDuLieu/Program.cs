using System.ComponentModel.Design;
using System.Text;

namespace L1_KhaiBaoBienVaKieuDuLieu
{
    internal class Program
    {

        //
        /*
         Cong thuc khai bao bien:
        
        <Kieu du lieu> <Ten bien> = <Gia tri khoi tao> ; 

         */

        static void Main(string[] args)
        {
            // Kieu du lieu;
            //Kieu so:
            int nguyen = -+23; // kieu nguyen 32 bit
            uint nguyenKoDau = 32; // Kieu nguyen duong // unsigned

            long nguyenLonHon = 1_000_000_0000;


            // Kieu thap phan/ so thuc:
            float soTP = 1.44232f;
            double soThuc = -2.13423112;

            //kieu chuoi
            string ten = "phuc"; // <=> char[] 

            //Nhap/ Xuat:
            //Đọc 1 dòng
           string nhapVao = Console.ReadLine();

            // In ra :
            // cw + tab
            Console.InputEncoding = Encoding.UTF8; // Nhap vao tieng viet

            Console.OutputEncoding = Encoding.UTF8; // Hien thi duoc tieng viet

            Console.WriteLine("Chuỗi bạn vừa nhập vào là: " + nhapVao); //c2
            Console.WriteLine("Chuỗi bạn vừa nhập vào là: {0}", nhapVao); //c2
            Console.WriteLine($"Chuỗi bạn vừa nhập vào là: {nhapVao}"); //c3

            // Nhap vao cac bien ten, nam sinh, gioi tinh, masv, diem: 
            // Hien thi thong tin ban than

             Console.Write("Xin moi nhap ten:");
             string tenbt = Console.ReadLine();

            Console.Write("Xin moi nhap nam sinh:");
            int namSinh = int.Parse(Console.ReadLine()); //c1

            Console.Write("Xin moi nhap diem:");
            double diem = Convert.ToDouble(Console.ReadLine()); // C2

            Console.WriteLine("Thong tin:");
            Console.WriteLine("Tên: {1}, Tuổi:{0}, Điểm: {2}", DateTime.Now.Year - namSinh, tenbt, diem); // tham so dang sau phai tuong ung voi thu tu trong chuoi truyen vao
        }
    }
}
