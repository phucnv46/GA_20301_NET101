namespace ChuaLab34
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<string> words = new List<string>() 
            { "Mạnh", "Hieu","Nam","Chien","Thu","Thuý"}
            ;

            Console.WriteLine("Xin mời nhập 1 kí tự: ");
            string key = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();

            string tuNhap = Console.ReadLine();

            foreach (string s in words)
            {
                if (s.StartsWith(key, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(s);
                }
                if(s.Equals(tuNhap, StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine(s);

                }

            }*/

            List<XeMay> xeMays = new List<XeMay>();
            
            XeMay xeMay = new XeMay();

            xeMay.InID();
        }
    }
}
