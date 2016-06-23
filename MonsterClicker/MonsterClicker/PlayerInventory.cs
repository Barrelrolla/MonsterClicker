﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MonsterClicker.Interfaces;

namespace MonsterClicker
{
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
            get
            {
                return this.experienceNeeded;
            }

            set
            {
                this.experienceNeeded = value;
            }
        }

        public BigInteger Money
        {
            get
            {
                return this.money;
            }

            set
            {
                this.money = value;
            }
        }
    }
}