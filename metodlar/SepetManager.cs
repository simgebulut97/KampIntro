using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    class SepetManager
    {
        //naming convention E büyük
        public void Ekle(Urun urun) 
        {

            Console.WriteLine("Sepete eklendi." + urun.Adi);

        }
        public void Ekle2(string urunAdi, string Aciklama, double fiyat)
        {
            Console.WriteLine("Sepete eklendi." + urun.Adi);
        }
    }
}
