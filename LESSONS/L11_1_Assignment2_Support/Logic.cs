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
        List<KhachHang> khachHangs;


        public Logic()
        {   
            khachHangs = Seeding.KhachHangs;
        }


        TaiKhoan _taiKhoan; // Để lưu thông tin tài khoản khi đăng nhập thành công

        public void DangNhap()
        {

           
            string username;
            string password;
            bool isLogin = false;
            do
            {
                Console.Write("Xin mời nhập tên đăng nhập: ");
                username = Console.ReadLine();
                Console.Write("Xin mời nhập mật khẩu: ");
                password = Console.ReadLine();

                foreach (var tkdn in tkdns)
                {
                    if (tkdn.Username.Equals(username) && tkdn.Password.Equals(password))
                    {
                        isLogin = true;
                        _taiKhoan = tkdn.TaiKhoan; // Tài khoản đăng nhập chứa
                        Menu(); // Khi đăng nhập thành công in ra  giao diện bên trong
                        break;

                    }

                }
                if (isLogin == false)
                {
                    Console.WriteLine("Có lỗi trong quá trình đăng nhập");
                }

            }
            while (isLogin == false);

        }

        private void Menu()
        {
            int luaChon;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Hiển thị Thông tin Tài Khoản (SoTaiKhoan,TenKhachHang,SoDu, TrangThai)" +
                "\r\n2. Hiển Thị Thông Tin chủ tài khoản" +
                "\r\n3. Chuyển khoản đến số tài khoản khác ( Nhập số tài khoản, hiện tên chủ tài khoản, rồi mời cho nhập số tiền, nếu không tìm thấy thì thông báo và bắt nhập lại , nhập stk là 000 để thoát ra menu, nếu không đủ tiền, hoặc tài khoản bị khoá, hoặc tài nhận bị khoá thì phải thông báo và không thực hiện được giao dịch)" +
                "\r\n4. Hiển thị danh sách GiaoDich của tài khoản \r\n5. Sao kê (In danh sách Giao Dịch vào file SaoKe+[SoTaiKhoan].txt) ( sử dụng File.WriteAllText)" +
                "\r\n6.Đăng xuất (trở lại màn hình đăng nhập)");
                Console.Write("Xin mời nhập lựa chọn: ");

                int.TryParse(Console.ReadLine(), out luaChon);

                switch (luaChon)
                {
                    default:
                        Console.WriteLine("Lựa chọn sai");
                        break;
                    case 1: HienThiThongTinTaiKhoan(); break;
                    case 2: HienThiThongTinChuTaiKhoan(); break;
                    case 3: ChuyenKhoan(); break;
                    case 4: InGiaoDich(); break;
                    case 5: SaoKe(); break;
                    case 6:
                        Console.WriteLine("Đăng xuất thành công");
                        DangNhap();
                        return;
                    
                }
            }
        }


        private void HienThiThongTinTaiKhoan()
        {
            Console.WriteLine($"STK: {_taiKhoan.STK}, Số dư: {_taiKhoan.SoDu}, " +
                $"Chủ tài khoản: {_taiKhoan.ChuTaiKhoan.Ten},Trạng thái :{(_taiKhoan.TrangThai ? "Mở" : "Khoá")}");

        }

        private void HienThiThongTinChuTaiKhoan()
        {
            _taiKhoan.ChuTaiKhoan.InThongTin();
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
            {
                LoaiGiaoDich = LoaiGiaoDich.Gui,
                TaiKhoanGui = _taiKhoan,
                TaiKhoanNhan = taiKhoanNhan,
                SoTien = stc,
                
            });
            taiKhoanNhan.GiaoDiches.Add(new GiaoDich()

            {
                LoaiGiaoDich = LoaiGiaoDich.Nhan,
                TaiKhoanGui = _taiKhoan,
                TaiKhoanNhan = taiKhoanNhan,
                SoTien=stc,
            });
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Chuyển khoản thành công");

            Console.ResetColor();
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
            string fileName = $"../../../SaoKe{_taiKhoan.STK}.txt";

             using(StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var giaoDich in _taiKhoan.GiaoDiches)
                {
                    writer.WriteLine($"Mã Giao Dịch:{giaoDich.MaGiaoDich}, Loại giao dịch" +
                        $" {giaoDich.LoaiGiaoDich}, Người nhận:{giaoDich.TaiKhoanNhan.STK}, Số tiền: {giaoDich.SoTien}");
                }
            }
        }
    }




}
