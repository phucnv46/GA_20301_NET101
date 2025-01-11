using System.Threading.Channels;

namespace L2_DieuKienVongLap
{
    internal class Program
    {

        // Toán tử logic: && => và
        /*
         logic bằng : ==
         lơn hơn : > 
         nhỏ hơn : < 
         khác : !=
         hoặc : ||
         lớn hơn hoặc bằng :  >=
         nhỏ hơn hoặc bằng :  <=
         là : is
         */
        // Cú pháp câu điều kiện:
        /*
         if(dk){ } 
         else if(dk khác){}
         */
        static void Main(string[] args)
        {
            int a = 1;

            // Dk ;
            if (a < 10)
            {
                Console.WriteLine("a nho hon 10");
            }

            else if (a < 20) // khi ma da co dk truoc day thoa man thi se khong thực hiện nữa
            {
                Console.WriteLine("a nho hon 20");
            }
            else if (a < 30)
            {
                Console.WriteLine("a nho hon 30");
            }
            else
            {
                Console.WriteLine("Ko thuoc trường hop nao");
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Câu lệnh rẽ nhánh

            for ( ; ; )
             // Kiem tra dieu kien truoc 
            {
                Console.Write("Xin mời nhập lựa chọn: ");
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1: Console.WriteLine("Trường hợp 1"); break;
                    case 2: Console.WriteLine("Trường hợp 2"); break;
                    case 3: Console.WriteLine("trường hợp 3"); break;
                    default:
                        Console.WriteLine("Chon sai!");
                        break;
                    case 4: return;
                }
            }

            
           


            // Vong lap : While, Do while, for, fore
        }
    }
}
