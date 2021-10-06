using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monty_Hall;

namespace TestProject
{
    public class RealPlayerAnswer : IPlayerAnswer
    {
        string answer1;
        string answer2;
        IPlayerAnswer iPlayer;
        public RealPlayerAnswer(IPlayerAnswer player)
        {
            iPlayer = player;
        }
        public RealPlayerAnswer()
        {

        }
        public string PlayerChoseNumberOfDoor()
        {
            answer1 = Console.ReadLine().ToUpper();
            return answer1;
        }    
        public string PlayerChoseStayOrSwitchTheDoor()
        {
            answer2 = Console.ReadLine().ToUpper();
            return answer2;
        }

        public string AnswerChooseNumberOfDoor()
        {
              PlayerChoseNumberOfDoor();
            if (answer1 != "1" && answer1 != "2" && answer1 != "3")
            {
                // answer1 = "1";
                throw (new MyException("You did not choose correct answer."));
            }
            return answer1;
        }

        public string AnswerStayOrSwitchTheDoor()
        {
            PlayerChoseStayOrSwitchTheDoor();
            if (answer2 != "1" && answer2 != "2")
            {
                // answer2 = "1";
                throw (new MyException("You did not choose correct answer."));
            }
            return answer2;
        }
    }
}
