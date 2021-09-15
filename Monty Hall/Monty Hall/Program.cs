using System;
using System.Linq;
using TestProject;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPlayer pl = new Player();
            bool start = true;
            bool continueGame= true;
            do
            {
                Game.Main(pl);
                break;
            }
            while (start);


            //Console.WriteLine($"Do you want stay with your door[1] or switch [2]?");
            //do
            //{
            //    Game.ContinueGame(pl);
            //    break;
            //}
            //while (continueGame);

            Console.ReadKey();
        }
    }
}
