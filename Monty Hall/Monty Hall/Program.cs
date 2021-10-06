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
            //IPlayerAnswer pl = new RealPlayerAnswer();
            //bool start = true;
            Message message = new();
            message.Text();
            Console.WriteLine(new RunTheGame().Greetings());
            Simulator simulator = new();
            simulator.RunSimulator2();
            //RunTheGame runGame = new();
            //IPrize prize = new RandomPrizeGenerator();
            //do
            //{
            //    runGame.StartGame(pl, prize);
            //    Console.WriteLine("Do you wish to continue game? [1-yes/2-no]");
            //    start = pl.AnswerStayOrSwitchTheDoor() == "1";
            //}
            //while (start);
            Console.ReadKey();
        }
    }
}
