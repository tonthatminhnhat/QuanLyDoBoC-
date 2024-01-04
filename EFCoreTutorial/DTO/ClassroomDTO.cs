using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.DTO
{
    public class ClassroomDTO
    {
        public long Id { get;set; }
        public string Name { get;set; } 
        public int AmountStudent {  get;set; }  
        public string Display
        {
            get { 
                return $"{Name}-SLSV: {AmountStudent}"; 
                }
        }
        // cachs 2 overi Tostring 
    }
}
