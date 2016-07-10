namespace MonsterClicker.Achievments
{
    using System;
    using System.Linq;
    using System.Text;
    using Interfaces;

    public class Achievements : ISaveable
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

        public string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"Killed100monsters: {this.killed100Monsters}");
            save.AppendLine($"Collected1mMoney: {this.collected1mMoney}");
            save.AppendLine($"Dealt1mDamage: {this.dealt1mDamage}");
            save.AppendLine($"Clicked100Times: {this.clicked100times}");
            return save.ToString();
        }

        public void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[30].Split(' ').ToArray();
            this.killed100Monsters = Convert.ToBoolean(line[1]);
            line = save[31].Split(' ').ToArray();
            this.collected1mMoney = Convert.ToBoolean(line[1]);
            line = save[32].Split(' ').ToArray();
            this.dealt1mDamage = Convert.ToBoolean(line[1]);
            line = save[33].Split(' ').ToArray();
            this.clicked100times = Convert.ToBoolean(line[1]);
            line = save[4].Split(' ').ToArray();
        }
    }
}
