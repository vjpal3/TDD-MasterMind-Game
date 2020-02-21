using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDMasterMindGame.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game game;

        [SetUp]
       public void Setup()
        {
            game = new Game(new CodeGenerator(), new GameStatus(), new GameInputValidator());
            game.code = new int[] { 1, 2, 3, 4 };
        }

        [TearDown]
        public void Teardown()
        {
            game = null;
        }
        
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3 })]

        public void ThrowExceptionIfAttemptLenghtIsMoreThan4OrLessThan4(int[] input)
        {
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }

        [TestCase(new int[] { 1, 2, 3, 7 })]
        [TestCase(new int[] { 0, 2, 3, 4 })]
        public void ThrowExceptionIfNumberInAttemptArrayIsGreaterThan6OrLessThan1(int[] input)
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => game.CheckScore(input));

        }

        [Test]
        public void ThrowExceptionIfAllNumbersInAttemptArrayAreNotUnique()
        {
            var input = new int[] { 1, 2, 2, 4 };
            Assert.Throws<Exception>(() => game.CheckScore(input));
        }

        [Test]
        public void IfGameIsWon_ReturnGameStatusIsWonTrue()
        {
            var input = new int[] { 1, 2, 3, 4 };

            var result = game.CheckScore(input);

            var expectedResult = "Game Status: Won\nCorrect Numbers: 4\nCorrect Positions: 4";
            Assert.That(game.code, Is.EquivalentTo(input));
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void If3NumbersAreCorrect_ReturnGameStatusCorrectNumsIs3()
        {
            var input = new int[] { 1, 2, 5, 3 };

            var result = game.CheckScore(input);
            var expectedResult = "Game Status: \nCorrect Numbers: 3\nCorrect Positions: 2";
            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void If2NumbersAreInCorrectPosition_ReturnGameStatusCorrectPositionsIs2()
        {
            var input = new int[] { 1, 2, 3, 5 };

            var result = game.CheckScore(input);
            var expectedResult = "Game Status: \nCorrect Numbers: 3\nCorrect Positions: 3";
            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void CorrectNumbersShouldIgnoreCorrectPositions()
        {
            var input = new int[] { 1, 4, 5, 3 };

            var result = game.CheckScore(input);
            var expectedResult = "Game Status: \nCorrect Numbers: 3\nCorrect Positions: 1";
            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}
