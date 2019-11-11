namespace Methods
{
    partial class Form5
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
            this.btnRenkYakalayici = new System.Windows.Forms.Button();
            this.btnDiziIsleme = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.txtOrnekIki = new System.Windows.Forms.TextBox();
            this.btnToplamaYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRenkYakalayici
            // 
            this.btnRenkYakalayici.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRenkYakalayici.Location = new System.Drawing.Point(12, 274);
            this.btnRenkYakalayici.Name = "btnRenkYakalayici";
            this.btnRenkYakalayici.Size = new System.Drawing.Size(316, 40);
            this.btnRenkYakalayici.TabIndex = 31;
            this.btnRenkYakalayici.Text = "RENGİ YAKALA";
            this.btnRenkYakalayici.UseVisualStyleBackColor = false;
            this.btnRenkYakalayici.Click += new System.EventHandler(this.btnRenkYakalayici_Click);
            // 
            // btnDiziIsleme
            // 
            this.btnDiziIsleme.Location = new System.Drawing.Point(12, 228);
            this.btnDiziIsleme.Name = "btnDiziIsleme";
            this.btnDiziIsleme.Size = new System.Drawing.Size(316, 40);
            this.btnDiziIsleme.TabIndex = 30;
            this.btnDiziIsleme.Text = "DİZİ İŞLEME";
            this.btnDiziIsleme.UseVisualStyleBackColor = true;
            this.btnDiziIsleme.Click += new System.EventHandler(this.btnDiziIsleme_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(12, 182);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(316, 40);
            this.btnOrnekUc.TabIndex = 29;
            this.btnOrnekUc.Text = "METİNSEL DEĞİŞİKLİK";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(12, 156);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(316, 20);
            this.txtSoyad.TabIndex = 28;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 130);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(316, 20);
            this.txtAd.TabIndex = 27;
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(12, 84);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(316, 40);
            this.btnOrnekIki.TabIndex = 26;
            this.btnOrnekIki.Text = "ÇİFT Mİ TEK Mİ";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // txtOrnekIki
            // 
            this.txtOrnekIki.Location = new System.Drawing.Point(12, 58);
            this.txtOrnekIki.Name = "txtOrnekIki";
            this.txtOrnekIki.Size = new System.Drawing.Size(316, 20);
            this.txtOrnekIki.TabIndex = 25;
            // 
            // btnToplamaYap
            // 
            this.btnToplamaYap.Location = new System.Drawing.Point(12, 12);
            this.btnToplamaYap.Name = "btnToplamaYap";
            this.btnToplamaYap.Size = new System.Drawing.Size(316, 40);
            this.btnToplamaYap.TabIndex = 24;
            this.btnToplamaYap.Text = "TOPLAMA YAP";
            this.btnToplamaYap.UseVisualStyleBackColor = true;
            this.btnToplamaYap.Click += new System.EventHandler(this.btnToplamaYap_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 326);
            this.Controls.Add(this.btnRenkYakalayici);
            this.Controls.Add(this.btnDiziIsleme);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.txtOrnekIki);
            this.Controls.Add(this.btnToplamaYap);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenkYakalayici;
        private System.Windows.Forms.Button btnDiziIsleme;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.TextBox txtOrnekIki;
        private System.Windows.Forms.Button btnToplamaYap;
    }
}