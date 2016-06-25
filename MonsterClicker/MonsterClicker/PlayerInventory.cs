namespace MonsterClicker
{
    using System.Numerics;
    using MonsterClicker.Interfaces;

    class PlayerInventory : IInventory
    {
        private BigInteger money;
        private BigInteger experienceNeeded;

        public PlayerInventory(BigInteger money, BigInteger experience)
        {
            this.Money = money;
            this.Experience = experience;
        }

        public BigInteger Experience
        {
            get { return this.experienceNeeded; } 
            set { this.experienceNeeded = value; }
        }

        public BigInteger Money
        {
            get { return this.money; } 
            set { this.money = value; }
        }
    }
}
