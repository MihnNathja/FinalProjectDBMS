﻿using DBMSProject.DAO;
using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class FChiTietHoaDon : Form
    {
        ClassChiTietHoaDonDAO chiTietHoaDonDAO = new ClassChiTietHoaDonDAO();
        ClassChiTietHoaDon chiTietHoaDon;
        
        List<ClassChiTietHoaDon> danhSachChiTietHoaDon;
        public FChiTietHoaDon()
        {
            InitializeComponent();
        }
        public FChiTietHoaDon(int maHoaDon)
        {
            InitializeComponent();
            LoadChiTietHoaDon(maHoaDon);
        }

        public bool HideButton { get; set; } = false;
        private void FChiTietHoaDon_Load(object sender, EventArgs e)
        {
            if (HideButton == true)
            {
                btnXuatHoaDon.Visible = false;
            }
        }
        public void LoadChiTietHoaDon(int maHoaDon)
        {
            ClassHoaDon classHoaDon = chiTietHoaDonDAO.LayHoaDon(maHoaDon);
            
            lblMaHoaDon.Text = classHoaDon.MaHoaDon.ToString();
            lblMaMayTinh.Text = classHoaDon.MaMayTinh.ToString();
            lblNgayTao.Text = classHoaDon.ThoiGianTao.ToString();
            lblTenTaiKhoan.Text = classHoaDon.MaKhachHang.ToString();
            lblTriGia.Text = classHoaDon.TriGia.ToString() + "VNĐ";


            dgvDichVuDaGoi.DataSource = chiTietHoaDonDAO.LayChiTietHoaDon(maHoaDon);


        }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {

            int maHoaDon = Convert.ToInt32(lblMaHoaDon.Text);  
            string ngayTao = lblNgayTao.Text;              
            string tenTaiKhoan = lblTenTaiKhoan.Text;         
            string maMayTinh = lblMaMayTinh.Text;          
            string triGia = lblTriGia.Text;
            XuatHoaDonRaFileTxt(maHoaDon, ngayTao, tenTaiKhoan, maMayTinh, dgvDichVuDaGoi, triGia);
        }
        public void XuatHoaDonRaFileTxt(int maHoaDon, string ngayTao, string tenTaiKhoan, string maMayTinh, DataGridView dataGridView, string triGia)
        {

            string filePath = Path.Combine("C:/VUONG_LAP_QUE/Nam 3/HK I/DBMS/project/FinalProjectDBMS/DBMSProject/DBMSProject/HoaDon", $"HoaDon_{maHoaDon}.txt");
            if (File.Exists(filePath))
            {
            
                MessageBox.Show($"Hóa đơn với mã {maHoaDon} đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

                using (StreamWriter writer = new StreamWriter(filePath))
            {
       
                writer.WriteLine("CHI TIẾT HÓA ĐƠN");
                writer.WriteLine("Mã hóa đơn: " + maHoaDon);
                writer.WriteLine("Ngày tạo: " + ngayTao);
                writer.WriteLine("Tài khoản: " + tenTaiKhoan);
                writer.WriteLine("Mã máy tính: " + maMayTinh);
                writer.WriteLine("------------------------------------------------");

                writer.WriteLine("DỊCH VỤ ĐÃ GỌI:");
                writer.WriteLine(String.Format("{0,-20} {1,-10} {2,-10}", "Tên Dịch Vụ", "Số Lượng", "Tổng Giá Tiền"));

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string tenDichVu = row.Cells["TenDichVu"].Value.ToString();
                        string soLuong = row.Cells["SoLuong"].Value.ToString();
                        string tongGiaTien = row.Cells["TongGiaTien"].Value.ToString();

                        writer.WriteLine(String.Format("{0,-20} {1,-10} {2,-10}", tenDichVu, soLuong, tongGiaTien));
                    }
                }
                writer.WriteLine("------------------------------------------------");
                writer.WriteLine("TỔNG TRỊ GIÁ HÓA ĐƠN: " + triGia + "VNĐ");
                writer.WriteLine("------------------------------------------------");
                writer.WriteLine("Cảm ơn quý khách đã sử dụng dịch vụ!");

                writer.Close();
            }

            MessageBox.Show("Hóa đơn đã được xuất ra file: ");
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }
    }
}
