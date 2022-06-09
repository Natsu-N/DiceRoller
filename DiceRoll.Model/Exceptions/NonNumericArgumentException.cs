using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Model.Exceptions
{
    public sealed class NonNumericArgumentException : DiceException
    {
        public NonNumericArgumentException( string value) : base($"Argument has non-numeric value '{value}'.")
        {
        }
    }
}
