using System;
using Xunit;
using Monty_Hall;
using System.Linq;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestCheckTheDoor()
        {
            string testDoor = "Goat";//Arrange
            Door door = new(testDoor);//Act
            var door1 = door.YourPrize();
            Assert.Equal(testDoor, door1);//Assert
        }
        [Fact]
        public void TestCheckTheDoorWithLuxuryCar()
        {
            string testDoor = "Luxury car";//Arrange
            Door door = new(testDoor);//Act
            var door1 = door.YourPrize();
            Assert.Equal(testDoor, door1);
        }

        // Create test to ask player which door he would like to open?
        [Fact]
        public void CheckFakeAnswer()// Check, if player's answer works
        {
            var yes = "1";
            FakePlayer fakeAnswer = new FakePlayer();// Call method fake answer
            string ans = fakeAnswer.AnswerChooseNumberOfDoor();
            Assert.Equal(yes, ans);
        }

        // Create test to ask player if he woul stay or switch?

        [Fact]
        public void CheckIfExceptionWorks()// Check, if player's answer works
        {
            string expMess = "You did not choose correct answer.";
            IPlayer fakeAnswer = new FakePlayer();// Call method with fake answer = "3"
            var exp =Assert.Throws<Exception>(()=> fakeAnswer.AnswerStayOrSwitchTheDoor());
            Assert.Equal(expMess, exp.Message);
        }
       
        // Check if we are open right door with car behind
        [Fact]
        public void CheckPrize()//with a real random prize
        {
            string prize = "Luxury car";
            Door door = new();
            string prize1 = door.YourPrize();
            Assert.Equal(prize, prize1);
        }
        [Fact]
        public void CheckPrize2() // Using fake Door class
        {
            string prize = "Luxury car";
            Game door = new();
            IDoor doorFake = new FakeDoor();
            string prize1 = doorFake.YourPrize();
            string prize2 = doorFake.YourPrize();
            string prize3 = doorFake.YourPrize();// luxury car is here
            Assert.Equal(prize, prize3);

        }
        [Fact]

        public void TestFakeAnswer()//Pass
        {
            string answ = "1";
            FakePlayer fakeAnsw = new FakePlayer();
            string answer = fakeAnsw.AnswerChooseNumberOfDoor();
            Assert.Equal(answ, answer);
        }
        [Fact]
        public void TestJustTest()// Testing all functions from fake and real .cs
        {
            string answ = "Luxury car";
            IPlayer fakeAnsw = new FakePlayer();
            Game game = new();
            game.ReturnPrize();
            var a1 = game.Return2Prize();
            IDoor door = new FakeDoor();
            door.YourPrize();
            door.ReturnAllPrizes();
            game.Return3Prize();
            Assert.Equal(answ, a1);
        }
    }
}
