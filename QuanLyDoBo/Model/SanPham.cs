using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDoBo.Model
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [Column("idsp")]
        public int idsp { get; set; }

        [StringLength(5)]
        public string? masp { get; set; }

        [StringLength(100)]
        public string namesp { get; set; }

        [StringLength(2)]
        public string idkieumau { get; set; }

        public int gia { get; set; }

        public int sale { get; set; }

        public bool hethang { get; set; }

        [StringLength(15)]
        public string loaivai { get; set; }

        [StringLength(100)]
        public string anhdaidien { get; set; }

        [ForeignKey("idkieumau")]
        public virtual KieuMau KieuMau { get; set; }

        public virtual List<Size> Sizes { get; set; }
        public virtual List<Anh> Anhs { get; set; }
    }
}

