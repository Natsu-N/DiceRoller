using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DiceRoller.UiServices;

namespace DiceRoller
{
    internal class MessageService : IMessageService
    {
        private readonly Window owner;

        public MessageService(Window owner)
        {
            this.owner = owner;
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(owner, message, null, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
