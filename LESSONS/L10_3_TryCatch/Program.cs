namespace L10_3_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = CheckInt("Xin mời nhập số nguyên:", int.MinValue, int.MaxValue);

            // Viết cho mình 1 hàm bắt người dùng nhập số, nếu sai thông báo bắt nhập lại
        }

        public static int CheckInt(string mess, int min, int max) // Kiểm tra đầu vào của 1 chuỗi có phải số nguyên không
        {
            while (true)
            {
                int result = 0;
            intput: Console.Write(mess);
                string input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(input)) // nếu nhập vào trống
                    {
                        Console.WriteLine("Nhập vào trống");
                        goto intput;
                    }
                    result = Convert.ToInt32(input);
                    if (result < min || result > max) // Kiểm soát cận trên, cận dưới
                    {
                        Console.WriteLine("Số nhập vào phải nhỏ hơn {0} và lớn hơn {1}", max, min);
                        goto intput;
                    }

                    return result;



                }
                catch (Exception e)
                {
                    Console.WriteLine("Xảy ra lỗi {0}", e.Message);

                }
            }

        }
    }
}
