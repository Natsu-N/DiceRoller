using System.ComponentModel;
using System.Windows.Input;
using DiceRoller.Model;
using DiceRoller.Model.Exceptions;
using System.Runtime.CompilerServices;

namespace DiceRoller.VewModel
{
    public class DiceRollViewModel: INotifyPropertyChanged
    {
        private readonly DiceRoll dice = new DiceRoll();

        public string Dice4Number { get; set; } = "(D4)";
        public string result { get; set; } = "(D4)";

        public bool isError {

            get => isError;
            set
            {
                isError = value;
                RaisePropertyChanged();
            }
        }

        public string Result
        {
            get => result;
            set
            {
                result = value;
                RaisePropertyChanged();
            }
        }


        public ICommand RollCommand { get;  }

        public DiceRollViewModel()
        {
            RollCommand = new DelegateCommand(this.Roll);
        }

        private void Roll()
        {
            try
            {
                for (int i = 0; i < int.Parse(Dice4Number); i++)
                {
                    Result = dice.Roll("D4").ToString();
                }
            }
            catch (Exception exception)
            {
                result = exception.Message;
                isError = true;
            }

        }

        private void RaisePropertyChanged([CallerMemberName] string? property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


        public event PropertyChangedEventHandler? PropertyChanged;


    }
}