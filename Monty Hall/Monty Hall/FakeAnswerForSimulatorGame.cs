using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monty_Hall;

namespace TestProject
{
    public class FakeAnswerForSimulatorGame : IPlayerAnswer
    {
        List<int> fakeAnswer = new List<int>() { 2, 1};//Door number 3, then swittch the door.
       
        public string AnswerChooseNumberOfDoor()
        {
            var numberOfDoor = "";
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                numberOfDoor = random.Next(1,4).ToString();
            }
            return numberOfDoor;
        }

        public int AnswerStayOrSwitchTheDoor()
        {
            var m = fakeAnswer.Count();
            if (m == 0)
            {
                return 1;
            }
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
