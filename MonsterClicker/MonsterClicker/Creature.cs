namespace MonsterClicker
{
    using System;
    using System.Numerics;
    using Interfaces;
    public abstract class Creature : ICreature
    {
        private BigInteger health;
        private static readonly BigInteger startHealth = 10;
        private BigInteger nextLevelHealth = startHealth;
        private Random randomGenerator;
        private int currentNumber = 0;
        private MonsterInventory inventory;

        public BigInteger Experience
        {
            get { return this.inventory.Experience; }
            set { this.inventory.Experience = value; }
        }

        public BigInteger Money
        {
            get { return this.inventory.Money; }
            set { this.inventory.Money = value; }
        }

        public BigInteger Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public void TakeDamage(BigInteger damage)
        {
            //TODO: Move the health == 0  check from Form.cs to this method
            this.Health -= damage;
        }

        public abstract void GenerateInventory();

        public int GetRandomNumber()
        {
            var number = randomGenerator.Next(0, 5);
            if (number == this.currentNumber)
            {
                while (number == this.currentNumber)
                {
                    number = randomGenerator.Next(0, 5);
                }
            }
            else
            {
                this.currentNumber = number;
            }
            return number;
        }
    }
}