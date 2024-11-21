namespace DBMSProject
{
    partial class FPhanTich
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
            this.btnPhanTich = new System.Windows.Forms.Button();
            this.btnDuDoan = new System.Windows.Forms.Button();
            this.dataGridViewPhanTich = new System.Windows.Forms.DataGridView();
            this.dataGridViewDuDoan = new System.Windows.Forms.DataGridView();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNam1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewDuDoan1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuDoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuDoan1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPhanTich
            // 
            this.btnPhanTich.Location = new System.Drawing.Point(29, 23);
            this.btnPhanTich.Name = "btnPhanTich";
            this.btnPhanTich.Size = new System.Drawing.Size(151, 39);
            this.btnPhanTich.TabIndex = 0;
            this.btnPhanTich.Text = "Phân tích doanh thu";
            this.btnPhanTich.UseVisualStyleBackColor = true;
            this.btnPhanTich.Click += new System.EventHandler(this.btnPhanTich_Click);
            // 
            // btnDuDoan
            // 
            this.btnDuDoan.Location = new System.Drawing.Point(29, 242);
            this.btnDuDoan.Name = "btnDuDoan";
            this.btnDuDoan.Size = new System.Drawing.Size(151, 39);
            this.btnDuDoan.TabIndex = 1;
            this.btnDuDoan.Text = "Dự đoán doanh thu";
            this.btnDuDoan.UseVisualStyleBackColor = true;
            this.btnDuDoan.Click += new System.EventHandler(this.btnDuDoan_Click);
            // 
            // dataGridViewPhanTich
            // 
            this.dataGridViewPhanTich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhanTich.Location = new System.Drawing.Point(29, 83);
            this.dataGridViewPhanTich.Name = "dataGridViewPhanTich";
            this.dataGridViewPhanTich.RowHeadersWidth = 51;
            this.dataGridViewPhanTich.RowTemplate.Height = 24;
            this.dataGridViewPhanTich.Size = new System.Drawing.Size(963, 117);
            this.dataGridViewPhanTich.TabIndex = 2;
            // 
            // dataGridViewDuDoan
            // 
            this.dataGridViewDuDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuDoan.Location = new System.Drawing.Point(29, 330);
            this.dataGridViewDuDoan.Name = "dataGridViewDuDoan";
            this.dataGridViewDuDoan.RowHeadersWidth = 51;
            this.dataGridViewDuDoan.RowTemplate.Height = 24;
            this.dataGridViewDuDoan.Size = new System.Drawing.Size(963, 132);
            this.dataGridViewDuDoan.TabIndex = 3;
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(252, 31);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(62, 24);
            this.cbbThang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbNam1
            // 
            this.cbbNam1.FormattingEnabled = true;
            this.cbbNam1.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbbNam1.Location = new System.Drawing.Point(391, 31);
            this.cbbNam1.Name = "cbbNam1";
            this.cbbNam1.Size = new System.Drawing.Size(62, 24);
            this.cbbNam1.TabIndex = 7;
            // 
            // dataGridViewDuDoan1
            // 
            this.dataGridViewDuDoan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuDoan1.Location = new System.Drawing.Point(29, 527);
            this.dataGridViewDuDoan1.Name = "dataGridViewDuDoan1";
            this.dataGridViewDuDoan1.RowHeadersWidth = 51;
            this.dataGridViewDuDoan1.RowTemplate.Height = 24;
            this.dataGridViewDuDoan1.Size = new System.Drawing.Size(963, 132);
            this.dataGridViewDuDoan1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dự đoán doanh thu tháng tới:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dự đoán về khách hàng, hóa đơn";
            // 
            // FPhanTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 697);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewDuDoan1);
            this.Controls.Add(this.cbbNam1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.dataGridViewDuDoan);
            this.Controls.Add(this.dataGridViewPhanTich);
            this.Controls.Add(this.btnDuDoan);
            this.Controls.Add(this.btnPhanTich);
            this.Name = "FPhanTich";
            this.Text = "FPhanTich";
            this.Load += new System.EventHandler(this.FPhanTich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuDoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuDoan1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhanTich;
        private System.Windows.Forms.Button btnDuDoan;
        private System.Windows.Forms.DataGridView dataGridViewPhanTich;
        private System.Windows.Forms.DataGridView dataGridViewDuDoan;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNam1;
        private System.Windows.Forms.DataGridView dataGridViewDuDoan1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}