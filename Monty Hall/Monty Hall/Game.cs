using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Game
    {
        internal string DoorOne { get; }
        internal string DoorTwo { get; }
        internal string DoorThree { get; }
        bool prizeInFirstDoor = false;
        bool prizeInSecondDoor = false;
        bool prizeInThirdDoor = false;
        string luxCar = "Luxury car";
        string goat = "Goat";
        bool showGoat = false;
        Door door = new();
        public string ReturnPrise()
        {
            var door1 = door.YourPrise();
            if (door1 == luxCar)
            {
                prizeInFirstDoor = true;
            }
            return door1;
        }
        public string Return2Prise()
        {
            var door1 = door.YourPrise();
            if (door1 == luxCar)
            {
                prizeInSecondDoor = true;
            }
            return door1;
        }

        public string Return3Prise()
        {
            var door1 = door.YourPrise();
            if (door1 == luxCar)
            {
                prizeInThirdDoor = true;
            }
            return door1;
        }
        public void ChoseCorrectDoor()
        {
            if (prizeInFirstDoor)
            {
                Console.WriteLine("First door");
            }
            else if (prizeInSecondDoor)
            {
                Console.WriteLine("Second door");
            }

            else if (prizeInThirdDoor)
            {
                Console.WriteLine("Third door");
            }
        }
        public void PlayerChoseFirstDoor()
        {
            if (!prizeInSecondDoor || !prizeInThirdDoor)
            {
                Console.WriteLine("Second door or Trird door.");
            }
           
        }   
        public void PlayerChoseSecondDoor()
        {
            if (!prizeInFirstDoor || !prizeInThirdDoor)
            {
                Console.WriteLine("First door or Trird door.");
            }
           
        }
        public void PlayerChoseThirdDoor()
        {
            if(!prizeInFirstDoor || !prizeInThirdDoor)
            {
                Console.WriteLine("First door or Second door.");
            }
        }
        public void ChoseWhereIsGoat()
        {
            if (!prizeInFirstDoor || !prizeInThirdDoor)
            {
                Console.WriteLine("First door or Trird door");
            }
            else if (!prizeInSecondDoor || !prizeInThirdDoor)
            {
                Console.WriteLine("Second door ");
            }
            else if (prizeInThirdDoor)
            {
                Console.WriteLine("Third door");
            }
        }
    }
}
