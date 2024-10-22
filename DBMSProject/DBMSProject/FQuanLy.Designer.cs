namespace DBMSProject
{
    partial class FQuanLy
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
            this.categoryManagementPtb = new System.Windows.Forms.PictureBox();
            this.MainScreenPtb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryManagementPtb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPtb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Màn hình chính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quản lý danh mục";
            // 
            // categoryManagementPtb
            // 
            this.categoryManagementPtb.Image = global::DBMSProject.Properties.Resources.categoryManagement;
            this.categoryManagementPtb.Location = new System.Drawing.Point(454, 55);
            this.categoryManagementPtb.Name = "categoryManagementPtb";
            this.categoryManagementPtb.Size = new System.Drawing.Size(291, 297);
            this.categoryManagementPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoryManagementPtb.TabIndex = 1;
            this.categoryManagementPtb.TabStop = false;
            this.categoryManagementPtb.Click += new System.EventHandler(this.categoryManagementPtb_Click);
            // 
            // MainScreenPtb
            // 
            this.MainScreenPtb.Image = global::DBMSProject.Properties.Resources.MainScreen;
            this.MainScreenPtb.Location = new System.Drawing.Point(65, 55);
            this.MainScreenPtb.Name = "MainScreenPtb";
            this.MainScreenPtb.Size = new System.Drawing.Size(351, 297);
            this.MainScreenPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainScreenPtb.TabIndex = 0;
            this.MainScreenPtb.TabStop = false;
            this.MainScreenPtb.Click += new System.EventHandler(this.MainScreenPtb_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryManagementPtb);
            this.Controls.Add(this.MainScreenPtb);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn";
            ((System.ComponentModel.ISupportInitialize)(this.categoryManagementPtb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPtb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainScreenPtb;
        private System.Windows.Forms.PictureBox categoryManagementPtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}