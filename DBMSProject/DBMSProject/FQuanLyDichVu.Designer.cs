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
            this.DrinkingTab = new System.Windows.Forms.TabPage();
            this.CardTab = new System.Windows.Forms.TabPage();
            this.FoodTab = new System.Windows.Forms.TabPage();
            this.ucQuanLyDoAn = new DBMSProject.UCQuanLyDichVu();
            this.ucQuanLyThucUong = new DBMSProject.UCQuanLyDichVu();
            this.ucQuanLyTheCao = new DBMSProject.UCQuanLyDichVu();
            this.tabDichVu.SuspendLayout();
            this.DrinkingTab.SuspendLayout();
            this.CardTab.SuspendLayout();
            this.FoodTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.FoodTab);
            this.tabDichVu.Controls.Add(this.DrinkingTab);
            this.tabDichVu.Controls.Add(this.CardTab);
            this.tabDichVu.Location = new System.Drawing.Point(0, 0);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.SelectedIndex = 0;
            this.tabDichVu.Size = new System.Drawing.Size(1086, 618);
            this.tabDichVu.TabIndex = 0;
            this.tabDichVu.SelectedIndexChanged += new System.EventHandler(this.ServiceTab_SelectedIndexChanged);
            // 
            // DrinkingTab
            // 
            this.DrinkingTab.Controls.Add(this.ucQuanLyThucUong);
            this.DrinkingTab.Location = new System.Drawing.Point(4, 25);
            this.DrinkingTab.Name = "DrinkingTab";
            this.DrinkingTab.Padding = new System.Windows.Forms.Padding(3);
            this.DrinkingTab.Size = new System.Drawing.Size(1078, 589);
            this.DrinkingTab.TabIndex = 1;
            this.DrinkingTab.Text = "Thức uống";
            this.DrinkingTab.UseVisualStyleBackColor = true;
            // 
            // CardTab
            // 
            this.CardTab.Controls.Add(this.ucQuanLyTheCao);
            this.CardTab.Location = new System.Drawing.Point(4, 25);
            this.CardTab.Name = "CardTab";
            this.CardTab.Padding = new System.Windows.Forms.Padding(3);
            this.CardTab.Size = new System.Drawing.Size(1078, 589);
            this.CardTab.TabIndex = 2;
            this.CardTab.Text = "Thẻ cào";
            this.CardTab.UseVisualStyleBackColor = true;
            // 
            // FoodTab
            // 
            this.FoodTab.Controls.Add(this.ucQuanLyDoAn);
            this.FoodTab.Location = new System.Drawing.Point(4, 25);
            this.FoodTab.Name = "FoodTab";
            this.FoodTab.Padding = new System.Windows.Forms.Padding(3);
            this.FoodTab.Size = new System.Drawing.Size(1078, 589);
            this.FoodTab.TabIndex = 0;
            this.FoodTab.Text = "Đồ ăn";
            this.FoodTab.UseVisualStyleBackColor = true;
            // 
            // ucQuanLyDoAn
            // 
            this.ucQuanLyDoAn.Location = new System.Drawing.Point(0, 0);
            this.ucQuanLyDoAn.Name = "ucQuanLyDoAn";
            this.ucQuanLyDoAn.Size = new System.Drawing.Size(1028, 576);
            this.ucQuanLyDoAn.TabIndex = 0;
            // 
            // ucQuanLyThucUong
            // 
            this.ucQuanLyThucUong.Location = new System.Drawing.Point(0, 0);
            this.ucQuanLyThucUong.Name = "ucQuanLyThucUong";
            this.ucQuanLyThucUong.Size = new System.Drawing.Size(1028, 576);
            this.ucQuanLyThucUong.TabIndex = 0;
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
            this.DrinkingTab.ResumeLayout(false);
            this.CardTab.ResumeLayout(false);
            this.FoodTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDichVu;
        private System.Windows.Forms.TabPage DrinkingTab;
        private System.Windows.Forms.TabPage CardTab;
        private UCQuanLyDichVu ucQuanLyThucUong;
        private UCQuanLyDichVu ucQuanLyTheCao;
        private System.Windows.Forms.TabPage FoodTab;
        private UCQuanLyDichVu ucQuanLyDoAn;
    }
}