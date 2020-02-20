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
        }

        [TearDown]
        public void Teardown()
        {
            game = null;
        }
        

        [Test]
        public void ThrowExceptionIfAttemptLenghtIsMoreThan4()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 3, 4, 5 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }

        [Test]
        public void ThrowExceptionIfAttemptLengthIsLessThan4()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 3 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }

        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsGreaterThan6()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 3, 7 };
            Assert.Throws<System.ArgumentOutOfRangeException>(() => game.CheckScore(input));

        }

        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsLessThan1()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 0, 2, 3, 4 };
            Assert.Throws<ArgumentOutOfRangeException>(() => game.CheckScore(input));
        }

        [Test]
        public void ThrowExceptionIfAllNumbersInAttemptArrayAreNotUnique()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 2, 4 };

            Assert.Throws<Exception>(() => game.CheckScore(input));

        }

        [Test]
        public void IfGameIsWon_ReturnGameStatusIsWonTrue()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 3, 4 };

            var result = game.CheckScore(input);
            

            Assert.That(result, Is.EqualTo("Game Status: Won"));
        }

        [Test]
        public void If3NumbersAreCorrect_ReturnGameStatusCorrectNumsIs3()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 5, 3 };

            var result = game.CheckScore(input);

            Assert.That(result, Is.EqualTo("Game Status: \nCorrect Numbers: 3"));

        }
    }
}
