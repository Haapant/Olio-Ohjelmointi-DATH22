﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_4
{
    static class StaattinenLuokka
    {
        public static void StaattinenMetodi()
        {
            Console.WriteLine("Tämä on staattinen metodi");
        }
        public static float KmToMiles(float km)
        {
            float conversionRate = 0,62137f;
            return km * conversionRate;
        }
    }
}