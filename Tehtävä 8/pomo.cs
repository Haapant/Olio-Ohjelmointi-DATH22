using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Pomo 
    {
        private static Pomo instance = null;
        public decimal Bonus { get; set; }
        public string Car { get; set; }
        private Pomo(string name, string job, decimal salary) : base(name, job, salary) { }

        public static Pomo getInstance(string name, string job, decimal salary)
        {
            if (instance == null)
                instance = new Pomo(name, job, salary);
            return instance;
        }
    }
}