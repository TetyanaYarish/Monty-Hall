using System;
using System.Linq;
using TestProject;

namespace Monty_Hall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IPlayer answ = new Player();
            //Player pl = new();
            //Door door1 = new();
       
            //Console.WriteLine("Prise behide the door1: XX" );
            //Console.WriteLine("Prise behide the door2: XX" );
            //Console.WriteLine("Prise behide the door3: XX");
            //door1.ReturnAllPrises();
            Game game = new();
            //game.ReturnPrise();
            //game.Return2Prise();
            //game.Return3Prise();
            //game.ChoseCorrectDoor();
            //Console.WriteLine("Chose the number of door [1/2/3].");
            ////int playerChoice = Convert.ToInt32(Console.ReadLine());
            //string playerChoice =Console.ReadLine();
            //switch (playerChoice)
            //{
            //    case "1":
            //       game.PlayerChoseFirstDoor();
            //        break;
            //    case "2":
            //        game.PlayerChoseSecondDoor();
            //        break;
            //    case "3":
            //        game.PlayerChoseThirdDoor();
            //        break;
            //    default:
            //        break;
            //}
            
           
            Console.WriteLine("Game over");
            Console.ReadKey();
        }
    }
}
