using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Model.Exceptions
{
    public sealed class NumberLessThanZeroException : DiceException
    {
        public NumberLessThanZeroException(string value) : base($"Argument has less than zero value '{value}'.")
        {
        }
    }
}
