using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMasterMindGame
{
    public class GameInputValidator
    {
        public bool isValid(int[] attempt)
        {
            if (attempt.Length > 4 || attempt.Length < 4)
            {
                return false;
            }
            return true;
        }
        private bool inputOutofBounds(int[] attempt)
        {
            throw new NotImplementedException();

        }

        private bool inputNotUnique(int[] attempt)
        {
            throw new NotImplementedException();
        }
    }
}
