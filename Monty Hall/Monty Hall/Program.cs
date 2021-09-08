using System;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool firstDoor = true;
            bool secondDoor = false;
            bool thirdDoor = false;
            Prise price = new();
            price.GetPrice();
            Doors doors = new(doorsEnum.Door_1);
            doors.GetDoor();
            Game game = new();
            game.ReturnPrise();
            game.RandomDoor();
            Console.WriteLine($"Hello World! {firstDoor} + {secondDoor} + {thirdDoor}");
          
        }
    }
}
