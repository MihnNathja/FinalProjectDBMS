namespace DBMSProject
{
    partial class UCMayTinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMayTinh));
            this.btnThemThoiGian = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Seriallbl = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblThoiGianDaDung = new System.Windows.Forms.Label();
            this.lblThoiGianConLai = new System.Windows.Forms.Label();
            this.lblMaNguoiDung = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBaoTri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemThoiGian
            // 
            this.btnThemThoiGian.BackColor = System.Drawing.Color.Cyan;
            this.btnThemThoiGian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThoiGian.Location = new System.Drawing.Point(282, 383);
            this.btnThemThoiGian.Name = "btnThemThoiGian";
            this.btnThemThoiGian.Size = new System.Drawing.Size(30, 31);
            this.btnThemThoiGian.TabIndex = 23;
            this.btnThemThoiGian.Text = "+";
            this.btnThemThoiGian.UseVisualStyleBackColor = false;
            this.btnThemThoiGian.Click += new System.EventHandler(this.ThemThoiGianBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thời gian còn lại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thời gian đã dùng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tình trạng:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Seriallbl
            // 
            this.Seriallbl.AutoSize = true;
            this.Seriallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seriallbl.Location = new System.Drawing.Point(213, 63);
            this.Seriallbl.Name = "Seriallbl";
            this.Seriallbl.Size = new System.Drawing.Size(18, 20);
            this.Seriallbl.TabIndex = 24;
            this.Seriallbl.Text = "1";
            this.Seriallbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(200, 267);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(112, 20);
            this.lblTinhTrang.TabIndex = 25;
            this.lblTinhTrang.Text = "Đang sử dụng";
            this.lblTinhTrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThoiGianDaDung
            // 
            this.lblThoiGianDaDung.AutoSize = true;
            this.lblThoiGianDaDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianDaDung.Location = new System.Drawing.Point(200, 309);
            this.lblThoiGianDaDung.Name = "lblThoiGianDaDung";
            this.lblThoiGianDaDung.Size = new System.Drawing.Size(63, 20);
            this.lblThoiGianDaDung.TabIndex = 26;
            this.lblThoiGianDaDung.Text = "1h02ph";
            this.lblThoiGianDaDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThoiGianConLai
            // 
            this.lblThoiGianConLai.AutoSize = true;
            this.lblThoiGianConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianConLai.Location = new System.Drawing.Point(200, 352);
            this.lblThoiGianConLai.Name = "lblThoiGianConLai";
            this.lblThoiGianConLai.Size = new System.Drawing.Size(63, 20);
            this.lblThoiGianConLai.TabIndex = 27;
            this.lblThoiGianConLai.Text = "5h37ph";
            this.lblThoiGianConLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNguoiDung
            // 
            this.lblMaNguoiDung.AutoSize = true;
            this.lblMaNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNguoiDung.Location = new System.Drawing.Point(200, 224);
            this.lblMaNguoiDung.Name = "lblMaNguoiDung";
            this.lblMaNguoiDung.Size = new System.Drawing.Size(18, 20);
            this.lblMaNguoiDung.TabIndex = 29;
            this.lblMaNguoiDung.Text = "1";
            this.lblMaNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mã người dùng:";
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.BackColor = System.Drawing.Color.Cyan;
            this.btnBaoTri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoTri.Location = new System.Drawing.Point(134, 383);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(129, 31);
            this.btnBaoTri.TabIndex = 30;
            this.btnBaoTri.Text = "Bảo trì";
            this.btnBaoTri.UseVisualStyleBackColor = false;
            this.btnBaoTri.Click += new System.EventHandler(this.btnBaoTri_Click);
            // 
            // UCMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBaoTri);
            this.Controls.Add(this.lblMaNguoiDung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblThoiGianConLai);
            this.Controls.Add(this.lblThoiGianDaDung);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.Seriallbl);
            this.Controls.Add(this.btnThemThoiGian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCMayTinh";
            this.Size = new System.Drawing.Size(336, 425);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblThoiGianDaDung;
        private System.Windows.Forms.Label lblThoiGianConLai;
        public System.Windows.Forms.Label Seriallbl;
        private System.Windows.Forms.Label lblMaNguoiDung;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblTinhTrang;
        public System.Windows.Forms.Button btnThemThoiGian;
        public System.Windows.Forms.Button btnBaoTri;
    }
}
