using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monty_Hall;

namespace TestProject
{
    public class FakePlayerAnswer : IPlayerAnswer
    {
        List<int> fakeAnswer = new List<int>() {  2,2,1,1 };//Door number 3, then swittch the door.
       
        public string AnswerChooseNumberOfDoor()
        {
            var m = fakeAnswer.Count();
            var answ = fakeAnswer[m - 1];
            if (answ !=1 && answ !=2 && answ !=3)
            {
                throw (new MyException("You did not choose correct answer."));
            }
            fakeAnswer.Remove(answ);
            return answ.ToString();
        }

        public int AnswerStayOrSwitchTheDoor()
        {
            var m = fakeAnswer.Count();
            var answ = fakeAnswer[m - 1];
            fakeAnswer.Remove(answ);
            if (answ != 1 && answ != 2 )
            {
                throw (new MyException("You did not choose correct answer."));
            }
           
            return answ;
        }

    }
    }
