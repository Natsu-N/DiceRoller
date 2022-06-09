namespace DiceRoller.Model.Exceptions
{
    internal class DiceNotFoundException : DiceException
    {
        public DiceNotFoundException(string dice) : base($"Dice {dice} is not found"){}
    }
}