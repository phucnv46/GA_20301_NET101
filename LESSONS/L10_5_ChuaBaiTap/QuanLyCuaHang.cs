using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_5_ChuaBaiTap
{
    internal class QuanLyCuaHang : IQuanLy
    {
        List<CuaHang> cuaHangs = new List<CuaHang>();
        public void HienThiDanhSach()
        {
              
        }

        public void Them()
        {
        }

        public object Tim()
        {
            string id = Console.ReadLine();
            foreach (var cuaHang in cuaHangs)
            {
                if (cuaHang.ID.Equals(id,StringComparison.OrdinalIgnoreCase))
                {
                    return cuaHang;
                }
            }
            return null;
        }

        public void Xoa()
        {
        }
    }
}
