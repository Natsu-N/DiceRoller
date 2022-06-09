using DiceRoller.Model.Exceptions;

namespace DiceRoller.Model
{
    public class DiceRoll
    {
        private  readonly  Random _rnd = new Random();
        private Dictionary<string, IDice> DiceSet = new()
        {
            {"D4", new DelegateDice(4)},
            {"D6", new DelegateDice(6)},
            {"D8", new DelegateDice(8)},
            {"D10", new DelegateDice(10)},
            {"D12", new DelegateDice(12)},
            {"D20", new DelegateDice(20)},
            {"D100", new DelegateDice(100)},
        };

        public int Roll(string diceKey)
        {
            if (DiceSet.TryGetValue(diceKey, out var result))
            {
                return result.RollDice();
            }

            throw new DiceNotFoundException(diceKey);
        }
    }
}