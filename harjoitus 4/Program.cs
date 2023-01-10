using harjoitus_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi("Evolve", "imagine dragon", "pop rock");
            albumi.LisääKappale(new kappale("next to me", "3,50"));
            albumi.LisääKappale(new kappale("what ever it takes", "3,10"));
            albumi.LisääKappale(new kappale("beliver", "3,21"));
            albumi.LisääKappale(new kappale("thunder", "3,24"));
            albumi.LisääKappale(new kappale("i dont know why", "3,07"));
            albumi.TulostaTiedot();
        }
    }
}
