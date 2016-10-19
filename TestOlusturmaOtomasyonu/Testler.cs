using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOlusturmaOtomasyonu
{
    public class Testler
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime Bitistarihi { get; set; }
        public int SoruSayisi { get; set; }
        public string OgretmenAdi { get; set; }

        public override string ToString()
        {
            return TestName;
        }
    }
}
