using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace Monty_Hall
{
    public class RunTheGame
    {
        public bool PlayerWon { get; private set; }
        

        public void StartGame(IPlayerAnswer pl, IPrize prize)// Start game
        {
            Game game = new();
            game.WhereIsTheCar();

            Console.WriteLine("Please choose the door number [1/2/3].");
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

            int playerChoice2 = pl.AnswerStayOrSwitchTheDoor();
            switch (playerChoice2)
            { 
                case 1:
                    Console.WriteLine($"You have chosen to stick with your door number {ans}. Car was behind door number { game.DoorWithCarBehind()}.");
                    if (ans == game.DoorWithCarBehind())
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        game.PlayerWon();
                        Console.WriteLine("CONGRATULATIONS!");
                        PlayerWon = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        game.PlayerLose();
                        Console.WriteLine("You lose!");
                        PlayerWon = false;
                    }
                    Console.ResetColor();
                    break;
                case 2:
                    Console.WriteLine($"You have chosen to switch your door number {ans}. Car was behind door number { game.DoorWithCarBehind()}.");
                    if (ans != game.DoorWithCarBehind())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("CONGRATULATIONS!");
                        game.PlayerWon();
                        PlayerWon = true;
                    }
                    else
                    {
                        game.PlayerLose();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You lose!");
                        PlayerWon = false;
                    }
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
        public string Greetings()
        {
            return "THIS IS THE MONTY HALL GAME!\n\nPrize behind the door 1: XX\nPrize behind the door 2: XX\nPrize behind the door 3: XX\n";
        }
    }
}
