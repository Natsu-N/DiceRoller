using System.Windows.Input;
using DiceRoller.Model;


namespace DiceRoller.VewModel
{
    public class DiceRollViewModel
    {
        public List<ItemDice> itemDiceList { get; set; } = new List<ItemDice>()
        {
            new ItemDice("D4", "0"),
            new ItemDice("D6", "0"),
            new ItemDice("D8", "0"),
            new ItemDice("D10", "0"),
            new ItemDice("D12", "0"),
            new ItemDice("D20", "0"),
            new ItemDice("D100", "0"),
        };

        public ICommand RollCommand { get; }

        public DiceRollViewModel()
        {
            RollCommand = new DelegateCommand(Roll);
        }

        public void Roll()
        {
            foreach (var item in itemDiceList)
            {
                item.Roll();
            }
        }

    }
}