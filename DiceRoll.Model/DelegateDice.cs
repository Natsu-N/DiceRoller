namespace DiceRoller.Model
{
    internal class DelegateDice: IDice
    {
        private readonly Random rnd = new Random();
        private readonly int diceDimension;

        public DelegateDice(int diceDimension)
        {
            this.diceDimension = diceDimension;
        }

        public int RollDice()
        {
            return rnd.Next(1, diceDimension + 1);
        }
      
    }
}
