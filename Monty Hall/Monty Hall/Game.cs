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
        public bool carInSecondDoor = false;//**
        public bool carInThirdDoor = false;
        string luxCar = "Luxury car";
        bool playerWon;
        string door = "";
        RandomPrizeGenerator prize1 = new();
        public Game(IPrize prize2)
        {
            prize = prize2;
        }
        public Game()
        {
            prize = new RandomPrizeGenerator();
        }
        public string CheckIfCarBehindTheFirstDoor()// ** check constructor Game (2 vers) in BJ 
        {
            var newPrize = prize.YourPrize();
            if (newPrize == luxCar)
            {
                carInFirstDoor = true;
            }
            return newPrize;
        }
        public string CheckIfCarBehindTheSecondDoor()
        {
            var newPrize = prize.YourPrize();
            if (newPrize == luxCar)
            {
                carInSecondDoor = true;
            }
            return newPrize;
        }

        public string ReturnPrizeBehindThirdDoor()
        {
            var newPrize = prize.YourPrize();
            if (newPrize == luxCar)
            {
                carInThirdDoor = true;
            }
            return newPrize;
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
            return door = "1";
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
            return door = "2";
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
        public bool ResultOfGame()
        {
            bool playerWinner=true;
            if(playerWon)
            {
                playerWinner = true;
                Console.WriteLine("CONGRATULATIONS!");
            }
            else if (!playerWon)
            {
                playerWinner = false;
                Console.WriteLine("You lose!");
            }
            return playerWinner;
        }
    }
}
