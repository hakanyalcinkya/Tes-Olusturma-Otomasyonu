namespace TestOlusturmaOtomasyonu
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
            this.cmbTestler = new System.Windows.Forms.ComboBox();
            this.lstSeciliTestSoruları = new System.Windows.Forms.ListBox();
            this.lblSoru = new System.Windows.Forms.Label();
            this.rdbCevapC = new System.Windows.Forms.RadioButton();
            this.rdbCevapD = new System.Windows.Forms.RadioButton();
            this.rdbCevapB = new System.Windows.Forms.RadioButton();
            this.rdbCevapA = new System.Windows.Forms.RadioButton();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.cmbCevaplar = new System.Windows.Forms.ComboBox();
            this.txtCevapA = new System.Windows.Forms.TextBox();
            this.txtCevapD = new System.Windows.Forms.TextBox();
            this.txtCevapC = new System.Windows.Forms.TextBox();
            this.txtCevapB = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTestGirisi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTestler
            // 
            this.cmbTestler.FormattingEnabled = true;
            this.cmbTestler.Location = new System.Drawing.Point(5, 34);
            this.cmbTestler.Name = "cmbTestler";
            this.cmbTestler.Size = new System.Drawing.Size(153, 21);
            this.cmbTestler.TabIndex = 0;
            this.cmbTestler.SelectedIndexChanged += new System.EventHandler(this.cmbTestler_SelectedIndexChanged);
            // 
            // lstSeciliTestSoruları
            // 
            this.lstSeciliTestSoruları.FormattingEnabled = true;
            this.lstSeciliTestSoruları.Location = new System.Drawing.Point(5, 70);
            this.lstSeciliTestSoruları.Name = "lstSeciliTestSoruları";
            this.lstSeciliTestSoruları.Size = new System.Drawing.Size(153, 212);
            this.lstSeciliTestSoruları.TabIndex = 1;
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(174, 74);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(0, 13);
            this.lblSoru.TabIndex = 3;
            this.lblSoru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbCevapC
            // 
            this.rdbCevapC.AutoSize = true;
            this.rdbCevapC.Location = new System.Drawing.Point(177, 182);
            this.rdbCevapC.Name = "rdbCevapC";
            this.rdbCevapC.Size = new System.Drawing.Size(14, 13);
            this.rdbCevapC.TabIndex = 4;
            this.rdbCevapC.TabStop = true;
            this.rdbCevapC.UseVisualStyleBackColor = true;
            // 
            // rdbCevapD
            // 
            this.rdbCevapD.AutoSize = true;
            this.rdbCevapD.Location = new System.Drawing.Point(177, 221);
            this.rdbCevapD.Name = "rdbCevapD";
            this.rdbCevapD.Size = new System.Drawing.Size(14, 13);
            this.rdbCevapD.TabIndex = 5;
            this.rdbCevapD.TabStop = true;
            this.rdbCevapD.UseVisualStyleBackColor = true;
            // 
            // rdbCevapB
            // 
            this.rdbCevapB.AutoSize = true;
            this.rdbCevapB.Location = new System.Drawing.Point(177, 140);
            this.rdbCevapB.Name = "rdbCevapB";
            this.rdbCevapB.Size = new System.Drawing.Size(14, 13);
            this.rdbCevapB.TabIndex = 6;
            this.rdbCevapB.TabStop = true;
            this.rdbCevapB.UseVisualStyleBackColor = true;
            // 
            // rdbCevapA
            // 
            this.rdbCevapA.AutoSize = true;
            this.rdbCevapA.Location = new System.Drawing.Point(177, 95);
            this.rdbCevapA.Name = "rdbCevapA";
            this.rdbCevapA.Size = new System.Drawing.Size(14, 13);
            this.rdbCevapA.TabIndex = 7;
            this.rdbCevapA.TabStop = true;
            this.rdbCevapA.UseVisualStyleBackColor = true;
            // 
            // btnCevapla
            // 
            this.btnCevapla.Location = new System.Drawing.Point(226, 250);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(54, 35);
            this.btnCevapla.TabIndex = 8;
            this.btnCevapla.Text = "Cevapla";
            this.btnCevapla.UseVisualStyleBackColor = true;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click);
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(363, 34);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(153, 37);
            this.txtSoru.TabIndex = 9;
            // 
            // cmbCevaplar
            // 
            this.cmbCevaplar.FormattingEnabled = true;
            this.cmbCevaplar.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbCevaplar.Location = new System.Drawing.Point(363, 95);
            this.cmbCevaplar.Name = "cmbCevaplar";
            this.cmbCevaplar.Size = new System.Drawing.Size(153, 21);
            this.cmbCevaplar.TabIndex = 10;
            // 
            // txtCevapA
            // 
            this.txtCevapA.Location = new System.Drawing.Point(363, 137);
            this.txtCevapA.Name = "txtCevapA";
            this.txtCevapA.Size = new System.Drawing.Size(153, 20);
            this.txtCevapA.TabIndex = 12;
            // 
            // txtCevapD
            // 
            this.txtCevapD.Location = new System.Drawing.Point(363, 215);
            this.txtCevapD.Name = "txtCevapD";
            this.txtCevapD.Size = new System.Drawing.Size(153, 20);
            this.txtCevapD.TabIndex = 13;
            // 
            // txtCevapC
            // 
            this.txtCevapC.Location = new System.Drawing.Point(363, 189);
            this.txtCevapC.Name = "txtCevapC";
            this.txtCevapC.Size = new System.Drawing.Size(153, 20);
            this.txtCevapC.TabIndex = 14;
            // 
            // txtCevapB
            // 
            this.txtCevapB.Location = new System.Drawing.Point(363, 163);
            this.txtCevapB.Name = "txtCevapB";
            this.txtCevapB.Size = new System.Drawing.Size(153, 20);
            this.txtCevapB.TabIndex = 15;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(444, 259);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(363, 259);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTestGirisi,
            this.tsmCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTestGirisi
            // 
            this.tsmTestGirisi.Name = "tsmTestGirisi";
            this.tsmTestGirisi.Size = new System.Drawing.Size(69, 20);
            this.tsmTestGirisi.Text = "Test Girisi";
            this.tsmTestGirisi.Click += new System.EventHandler(this.tsmTestGirisi_Click);
            // 
            // tsmCikis
            // 
            this.tsmCikis.Name = "tsmCikis";
            this.tsmCikis.Size = new System.Drawing.Size(44, 20);
            this.tsmCikis.Text = "Çıkış";
            this.tsmCikis.Click += new System.EventHandler(this.tsmCikis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Teste Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtCevapB);
            this.Controls.Add(this.txtCevapC);
            this.Controls.Add(this.txtCevapD);
            this.Controls.Add(this.txtCevapA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCevaplar);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.rdbCevapA);
            this.Controls.Add(this.rdbCevapB);
            this.Controls.Add(this.rdbCevapD);
            this.Controls.Add(this.rdbCevapC);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.lstSeciliTestSoruları);
            this.Controls.Add(this.cmbTestler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTestler;
        private System.Windows.Forms.ListBox lstSeciliTestSoruları;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.RadioButton rdbCevapC;
        private System.Windows.Forms.RadioButton rdbCevapD;
        private System.Windows.Forms.RadioButton rdbCevapB;
        private System.Windows.Forms.RadioButton rdbCevapA;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.ComboBox cmbCevaplar;
        private System.Windows.Forms.TextBox txtCevapA;
        private System.Windows.Forms.TextBox txtCevapD;
        private System.Windows.Forms.TextBox txtCevapC;
        private System.Windows.Forms.TextBox txtCevapB;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmTestGirisi;
        private System.Windows.Forms.ToolStripMenuItem tsmCikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

