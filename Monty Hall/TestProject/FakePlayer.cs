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
        List<string> fakeAnswer = new List<string>() { "N", "Y", "Y", "Y" };
        public string Answer()
        {
            var m = fakeAnswer.Count();
            if (m == 0)
            {
                return "N";
                // throw Exception 
            }
            var answ = fakeAnswer[m - 1];//throw Exception
            fakeAnswer.Remove(answ);
            return answ;
        }
        //public int Answer2()
        //{
        //    var m = fakeAnswer.Count();
        //    if (m == 0)
        //    {
        //        return "N";
        //        // throw Exception 
        //    }
        //    var answ = fakeAnswer[m - 1];//throw Exception
        //    fakeAnswer.Remove(answ);
        //    return answ;
        //}
    }
}
