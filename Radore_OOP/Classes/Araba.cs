﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Classes
{
    public class Araba
    {
        public string marka;
        public string model;
        public int kapiSayisi;
        public int pencereSayisi;

        public void Git(string markasi,string modeli)
        {
            Console.WriteLine(markasi +" "+modeli +" gidiyor");
        }
    }
}
