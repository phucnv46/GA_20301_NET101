using L11_1_Assignment2_Support;

using System;
using System.Collections.Generic;

namespace L11_1_Assignment2_Support
{
    internal class Seeding
    {
        public static List<KhachHang> KhachHangs
        {
            get
            {
                return new List<KhachHang>()
                {
                    new KhachHang()
                    {
                        Id = 1,
                        Ten = "Nguyen Van Phuc",
                        GioiTinh = true,
                        NgaySinh = new DateTime(2006, 7, 7),
                        SDT = "0966456789",
                        SoCCCD = "01252145123645",
                        TaiKhoan = new TaiKhoan()
                        {
                            STK = "001",
                            SoDu = 5000,
                            TrangThai = true
                        }
                    },
                    new KhachHang()
                    {
                        Id = 2,
                        Ten = "Tran Thi Bich",
                        GioiTinh = false,
                        NgaySinh = new DateTime(1995, 5, 15),
                        SDT = "0987654321",
                        SoCCCD = "98765432101234",
                        TaiKhoan = new TaiKhoan()
                        {
                            STK = "002",
                            SoDu = 3000,
                            TrangThai = true
                        }
                    },
                    new KhachHang()
                    {
                        Id = 3,
                        Ten = "Le Van Tam",
                        GioiTinh = true,
                        NgaySinh = new DateTime(1988, 12, 20),
                        SDT = "0912345678",
                        SoCCCD = "12345678901234",
                        TaiKhoan = new TaiKhoan()
                        {
                            STK = "003",
                            SoDu = 10000,
                            TrangThai = false
                        }
                    }
                };
            }
        }

        public static List<TaiKhoanDangNhap> TaiKhoanDangNhaps
        {
            get
            {
                return new List<TaiKhoanDangNhap>()
                {
                    new TaiKhoanDangNhap()
                    {
                        Username = "user1",
                        Password = "pass1",
                        TaiKhoan = KhachHangs[0].TaiKhoan
                    },
                    new TaiKhoanDangNhap()
                    {
                        Username = "user2",
                        Password = "pass2",
                        TaiKhoan = KhachHangs[1].TaiKhoan
                    },
                    new TaiKhoanDangNhap()
                    {
                        Username = "user3",
                        Password = "pass3",
                        TaiKhoan = KhachHangs[2].TaiKhoan
                    }
                };
            }
        }

        public static List<GiaoDich> GiaoDichs
        {
            get
            {
                return new List<GiaoDich>()
                {
                    new GiaoDich()
                    {
                        TaiKhoanGui = KhachHangs[0].TaiKhoan,
                        TaiKhoanNhan = KhachHangs[1].TaiKhoan,
                        LoaiGiaoDich = LoaiGiaoDich.Gui
                    },
                    new GiaoDich()
                    {
                        TaiKhoanGui = KhachHangs[1].TaiKhoan,
                        TaiKhoanNhan = KhachHangs[2].TaiKhoan,
                        LoaiGiaoDich = LoaiGiaoDich.Gui
                    },
                    new GiaoDich()
                    {
                        TaiKhoanGui = KhachHangs[2].TaiKhoan,
                        TaiKhoanNhan = KhachHangs[0].TaiKhoan,
                        LoaiGiaoDich = LoaiGiaoDich.Gui
                    }
                };
            }
        }
    }
}
