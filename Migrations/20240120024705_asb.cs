using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ass_NET105.Migrations
{
    /// <inheritdoc />
    public partial class asb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chucVus",
                columns: table => new
                {
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVus", x => x.IDRole);
                });

            migrationBuilder.CreateTable(
                name: "hangSXs",
                columns: table => new
                {
                    IDHangSx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHangSX = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangSXs", x => x.IDHangSx);
                });

            migrationBuilder.CreateTable(
                name: "maus",
                columns: table => new
                {
                    IDMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mausac = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maus", x => x.IDMau);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.IdSP);
                });

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    IDSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeGiay = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.IDSize);
                });

            migrationBuilder.CreateTable(
                name: "theLoai",
                columns: table => new
                {
                    IDTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theLoai", x => x.IDTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "nguoiDungs",
                columns: table => new
                {
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    ChucVuIDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguoiDungs", x => x.IDUser);
                    table.ForeignKey(
                        name: "FK_nguoiDungs_chucVus_ChucVuIDRole",
                        column: x => x.ChucVuIDRole,
                        principalTable: "chucVus",
                        principalColumn: "IDRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamCTs",
                columns: table => new
                {
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSale = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IDHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaSale = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    SanPhamIdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MauIDMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeIDSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HangIDHangSx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheLoaiIDTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamCTs", x => x.IDSPCT);
                    table.ForeignKey(
                        name: "FK_sanPhamCTs_hangSXs_HangIDHangSx",
                        column: x => x.HangIDHangSx,
                        principalTable: "hangSXs",
                        principalColumn: "IDHangSx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamCTs_maus_MauIDMau",
                        column: x => x.MauIDMau,
                        principalTable: "maus",
                        principalColumn: "IDMau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamCTs_sanPhams_SanPhamIdSP",
                        column: x => x.SanPhamIdSP,
                        principalTable: "sanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamCTs_sizes_SizeIDSize",
                        column: x => x.SizeIDSize,
                        principalTable: "sizes",
                        principalColumn: "IDSize",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamCTs_theLoai_TheLoaiIDTheLoai",
                        column: x => x.TheLoaiIDTheLoai,
                        principalTable: "theLoai",
                        principalColumn: "IDTheLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangs",
                columns: table => new
                {
                    IDGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiDungIDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangs", x => x.IDGioHang);
                    table.ForeignKey(
                        name: "FK_gioHangs_nguoiDungs_NguoiDungIDUser",
                        column: x => x.NguoiDungIDUser,
                        principalTable: "nguoiDungs",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayShip = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NguoiDungIDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_hoaDons_nguoiDungs_NguoiDungIDUser",
                        column: x => x.NguoiDungIDUser,
                        principalTable: "nguoiDungs",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "binhLuans",
                columns: table => new
                {
                    IDBinhLuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SanPhamCTIDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NguoiDungIDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_binhLuans", x => x.IDBinhLuan);
                    table.ForeignKey(
                        name: "FK_binhLuans_nguoiDungs_NguoiDungIDUser",
                        column: x => x.NguoiDungIDUser,
                        principalTable: "nguoiDungs",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_binhLuans_sanPhamCTs_SanPhamCTIDSPCT",
                        column: x => x.SanPhamCTIDSPCT,
                        principalTable: "sanPhamCTs",
                        principalColumn: "IDSPCT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangCTs",
                columns: table => new
                {
                    IDGHCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GioHangIDGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamCTIDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangCTs", x => x.IDGHCT);
                    table.ForeignKey(
                        name: "FK_gioHangCTs_gioHangs_GioHangIDGioHang",
                        column: x => x.GioHangIDGioHang,
                        principalTable: "gioHangs",
                        principalColumn: "IDGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gioHangCTs_sanPhamCTs_SanPhamCTIDSPCT",
                        column: x => x.SanPhamCTIDSPCT,
                        principalTable: "sanPhamCTs",
                        principalColumn: "IDSPCT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDoncts",
                columns: table => new
                {
                    IDHDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    HoaDonIdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamctIDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDoncts", x => x.IDHDCT);
                    table.ForeignKey(
                        name: "FK_hoaDoncts_hoaDons_HoaDonIdBill",
                        column: x => x.HoaDonIdBill,
                        principalTable: "hoaDons",
                        principalColumn: "IdBill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDoncts_sanPhamCTs_SanPhamctIDSPCT",
                        column: x => x.SanPhamctIDSPCT,
                        principalTable: "sanPhamCTs",
                        principalColumn: "IDSPCT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_binhLuans_NguoiDungIDUser",
                table: "binhLuans",
                column: "NguoiDungIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_binhLuans_SanPhamCTIDSPCT",
                table: "binhLuans",
                column: "SanPhamCTIDSPCT");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangCTs_GioHangIDGioHang",
                table: "gioHangCTs",
                column: "GioHangIDGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangCTs_SanPhamCTIDSPCT",
                table: "gioHangCTs",
                column: "SanPhamCTIDSPCT");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_NguoiDungIDUser",
                table: "gioHangs",
                column: "NguoiDungIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDoncts_HoaDonIdBill",
                table: "hoaDoncts",
                column: "HoaDonIdBill");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDoncts_SanPhamctIDSPCT",
                table: "hoaDoncts",
                column: "SanPhamctIDSPCT");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NguoiDungIDUser",
                table: "hoaDons",
                column: "NguoiDungIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_nguoiDungs_ChucVuIDRole",
                table: "nguoiDungs",
                column: "ChucVuIDRole");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamCTs_HangIDHangSx",
                table: "sanPhamCTs",
                column: "HangIDHangSx");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamCTs_MauIDMau",
                table: "sanPhamCTs",
                column: "MauIDMau");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamCTs_SanPhamIdSP",
                table: "sanPhamCTs",
                column: "SanPhamIdSP");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamCTs_SizeIDSize",
                table: "sanPhamCTs",
                column: "SizeIDSize");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamCTs_TheLoaiIDTheLoai",
                table: "sanPhamCTs",
                column: "TheLoaiIDTheLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "binhLuans");

            migrationBuilder.DropTable(
                name: "gioHangCTs");

            migrationBuilder.DropTable(
                name: "hoaDoncts");

            migrationBuilder.DropTable(
                name: "gioHangs");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "sanPhamCTs");

            migrationBuilder.DropTable(
                name: "nguoiDungs");

            migrationBuilder.DropTable(
                name: "hangSXs");

            migrationBuilder.DropTable(
                name: "maus");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "theLoai");

            migrationBuilder.DropTable(
                name: "chucVus");
        }
    }
}
