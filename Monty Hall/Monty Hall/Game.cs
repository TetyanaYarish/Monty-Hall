using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Game
    {
        
        public List<Doors> doors = new();


        internal int DoorNumber { get; }
        public int ReturnPrise()
        {
            var doorNum = DoorNumber;
            return doorNum;
        }

        public void CooseTheDoor()
        {
            int option = 2;
            switch (option)
            {
                case 1:
                    Console.WriteLine($"Measured value is {option}; too low.");
                    break;

                case 2:
                    Console.WriteLine($"Measured value is {option}; too high.");
                    break;

                case 3:
                    Console.WriteLine("Failed measurement.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {option}.");
                    break;
            }
        }

    }
}
