using System.Windows.Input;

namespace DiceRoller.VewModel
{
    internal class DelegateCommand: ICommand
    {
        private readonly Action _action;

        public DelegateCommand(Action action)
        {
            this._action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler? CanExecuteChanged;
    }
}
