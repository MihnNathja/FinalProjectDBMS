﻿namespace DBMSProject
{
    partial class FNapTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txbSoTienNap = new System.Windows.Forms.TextBox();
            this.txbThoiGianQuyDoi = new System.Windows.Forms.TextBox();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gia hạn thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền nạp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian quy đổi:";
            // 
            // txbTenTaiKhoan
            // 
            this.txbTenTaiKhoan.Enabled = false;
            this.txbTenTaiKhoan.Location = new System.Drawing.Point(179, 56);
            this.txbTenTaiKhoan.Name = "txbTenTaiKhoan";
            this.txbTenTaiKhoan.Size = new System.Drawing.Size(181, 22);
            this.txbTenTaiKhoan.TabIndex = 4;
            // 
            // txbSoTienNap
            // 
            this.txbSoTienNap.Location = new System.Drawing.Point(179, 105);
            this.txbSoTienNap.Name = "txbSoTienNap";
            this.txbSoTienNap.Size = new System.Drawing.Size(181, 22);
            this.txbSoTienNap.TabIndex = 5;
            this.txbSoTienNap.TextChanged += new System.EventHandler(this.txbSoTienNap_TextChanged);
            // 
            // txbThoiGianQuyDoi
            // 
            this.txbThoiGianQuyDoi.Enabled = false;
            this.txbThoiGianQuyDoi.Location = new System.Drawing.Point(179, 158);
            this.txbThoiGianQuyDoi.Name = "txbThoiGianQuyDoi";
            this.txbThoiGianQuyDoi.Size = new System.Drawing.Size(181, 22);
            this.txbThoiGianQuyDoi.TabIndex = 6;
            // 
            // btnNapTien
            // 
            this.btnNapTien.BackColor = System.Drawing.Color.Cyan;
            this.btnNapTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNapTien.Location = new System.Drawing.Point(77, 210);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(75, 31);
            this.btnNapTien.TabIndex = 7;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = false;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(190, 210);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FNapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 253);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNapTien);
            this.Controls.Add(this.txbThoiGianQuyDoi);
            this.Controls.Add(this.txbSoTienNap);
            this.Controls.Add(this.txbTenTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FNapTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gia hạn thời gian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenTaiKhoan;
        private System.Windows.Forms.TextBox txbSoTienNap;
        private System.Windows.Forms.TextBox txbThoiGianQuyDoi;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Button btnThoat;
    }
}