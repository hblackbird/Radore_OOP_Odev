﻿using Radore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Classes
{
    //Anne class ı Insan Class ından türemiştir
    //Anne classı Insan clas ındaki public olan tüm değişkenlere
    //ve metodlarada da erişebilir 
    public class Anne : Insan,IOku,IYaz
    {
        public void oku(string isim)
        {
            Console.WriteLine(isim + " okuyor...");
        }

        public void yaz(string isim)
        {
            Console.WriteLine(isim + " yazıyor...");
        }
    }
}
