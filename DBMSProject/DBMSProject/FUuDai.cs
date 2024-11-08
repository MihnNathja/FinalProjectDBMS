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
    public partial class FUuDai : Form
    {
        ClassHoaDon HoaDon;
        string conn;
        public FUuDai(ClassHoaDon hoadon, string connStr)
        {
            InitializeComponent();
            HoaDon = hoadon;
            conn = connStr;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ClassUuDaiDAO uudaiDao = new ClassUuDaiDAO(conn);
            List<ClassUuDai> listUD = uudaiDao.TimKiemUuDai(txtTimKiem.Text.Trim());
            addFlowLayoutPanel(listUD);
        }

        private void FUuDai_Load(object sender, EventArgs e)
        {
            ClassUuDaiDAO uudaiDao = new ClassUuDaiDAO(conn);
            List<ClassUuDai> listUD = uudaiDao.TruyXuatDanhSachUuDai();
            addFlowLayoutPanel(listUD);
        }
        public void addFlowLayoutPanel(List<ClassUuDai> listUD)
        {
            flpnlUuDai.Controls.Clear();
            foreach (var item in listUD)
            {
                UCUuDai uc = new UCUuDai(HoaDon, conn);
                uc.LoadUCUuDai(item);
                flpnlUuDai.Controls.Add(uc);
            }
        }
    }
}
