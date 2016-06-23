namespace MonsterClicker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using MonsterClicker.Exceptions;
    using System.Numerics;
    using WMPLib;

    public partial class Form1 : Form
    {
        // TODO: FIX DAMAGE AND LEVEL SCALING ASAP!!!
        private static Player player = new Player();
        private static Weapon weaponInStore = new Weapon(1, 1);
        private Monster monster = new Monster();
        private Unit testUnit = new Unit(2, 1);

        public Form1()
        {
            this.InitializeComponent();
            this.monsterHPlabel.Text = string.Format("Monster HP: {0}", monster.Health);
            this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            this.weaponLabel.Text = string.Format("Cost: {0}", weaponInStore.Cost);
            this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", player.DamagePerClick);
            this.damageSecondLabel.Text = string.Format("Damage Per Second: {0}", player.DamagePerSecond);
            this.playerLevelLabel.Text = string.Format("Level: {0}", player.Level);
            this.unitPriceLabel.Text = string.Format("Price: {0}; Count: {1}", testUnit.Price, testUnit.Count);
            this.levelUpLabel.Hide();
            this.floatDamageLabel.Hide();
            playerMusic.URL = @".\Resources\street.mp3";
        }

        private void monsterButton_Click(object sender, EventArgs e)
        {
            this.clickMeLabel.Hide();
            monster.TakeDamage(player.DealDamage());
            CheckIfDead();
            if (monster.Health <= 0)
            {
                throw new NoHealthException("The creature should be dead, but it is not!");
            }

            ShowDamage();
        }

        private void ShowDamage()
        {
            floatDamageLabel.Hide();
            floatDamageLabel.Show();
            // getting the window position relative to the screen
            var window = new Point(this.Location.X, this.Location.Y);
            // setting the new location relative to the mouse relative to the window position
            var newLocation = new Point(MousePosition.X - window.X - 20, MousePosition.Y - window.Y - 60);
            floatDamageLabel.Location = newLocation;
            floatDamageLabel.Text = string.Format("{0}", player.DamagePerClick);
            floatDamageTimer.Start();
        }

        private void CheckIfDead()
        {
            if (monster.Health <= 0)
            {
                monster.GenerateHealth();
                player.Money += monster.Money;
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
                player.ExperiencePointsNeeded -= monster.Experience;
                monster.GenerateInvetory();
                if (player.ExperiencePointsNeeded <= 0)
                {
                    player.LevelUp();
                    this.levelUpLabel.Hide();
                    this.levelUpLabel.Show();
                    this.levelTimer.Interval = 2000;
                    this.levelTimer.Start();
                    this.playerLevelLabel.Text = string.Format("Level: {0}", player.Level);
                    this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", player.DamagePerClick);
                }
                ChangePhotoOfMonster(monster.GetRandomNumber());
            }
            this.monsterHPlabel.Text = string.Format("Monster HP: {0}", monster.Health);
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
                this.warning.Text = "Upgrade bought!";
                this.warningTimer.Interval = 2000;
                this.warningTimer.Start();
            }
            else
            {
                this.warning.ForeColor = Color.Red;
                this.warning.Text = "Not enough money!";
                this.warningTimer.Interval = 2000;
                this.warningTimer.Start();
            }
        }

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            this.warning.Text = string.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.levelUpLabel.Hide();
        }
        WindowsMediaPlayer playerMusic = new WindowsMediaPlayer();

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
            if (player.Money >= testUnit.Price)
            {
                testUnit.Count++;
                RefreshDamagePerSecond();
                player.Money -= testUnit.Price;
                this.unitPriceLabel.Text = string.Format("Price: {0}; Count: {1}", testUnit.Price, testUnit.Count);
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            }
        }

        private void RefreshDamagePerSecond()
        {
            player.DamagePerSecond = CalculateDamagePerSecond();
            damageSecondLabel.Text = string.Format("Damage Per Second: {0}", player.DamagePerSecond);
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            monster.TakeDamage(player.DamagePerSecond);
            CheckIfDead();
            if (monster.Health <= 0)
            {
                throw new NoHealthException("The creature should be dead, but it is not!");
            }
        }

        private BigInteger CalculateDamagePerSecond()
        {
            return testUnit.Damage; // all unit types should be added here
        }

        private void floatDamageTimer_Tick(object sender, EventArgs e)
        {
            floatDamageLabel.Hide();
        }
    }
}
