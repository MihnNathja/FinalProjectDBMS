using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    public class ClassKhachHang
    {
        private int maKhachHang;
        private string taiKhoan;
        private TimeSpan thoiGianConLai;
        private string loaiKhachHang;
        private int diemTichLuy;

        public ClassKhachHang(int maKhachHang, string taiKhoan, TimeSpan thoiGianConLai, string loaiKhachHang, int diemTichLuy)
        {
            this.MaKhachHang = maKhachHang;
            this.TaiKhoan = taiKhoan;
            this.ThoiGianConLai = thoiGianConLai;
            this.LoaiKhachHang = loaiKhachHang;
            this.DiemTichLuy = diemTichLuy;
        }

        public int MaKhachHang
        {
            get => maKhachHang;
            set => maKhachHang = value;
        }

        public string TaiKhoan
        {
            get => taiKhoan;
            set => taiKhoan = value;
        }

        public TimeSpan ThoiGianConLai
        {
            get => thoiGianConLai;
            set => thoiGianConLai = value;
        }

        public string LoaiKhachHang
        {
            get => loaiKhachHang;
            set => loaiKhachHang = value;
        }

        public int DiemTichLuy
        {
            get => diemTichLuy;
            set => diemTichLuy = value;
        }
    }
}
