﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClicker
{
    // TODO: IUnit, Abstract Unit, separate class for each unit type
    class Unit
    {
        private BigInteger damage;
        private BigInteger price;
        private BigInteger count;

        public Unit(BigInteger damage, BigInteger price)
        {
            this.damage = damage;
            this.price = price;
        }

        public BigInteger Price
        {
            get { return this.price; }
        }

        public BigInteger Damage
        {
            get { return this.damage * this.count; }
        }

        public BigInteger Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
    }
}
