using System;

namespace ClassMetotDemo
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
            Musteri2.MusteriSoyadi = "Genç";
            Musteri2.MusteriDogumYili = 1985;
            Musteri2.MusteriEmail = "ali@hotmail.com";

            Musteri Musteri3 = new Musteri();
            Musteri3.MusteriAdi = "Sinan";
            Musteri3.MusteriSoyadi = "Dinc";
            Musteri3.MusteriDogumYili = 1978;
            Musteri3.MusteriEmail = "sinan@hotmail.com";

            Musteri[] musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriDogumYili);
                Console.WriteLine(musteri.MusteriEmail);

            }
            MusteriManager musteriManager = new MusteriManager() ;

            MusteriManager.Ekle(Musteri1);




        }
    }
}
