using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace L11_1_Assignment2_Support
{
    internal class Logic
    {
        List<TaiKhoanDangNhap> tkdns = Seeding.TaiKhoanDangNhaps;
        List<KhachHang> khachHangs = Seeding.KhachHangs;
        List<GiaoDich> GiaoDiches = Seeding.GiaoDichs;

        TaiKhoan _taiKhoan;

        public void DangNhap()
        {

            string username;
            string password;
            bool isLogin = true;
            do
            {

                username = Console.ReadLine();
                password = Console.ReadLine();

                foreach (var tkdn in tkdns)
                {
                    if (tkdn.Username.Equals(username) && tkdn.Password.Equals(password))
                    {
                        isLogin = true;
                        _taiKhoan = tkdn.TaiKhoan;
                        break;

                    }
                }
            }
            while (isLogin == false);

        }

        private void Menu(TaiKhoan taiKhoan)
        {

        }

        private void ChuyenKhoan()
        {
            TaiKhoan taiKhoanNhan = null;
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            foreach (var tkdn in tkdns)
            {
                taiKhoans.Add(tkdn.TaiKhoan);
            }

            Console.WriteLine("Xin mời nhập số tài khoản");
            string stk = Console.ReadLine();

            if (stk == "000") return;

            foreach (var tk in taiKhoans)
            {
                if (tk.STK.Equals(stk))
                {
                    taiKhoanNhan = tk;
                    break;
                }
            }

            Console.WriteLine("Xin mời nhập số tiền cần chuyển");
            double stc = double.Parse(Console.ReadLine());

            if (stc <= 0)
            {
                Console.WriteLine("Không được chuyển nhỏ hơn 0");
                return;
            }

            if (stc > _taiKhoan.SoDu)
            {
                Console.WriteLine("So Dư hiện tại không đủ thực hiện giao dịch này");
                return;
            }

            

            if (taiKhoanNhan.TrangThai == false)
            {
                Console.WriteLine("...");
                return;
            }

            if (_taiKhoan.TrangThai == false)
            {
                Console.WriteLine("...");
                return;
            }

            _taiKhoan.SoDu -= stc;
            taiKhoanNhan.SoDu += stc;

            _taiKhoan.GiaoDiches.Add(new GiaoDich()
            { LoaiGiaoDich = LoaiGiaoDich.Gui, MaGiaoDich = "123",TaiKhoanGui = _taiKhoan, 
                TaiKhoanNhan= taiKhoanNhan });
            taiKhoanNhan.GiaoDiches.Add(new GiaoDich()

            {
                LoaiGiaoDich = LoaiGiaoDich.Nhan,
                MaGiaoDich = "123",
                TaiKhoanGui = _taiKhoan,
                TaiKhoanNhan = taiKhoanNhan
            });
        }

        private void InGiaoDich()
        {
            foreach (var gd in _taiKhoan.GiaoDiches)
            {
                gd.InThongTin();
               
            }
            Console.ResetColor();
        }

        private void SaoKe()
        {
            string fileName = $"SaoKe{_taiKhoan.STK}.txt";

            File.WriteAllText(fileName,JsonSerializer.Serialize(_taiKhoan.GiaoDiches));
        }
    }


    

}
