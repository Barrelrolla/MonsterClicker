namespace MonsterClicker
{
    using System;
    using System.Numerics;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public BigInteger monsterHP = 10;
        public BigInteger damagePerClick = 1;
        public BigInteger money = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void monsterButton_Click(object sender, EventArgs e)
        {
            monsterHP -= damagePerClick;
            if (monsterHP == 0)
            {
                money += 1;
                moneyLabel.Text = string.Format("Money: {0}", money);
                monsterHP = 10;
            }
            monsterHPlabel.Text = string.Format("Monster HP: {0}", monsterHP);
        }
    }
}
