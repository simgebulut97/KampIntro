using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri listeye eklendi.");
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri listeye eklendi.");
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
        
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Listele\n/////////////////////\n");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
            }
        }
        public void Sil(Musteri musteri)
        {

            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + "Adlı musteri silindi.");

        }
#pragma warning disable CS1513 // } bekleniyor
    }
#pragma warning restore CS1513 // } bekleniyor
}