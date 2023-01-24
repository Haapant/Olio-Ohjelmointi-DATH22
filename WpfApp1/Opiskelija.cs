using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Opiskelija
    {
        public string Nimi { get; set; }
        public string OpiskelijaId { get; set; }
        public int Opintopisteet { get; set; }

        public string HaeTiedot()
        {
            return Nimi + "Opiskelijan Id on" + OpiskelijaId + "Opiskelijalla on opintopisteitä " + Opintopisteet;
        }
    }
}
