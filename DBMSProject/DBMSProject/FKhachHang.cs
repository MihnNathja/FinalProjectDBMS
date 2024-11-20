using DBMSProject.Object;
using DBMSProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using System.Data.SqlClient;

namespace DBMSProject
{
    public partial class FKhachHang : Form
    {
        public SqlTableDependency<ClassPhienDangNhap> phiendangnhap_table_dependency;
        //string connStrAdmin = "Data Source=26.221.50.203;Initial Catalog=QuanLyDichVuQuanNet;Persist Security Info=True;User ID=sqlDependency;Password=sqlDependency;";
        string connStrAdmin = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QuanLyDichVuQuanNet;Persist Security Info=True;User ID=sqlDependency;Password=sqlDependency;";
        int maKhachHang;
        int maTaiKhoanKhachHang;
        string conn;
        ClassPhienDangNhap classPhienDangNhap = new ClassPhienDangNhap();
        ClassPhienDangNhapDAO classPhienDangNhapDAO;
        ClassTaiKhoanDAO tkDAO;

        private Timer timer;
        private int timeLoad;

        int maMayTinh = 1;
        public FKhachHang(int maTaiKhoan, string connStr)
        {
            InitializeComponent();
            conn = connStr;
            classPhienDangNhapDAO = new ClassPhienDangNhapDAO(conn);
            tkDAO = new ClassTaiKhoanDAO(conn);
            ClassKhachHangDAO classKhachHangDAO = new ClassKhachHangDAO(conn);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            this.maTaiKhoanKhachHang = maTaiKhoan;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timeLoad = 0;
            timer.Start();
            txtThoiGianSuDung.Text = "0:00:00";


            maKhachHang = tkDAO.ChuyenDoiMaTaiKhoanSangMaKhachHang(maTaiKhoan);

            classPhienDangNhap = classPhienDangNhapDAO.LapPhienDangNhap(maKhachHang);
            string tenTaiKhoan = classPhienDangNhapDAO.getTenTaiKhoan(maTaiKhoan);
            lblUserName.Text = tenTaiKhoan;
            TimeSpan thoiGianBatDau = classPhienDangNhap.ThoiGianBatDau;
            txtThoiGianBatDau.Text = thoiGianBatDau.ToString(@"hh\:mm\:ss");
            TimeSpan thoiGianConLai = classPhienDangNhap.ThoiGianConLai;
            txtThoiGianConLai.Text = thoiGianConLai.ToString(@"hh\:mm\:ss");
            txtDanhHieu.Text = classKhachHangDAO.GetDanhHieuKhachHang(maKhachHang);

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLoad++;

            classPhienDangNhap.ThoiGianSuDung = TimeSpan.FromSeconds(timeLoad);
            txtThoiGianSuDung.Text = classPhienDangNhap.ThoiGianSuDung.ToString(@"hh\:mm\:ss");
            if (classPhienDangNhap.ThoiGianConLai.TotalSeconds > 0)
            {
                classPhienDangNhap.ThoiGianConLai = classPhienDangNhap.ThoiGianConLai.Subtract(TimeSpan.FromSeconds(1));
                txtThoiGianConLai.Text = classPhienDangNhap.ThoiGianConLai.ToString(@"hh\:mm\:ss");
            }
            else
            {
                
                timer.Stop();
                MessageBox.Show("Thời gian còn lại đã hết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        

        private void KhachHang_Load(object sender, EventArgs e)
        {
            refresh();
            start_phiendangnhap_table_dependency();
        }

        private void FKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                stop_phiendangnhap_table_dependency();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            FDichVu dv = new FDichVu(maTaiKhoanKhachHang, maMayTinh, conn);
            dv.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FDoiMatKhau fDoiMatKhau = new FDoiMatKhau(maTaiKhoanKhachHang, conn);
            fDoiMatKhau.ShowDialog();
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            int maKhachHang = tkDAO.ChuyenDoiMaTaiKhoanSangMaKhachHang(maTaiKhoanKhachHang);
            classPhienDangNhapDAO.XoaPhienDangNhap(maKhachHang, classPhienDangNhap.ThoiGianConLai);
            
            this.Close();
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            FThanhToanHoaDon fThanhToanHoaDon = new FThanhToanHoaDon(maTaiKhoanKhachHang, conn);
            if (fThanhToanHoaDon.HoaDonTonTai)
            {
                fThanhToanHoaDon.ShowDialog();
            }
        }
        private bool start_phiendangnhap_table_dependency()
        {
            try
            {
                phiendangnhap_table_dependency = new SqlTableDependency<ClassPhienDangNhap>(connStrAdmin, "PhienDangNhap");
                phiendangnhap_table_dependency.OnChanged += phiendangnhap_table_dependency_Changed;
                phiendangnhap_table_dependency.OnError += phiendangnhap_table_dependency_OnError;
                phiendangnhap_table_dependency.Start();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }
            

        }
        private bool stop_phiendangnhap_table_dependency()
        {
            try
            {
                if (phiendangnhap_table_dependency != null)
                {
                    phiendangnhap_table_dependency.Stop();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;

        }
        private void phiendangnhap_table_dependency_OnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Error.Message.ToString());
        }
        private void phiendangnhap_table_dependency_Changed(object sender, RecordChangedEventArgs<ClassPhienDangNhap> e)
        {
            try
            {
                if (e.ChangeType != ChangeType.None)
                {
                    refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void refresh()
        {
            LoadThoiGianConLai();
        }
        private void LoadThoiGianConLai()
        {
            string sql = "SELECT thoiGianConLai FROM PhienDangNhap WHERE maKhachHang = @maKhachHang";
            using (SqlConnection connection = new SqlConnection(connStrAdmin))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@maKhachHang", maKhachHang);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Lấy giá trị thoiGianConLai mới từ cơ sở dữ liệu
                        TimeSpan newThoiGianConLai = (TimeSpan)reader["thoiGianConLai"];

                        // Trừ đi thời gian đã sử dụng
                        TimeSpan adjustedThoiGianConLai = newThoiGianConLai.Subtract(classPhienDangNhap.ThoiGianSuDung);

                        // Kiểm tra nếu thoiGianConLai sau khi điều chỉnh thay đổi
                        if (adjustedThoiGianConLai != classPhienDangNhap.ThoiGianConLai)
                        {
                            classPhienDangNhap.ThoiGianConLai = adjustedThoiGianConLai;

                            // Cập nhật giao diện và hiển thị thông báo
                            ThreadSafe(() =>
                            {
                                txtThoiGianConLai.Text = classPhienDangNhap.ThoiGianConLai.ToString(@"hh\:mm\:ss");
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void ThreadSafe(MethodInvoker method)
        {
            try
            {
                if (InvokeRequired)
                    Invoke(method);
                else
                    method();
            }
            catch (ObjectDisposedException) { }
        }
    }
}
