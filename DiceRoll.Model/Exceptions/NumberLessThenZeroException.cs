using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Model.Exceptions
{
    public sealed class NumberLessThenZeroException : DiceException
    {
        public NumberLessThenZeroException(string value) : base($"Argument has less the zero value '{value}'.")
        {
        }
    }
}
