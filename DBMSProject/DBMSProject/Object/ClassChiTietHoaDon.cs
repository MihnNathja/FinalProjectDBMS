using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    internal class ClassChiTietHoaDon
    {
        int maHoaDon;
        DateTime thoiGianTao;
        int maMayTinh;
        string tenDichVu;
        string taiKhoan;
        int soLuong;
        decimal tongGiaTien;
        decimal triGia;
        string trangThai;

        
        public ClassChiTietHoaDon(int maHoaDon, int maMayTinh, DateTime thoiGianTao, string tenDichVu, string taiKhoan, int soLuong, decimal tongGiaTien, decimal triGia, string trangThai) 
        {
            this.maHoaDon = maHoaDon;
            this.maMayTinh = maMayTinh;
            this.thoiGianTao = thoiGianTao;
            this.tenDichVu = tenDichVu;
            this.taiKhoan = taiKhoan;
            this.soLuong = soLuong;
            this.tongGiaTien = tongGiaTien;
            this.triGia = triGia;
            this.trangThai = trangThai;
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime ThoiGianTao { get => thoiGianTao; set => thoiGianTao = value; }
        public int MaMayTinh { get => maMayTinh; set => maMayTinh = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal TongGiaTien { get => tongGiaTien; set => tongGiaTien = value; }
        public decimal TriGia { get => triGia; set => triGia = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
