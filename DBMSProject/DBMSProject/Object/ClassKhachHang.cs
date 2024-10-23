using DBMSProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    public class ClassKhachHang
    {
        int maKhachHang;
        int maTaiKhoan;
        TimeSpan thoiGianConLai;
        string loaiKhachHang;
        int diemTichLuy;

        public ClassKhachHang(int maKhachHang, int maTaiKhoan, TimeSpan thoiGianConLai, string loaiKhachHang, int diemTichLuy)
        {
            this.maKhachHang = maKhachHang;
            this.maTaiKhoan = maTaiKhoan;
            this.thoiGianConLai = thoiGianConLai;
            this.loaiKhachHang = loaiKhachHang;
            this.diemTichLuy = diemTichLuy;
        }
        public ClassKhachHang()
        {

        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public TimeSpan ThoiGianConLai { get => thoiGianConLai; set => thoiGianConLai = value; }
        public string LoaiKhachHang { get => loaiKhachHang; set => loaiKhachHang = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
    }
}
