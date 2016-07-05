namespace MonsterClicker
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Media;
    using System.Numerics;
    using System.Windows.Forms;
    using Buildings;
    using Exceptions;
    using Units;
    using Weapons;
    
    public partial class Form1 : Form
    {
        private Player player = new Player();
        private Weapon weaponInStore = new WoodenSword(1, 1);
        private Monster monster = new Monster();
        private Building farm = new Farm();
        private Building monastery = new Monastery();
        private Building dojo = new Dojo();
        private Unit farmers = new Farmer();
        private Unit monks = new Monk();
        private Unit ninjas = new Ninja();
        private List<Unit> unitsList = new List<Unit>();
        private BigInteger monsterKills = 1;
        private Boss boss;
        private Achievements achievements = new Achievements();
        private BigInteger totalMoney = 0;
        private BigInteger totalDamage = 0;
        private int clicksCount = 0;
        private SoundPlayer playerMusic = new SoundPlayer();    
        ////private SoundPlayer duck = new SoundPlayer();

        ////This variable counts monster images and is used to get random image
        
        private int monsterImagesCount = 5;

        ////TODO: achivements - kills and all damage
        ////TODO: maybe add more weapons and units

        public Form1()
        {
            this.InitializeComponent();
            this.unitsList.Add(this.farmers);
            this.unitsList.Add(this.monks);
            this.unitsList.Add(this.ninjas);
            ////this.monsterHPlabel.Text = string.Format("Monster HP: {0}", monster.Health);
            ////this.bossHPLabel.Text = string.Format("Boss HP: {0}", boss.Health);
            ////this.player.Money = 100000; //cheat for testing, REMOVE IT BEFORE RELEASE!!! :D
            this.moneyLabel.Hide();
            this.weaponLabel.Hide();
            this.damageClickLabel.Hide();
            this.damageSecondLabel.Hide();
            this.playerLevelLabel.Hide();
            this.farmersLabel.Hide();
            this.monkLabel.Hide();
            this.ninjasLabel.Hide();
            this.creatureName.Hide();
            this.monkButton.Hide();
            this.monkLabel.Hide();
            this.ninjasButton.Hide();
            this.ninjasLabel.Hide();
            this.levelUpLabel.Hide();
            this.floatDamageLabel.Hide();
            this.playerMusic.SoundLocation = "../../Resources/street.wav";
            this.playerMusic.PlayLooping();
            this.achievementLabel.Hide();
            this.monsterButton.Hide();
            this.farmerButton.Hide();
            this.weaponButton.Hide();
            this.playNstop.Hide();
            this.monsterHPlabel.Hide();
            this.clickMeLabel.Hide();
            ////this.duck.SoundLocation = "../../Resources/duck.wav";
            this.OnAchievementUnlocked += this.Form1_OnAchievementUnlocked;
            this.warning.Hide();
            this.namesLabel.Text = $"C# OOP team project by {Environment.NewLine} Yulian Teofilov, Kaloyan Kostov, Kristian Kanchev, {Environment.NewLine} Desislav Arashev, Yordan Paskov, Borislav Peev, Kremena Filipova";
        }

        public delegate void AchievementUnlocked(object sender, AchievementArgs a);

        public event AchievementUnlocked OnAchievementUnlocked;
        ////Methods

        private void CheckForMonsterKills()
        {
            if (this.monsterKills == 100)
            {
                AchievementArgs a = new AchievementArgs("Killed 100 monsters!");
                this.achievements.Killed100Monsters = true;
                this.OnAchievementUnlocked(this.player, a);
            }
        }

        private void CheckForCollectedMoney(Creature creature)
        {
            if (this.achievements.Collected1mMoney == false)
            {
                this.totalMoney += creature.Money;
                if (this.totalMoney >= 1000000)
                {
                    AchievementArgs a = new AchievementArgs("Collected 1 000 000 money!");
                    this.achievements.Collected1mMoney = true;
                    this.OnAchievementUnlocked(this.player, a);
                }
            }
        }

        private void CheckForDamage()
        {
            if (this.achievements.Dealt1mDamage == false)
            {
                totalDamage += this.player.DealDamage();
                if (totalDamage >= 1000000)
                {
                    AchievementArgs a = new AchievementArgs("Dealed 1 000 000 Damage!");
                    this.achievements.Dealt1mDamage = true;
                    this.OnAchievementUnlocked(this.player, a);
                }
            }
        }

        private void CheckForClicks()
        {
            if (this.achievements.Clicked100Times == false)
            {
                clicksCount++;
                if (clicksCount == 100)
                {
                    AchievementArgs a = new AchievementArgs("Clicked 100 times!");
                    this.achievements.Clicked100Times = true;
                    this.OnAchievementUnlocked(this.player, a);
                }
            }
        }

        private void ShowDamage()
        {
            this.floatDamageLabel.BringToFront();
            this.floatDamageLabel.Hide();
            this.floatDamageLabel.Show();
            //// getting the window position relative to the screen
            var window = new Point(this.Location.X, this.Location.Y);
            //// setting the new location relative to the mouse relative to the window position
            var newLocation = new Point(MousePosition.X - window.X - 20, MousePosition.Y - window.Y - 60);
            this.floatDamageLabel.Location = newLocation;
            this.floatDamageLabel.Text = string.Format("{0}", this.player.DealDamage());
            this.floatDamageTimer.Start();
        }

        private void CheckIfDead()
        {
            if (this.monster.Health <= 0)
            {
                this.monsterKills++;
                CheckForMonsterKills();
                this.monster.GenerateHealth();
                this.creatureName.Text = string.Format("Name: {0}", Creature.GetRandomName());
                if (this.monsterKills % 10 == 0)
                {
                    this.boss = new Boss(this.monster);
                    this.boss.GenerateHealth();
                    this.boss.Money = this.monster.Money;
                    this.bossHPLabel.Text = string.Format("Boss HP: {0}", this.boss.Health);
                    this.monsterButton.Hide();
                    this.bossButton.Show();
                    this.monsterHPlabel.Hide();
                    this.bossHPLabel.Show();
                }

                this.player.Money += this.monster.Money;
                CheckForCollectedMoney(this.monster);
                this.CheckIfMoneyAreValid();
                this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                this.player.ExperiencePointsNeeded -= this.monster.Experience;
                this.monster.GenerateInventory();
                if (this.player.ExperiencePointsNeeded <= 0)
                {
                    this.player.LevelUp();
                    this.levelUpLabel.Hide();
                    this.levelUpLabel.Show();
                    this.levelTimer.Interval = 2000;
                    this.levelTimer.Start();
                    this.player.DamagePerSecond = this.CalculateDamagePerSecond();
                    this.playerLevelLabel.Text = string.Format("Level: {0}", this.player.Level);
                    this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", this.player.DealDamage());
                    this.damageSecondLabel.Text = string.Format("Damage Per Second: {0}", this.player.DamagePerSecond);
                }

                this.ChangePhotoOfMonster(Random.Next(this.monsterImagesCount));
            }

            this.monsterHPlabel.Text = string.Format("Monster HP: {0}", this.monster.Health);
        }

        private void CheckIfMoneyAreValid()
        {
            if (this.player.Money < 0)
            {
                throw new NoMoneyException("The player is in debt!");
            }
        }

        private void ChangePhotoOfMonster(int number)
        {
            switch (number)
            {
                case 0:
                    this.monsterButton.BackgroundImage = Properties.Resources.img1;
                    break;
                case 1:
                    this.monsterButton.BackgroundImage = Properties.Resources.img2;
                    break;
                case 2:
                    this.monsterButton.BackgroundImage = Properties.Resources.img3;
                    break;
                case 3:
                    this.monsterButton.BackgroundImage = Properties.Resources.img4;
                    break;
                case 4:
                    this.monsterButton.BackgroundImage = Properties.Resources.img5;
                    break;
                default:
                    this.monsterButton.BackgroundImage = Properties.Resources.monster;
                    break;
            }
        }

        private void RefreshDamagePerSecond()
        {
            this.player.DamagePerSecond = this.CalculateDamagePerSecond();
            this.damageSecondLabel.Text = string.Format("Damage Per Second: {0}", this.player.DamagePerSecond);
        }

        private void CheckBossDead()
        {
            if (this.boss.Health <= 0)
            {
                this.monsterKills++;
                CheckForMonsterKills();
                this.monster.GenerateHealth();
                this.creatureName.Text = string.Format("Name: {0}", Creature.GetRandomName());
                this.boss.Health = 0;
                this.player.Money += this.boss.Money;
                CheckForCollectedMoney(this.boss);
                this.CheckIfMoneyAreValid();
                this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                this.player.ExperiencePointsNeeded -= this.boss.Experience;
                this.boss.GenerateInventory();                
                if (this.player.ExperiencePointsNeeded <= 0)
                {
                    this.player.LevelUp();
                    this.levelUpLabel.Hide();
                    this.levelUpLabel.Show();
                    this.levelTimer.Interval = 2000;
                    this.levelTimer.Start();
                    this.player.DamagePerSecond = this.CalculateDamagePerSecond();
                    this.playerLevelLabel.Text = string.Format("Level: {0}", this.player.Level);
                    this.damageSecondLabel.Text = string.Format("Damage Per Second: {0}", this.player.DamagePerSecond);
                    this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", this.player.DealDamage());
                }

                this.CheckBossHealthValid();
                this.bossButton.Hide();
                this.monsterButton.Show();
                this.bossHPLabel.Hide();
                this.monsterHPlabel.Show();
            }

            this.bossHPLabel.Text = string.Format("Boss HP: {0}", this.boss.Health);            
        }

        private void CheckBossHealthValid()
        {
            if (this.boss.Health < 0)
            {
                throw new NoHealthException("The creature should be dead, but it is not!");
            }
        }

        private void CheckIfHealthIsValid()
        {
            if (this.monster.Health < 0)
            {
                throw new NoHealthException("The creature should be dead, but it is not!");
            }
        }

        private BigInteger CalculateDamagePerSecond()
        {
            BigInteger dps = 0;
            this.unitsList.ForEach(u => dps += u.DealDamage(this.player.BaseClickDamage));
            return dps;
        }

        ////Events

        private void Form1_OnAchievementUnlocked(object sender, AchievementArgs a)
        {
            this.achievementLabel.Text = string.Format("Achievement unlocked!{0}{1}", Environment.NewLine, a.Message);
            this.achievementLabel.Show();
            this.achievementTimer.Interval = 3000;
            this.achievementTimer.Start();
        }

        private void FloatDamageTimer_Tick(object sender, EventArgs e)
        {
            this.floatDamageLabel.Hide();
        }

        private void BossButtonClick(object sender, EventArgs e)
        {
            CheckForClicks();
            this.clickMeLabel.Hide();
            this.boss.TakeDamage(this.player.DealDamage());
            CheckForDamage();
            this.CheckBossDead();
            this.CheckBossHealthValid();
            this.ShowDamage();
        }

        private void MonkButton_Click(object sender, EventArgs e)
        {
            if (this.monastery.PurchasedState == false && this.player.Money >= this.monastery.Price)
            {
                this.player.Money -= this.monastery.Price;
                this.monastery.PurchasedState = true;
                this.CheckIfMoneyAreValid();
                this.monkButton.Text = "Buy Monk";
                this.monkLabel.Text = string.Format("Price: {0}; Count: {1}", this.monks.Price, this.monks.Count);
                this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                this.ninjasButton.Show();
                this.ninjasLabel.Show();
                this.PurchaseSuccesful("Monastery");
            }
            else if (this.monastery.PurchasedState == false && this.player.Money < this.monastery.Price)
            {
                this.PurchaseUnsuccesful();
            }
            else
            {
                if (this.player.Money >= this.monks.Price)
                {
                    this.player.Money -= this.monks.Price;
                    this.monks.IncreaseCount();
                    this.monks.PriceIncrease();
                    this.RefreshDamagePerSecond();
                    this.CheckIfMoneyAreValid();
                    this.monkLabel.Text = string.Format("Price: {0}; Count: {1}", this.monks.Price, this.monks.Count);
                    this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                    this.PurchaseSuccesful("Monk");
                }
                else
                {
                    this.PurchaseUnsuccesful();
                }
            }
        }

        private void NinjasButton_Click(object sender, EventArgs e)
        {
            if (this.dojo.PurchasedState == false && this.player.Money >= this.dojo.Price)
            {
                this.player.Money -= this.dojo.Price;
                this.dojo.PurchasedState = true;
                this.CheckIfMoneyAreValid();
                this.ninjasButton.Text = "Buy Ninja";
                this.ninjasLabel.Text = string.Format("Price: {0}; Count: {1}", this.ninjas.Price, this.ninjas.Count);
                this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                this.PurchaseSuccesful("Dojo");
            }
            else if (this.dojo.PurchasedState == false && this.player.Money < this.dojo.Price)
            {
                this.PurchaseUnsuccesful();
            }
            else
            {
                if (this.player.Money >= this.ninjas.Price)
                {
                    this.player.Money -= this.ninjas.Price;
                    this.ninjas.IncreaseCount();
                    this.ninjas.PriceIncrease();
                    this.RefreshDamagePerSecond();
                    this.CheckIfMoneyAreValid();
                    this.ninjasLabel.Text = string.Format("Price: {0}; Count: {1}", this.ninjas.Price, this.ninjas.Count);
                    this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                    this.PurchaseSuccesful("Ninja");
                }
                else
                {
                    this.PurchaseUnsuccesful();
                }
            }
        }

        private void MonsterButton_Click(object sender, EventArgs e)
        {
            this.clickMeLabel.Hide();
            this.monster.TakeDamage(this.player.DealDamage());
            if (this.achievements.Dealt1mDamage == false)
            CheckForDamage();
            this.CheckIfDead();
            this.CheckIfHealthIsValid();
            this.ShowDamage();
            CheckForClicks();
            ////this.duck.Play();
        }

        private void TestTimer_Tick(object sender, EventArgs e)
        {
            if (this.monsterButton.Visible)
            {
                this.monster.TakeDamage(this.player.DamagePerSecond);
                CheckForDamage();
                this.CheckIfDead();
                this.CheckIfHealthIsValid();
            }

            if (this.bossButton.Visible)
            {
                this.boss.TakeDamage(this.player.DamagePerSecond);
                CheckForDamage();
                this.CheckBossDead();
                CheckBossHealthValid();
            }
        }

        private void TestUnitButton_Click(object sender, EventArgs e)
        {
            if (this.farm.PurchasedState == false && this.player.Money >= this.farm.Price)
            {
                this.player.Money -= this.farm.Price;
                this.farm.PurchasedState = true;
                this.CheckIfMoneyAreValid();
                this.farmerButton.Text = "Buy Farmer";
                this.farmersLabel.Text = string.Format("Price: {0}; Count: {1}", this.farmers.Price, this.farmers.Count);
                this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                this.monkButton.Show();
                this.monkLabel.Show();
                this.PurchaseSuccesful("Farm");
            }
            else if (this.farm.PurchasedState == false && this.player.Money < this.farm.Price)
            {
                this.PurchaseUnsuccesful();
            }
            else
            {
                if (this.player.Money >= this.farmers.Price)
                {
                    this.player.Money -= this.farmers.Price;
                    this.farmers.IncreaseCount();
                    this.farmers.PriceIncrease();
                    this.RefreshDamagePerSecond();
                    this.CheckIfMoneyAreValid();
                    this.farmersLabel.Text = string.Format("Price: {0}; Count: {1}", this.farmers.Price, this.farmers.Count);
                    this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                    this.PurchaseSuccesful("Farmer");
                }
                else
                {
                    this.PurchaseUnsuccesful();
                }
            }
        }

        private void WeaponButton_Click(object sender, EventArgs e)
        {
            if (this.player.Money >= this.weaponInStore.Cost)
            {
                this.player.BuyWeapon(this.weaponInStore);
                this.weaponInStore = new WoodenSword(this.weaponInStore.DamageIncrease(), this.weaponInStore.CostIncrease());
                this.CheckIfMoneyAreValid();
                this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                this.weaponLabel.Text = string.Format("Cost: {0}", this.weaponInStore.Cost);
                this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", this.player.DealDamage());
                this.PurchaseSuccesful("Weapon");
            }
            else
            {
                this.PurchaseUnsuccesful();
            }
        }

        private void PurchaseUnsuccesful()
        {
            this.warning.ForeColor = Color.Red;
            this.warning.Text = "Not enough money!";
            this.warning.Show();
            this.warningTimer.Interval = 2000;
            this.warningTimer.Start();
        }

        private void PurchaseSuccesful(string purchase)
        {
            this.warning.ForeColor = Color.Green;
            this.warning.Text = string.Format("Purchased {0}!", purchase);
            this.warning.Show();
            this.warningTimer.Interval = 2000;
            this.warningTimer.Start();
        }

        private void WarningTimer_Tick(object sender, EventArgs e)
        {
            this.warning.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.levelUpLabel.Hide();
        }

        private void PlayNstop_CheckedChanged(object sender, EventArgs e)
        {            
            {
                if (this.playNstop.Checked)
                {
                    this.playerMusic.Play();
                    this.playNstop.BackgroundImage = Properties.Resources.soundOn;
                }
                else
                {
                    this.playerMusic.Stop();
                    this.playNstop.BackgroundImage = Properties.Resources.soundOf;
                }
            }
        }

        private void AchievementTimer_Tick(object sender, EventArgs e)
        {
            this.achievementLabel.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.titleLabel.Hide();
                this.namesLabel.Hide();
                this.startLabel.Hide();
                this.moneyLabel.Text = string.Format("Money: {0}", this.player.Money);
                this.moneyLabel.Show();
                this.weaponLabel.Text = string.Format("Cost: {0}", this.weaponInStore.Cost);
                this.weaponLabel.Show();
                this.damageClickLabel.Text = string.Format("Damage Per Click: {0}", this.player.DealDamage());
                this.damageClickLabel.Show();
                this.damageSecondLabel.Text = string.Format("Damage Per Second: {0}", this.player.DamagePerSecond);
                this.damageSecondLabel.Show();
                this.playerLevelLabel.Text = string.Format("Level: {0}", this.player.Level);
                this.playerLevelLabel.Show();
                this.farmersLabel.Text = string.Format("Price: {0}", this.farm.Price);
                this.farmersLabel.Show();
                this.monkLabel.Text = string.Format("Price: {0}", this.monastery.Price);
                this.ninjasLabel.Text = string.Format("Price: {0}", this.dojo.Price);
                this.creatureName.Text = string.Format("Name: Bebe");
                this.monsterHPlabel.Show();
                this.clickMeLabel.Show();
                this.creatureName.Show();
                this.monsterButton.Show();
                this.farmerButton.Show();
                this.weaponButton.Show();
                this.playNstop.Show();
            }
        }
    }
}
