namespace TestOlusturmaOtomasyonu
{
    partial class Form2
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
            this.txtTestAdi = new System.Windows.Forms.TextBox();
            this.txtOgretmenAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnTestEkle = new System.Windows.Forms.Button();
            this.nudSoruSayisi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoruSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Adı";
            // 
            // txtTestAdi
            // 
            this.txtTestAdi.Location = new System.Drawing.Point(91, 27);
            this.txtTestAdi.Name = "txtTestAdi";
            this.txtTestAdi.Size = new System.Drawing.Size(161, 20);
            this.txtTestAdi.TabIndex = 1;
            // 
            // txtOgretmenAdi
            // 
            this.txtOgretmenAdi.Location = new System.Drawing.Point(91, 133);
            this.txtOgretmenAdi.Name = "txtOgretmenAdi";
            this.txtOgretmenAdi.Size = new System.Drawing.Size(161, 20);
            this.txtOgretmenAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretmen Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Başlama Tarihi";
            // 
            // dtpBaslamaTarihi
            // 
            this.dtpBaslamaTarihi.Location = new System.Drawing.Point(91, 60);
            this.dtpBaslamaTarihi.Name = "dtpBaslamaTarihi";
            this.dtpBaslamaTarihi.Size = new System.Drawing.Size(161, 20);
            this.dtpBaslamaTarihi.TabIndex = 7;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(91, 97);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(161, 20);
            this.dtpBitisTarihi.TabIndex = 8;
            // 
            // btnTestEkle
            // 
            this.btnTestEkle.Location = new System.Drawing.Point(177, 204);
            this.btnTestEkle.Name = "btnTestEkle";
            this.btnTestEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTestEkle.TabIndex = 9;
            this.btnTestEkle.Text = "Ekle";
            this.btnTestEkle.UseVisualStyleBackColor = true;
            this.btnTestEkle.Click += new System.EventHandler(this.btnTestEkle_Click);
            // 
            // nudSoruSayisi
            // 
            this.nudSoruSayisi.Location = new System.Drawing.Point(91, 168);
            this.nudSoruSayisi.Name = "nudSoruSayisi";
            this.nudSoruSayisi.Size = new System.Drawing.Size(161, 20);
            this.nudSoruSayisi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soru sayısı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudSoruSayisi);
            this.Controls.Add(this.btnTestEkle);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslamaTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgretmenAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTestAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoruSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestAdi;
        private System.Windows.Forms.TextBox txtOgretmenAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBaslamaTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Button btnTestEkle;
        private System.Windows.Forms.NumericUpDown nudSoruSayisi;
        private System.Windows.Forms.Label label5;
    }
}