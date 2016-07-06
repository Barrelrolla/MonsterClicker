namespace MonsterClicker.Creatures
{
    using System.Numerics;
    using MonsterClicker.Interfaces;

    public class MonsterInventory : IInventory
    {
        private BigInteger money;
        private BigInteger experienceToGive;

        public MonsterInventory(BigInteger money, BigInteger experience)
        {
            this.Money = money;
            this.Experience = experience;
        }

        public BigInteger Experience
        {
            get { return this.experienceToGive; }
            set { this.experienceToGive = value; }
        }

        public BigInteger Money
        {
            get { return this.money; }
            set { this.money = value; }
        }
    }
}
