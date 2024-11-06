using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    public class ClassHoaDon
    {
        int maHoaDon;
        DateTime thoiGianTao;
        int maKhachHang;
        int maMayTinh;
        string trangThai;
        decimal triGia;
        int? maUuDai;

      
        public ClassHoaDon()
        {

        }
        public ClassHoaDon(int maHoaDon,  int maKhachHang,  int maMayTinh, DateTime thoiGianTao, string trangThai, decimal triGia, int? maUuDai)
        {
            this.maHoaDon = maHoaDon;
            this.thoiGianTao = thoiGianTao;
            this.maKhachHang = maKhachHang;
            this.maMayTinh = maMayTinh;
            this.trangThai = trangThai;
            this.triGia = triGia;
            this.maUuDai = maUuDai;
            
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime ThoiGianTao { get => thoiGianTao; set => thoiGianTao = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int MaMayTinh { get => maMayTinh; set => maMayTinh = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public decimal TriGia { get => triGia; set => triGia = value; }
        public int? MaUuDai { get => maUuDai; set => maUuDai = value; }
    }
}
