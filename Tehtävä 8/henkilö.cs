using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_8
{
    abstract class henkilö
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }

        protected Person(string name, string job, decimal salary)
        {
            this.Name = name;
            this.Job = job;
            this.Salary = salary;
        }
    }
}