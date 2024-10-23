using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    public class ClassUuDai
    {
        int maUuDai;
        string tenUuDai;
        double giaTri;
        DateTime thoiGianBatDau;
        DateTime thoiGianKetThuc;
        string dieuKien;
        int soLuong;
        string tinhTrang;

        public ClassUuDai(int maUuDai, string tenUuDai, double giaTri, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string dieuKien, int soLuong, string tinhTrang)
        {
            this.maUuDai = maUuDai;
            this.tenUuDai = tenUuDai;
            this.giaTri = giaTri;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.dieuKien = dieuKien;
            this.soLuong = soLuong;
            this.tinhTrang = tinhTrang;
        }

        public int MaUuDai { get => maUuDai; set => maUuDai = value; }
        public string TenUuDai { get => tenUuDai; set => tenUuDai = value; }
        public double GiaTri { get => giaTri; set => giaTri = value; }
        public DateTime ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public string DieuKien { get => dieuKien; set => dieuKien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
