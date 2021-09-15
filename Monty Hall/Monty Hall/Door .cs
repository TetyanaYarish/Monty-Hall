using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Door:IDoor
    {
        List<string> Titles = new List<string>{ "Luxury car", "Goat", "Goat" };

         private string Prize;// not allowed to change value of prize.

        public Door(string pr)
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
 
        public string YourPrize()
        {
            int num = Titles.Count();
            if (num < 1)
            {
                throw new Exception("We dont have more prizes. ");
            }
            string value = Titles[new Random().Next(0, num)];
            Titles.Remove(value);

            return value;
        }
    }
}
