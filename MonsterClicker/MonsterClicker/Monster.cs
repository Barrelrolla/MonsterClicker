namespace MonsterClicker
{
    using Interfaces;
    using System.Numerics;
    public class Monster : IMonster
    {
        private BigInteger health;
        private static BigInteger startHealth = 10;
        private BigInteger nextLevelHealth = startHealth + 1;

        public Monster()
        {
            this.Health = startHealth;
        }

        public BigInteger Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public void TakeDamage(BigInteger damage)
        {
            this.Health -= damage;            
        }

        public void GenerateHealth()
        {
            nextLevelHealth +=  (nextLevelHealth / 10);
            this.health = nextLevelHealth;
        }

        
    }
}