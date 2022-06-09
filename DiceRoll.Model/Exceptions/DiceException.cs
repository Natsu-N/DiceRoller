using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Model.Exceptions
{
    public class DiceException: Exception
    {
        protected DiceException() : base()
        {
        }

        protected DiceException(string reason) : base(reason)
        {
        }

        protected DiceException(string reason, Exception innerException) : base(reason, innerException)
        {
        }
    }
}
