namespace Methods
{
    partial class Form4
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
            this.btnMailOlustur = new System.Windows.Forms.Button();
            this.cmbSunucuAdlari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMailOlustur
            // 
            this.btnMailOlustur.Location = new System.Drawing.Point(12, 96);
            this.btnMailOlustur.Name = "btnMailOlustur";
            this.btnMailOlustur.Size = new System.Drawing.Size(224, 30);
            this.btnMailOlustur.TabIndex = 52;
            this.btnMailOlustur.Text = "MAİL ADRESİMİ OLUŞTUR";
            this.btnMailOlustur.UseVisualStyleBackColor = true;
            // 
            // cmbSunucuAdlari
            // 
            this.cmbSunucuAdlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSunucuAdlari.FormattingEnabled = true;
            this.cmbSunucuAdlari.Items.AddRange(new object[] {
            "hotmail.com",
            "hotmail.co.uk",
            "hotmail.co.jp",
            "hotmail.com.tr",
            "hotmail.com.fr",
            "hotmail.com.it"});
            this.cmbSunucuAdlari.Location = new System.Drawing.Point(12, 71);
            this.cmbSunucuAdlari.Name = "cmbSunucuAdlari";
            this.cmbSunucuAdlari.Size = new System.Drawing.Size(224, 21);
            this.cmbSunucuAdlari.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Lütfen tercih ettiğiniz mail uzantısını seçiniz:";
            // 
            // txtMailKullaniciAdi
            // 
            this.txtMailKullaniciAdi.Location = new System.Drawing.Point(12, 30);
            this.txtMailKullaniciAdi.Name = "txtMailKullaniciAdi";
            this.txtMailKullaniciAdi.Size = new System.Drawing.Size(224, 20);
            this.txtMailKullaniciAdi.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Lütfen mail için adınızı giriniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 139);
            this.Controls.Add(this.btnMailOlustur);
            this.Controls.Add(this.cmbSunucuAdlari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMailKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMailOlustur;
        private System.Windows.Forms.ComboBox cmbSunucuAdlari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMailKullaniciAdi;
        private System.Windows.Forms.Label label1;
    }
}