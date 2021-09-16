using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Door:IDoor
    {
        List<string> listOfPrizes = new List<string>{ "Luxury car", "Goat", "Goat" };

         private string Prize;// not allowed to change value of prize.

        public Door(string pr)//Constructor to keep prize with 
        {
            Prize = pr;
        }
        public Door()
        {

        }
        public void ReturnAllPrizes()
        { 
            var prize1=YourPrize();
           
        }
 
        public string YourPrize()//Function, which return randomly prize from list of prizes
        {
            int num = listOfPrizes.Count();
            if (num < 1)
            {
                throw new Exception("We dont have more prizes. ");
            }
            string value = listOfPrizes[new Random().Next(0, num)];
            listOfPrizes.Remove(value);//remove prize from list of prizes

            return value;
        }
    }
}
