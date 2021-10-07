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
        string answerNumberOfDoor;
        string answerStayOrSwitchTheDoor;
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
            answerNumberOfDoor = Console.ReadLine().ToUpper();
            return answerNumberOfDoor;
        }    
        public string PlayerChoseStayOrSwitchTheDoor()
        {
            answerStayOrSwitchTheDoor = Console.ReadLine().ToUpper();
            return answerStayOrSwitchTheDoor;
        }

        public string AnswerChooseNumberOfDoor()
        {
              PlayerChoseNumberOfDoor();
            if (answerNumberOfDoor != "1" && answerNumberOfDoor != "2" && answerNumberOfDoor != "3")
            {
                // answer1 = "1";
                throw (new MyException("You did not choose correct answer."));
            }
            return answerNumberOfDoor;
        }

        public string AnswerStayOrSwitchTheDoor()
        {
            PlayerChoseStayOrSwitchTheDoor();
            if (answerStayOrSwitchTheDoor != "1" && answerStayOrSwitchTheDoor != "2")
            {
                // answer2 = "1";
                throw (new MyException("You did not choose correct answer."));
            }
            return answerStayOrSwitchTheDoor;
        }
    }
}
