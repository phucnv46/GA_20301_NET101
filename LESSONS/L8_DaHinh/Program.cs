using System.Text;

namespace L8_DaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Add(3, 6));
            Console.WriteLine(Add(4.5, 7));
            Console.WriteLine(Add(4.5, 7, -1));

            PhuongTienBay chim = new Chim(); // Nếu sử dụng virtual và override
            // thi khi khai báo bằng lớp cha, vẫn sẽ thực thi phương thức của lớp con

            //chim.Bay();

            QuanLyBay quanLyBay = new QuanLyBay();
            quanLyBay.PhuongTienBay = new MayBay();
            // quanLyBay.Bay();

            //Luyen tập
            /*
            Viết chương trình tính diện tích các hình có lơp cha tên Hinh:
            TinhChuVi(), TinhDienTich();
            Tạo ra các lớp Tron,Vuong,TamGiac,ChuNhat kế thừa từ lớp Hinh
            Tạo ra lớp TinhToan thực hiện chọn loại hình và in ra chu vi, diện tích.

             */
            int choice;
            while (true)
            {
                Console.WriteLine("1.Hình vuông");
                Console.WriteLine("2.Hình tròn");
                Console.WriteLine("3.Hình Chữ nhật");
                Console.WriteLine("4.Thoát");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    default:
                        Console.WriteLine("Chọn sai rồi!");
                        break;
                    case 4: return;
                    case 1:
                        {
                            Vuong vuong = new Vuong();
                            vuong.Canh = 6;

                            TinhToan tinhToan = new TinhToan(vuong);

                            tinhToan.TinhChuVi();
                            tinhToan.TinhDienTich();
                            break;
                        }
                    case 2:
                        {
                            Tron tron = new Tron();
                            tron.BanKinh = 6;

                            TinhToan tinhToan = new TinhToan(tron);
                            tinhToan.TinhChuVi();
                            tinhToan.TinhDienTich();
                            break;
                        }
                    case 3:
                        {
                            ChuNhat chuNhat = new ChuNhat();
                            chuNhat.Dai = 10;
                            chuNhat.Rong = 5;

                            TinhToan tinhToan = new TinhToan(chuNhat);
                            tinhToan.TinhChuVi();
                            tinhToan.TinhDienTich();
                            break;
                        }


                }

            }


        }

        // Overload: các phương thức có chung tên nhưng tham số khác nhau,
        // cách triển khai khác nhau
        static double Add(double x, double y)
        {
            return x + y;
        }

        static int Add(int x, int y) // khac kieu tra ve
        {
            return (int)(x + y);
        }
        static double Add(double x, double y, double z)
        {
            return x + y + z;
        }

    }
}
