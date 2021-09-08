using System;
using Xunit;
using Monty_Hall;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool firstDoor = false;
            Doors doors = new(doorsEnum.Door_1);
            bool compareDoors=doors.PriseIsHere();
            Assert.Equal(firstDoor, compareDoors);
        }
    }
}
