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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        string baglantiCumlesi = @"Server={*}; Database=TestHazirlamaOtoDB;User Id=sa; Password={*}";


       
        private void btnTestEkle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);

            string q = "insert into Test(Name,BaslamaTarihi,BitisTarihi,OgretmenAdi,SoruAdeti) values(@Name,@BaslamaTarihi,@BitisTarihi,@OgretmenAdi,@SoruAdeti)";
            List<SqlParameter> par = new List<SqlParameter>();

            par.Add(new SqlParameter("@Name",txtTestAdi.Text));
            par.Add(new SqlParameter("@BaslamaTarihi",dtpBaslamaTarihi.Value));
            par.Add(new SqlParameter("@BitisTarihi",dtpBitisTarihi.Value));
            par.Add(new SqlParameter("@OgretmenAdi",txtOgretmenAdi.Text));
            par.Add(new SqlParameter("@SoruAdeti",nudSoruSayisi.Value));

            db.RunQuery(q, par);
            MessageBox.Show("Test Kaydedildi.. ");

        }
    }
}
