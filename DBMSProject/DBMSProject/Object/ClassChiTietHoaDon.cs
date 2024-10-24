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
        int maDichVu;
        int soLuong;
        decimal tongGiaTien;

        public ClassChiTietHoaDon()
        {

        }
        public ClassChiTietHoaDon(int maHoaDon, int maDichVu, int soLuong, decimal tongGiaTien) 
        {
            this.maHoaDon = maHoaDon;
            this.maDichVu = maDichVu;
            this.soLuong = soLuong;
            this.tongGiaTien = tongGiaTien;
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal TongGiaTien { get => tongGiaTien; set => tongGiaTien = value; }
    }
}
