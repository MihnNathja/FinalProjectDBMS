namespace DBMSProject
{
    partial class FManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectMenuscript = new System.Windows.Forms.TabControl();
            this.QuanLyThanhVienTab = new System.Windows.Forms.TabPage();
            this.UserFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ĐangKyThanhVienTab = new System.Windows.Forms.TabPage();
            this.ChBHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txbRe_password = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuanLyMayTab = new System.Windows.Forms.TabPage();
            this.computerFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.QuanLyGoiDichVuTab = new System.Windows.Forms.TabPage();
            this.ThanhToanTab = new System.Windows.Forms.TabControl();
            this.ChuaThanhToanTab = new System.Windows.Forms.TabPage();
            this.ChuaThanhToanDtg = new System.Windows.Forms.DataGridView();
            this.DaThanhToanTab = new System.Windows.Forms.TabPage();
            this.DaThanhToanDtg = new System.Windows.Forms.DataGridView();
            this.QuanLyUuDaiTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaUuDai = new System.Windows.Forms.Button();
            this.btnThemUuDai = new System.Windows.Forms.Button();
            this.ThoatTab = new System.Windows.Forms.TabPage();
            this.SelectMenuscript.SuspendLayout();
            this.QuanLyThanhVienTab.SuspendLayout();
            this.ĐangKyThanhVienTab.SuspendLayout();
            this.QuanLyMayTab.SuspendLayout();
            this.QuanLyGoiDichVuTab.SuspendLayout();
            this.ThanhToanTab.SuspendLayout();
            this.ChuaThanhToanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChuaThanhToanDtg)).BeginInit();
            this.DaThanhToanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaThanhToanDtg)).BeginInit();
            this.QuanLyUuDaiTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectMenuscript
            // 
            this.SelectMenuscript.Controls.Add(this.QuanLyThanhVienTab);
            this.SelectMenuscript.Controls.Add(this.ĐangKyThanhVienTab);
            this.SelectMenuscript.Controls.Add(this.QuanLyMayTab);
            this.SelectMenuscript.Controls.Add(this.QuanLyGoiDichVuTab);
            this.SelectMenuscript.Controls.Add(this.QuanLyUuDaiTab);
            this.SelectMenuscript.Controls.Add(this.ThoatTab);
            this.SelectMenuscript.Location = new System.Drawing.Point(0, 2);
            this.SelectMenuscript.Name = "SelectMenuscript";
            this.SelectMenuscript.SelectedIndex = 0;
            this.SelectMenuscript.Size = new System.Drawing.Size(1082, 517);
            this.SelectMenuscript.TabIndex = 0;
            this.SelectMenuscript.Tag = "";
            // 
            // QuanLyThanhVienTab
            // 
            this.QuanLyThanhVienTab.Controls.Add(this.UserFlp);
            this.QuanLyThanhVienTab.Controls.Add(this.btnSearch);
            this.QuanLyThanhVienTab.Controls.Add(this.txbSearch);
            this.QuanLyThanhVienTab.Controls.Add(this.label1);
            this.QuanLyThanhVienTab.Location = new System.Drawing.Point(4, 25);
            this.QuanLyThanhVienTab.Name = "QuanLyThanhVienTab";
            this.QuanLyThanhVienTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyThanhVienTab.Size = new System.Drawing.Size(1074, 488);
            this.QuanLyThanhVienTab.TabIndex = 0;
            this.QuanLyThanhVienTab.Text = "Quản lý thành viên";
            this.QuanLyThanhVienTab.UseVisualStyleBackColor = true;
            // 
            // UserFlp
            // 
            this.UserFlp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserFlp.AutoScroll = true;
            this.UserFlp.Location = new System.Drawing.Point(12, 63);
            this.UserFlp.Name = "UserFlp";
            this.UserFlp.Size = new System.Drawing.Size(1055, 417);
            this.UserFlp.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(12, 35);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(328, 22);
            this.txbSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm thành viên";
            // 
            // ĐangKyThanhVienTab
            // 
            this.ĐangKyThanhVienTab.Controls.Add(this.ChBHienThiMatKhau);
            this.ĐangKyThanhVienTab.Controls.Add(this.btnThoat);
            this.ĐangKyThanhVienTab.Controls.Add(this.btnDangKy);
            this.ĐangKyThanhVienTab.Controls.Add(this.txbRe_password);
            this.ĐangKyThanhVienTab.Controls.Add(this.txbPassword);
            this.ĐangKyThanhVienTab.Controls.Add(this.txbUsername);
            this.ĐangKyThanhVienTab.Controls.Add(this.label5);
            this.ĐangKyThanhVienTab.Controls.Add(this.label4);
            this.ĐangKyThanhVienTab.Controls.Add(this.label3);
            this.ĐangKyThanhVienTab.Controls.Add(this.label2);
            this.ĐangKyThanhVienTab.Location = new System.Drawing.Point(4, 25);
            this.ĐangKyThanhVienTab.Name = "ĐangKyThanhVienTab";
            this.ĐangKyThanhVienTab.Padding = new System.Windows.Forms.Padding(3);
            this.ĐangKyThanhVienTab.Size = new System.Drawing.Size(1074, 488);
            this.ĐangKyThanhVienTab.TabIndex = 1;
            this.ĐangKyThanhVienTab.Text = "Đăng ký thành viên";
            this.ĐangKyThanhVienTab.UseVisualStyleBackColor = true;
            // 
            // ChBHienThiMatKhau
            // 
            this.ChBHienThiMatKhau.AutoSize = true;
            this.ChBHienThiMatKhau.Location = new System.Drawing.Point(813, 159);
            this.ChBHienThiMatKhau.Name = "ChBHienThiMatKhau";
            this.ChBHienThiMatKhau.Size = new System.Drawing.Size(130, 20);
            this.ChBHienThiMatKhau.TabIndex = 11;
            this.ChBHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.ChBHienThiMatKhau.UseVisualStyleBackColor = true;
            this.ChBHienThiMatKhau.CheckedChanged += new System.EventHandler(this.ChBHienThiMatKhau_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(616, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 31);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Cyan;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(469, 310);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(108, 31);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txbRe_password
            // 
            this.txbRe_password.Location = new System.Drawing.Point(441, 220);
            this.txbRe_password.Name = "txbRe_password";
            this.txbRe_password.Size = new System.Drawing.Size(331, 22);
            this.txbRe_password.TabIndex = 6;
            this.txbRe_password.UseSystemPasswordChar = true;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(441, 157);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(331, 22);
            this.txbPassword.TabIndex = 5;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(441, 99);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(331, 22);
            this.txbUsername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhập lại mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thêm thành viên";
            // 
            // QuanLyMayTab
            // 
            this.QuanLyMayTab.Controls.Add(this.computerFlp);
            this.QuanLyMayTab.Location = new System.Drawing.Point(4, 25);
            this.QuanLyMayTab.Name = "QuanLyMayTab";
            this.QuanLyMayTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyMayTab.Size = new System.Drawing.Size(1074, 488);
            this.QuanLyMayTab.TabIndex = 2;
            this.QuanLyMayTab.Text = "Quản lý máy";
            this.QuanLyMayTab.UseVisualStyleBackColor = true;
            // 
            // computerFlp
            // 
            this.computerFlp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.computerFlp.AutoScroll = true;
            this.computerFlp.Location = new System.Drawing.Point(6, 6);
            this.computerFlp.Name = "computerFlp";
            this.computerFlp.Size = new System.Drawing.Size(1062, 476);
            this.computerFlp.TabIndex = 4;
            // 
            // QuanLyGoiDichVuTab
            // 
            this.QuanLyGoiDichVuTab.Controls.Add(this.ThanhToanTab);
            this.QuanLyGoiDichVuTab.Location = new System.Drawing.Point(4, 25);
            this.QuanLyGoiDichVuTab.Name = "QuanLyGoiDichVuTab";
            this.QuanLyGoiDichVuTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyGoiDichVuTab.Size = new System.Drawing.Size(1074, 488);
            this.QuanLyGoiDichVuTab.TabIndex = 3;
            this.QuanLyGoiDichVuTab.Text = "Quản lý gọi dịch vụ";
            this.QuanLyGoiDichVuTab.UseVisualStyleBackColor = true;
            // 
            // ThanhToanTab
            // 
            this.ThanhToanTab.Controls.Add(this.ChuaThanhToanTab);
            this.ThanhToanTab.Controls.Add(this.DaThanhToanTab);
            this.ThanhToanTab.Location = new System.Drawing.Point(0, 7);
            this.ThanhToanTab.Name = "ThanhToanTab";
            this.ThanhToanTab.SelectedIndex = 0;
            this.ThanhToanTab.Size = new System.Drawing.Size(1074, 485);
            this.ThanhToanTab.TabIndex = 0;
            // 
            // ChuaThanhToanTab
            // 
            this.ChuaThanhToanTab.Controls.Add(this.ChuaThanhToanDtg);
            this.ChuaThanhToanTab.Location = new System.Drawing.Point(4, 25);
            this.ChuaThanhToanTab.Name = "ChuaThanhToanTab";
            this.ChuaThanhToanTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChuaThanhToanTab.Size = new System.Drawing.Size(1066, 456);
            this.ChuaThanhToanTab.TabIndex = 0;
            this.ChuaThanhToanTab.Text = "Chưa thanh toán";
            this.ChuaThanhToanTab.UseVisualStyleBackColor = true;
            // 
            // ChuaThanhToanDtg
            // 
            this.ChuaThanhToanDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChuaThanhToanDtg.Location = new System.Drawing.Point(6, 7);
            this.ChuaThanhToanDtg.Name = "ChuaThanhToanDtg";
            this.ChuaThanhToanDtg.RowHeadersWidth = 51;
            this.ChuaThanhToanDtg.RowTemplate.Height = 24;
            this.ChuaThanhToanDtg.Size = new System.Drawing.Size(760, 440);
            this.ChuaThanhToanDtg.TabIndex = 1;
            // 
            // DaThanhToanTab
            // 
            this.DaThanhToanTab.Controls.Add(this.DaThanhToanDtg);
            this.DaThanhToanTab.Location = new System.Drawing.Point(4, 25);
            this.DaThanhToanTab.Name = "DaThanhToanTab";
            this.DaThanhToanTab.Padding = new System.Windows.Forms.Padding(3);
            this.DaThanhToanTab.Size = new System.Drawing.Size(1066, 456);
            this.DaThanhToanTab.TabIndex = 1;
            this.DaThanhToanTab.Text = "Đã thanh toán";
            this.DaThanhToanTab.UseVisualStyleBackColor = true;
            // 
            // DaThanhToanDtg
            // 
            this.DaThanhToanDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaThanhToanDtg.Location = new System.Drawing.Point(6, 7);
            this.DaThanhToanDtg.Name = "DaThanhToanDtg";
            this.DaThanhToanDtg.RowHeadersWidth = 51;
            this.DaThanhToanDtg.RowTemplate.Height = 24;
            this.DaThanhToanDtg.Size = new System.Drawing.Size(760, 440);
            this.DaThanhToanDtg.TabIndex = 2;
            // 
            // QuanLyUuDaiTab
            // 
            this.QuanLyUuDaiTab.Controls.Add(this.panel2);
            this.QuanLyUuDaiTab.Controls.Add(this.panel1);
            this.QuanLyUuDaiTab.Location = new System.Drawing.Point(4, 25);
            this.QuanLyUuDaiTab.Name = "QuanLyUuDaiTab";
            this.QuanLyUuDaiTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyUuDaiTab.Size = new System.Drawing.Size(1074, 488);
            this.QuanLyUuDaiTab.TabIndex = 4;
            this.QuanLyUuDaiTab.Text = "Quản lý ưu đãi";
            this.QuanLyUuDaiTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 388);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaUuDai);
            this.panel1.Controls.Add(this.btnThemUuDai);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnXoaUuDai
            // 
            this.btnXoaUuDai.Location = new System.Drawing.Point(466, 22);
            this.btnXoaUuDai.Name = "btnXoaUuDai";
            this.btnXoaUuDai.Size = new System.Drawing.Size(132, 41);
            this.btnXoaUuDai.TabIndex = 1;
            this.btnXoaUuDai.Text = "Xóa ưu đãi";
            this.btnXoaUuDai.UseVisualStyleBackColor = true;
            // 
            // btnThemUuDai
            // 
            this.btnThemUuDai.Location = new System.Drawing.Point(294, 21);
            this.btnThemUuDai.Name = "btnThemUuDai";
            this.btnThemUuDai.Size = new System.Drawing.Size(132, 41);
            this.btnThemUuDai.TabIndex = 0;
            this.btnThemUuDai.Text = "Thêm ưu đãi";
            this.btnThemUuDai.UseVisualStyleBackColor = true;
            // 
            // ThoatTab
            // 
            this.ThoatTab.Location = new System.Drawing.Point(4, 25);
            this.ThoatTab.Name = "ThoatTab";
            this.ThoatTab.Padding = new System.Windows.Forms.Padding(3);
            this.ThoatTab.Size = new System.Drawing.Size(1074, 488);
            this.ThoatTab.TabIndex = 5;
            this.ThoatTab.Text = "Quay lại trang chủ";
            this.ThoatTab.UseVisualStyleBackColor = true;
            this.ThoatTab.Enter += new System.EventHandler(this.ThoatTab_Enter);
            // 
            // FManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 519);
            this.Controls.Add(this.SelectMenuscript);
            this.Name = "FManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.FManHinhChinh_Load);
            this.SelectMenuscript.ResumeLayout(false);
            this.QuanLyThanhVienTab.ResumeLayout(false);
            this.QuanLyThanhVienTab.PerformLayout();
            this.ĐangKyThanhVienTab.ResumeLayout(false);
            this.ĐangKyThanhVienTab.PerformLayout();
            this.QuanLyMayTab.ResumeLayout(false);
            this.QuanLyGoiDichVuTab.ResumeLayout(false);
            this.ThanhToanTab.ResumeLayout(false);
            this.ChuaThanhToanTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChuaThanhToanDtg)).EndInit();
            this.DaThanhToanTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaThanhToanDtg)).EndInit();
            this.QuanLyUuDaiTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SelectMenuscript;
        private System.Windows.Forms.TabPage QuanLyThanhVienTab;
        private System.Windows.Forms.TabPage ĐangKyThanhVienTab;
        private System.Windows.Forms.TabPage QuanLyMayTab;
        private System.Windows.Forms.TabPage QuanLyGoiDichVuTab;
        private System.Windows.Forms.TabPage QuanLyUuDaiTab;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel UserFlp;
        private System.Windows.Forms.TabPage ThoatTab;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRe_password;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.FlowLayoutPanel computerFlp;
        private System.Windows.Forms.TabControl ThanhToanTab;
        private System.Windows.Forms.TabPage ChuaThanhToanTab;
        private System.Windows.Forms.TabPage DaThanhToanTab;
        private System.Windows.Forms.DataGridView ChuaThanhToanDtg;
        private System.Windows.Forms.DataGridView DaThanhToanDtg;
        private System.Windows.Forms.CheckBox ChBHienThiMatKhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemUuDai;
        private System.Windows.Forms.Button btnXoaUuDai;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}