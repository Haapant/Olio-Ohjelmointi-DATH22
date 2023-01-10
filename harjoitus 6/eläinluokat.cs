using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_6
{
    internal class Animals
    {
        public static int TotalAnimals { get; set; }
        public virtual string Sound { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("This animal makes a generic sound.");
        }
        public Animals()
        {
            TotalAnimals++;
        }
    }

    class Dog : Animals
    {
        public override string Sound { get; set; } = "Woof";
        public override void MakeSound()
        {
            Console.WriteLine("The dog says " + Sound);
        }
    }
    class Cat : Animals
    {
        public override string Sound { get; set; } = "Meow";
        public override void MakeSound()
        {
            Console.WriteLine("The cat says " + Sound);
        }
    

