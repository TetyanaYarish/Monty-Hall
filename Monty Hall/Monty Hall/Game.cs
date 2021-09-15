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
      
        Door door = new();
        public string ReturnPrise()
        {
            var door1 = door.YourPrise();
            if (door1 == luxCar)
            {
                prizeInFirstDoor = true;
            }
            return door1;
        }
        public string Return2Prise()
        {
            var door1 = door.YourPrise();
            if (door1 == luxCar)
            {
                prizeInSecondDoor = true;
            }
            return door1;
        }

        public string Return3Prise()
        {
            var door1 = door.YourPrise();
            if (door1 == luxCar)
            {
                prizeInThirdDoor = true;
            }
            return door1;
        }
        public void ChoseCorrectDoor()
        {
            if (prizeInFirstDoor)
            {
                Console.Write("First door");
            }
            else if (prizeInSecondDoor)
            {
                Console.Write("Second door");
            }

            else if (prizeInThirdDoor)
            {
                Console.Write("Third door");
            }
        }
        public void PlayerChoseFirstDoor()
        {
            if (!prizeInSecondDoor )
            {
                Console.WriteLine("Second door has a goat.");
            }
            else if (!prizeInThirdDoor)
            {
                Console.WriteLine("Third door has a goat.");
            }
        }
        public void PlayerChoseSecondDoor()
        {
          
            if (!prizeInFirstDoor )
            {
                Console.WriteLine("First door has a goat.");
            } 
            else if (!prizeInThirdDoor)
            {
                Console.WriteLine("Third door has a goat.");
            }
           
        }
       
        public void PlayerChoseThirdDoor()
        {
            if(!prizeInFirstDoor )
            {
                Console.WriteLine("First door has a goat.");
            }
             else if(!prizeInThirdDoor)
            {
                Console.WriteLine("Third door has a goat.");
            }
        }

   
        public static void Main(IPlayer answ)
        {
           // IPlayer answ1 = new Player();
            IPlayer pl = new Player();
            Door door1 = new();

            Console.WriteLine("Prise behide the door 1: XX");
            Console.WriteLine("Prise behide the door 2: XX");
            Console.WriteLine("Prise behide the door 3: XX");
            door1.ReturnAllPrises();
            Game game = new();
            game.ReturnPrise();
            game.Return2Prise();
            game.Return3Prise();
            game.ChoseCorrectDoor();
            bool continueGame = true;
            Console.WriteLine("Chose the number of door [1/2/3].");
            string playerChoice = pl.AnswerChoseNumberOfDoor();
            switch (playerChoice)
            {
                case "1":
                    game.PlayerChoseFirstDoor();
                    break;
                case "2":
                    game.PlayerChoseSecondDoor();
                    break;
                case "3":
                    game.PlayerChoseThirdDoor();
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Do you want stay with your door[1] or switch [2]?");
            do
            {
                Game.ContinueGame(pl);
                break;
            }
            while (continueGame);
            string playerChoice2 = pl.AnswerStayOrSwitchTheDoor();
            switch (playerChoice2)
            {
                case "1":
                    Console.Write($"You choose stay. Car was behind ");
                    game.ChoseCorrectDoor();
                    break;
                case "2":
                    Console.Write($"You choose switch. Car was behind ");
                    game.ChoseCorrectDoor();
                    break;

                default:
                    break;
            }
        }
        public static void ContinueGame(IPlayer answ)
        {
           
            IPlayer answ1 = new Player();
            Player pl = new();
            Game game = new();
          
            //string playerChoice = pl.AnswerStayOrSwitchTheDoor();
            //switch (playerChoice)
            //{
            //    case "1":
            //        Console.WriteLine($"You choose stay. Car was behind  ");
            //        game.ChoseCorrectDoor();
            //        break;
            //    case "2":
            //        Console.WriteLine($"You choose switch.Car was behind ");
            //        game.ChoseCorrectDoor();
            //        break;

            //    default:
            //        break;
            //}
        }
    }
}
