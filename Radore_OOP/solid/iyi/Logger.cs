using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.solid.iyi
{
    public class Logger
    {
        private readonly Dictionary<LogType, ILogger> _loglar;

        public Logger(Dictionary<LogType, ILogger> loglar)
        {
            _loglar = loglar;
        }

        public void logKaydet(LogType logType, string mesaj)
        {
            if(_loglar.ContainsKey(logType))
            {
                _loglar[logType].Log(mesaj);
            }
            else
            {
                Console.WriteLine("Unsupported log type");
            }
        }
    }
}
