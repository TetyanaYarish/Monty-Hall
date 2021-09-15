using Monty_Hall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class FakeDoor : IDoor
    {

        List<string> Titles = new List<string> { "Luxury car", "Goat", "Goat" };
        public void ReturnAllPrises()
        {
            Console.WriteLine(Titles);
        }

        public string YourPrise()
        {
            var prize = "";
            for (int i = 0; i < Titles.Count(); i++)
            {
                prize +=prize;
            }
            return prize;
        }

    }
}
