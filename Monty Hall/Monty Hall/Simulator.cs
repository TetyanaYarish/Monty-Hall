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
        IPlayerAnswer answer = new FakeAnswerForSimulatorGame();

        public void RunSimulator2()
        {
            int playerWon = 0;
            int playerLose = 0;
            Console.WriteLine("Please choose number of games.");
            int numberOfRun= Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < numberOfRun; i++)
            {
                IPrize prizeGenerator = new RandomPrizeGenerator();
               
                RunTheGame runGame = new();
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
