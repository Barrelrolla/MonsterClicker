using System;
using System.Collections.Generic;

namespace MonsterClicker
{
    using Interfaces;
    using System.Numerics;
    using System.Windows.Forms;
    public class Monster : IMonster
    {
        private BigInteger health;
        private static BigInteger startHealth = 10;
        private BigInteger nextLevelHealth = startHealth;
        //private List<string> photosPaths;
        private Random randomGenerator;
        private int currentNumber = 0;
        private MonsterInventory inventory;

        //TODO: exp and money - every next monster must have more money and exp
        //TODO: exp must be part of health
        //TODO: make class Boss 
        //TODO: make homework
        //TODO: Timer

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

        public void TakeDamage(BigInteger damage)
        {
            //TODO: Move the health == 0  check from Form.cs to this method
            this.Health -= damage;
        }

        public void GenerateHealth()
        {
            nextLevelHealth += (nextLevelHealth / 10);
            this.health = nextLevelHealth;
        }

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

        public void GenerateInvetory()
        {
            this.Money += this.Money / 10 < 1 ? 1 : this.Money / 10;
            this.Experience += this.Experience / 20 < 1 ? 1 : this.Experience / 20;
        }
    }
}