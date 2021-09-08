using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
   public enum doorsEnum
    {
        Door_1,
        Door_2,
        Door_3
    }
    public class Doors
    {

        public doorsEnum Door { get; }
     

        string[] doors = { "Door 1", "Door 2", "Door 3" };
        public void GetDoor()
        {
            for (int i = 0; i < doors.Length; i++)
            {
                Console.WriteLine(doors[i]);
            }
        }
        public Doors(doorsEnum enumDoor)
        {
            Door = enumDoor;
        }
        public bool PriseIsHere()
        {
            return true;
        }
    }
}
