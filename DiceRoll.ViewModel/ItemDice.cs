using System.ComponentModel;
using DiceRoller.Model;
using DiceRoller.Model.Exceptions;
using System.Linq;
using Array = System.Array;

namespace DiceRoller.ViewModel
{
    public sealed class ItemDice: INotifyPropertyChanged
    {
        public string DiceName { get; }
        public string DiceNumber { get; set; } = "0";
        private readonly DiceRoll dice = new();

        public int[] Result { get; private set; }
        public string? ResultError { get; private set; }

        public bool IsError { get; private set; }

        public ItemDice(string name, string number)
        {
            DiceName = name;
            DiceNumber = number;

            Result = Array.Empty<int>();
        }

        public void Roll()
        {
            IsError = false;
            try
            {
                Result = dice.Roll(DiceName, DiceNumber).ToArray();
            }
            catch (DiceException exception)
            {
                Result = Array.Empty<int>();
                ResultError = exception.Message;
                IsError = true;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
