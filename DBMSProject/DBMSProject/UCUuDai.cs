using DBMSProject.DAO;
using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class UCUuDai : UserControl
    {
        string conn;
        public UCUuDai(ClassHoaDon HoaDon, string connStr)
        {
            InitializeComponent();
            this.HoaDon = HoaDon;
            conn = connStr;
        }

        private void UCUuDai_Load(object sender, EventArgs e)
        {

        }
        ClassUuDai UuDai = new ClassUuDai();
        ClassHoaDon HoaDon = new ClassHoaDon();
        public void LoadUCUuDai(ClassUuDai uuDai)
        {
            lblTenUuDai.Text = uuDai.TenUuDai;
            lblDieuKien.Text = uuDai.DieuKien;
            lblSoLuong.Text = uuDai.SoLuong.ToString();
            this.UuDai = uuDai;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            ClassHoaDonDAO clHDDAO = new ClassHoaDonDAO(conn);
            clHDDAO.ThemUuDai_HoaDon(HoaDon.MaHoaDon, UuDai.MaUuDai);
            
        }
    }
}
