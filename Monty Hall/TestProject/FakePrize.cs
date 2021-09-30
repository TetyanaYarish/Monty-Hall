using Monty_Hall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class FakePrize : IPrize
    {

        List<string> listOfPrizes = new List<string> { "Luxury car", "Goat", "Goat" };
        public void DoorWithPrize()
        {
            YourPrize();
        }

        public string YourPrize()
        {
            int num = 0;
            string value = listOfPrizes[num];
            if (listOfPrizes.Count()< 0)
            {
                return null;

                //remove prize from list of prizes 
            }
            listOfPrizes.Remove(value);
            return value;
        }

    }
}
