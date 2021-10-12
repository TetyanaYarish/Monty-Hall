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
        int answerStayOrSwitchTheDoor;
        IPlayerAnswer iPlayer;
        // IAnswerFromPlayerToChoseTheDoor answerFromPlayer=new AnswerFromPlayerFakeDoorNumber();
        IAnswerFromPlayerToChoseTheDoor answerFromPlayer = new AnswerFromPlayerFromConsoleReadLine();

        public RealPlayerAnswer()
        {

        }
        public RealPlayerAnswer(IAnswerFromPlayerToChoseTheDoor answerFromPlayer1)
        {

        }
        public int PlayerChoseStayOrSwitchTheDoor()
        {
            answerStayOrSwitchTheDoor = Convert.ToInt32(Console.ReadLine());
            if (answerStayOrSwitchTheDoor != 1 && answerStayOrSwitchTheDoor != 2)
            {
                // answer2 = "1";
                throw (new MyException("You did not choose correct answer."));
            }
            return answerStayOrSwitchTheDoor;
        }

        public string AnswerChooseNumberOfDoor()
        {
            answerNumberOfDoor = answerFromPlayer.PlayerChoseNumberOfDoor();
            if (answerNumberOfDoor != "1" && answerNumberOfDoor != "2" && answerNumberOfDoor != "3")
            {
                // answer1 = "1";
                throw (new MyException("You did not choose correct answer."));
            }
            return answerNumberOfDoor;
        }

        public int AnswerStayOrSwitchTheDoor()
        {
            PlayerChoseStayOrSwitchTheDoor();

            return answerStayOrSwitchTheDoor;
        }
    }
}
