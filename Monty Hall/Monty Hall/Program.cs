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
           // pl.Answer();
            //Doors doors = new();
            Door door1 = new();
            //var prise1=door1.YourPrise();
            //var prise2=door1.YourPrise();
            //var prise3=door1.YourPrise();
         // var test = door1.
            Console.WriteLine("Prise behide the door1: XX" );
            Console.WriteLine("Prise behide the door2: XX" );
            Console.WriteLine("Prise behide the door3: XX");
            door1.ReturnAllPrises();
           //if(prise1=="Goat1")
           // {
           //     Console.WriteLine($"Your prise behind door1 : {prise1}");
           // } 
           //else if(prise1=="Goat2")
           // {
           //     Console.WriteLine($"Your prise behind door1 : {prise1}");
           // }
           //else if(prise1== "Luxury car")
           // {
           //     Console.WriteLine($"Your prise behind door1 : {prise1}");
           // }
            //Game game = new();
            //     var door = Enum.GetValues(typeof(doorsEnum)).Cast<doorsEnum>();
            //Door door2 = new();
       
            //Console.WriteLine("Prise list: " + door.ToList());

            //Console.WriteLine("Prises number: " + door.Count());

            //game.CooseTheDoor();
            //Console.WriteLine("Do you want to stay with this door? [Y/N]");
            //do
            //{
            //    //Console.WriteLine("Your prise is: " + price.YourPrise());

            //} while (answ.Answer() == "Y");
            //if (answ.Answer() == "N")
            //{
            //    //Console.WriteLine("Your prise is: " + price.YourPrise());
            //}

            Console.Write("Game over");
            Console.ReadKey();
        }
    }
}
