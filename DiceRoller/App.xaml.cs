using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DiceRoller.UiServices;

namespace DiceRoller
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var window = new MainWindow();
            IMessageService messageService = new MessageService(window);

            var vm = new ViewModel.DiceRollViewModel(messageService);

            window.DataContext = vm;


            window.Show();
        }
    }
}
