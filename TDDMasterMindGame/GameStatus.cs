using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMasterMindGame
{
    public class GameStatus : IGameStatus
    {
        public bool GameIsWon { get; set; }
        public int CorrectNumbers;

        public int CorrectPositions;

        public void getStatus(int[] code, int[] attempt)
        {
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] != attempt[i])
                {
                    GameIsWon = false;
                    break;
                }
                else 
                    GameIsWon = true;
            }
            
        }
    }
}
