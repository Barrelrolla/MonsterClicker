namespace MonsterClicker
{
    using MonsterClicker.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Numerics;
    using System.Windows.Forms;
    using Units;
    using WMPLib;

    public partial class Form1 : Form
    {
        private Player player = new Player();
        private Weapon weaponInStore = new Weapon(1, 1);
        private Monster monster = new Monster();
        private Unit farmers = new Farmer();
        private Unit monks = new Monk();
        private Unit ninjas = new Ninja();
        private List<Unit> unitsList = new List<Unit>();
        private BigInteger monsterKills = 1;
        private Boss boss;

        //TODO: achivement - kills and all damage
        //TODO: enum with monster names

        public Form1()
        {
            this.InitializeComponent();
            unitsList.Add(farmers);
            unitsList.Add(monks);
            unitsList.Add(ninjas);
            //this.monsterHPlabel.Text = string.Format("Monster HP: {0}", monster.Health);
            //this.bossHPLabel.Text = string.Format("Boss HP: {0}", boss.Health);
            this.player.Money = 100000; //cheat for testing, REMOVE IT BEFORE RELEASE!!! :D
            this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            this.weaponLabel.Text = string.Format("Cost: {0}", weaponInStore.Cost);
            this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", player.DamagePerClick);
            this.damageSecondLabel.Text = string.Format("Damage Per Second: {0}", player.DamagePerSecond);
            this.playerLevelLabel.Text = string.Format("Level: {0}", player.Level);
            this.farmersLabel.Text = string.Format("Price: {0}; Count: {1}", farmers.Price, farmers.Count);
            this.monkLabel.Text = string.Format("Price: {0}; Count: {1}", monks.Price, monks.Count);
            this.ninjasLabel.Text = string.Format("Price: {0}; Count: {1}", ninjas.Price, ninjas.Count);
            this.levelUpLabel.Hide();
            this.floatDamageLabel.Hide();
            playerMusic.URL = @".\Resources\street.mp3";
            this.player.Money = 100000; //cheat for testing, REMOVE IT BEFORE RELEASE!!! :D
        }

        private void monsterButton_Click(object sender, EventArgs e)
        {
            this.clickMeLabel.Hide();
            monster.TakeDamage(player.DealDamage());
            CheckIfDead();
            CheckIfHealthIsValid();
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
                this.monsterKills++;
                monster.GenerateHealth();
                if (this.monsterKills%10 == 0)
                {
                    boss = new Boss(this.monster);
                    boss.GenerateHealth();
                    boss.Money = monster.Money;
                    this.bossHPLabel.Text = string.Format("Boss HP: {0}", boss.Health);
                    this.monsterButton.Hide();
                    this.bossButton.Show();
                    this.monsterHPlabel.Hide();
                    this.bossHPLabel.Show();
                }
                player.Money += monster.Money;
                CheckIfMoneyAreValid();
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
                player.ExperiencePointsNeeded -= monster.Experience;
                monster.GenerateInventory();
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

        private void CheckIfMoneyAreValid()
        {
            if (player.Money < 0)
            {
                throw new NoMoneyException("The player is in debt!");
            }
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
                CheckIfMoneyAreValid();
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
            if (player.Money >= farmers.Price)
            {
                player.Money -= farmers.Price;
                farmers.IncreaseCount();
                farmers.PriceIncrease();
                RefreshDamagePerSecond();
                CheckIfMoneyAreValid();
                this.farmersLabel.Text = string.Format("Price: {0}; Count: {1}", farmers.Price, farmers.Count);
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            }
        }

        private void RefreshDamagePerSecond()
        {
            player.DamagePerSecond = CalculateDamagePerSecond();
            damageSecondLabel.Text = string.Format("Damage Per Second: {0}", player.DamagePerSecond);
        }

        private void CheckBossDead()
        {
            if (boss.Health <= 0)
            {
                this.monsterKills++;
                monster.GenerateHealth();
                boss.GenerateHealth();
                player.Money += boss.Money;
                CheckIfMoneyAreValid();
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
                player.ExperiencePointsNeeded -= boss.Experience;
                boss.GenerateInventory();
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
                this.bossButton.Hide();
                this.monsterButton.Show();
                this.bossHPLabel.Hide();
                this.monsterHPlabel.Show();

            }

            this.bossHPLabel.Text = string.Format("Boss HP: {0}", boss.Health);            
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            if (monsterButton.Visible)
            {
                monster.TakeDamage(player.DamagePerSecond);
                CheckIfDead();
                CheckIfHealthIsValid();
            }
            if (bossButton.Visible)
            {
                boss.TakeDamage(player.DamagePerSecond);
                CheckBossDead();
                //CheckBossHealthValid();   //this should be working, but it's not
            }
        }

        private void CheckBossHealthValid()
        {
            if (boss.Health < 0)
            {
                throw new NoHealthException("The creature should be dead, but it is not!");
            }
        }

        private void CheckIfHealthIsValid()
        {
            if (monster.Health < 0)
            {
                throw new NoHealthException("The creature should be dead, but it is not!");
            }
        }

        private BigInteger CalculateDamagePerSecond()
        {
            BigInteger DPS = 0;
            unitsList.ForEach(u => DPS += u.Damage);
            return DPS;
        }

        private void floatDamageTimer_Tick(object sender, EventArgs e)
        {
            floatDamageLabel.Hide();
        }

        private void bossButton_Click(object sender, EventArgs e)
        {
            this.clickMeLabel.Hide();
            boss.TakeDamage(player.DealDamage());
            CheckBossDead();
            CheckBossHealthValid();
            ShowDamage();
        }

        private void bossHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void monkButton_Click(object sender, EventArgs e)
        {
            if (player.Money >= monks.Price)
            {
                player.Money -= monks.Price;
                monks.IncreaseCount();
                monks.PriceIncrease();
                RefreshDamagePerSecond();
                CheckIfMoneyAreValid();
                this.monkLabel.Text = string.Format("Price: {0}; Count: {1}", monks.Price, monks.Count);
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            }
        }

        private void ninjasButton_Click(object sender, EventArgs e)
        {
            if (player.Money >= ninjas.Price)
            {
                player.Money -= ninjas.Price;
                ninjas.IncreaseCount();
                ninjas.PriceIncrease();
                RefreshDamagePerSecond();
                CheckIfMoneyAreValid();
                this.ninjasLabel.Text = string.Format("Price: {0}; Count: {1}", ninjas.Price, ninjas.Count);
                this.moneyLabel.Text = string.Format("Money: {0}", player.Money);
            }
        }
    }
}
