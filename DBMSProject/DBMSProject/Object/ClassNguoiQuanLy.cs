using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    internal class ClassNguoiQuanLy
    {
        int maNguoiQuanLy;
        int maTaiKhoan;

        public ClassNguoiQuanLy(int maNguoiQuanLy, int maTaiKhoan)
        {
            this.maNguoiQuanLy = maNguoiQuanLy;
            this.maTaiKhoan = maTaiKhoan;
        }
        public ClassNguoiQuanLy()
        {

        }

        public int MaNguoiQuanLy { get => maNguoiQuanLy; set => maNguoiQuanLy = value; }
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
    }
}
