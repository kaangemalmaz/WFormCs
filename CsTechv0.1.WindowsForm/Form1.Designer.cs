
namespace CsTechv0._1.WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDgrSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYnlsSayi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDenemeSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Tahmin Ettiğiniz Sayiyi Giriniz : ";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(243, 68);
            this.txtSayi.MaxLength = 4;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(160, 23);
            this.txtSayi.TabIndex = 1;
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Şansımı denemek istiyorum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDgrSayi
            // 
            this.txtDgrSayi.Enabled = false;
            this.txtDgrSayi.Location = new System.Drawing.Point(230, 166);
            this.txtDgrSayi.Name = "txtDgrSayi";
            this.txtDgrSayi.Size = new System.Drawing.Size(67, 23);
            this.txtDgrSayi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doğru Basamak Sayisi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yanlış Basamak Sayisi : ";
            // 
            // txtYnlsSayi
            // 
            this.txtYnlsSayi.Enabled = false;
            this.txtYnlsSayi.Location = new System.Drawing.Point(230, 196);
            this.txtYnlsSayi.Name = "txtYnlsSayi";
            this.txtYnlsSayi.Size = new System.Drawing.Size(67, 23);
            this.txtYnlsSayi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bilgisayarın Tuttuğu Sayıyı Bulunuz";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(371, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ana Ekrana Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Deneme Sayisi : ";
            // 
            // txtDenemeSayisi
            // 
            this.txtDenemeSayisi.Enabled = false;
            this.txtDenemeSayisi.Location = new System.Drawing.Point(230, 225);
            this.txtDenemeSayisi.Name = "txtDenemeSayisi";
            this.txtDenemeSayisi.Size = new System.Drawing.Size(67, 23);
            this.txtDenemeSayisi.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 324);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDenemeSayisi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYnlsSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDgrSayi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDgrSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYnlsSayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDenemeSayisi;
    }
}

