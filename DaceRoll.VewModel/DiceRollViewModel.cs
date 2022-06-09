using System.Windows.Input;
using DiceRoller.Model;
namespace DiceRoller.VewModel
{
    public class DiceRollViewModel
    {
        private readonly DiceRoll dice = new DiceRoll();

        public string Dice4Number { get; set; } = "(D4)";
        public string Dice6Number { get; set; } = "(D6)";
        public string Dice8Number { get; set; } = "(D8)";
        public string Dice10Number { get; set; } = "(D10)";
        public string Dice12Number { get; set; } = "(D12)";
        public string Dice20Number { get; set; } = "(D20)";
        public string Dice100Number { get; set; } = "(D100)";

        public string Dice4Result { get; set; } = "(D4)";
        public string Dice6Result { get; set; } = "(D6)";
        public string Dice8Result { get; set; } = "(D8)";
        public string Dice10Result { get; set; } = "(D10)";
        public string Dice12Result { get; set; } = "(D12)";
        public string Dice20Result { get; set; } = "(D20)";
        public string Dice100Result { get; set; } = "(D100)";

        public ICommand RollCommand { get;  }

        public DiceRollViewModel()
        {
            RollCommand = new DelegateCommand(this.Roll);
        }

        private void Roll()
        {

        }


    }
}