using OOP3;


ICradyManager konutkrediManager = new KunutKrediManager();
ICradyManager tasitkrediManager = new TasitKrediMangager();
ICradyManager ihtiyacKrediManager = new IhtiyacKrediManager();

ILoggerService dataLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>() { dataLoggerService, fileLoggerService, smsLoggerService });

List<ICradyManager> krediler = new List<ICradyManager>() { konutkrediManager, tasitkrediManager };
//basvuruManager.KrediOnbilgi(krediler);

