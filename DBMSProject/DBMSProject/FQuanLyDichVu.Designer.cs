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
            this.ServiceTab = new System.Windows.Forms.TabControl();
            this.FoodTab = new System.Windows.Forms.TabPage();
            this.DrinkingTab = new System.Windows.Forms.TabPage();
            this.CardTab = new System.Windows.Forms.TabPage();
            this.FoodDtg = new System.Windows.Forms.DataGridView();
            this.DrinkingDtg = new System.Windows.Forms.DataGridView();
            this.CardDtg = new System.Windows.Forms.DataGridView();
            this.ServiceTab.SuspendLayout();
            this.FoodTab.SuspendLayout();
            this.DrinkingTab.SuspendLayout();
            this.CardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkingDtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceTab
            // 
            this.ServiceTab.Controls.Add(this.FoodTab);
            this.ServiceTab.Controls.Add(this.DrinkingTab);
            this.ServiceTab.Controls.Add(this.CardTab);
            this.ServiceTab.Location = new System.Drawing.Point(0, 0);
            this.ServiceTab.Name = "ServiceTab";
            this.ServiceTab.SelectedIndex = 0;
            this.ServiceTab.Size = new System.Drawing.Size(1006, 499);
            this.ServiceTab.TabIndex = 0;
            // 
            // FoodTab
            // 
            this.FoodTab.Controls.Add(this.FoodDtg);
            this.FoodTab.Location = new System.Drawing.Point(4, 25);
            this.FoodTab.Name = "FoodTab";
            this.FoodTab.Padding = new System.Windows.Forms.Padding(3);
            this.FoodTab.Size = new System.Drawing.Size(1027, 524);
            this.FoodTab.TabIndex = 0;
            this.FoodTab.Text = "Đồ ăn";
            this.FoodTab.UseVisualStyleBackColor = true;
            // 
            // DrinkingTab
            // 
            this.DrinkingTab.Controls.Add(this.DrinkingDtg);
            this.DrinkingTab.Location = new System.Drawing.Point(4, 25);
            this.DrinkingTab.Name = "DrinkingTab";
            this.DrinkingTab.Padding = new System.Windows.Forms.Padding(3);
            this.DrinkingTab.Size = new System.Drawing.Size(1027, 524);
            this.DrinkingTab.TabIndex = 1;
            this.DrinkingTab.Text = "Thức uống";
            this.DrinkingTab.UseVisualStyleBackColor = true;
            // 
            // CardTab
            // 
            this.CardTab.Controls.Add(this.CardDtg);
            this.CardTab.Location = new System.Drawing.Point(4, 25);
            this.CardTab.Name = "CardTab";
            this.CardTab.Padding = new System.Windows.Forms.Padding(3);
            this.CardTab.Size = new System.Drawing.Size(998, 470);
            this.CardTab.TabIndex = 2;
            this.CardTab.Text = "Thẻ cào";
            this.CardTab.UseVisualStyleBackColor = true;
            // 
            // FoodDtg
            // 
            this.FoodDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodDtg.Location = new System.Drawing.Point(0, 0);
            this.FoodDtg.Name = "FoodDtg";
            this.FoodDtg.RowHeadersWidth = 51;
            this.FoodDtg.RowTemplate.Height = 24;
            this.FoodDtg.Size = new System.Drawing.Size(1027, 527);
            this.FoodDtg.TabIndex = 2;
            // 
            // DrinkingDtg
            // 
            this.DrinkingDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrinkingDtg.Location = new System.Drawing.Point(0, -1);
            this.DrinkingDtg.Name = "DrinkingDtg";
            this.DrinkingDtg.RowHeadersWidth = 51;
            this.DrinkingDtg.RowTemplate.Height = 24;
            this.DrinkingDtg.Size = new System.Drawing.Size(1027, 527);
            this.DrinkingDtg.TabIndex = 3;
            // 
            // CardDtg
            // 
            this.CardDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardDtg.Location = new System.Drawing.Point(0, -1);
            this.CardDtg.Name = "CardDtg";
            this.CardDtg.RowHeadersWidth = 51;
            this.CardDtg.RowTemplate.Height = 24;
            this.CardDtg.Size = new System.Drawing.Size(1027, 527);
            this.CardDtg.TabIndex = 3;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 497);
            this.Controls.Add(this.ServiceTab);
            this.Name = "ServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục";
            this.ServiceTab.ResumeLayout(false);
            this.FoodTab.ResumeLayout(false);
            this.DrinkingTab.ResumeLayout(false);
            this.CardTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodDtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkingDtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ServiceTab;
        private System.Windows.Forms.TabPage FoodTab;
        private System.Windows.Forms.TabPage DrinkingTab;
        private System.Windows.Forms.TabPage CardTab;
        private System.Windows.Forms.DataGridView FoodDtg;
        private System.Windows.Forms.DataGridView DrinkingDtg;
        private System.Windows.Forms.DataGridView CardDtg;
    }
}