using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Boss : Person
    {
        private static Boss instance = null;
        public decimal Bonus { get; set; }
        public string Car { get; set; }
        private Boss(string name, string job, decimal salary) : base(name, job, salary) { }

        public static Boss getInstance(string name, string job, decimal salary)
        {
            if (instance == null)
                instance = new Boss(name, job, salary);
            return instance;
        }
    }
}