using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Opiskelija> list = new List<Opiskelija>();
            Opiskelija opiskelija0 = new Opiskelija("Elias", "Datanomi", 15);
            opiskelija0.MuokkaaOpintopisteitä(20);

            Opiskelija opiskelija1 = new Opiskelija("Ali", "Datanomi", 5);
            Opiskelija opiskelija2 = new Opiskelija("Datanom", "Datanomi", 45);
            Opiskelija opiskelija3 = new Opiskelija("Maito", "Datanomi", 25);

            list.Add(opiskelija0);
            list.Add(opiskelija1);
            list.Add(opiskelija2);
            list.Add(opiskelija3);

            foreach (Opiskelija opiskelija in list)
            {
                opiskelija.TulostaData();
                Console.WriteLine("");
            }
        }
    }
}
