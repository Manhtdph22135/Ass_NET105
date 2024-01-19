using Ass_NET105.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ass_NET105.DBContext
{
    public class Context : DbContext
    {

        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<SanPhamCT> sanPhamCTs { get; set; }
        public DbSet<MauSac> maus { get; set; }
        public DbSet<HangSX> hangSXs { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<TheLoai> theLoai { get; set; }
        public DbSet<BinhLuan> binhLuans { get; set; }
        public DbSet<GioHang> gioHangs { get; set; }
        public DbSet<GioHangCT> gioHangCTs { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<HoaDonCT> hoaDoncts { get; set; }
        public DbSet<NguoiDung> nguoiDungs { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=WINDOWS-10;Initial Catalog=DuAn_Net1051;trusted_connection=true");
            optionsBuilder.UseSqlServer(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=Asm_net05;Integrated Security=True;Encrypt=False"); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
    }
}
