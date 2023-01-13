using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_8
{
    internal class Työntekijä : henkilö
    {
        public double WeeklyHours { get; set; }
        public Työntekijä(string name, decimal salary, double weeklyHours)
            : base(name, "Employee", salary)
        {
            this.WeeklyHours = weeklyHours;
        }
    }
}