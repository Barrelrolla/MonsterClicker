namespace MonsterClicker
{
    using System.Numerics;

    public class Monster : Creature
    {
        private static readonly BigInteger StartHealth = 10;
        private BigInteger nextLevelHealth = StartHealth;
        private BigInteger killCount = 1;

        public delegate void AchievementHandler(object sender, AchievementArgs a);

        public event AchievementHandler OnKillsReached;

        public override void GenerateHealth()
        {
            this.nextLevelHealth += this.nextLevelHealth / 7;
            this.Health = this.nextLevelHealth;
            this.killCount++;
            if (this.killCount == 100)
            {
                AchievementArgs killsAchievemnt = new AchievementArgs("Killed 100 monsters!");
                this.OnKillsReached(this, killsAchievemnt);
            }
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / 10 < 1 ? 1 : this.Money / 10;
            this.Experience += this.Experience / 20 < 1 ? 1 : this.Experience / 20;
        }
    }
}