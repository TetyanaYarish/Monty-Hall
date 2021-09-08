using System;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prise price = new();
            price.GetPrice();
            Doors doors = new();
            doors.GetDoor();
            Game game = new();
            game.ReturnPrise();
            doors.RandomDoor();
            Console.WriteLine(price.YourPrise());
          
        }
    }
}
