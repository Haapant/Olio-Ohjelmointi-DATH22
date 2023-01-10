using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class Elevator
    {
        private int _currentFloor;
        public int CurrentFloor
        {
            get
            {
                return _currentFloor;
            }
            set
            {
                if (value >= 1 && value <= 6)
                {
                    _currentFloor = value;
                    Console.WriteLine("Elevator moving to floor " + _currentFloor);
                }
                else
                {
                    Console.WriteLine("Invalid floor. Please enter a number between 1 and 6.");
                }
            }
        }
        public Elevator()
        {
            _currentFloor = 1;
        }
    }
}
luokka