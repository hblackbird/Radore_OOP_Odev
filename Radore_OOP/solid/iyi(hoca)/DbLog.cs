﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.solid.iyi_hoca_
{
    public class DbLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine("DbLog" + message);
        }
    }
}
