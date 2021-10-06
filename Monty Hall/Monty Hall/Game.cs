using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
   
    public class Game
    {
        IPrize prize;
        public bool carInFirstDoor = false;
        public bool carInSecondDoor = false;
        public bool carInThirdDoor = false;
        string luxCar = "Luxury car";
        bool playerWon;
        string door = "";
        //RandomPrizeGenerator prize1 = new();
        public Game(IPrize prize2)
        {
            prize = prize2;
        }
        
        public Game()
        {
            prize = new RandomPrizeGenerator();
        }
 
        public void WhereIsTheCar()
        {
            var door1 = prize.YourPrize();
            var door2 = prize.YourPrize();
            var door3 = prize.YourPrize();
            if (door1 == luxCar)
            {
                carInFirstDoor = true;
            }
            else if (door2 == luxCar)
            {
                carInSecondDoor = true;
            }
            else if (door3 == luxCar)
            {
                carInThirdDoor = true;
            }
        }
        public string DoorWithCarBehind()
        {
         
            string doorWithCar = "";
            if (carInFirstDoor)
            {
                return doorWithCar = "1";
            }
            else if (carInSecondDoor)
            {
                return doorWithCar = "2";
            }

            else if (carInThirdDoor)
            {
                return doorWithCar = "3";
            }
            return doorWithCar;
        }
        public void PlayerChooseFirstDoor()
        {
            if (!carInSecondDoor)
            {
                Console.WriteLine("You have chosen First door.");
                Console.WriteLine("Second door has a goat.");
            }
            else if (!carInThirdDoor)
            {
                Console.WriteLine("You have chosen First door.");
                Console.WriteLine("Third door has a goat.");
            }
        }
        public void PlayerChooseSecondDoor()
        {
            if (!carInFirstDoor)
            {
                Console.WriteLine("You have chosen Second door.");
                Console.WriteLine("First door has a goat.");
            }
            else if (!carInThirdDoor)
            {
                Console.WriteLine("You have chosen Second door.");
                Console.WriteLine("Third door has a goat.");
            }
        }
        public string PlayerChooseThirdDoor()
        {
            if (!carInFirstDoor)
            {
                Console.WriteLine("You have chosen Third door.");
                Console.WriteLine("First door has a goat.");
                carInFirstDoor = false;
            }
            else if (!carInSecondDoor)
            {
                Console.WriteLine("You have chosen Third door.");
                Console.WriteLine("Second door has a goat.");
                carInSecondDoor = false;
            }
            return door = "3";
        }

        public bool PlayerWon()
        {
            return playerWon = true;
        }
        public bool PlayerLose()
        {
            return playerWon = false;
        }
      
    }
}
