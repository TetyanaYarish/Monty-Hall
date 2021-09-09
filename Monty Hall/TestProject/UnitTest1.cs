using System;
using Xunit;
using Monty_Hall;
using System.Linq;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool firstDoor = false;
            Doors doors = new(doorsEnum.Door_1);
            bool compareDoors = doors.PriseIsHere();
            Assert.Equal(firstDoor, compareDoors);
        }

        // Create test for door
        [Fact]
        public void TestNumberOfDoors()
        {
            int numberOfDoorInArray = 3;
            var doors = Enum.GetValues(typeof(doorsEnum)).Cast<doorsEnum>();
            int numberOfDoors=doors.Count();
            Assert.Equal(numberOfDoorInArray, numberOfDoors);
        }

        // Create test to ask player which door he would like to open?


        // Create test to ask player if he woul stay or switch?

        [Fact]
        public void CheckIfFakeAnswerWorks()// Check, if player's answer works
        {
            var valOfCards = "N";
            FakePlayer fakeAnswer = new FakePlayer();// Call method fake answer
            string ans = fakeAnswer.Answer();
            Assert.Equal(valOfCards, ans);
        }
    }
}
