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

        
    }
}