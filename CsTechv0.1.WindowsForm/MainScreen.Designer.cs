
namespace CsTechv0._1.WindowsForm
{
    partial class MainScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merhabalar, Hoşgeldiniz ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siz Bilgisayarın Sayısını Bilin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bilgisayar Sizin Sayınızı Bilsin.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "- İyi eğlenceler dileriz.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(643, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "- Bilgisayarın tahmin etmesi gereken sayi bulunurken sizden doğru ve yanliş basam" +
    "ak sayisini girmeniz istenecektir.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(602, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "- Bilgisayarın tuttuğu sayi için deneme yapılırken bilgisayar size doğru ve yanlı" +
    "ş basamak sayisini verecektir.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = " sayiyi bulacaktır.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(730, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "- Bilgisayara karşı oyunu oynarken bilgisayarın tuttuğu sayi bulunmaya çalışılaca" +
    "k olup, ikinci seçenekte bilgisayar sizin tuttuğunuz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "- Her iki oyun seçeneği içinde rakamları farklı 4 basamaklı bir sayi seçilecektir" +
    ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(263, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oyunun Kuralları";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}