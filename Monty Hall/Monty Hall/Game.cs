using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
   
    public class Game
    {
        public bool carInFirstDoor = false;
        public bool carInSecondDoor = false;//**
        public bool carInThirdDoor = false;
        string luxCar = "Luxury car";
        bool playerWon;
        string door2 = "";
       
        RandomPrizeGenerator prize = new();
        public string ReturnPrizeBehindFirstDoor(IPrize prize)
        {
            var door1 = prize.YourPrize();
            if (door1 == luxCar)
            {
                carInFirstDoor = true;
            }
            return door1;
        }
        public string ReturnPrizeBehindSecondDoor(IPrize prize)
        {
            var door1 = prize.YourPrize();
            if (door1 == luxCar)
            {
                carInSecondDoor = true;
            }
            return door1;
        }

        public string ReturnPrizeBehindThirdDoor(IPrize prize)
        {
            var door1 = prize.YourPrize();
            if (door1 == luxCar)
            {
                carInThirdDoor = true;
            }
            return door1;
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
        public string PlayerChooseFirstDoor()
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
            return door2 = "1";
        }
        public string PlayerChooseSecondDoor()
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
            return door2 = "2";
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
            return door2 = "3";
        }

        public bool PlayerWon()
        {
            return playerWon = true;
        }
        public bool PlayerLose()
        {
            return playerWon = false;
        }
        public void ResultOfGame()
        {
            if(playerWon)
            {
                Console.WriteLine("CONGRATULATIONS!");
            }
            else if (!playerWon)
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}
