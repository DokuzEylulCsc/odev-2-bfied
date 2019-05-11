namespace ODEV2DY
{
    partial class Fakulte_islemleri
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
            this.txtfac = new System.Windows.Forms.TextBox();
            this.btnfac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfac
            // 
            this.txtfac.Location = new System.Drawing.Point(12, 12);
            this.txtfac.Name = "txtfac";
            this.txtfac.Size = new System.Drawing.Size(100, 20);
            this.txtfac.TabIndex = 0;
            // 
            // btnfac
            // 
            this.btnfac.Location = new System.Drawing.Point(118, 9);
            this.btnfac.Name = "btnfac";
            this.btnfac.Size = new System.Drawing.Size(75, 23);
            this.btnfac.TabIndex = 1;
            this.btnfac.Text = "Fakülte Ekle";
            this.btnfac.UseVisualStyleBackColor = true;
            this.btnfac.Click += new System.EventHandler(this.btnfac_Click);
            // 
            // Fakulte_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.btnfac);
            this.Controls.Add(this.txtfac);
            this.Name = "Fakulte_islemleri";
            this.Text = "Fakulte_islemleri";
            this.Load += new System.EventHandler(this.Fakulte_islemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfac;
        private System.Windows.Forms.Button btnfac;
    }
}