using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, opiskelija> dic = new Dictionary<string, opiskelija>();
            opiskelija pekka = new opiskelija("pekka", "jaakkola", 999, "datanomi");
            opiskelija pertti = new opiskelija("pertti", "mikkola", 333, "datanomi");
            opiskelija jukka = new opiskelija("jukka", "haapala", 945, "datanomi");

            dic.Add(pekka.opiskelijaId, pekka);
            dic.Add(pertti.opiskelijaId, pertti);
            dic.Add(jukka.opiskelijaId, jukka);
        }
    }
}
