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
        Game game = new Game(new CodeGenerator(), new GameStatus(), new GameInputValidator());

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

    }
}
