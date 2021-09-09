using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monty_Hall;

namespace TestProject
{
    public class Player : IPlayer
    {
        
        public string Answer()
        {
            string answer = Console.ReadLine().ToUpper();
            return answer;
        }
    }
}
