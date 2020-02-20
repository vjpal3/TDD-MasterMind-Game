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

        public string CheckScore(int[] input)
        {
            if (!_validator.isValid(input))
                throw new ArgumentException();

            if(!_validator.inputOutOfBounds(input))
                throw new ArgumentOutOfRangeException();

            if(!_validator.inputNotUnique(input))
                throw new Exception("input values must be unique");

            _gameStatus.getStatus(code, input);
            var result = "Game Status: ";
            if(_gameStatus.GameIsWon)
            {
                result += "Won";
            }
            else
            {
                result += "\nCorrect Numbers: " + _gameStatus.CorrectNumbers;
            }
            
            return result;
        }
    }
}
