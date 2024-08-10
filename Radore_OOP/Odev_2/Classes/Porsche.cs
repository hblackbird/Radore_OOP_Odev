using Radore_OOP.Odev_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odev_2.Classes
{
    public class Porsche : Araba, IHizli
    {
        public override double yakitTuketimi => 80.0;

        public void hizli()
        {
            Console.WriteLine("Porsche çok hızlı gidiyor");
        }
    }
}
