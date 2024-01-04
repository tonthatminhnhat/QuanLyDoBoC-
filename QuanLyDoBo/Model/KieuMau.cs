using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoBo.Model
{
    [Table("KieuMau")]
    public class KieuMau
    {
        [Key]
        [StringLength(2)]
        public string idkieumau { get; set; }

        [StringLength(15)]
        public string tenmau { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }
    }
}
