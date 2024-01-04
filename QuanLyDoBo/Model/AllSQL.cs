using Microsoft.EntityFrameworkCore;
using QuanLyDoBo.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyDoBo.Model
{
    public class AllSQL
    {
        public bool InsertSP(string idkieumau, int gia, string namesp, int sale, string loaivai, string anhdaidien)
        {
            SanPhamDB db = new SanPhamDB();
            SanPham sanpham = new SanPham();
            sanpham.masp = "0";
            sanpham.idkieumau = idkieumau;
            sanpham.gia = gia;
            sanpham.namesp = namesp;
            sanpham.sale = sale;
            sanpham.loaivai = loaivai;
            sanpham.anhdaidien = anhdaidien;
            sanpham.hethang = true;
            db.SanPhams.Add(sanpham);
            var numChanges = db.SaveChanges();
            return numChanges > 0;
        }
        public bool UpdateMaSP()
        {
            SanPhamDB db = new SanPhamDB();
            string updateMaspQuery = $"UPDATE SanPham SET masp = CAST(idsp AS TEXT)||idkieumau WHERE masp = '0'";
            int check = db.Database.ExecuteSqlRaw(updateMaspQuery);
            if (check > 0) return true;
            return false;

        }
        public bool DeleteSP(string masp)
        {
            SanPhamDB db = new SanPhamDB();
            var sanPhamToDelete = db.SanPhams.FirstOrDefault(sp => sp.masp == masp);
            if (sanPhamToDelete != null)
            {
                db.SanPhams.Remove(sanPhamToDelete);
                int numChanges = db.SaveChanges();
                if (numChanges > 0) return true;
            }
            return false;
        }
        public bool UpdateSP(string masp, int gia, string namesp, int sale, string loaivai, string anhdaidien)
        {
            SanPhamDB db = new SanPhamDB();
            var sanpham = db.SanPhams.SingleOrDefault(sp => sp.masp == masp);
            if (sanpham!=null){          
            sanpham.gia = gia;
            sanpham.namesp = namesp;
            sanpham.sale = sale;
            sanpham.loaivai = loaivai;
            sanpham.anhdaidien = anhdaidien;
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public bool UpdateHetHangSP(string masp, bool hethang)
        {
            SanPhamDB db = new SanPhamDB();
            var sp = db.SanPhams.SingleOrDefault(sp => sp.masp == masp);
            if (sp != null)
            {
                sp.hethang = hethang;
                return db.SaveChanges() > 0;
            }
            return false;
        }
    /////// xử lý của ảnh
        public bool UpdateMaAnh()
        {
            SanPhamDB db = new SanPhamDB();
            string updateMaspQuery = $"UPDATE Anh SET maanh = masp||CAST(idanh AS TEXT) WHERE maanh = '0'";
            if (db.Database.ExecuteSqlRaw(updateMaspQuery)>0) return true;
            return false;
        }
        public bool UpdateAnh(string maanh, string mau, string path)
        {
            SanPhamDB db = new SanPhamDB();
            var anh = db.Anhs.SingleOrDefault(a => a.maanh == maanh);
            if (anh != null)
            {
                anh.mau = mau;
                anh.path = path;
                return db.SaveChanges()>0;
            }
            return false;
        }
        public bool InsertAnh(string masp, string mau, string path)
        {
            SanPhamDB db = new SanPhamDB();
            Anh a = new Anh();
            a.maanh = "0";
            a.masp = masp;
            a.mau = mau;
            a.path = path;
            a.hethang = true;
            db.Anhs.Add(a);
            return db.SaveChanges() > 0;
        }
        public bool DeleteAnh(string maanh)
        {
            SanPhamDB db = new SanPhamDB();
            var Anh = db.Anhs.FirstOrDefault(a => a.maanh == maanh);
            if (Anh != null)
            {
                db.Anhs.Remove(Anh);
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public bool UpdateHetHangAnh(string maanh, bool hethang)
        {
            SanPhamDB db = new SanPhamDB();
            var anh = db.Anhs.SingleOrDefault(a => a.maanh == maanh);
            if (anh != null)
            {
                anh.hethang = hethang;
                return db.SaveChanges() > 0;
            }
            return false;
        }
        // xử lý size
        public bool UpdateMaSize()
        {
            SanPhamDB db = new SanPhamDB();
            string updateMaspQuery = $"UPDATE Size SET masize = maanh||size WHERE masize = '0'";
            if (db.Database.ExecuteSqlRaw(updateMaspQuery) > 0) return true;
            return false;
        }
        public bool InsertSize(string maanh, string masp, string size)
        {
            SanPhamDB db = new SanPhamDB();
            Size a = new Size();
            a.masize = "0";
            a.maanh = maanh;
            a.masp = masp;
            a.size = size;
            a.soluong = 0;
            db.Sizes.Add(a);
            if (db.SaveChanges() > 0)
            {
                if (UpdateMaSize()) return true;
            }
            return false;
        }
        public bool UpdateSoLuong(string masize, int soluong)
        {
            SanPhamDB db = new SanPhamDB();
            var size = db.Sizes.SingleOrDefault(s => s.masize == masize);
            if (size != null)
            {
                size.soluong = soluong;
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public bool Delete5Size(string maanh)
        {
            SanPhamDB db = new SanPhamDB(); 
                var sizes = db.Sizes.Where(s => s.maanh == maanh).ToList();
                db.Sizes.RemoveRange(sizes);

                return db.SaveChanges()>0;
        }
        public bool DeleteAllSize(string masp)
        {

            return false;
        }
    }
}
