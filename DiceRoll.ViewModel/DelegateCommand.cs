using System.Windows.Input;

namespace DiceRoller.ViewModel
{
    internal class DelegateCommand: ICommand
    {
        private readonly Action action;

        public DelegateCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            action();
        }

        public event EventHandler? CanExecuteChanged;
    }
}
