using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {       //polyphorphism
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //instance
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService()});
            //basvuruManager.BasvuruYap(konutKrediManager,new DataBaseLoggerService()); de diyebilirdik.
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
