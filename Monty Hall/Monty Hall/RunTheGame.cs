using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace Monty_Hall
{
   public  class RunTheGame
    {
        public static void TheGame(IPlayer answ)// Start game
        {
            IPrize prize = new Prize();
            Game game = new();
            
            IPlayer pl = new Player();
            Prize door1 = new();
            RunTheGame start = new();
            door1.ReturnAllPrizes();
            game.ReturnPrize();
            game.Return2Prize();
            game.Return3Prize();

            Console.WriteLine(start.StartGame() + "Please choose the door number [1/2/3].");
            var ans = pl.AnswerChooseNumberOfDoor();
            switch (ans)
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
                        Console.WriteLine(game.PlayerWon());
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(game.PlayerLose());

                    }
                    Console.ResetColor();
                    break;
                case "2":
                    Console.WriteLine($"You have chosen to change your selection door number {ans}. Car was behind door number { game.ChooseCorrectDoor()}.");
                    if (ans != game.ChooseCorrectDoor())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(game.PlayerWon());
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(game.PlayerLose());
                    }
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
        public string StartGame()
        {
            return "Prize behind the door 1: XX\nPrize behind the door 2: XX\nPrize behind the door 3: XX\n";
        }
    }
}
