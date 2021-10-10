using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
   public class AnswerFromPlayerFromConsoleReadLine:IAnswerFromPlayerToChoseTheDoor
    {
        string answerNumberOfDoor;
        public string PlayerChoseNumberOfDoor()
        {
            answerNumberOfDoor = Console.ReadLine().ToUpper();
            return answerNumberOfDoor;
        }
    }
}
