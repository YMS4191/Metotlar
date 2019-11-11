namespace Methods
{
    partial class Form6
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
            this.txtMailAdresleri = new System.Windows.Forms.TextBox();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnOutUc = new System.Windows.Forms.Button();
            this.btnOutIki = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMailAdresleri
            // 
            this.txtMailAdresleri.Location = new System.Drawing.Point(12, 196);
            this.txtMailAdresleri.Multiline = true;
            this.txtMailAdresleri.Name = "txtMailAdresleri";
            this.txtMailAdresleri.Size = new System.Drawing.Size(331, 68);
            this.txtMailAdresleri.TabIndex = 27;
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(12, 150);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(331, 40);
            this.btnParams.TabIndex = 25;
            this.btnParams.Text = "PARAMS ANAHTAR KELİMESİ";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnOutUc
            // 
            this.btnOutUc.Location = new System.Drawing.Point(12, 104);
            this.btnOutUc.Name = "btnOutUc";
            this.btnOutUc.Size = new System.Drawing.Size(331, 40);
            this.btnOutUc.TabIndex = 24;
            this.btnOutUc.Text = "OUT ANAHTAR KELİMESİ (ÖRNEK ÜÇ)";
            this.btnOutUc.UseVisualStyleBackColor = true;
            this.btnOutUc.Click += new System.EventHandler(this.btnOutUc_Click);
            // 
            // btnOutIki
            // 
            this.btnOutIki.Location = new System.Drawing.Point(12, 58);
            this.btnOutIki.Name = "btnOutIki";
            this.btnOutIki.Size = new System.Drawing.Size(331, 40);
            this.btnOutIki.TabIndex = 23;
            this.btnOutIki.Text = "OUT ANAHTAR KELİMESİ (ÖRNEK İKİ)";
            this.btnOutIki.UseVisualStyleBackColor = true;
            this.btnOutIki.Click += new System.EventHandler(this.btnOutIki_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(349, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 251);
            this.listBox1.TabIndex = 22;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(12, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(331, 40);
            this.btnOut.TabIndex = 21;
            this.btnOut.Text = "OUT ANAHTAR KELİMESİ";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 275);
            this.Controls.Add(this.txtMailAdresleri);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnOutUc);
            this.Controls.Add(this.btnOutIki);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOut);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailAdresleri;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnOutUc;
        private System.Windows.Forms.Button btnOutIki;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOut;
    }
}