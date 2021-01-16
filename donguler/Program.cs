using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampı";
            string kurs2 = "Programlamaya baslangic temel kurs";
            string kurs3 = "Java";

            //array - dizi
            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampı", "Programlamaya baslangic temel kurs", "Java" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
               
            }
            //dizi temelli yapıları tek tek dönmeye yarıyor
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
