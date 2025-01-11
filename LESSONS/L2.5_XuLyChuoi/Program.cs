using System.Text;

namespace L2._5_XuLyChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string ten2; 
            Random rd = new Random(); 

            int xx1 = rd.Next(1,6); // random tu 1 den 6


            Console.WriteLine(xx1);

            ThayDoiTen(out ten2);
            Console.WriteLine(ten2);
        }

     static void ThayDoiTen(out string? ten)  // giong con tro nhung khong can khoi tao gia tri
        {
            ten = "Hùng";
        }

    }
}
