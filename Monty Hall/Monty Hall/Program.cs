using System;
using System.Linq;
using TestProject;
using System.Drawing;
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
            
            while (start)
            {
                do
                {
                    RunTheGame.TheGame(pl);
                    break;
                }
                while (start);
                Console.WriteLine("Do you wish to continue game? [1-yes/2-no]");
                string playerPLay= Console.ReadLine();
                if(playerPLay=="1")
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
