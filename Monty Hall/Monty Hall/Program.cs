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
           
            do
            {
                Game.Main(pl);
                break;
            }
            while (start);

            Console.ReadKey();
        }
        
    }
}
