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

        public List<Prise> prises = new List<Prise>();
        public void ReturnPrise()
        {
            Console.WriteLine("Doors number: " + doors.Count());
            Console.WriteLine("Prises number: " + prises.Count());
        }
        public int RandomDoor()
        {
            Random rnd = new();
            int mIndex = doors.Count;
            return mIndex;

        }
    }
}
