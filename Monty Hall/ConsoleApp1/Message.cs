using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Message
    {
        public void Text()
        {

            Console.Title = "Monty Hall";
            string title = @"
          *******  MONTY  *******
      __    __            __     __
     /\ \  /\ \          /\ \   /\ \
     \ \ \_\_\ \    ____ \ \ \  \ \ \
      \ \  ___  \  /'__'\ \ \ \  \ \ \
       \ \ \ \ \ \/\ \L\.\_\ \ \__\ \ \___
        \ \_\ \ \_\ \_/.\__\\ \____\ \____\
         \/_/  \/_/\/__/|__/ \/____/\/____/
                              
                               
                                                                 ";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
}
