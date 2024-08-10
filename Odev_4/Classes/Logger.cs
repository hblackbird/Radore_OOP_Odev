using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4.Classes
{
    public class Logger
    {
        public ILog iLog;

        public Logger(ILog iLog)
        {
            this.iLog = iLog;
        }
        public void LogKaydet(string mesaj)
        {
            iLog.Log(mesaj);
        }
    }
}
