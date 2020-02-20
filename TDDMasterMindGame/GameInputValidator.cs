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
        public bool inputOutOfBounds(int[] attempt)
        {
            for(var i=0; i < attempt.Length; i++)
            {
                if (attempt[i] > 6 || attempt[i] < 1)
                    return false;
            }
            return true;
        }

        public bool inputNotUnique(int[] attempt)
        {
            throw new NotImplementedException();
        }
    }
}
