using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.solid.iyi
{
    public class XmlLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("XML Log: " + message);
        }
    }
}
