namespace ODEV2DY
{
    partial class Main
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnfakulte = new System.Windows.Forms.Button();
            this.btnbolum = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(233, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 0;
            // 
            // btnfakulte
            // 
            this.btnfakulte.Location = new System.Drawing.Point(52, 120);
            this.btnfakulte.Name = "btnfakulte";
            this.btnfakulte.Size = new System.Drawing.Size(158, 38);
            this.btnfakulte.TabIndex = 1;
            this.btnfakulte.Text = "Fakülte İşlemleri";
            this.btnfakulte.UseVisualStyleBackColor = true;
            this.btnfakulte.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbolum
            // 
            this.btnbolum.Location = new System.Drawing.Point(310, 117);
            this.btnbolum.Name = "btnbolum";
            this.btnbolum.Size = new System.Drawing.Size(158, 41);
            this.btnbolum.TabIndex = 2;
            this.btnbolum.Text = "Bölüm İşlemleri";
            this.btnbolum.UseVisualStyleBackColor = true;
            this.btnbolum.Click += new System.EventHandler(this.btnbolum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ders İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 256);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbolum);
            this.Controls.Add(this.btnfakulte);
            this.Controls.Add(this.lbl);
            this.Name = "Main";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnfakulte;
        private System.Windows.Forms.Button btnbolum;
        private System.Windows.Forms.Button button2;
    }
}

