using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_4
{
    internal class Albumi
    {

        public string albuminNimi;
        public string artisti;
        public string genre;
        private List<kappale> kappaleet = new List<kappale>();

        public Albumi(string albuminNimi, string artisti, string genre)
        {
            this.albuminNimi = albuminNimi;
            this.artisti = artisti;
            this.genre = genre;
        }

        public void LisääKappale(kappale uusikappale)
        {
            kappaleet.Add(uusikappale);
        }
        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("albumi");
            Console.WriteLine(" -artisti:" + artisti);
            Console.WriteLine(" -albumin nimi:" + albuminNimi);
            Console.WriteLine(" -genre:" + genre);
            Console.WriteLine("songs:");
            foreach (kappale kappale in kappaleet)
            {
                kappale.TulostaTiedot();
            }
        }
    }
}

