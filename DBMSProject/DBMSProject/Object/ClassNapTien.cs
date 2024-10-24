using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    public class ClassNapTien
    {
        private int maKhachHang;
        private DateTime thoiGianNapTien;
        private decimal giaTriNap;
        private TimeSpan thoiGianQuyDoi;
        private string ghiChu;

        public ClassNapTien() { }

        public ClassNapTien(int maKhachHang, DateTime thoiGianNapTien, decimal giaTriNap, TimeSpan thoiGianQuyDoi, string ghiChu)
        {
            this.MaKhachHang = maKhachHang;
            this.ThoiGianNapTien = thoiGianNapTien;
            this.GiaTriNap = giaTriNap;
            this.ThoiGianQuyDoi = thoiGianQuyDoi;
            this.GhiChu = ghiChu;
        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime ThoiGianNapTien { get => thoiGianNapTien; set => thoiGianNapTien = value; }
        public decimal GiaTriNap { get => giaTriNap; set => giaTriNap = value; }
        public TimeSpan ThoiGianQuyDoi { get => thoiGianQuyDoi; set => thoiGianQuyDoi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
