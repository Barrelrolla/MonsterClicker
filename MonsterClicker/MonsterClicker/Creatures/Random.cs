namespace MonsterClicker.Creatures
{
    public class Random : System.Random
    {
        private static readonly Random RandomGenerator = new Random();
        private static int currentNumber;

        public static new int Next(int maxValue)
        {
            var number = RandomGenerator.Next(0, maxValue);
            if (number == currentNumber)
            {
                while (number == currentNumber)
                {
                    number = RandomGenerator.Next(0, 5);
                }
            }
            else
            {
                currentNumber = number;
            }

            return number;
        }
    }
}