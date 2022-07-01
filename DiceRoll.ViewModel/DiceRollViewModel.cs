using System.Collections.ObjectModel;
using System.Windows.Input;
using DiceRoller.Model;
using DiceRoller.UiServices;

namespace DiceRoller.ViewModel
{
    public class DiceRollViewModel
    {
        private readonly IMessageService messageService;

        public ObservableCollection<ItemDice> ItemDiceList { get; set; } = new ObservableCollection<ItemDice>()
        {
            new ItemDice("D4", "0"),
            new ItemDice("D6", "0"),
            new ItemDice("D8", "0"),
            new ItemDice("D10", "0"),
            new ItemDice("D12", "0"),
            new ItemDice("D20", "0"),
            new ItemDice("D100", "0"),
        };

        public ICommand RollCommand { get; }

        public DiceRollViewModel(IMessageService messageService)
        {
            this.messageService = messageService;
            RollCommand = new DelegateCommand(Roll);
        }

        public void Roll()
        {
            foreach (var item in ItemDiceList)
            {
                item.Roll(messageService);
            }
        }
    }
}