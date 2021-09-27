using System;

namespace ConsoleApp1
{
   public class Program
    {
       public static void Main (string[] args)
        {

            Console.Title = "Monty Hall";
            string title = @"
              MONTY
      __      __            __     __
     /\ \    /\ \          /\ \   /\ \
     \ \ \___\_\ \    ____ \ \ \  \ \ \
      \ \ \_____\ \  /'__'\ \ \ \  \ \ \
       \ \ \   \ \ \/\ \L\.\_\ \ \__\ \ \___
        \ \_\   \ \_\ \_/.\__\\ \____\ \____\
         \/_/    \/_/\/__/|__/ \/____/\/____/
                              
                               
                                                                 ";

            Console.WriteLine(title);
            Console.Read();
        }
    }
}
