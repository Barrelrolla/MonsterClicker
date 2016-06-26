namespace MonsterClicker
{
    public class Random : System.Random
    {
        private static Random randomGenerator = new Random();
        private static int currentNumber;

        public static new int Next(int maxValue)
        {
            var number = randomGenerator.Next(0, maxValue);
            if (number == currentNumber)
            {
                while (number == currentNumber)
                {
                    number = randomGenerator.Next(0, 5);
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