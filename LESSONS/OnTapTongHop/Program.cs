namespace OnTapTongHop
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Khai bao mang: <Kieu du kieu>[] <tenmang> = {...khai bao cac phan tu}
            // Khoi tao mang voi new <Kieu du kieu>[] <tenmang> = new [kich thuoc mang]

            int[] soNguyens = { 1, 3, 4, 12, 2 }; // so luong cac phan tu se la kich thuoc mang
            int[] soNguyens2 = new int[12]; // xac dinh kich thuoc mang tu dau 

            // Truy cap mang: 1 phan tu thi su dung index, index luon bat dau tu 0;
            soNguyens[2] = 5;

            //Truy cap toan bo mang: co the dung 2 cach for/ foreach

            for (int i = 0; i < soNguyens.Length; i++)
            {
                Console.WriteLine(soNguyens[i]); // su dung index
            }

            // foreach
            foreach (var soNguyen in soNguyens) // duyet moi phan tu trong mang
            {
                Console.Write(soNguyen); 
            }

            // Mang dac biet khong gioi han so luong phan
            // Cu phap List<KDL> <tenDanhSach> = new List<KDL>(){... khoi tao phan tu}

            List<double> doubles = new ();
            // truy cap danh sach thi truy cap nhu mang
            
            //1 so thuoc tinh cua list
           int slpt = doubles.Count; // so luong phan tu trong list
            // Add
            //Remove(objects)
            //RemoveAt(index)
            //Insert(vtc, objects)
            // Sort : sap xep mang
            //OrderBy(), OrderByDescending()
            
            // Dictionary<Key,Value> ...

         

        }
    }
}
