namespace DiceRoller.Model.Exceptions
{
    public sealed class NonNumericArgumentException : DiceException
    {
        public NonNumericArgumentException( string value) : base($"Argument has non-numeric value '{value}'.")
        {
        }
    }
}
