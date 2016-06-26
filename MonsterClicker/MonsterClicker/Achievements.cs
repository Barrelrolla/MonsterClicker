namespace MonsterClicker
{
    public class Achievements
    {
        private bool killed100Monsters;

        public Achievements()
        {
            this.Killed100Monsters = false;
        }

        public bool Killed100Monsters
        {
            get { return this.killed100Monsters; }
            set { this.killed100Monsters = value; }
        }
    }
}
