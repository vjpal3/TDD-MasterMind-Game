using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMasterMindGame
{
    public class Game
    {
        private readonly ICodeGenerator _codeGenerator;
        private readonly IGameStatus _gameStatus;

        private readonly GameInputValidator _validator;
        public int[] code;

        
        public Game(ICodeGenerator generator, GameStatus gameStatus, GameInputValidator validator)
        {
            _codeGenerator = generator;
            code = _codeGenerator.Generate();
            _gameStatus = gameStatus;
            _validator = validator;
        }

        public void CheckScore(int[] input)
        {
            if(input.Length > 4 || input.Length < 4)
            {
                throw new ArgumentException();
            }
        }
    }
}
