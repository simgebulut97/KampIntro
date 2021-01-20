using ClassMetotDemo;
using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.MusteriAdi = "Simge";
            Musteri1.MusteriSoyadi = "Bulut";
            Musteri1.MusteriDogumYili = 1997;
            Musteri1.MusteriEmail = "simge@hotmail.com";

            Musteri Musteri2 = new Musteri();
            Musteri2.MusteriAdi = "Ali";
            Musteri2.MusteriSoyadi = "Genc";
            Musteri2.MusteriDogumYili = 1985;
            Musteri2.MusteriEmail = "ali@hotmail.com";

            Musteri Musteri3 = new Musteri();
            Musteri3.MusteriAdi = "Sinan";
            Musteri3.MusteriSoyadi = "Dinc";
            Musteri3.MusteriDogumYili = 1978;
            Musteri3.MusteriEmail = "sinan@hotmail.com";

            Musteri[] musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3 };


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(Musteri1);
            musteriManager.Ekle(Musteri2);
            musteriManager.Ekle(Musteri3);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(Musteri3);




        }
    }
}