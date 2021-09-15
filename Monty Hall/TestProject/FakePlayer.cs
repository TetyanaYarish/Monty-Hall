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
        List<string> fakeAnswer = new List<string>() { "2", "3", "2", "1" };
        public string AnswerChoseNumberOfDoor()
        {
            var m = fakeAnswer.Count();
            if (m == 0)
            {
                return "1";
                // throw Exception 
            }
            var answ = fakeAnswer[m - 1];
            fakeAnswer.Remove(answ);
            return answ;
        }

        public string AnswerStayOrSwitchTheDoor()
        {
            var m = fakeAnswer.Count();
            if (m == 0)
            {
                return "1";
                // throw Exception like an option.
            }
            var answ = fakeAnswer[m - 1];
            fakeAnswer.Remove(answ);
            return answ;
        }
    }
}
