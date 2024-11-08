namespace DBMSProject
{
    partial class FDichVu
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
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.flpnlDichVu = new System.Windows.Forms.FlowLayoutPanel();
            this.DichVuDoAnView = new System.Windows.Forms.RadioButton();
            this.DichVuThucUongView = new System.Windows.Forms.RadioButton();
            this.DichVuTheCaoView = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiYeuCau.Location = new System.Drawing.Point(639, 500);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(146, 42);
            this.btnGuiYeuCau.TabIndex = 21;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = true;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(164, 29);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(621, 29);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // flpnlDichVu
            // 
            this.flpnlDichVu.AutoScroll = true;
            this.flpnlDichVu.Location = new System.Drawing.Point(40, 120);
            this.flpnlDichVu.Name = "flpnlDichVu";
            this.flpnlDichVu.Size = new System.Drawing.Size(745, 374);
            this.flpnlDichVu.TabIndex = 24;
            // 
            // DichVuDoAnView
            // 
            this.DichVuDoAnView.AutoSize = true;
            this.DichVuDoAnView.Checked = true;
            this.DichVuDoAnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DichVuDoAnView.Location = new System.Drawing.Point(40, 74);
            this.DichVuDoAnView.Name = "DichVuDoAnView";
            this.DichVuDoAnView.Size = new System.Drawing.Size(79, 24);
            this.DichVuDoAnView.TabIndex = 26;
            this.DichVuDoAnView.TabStop = true;
            this.DichVuDoAnView.Text = "Đồ ăn";
            this.DichVuDoAnView.UseVisualStyleBackColor = true;
            this.DichVuDoAnView.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // DichVuThucUongView
            // 
            this.DichVuThucUongView.AutoSize = true;
            this.DichVuThucUongView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DichVuThucUongView.Location = new System.Drawing.Point(164, 74);
            this.DichVuThucUongView.Name = "DichVuThucUongView";
            this.DichVuThucUongView.Size = new System.Drawing.Size(117, 24);
            this.DichVuThucUongView.TabIndex = 27;
            this.DichVuThucUongView.Text = "Thức uống";
            this.DichVuThucUongView.UseVisualStyleBackColor = true;
            this.DichVuThucUongView.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // DichVuTheCaoView
            // 
            this.DichVuTheCaoView.AutoSize = true;
            this.DichVuTheCaoView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DichVuTheCaoView.Location = new System.Drawing.Point(332, 74);
            this.DichVuTheCaoView.Name = "DichVuTheCaoView";
            this.DichVuTheCaoView.Size = new System.Drawing.Size(97, 24);
            this.DichVuTheCaoView.TabIndex = 28;
            this.DichVuTheCaoView.Text = "Thẻ cào";
            this.DichVuTheCaoView.UseVisualStyleBackColor = true;
            this.DichVuTheCaoView.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tìm kiếm:";
            // 
            // FDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DichVuTheCaoView);
            this.Controls.Add(this.DichVuThucUongView);
            this.Controls.Add(this.DichVuDoAnView);
            this.Controls.Add(this.flpnlDichVu);
            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "FDichVu";
            this.Text = "FDichVu";
            this.Load += new System.EventHandler(this.FDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.FlowLayoutPanel flpnlDichVu;
        private System.Windows.Forms.RadioButton DichVuDoAnView;
        private System.Windows.Forms.RadioButton DichVuThucUongView;
        private System.Windows.Forms.RadioButton DichVuTheCaoView;
        private System.Windows.Forms.Label label2;
    }
}