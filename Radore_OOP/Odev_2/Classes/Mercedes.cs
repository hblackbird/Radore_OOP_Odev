using Radore_OOP.Odev_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odev_2.Classes
{
    public class Mercedes : Araba, IUcma, IYuzme
    {
        public override double yakitTuketimi => 70.0;

        public void ucuyor()
        {
            Console.WriteLine("Mercedes havada ucuyor");
        }

        public void yuzuyor()
        {
            Console.WriteLine("Mercedes denizde yuzuyor");
        }
    }
}
