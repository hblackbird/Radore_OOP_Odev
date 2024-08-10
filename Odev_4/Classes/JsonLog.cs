using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4.Classes
{
    public class JsonLog : ILog
    {
        public string Log(string message)
        {
            return "XmlLog" + message;
        }
    }
}
