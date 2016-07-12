namespace MonsterClicker.Creatures
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Monster : Creature
    {
        private const int HealthModifier = 9;
        private const int MoneyModifier = 10;
        private const int XPModifier = 20;
        private static readonly BigInteger StartHealth = 10;

        public override void GenerateHealth()
        {
            this.NextLevelHealth += (this.NextLevelHealth / HealthModifier) < 2 ? 2 : this.NextLevelHealth / HealthModifier;
            this.Health = this.NextLevelHealth;
            this.KillCount++;
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / MoneyModifier < 1 ? 1 : this.Money / MoneyModifier;
            this.Experience += this.Experience / XPModifier < 1 ? 1 : this.Experience / XPModifier;
        }

        public override void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[7].Split(' ').ToArray();
            this.Health = BigInteger.Parse(line[1]);
            line = save[8].Split(' ').ToArray();
            this.Money = BigInteger.Parse(line[1]);
            line = save[9].Split(' ').ToArray();
            this.Experience = BigInteger.Parse(line[1]);
            line = save[10].Split(' ').ToArray();
            this.Name = line[1];
            line = save[11].Split(' ').ToArray();
            this.KillCount = BigInteger.Parse(line[1]);
            line = save[12].Split(' ').ToArray();
            this.NextLevelHealth = BigInteger.Parse(line[1]);
        }
    }
}