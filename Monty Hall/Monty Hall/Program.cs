using System;
using System.Linq;
using TestProject;
using TestProject;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPlayer pl = new Player();
            bool start = true;
            RunTheGame startGame = new();
            Game game = new();
            Console.WriteLine(startGame.Greetings());
      
            while (start)
            {
                do
                {
                    RunTheGame.StartGame(pl);
                    break;
                }
                while (start);
                Console.WriteLine("Do you wish to continue game? [1-yes/2-no]");
                if (pl.AnswerStayOrSwitchTheDoor() == "1")
                {
                    start = true;
                }
                else
                {
                    return;
                }
            }
            Console.ReadKey();
        }
    }
}
