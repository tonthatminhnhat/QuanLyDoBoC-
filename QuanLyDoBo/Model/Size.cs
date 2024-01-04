using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDoBo.Model
{
    [Table("Size")]
    public class Size
    {
        [Key]
        public int idsize { get; set; }

        [StringLength(10)]
        public string? masize { get; set; }

        [StringLength(7)]
        public String maanh { get; set; }

        [StringLength(5)]
        public string? masp { get; set; }

        [StringLength(4)]
        public string size { get; set; }

        public int soluong { get; set; }

        public virtual Anh Anh { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
