using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _20T1020493
{
        public class Sach
        {
            public string MaSach { get; set; } 
            public string TenSach { get; set; } 
            public int NamXuatBan { get; set; } 
            public string NhaSanXuat { get; set; }
            public double GiaNhap { get; set; } 
            public double GiaBan { get; set; } 
            public int SoLuongNhap { get; set; }
            public string HinhDaiDien { get; set; }
          public Sach() { } 
            public Sach(string maSach, string tenSach, int namXuatBan, string nhaSanXuat, double giaNhap, double giaBan, int soLuongNhap, string hinhDaiDien)
            {
                MaSach = maSach;
                TenSach = tenSach;
                NamXuatBan = namXuatBan;
                NhaSanXuat = nhaSanXuat;
                GiaNhap = giaNhap;
                GiaBan = giaBan;
                SoLuongNhap = soLuongNhap;
                HinhDaiDien = hinhDaiDien;
            }
            public override string ToString()
            { 
           /* var json = JsonSerializer.Serialize(this);*/
            return JsonConvert.SerializeObject(this, Formatting.Indented); 
            }
            public static Sach FromJson(string Json)
        {
               /*var obj = JsonSerializer.Deserialize<Sach>(Json);*/
            return JsonConvert.DeserializeObject<Sach>(Json); ;
        }
        }
    }

