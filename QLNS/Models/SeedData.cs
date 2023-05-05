using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLNS.Data;
using System;
using System.Linq;

namespace QLNS.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new QLNSContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<QLNSContext>>()))
        {
            // Look for any movies.
            if (context.NhanVien.Any())
            {
                return;   // DB has been seeded
            }
            context.NhanVien.AddRange(
                new NhanVien
                {
                    MaNV = "NV001",
                    TenNV = "Tran Thi B",
                    GioiTinh = "Nu",
                    NgaySinh = new System.DateTime(1998, 2, 2),
                    DiaChi = "Ho Chi Minh",
                    MaNganh = "Marketing",
                    MaBac = "Bac2",
                    HeSoLuong = 2.0,
                    PhuCap = 2000000,
                    MaChucVu = "CV2",
                    MaPB = "PB2"
                },
            new NhanVien
            {
                MaNV = "NV002",
                TenNV = "Nguyen Van A",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1995, 1, 1),
                DiaChi = "Ha Noi",
                MaNganh = "IT",
                MaBac = "Bac1",
                HeSoLuong = 1.5,
                PhuCap = 1000000,
                MaChucVu = "CV1",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV003",
                TenNV = "Tran Van D",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1993, 4, 15),
                DiaChi = "Da Nang",
                MaNganh = "Kinh doanh",
                MaBac = "Bac2",
                HeSoLuong = 2.5,
                PhuCap = 2500000,
                MaChucVu = "CV2",
                MaPB = "PB2"
            },
            new NhanVien
            {
                MaNV = "NV004",
                TenNV = "Nguyen Thi E",
                GioiTinh = "Nu",
                NgaySinh = new System.DateTime(1994, 3, 12),
                DiaChi = "Hai Phong",
                MaNganh = "IT",
                MaBac = "Bac1",
                HeSoLuong = 1.5,
                PhuCap = 1500000,
                MaChucVu = "CV1",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV005",
                TenNV = "Pham Van F",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1995, 2, 19),
                DiaChi = "Ha Noi",
                MaNganh = "Marketing",
                MaBac = "Bac2",
                HeSoLuong = 2.0,
                PhuCap = 2000000,
                MaChucVu = "CV2",
                MaPB = "PB3"
            },
            new NhanVien
            {
                MaNV = "NV006",
                TenNV = "Tran Thi G",
                GioiTinh = "Nu",
                NgaySinh = new System.DateTime(1996, 1, 25),
                DiaChi = "Ho Chi Minh",
                MaNganh = "Ke toan",
                MaBac = "Bac3",
                HeSoLuong = 3.0,
                PhuCap = 3000000,
                MaChucVu = "CV3",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV007",
                TenNV = "Le Van H",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1997, 2, 28),
                DiaChi = "Da Nang",
                MaNganh = "Kinh doanh",
                MaBac = "Bac2",
                HeSoLuong = 2.5,
                PhuCap = 2500000,
                MaChucVu = "CV2",
                MaPB = "PB2"
            },

            new NhanVien
            {
                MaNV = "NV009",
                TenNV = "Nguyen Van I",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1994, 5, 15),
                DiaChi = "Da Nang",
                MaNganh = "Sales",
                MaBac = "Bac2",
                HeSoLuong = 2.2,
                PhuCap = 2200000,
                MaChucVu = "CV2",
                MaPB = "PB3"
            },
            new NhanVien
            {
                MaNV = "NV010",
                TenNV = "Tran Van J",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1992, 9, 25),
                DiaChi = "Ha Noi",
                MaNganh = "IT",
                MaBac = "Bac3",
                HeSoLuong = 3.0,
                PhuCap = 3000000,
                MaChucVu = "CV3",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV015",
                TenNV = "Tran Thi O",
                GioiTinh = "Nu",
                NgaySinh = new System.DateTime(1999, 12, 3),
                DiaChi = "Can Tho",
                MaNganh = "Marketing",
                MaBac = "Bac1",
                HeSoLuong = 1.8,
                PhuCap = 1800000,
                MaChucVu = "CV1",
                MaPB = "PB2"
            }
            );
            context.SaveChanges();
        }
    }
}