using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
       public string Nimi { get; set; }
       public string OpiskelijaId { get; set; }
       public string Opintopisteet { get; set; }

        public string HaeTiedot()
        {
            return Nimi + "Opiskelijan Id on" + OpiskelijaId + "Opiskelijalla on opintopisteitä " + Opintopisteet;
        }

    }
}
