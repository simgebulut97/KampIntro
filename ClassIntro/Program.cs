using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Simge";
            int yas =23;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demirog";
            kurs1.KursunIzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.KursunEgitmeni = "aa";
            kurs2.KursunIzlenmeOrani = 95;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C";
            kurs3.KursunEgitmeni = "bb";
            kurs3.KursunIzlenmeOrani = 108;

            Kurs[] kurslar = new Kurs[] {kurs1 ,kurs2 ,kurs3  };

            foreach (Kurs kurs in kurslar)
            { 
                Console.WriteLine(kurs.KursAdi+ " : " + kurs.KursunEgitmeni);
                
            }
          
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int KursunIzlenmeOrani { get; set; }
    }
}
