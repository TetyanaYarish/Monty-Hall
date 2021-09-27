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
            door.YourPrize();
            door.YourPrize();
            var door1 = door.YourPrize();
            Assert.Equal(testDoor, door1);
        }

        // Create test to ask player which door he would like to open?
        [Fact]
        public void ReturnCarBehindFirstDoorTest()// Using Fake Prize class
        {
            Game game = new();
            IPrize prize1 = new FakePrize();
            prize1.YourPrize();
            prize1.YourPrize();
            var n = game.ReturnPrizeBehindFirstDoor(prize1);
            bool t = game.carInFirstDoor;
            Assert.True(t);
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
        public void CheckIfPlayerWonTestUsingRandomPrizeGeneratorClass() // Using real Prize class but fake answer** ASK Simon
        {
            bool playerWon = false;
            Game game = new();
            IPlayer fakeplayer = new FakePlayer();
            RunTheGame.StartGame(fakeplayer); //Player chooses door #3 and then switched the door 
            bool res = game.ResultOfGame();
            Assert.Equal(playerWon, res);
        }
        
        [Fact]
        public void GreetingMessages()
        {
            string greeting= "THIS IS THE MONTY HALL GAME!\n\nPrize behind the door 1: XX\nPrize behind the door 2: XX\nPrize behind the door 3: XX\n";
            RunTheGame runGame = new();
            var start = runGame.Greetings();
            Assert.Equal(greeting, start);
        }
        [Fact]
        public void TestJustAllClassesAndFunctions()
        {
            IPlayer fakeplayer = new FakePlayer();
            IPrize fakePrize = new FakePrize();
            var numberOfDoor = fakeplayer.AnswerChooseNumberOfDoor();
            var stayOrSwitch = fakeplayer.AnswerStayOrSwitchTheDoor();
            Game game = new();
            RandomPrizeGenerator randomPrize = new();
            RunTheGame runGame = new();
            var start = runGame.Greetings();
            RunTheGame.StartGame(fakeplayer);
            var pr00 = fakePrize.YourPrize(); //null
            var pr0 = fakePrize.YourPrize(); //Goat
            var pr1 = game.ReturnPrizeBehindFirstDoor(fakePrize); //LC
            var pr2 = game.ReturnPrizeBehindSecondDoor(fakePrize); //null
            var pr3 = game.ReturnPrizeBehindThirdDoor(fakePrize); //null
            var first = game.PlayerChooseFirstDoor(); //1
            var second = game.PlayerChooseSecondDoor(); //2
            var third = game.PlayerChooseThirdDoor(); //3
            var playerLose = game.PlayerLose(); //False
            var playerWon = game.PlayerWon(); //True
            var door = game.DoorWithCarBehind(); //!
            runGame.Greetings();
            RandomPrizeGenerator generator = new();
            IPlayer player = new FakePlayer();// Double
            RunTheGame.StartGame(player);//Double
            IPrize prize1 = new FakePrize();
            IPrize prize2 = new FakePrize();
            IPrize prize3 = new FakePrize();
            game.ReturnPrizeBehindFirstDoor(prize1); //LC and Goat 1
            game.ReturnPrizeBehindSecondDoor(prize2);
            game.ReturnPrizeBehindThirdDoor(prize3);
            generator.ReturnAllPrizes();
            game.PlayerWon();
            var corr = game.DoorWithCarBehind();
            var n = corr.Count();
            var m = corr.Contains("l");
        }
    }
}