using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Model
{
    internal class DelegateDice: IDice
    {
        private readonly Random _rnd = new Random();
        private readonly int Dicemension;

        public DelegateDice(int args)
        {
            this.Dicemension = args;
        }

        public int RollDice()
        {
            return _rnd.Next(1, Dicemension);
        }
      
    }
}
