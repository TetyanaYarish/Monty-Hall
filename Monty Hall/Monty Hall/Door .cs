using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Door
    {
        List<string> Titles = new List<string>{ "Luxury car", "Goat1", "Goat2" };

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
            var prise2=YourPrise();
            var prise3=YourPrise();
            Console.WriteLine($"All prises are : {prise1} {prise2} and {prise3}");
          
        }

        public string YourPrise()
        {
            // List<string> Titles = new List<string> { "Luxury car", "Goat1", "Goat2" };
            int num = Titles.Count();
            if (num < 1)
            {
                throw new Exception("We dont have more prises. ");
                
            }
            string value = Titles[new Random().Next(0, num)];
           

            Titles.Remove(value);

            return value;
        }
    }
}
