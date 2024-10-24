namespace DBMSProject
{
    partial class FQuanLyDichVu
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
            this.tabDichVu = new System.Windows.Forms.TabControl();
            this.DichVuDoAnView = new System.Windows.Forms.TabPage();
            this.ucQuanLyDoAn = new DBMSProject.UCQuanLyDichVu();
            this.DichVuThucUongView = new System.Windows.Forms.TabPage();
            this.ucQuanLyThucUong = new DBMSProject.UCQuanLyDichVu();
            this.DichVuTheCaoView = new System.Windows.Forms.TabPage();
            this.ucQuanLyTheCao = new DBMSProject.UCQuanLyDichVu();
            this.tabDichVu.SuspendLayout();
            this.DichVuDoAnView.SuspendLayout();
            this.DichVuThucUongView.SuspendLayout();
            this.DichVuTheCaoView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.DichVuDoAnView);
            this.tabDichVu.Controls.Add(this.DichVuThucUongView);
            this.tabDichVu.Controls.Add(this.DichVuTheCaoView);
            this.tabDichVu.Location = new System.Drawing.Point(0, 0);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.SelectedIndex = 0;
            this.tabDichVu.Size = new System.Drawing.Size(1039, 618);
            this.tabDichVu.TabIndex = 0;
            this.tabDichVu.SelectedIndexChanged += new System.EventHandler(this.ServiceTab_SelectedIndexChanged);
            // 
            // DichVuDoAnView
            // 
            this.DichVuDoAnView.Controls.Add(this.ucQuanLyDoAn);
            this.DichVuDoAnView.Location = new System.Drawing.Point(4, 25);
            this.DichVuDoAnView.Name = "DichVuDoAnView";
            this.DichVuDoAnView.Padding = new System.Windows.Forms.Padding(3);
            this.DichVuDoAnView.Size = new System.Drawing.Size(1031, 589);
            this.DichVuDoAnView.TabIndex = 0;
            this.DichVuDoAnView.Tag = "DichVuDoAnView";
            this.DichVuDoAnView.Text = "Đồ ăn";
            this.DichVuDoAnView.UseVisualStyleBackColor = true;
            // 
            // ucQuanLyDoAn
            // 
            this.ucQuanLyDoAn.Location = new System.Drawing.Point(0, 0);
            this.ucQuanLyDoAn.Name = "ucQuanLyDoAn";
            this.ucQuanLyDoAn.Size = new System.Drawing.Size(1028, 576);
            this.ucQuanLyDoAn.TabIndex = 0;
            // 
            // DichVuThucUongView
            // 
            this.DichVuThucUongView.Controls.Add(this.ucQuanLyThucUong);
            this.DichVuThucUongView.Location = new System.Drawing.Point(4, 25);
            this.DichVuThucUongView.Name = "DichVuThucUongView";
            this.DichVuThucUongView.Padding = new System.Windows.Forms.Padding(3);
            this.DichVuThucUongView.Size = new System.Drawing.Size(1078, 589);
            this.DichVuThucUongView.TabIndex = 1;
            this.DichVuThucUongView.Text = "Thức uống";
            this.DichVuThucUongView.UseVisualStyleBackColor = true;
            // 
            // ucQuanLyThucUong
            // 
            this.ucQuanLyThucUong.Location = new System.Drawing.Point(0, 0);
            this.ucQuanLyThucUong.Name = "ucQuanLyThucUong";
            this.ucQuanLyThucUong.Size = new System.Drawing.Size(1028, 576);
            this.ucQuanLyThucUong.TabIndex = 0;
            // 
            // DichVuTheCaoView
            // 
            this.DichVuTheCaoView.Controls.Add(this.ucQuanLyTheCao);
            this.DichVuTheCaoView.Location = new System.Drawing.Point(4, 25);
            this.DichVuTheCaoView.Name = "DichVuTheCaoView";
            this.DichVuTheCaoView.Padding = new System.Windows.Forms.Padding(3);
            this.DichVuTheCaoView.Size = new System.Drawing.Size(1078, 589);
            this.DichVuTheCaoView.TabIndex = 2;
            this.DichVuTheCaoView.Text = "Thẻ cào";
            this.DichVuTheCaoView.UseVisualStyleBackColor = true;
            // 
            // ucQuanLyTheCao
            // 
            this.ucQuanLyTheCao.Location = new System.Drawing.Point(0, 0);
            this.ucQuanLyTheCao.Name = "ucQuanLyTheCao";
            this.ucQuanLyTheCao.Size = new System.Drawing.Size(1028, 576);
            this.ucQuanLyTheCao.TabIndex = 0;
            // 
            // FQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 618);
            this.Controls.Add(this.tabDichVu);
            this.Name = "FQuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục";
            this.Load += new System.EventHandler(this.FQuanLyDichVu_Load);
            this.tabDichVu.ResumeLayout(false);
            this.DichVuDoAnView.ResumeLayout(false);
            this.DichVuThucUongView.ResumeLayout(false);
            this.DichVuTheCaoView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDichVu;
        private System.Windows.Forms.TabPage DichVuThucUongView;
        private System.Windows.Forms.TabPage DichVuTheCaoView;
        private UCQuanLyDichVu ucQuanLyThucUong;
        private UCQuanLyDichVu ucQuanLyTheCao;
        private System.Windows.Forms.TabPage DichVuDoAnView;
        private UCQuanLyDichVu ucQuanLyDoAn;
    }
}