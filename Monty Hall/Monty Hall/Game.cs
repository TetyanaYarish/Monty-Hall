using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace Monty_Hall
{
    public class Game
    {
        bool prizeInFirstDoor = false;
        bool prizeInSecondDoor = false;
        bool prizeInThirdDoor = false;
        string luxCar = "Luxury car";
        bool playerWon = true;
        string door2 = "";

        Prize door = new();
        public string ReturnPrize()
        {
            var door1 = door.YourPrize();
            if (door1 == luxCar)
            {
                prizeInFirstDoor = true;
            }
            return door1;
        }
        public string Return2Prize()
        {
            var door1 = door.YourPrize();
            if (door1 == luxCar)
            {
                prizeInSecondDoor = true;
            }
            return door1;
        }

        public string Return3Prize()
        {
            var door1 = door.YourPrize();
            if (door1 == luxCar)
            {
                prizeInThirdDoor = true;
            }
            return door1;
        }

        public string ChooseCorrectDoor()
        {
            string doorWithCar = "";
            if (prizeInFirstDoor)
            {
                return doorWithCar = "1";
            }
            else if (prizeInSecondDoor)
            {
                return doorWithCar = "2";
            }

            else if (prizeInThirdDoor)
            {
                return doorWithCar = "3";
            }
            return doorWithCar;
        }
        public string PlayerChooseFirstDoor()
        {
            if (!prizeInSecondDoor)
            {
                Console.WriteLine("You have chosen First door.");
                Console.WriteLine("Second door has a goat.");
                //  prizeInSecondDoor = false;
            }
            else if (!prizeInThirdDoor)
            {
                Console.WriteLine("You have chosen First door.");
                Console.WriteLine("Third door has a goat.");
                //  prizeInThirdDoor = false;
            }
            return door2 = "1";
        }
        public string PlayerChooseSecondDoor()
        {
            if (!prizeInFirstDoor)
            {
                Console.WriteLine("You have chosen Second door.");
                Console.WriteLine("First door has a goat.");
                //  prizeInFirstDoor = false;
            }
            else if (!prizeInThirdDoor)
            {
                Console.WriteLine("You have chosen Second door.");
                Console.WriteLine("Third door has a goat.");
                // prizeInThirdDoor = false;
            }
            return door2 = "2";
        }

        public string PlayerChooseThirdDoor()
        {

            if (!prizeInFirstDoor)
            {
                Console.WriteLine("You have chosen Third door.");
                Console.WriteLine("First door has a goat.");
                prizeInFirstDoor = false;
            }
            else if (!prizeInSecondDoor)
            {
                Console.WriteLine("You have chosen Third door.");
                Console.WriteLine("Second door has a goat.");
                 prizeInSecondDoor = false;
            }
            return door2 = "3";
        }
        //public void ResultOfGame()
        //{
        //    if (prizeInFirstDoor)
        //    {

        //    }
        //}
        public string PlayerWon()
        {
            return "CONGRATULATIONS!";
        }
        public string PlayerLose()
        { 
            return "You lose!";
        }
    }
}
