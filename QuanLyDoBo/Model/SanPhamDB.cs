using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoBo.Model
{
    public class SanPhamDB : DbContext
    {
        public DbSet<Anh> Anhs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<KieuMau> KieuMaus { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var dbPath = Path.Combine(basePath, "sanpham.db");
            var connectionString = $"Data Source={dbPath}";
            optionsBuilder.UseSqlite(connectionString);
        }
        // Add-Migration <TênMigration>Update-Database


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anh>()
                .HasIndex(a => a.maanh)
                .IsUnique();

            modelBuilder.Entity<SanPham>()
                .HasIndex(sp => sp.masp)
                .IsUnique(false);

            modelBuilder.Entity<Size>()
                .HasIndex(s => s.masize)
                .IsUnique();

            modelBuilder.Entity<Size>()
    .HasOne(s => s.SanPham)
    .WithMany(sp => sp.Sizes)
    .HasForeignKey(s => s.masp)
    .HasPrincipalKey(sp => sp.masp).IsRequired(false);
           

            modelBuilder.Entity<Size>()
     .HasOne(s => s.Anh)
     .WithMany(a => a.Sizes)
     .HasForeignKey(s => s.maanh)
     .HasPrincipalKey(a => a.maanh).IsRequired(false);

            modelBuilder.Entity<Anh>()
      .HasOne(a => a.SanPham)
      .WithMany(sp => sp.Anhs)
      .HasForeignKey(a => a.masp)
      .HasPrincipalKey(sp => sp.masp).IsRequired(false);

        }       
    }
}
