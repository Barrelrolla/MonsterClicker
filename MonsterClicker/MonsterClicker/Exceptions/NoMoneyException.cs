namespace MonsterClicker.Exceptions
{
    using System;

    public class NoMoneyException : Exception
    {
        public NoMoneyException(string message) : base(message)
        {
        }
    }
}
