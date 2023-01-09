using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira();
            koira1.Ikä = 2;
            koira1.Nimi = "Rekku";
            koira1.Rotu = "Mopsi";
            Console.WriteLine("Koiran nimi on" + koira1.Nimi);
            Console.WriteLine("Koiran ikä on"+ koira1.Ikä);
            Console.WriteLine("Koiran rotu on"+ koira1.Rotu);

            koira1.HaeTiedosto();
            koira koira2 = new koira();
            koira2.Nimi = "Ali";
            koira2.Ikä = 50;
            koira2.Rotu = "Orja";

            koira2.HaeTiedosto();

            koira1.Hauku();
            koira2.Hauku();
        }
    }
}