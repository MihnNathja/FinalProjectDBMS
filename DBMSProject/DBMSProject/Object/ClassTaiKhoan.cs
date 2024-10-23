using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Object
{
    internal class ClassTaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public ClassTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
        }
        public ClassTaiKhoan()
        {
            this.TenTaiKhoan = "";
            this.MatKhau = "";
        }


    }
}
