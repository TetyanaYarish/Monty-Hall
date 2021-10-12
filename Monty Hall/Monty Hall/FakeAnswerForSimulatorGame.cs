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
        List<int> fakeAnswer = new List<int>() { 2, 2,3,1 };//Door number 3, then swittch the door.
        //int fakeAnswer2;
        
        AnswerFromPlayerFromConsoleReadLine answer = new();
        //
        public string AnswerChooseNumberOfDoor()
        {
            var numberOfDoor = "";
            Random random = new Random();
            numberOfDoor = random.Next(1, 4).ToString();
            return numberOfDoor;
        }
        public int ReadTheAnswerFromPlayerAndKeepIt()
        {
            int fakeAnswer2 = Convert.ToInt32(Console.ReadLine());
            return fakeAnswer2;
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

            return answ;
        }
    }
}
