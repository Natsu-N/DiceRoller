using System.Runtime.Serialization.Formatters;
using DiceRoller.Model.Exceptions;

namespace DiceRoller.Model
{
    public class DiceRoll
    {
        private readonly Dictionary<string, IDice> DiceSet = new()
        {
            {"D4", new DelegateDice(4)},
            {"D6", new DelegateDice(6)},
            {"D8", new DelegateDice(8)},
            {"D10", new DelegateDice(10)},
            {"D12", new DelegateDice(12)},
            {"D20", new DelegateDice(20)},
            {"D100", new DelegateDice(100)},
        };

        public string Roll(string diceKey, string number)
        {
            var resultSet = "";
            var dice = GetDice(diceKey);
            var numberOfDice = GetDiceNumber(number);
            for (int i = 0; i < numberOfDice; i++)
            {
                resultSet += dice.RollDice() + "  \n";
            }
            return resultSet;
        }

        private int GetDiceNumber(string number)
        {
            if (int.TryParse(number, out var result))
            {
                if (result >= 0)
                {
                    return result;
                }
                throw new NumberLessThanZeroException(number);
            }

            throw new NonNumericArgumentException(number);
        }

        private IDice GetDice(string diceKey)
        {
            if (DiceSet.TryGetValue(diceKey, out var result))
            {
                return result;
            }
            throw new DiceNotFoundException(diceKey);
        }

    }
}