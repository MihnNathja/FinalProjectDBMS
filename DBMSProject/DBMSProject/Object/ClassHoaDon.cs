using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    internal class ClassHoaDon
    {
        int maHoaDon;
        DateTime thoiGianTao;
        string trangThai;
        string tenTaiKhoan;
        decimal triGia;

      
        public ClassHoaDon(int maHoaDon, DateTime thoiGianTao, string trangThai, string tenTaiKhoan, decimal triGia)
        {
            MaHoaDon = maHoaDon;
            ThoiGianTao = thoiGianTao;
            TrangThai = trangThai;
            TenTaiKhoan = tenTaiKhoan;
            TriGia = triGia;
            
        }

        public int MaHoaDon { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public string TrangThai { get; set; }
        public decimal TriGia { get; set; }
        public string TenTaiKhoan { get ; set; }
    }
}
