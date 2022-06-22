using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DiceRoller.Model;
using DiceRoller.Model.Exceptions;

namespace DiceRoller.VewModel
{
    public class ItemDice: INotifyPropertyChanged
    {
        public string DiceName { get; set; }
        public string DiceNumber { get; set; } = "0";
        private readonly DiceRoll Dice = new();

        public string Result { get; set; }

        public bool IsError { get; set; }


        //public string result { get; set; }
        //public string Result
        //{
        //    get => result;
        //    set
        //    {
        //        result = value;
        //        RaisePropertyChanged();
        //    }
        //}

        //public bool isError;
        //public bool IsError
        //{

        //    get => isError;
        //    set
        //    {
        //        isError = value;
        //        RaisePropertyChanged();
        //    }
        //}

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
