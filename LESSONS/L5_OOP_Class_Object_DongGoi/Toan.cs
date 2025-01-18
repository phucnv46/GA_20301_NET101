using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_OOP_Class_Object_DongGoi
{
    internal class Toan
    {
        public static double Tong(params double[] numbers) // params, cho phep truyen vao
                                                           // khong gioi han cac phan tu cung loai
        {
            double total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
        return total;
        }
    }
}
