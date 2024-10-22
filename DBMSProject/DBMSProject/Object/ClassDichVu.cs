using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    public class ClassDichVu
    {
        int maDichVu;
        string tenDichVu;
        string loaiDichVu;
        double donGia;
        int soLuong;

        public ClassDichVu(int maDichVu, string tenDichVu, string loaiDichVu, double donGia, int soLuong)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.loaiDichVu = loaiDichVu;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public string LoaiDichVu { get => loaiDichVu; set => loaiDichVu = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
