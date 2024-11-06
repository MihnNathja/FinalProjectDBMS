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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace DBMSProject
{
    public partial class FDichVu : Form
    {
        int maTaiKhoanKhachHang;
        int maMayTinh;
        public FDichVu(int maTaiKhoanKhachHang, int maMayTinh)
        {
            InitializeComponent();
            this.maTaiKhoanKhachHang = maTaiKhoanKhachHang;
            this.maMayTinh = maMayTinh;
        }

        private void FDichVu_Load(object sender, EventArgs e)
        {
            ClassDichVuDAO clDVDAO = new ClassDichVuDAO();
            List<ClassDichVu> listdv = clDVDAO.TruyXuatDanhSachDichVu(CheckSelectedRadioButton().Name);
            addFlowLayoutPanel(listdv);
        }
        public void addFlowLayoutPanel(List<ClassDichVu> listdv)
        {
            flpnlDichVu.Controls.Clear();
            string imageFolderPath = System.IO.Path.Combine(Application.StartupPath, "images");
            foreach (var item in listdv)
            {
                UCDichVu uc = new UCDichVu();
                uc.LoadUCDichVu(item);

                switch (item.LoaiDichVu.Trim().ToLower())
                {
                    case "đồ ăn":
                        uc.ptbDichVu.Image = Image.FromFile(System.IO.Path.Combine(imageFolderPath, "food.png"));
                        break;
                    case "thức uống":
                        uc.ptbDichVu.Image = Image.FromFile(System.IO.Path.Combine(imageFolderPath, "drink.png"));
                        break;
                    case "thẻ cào":
                        uc.ptbDichVu.Image = Image.FromFile(System.IO.Path.Combine(imageFolderPath, "card.png"));
                        break;
                }
                uc.ptbDichVu.SizeMode = PictureBoxSizeMode.Zoom;
                flpnlDichVu.Controls.Add(uc);
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            FDichVu_Load(sender, e);
            txtTimKiem.Text = "";
        }
        private RadioButton CheckSelectedRadioButton()
        {
            if (DichVuDoAnView.Checked)
            {
                return DichVuDoAnView;
            }
            else if (DichVuThucUongView.Checked)
            {
                return DichVuThucUongView;
            }
            else
            {
                return DichVuTheCaoView;
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            ClassChiTietHoaDonDAO clCTHDDAO = new ClassChiTietHoaDonDAO();
            bool checkThemDichVu= true;
            foreach(UCDichVu uc in flpnlDichVu.Controls)
            {
                if (Convert.ToInt32(uc.nudSoLuong.Value) > 0)
                {
                    checkThemDichVu = clCTHDDAO.ThemDichVu_ChiTietHoaDon(maTaiKhoanKhachHang, maMayTinh, uc.Dichvu.MaDichVu, Convert.ToInt32(uc.nudSoLuong.Value));
                }
            }
            if (checkThemDichVu)
            {
                MessageBox.Show("Thêm dịch vụ thành công");
            }
            FDichVu_Load(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ClassDichVuDAO dichvuDao = new ClassDichVuDAO();
            List<ClassDichVu> listdv = dichvuDao.TimKiemDichVu(txtTimKiem.Text.Trim(), CheckSelectedRadioButton().Text);
            addFlowLayoutPanel(listdv);
        }
    }
}
