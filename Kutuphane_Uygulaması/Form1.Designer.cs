namespace Kutuphane_Uygulaması
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapad = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.btnIade = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogEkrani = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(75, 67);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(215, 22);
            this.txtYazar.TabIndex = 4;
            // 
            // txtKitapad
            // 
            this.txtKitapad.Location = new System.Drawing.Point(75, 38);
            this.txtKitapad.Name = "txtKitapad";
            this.txtKitapad.Size = new System.Drawing.Size(215, 22);
            this.txtKitapad.TabIndex = 5;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(75, 97);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(215, 22);
            this.txtIsbn.TabIndex = 6;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(6, 130);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(87, 37);
            this.btnKitapEkle.TabIndex = 7;
            this.btnKitapEkle.Text = "EKLE";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnKitapEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKitapad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOgrNo);
            this.groupBox2.Controls.Add(this.txtOgrAd);
            this.groupBox2.Controls.Add(this.btnOgrenciEkle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 148);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Ekleme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Öğrenci Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci No:";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(6, 100);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(87, 37);
            this.btnOgrenciEkle.TabIndex = 10;
            this.btnOgrenciEkle.Text = "EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(92, 32);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(198, 22);
            this.txtOgrAd.TabIndex = 10;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(90, 61);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(200, 22);
            this.txtOgrNo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kütüphanedeki Kitaplar";
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 16;
            this.lstKitaplar.Location = new System.Drawing.Point(353, 44);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(141, 148);
            this.lstKitaplar.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kayıtlı Öğrenciler";
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.ItemHeight = 16;
            this.lstOgrenciler.Location = new System.Drawing.Point(353, 243);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(141, 116);
            this.lstOgrenciler.TabIndex = 13;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Location = new System.Drawing.Point(527, 44);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(182, 54);
            this.btnOduncVer.TabIndex = 14;
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.UseVisualStyleBackColor = true;
            // 
            // btnIade
            // 
            this.btnIade.Location = new System.Drawing.Point(527, 112);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(182, 54);
            this.btnIade.TabIndex = 15;
            this.btnIade.Text = "İade Al";
            this.btnIade.UseVisualStyleBackColor = true;
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(527, 183);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(182, 54);
            this.btnSirala.TabIndex = 16;
            this.btnSirala.Text = "En Çok Okunanları Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sistem Logları";
            // 
            // txtLogEkrani
            // 
            this.txtLogEkrani.Location = new System.Drawing.Point(528, 275);
            this.txtLogEkrani.Multiline = true;
            this.txtLogEkrani.Name = "txtLogEkrani";
            this.txtLogEkrani.ReadOnly = true;
            this.txtLogEkrani.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogEkrani.Size = new System.Drawing.Size(100, 22);
            this.txtLogEkrani.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLogEkrani);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.btnOduncVer);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Takip Sistemi - Mustafa Said ERKAYIRAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapad;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogEkrani;
    }
}

