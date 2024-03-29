﻿// <auto-generated />
using System;
using Ass_NET105.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ass_NET105.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240120024705_asb")]
    partial class asb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ass_NET105.Models.BinhLuan", b =>
                {
                    b.Property<Guid>("IDBinhLuan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBinh")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NguoiDungIDUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SanPhamCTIDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDBinhLuan");

                    b.HasIndex("NguoiDungIDUser");

                    b.HasIndex("SanPhamCTIDSPCT");

                    b.ToTable("binhLuans");
                });

            modelBuilder.Entity("Ass_NET105.Models.ChucVu", b =>
                {
                    b.Property<Guid>("IDRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IDRole");

                    b.ToTable("chucVus");
                });

            modelBuilder.Entity("Ass_NET105.Models.GioHang", b =>
                {
                    b.Property<Guid>("IDGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("NguoiDungIDUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDGioHang");

                    b.HasIndex("NguoiDungIDUser");

                    b.ToTable("gioHangs");
                });

            modelBuilder.Entity("Ass_NET105.Models.GioHangCT", b =>
                {
                    b.Property<Guid>("IDGHCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GioHangIDGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDGH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamCTIDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IDGHCT");

                    b.HasIndex("GioHangIDGioHang");

                    b.HasIndex("SanPhamCTIDSPCT");

                    b.ToTable("gioHangCTs");
                });

            modelBuilder.Entity("Ass_NET105.Models.HangSX", b =>
                {
                    b.Property<Guid>("IDHangSx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenHangSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDHangSx");

                    b.ToTable("hangSXs");
                });

            modelBuilder.Entity("Ass_NET105.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IdBill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiNguoiNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayShip")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NguoiDungIDUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SDTNguoiNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenNguoiNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TongThanhToan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdBill");

                    b.HasIndex("NguoiDungIDUser");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("Ass_NET105.Models.HoaDonCT", b =>
                {
                    b.Property<Guid>("IDHDCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("HoaDonIdBill")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamctIDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IDHDCT");

                    b.HasIndex("HoaDonIdBill");

                    b.HasIndex("SanPhamctIDSPCT");

                    b.ToTable("hoaDoncts");
                });

            modelBuilder.Entity("Ass_NET105.Models.MauSac", b =>
                {
                    b.Property<Guid>("IDMau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mausac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDMau");

                    b.ToTable("maus");
                });

            modelBuilder.Entity("Ass_NET105.Models.NguoiDung", b =>
                {
                    b.Property<Guid>("IDUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChucVuIDRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IDUser");

                    b.HasIndex("ChucVuIDRole");

                    b.ToTable("nguoiDungs");
                });

            modelBuilder.Entity("Ass_NET105.Models.SanPham", b =>
                {
                    b.Property<Guid>("IdSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSP");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("Ass_NET105.Models.SanPhamCT", b =>
                {
                    b.Property<Guid>("IDSPCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Anh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaSale")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("HangIDHangSx")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDMau")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDSale")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDTheLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MauIDMau")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SanPhamIdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SizeIDSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<Guid>("TheLoaiIDTheLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IDSPCT");

                    b.HasIndex("HangIDHangSx");

                    b.HasIndex("MauIDMau");

                    b.HasIndex("SanPhamIdSP");

                    b.HasIndex("SizeIDSize");

                    b.HasIndex("TheLoaiIDTheLoai");

                    b.ToTable("sanPhamCTs");
                });

            modelBuilder.Entity("Ass_NET105.Models.Size", b =>
                {
                    b.Property<Guid>("IDSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SizeGiay")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IDSize");

                    b.ToTable("sizes");
                });

            modelBuilder.Entity("Ass_NET105.Models.TheLoai", b =>
                {
                    b.Property<Guid>("IDTheLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDTheLoai");

                    b.ToTable("theLoai");
                });

            modelBuilder.Entity("Ass_NET105.Models.BinhLuan", b =>
                {
                    b.HasOne("Ass_NET105.Models.NguoiDung", "NguoiDung")
                        .WithMany("BinhLuans")
                        .HasForeignKey("NguoiDungIDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ass_NET105.Models.SanPhamCT", "SanPhamCT")
                        .WithMany("BinhLuans")
                        .HasForeignKey("SanPhamCTIDSPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");

                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("Ass_NET105.Models.GioHang", b =>
                {
                    b.HasOne("Ass_NET105.Models.NguoiDung", "NguoiDung")
                        .WithMany("GioHangs")
                        .HasForeignKey("NguoiDungIDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("Ass_NET105.Models.GioHangCT", b =>
                {
                    b.HasOne("Ass_NET105.Models.GioHang", "GioHang")
                        .WithMany("GioHangcts")
                        .HasForeignKey("GioHangIDGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ass_NET105.Models.SanPhamCT", "SanPhamCT")
                        .WithMany("GioHangCT")
                        .HasForeignKey("SanPhamCTIDSPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("Ass_NET105.Models.HoaDon", b =>
                {
                    b.HasOne("Ass_NET105.Models.NguoiDung", "NguoiDung")
                        .WithMany("HoaDons")
                        .HasForeignKey("NguoiDungIDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("Ass_NET105.Models.HoaDonCT", b =>
                {
                    b.HasOne("Ass_NET105.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("HoaDonIdBill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ass_NET105.Models.SanPhamCT", "SanPhamct")
                        .WithMany("HoaDonCT")
                        .HasForeignKey("SanPhamctIDSPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPhamct");
                });

            modelBuilder.Entity("Ass_NET105.Models.NguoiDung", b =>
                {
                    b.HasOne("Ass_NET105.Models.ChucVu", "ChucVu")
                        .WithMany("NguoiDung")
                        .HasForeignKey("ChucVuIDRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("Ass_NET105.Models.SanPhamCT", b =>
                {
                    b.HasOne("Ass_NET105.Models.HangSX", "Hang")
                        .WithMany("SanPhamCT")
                        .HasForeignKey("HangIDHangSx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ass_NET105.Models.MauSac", "Mau")
                        .WithMany("SanPhamct")
                        .HasForeignKey("MauIDMau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ass_NET105.Models.SanPham", "SanPham")
                        .WithMany("SanPhamCT")
                        .HasForeignKey("SanPhamIdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ass_NET105.Models.Size", "Size")
                        .WithMany("SanPhamct")
                        .HasForeignKey("SizeIDSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ass_NET105.Models.TheLoai", "TheLoai")
                        .WithMany("SanPhamct")
                        .HasForeignKey("TheLoaiIDTheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hang");

                    b.Navigation("Mau");

                    b.Navigation("SanPham");

                    b.Navigation("Size");

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("Ass_NET105.Models.ChucVu", b =>
                {
                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("Ass_NET105.Models.GioHang", b =>
                {
                    b.Navigation("GioHangcts");
                });

            modelBuilder.Entity("Ass_NET105.Models.HangSX", b =>
                {
                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("Ass_NET105.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("Ass_NET105.Models.MauSac", b =>
                {
                    b.Navigation("SanPhamct");
                });

            modelBuilder.Entity("Ass_NET105.Models.NguoiDung", b =>
                {
                    b.Navigation("BinhLuans");

                    b.Navigation("GioHangs");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("Ass_NET105.Models.SanPham", b =>
                {
                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("Ass_NET105.Models.SanPhamCT", b =>
                {
                    b.Navigation("BinhLuans");

                    b.Navigation("GioHangCT");

                    b.Navigation("HoaDonCT");
                });

            modelBuilder.Entity("Ass_NET105.Models.Size", b =>
                {
                    b.Navigation("SanPhamct");
                });

            modelBuilder.Entity("Ass_NET105.Models.TheLoai", b =>
                {
                    b.Navigation("SanPhamct");
                });
#pragma warning restore 612, 618
        }
    }
}
