using System;
using System.Linq;
using TestProject;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPlayer answ = new Player();
            Player pl = new();
            Door door1 = new();
       
            Console.WriteLine("Prise behide the door1: XX" );
            Console.WriteLine("Prise behide the door2: XX" );
            Console.WriteLine("Prise behide the door3: XX");
            door1.ReturnAllPrises();


            Console.Write("Game over");
            Console.ReadKey();
        }
    }
}
