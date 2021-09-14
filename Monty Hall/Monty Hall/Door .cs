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

         private string Prize;// not allowed to change value of prise.

        public Door(string pr)
        {
            Prize = pr;
        }
        public Door()
        {

        }
        public void ReturnAllPrises()
        { 
            var prise1=YourPrise();
           
        }
 
        public string YourPrise()
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
