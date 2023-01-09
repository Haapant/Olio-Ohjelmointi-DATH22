using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class ajoneuvo
    {
        public string Merkki;
        public int Nopeus;
        public int Renkaat;

        public ajoneuvo(string merkki, int nopeus, int renkaat)
        {
            Merkki = merkki;
            Nopeus = nopeus;
            Renkaat = renkaat;
        }

        public void TulostaData()
        {
            Console.WriteLine("auton merkki on" + Merkki);
            Console.WriteLine("auton nopeus on" + Nopeus);
            Console.WriteLine("autossa on renkaita" + Renkaat);
        }

    }
}
