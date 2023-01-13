using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus11
{
    internal class opiskelija
    {
        public string etunimi;
        public string sukunimi;
        public int ryhmätunnus;
        public string opiskelijaId;

        public opiskelija(string etunimi, string sukunimi, int ryhmätunnus, string opiskelijaId)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.ryhmätunnus = ryhmätunnus;
            this.opiskelijaId = opiskelijaId;
        }
        public void TulostaData()
        {
            Console.WriteLine("Etunimi" + etunimi, "Sukunimi" + sukunimi, "Ryhmätunnus" + ryhmätunnus, "OpiskelijaID" + opiskelijaId);
        }
    }
}

      