using System;
using TestProject;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPlayer answ = new Player();
            Prise price = new();
            price.GetPrice();
            Doors doors = new();
            doors.GetDoor();
            Game game = new();
            game.ReturnPrise();
            doors.RandomDoor();
            Console.WriteLine("Do you want to see your prise? [Y/N]");
            //IAnswer answ2 = new RealAnswer();

            if (answ.Answer() == "Y")
            {
                Console.WriteLine(price.YourPrise());
            }
            else
            {
                Console.ReadLine();
            }
          
        }
    }
}
