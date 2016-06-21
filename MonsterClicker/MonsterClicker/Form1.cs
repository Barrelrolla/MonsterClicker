namespace MonsterClicker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using WMPLib;

    public partial class Form1 : Form
    {
        private static Player player = new Player();
        private static Weapon weaponInStore = new Weapon(1, 1);
        private Monster monster = new Monster();
        private int warningTime;
        private int levelUpTime;
        private Unit testUnit = new Unit(2);

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
            playerMusic.URL = "street.mp3";
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
                ChangePhotoOfMonster(monster.GetRandomNumber());
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

        private void ChangePhotoOfMonster(int number)
        {
            switch (number)
            {
                case 0:
                {
                        this.monsterButton.BackgroundImage = Properties.Resources.img1;
                        break;
                }
                case 1:
                {
                    this.monsterButton.BackgroundImage = Properties.Resources.img2;
                    break;
                }
                case 2:
                {
                    this.monsterButton.BackgroundImage = Properties.Resources.img3;
                    break;
                }
                case 3:
                {
                        this.monsterButton.BackgroundImage = Properties.Resources.img4;
                        break;
                }
                case 4:
                {
                        this.monsterButton.BackgroundImage = Properties.Resources.img5;
                        break;
                }
                default:
                {
                        this.monsterButton.BackgroundImage = Properties.Resources.monster;
                        break;
                }
            }
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
        WMPLib.WindowsMediaPlayer playerMusic = new WMPLib.WindowsMediaPlayer();
      
        private void playNstop_CheckedChanged(object sender, EventArgs e)
        {
            if (playNstop.Checked)
            {
                playNstop.Text = "Stop";
                playerMusic.controls.play();
            }
            else
            {
                playNstop.Text = "Play";
                playerMusic.controls.stop();
            }
        }

        private void testUnitButton_Click(object sender, EventArgs e)
        {
            testUnit.Count++;
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            monster.TakeDamage(testUnit.Damage);
            this.monsterHPlabel.Text = string.Format("Monster HP: {0}", monster.Health);
        }
    }
}
