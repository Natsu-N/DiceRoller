using System.ComponentModel;
using System.Windows.Input;
using DiceRoller.Model;
using DiceRoller.Model.Exceptions;
using System.Runtime.CompilerServices;

namespace DiceRoller.VewModel
{
    public class DiceRollViewModel
    {
        public List<string> nameList { get; set; }= new List<string>
        {
            "D4", "D6", "D8", "D10", "D12", "D20", "D100"
        };

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

        private readonly DiceRoll dice = new DiceRoll();


        public ICommand RollCommand { get;  }

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