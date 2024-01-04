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
    [Table("Anh")]
    public class Anh
    {
        [Key]
        public int idanh { get; set; }

        [StringLength(5)]
        public string masp { get; set; }

        [StringLength(25)]
        public string mau { get; set; }

        [StringLength(100)]
        public string path { get; set; }

        [StringLength(7)]
        public string maanh { get; set; }

        public bool hethang { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual List<Size> Sizes { get; set; }
    }
}
