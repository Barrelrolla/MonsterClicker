namespace MonsterClicker.Exceptions
{
    using System;

    class NoMoneyException : Exception
    {
        public NoMoneyException (string message) : base (message)
        {
        }
    }
}
