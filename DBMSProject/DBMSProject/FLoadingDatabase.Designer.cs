namespace DBMSProject
{
    partial class FLoadingDatabase
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
            this.components = new System.ComponentModel.Container();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.prbLoading = new System.Windows.Forms.ProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Blue;
            this.lblLoading.Location = new System.Drawing.Point(129, 166);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(280, 29);
            this.lblLoading.TabIndex = 6;
            this.lblLoading.Text = "Đang lấy thông tin Server";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Red;
            this.lblPercent.Location = new System.Drawing.Point(584, 106);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(35, 29);
            this.lblPercent.TabIndex = 5;
            this.lblPercent.Text = "%";
            // 
            // prbLoading
            // 
            this.prbLoading.Location = new System.Drawing.Point(135, 87);
            this.prbLoading.Margin = new System.Windows.Forms.Padding(4);
            this.prbLoading.Name = "prbLoading";
            this.prbLoading.Size = new System.Drawing.Size(427, 48);
            this.prbLoading.TabIndex = 4;
            // 
            // FLoadingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 283);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.prbLoading);
            this.Name = "FLoadingDatabase";
            this.Text = "FLoadingDatabase";
            this.Load += new System.EventHandler(this.FLoadingDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ProgressBar prbLoading;
        private System.Windows.Forms.Timer timerLoading;
    }
}