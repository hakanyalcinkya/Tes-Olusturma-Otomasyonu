using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOlusturmaOtomasyonu
{
    public class Sorular
    {
        public int Id { get; set; }
        public string Soru { get; set; }
        public string CevapA { get; set; }
        public string CevapB { get; set; }
        public string CevapC { get; set; }
        public string CevapD { get; set; }
        public string Cevap { get; set; }
        public int TestId { get; set; }

        public override string ToString()
        {
            return Soru;
        }
    }
}
