
namespace CsTechv0._1.WindowsForm
{
    partial class Bilgisayar
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
            this.txtBilgisayarSayiTahmin = new System.Windows.Forms.TextBox();
            this.btndogru = new System.Windows.Forms.Button();
            this.btnynls = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYnlsSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDgrSayi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnarti = new System.Windows.Forms.Button();
            this.btneksi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDenemeSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayarın Tahmini :";
            // 
            // txtBilgisayarSayiTahmin
            // 
            this.txtBilgisayarSayiTahmin.Enabled = false;
            this.txtBilgisayarSayiTahmin.Location = new System.Drawing.Point(198, 79);
            this.txtBilgisayarSayiTahmin.MaxLength = 4;
            this.txtBilgisayarSayiTahmin.Name = "txtBilgisayarSayiTahmin";
            this.txtBilgisayarSayiTahmin.Size = new System.Drawing.Size(120, 23);
            this.txtBilgisayarSayiTahmin.TabIndex = 1;
            this.txtBilgisayarSayiTahmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBilgisayarSayiTahmin_KeyPress);
            // 
            // btndogru
            // 
            this.btndogru.Location = new System.Drawing.Point(20, 133);
            this.btndogru.Name = "btndogru";
            this.btndogru.Size = new System.Drawing.Size(186, 47);
            this.btndogru.TabIndex = 2;
            this.btndogru.Text = "Doğru";
            this.btndogru.UseVisualStyleBackColor = true;
            this.btndogru.Click += new System.EventHandler(this.btndogru_Click);
            // 
            // btnynls
            // 
            this.btnynls.Location = new System.Drawing.Point(212, 133);
            this.btnynls.Name = "btnynls";
            this.btnynls.Size = new System.Drawing.Size(186, 47);
            this.btnynls.TabIndex = 3;
            this.btnynls.Text = "Yanlış";
            this.btnynls.UseVisualStyleBackColor = true;
            this.btnynls.Click += new System.EventHandler(this.btnynls_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yanlış Basamak Sayisi : ";
            // 
            // txtYnlsSayi
            // 
            this.txtYnlsSayi.Enabled = false;
            this.txtYnlsSayi.Location = new System.Drawing.Point(212, 238);
            this.txtYnlsSayi.MaxLength = 1;
            this.txtYnlsSayi.Name = "txtYnlsSayi";
            this.txtYnlsSayi.Size = new System.Drawing.Size(67, 23);
            this.txtYnlsSayi.TabIndex = 9;
            this.txtYnlsSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYnlsSayi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doğru Basamak Sayisi : ";
            // 
            // txtDgrSayi
            // 
            this.txtDgrSayi.Location = new System.Drawing.Point(212, 208);
            this.txtDgrSayi.MaxLength = 1;
            this.txtDgrSayi.Name = "txtDgrSayi";
            this.txtDgrSayi.Size = new System.Drawing.Size(67, 23);
            this.txtDgrSayi.TabIndex = 7;
            this.txtDgrSayi.TextChanged += new System.EventHandler(this.txtDgrSayi_TextChanged);
            this.txtDgrSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDgrSayi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bilgisayar Tuttuğunuz Sayıyı Tahmin Etsin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ana Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnarti
            // 
            this.btnarti.Location = new System.Drawing.Point(285, 208);
            this.btnarti.Name = "btnarti";
            this.btnarti.Size = new System.Drawing.Size(33, 23);
            this.btnarti.TabIndex = 13;
            this.btnarti.Text = "+";
            this.btnarti.UseVisualStyleBackColor = true;
            this.btnarti.Click += new System.EventHandler(this.btnarti_Click);
            // 
            // btneksi
            // 
            this.btneksi.Location = new System.Drawing.Point(324, 208);
            this.btneksi.Name = "btneksi";
            this.btneksi.Size = new System.Drawing.Size(33, 23);
            this.btneksi.TabIndex = 14;
            this.btneksi.Text = "-";
            this.btneksi.UseVisualStyleBackColor = true;
            this.btneksi.Click += new System.EventHandler(this.btneksi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Deneme Sayisi : ";
            // 
            // txtDenemeSayisi
            // 
            this.txtDenemeSayisi.Enabled = false;
            this.txtDenemeSayisi.Location = new System.Drawing.Point(212, 267);
            this.txtDenemeSayisi.MaxLength = 1;
            this.txtDenemeSayisi.Name = "txtDenemeSayisi";
            this.txtDenemeSayisi.Size = new System.Drawing.Size(67, 23);
            this.txtDenemeSayisi.TabIndex = 15;
            // 
            // Bilgisayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 390);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDenemeSayisi);
            this.Controls.Add(this.btneksi);
            this.Controls.Add(this.btnarti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYnlsSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDgrSayi);
            this.Controls.Add(this.btnynls);
            this.Controls.Add(this.btndogru);
            this.Controls.Add(this.txtBilgisayarSayiTahmin);
            this.Controls.Add(this.label1);
            this.Name = "Bilgisayar";
            this.Text = "Bilgisayar";
            this.Load += new System.EventHandler(this.Bilgisayar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBilgisayarSayiTahmin;
        private System.Windows.Forms.Button btndogru;
        private System.Windows.Forms.Button btnynls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYnlsSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDgrSayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnarti;
        private System.Windows.Forms.Button btneksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDenemeSayisi;
    }
}