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
        public void ChooseCorrectDoor()
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
        public void PlayerChooseFirstDoor()
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
        public void PlayerChooseSecondDoor()
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
       
        public void PlayerChooseThirdDoor()
        {
            if(!prizeInFirstDoor )
            {
                Console.WriteLine("First door has a goat.");
            }
             else if(!prizeInSecondDoor)
            {
                Console.WriteLine("Second door has a goat.");
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
            game.ChooseCorrectDoor();
            bool continueGame = true;
            Console.WriteLine("Chose the number of door [1/2/3].");
           // string playerChoice = pl.AnswerChoseNumberOfDoor();
            switch (pl.AnswerChooseNumberOfDoor())//*** Ask Simon, why during testing, I can not call fake answer from FakePlayer.cs?
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
            Console.WriteLine($"Do you want stay with your door [1] or switch [2]?");
           
                string playerChoice2 = pl.AnswerStayOrSwitchTheDoor();
                switch (playerChoice2)
                {
                    case "1":
                        Console.Write($"You choose stay. Car was behind ");
                        game.ChooseCorrectDoor();
                        break;
                    case "2":
                        Console.Write($"You choose switch. Car was behind ");
                        game.ChooseCorrectDoor();
                        break;

                    default:
                        break;
                }
                //Game.ContinueGame(pl);
              
        }
        public static void ContinueGame(IPlayer answ)
        {
            //IPlayer answ1 = new Player();
            //Player pl = new();
            //Game game = new();
        }
    }
}
