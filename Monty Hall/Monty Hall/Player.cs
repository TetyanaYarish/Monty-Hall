using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monty_Hall;

namespace TestProject
{
    public class Player : IPlayer
    {

        public string AnswerChooseNumberOfDoor()
        {
            string answer1 = Console.ReadLine().ToUpper();


            if (answer1 != "1" && answer1 != "2" && answer1 != "3")
            {
                // answer1 = "1";
                throw new Exception("You did not choose correct answer.");
            }
            return answer1;
        }

        public string AnswerStayOrSwitchTheDoor()
        {
            string answer2 = Console.ReadLine().ToUpper();
            if (answer2 != "1" && answer2 != "2")
            {
               // answer2 = "1";
               throw new Exception("You did not choose correct answer.");
            }
            return answer2;
        }
    }
}
