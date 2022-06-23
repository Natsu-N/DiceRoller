using System.ComponentModel;
using DiceRoller.Model;
using DiceRoller.Model.Exceptions;

namespace DiceRoller.ViewModel
{
    public class ItemDice: INotifyPropertyChanged
    {
        public string DiceName { get; set; }
        public string DiceNumber { get; set; } = "0";
        private readonly DiceRoll Dice = new();

        public string Result { get; set; }

        public bool IsError { get; set; }

        public ItemDice(string name, string number)
        {
            DiceName = name;
            DiceNumber = number;
        }

        public void Roll()
        {
            IsError = false;
            try
            {
                Result = Dice.Roll(DiceName, DiceNumber);
            }
            catch (DiceException exception)
            {
                Result = exception.Message;
                IsError = true;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
