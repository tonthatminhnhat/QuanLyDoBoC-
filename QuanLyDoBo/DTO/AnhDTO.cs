using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoBo.DTO
{
    public class AnhDTO
    {
        public int idanh { get; set; }

        public string masp { get; set; }

        public string mau { get; set; }

        public string path { get; set; }

        public string maanh { get; set; }

        public bool hethang { get; set; }

    }
}
