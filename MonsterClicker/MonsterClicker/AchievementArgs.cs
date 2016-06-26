namespace MonsterClicker
{
    using System;

    public class AchievementArgs : EventArgs
    {
        private string message;

        public AchievementArgs(string text)
        {
            this.Message = text;
        }

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
