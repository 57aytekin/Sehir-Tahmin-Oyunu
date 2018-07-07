namespace SehirTahminOyunu
{
    partial class Form1
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
            this.grbSoruAlani = new System.Windows.Forms.GroupBox();
            this.grbCevapAlani = new System.Windows.Forms.GroupBox();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblGirilenHarf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKelimeGir = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnHarfGir = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbCevapAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSoruAlani
            // 
            this.grbSoruAlani.Location = new System.Drawing.Point(71, 41);
            this.grbSoruAlani.Name = "grbSoruAlani";
            this.grbSoruAlani.Size = new System.Drawing.Size(440, 149);
            this.grbSoruAlani.TabIndex = 0;
            this.grbSoruAlani.TabStop = false;
            this.grbSoruAlani.Text = "Soru Alanı";
            // 
            // grbCevapAlani
            // 
            this.grbCevapAlani.Controls.Add(this.lblKalanHak);
            this.grbCevapAlani.Controls.Add(this.lblGirilenHarf);
            this.grbCevapAlani.Controls.Add(this.label2);
            this.grbCevapAlani.Controls.Add(this.label1);
            this.grbCevapAlani.Controls.Add(this.btnKelimeGir);
            this.grbCevapAlani.Controls.Add(this.txtKelime);
            this.grbCevapAlani.Controls.Add(this.btnHarfGir);
            this.grbCevapAlani.Controls.Add(this.txtHarf);
            this.grbCevapAlani.Location = new System.Drawing.Point(71, 196);
            this.grbCevapAlani.Name = "grbCevapAlani";
            this.grbCevapAlani.Size = new System.Drawing.Size(440, 149);
            this.grbCevapAlani.TabIndex = 1;
            this.grbCevapAlani.TabStop = false;
            this.grbCevapAlani.Text = "Cevap Alanı";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Location = new System.Drawing.Point(99, 108);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(13, 13);
            this.lblKalanHak.TabIndex = 7;
            this.lblKalanHak.Text = "4";
            // 
            // lblGirilenHarf
            // 
            this.lblGirilenHarf.AutoSize = true;
            this.lblGirilenHarf.Location = new System.Drawing.Point(98, 81);
            this.lblGirilenHarf.Name = "lblGirilenHarf";
            this.lblGirilenHarf.Size = new System.Drawing.Size(25, 13);
            this.lblGirilenHarf.TabIndex = 6;
            this.lblGirilenHarf.Text = "___";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kalan Hak:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler:";
            // 
            // btnKelimeGir
            // 
            this.btnKelimeGir.Location = new System.Drawing.Point(350, 35);
            this.btnKelimeGir.Name = "btnKelimeGir";
            this.btnKelimeGir.Size = new System.Drawing.Size(85, 23);
            this.btnKelimeGir.TabIndex = 3;
            this.btnKelimeGir.Text = "Kelime Gir";
            this.btnKelimeGir.UseVisualStyleBackColor = true;
            this.btnKelimeGir.Click += new System.EventHandler(this.btnKelimeGir_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(233, 36);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(111, 20);
            this.txtKelime.TabIndex = 2;
            // 
            // btnHarfGir
            // 
            this.btnHarfGir.Location = new System.Drawing.Point(123, 34);
            this.btnHarfGir.Name = "btnHarfGir";
            this.btnHarfGir.Size = new System.Drawing.Size(85, 23);
            this.btnHarfGir.TabIndex = 1;
            this.btnHarfGir.Text = "Harf Gir";
            this.btnHarfGir.UseVisualStyleBackColor = true;
            this.btnHarfGir.Click += new System.EventHandler(this.btnHarfGir_Click_1);
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(6, 37);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(111, 20);
            this.txtHarf.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeni Oyuna Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(614, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbCevapAlani);
            this.Controls.Add(this.grbSoruAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCevapAlani.ResumeLayout(false);
            this.grbCevapAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSoruAlani;
        private System.Windows.Forms.GroupBox grbCevapAlani;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblGirilenHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKelimeGir;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnHarfGir;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button button1;
    }
}

