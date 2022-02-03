using System;
using System.Collections.Generic;
using System.Text;

namespace TV_Store
{
    public class TV
    {
        public string Proizvoditel { get; set; }

        public int Resolucija { get; set; }

        public int Prodazbi { get; set; }

        public TV() { }


        public TV(string proizvoditel, int resolucija)
        {
            Proizvoditel = proizvoditel;
            Resolucija = resolucija;
            Prodazbi = 0;
            

        }
        public override string ToString()
        {
            return string.Format("{0}, Resolution:{1}", Proizvoditel, Resolucija);
        }

    }
}
