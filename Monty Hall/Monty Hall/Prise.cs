using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{

   public class Prise
    {
        string[] listOfPrice = { "Luxury car", "Rubish bin", "Rubish bin" };
        public void GetPrice()
        {
            for (int i = 0; i < listOfPrice.Length; i++)
            {
                Console.WriteLine(listOfPrice[i]);
            }
        }
    }

}
