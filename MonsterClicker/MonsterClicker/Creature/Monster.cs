namespace MonsterClicker
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Monster : Creature
    {
        private static readonly BigInteger StartHealth = 10;

        public override void GenerateHealth()
        {
            this.nextLevelHealth += (this.nextLevelHealth / 9) < 2 ? 2 : this.nextLevelHealth / 9;
            this.Health = this.nextLevelHealth;
            this.killCount++;
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / 10 < 1 ? 1 : this.Money / 10;
            this.Experience += this.Experience / 20 < 1 ? 1 : this.Experience / 20;
        }

        public override void LoadCreatureState(string text)
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
            this.killCount = BigInteger.Parse(line[1]);
            line = save[12].Split(' ').ToArray();
            this.nextLevelHealth = BigInteger.Parse(line[1]);
        }
    }
}