namespace MonsterClicker.Creatures
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Monster : Creature
    {
        private static readonly BigInteger StartHealth = 10;

        public override void GenerateHealth()
        {
            this.NextLevelHealth += (this.NextLevelHealth / 9) < 2 ? 2 : this.NextLevelHealth / 9;
            this.Health = this.NextLevelHealth;
            this.KillCount++;
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / 10 < 1 ? 1 : this.Money / 10;
            this.Experience += this.Experience / 20 < 1 ? 1 : this.Experience / 20;
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