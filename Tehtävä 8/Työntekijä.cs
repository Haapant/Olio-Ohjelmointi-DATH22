using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Employee : Person
    {
        public double WeeklyHours { get; set; }
        public Employee(string name, decimal salary, double weeklyHours)
            : base(name, "Employee", salary)
        {
            this.WeeklyHours = weeklyHours;
        }
    }
}