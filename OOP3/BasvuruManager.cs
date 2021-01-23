using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (ILoggerService LoggerService in loggerService)
            {
                LoggerService.Log();
            }
            


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
