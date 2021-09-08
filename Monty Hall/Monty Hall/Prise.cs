using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{

   public class Prise
    {
       public string[] listOfPrice = { "Luxury car", "Goat", "Goat" };
        public void GetPrice()
        {
            for (int i = 0; i < listOfPrice.Length; i++)
            {
                Console.WriteLine(listOfPrice[i]);
            }
        }
        public string YourPrise()
        {
            string[] Titles = { "Luxury car", "Goat", "Goat" };

           string value = Titles[new Random().Next(0, Titles.Length)];
            return value;
        }
    }

}
