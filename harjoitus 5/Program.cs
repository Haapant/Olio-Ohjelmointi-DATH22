using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Laskin.Summa(2, 8));
            Console.WriteLine(Laskin.Erotus(5,2));
            Console.WriteLine(Laskin.Kertolasku(6,2));
            Console.WriteLine(Laskin.Jakolasku(4,8));

        }
    }
}
