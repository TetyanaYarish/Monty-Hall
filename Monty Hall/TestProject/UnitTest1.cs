using System;
using Xunit;
using Monty_Hall;
using System.Linq;

namespace TestProject
{
    public class UnitTest1
    {
        //Test check number of prizes

        [Fact]
        public void CheckNumberOfPrizesTest()
        {
            RandomPrizeGenerator door = new();//Act
            door.YourPrize();
            door.YourPrize();
            int num2 = door.listOfPrizes.Count();
            int n = door.CountPrizes();
            Assert.Equal(1, num2);//Assert
            Assert.Equal(1, n);//Assert
            Assert.NotEqual(3, num2);//Assert 
        }
        [Fact]
        public void CheckTheDoorWithLuxuryCarTest()
        {
            string testDoor = "Luxury car";//Arrange
            bool playerWon = true;
            RandomPrizeGenerator door = new(testDoor);//Act
            var door1 = door.YourPrize();
            Game game = new();
            string result = game.PlayerWon();
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
        public void CheckIfExceptionWorksTest()// Check, if player's answer works
        {
            string expMess = "You did not choose correct answer.";
            IPlayer fakeAnswer = new FakePlayer();// Call method with fake answer = "3"
            var exp = Assert.Throws<Exception>(() => fakeAnswer.AnswerStayOrSwitchTheDoor());
            Assert.Equal(expMess, exp.Message);
        }

        // Check if we are open right door with car behind
        [Fact]
        public void CheckPrizeTest()//with a real random prize
        {
            string prize = "Luxury car";
            RandomPrizeGenerator door = new();
            string prize1 = door.YourPrize();
            Assert.Equal(prize, prize1);
        }
        [Fact]
        public void CheckPrize2Test() // Using fake Door class
        {
            string prize = "Luxury car";
            Game door = new();
            IPrize doorFake = new FakePrize();
            string prize1 = doorFake.YourPrize();
            string prize2 = doorFake.YourPrize();
            string prize3 = doorFake.YourPrize();// luxury car is here
            Assert.Equal(prize, prize3);

        }
        [Fact]

        public void CheckFakeAnswerTest()//Pass
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
            IPrize door = new FakePrize();
            door.YourPrize();
            door.ReturnAllPrizes();
            game.Return3Prize();
            Assert.Equal(answ, a1);
        }
        [Fact]
        public void GamePlayerWonTest() // Using fake Door class
        {
            string prize = "Luxury car";
            bool playerWon;
            IPlayer pl = new FakePlayer();
            IPrize fakeDoor = new FakePrize();
            string prize1 = fakeDoor.YourPrize();
            string prize2 = fakeDoor.YourPrize();
            string prize3 = fakeDoor.YourPrize();// luxury car is here
            Game game = new Game();
            // Game.RunTheGame(prize);
            // var playerWinner = game.PlayerWon();
            // Assert.Equal(playerWon, prize3);

        }
    }
}
