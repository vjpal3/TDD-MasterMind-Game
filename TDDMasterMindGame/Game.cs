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

        public bool CheckScore(int[] input)
        {
            if (!_validator.isValid(input))
                throw new ArgumentException();

            if(!_validator.inputOutOfBounds(input))
                throw new ArgumentOutOfRangeException();

            var uniqueValues = new HashSet<int>(input);

            if (uniqueValues.Count() != input.Length)
                throw new Exception("input values must be unique");

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] != input[i])
                    return false;
            }

            return true ;
        }
    }
}
