using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    internal class ClassPhienDangNhap
    {
        int maKhachHang;
        int maMayTinh;
        TimeSpan thoiGianBatDau ;
        TimeSpan thoiGianSuDung;
        TimeSpan thoiGianConLai;

        public ClassPhienDangNhap(int maKhachHang, int maMayTinh, TimeSpan thoiGianBatDau, TimeSpan thoiGianSuDung, TimeSpan thoiGianConLai)
        {
            this.maKhachHang = maKhachHang;
            this.maMayTinh = maMayTinh;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianSuDung = thoiGianSuDung;
            this.thoiGianConLai = thoiGianConLai;
        }
        public ClassPhienDangNhap()
        {

        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int MaMayTinh { get => maMayTinh; set => maMayTinh = value; }
        public TimeSpan ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public TimeSpan ThoiGianSuDung { get => thoiGianSuDung; set => thoiGianSuDung = value; }
        public TimeSpan ThoiGianConLai { get => thoiGianConLai; set => thoiGianConLai = value; }
    }
}
