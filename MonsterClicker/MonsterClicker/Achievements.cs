namespace MonsterClicker
{
    public class Achievements
    {
        private bool killed100Monsters;
        private bool collected1mMoney;
        private bool dealt1mDamage;
        private bool clicked100times;

        public bool Killed100Monsters
        {
            get { return this.killed100Monsters; }
            set { this.killed100Monsters = value; }
        }

        public bool Collected1mMoney
        {
            get { return this.collected1mMoney; }
            set { this.collected1mMoney = value; }
        }

        public bool Dealt1mDamage
        {
            get { return this.dealt1mDamage; }
            set { this.dealt1mDamage = value; }
        }

        public bool Clicked100Times
        {
            get { return this.clicked100times; }
            set { this.clicked100times = value; }
        }
    }
}
