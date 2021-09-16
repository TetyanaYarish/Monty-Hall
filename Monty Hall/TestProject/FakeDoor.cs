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

        List<string> listOfPrizes = new List<string> { "Luxury car", "Goat", "Goat" };
        public void ReturnAllPrizes()
        {
            YourPrize();
        }

        public string YourPrize()
        {
            int num = listOfPrizes.Count();
            if (num < 1)
            {
                return null;
            }
            string value = listOfPrizes[num-1];
            listOfPrizes.Remove(value);//remove prize from list of prizes

            return value;
        }

    }
}
