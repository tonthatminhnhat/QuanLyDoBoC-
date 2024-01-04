using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DDB { get; set; }
        public string? POB { get; set; }//noi sinh
        public long IdClassroom { get; set; }
    }
}
