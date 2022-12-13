using System.Collections.Generic;


namespace OOP3
{

    public class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService(); 
            
            BasvuruManager basvuruManager= new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DataBaseLoggerService());


            List<IKrediManager> krediler= new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }




    }



}