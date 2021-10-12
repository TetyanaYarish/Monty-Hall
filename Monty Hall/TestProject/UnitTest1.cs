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


        [Fact]//Leave just to have example for exception messages
        public void CheckIfExceptionWorksTest()// Check, if player's answer works
        {
            string expMess = "You did not choose correct answer.";
            IAnswerFromPlayerToChoseTheDoor answerFromPlayer = new AnswerFromPlayerFakeDoorNumber();
            IPlayerAnswer realAnswer = new RealPlayerAnswer(answerFromPlayer);
            var exp = Assert.Throws<MyException>(() => realAnswer.AnswerChooseNumberOfDoor());
            Assert.Equal(expMess, exp.Message);
        }
       //all methods I replaced to 
    }
}