using Radore_OOP.Odev_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odev_2.Classes
{
    public class Bmw : Araba,IUcma, IYuzme, IHizli
    {
        public override double yakitTuketimi => 60.0;

        public void hizli()
        {
            Console.WriteLine("Bmw çok hızlı gidiyor");
        }

        public void ucuyor()
        {
            Console.WriteLine("Bmw havada ucuyor");
        }

        public void yuzuyor()
        {
            Console.WriteLine("Bmw denizde gidiyor");
        }
    }
}
