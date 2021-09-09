using System;
using System.Linq;
using TestProject;
using TestProject;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPlayer answ = new FakePlayerAndAnswer();
            Prise price = new();
            price.GetPrice();
            Doors doors = new();
            doors.GetDoor();
            Game game = new();
            var door = Enum.GetValues(typeof(doorsEnum)).Cast<doorsEnum>();
           door.ToList();
            //game.ReturnPrise();
            //doors.RandomDoor();
            Console.WriteLine("Do you want to stay with this door? [Y/N]");
            while (answ.Answer() == "Y")
            {
                Console.WriteLine("Your prise is: " + price.YourPrise());
            }
            while (answ.Answer() == "N")
            {
                Console.WriteLine("Your prise is: " + price.YourPrise());
            }

            Console.Write("Game over");
            Console.ReadKey();
        }
    }
}
