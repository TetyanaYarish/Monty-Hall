using System;
using Xunit;
using Monty_Hall;
using System.Linq;
using System.Threading;

namespace TestProject
{
    public class UnitTest1
    {
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
           Assert.Equal(1, n);//Assert Second method
            Assert.NotEqual(3, num2);//Assert Third method
        }
        [Fact]
        public void CheckRandomPrizeGeneratorClassTest()
        {
            string testDoor1 = "Luxury car";//Arrange
            string testDoor2 = "Goat";//Arrange
            string testDoor3 = "Goat";//Arrange
            RandomPrizeGenerator door = new();//Act
            door.YourPrize();
            door.YourPrize();
            var door3 = door.YourPrize();
            bool someOfDoorsHasCarBehind = false;
            if (door3 == testDoor1 || door3 == testDoor2 || door3 == testDoor3)
            {
                someOfDoorsHasCarBehind = true;
            };
            Assert.True(someOfDoorsHasCarBehind);
        }

        // Create test to ask player which door he would like to open?
        [Fact]
        public void ReturnCarBehindFirstDoorTestUsingFakePrizeClass()
        {
            IPrize prize1 = new FakePrize();
            Game game = new(prize1);
            game.WhereIsTheCar();
            bool first = game.carInFirstDoor;
            bool second = game.carInSecondDoor;
            bool third = game.carInThirdDoor;
            Assert.True(first);
        }

        // Create test to ask player if he woul stay or switch?

        [Fact]
        public void CheckIfExceptionWorksTest()// Check, if player's answer works
        {
            string expMess = "You did not choose correct answer.";
            IPlayerAnswer fakeAnswer2 = new FakePlayerAnswer();
            IPlayerAnswer fakeAnswer = new RealPlayerAnswer(fakeAnswer2);
            var exp = Assert.Throws<MyException>(() => fakeAnswer2.AnswerChooseNumberOfDoor());
            // fakeAnswer.AnswerStayOrSwitchTheDoor();
            Assert.Equal(expMess, exp.Message);
        }

        [Fact]
        public void GreetingMessages()
        {
            string greeting = "THIS IS THE MONTY HALL GAME!\n\nPrize behind the door 1: XX\nPrize behind the door 2: XX\nPrize behind the door 3: XX\n";
            RunTheGame runGame = new();
            var start = runGame.Greetings();
            Assert.Equal(greeting, start);
        }
        [Fact]
        public void CheckNuberOfDoorsWithCarAndNumberOPfDoorsWithGoatsBehind()
        {
            var expectedNumberOfCar = 1;
            var actualNumberOfCar = 0;
            var expectedNumberOfGoat = 2;
            var actualNumberOfGoat = 0;
            RandomPrizeGenerator randomPrize = new();
            foreach (var prize in randomPrize.listOfPrizes)
            {
                if (prize == "Goat")
                {
                    actualNumberOfGoat++;
                }

            }

            foreach (var prize in randomPrize.listOfPrizes)
            {
                if (prize == "Luxury car")
                {
                    actualNumberOfCar++;
                }

            }
            Assert.Equal(expectedNumberOfCar, actualNumberOfCar);
            Assert.Equal(expectedNumberOfGoat, actualNumberOfGoat);
        }

        [Fact]
        public void CheckNuberOfPrizes()
        {
            var expectedNumber = 3;
            RandomPrizeGenerator randomPrize = new();
            var num = randomPrize.listOfPrizes.Count();
            Assert.Equal(expectedNumber, num);
        }
        [Fact]
        public void ChectIfTestUsingFakeAnswerAndFakePrize()
        {
            IPrize prize = new FakePrize();
            IPlayerAnswer playerAnswer = new RealPlayerAnswer();
            var pr = prize.YourPrize();
            RunTheGame runGame = new();
            Game game = new();
            var door = game.DoorWithCarBehind();
            runGame.StartGame(playerAnswer, prize);
            game.WhereIsTheCar();
            Assert.Equal(pr, door);
        }

        [Fact]
        public void TestJustAllClassesAndFunctionsDebugToSeeAllOutcomes()
        {/*
            IPlayer fakeplayer = new FakePlayer();
            IPrize fakePrize = new FakePrize();
            var numberOfDoor = fakeplayer.AnswerChooseNumberOfDoor();
            var stayOrSwitch = fakeplayer.AnswerStayOrSwitchTheDoor();*/
            Game game = new();/*
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
            game.PlayerWon();*/
            game.DoorWithCarBehind();
            var true1 = game.carInFirstDoor;

        }
    }
}