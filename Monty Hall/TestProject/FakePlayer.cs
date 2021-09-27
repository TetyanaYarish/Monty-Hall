using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monty_Hall;

namespace TestProject
{
    public class FakePlayer : IPlayer
    {
        List<string> fakeAnswer = new List<string>() {  "2", "1", "2", "3" };//Door number 3, then swittch the door.
       
        public string AnswerChooseNumberOfDoor()
        {
            var m = fakeAnswer.Count();
            if (m == 0)
            {
                throw new Exception("You did not choose correct answer.");
            }
            var answ = fakeAnswer[m - 1];
            fakeAnswer.Remove(answ);
            return answ;
        }

        public string AnswerStayOrSwitchTheDoor()
        {
            var m = fakeAnswer.Count();
            var answ = fakeAnswer[m - 1];
            fakeAnswer.Remove(answ);
            if (answ=="3")
            {
                throw new Exception("You did not choose correct answer.");
            }
           
            return answ;
        }

    }
    }
