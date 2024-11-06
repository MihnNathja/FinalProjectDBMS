namespace DBMSProject
{
    partial class UCUuDai
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
            this.lblTenUuDai = new System.Windows.Forms.Label();
            this.lblDieuKien = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.pbxUuDai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUuDai)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenUuDai
            // 
            this.lblTenUuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenUuDai.Location = new System.Drawing.Point(107, 7);
            this.lblTenUuDai.Name = "lblTenUuDai";
            this.lblTenUuDai.Size = new System.Drawing.Size(241, 55);
            this.lblTenUuDai.TabIndex = 7;
            this.lblTenUuDai.Text = "Tên ưu đãi";
            // 
            // lblDieuKien
            // 
            this.lblDieuKien.AutoSize = true;
            this.lblDieuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieuKien.Location = new System.Drawing.Point(107, 71);
            this.lblDieuKien.Name = "lblDieuKien";
            this.lblDieuKien.Size = new System.Drawing.Size(69, 18);
            this.lblDieuKien.TabIndex = 9;
            this.lblDieuKien.Text = "Điều kiện";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(107, 96);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(67, 18);
            this.lblSoLuong.TabIndex = 10;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.Cyan;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Location = new System.Drawing.Point(341, 81);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(61, 31);
            this.btnChon.TabIndex = 35;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // pbxUuDai
            // 
            this.pbxUuDai.Image = global::DBMSProject.Properties.Resources.categoryManagement;
            this.pbxUuDai.Location = new System.Drawing.Point(3, 3);
            this.pbxUuDai.Name = "pbxUuDai";
            this.pbxUuDai.Size = new System.Drawing.Size(98, 109);
            this.pbxUuDai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUuDai.TabIndex = 0;
            this.pbxUuDai.TabStop = false;
            // 
            // UCUuDai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDieuKien);
            this.Controls.Add(this.lblTenUuDai);
            this.Controls.Add(this.pbxUuDai);
            this.Name = "UCUuDai";
            this.Size = new System.Drawing.Size(405, 118);
            this.Load += new System.EventHandler(this.UCUuDai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUuDai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUuDai;
        private System.Windows.Forms.Label lblTenUuDai;
        private System.Windows.Forms.Label lblDieuKien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnChon;
    }
}
