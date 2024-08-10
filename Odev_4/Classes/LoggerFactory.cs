using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4.Classes
{
    public class LoggerFactory
    {
        public static ILog LoglamaYontemi(string yontem)
        {
            var newInstance = Assembly.GetAssembly(typeof(ILog)).CreateInstance("Odev_4.Classes." + yontem);
            return (ILog)newInstance;
        }
    }
}
