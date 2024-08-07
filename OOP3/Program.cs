// See https://aka.ms/new-console-template for more information

using OOP3;

IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();


TasitKrediManager tasitKrediManager = new TasitKrediManager();


KonutKrediManager konutKrediManager = new KonutKrediManager();


IKrediManager konutKrediManager2 = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ıhtiyacKrediManager, new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService()});

List<IKrediManager> krediler = new List<IKrediManager>()
{ tasitKrediManager, ıhtiyacKrediManager};
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);