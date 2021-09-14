using System;
using Xunit;
using Monty_Hall;
using System.Linq;

namespace TestProject
{
    public class UnitTest1
    {


        //   Create test for door

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

        [Fact]
        public void CheckDoor()
        {
            string ourDoor = "FirstDoor";
            Door door = new();
            var d = door.GetType();
            var name = d.Name;
            Assert.Equal(ourDoor, name);
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
        // create counter to run app 

        // Check if we are open right door with car behind
        [Fact]
        public void CheckPrize()
        {
            string prize = "Luxury car";
            Door door = new();
            string prise = door.YourPrise();
            Assert.Equal(prize, prise);
        }
        [Fact]
        public void CheckPrize2()
        {
            string prize = "Luxury car";
            Game door = new();
            string prise = door.ReturnPrise();
            string prise2 = door.Return2Prise();
            string prise3 = door.Return3Prise();
            door.PlayerChoseFirstDoor();
            door.RandomDoorToShowGoat();
             door.ChoseCorrectDoor();
            Assert.Equal(prize, prise);
          
        }


    }
}
