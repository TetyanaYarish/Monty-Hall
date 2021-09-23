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
            int num1 = door.listOfPrizes.Count();
            Assert.Equal(3, num1);   // Three prisez on the begin       
            door.YourPrize();
            door.YourPrize();
            int num2 = door.listOfPrizes.Count();
            int n = door.CountPrizes();
            Assert.Equal(1, num2);//One prise at the end
            //Assert.Equal(1, n);//Assert Second method
            //Assert.NotEqual(3, num2);//Assert Third method
        }
        [Fact]
        public void CheckTheDoorWithLuxuryCarTest()
        {
            string testDoor = "Luxury car";//Arrange
            RandomPrizeGenerator door = new();//Act
            var door1 = door.YourPrize();
            Assert.Equal(testDoor, door1);
        }

        // Create test to ask player which door he would like to open?
        [Fact]
        public void ReturnCarBehindFirstDoorTest()// Using Fake Prize class
        {
            Game game = new();
            IPrize prize1 = new FakePrize();
            var one=prize1.YourPrize();
            prize1.YourPrize();
           var n= game.ReturnPrizeBehindFirstDoor(prize1);
            var t=game.carInFirstDoor;
            Assert.True( t);
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
        public void CheckRealRandomPrizeTest()//with a real random prize. result will depend on random method.
        {
            string prize = "Luxury car";
            RandomPrizeGenerator prizeRandom = new();
            string prize1 = prizeRandom.YourPrize();
            Assert.Equal(prize, prize1);
        }
        [Fact]
        public void CheckPrize2Test() // Using fake Prize class** 
        {
            string prize = "Luxury car";
            Game game = new();
            IPrize fakePrize = new FakePrize();
            string prize1 = fakePrize.YourPrize();
            //string prize2 = fakePrize.YourPrize();
            string prize3 = fakePrize.YourPrize();
            var co=game.ReturnPrizeBehindThirdDoor(fakePrize);
            game.ResultOfGame();
            var won=game.PlayerWon();
            var lose = game.PlayerLose();
            var won1 = game.PlayerWon();

            // luxury car is here
            Assert.Equal(prize, prize3);
        }
        [Fact]
        public void TestRandomPrizeGeneratorClass()
        {
            RandomPrizeGenerator prize = new();
            IPrize prize1 = new FakePrize();
            prize.ReturnYourPrize(prize1);
        }

        [Fact]
        public void TestJustGameClassTest()// Testing all functions from fake and real .cs
        {

            Game game = new();
            IPrize prize = new FakePrize();
            var pr = prize.YourPrize();
            game.ReturnPrizeBehindFirstDoor(prize);
            game.ReturnPrizeBehindSecondDoor(prize);
            game.ReturnPrizeBehindThirdDoor(prize);
            var first = game.PlayerChooseFirstDoor();
            var second = game.PlayerChooseSecondDoor();
            var third = game.PlayerChooseThirdDoor();
            var playerLose = game.PlayerLose();
            var playerWon = game.PlayerWon();
            var door = game.DoorWithCarBehind();

            //Assert.Equal(answ,);
        }
        [Fact]
        public void TestJustPlayerClass()
        {
                string one = "1";
                FakePlayer fakeplayer = new FakePlayer();
                IPrize fakePrize = new FakePrize();
                var numberOfDoor = fakeplayer.AnswerChooseNumberOfDoor();
                var stayOrSwitch = fakeplayer.AnswerStayOrSwitchTheDoor();
                Game game = new();
                RandomPrizeGenerator pr = new();
                RunTheGame runTheGame = new();
                var start = runTheGame.Greetings();
                fakePrize.YourPrize();
                RunTheGame.StartGame(fakeplayer);
           
        }
        [Fact]
        public void TestJustRunTheGameClass()
        {
            Game game = new();
            RunTheGame runGame = new();
            runGame.Greetings();
            RandomPrizeGenerator generator = new();
            IPlayer player =new FakePlayer();
            RunTheGame.StartGame(player);
            IPrize prize1 = new FakePrize();
            IPrize prize2 = new FakePrize();
            IPrize prize3 = new FakePrize();

            game.ReturnPrizeBehindFirstDoor(prize1);
            game.ReturnPrizeBehindSecondDoor(prize2);
            game.ReturnPrizeBehindThirdDoor(prize3);
            generator.ReturnAllPrizes();
            game.PlayerWon();
            var corr=game.DoorWithCarBehind();
            var n=corr.Count();
            var m=corr.Contains("l");
        }
    }
}