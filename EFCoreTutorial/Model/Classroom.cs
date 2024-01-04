using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.Model
{
    [Table("Classroom")]
    public class Classroom

    {
        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string? Room { get; set; }
        [StringLength(50)]
        public string? Teacher { get; set; }
        public virtual List<Student> Students { get; set; }


    }
}
