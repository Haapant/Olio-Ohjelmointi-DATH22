using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ajoneuvo auto1 = new ajoneuvo("volvo", 1200, 3);
            auto1.TulostaData();
        }
        
    }
}
