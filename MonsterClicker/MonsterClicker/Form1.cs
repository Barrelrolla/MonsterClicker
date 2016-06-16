using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterClicker
{
    public partial class Form1 : Form
    {
        public BigInteger money = 0;
        public BigInteger damagePerClick = 1;
        public BigInteger playerLevel = 1;
        public BigInteger neededPlayerXP = 10;
        public BigInteger monsterHP = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monsterHP -= damagePerClick;
            if (monsterHP == 0)
            {
                money += 1;
                moneyLabel.Text = string.Format("Money: {0}", money);
                neededPlayerXP -= 5;
                if (neededPlayerXP <= 0)
                {
                    playerLevel += 1;
                    neededPlayerXP = 10;
                    playerLevelLabel.Text = string.Format("Player level: {0}", playerLevel);
                }
                playerXPLabel.Text = string.Format("XP to next level: {0}", neededPlayerXP);
                monsterHP = 10;
            }
            monsterHPLabel.Text = string.Format("MONSTER HP: {0}", monsterHP);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
