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

        public void TestCheckTheDoor()
        {
            string testDoor = "Goat";//Arrange
            Door door = new(testDoor);//Act
            var door1 = door.YourPrise();
            Assert.Equal(testDoor, door1);
        }   
        [Fact]

        public void TestCheckTheDoorWithLuxuryCar()
        {
            string testDoor = "Luxury car";//Arrange
            Door door = new(testDoor);//Act
            var door1 = door.YourPrise();
            Assert.Equal(testDoor, door1);
        }

        //[Fact]
        //public void CheckDoor()
        //{
        //    string ourDoor = "FirstDoor";
        //    Door door = new();
        //    var d = door.GetType();
        //    var name = d.Name;
        //    Assert.Equal(ourDoor, name);
        //}

        [Fact]
        public void TestNumberOfDoors()
        {
            int numberOfDoorsInArray = 3;
            var doors = Enum.GetValues(typeof(doorsEnum)).Cast<doorsEnum>();
            int numberOfDoors = doors.Count();
            Assert.Equal(numberOfDoorsInArray, numberOfDoors);
        }

        // Create test to ask player which door he would like to open?
        [Fact]
        public void CheckFakeAnswer()// Check, if player's answer works
        {
            var yes = "Y";
            FakePlayer fakeAnswer = new FakePlayer();// Call method fake answer
            string ans = fakeAnswer.Answer();
            Assert.Equal(yes, ans);
        }

        // Create test to ask player if he woul stay or switch?

        [Fact]
        public void CheckIfFakeAnswerWorks()// Check, if player's answer works
        {
            var valOfCards = "Y";
            FakePlayer fakeAnswer = new FakePlayer();// Call method fake answer
            string ans = fakeAnswer.Answer();
            Assert.Equal(valOfCards, ans);
        }
    }
}
