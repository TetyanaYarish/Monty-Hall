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
        bool one = false;
        bool two = false;
        bool three = false;
        string door2 = "";

        Door door = new();
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
        //public void ChooseCorrectDoor()
        //{
        //    if (prizeInFirstDoor)
        //    {
        //        Console.WriteLine("1");
        //    }
        //    else if (prizeInSecondDoor)
        //    {
        //        Console.WriteLine("2");
        //    }

        //    else if (prizeInThirdDoor)
        //    {
        //        Console.WriteLine("3");
        //    }
        //}
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

            }
            else if (!prizeInThirdDoor)
            {
                Console.WriteLine("You have chosen First door.");
                Console.WriteLine("Third door has a goat.");
            }
            return door2 = "1";
        }
        public string PlayerChooseSecondDoor()
        {
            if (!prizeInFirstDoor)
            {
                Console.WriteLine("You have chosen Second door.");
                Console.WriteLine("First door has a goat.");
            }
            else if (!prizeInThirdDoor)
            {
                Console.WriteLine("You have chosen Second door.");
                Console.WriteLine("Third door has a goat.");
            }
            return door2 = "2";
        }

        public string PlayerChooseThirdDoor()
        {

            if (!prizeInFirstDoor)
            {
                Console.WriteLine("You have chosen Third door.");
                Console.WriteLine("First door has a goat.");
            }
            else if (!prizeInSecondDoor)
            {
                Console.WriteLine("You have chosen Third door.");
                Console.WriteLine("Second door has a goat.");
            }
            return door2 = "3";
        }


        public static void RunTheGame(IPlayer answ)// Start game
        {
            Game game = new();
            var d = game.door;
            IPlayer pl = new Player();
            Door door1 = new();

            Console.WriteLine("Prize behide the door 1: XX");
            Console.WriteLine("Prize behide the door 2: XX");
            Console.WriteLine("Prize behide the door 3: XX");
            door1.ReturnAllPrizes();

            game.ReturnPrize();
            game.Return2Prize();
            game.Return3Prize();

            Console.WriteLine("Please choose the door number [1/2/3].");
            var ans = pl.AnswerChooseNumberOfDoor();
            switch (ans)//*** Ask Simon, why during testing, I can not call fake answer from FakePlayer.cs?
            {
                case "1":
                    game.PlayerChooseFirstDoor();
                    break;
                case "2":
                    game.PlayerChooseSecondDoor();
                    break;
                case "3":
                    game.PlayerChooseThirdDoor();
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Do you want stay with your door [1-yes/2-no]");

            string playerChoice2 = pl.AnswerStayOrSwitchTheDoor();
            switch (playerChoice2)
            {
                case "1":
                    Console.WriteLine($"You have chosen to stick with your original selection door number {ans}. Car was behind door number { game.ChooseCorrectDoor()}.");
                    if (ans == game.ChooseCorrectDoor())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("CONGRATULATION!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You lose!");
                    }
                    Console.ResetColor();
                    break;
                case "2":
                    Console.WriteLine($"You have chosen to change your selection door number {ans}. Car was behind door number { game.ChooseCorrectDoor()}.");
                    if (ans != game.ChooseCorrectDoor())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("CONGRATULATION!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You lose!");
                    }
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
    }
}
