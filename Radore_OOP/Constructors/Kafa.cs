using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Constructors
{
    public  class Kafa
    {
        //compositon
        public Goz goz;
        public Kulak kulak;
        public Burun burun;

        public string gozRengi;
        public string kulakSekil;
        public string burunTipi;


        public Kafa( string gozRengi,string retina,int gozGenislik,int gozYukseklik, string kulakSekil, string burunTipi)
        {
            this.gozRengi = gozRengi;
            this.kulakSekil = kulakSekil;
            this.burunTipi = burunTipi;
        }

        public Kafa(Goz goz, Kulak kulak, Burun burun)
        {
            this.goz = goz;
            this.kulak = kulak;
            this.burun = burun;
        }   
    }
}
