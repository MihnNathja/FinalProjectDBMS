using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    public class ClassMayTinh
    {
        private int maMayTinh;
        private int maKhachHang;
        private string tinhTrang;
        private TimeSpan thoiGianBatDau;
        private TimeSpan thoiGianDaDung;
        private TimeSpan thoiGianConLai;
        private String ghiChu;

        public ClassMayTinh(int maMayTinh, int maKhachHang, string tinhTrang, TimeSpan thoiGianBatDau, TimeSpan thoiGianDaDung, TimeSpan thoiGianConLai, string ghiChu)
        {
            this.MaMayTinh = maMayTinh;
            this.MaKhachHang = maKhachHang;
            this.TinhTrang = tinhTrang;
            this.ThoiGianBatDau = thoiGianBatDau;
            this.ThoiGianDaDung = thoiGianDaDung;
            this.ThoiGianConLai = thoiGianConLai;
            this.GhiChu = ghiChu;
        }

        public int MaMayTinh { get => maMayTinh; set => maMayTinh = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public TimeSpan ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public TimeSpan ThoiGianDaDung { get => thoiGianDaDung; set => thoiGianDaDung = value; }
        public TimeSpan ThoiGianConLai { get => thoiGianConLai; set => thoiGianConLai = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }

}
