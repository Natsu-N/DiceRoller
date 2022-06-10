using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DiceRoller.Model;
using DiceRoller.Model.Exceptions;

namespace DiceRoller.VewModel
{
    public class ItemDice: INotifyPropertyChanged
    {
        public string name { get; set; }
        public string diceNumber { get; set; } = "0";
        private readonly DiceRoll dice = new DiceRoll();

        public string result { get; set; }
        public string Result
        {
            get => result;
            set
            {
                result = value;
                RaisePropertyChanged();
            }
        }

        public bool isError;
        public bool IsError
        {

            get => isError;
            set
            {
                isError = value;
                RaisePropertyChanged();
            }
        }

        public ItemDice(string name, string diceNumber)
        {
            this.name = name;
            this.diceNumber = diceNumber;
        }


        private void Roll()
        {
            IsError = false;
            try
            {
                Result = dice.Roll(name, diceNumber);
            }
            catch (DiceException exception)
            {
                Result = exception.Message;
                IsError = true;
            }

        }

        private void RaisePropertyChanged([CallerMemberName] string? property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


        public event PropertyChangedEventHandler? PropertyChanged;


    }
}
