using System;
using System.Collections.Generic;

namespace MonsterClicker
{
    using Interfaces;
    using System.Numerics;
    using System.Windows.Forms;
    public class Monster : Creature
    {
        private BigInteger health;
        private static readonly BigInteger  startHealth = 10;
        private BigInteger nextLevelHealth = startHealth;
        private Random randomGenerator;
        private int currentNumber = 0;
        private MonsterInventory inventory;
        private BigInteger level = 1;

        //TODO: exp and money - every next monster must have more money and exp
        //TODO: enum with names of monster and show it

        public Monster()
        {
            this.Health = startHealth;
            //this.photosPaths = new List<string>();
            this.randomGenerator = new System.Random();
            this.inventory = new MonsterInventory(1, 5);
        }

        public BigInteger Money
        {
            get { return this.inventory.Money; }
            set { this.inventory.Money = value; }
        }

        public BigInteger Experience
        {
            get { return this.inventory.Experience; }
            set { this.inventory.Experience = value; }
        }

        public BigInteger Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public BigInteger Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public void TakeDamage(BigInteger damage)
        {
            //TODO: Move the health == 0  check from Form.cs to this method
            this.Health -= damage;
        }

        public void GenerateHealth()
        {
            nextLevelHealth += (nextLevelHealth / 4);
            this.health = nextLevelHealth;
            this.level++;
        }
        
        public override void GenerateInventory()
        {
            this.Money += this.Money / 10 < 1 ? 1 : this.Money / 10;
            this.Experience += this.Experience / 20 < 1 ? 1 : this.Experience / 20;
        }
    }
}