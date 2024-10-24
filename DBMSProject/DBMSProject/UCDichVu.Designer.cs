namespace DBMSProject
{
    partial class UCDichVu
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
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(6, 166);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(165, 22);
            this.nudSoLuong.TabIndex = 8;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(112, 130);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(31, 16);
            this.lblDonGia.TabIndex = 7;
            this.lblDonGia.Text = "Giá";
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDichVu.Location = new System.Drawing.Point(3, 109);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(87, 16);
            this.lblTenDichVu.TabIndex = 6;
            this.lblTenDichVu.Text = "Tên dịch vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 150);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UCDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTenDichVu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCDichVu";
            this.Size = new System.Drawing.Size(180, 200);
            this.Load += new System.EventHandler(this.UCDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.NumericUpDown nudSoLuong;
    }
}
