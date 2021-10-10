using System;
using System.Linq;
using TestProject;
using ConsoleApp1;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPlayerAnswer pl = new RealPlayerAnswer();
            bool start = true;
            Message message = new();
            message.Text();
     
            do
            {
                Console.WriteLine("Do you want to start a game[1] or a simulator[2]? "); 
                var ans = pl.AnswerStayOrSwitchTheDoor();
                switch (ans)
                {
                    case 1:
                            Console.WriteLine(new RunTheGame().Greetings());
                            RunTheGame runGame = new();
                            IPrize prize = new RandomPrizeGenerator();
                            runGame.StartGame(pl, prize);
                            Console.WriteLine("Do you wish to continue? [1-yes/2-no]");
                            start = pl.AnswerStayOrSwitchTheDoor() == 1;
                        break;
                    case 2:
                            Console.WriteLine(new RunTheGame().Greetings());
                            Simulator simulator = new();
                            simulator.RunSimulator2();
                        break;
                    default:
                        break;
                }
            } while (start);
            Console.ReadKey();
        }
    }
}
