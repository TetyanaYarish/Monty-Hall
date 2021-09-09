using System;
using System.Collections.Generic;
using System.Linq;

namespace Monty_Hall
{
    internal class FakePlayerAndAnswer : IPlayer //FakePl from Program
    {
        List<string> fakeAnswer = new List<string>() { "N", "Y", "Y", "Y" };
        public string Answer()
        {
            var m = fakeAnswer.Count();
            if (m == 0)
            {
                //return "N";
                throw new Exception("You don't leave any answer.");
            }
            var answ = fakeAnswer[m - 1];//throw Exception
            fakeAnswer.Remove(answ);
            return answ;
        }

       
    }
}