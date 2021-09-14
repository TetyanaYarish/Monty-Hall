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

        List<string> Titles = new List<string> { "Luxury car", "Goat1", "Goat2" };

       
        public void ReturnAllPrises()
        {
            throw new NotImplementedException();
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
