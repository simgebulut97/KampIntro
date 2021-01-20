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
            Console.WriteLine(musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.MusteriDogumYili + musteri.MusteriEmail);
        }
}
