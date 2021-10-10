using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
   public class AnswerFromPlayerFakeDoorNumber:IAnswerFromPlayerToChoseTheDoor
    {
        string answerNumberOfDoor="5";
        public string PlayerChoseNumberOfDoor()
        {
            return answerNumberOfDoor;
        }
    }
}
