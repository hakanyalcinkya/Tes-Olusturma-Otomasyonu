using AdoNetHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOlusturmaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string baglantiCumlesi = @"Server={*}; Database=TestHazirlamaOtoDB;User Id=sa; Password={*}";

        private void GetDataTest()
        {
            Database db = new Database(baglantiCumlesi);

            DataTable sonucTablo = db.GetTable("select * from Test", null);

            foreach (DataRow row in sonucTablo.Rows)
            {
                Testler test = new Testler();

                test.Id = (int)row["Id"];
                test.TestName = row["Name"].ToString();
                test.BaslamaTarihi = (DateTime)row["BaslamaTarihi"];
                test.Bitistarihi = (DateTime)row["BitisTarihi"];
                test.OgretmenAdi = row["OgretmenAdi"].ToString();
                test.SoruSayisi = (int)row["SoruAdeti"];

                cmbTestler.Items.Add(test);
            }
        }
        private void GetDataSorular()
        {
            
            Database db = new Database(baglantiCumlesi);
            DataTable sonucSorularTablosu = db.GetTable("select * from Sorular", null);

            foreach (DataRow row in sonucSorularTablosu.Rows)
            {
                Sorular soru = new Sorular();

                soru.Id = (int)row["Id"];
                soru.Soru = row["Soru"].ToString();
                soru.CevapA = row["CevapA"].ToString();
                soru.CevapB = row["CevapB"].ToString();
                soru.CevapC = row["CevapC"].ToString();
                soru.CevapD = row["CevapD"].ToString();
                soru.Cevap = row["Cevap"].ToString();
                soru.TestId = (int)row["TestId"];
                //int index = lstSeciliTestSoruları.Items.Count + 1;
                //"Soru"+index+
                lstSeciliTestSoruları.Items.Add(soru);

            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "insert into Sorular(Soru, CevapA, CevapB,CevapC,CevapD,Cevap,TestId) values(@Soru,@CevapA,@CevapB,@CevapC,@CevapD,@Cevap,@TestId)";

            List<SqlParameter> par = new List<SqlParameter>();
            Testler seciliTest = cmbTestler.SelectedItem as Testler;
            par.Add(new SqlParameter("@TestId", seciliTest.Id));
            par.Add(new SqlParameter("@Soru", txtSoru.Text));
            par.Add(new SqlParameter("@CevapA", txtCevapA.Text));
            par.Add(new SqlParameter("@CevapB", txtCevapB.Text));
            par.Add(new SqlParameter("@CevapC", txtCevapC.Text));
            par.Add(new SqlParameter("@CevapD", txtCevapD.Text));
            par.Add(new SqlParameter("@Cevap", cmbCevaplar.SelectedItem));

            db.RunQuery(q, par);

            MessageBox.Show("Soru Kaydedildi...");
            GetDataSorular();

        }

        private void tsmTestGirisi_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void tsmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataTest();

        }
        
        private void cmbTestler_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstSeciliTestSoruları.Items.Clear();
            if (cmbTestler.SelectedIndex > -1)
            {
                GetDataSorular();
                lblSoru.Text = "";
                rdbCevapA.Text ="";
                rdbCevapB.Text ="";
                rdbCevapC.Text ="";
                rdbCevapD.Text = "";
            }
        }
       
         
        
        private int index = 0;
        private void btnCevapla_Click(object sender, EventArgs e)
        {
            Sorular seciliSoru = lstSeciliTestSoruları.Items[index] as Sorular;




            if (rdbCevapA.Checked == true)
            {
                if (seciliSoru.Cevap == "A")
                {
                    MessageBox.Show("Soruyu doğru cevapladınız. Tebrikler !");
                }
                else
                {
                    MessageBox.Show("Soruyu yanlış cevapladınız. Üzgünüm !");
                }
            }
            else if (rdbCevapB.Checked == true)
            {
                if (seciliSoru.Cevap == "B")
                {
                    MessageBox.Show("Soruyu doğru cevapladınız. Tebrikler !");

                }
                else
                {
                    MessageBox.Show("Soruyu yanlış cevapladınız. Üzgünüm !");
                }
            }
            else if (rdbCevapC.Checked == true)
            {
                if (seciliSoru.Cevap == "C")
                {
                    MessageBox.Show("Soruyu doğru cevapladınız. Tebrikler !");
                }
                else
                {
                    MessageBox.Show("Soruyu yanlış cevapladınız. Üzgünüm !");
                }
            }
            else if (rdbCevapD.Checked == true)
            {
                if (seciliSoru.Cevap == "D")
                {
                    MessageBox.Show("Soruyu doğru cevapladınız. Tebrikler !");
                }
                else
                {
                    MessageBox.Show("Soruyu yanlış cevapladınız. Üzgünüm !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir cevap seçiniz...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTestler.Text!="")
            {
                Sorular seciliSoru = lstSeciliTestSoruları.Items[0] as Sorular;
                lblSoru.Text = "Soru :"+seciliSoru.Soru;
                rdbCevapA.Text ="A-"+ seciliSoru.CevapA;
                rdbCevapB.Text ="B-"+ seciliSoru.CevapB;
                rdbCevapC.Text ="C-"+ seciliSoru.CevapC;
                rdbCevapD.Text = "D-"+seciliSoru.CevapD;
            }
            else
            {
                MessageBox.Show("Lütfen bir test seciniz...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Testler test = cmbTestler.SelectedItem as Testler;
            int sayi = test.SoruSayisi - 1;
            if (index<sayi)
            {
                index++;
                Sorular seciliSoru = lstSeciliTestSoruları.Items[index] as Sorular;

                lblSoru.Text = "Soru :"+seciliSoru.Soru;
                rdbCevapA.Text = "A-"+seciliSoru.CevapA;
                rdbCevapB.Text = "B-"+seciliSoru.CevapB;
                rdbCevapC.Text = "C-"+seciliSoru.CevapC;
                rdbCevapD.Text ="D-"+ seciliSoru.CevapD;
            }

            else
            {
                MessageBox.Show("Testiniz bitmiştir.");
            }

            rdbCevapA.Checked = false;
            rdbCevapB.Checked = false;
            rdbCevapC.Checked = false;
            rdbCevapD.Checked = false;
        }
    }
}
