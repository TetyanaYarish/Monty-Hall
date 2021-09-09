using System;
using Xunit;
using Monty_Hall;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool firstDoor = false;
            Doors doors = new(doorsEnum.Door_1);
            bool compareDoors=doors.PriseIsHere();
            Assert.Equal(firstDoor, compareDoors);
        }

        // Create test for door


        // Create test to ask player which door he woult open?
       [Fact] 
        public void CheckIfFakeAnswerClassWorks()// Check, if player's answer works
        {
            var valOfCards = "N";
            FakePlayer fakeAnswer = new FakePlayer();// Call method fake answer
            string ans = fakeAnswer.Answer();
            Assert.Equal(valOfCards, ans);
        } 
        
        
        // Create test to ask player if he woul stay or switch?

        

    }
}
