using System;
using Xunit;
using TestProject;
using Monty_Hall;
using System.Threading;
using System.Linq;

namespace TestProject2
{
    public class SecondUnitTest
    {
        [Fact]
        public void CheckIfTestUsingFakeAnswerAndRealPrize()
        {
            bool playrrWon=true;
            Game game = new();
            game.WhereIsTheCar();
            bool result1=game.carInFirstDoor;
            bool result2=game.carInSecondDoor;
            bool result3=game.carInThirdDoor;
            Assert.Equal(playrrWon, result3);
        }
        [Fact]
        public void CheckSimulatorClassTest()
        {
            Simulator simulator = new();
            simulator.RunSimulator2();
        }
    }
}
