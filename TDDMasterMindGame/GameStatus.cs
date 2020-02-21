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
        public int CorrectNumbers { get; set; }

        public int CorrectPositions { get; set; }

        public void getStatus(int[] code, int[] attempt)
        {
            

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == attempt[i])
                {
                    CorrectPositions++;
                    CorrectNumbers++;
                    continue;
                }
                else if(attempt.Contains(code[i]))
                {
                    CorrectNumbers++;
                }
                    
            }

            if (CorrectNumbers == code.Length && CorrectPositions == code.Length)
                GameIsWon = true;
            else
                GameIsWon = false;
        }
    }
}
