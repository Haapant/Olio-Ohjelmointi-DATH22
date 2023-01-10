using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            while (true)
            {
                Console.Write("Which floor would you like to go to (1-6)? ");
                int targetFloor = int.Parse(Console.ReadLine());
                elevator.CurrentFloor = targetFloor;
            }
        }
    }
}