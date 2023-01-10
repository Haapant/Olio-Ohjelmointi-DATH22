using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_4
{
    internal class kappale
    {
        public string nimi;
        public string kesto;

        public kappale(string nimi, string kesto)
        {
            this.nimi = nimi;
            this.kesto = kesto;
        }
        public void TulostaTiedot()
        {
            Console.WriteLine("---Nimi:"+ nimi + "-"+ kesto);
        }
    }
}
