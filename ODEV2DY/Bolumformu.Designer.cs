namespace ODEV2DY
{
    partial class Bolumformu
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
            this.btnbolumekle = new System.Windows.Forms.Button();
            this.cmbfak = new System.Windows.Forms.ComboBox();
            this.txtbolumadi = new System.Windows.Forms.TextBox();
            this.btnders = new System.Windows.Forms.Button();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.txtders = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.btnsube = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsube = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrElemani = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOgrElemani = new System.Windows.Forms.Button();
            this.cmbBolumOgrelemani = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOgradi = new System.Windows.Forms.TextBox();
            this.btnOgr = new System.Windows.Forms.Button();
            this.cmbBolumogrekle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDuzey = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbolumekle
            // 
            this.btnbolumekle.Location = new System.Drawing.Point(278, 29);
            this.btnbolumekle.Name = "btnbolumekle";
            this.btnbolumekle.Size = new System.Drawing.Size(75, 23);
            this.btnbolumekle.TabIndex = 7;
            this.btnbolumekle.Text = "Bolum Ekle";
            this.btnbolumekle.UseVisualStyleBackColor = true;
            this.btnbolumekle.Click += new System.EventHandler(this.btnbolumekle_Click_1);
            // 
            // cmbfak
            // 
            this.cmbfak.FormattingEnabled = true;
            this.cmbfak.Location = new System.Drawing.Point(127, 29);
            this.cmbfak.Name = "cmbfak";
            this.cmbfak.Size = new System.Drawing.Size(121, 21);
            this.cmbfak.TabIndex = 6;
            // 
            // txtbolumadi
            // 
            this.txtbolumadi.Location = new System.Drawing.Point(11, 29);
            this.txtbolumadi.Name = "txtbolumadi";
            this.txtbolumadi.Size = new System.Drawing.Size(100, 20);
            this.txtbolumadi.TabIndex = 5;
            // 
            // btnders
            // 
            this.btnders.Location = new System.Drawing.Point(278, 115);
            this.btnders.Name = "btnders";
            this.btnders.Size = new System.Drawing.Size(75, 23);
            this.btnders.TabIndex = 8;
            this.btnders.Text = "Ders Ekle";
            this.btnders.UseVisualStyleBackColor = true;
            this.btnders.Click += new System.EventHandler(this.btnders_Click);
            // 
            // cmbbolum
            // 
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Location = new System.Drawing.Point(11, 116);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(121, 21);
            this.cmbbolum.TabIndex = 9;
            this.cmbbolum.SelectedIndexChanged += new System.EventHandler(this.cmbbolum_SelectedIndexChanged);
            // 
            // txtders
            // 
            this.txtders.Location = new System.Drawing.Point(148, 118);
            this.txtders.Name = "txtders";
            this.txtders.Size = new System.Drawing.Size(100, 20);
            this.txtders.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bolum Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fakülte Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bolum Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ders Adı";
            // 
            // cmbders
            // 
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(11, 204);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(121, 21);
            this.cmbders.TabIndex = 15;
            this.cmbders.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnsube
            // 
            this.btnsube.Location = new System.Drawing.Point(278, 204);
            this.btnsube.Name = "btnsube";
            this.btnsube.Size = new System.Drawing.Size(75, 23);
            this.btnsube.TabIndex = 17;
            this.btnsube.Text = "Şube Ekle";
            this.btnsube.UseVisualStyleBackColor = true;
            this.btnsube.Click += new System.EventHandler(this.btnsube_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ders Adı";
            // 
            // txtsube
            // 
            this.txtsube.Location = new System.Drawing.Point(148, 204);
            this.txtsube.Name = "txtsube";
            this.txtsube.Size = new System.Drawing.Size(100, 20);
            this.txtsube.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Şube Adı";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 274);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Bölüm Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ogretim Elemanı";
            // 
            // txtOgrElemani
            // 
            this.txtOgrElemani.Location = new System.Drawing.Point(671, 31);
            this.txtOgrElemani.Name = "txtOgrElemani";
            this.txtOgrElemani.Size = new System.Drawing.Size(100, 20);
            this.txtOgrElemani.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Bolum Adı";
            // 
            // btnOgrElemani
            // 
            this.btnOgrElemani.Location = new System.Drawing.Point(777, 31);
            this.btnOgrElemani.Name = "btnOgrElemani";
            this.btnOgrElemani.Size = new System.Drawing.Size(146, 23);
            this.btnOgrElemani.TabIndex = 25;
            this.btnOgrElemani.Text = "Ogr.  Elemanı Ekle";
            this.btnOgrElemani.UseVisualStyleBackColor = true;
            this.btnOgrElemani.Click += new System.EventHandler(this.btnOgrElemani_Click);
            // 
            // cmbBolumOgrelemani
            // 
            this.cmbBolumOgrelemani.FormattingEnabled = true;
            this.cmbBolumOgrelemani.Location = new System.Drawing.Point(544, 32);
            this.cmbBolumOgrelemani.Name = "cmbBolumOgrelemani";
            this.cmbBolumOgrelemani.Size = new System.Drawing.Size(121, 21);
            this.cmbBolumOgrelemani.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Öğrenci Adı";
            // 
            // txtOgradi
            // 
            this.txtOgradi.Location = new System.Drawing.Point(671, 115);
            this.txtOgradi.Name = "txtOgradi";
            this.txtOgradi.Size = new System.Drawing.Size(100, 20);
            this.txtOgradi.TabIndex = 32;
            // 
            // btnOgr
            // 
            this.btnOgr.Location = new System.Drawing.Point(868, 114);
            this.btnOgr.Name = "btnOgr";
            this.btnOgr.Size = new System.Drawing.Size(106, 23);
            this.btnOgr.TabIndex = 30;
            this.btnOgr.Text = "Öğrenci Ekle";
            this.btnOgr.UseVisualStyleBackColor = true;
            // 
            // cmbBolumogrekle
            // 
            this.cmbBolumogrekle.FormattingEnabled = true;
            this.cmbBolumogrekle.Location = new System.Drawing.Point(544, 114);
            this.cmbBolumogrekle.Name = "cmbBolumogrekle";
            this.cmbBolumogrekle.Size = new System.Drawing.Size(121, 21);
            this.cmbBolumogrekle.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(569, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Bolum Adı";
            // 
            // cmbDuzey
            // 
            this.cmbDuzey.FormattingEnabled = true;
            this.cmbDuzey.Items.AddRange(new object[] {
            "Lisans",
            "Yuksek",
            "Doktora"});
            this.cmbDuzey.Location = new System.Drawing.Point(777, 114);
            this.cmbDuzey.Name = "cmbDuzey";
            this.cmbDuzey.Size = new System.Drawing.Size(85, 21);
            this.cmbDuzey.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(774, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Düzey";
            // 
            // Bolumformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 427);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbDuzey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOgradi);
            this.Controls.Add(this.btnOgr);
            this.Controls.Add(this.cmbBolumogrekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOgrElemani);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOgrElemani);
            this.Controls.Add(this.cmbBolumOgrelemani);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsube);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsube);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtders);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.btnders);
            this.Controls.Add(this.btnbolumekle);
            this.Controls.Add(this.cmbfak);
            this.Controls.Add(this.txtbolumadi);
            this.Name = "Bolumformu";
            this.Text = "Bolumformu";
            this.Load += new System.EventHandler(this.Bolumformu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbolumekle;
        private System.Windows.Forms.ComboBox cmbfak;
        private System.Windows.Forms.TextBox txtbolumadi;
        private System.Windows.Forms.Button btnders;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.TextBox txtders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.Button btnsube;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsube;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrElemani;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOgrElemani;
        private System.Windows.Forms.ComboBox cmbBolumOgrelemani;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOgradi;
        private System.Windows.Forms.Button btnOgr;
        private System.Windows.Forms.ComboBox cmbBolumogrekle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDuzey;
        private System.Windows.Forms.Label label10;
    }
}