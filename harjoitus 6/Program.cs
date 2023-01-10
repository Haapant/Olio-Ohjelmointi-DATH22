using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals.TotalAnimals = 0;
            Dog dog1 = new Dog();
            dog1.MakeSound();
            Cat cat1 = new Cat();
            cat1.MakeSound();
            Console.WriteLine("Total animals created: " + Animals.TotalAnimals);
            Console.ReadLine();
        }
    }
}
