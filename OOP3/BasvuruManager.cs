using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager
    {
        public void BasvuruYap(ICradyManager cradyManager, List<ILoggerService> loggerServices)
        {            
            cradyManager.Calculate();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }
        }

        public void KrediOnbilgi(List<ICradyManager> krediler)
        {
            foreach (var kredi in krediler) 
            {
                kredi.Calculate();
            }
        }
    }
}
