namespace MonsterClicker
{
    public struct Achievements
    {
        private bool killed100Monsters;

        public bool Killed100Monsters
        {
            get { return this.killed100Monsters; }
            set { this.killed100Monsters = value; }
        }
    }
}
