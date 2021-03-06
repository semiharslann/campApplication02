﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            /*
             * new EsnafKrediManager()
             * veya
             * EsnafKrediManager esnafKrediManager = new EsnafKrediManager();    olarak yapılabilir.
            */

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap( new EsnafKrediManager(), new List<ILoggerService> { databaseLoggerService, new SmsLoggerService() });
            
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
