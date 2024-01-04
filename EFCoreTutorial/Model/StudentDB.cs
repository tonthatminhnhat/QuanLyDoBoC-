using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EFCoreTutorial.Model
{
    public class StudentDB: DbContext
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine("F:", "student.db");
            var con = $"Data source={path}";
                optionsBuilder.UseSqlite(con);
            // để tạo csdl mở package manager console
            // gõ: add-migration init ( nếu lỗi sửa) và update-database
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Classroom c1 = new Classroom
            {
                Id = 1,
                Name = "CNTTK44H",
                Room = "Lab1",
                Teacher = "Hùng Dung",
            };
            Classroom c2 = new Classroom
            {
                Id = 2,
                Name = "CNTTK44B",
                Room = "Lab3",
                Teacher = "Hùng Dung2",
            };
            Classroom c3 = new Classroom
            {
                Id = 3,
                Name = "CNTTK44A",
                Room = "Lab2",
                Teacher = "Hùng Dung3",
            };
            Classroom c4 = new Classroom
            {
                Id = 4,
                Name = "CNTTK44L",
                Room = "Lab7",
                Teacher = "Hùng Dung7",
            };
            modelBuilder.Entity<Classroom>().HasData(c1, c2, c3, c4);
            // taoj ra 1 phien ban moi:add-migration seed_classroom vaf update-database
        }
    }
}
