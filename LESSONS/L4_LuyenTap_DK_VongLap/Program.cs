using System.Text;

namespace L4_LuyenTap_DK_VongLap
{
    internal class Program
    // public: cấp truy cập cao nhất có thể truy cập khác project
    // internal: Có thể truy cập trong cùng project
    // protected: Truy cập trong class kế thừa
    // private chỉ truy cập trong class
    {
        static void Main(string[] args) // static sẽ sử dụng được trực tiếp với class mà khong
                                        //can thong qua object bằng toán tử new
        {

            /*SinhVien manh = new SinhVien() { Mssv = "PH59967", Ten ="Manh", NgaySinh= new DateTime(2006,6,14)};
            

            Console.WriteLine($"Mssv: {manh.Mssv},Ten: {manh.Ten}, Tuoi: {manh.Tuoi}");

            manh.XinChao();
            SinhVien.DiHoc();

            Random rd = new Random();
            Console.WriteLine(rd.Next(1,7));*/


            //Tạo 1 menu chỉ dừng lại khi chọn 0: thực hiện các chức năng
            /*1. Nhập 1 số nguyên dương. Kiểm tra xem so nhập vào là
             * số chẵn hay lẻ
             *2.Tính tổng cac số chẵn từ 1 - số nguyên vừa nhập
              3.Nhập và chiều dài và chiều rộng của hcn in ra cv và diện tích
              4.Tính giai thừa của 1 số nguyên nhập vào n!;
              5. Nhập vào 1 số kiểm tra có phải số chính phương không
              6.Cho ngẫu nhiên 1 số từ (1-10), nhập vào 1 số nếu trùng thì chúc mừng
               ngược lại chúc bạn may mắn lần sau
              7. Viết hàm tính luỹ thừa
             */
            Console.OutputEncoding = Encoding.UTF8;

            int luachon;
            while (true)
            {
                Console.WriteLine("1. Nhập 1 số nguyên dương." +
                    " Kiểm tra xem so nhập vào là\r\n       " +
                    "       số chẵn hay lẻ\r\n           " +
                    "   2.Tính tổng cac số chẵn từ 1 - " +
                    "số nguyên vừa nhập\r\n            " +
                    "  3.Nhập và chiều dài và chiều rộng của hcn in ra cv và diện tích" +
                    "\r\n             " +
                    " 4.Tính giai thừa của 1 số nguyên nhập vào n!;" +
                    "\r\n              " +
                    "5. Nhập vào 1 số kiểm tra có phải số chính phương không\r\n " +
                    "             6.Cho ngẫu nhiên 1 số từ (1-10), nhập vào 1 số nếu trùng thì chúc mừng\r\n     " +
                    "          ngược lại chúc bạn may mắn lần sau\r\n        " +
                    "      7. Viết hàm tính luỹ thừa\r\n");
                Console.Write("Xin moi nhap lua chon: ");
                luachon = Convert.ToInt32(Console.ReadLine());

                switch (luachon)
                {
                    default:
                        Console.WriteLine("Chọn sai!");
                        break;
                    case 0: return;
                    case 1:
                        {
                            Console.Write("Xin mời nhập 1 số nguyên dương: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            if (n % 2 == 0) Console.WriteLine("Day la so chan");
                            else Console.WriteLine("Day la so le");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Xin mời nhập 1 số nguyên dương: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            int sum = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    sum += i;
                                }
                            }
                            Console.WriteLine($"Tong cac so chan tu 1 - {n} la {sum}");

                            break;
                        }
                    case 3:
                        {
                            double cd, cr;
                            Console.WriteLine("Xin moi nhap chieu dai:");
                            cd = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Xin moi nhap chieu rong:");
                            cr = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Chu vi:{(cd + cr) * 2}, Dien tich:{cd * cr}");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Xin mời nhập 1 số nguyên dương: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            int giaithua = 1;

                            for (int i = 1; i < n + 1; i++)
                            {
                                giaithua *= i;
                            }
                            Console.WriteLine("n!={0}", giaithua);

                            break;
                        }
                    case 5:
                        {
                            Console.Write("Xin mời nhập 1 số nguyên dương: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            //25 chinh phuong cua 5
                            
                            // 6.254231 =>double
                            // 6
                            //6.0 =>double


                            if(Math.Sqrt(n) == (int)Math.Sqrt(n))    
                            {
                                Console.WriteLine("Day la so chinh phuong");
                            }
                            else
                            {
                                Console.WriteLine("meo phai");
                            }

                            break;
                        }
                        case 6:
                        {
                            Random rd = new Random();
                            int ngaunhien = rd.Next(1,11);

                            Console.Write("Xin mời nhập 1 số nguyên dương: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            if(ngaunhien == n)
                                Console.WriteLine("Chuc mung  ban!");
                            else Console.WriteLine("Chuc ba may man lan sau");


                            break;
                        }
                        case 7:
                        {
                            int luythua = Luythua(2, 3);
                            Console.WriteLine($"2^3={luythua}");
                        break;
                        }
                }
            }

        }

        //Cú pháp viết hàm
        // |<quyền truy cập>| |<static>| <kiểu trả về> <Tên hàm>(|dsts|){}

        static int Luythua(int a, int b)
        {
            int tich = 1;
            for (int i = 0; i < b; i++)
            {
                tich *= a;
            }
            return tich;
        }

        private static int Cong2So(int a, int b)
        {
            Console.WriteLine($"Ket qua cua phep cong 2 so {a} + {b} là {a + b}");
            return a + b;
        }
    }


    //Tạo 1 menu chỉ dừng lại khi chọn 0: thực hiện các chức năng
    /*1. Nhập 1 số nguyên dương. Kiểm tra xem so nhập vào là
     * số chẵn hay lẻ
     *2.Tính tổng cac số chẵn từ 1 - số nguyên vừa nhập
      3.Nhập và chiều dài và chiều rộng của hcn in ra cv và diện tích
      4.Tính giai thừa của 1 số nguyên nhập vào n!;
      5. Nhập vào 1 số kiểm tra có phải số chính phương không
      6.Cho ngẫu nhiên 1 số từ (1-10), nhập vào 1 số nếu trùng thì chúc mừng
       ngược lại chúc bạn may mắn lần sau
      7. Viết hàm tính luỹ thừa
     */


}
