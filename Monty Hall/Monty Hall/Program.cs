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
            IPlayer pl = new Player();
            bool start = true;
            Game game = new();
            Message message = new ();
            message.Text();
            Console.WriteLine(new RunTheGame().Greetings());
      
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
