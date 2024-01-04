using QuanLyDoBo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoBo.DTO
{
    public class SanPhamDTO
    {
        public int idsp { get; set; }

        public string masp { get; set; }

        public string namesp { get; set; }

        public string idkieumau { get; set; }

        public int gia { get; set; }

        public int sale { get; set; }

        public bool hethang { get; set; }

        public string loaivai { get; set; }

        public string anhdaidien { get; set; }

    }
}
