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

        // Create test to ask player which door he would like to open?
        [Fact]
        public void CheckFakeAnswer()// Check, if player's answer works
        {
            var yes = "Y";
            FakePlayer fakeAnswer = new FakePlayer();// Call method fake answer
            string ans = fakeAnswer.AnswerChooseNumberOfDoor();
            Assert.Equal(yes, ans);
        }

        // Create test to ask player if he woul stay or switch?

        [Fact]
        public void CheckIfFakeAnswerWorks()// Check, if player's answer works
        {
            var valOfCards = "1";
            FakePlayer fakeAnswer = new FakePlayer();// Call method fake answer
            string ans = fakeAnswer.AnswerChooseNumberOfDoor();
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
        public void CheckPrize2() // Unrunned test
        {
            string prize = "Luxury car";
            Game door = new();
            FakePlayer fakeAnsw = new FakePlayer();
           // IPlayer player = new FakePlayer();
            Game.Main(fakeAnsw);
            string prise = door.ReturnPrise();
            string prise2 = door.Return2Prise();
            string prise3 = door.Return3Prise();
            door.PlayerChooseFirstDoor();

            door.ChooseCorrectDoor();
            Assert.Equal(prize, prise3);

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
        public void Test()//
        {
            string answ = "Luxury car";
            IPlayer fakeAnsw = new FakePlayer();
            Game game = new();
            game.ReturnPrise();
            var a1=game.Return2Prise();
            IDoor door = new FakeDoor();
            door.YourPrise();
            door.ReturnAllPrises();
            game.Return3Prise();
            Assert.Equal(answ, a1);
        }
    }
}
