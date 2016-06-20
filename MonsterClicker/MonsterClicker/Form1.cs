namespace MonsterClicker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private static Player player = new Player();
        private static Weapon weaponInStore = new Weapon(1, 1);
        private Monster monster = new Monster();
        private int warningTime;
        private int levelUpTime;

        public Form1()
        {
            this.InitializeComponent();
            this.monsterHPlabel.Text = string.Format("Monster HP: {0}", player.monsterHealth);
            this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            this.weaponLabel.Text = string.Format("Cost: {0}", weaponInStore.Cost);
            this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", player.DamagePerClick);
            this.damageSecondLabel.Text = string.Format("Damage Per Second: {0}", player.DamagePerSecond);
            this.playerLevelLabel.Text = string.Format("Level: {0}", player.Level);
            // hidden until implemented
            this.damageSecondLabel.Hide();
        }

        private void monsterButton_Click(object sender, EventArgs e)
        {
            monster.TakeDamage(player.DealDamage());
            if (this.levelUpLabel.Text != "Level Up!")
            {
                this.levelUpLabel.Text = string.Empty;
            }

            if (monster.Health <= 0)
            {
                monster.GenerateHealth();
                player.Money++;
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
                player.ExperiencePoints += 5;
                if (player.ExperiencePoints >= 10)
                {
                    player.LevelUp();
                    this.levelUpLabel.Text = "Level Up!";
                    this.levelUpTime = 3;
                    this.levelTimer.Start();
                    this.playerLevelLabel.Text = string.Format("Level: {0}", player.Level);
                    this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", player.DamagePerClick);
                }
            }
            this.monsterHPlabel.Text = string.Format("Monster HP: {0}", monster.Health);

            // TODO: Placeholder text, remove after getting a monster
            //if (player.monsterHealth <= 0)
            //{
            //    var healthToAdd = player.initialMonsterHealth / 10;
            //    healthToAdd = healthToAdd < 1 ? 1 : healthToAdd;
            //    var newHealth = player.initialMonsterHealth + healthToAdd;
            //    player.monsterHealth = newHealth;
            //    player.initialMonsterHealth = newHealth;
            //    player.Money++;
            //    this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            //    player.ExperiencePoints += 5;
            //    if (player.ExperiencePoints >= 10)
            //    {
            //        player.LevelUp();
            //        this.levelUpLabel.Text = "Level Up!";
            //        this.levelUpTime = 3;
            //        this.levelTimer.Start();
            //        this.playerLevelLabel.Text = string.Format("Level: {0}", player.Level);
            //        this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", player.DamagePerClick);
            //    }
            //}

            //this.monsterHPlabel.Text = string.Format("Monster HP: {0}", player.monsterHealth);
        }

        private void weaponButton_Click(object sender, EventArgs e)
        {
            if (player.Money >= weaponInStore.Cost)
            {
                weaponInStore = player.BuyWeapon(weaponInStore);
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
                this.weaponLabel.Text = string.Format("Cost: {0}", weaponInStore.Cost);
                this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", player.DamagePerClick);
                this.warning.ForeColor = Color.Green;
                this.warning.Text = "Weapon bought!";
                this.warningTime = 3;
                this.warningTimer.Start();
            }
            else
            {
                this.warning.ForeColor = Color.Red;
                this.warning.Text = "Not enough money!";
                this.warningTime = 3;
                this.warningTimer.Start();
            }
        }

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            if (this.warningTime > 0)
            {
                this.warningTime--;
            }
            else
            {
                this.warning.Text = string.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.levelUpTime > 0)
            {
                this.levelUpTime--;
            }
            else
            {
                this.levelUpLabel.Text = string.Empty;
            }
        }
    }
}
