using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus2
{
    internal class Opiskelija
    {
        private string Nimi;
        private string Id;
        private int Opintopisteet;

        public Opiskelija(string nimi, string id, int opintopisteet)
        {
            Nimi = nimi;
            Id = id;
            Opintopisteet = opintopisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Opintopisteet: " + Opintopisteet);

        }

        public void MuokkaaOpintopisteitä(int i)
        {
            Opintopisteet = i;
        }
    }
}
