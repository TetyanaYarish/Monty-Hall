using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace Monty_Hall
{
    public class Simulator
    {
        IPrize prizeGenerator = new RandomPrizeGenerator();
        public void RunSimulator()
        {
            int playerWon = 0;
            int playerLose = 0;
            Console.WriteLine("Please choose number of games.");
            int numberOfRun= Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < numberOfRun; i++)
            {
                RunTheGame runGame = new();
                IPlayerAnswer answer = new FakeAnswerForSimulatorGame();
                runGame.StartGame(answer, prizeGenerator);
                bool result = runGame.PlayerWon;
                if (result)
                {
                    playerWon ++;
                }
                else
                {
                    playerLose ++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Player won {playerWon} times and lose {playerLose} times. ");
            Console.ResetColor();
        }
    }
}
