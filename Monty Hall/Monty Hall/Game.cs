using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
   public class Game
    {
        List<Doors> doors = new();

        List<Prise> prises = new List<Prise>();
        public void ReturnPrise()
        {
            Console.WriteLine("Doors number: "+doors.Count());
            Console.WriteLine("Prises number: "+prises.Count());
        }
    }
}
