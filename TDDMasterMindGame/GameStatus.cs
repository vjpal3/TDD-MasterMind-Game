using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMasterMindGame
{
    public class GameStatus : IGameStatus
    {
        public bool GameIsWon;
        public int CorrectNumbers;

        public int CorrectPositions;
    }
}
