namespace MonsterClicker
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Boss : Creature
    {
        public Boss(Creature creature)
        {
            this.Health = creature.Health;
        }

        public override void GenerateHealth()
        {
            this.Health *= 5;
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / 2;
            this.Experience += this.Experience / 4;
        }

        public override void LoadCreatureState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[11].Split(' ').ToArray();
            this.Health = BigInteger.Parse(line[1]);
            line = save[12].Split(' ').ToArray();
            this.Money = BigInteger.Parse(line[1]);
            line = save[13].Split(' ').ToArray();
            this.Experience = BigInteger.Parse(line[1]);
            line = save[14].Split(' ').ToArray();
            this.Name = line[1];
        }
    }
}