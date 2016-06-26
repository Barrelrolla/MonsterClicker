namespace MonsterClicker.Exceptions
{
    using System;

    public class NoHealthException : Exception
    {
        public NoHealthException(string message) : base(message)
        {
        }
    }
}