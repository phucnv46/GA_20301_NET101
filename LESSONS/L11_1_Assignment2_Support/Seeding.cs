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
                        Id = 0,
                        Ten = "Le Duc Manh",
                        GioiTinh = true,
                        NgaySinh = new DateTime(2006, 6, 14),
                        SDT = "0946286256",
                        SoCCCD = "0613165132161",



                    },
                    new KhachHang()
                    {
                        Id = 1,
                        Ten = "Nguyen Thanh Tung",
                        GioiTinh = true,
                        NgaySinh = new DateTime(2006, 6, 14),
                        SDT = "0122345678",
                        SoCCCD = "21655613",


                    },
                    new KhachHang()
                    {
                        Id = 2,
                        Ten = "Nguyen Ngoc Tu",
                        GioiTinh = true,
                        NgaySinh = new DateTime(2006, 6, 14),
                        SDT = "79654956544654",
                        SoCCCD = "4461891616",


                    },
                };
            }
        }
        public static List<TaiKhoan> TaiKhoans = new List<TaiKhoan>
    {
        new TaiKhoan { STK = "001", SoDu = 5000000, TrangThai = true, ChuTaiKhoan = KhachHangs[0] },
        new TaiKhoan { STK = "002", SoDu = 3000000, TrangThai = true, ChuTaiKhoan = KhachHangs[1] },
        new TaiKhoan {STK = "003", SoDu = 4000000, TrangThai = true, ChuTaiKhoan = KhachHangs[2]}
    };

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
                        TaiKhoan = TaiKhoans[0],
                    },
                    new TaiKhoanDangNhap()
                    {
                        Username = "user2",
                        Password = "pass2",
                        TaiKhoan = TaiKhoans[1]
                    },
                    new TaiKhoanDangNhap()
                    {
                        Username = "user3",
                        Password = "pass3",
                        TaiKhoan = TaiKhoans[2]
                    }
                };
            }


        }
    }
}
