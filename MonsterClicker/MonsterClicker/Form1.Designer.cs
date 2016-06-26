namespace MonsterClicker
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label monsterHPlabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button weaponButton;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Timer warningTimer;
        private System.Windows.Forms.Label damageClickLabel;
        private System.Windows.Forms.Label damageSecondLabel;
        private System.Windows.Forms.Label playerLevelLabel;
        private System.Windows.Forms.Label levelUpLabel;
        private System.Windows.Forms.Timer levelTimer;
        private System.Windows.Forms.Button monsterButton;
        private System.Windows.Forms.CheckBox playNstop;
        private System.Windows.Forms.Button farmerButton;
        private System.Windows.Forms.Label farmersLabel;
        private System.Windows.Forms.Timer DPSTimer;
        private System.Windows.Forms.Label floatDamageLabel;
        private System.Windows.Forms.Timer floatDamageTimer;
        private System.Windows.Forms.Label clickMeLabel;
        private System.Windows.Forms.Button bossButton;
        private System.Windows.Forms.Label bossHPLabel;
        private System.Windows.Forms.Button monkButton;
        private System.Windows.Forms.Label monkLabel;
        private System.Windows.Forms.Button ninjasButton;
        private System.Windows.Forms.Label ninjasLabel;
        private System.Windows.Forms.Label creatureName;
        private System.Windows.Forms.Label achievementLabel;
        private System.Windows.Forms.Timer achievementTimer;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monsterHPlabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.weaponButton = new System.Windows.Forms.Button();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.warningTimer = new System.Windows.Forms.Timer(this.components);
            this.damageClickLabel = new System.Windows.Forms.Label();
            this.damageSecondLabel = new System.Windows.Forms.Label();
            this.playerLevelLabel = new System.Windows.Forms.Label();
            this.levelUpLabel = new System.Windows.Forms.Label();
            this.levelTimer = new System.Windows.Forms.Timer(this.components);
            this.monsterButton = new System.Windows.Forms.Button();
            this.playNstop = new System.Windows.Forms.CheckBox();
            this.farmerButton = new System.Windows.Forms.Button();
            this.farmersLabel = new System.Windows.Forms.Label();
            this.DPSTimer = new System.Windows.Forms.Timer(this.components);
            this.floatDamageLabel = new System.Windows.Forms.Label();
            this.floatDamageTimer = new System.Windows.Forms.Timer(this.components);
            this.clickMeLabel = new System.Windows.Forms.Label();
            this.bossButton = new System.Windows.Forms.Button();
            this.bossHPLabel = new System.Windows.Forms.Label();
            this.monkButton = new System.Windows.Forms.Button();
            this.monkLabel = new System.Windows.Forms.Label();
            this.ninjasButton = new System.Windows.Forms.Button();
            this.ninjasLabel = new System.Windows.Forms.Label();
            this.creatureName = new System.Windows.Forms.Label();
            this.achievementLabel = new System.Windows.Forms.Label();
            this.achievementTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // monsterHPlabel
            // 
            this.monsterHPlabel.AutoSize = true;
            this.monsterHPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monsterHPlabel.Location = new System.Drawing.Point(61, 105);
            this.monsterHPlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monsterHPlabel.Name = "monsterHPlabel";
            this.monsterHPlabel.Size = new System.Drawing.Size(119, 20);
            this.monsterHPlabel.TabIndex = 1;
            this.monsterHPlabel.Text = "Monster HP: 10";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(10, 10);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(73, 20);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Money: 0";
            // 
            // weaponButton
            // 
            this.weaponButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponButton.Location = new System.Drawing.Point(210, 5);
            this.weaponButton.Margin = new System.Windows.Forms.Padding(2);
            this.weaponButton.Name = "weaponButton";
            this.weaponButton.Size = new System.Drawing.Size(148, 30);
            this.weaponButton.TabIndex = 3;
            this.weaponButton.Text = "Upgrade Weapon";
            this.weaponButton.UseVisualStyleBackColor = true;
            this.weaponButton.Click += new System.EventHandler(this.WeaponButton_Click);
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponLabel.Location = new System.Drawing.Point(362, 10);
            this.weaponLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(50, 20);
            this.weaponLabel.TabIndex = 4;
            this.weaponLabel.Text = "Cost: ";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(190, 34);
            this.warning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 20);
            this.warning.TabIndex = 5;
            // 
            // warningTimer
            // 
            this.warningTimer.Tick += new System.EventHandler(this.WarningTimer_Tick);
            // 
            // damageClickLabel
            // 
            this.damageClickLabel.AutoSize = true;
            this.damageClickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageClickLabel.Location = new System.Drawing.Point(10, 320);
            this.damageClickLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.damageClickLabel.Name = "damageClickLabel";
            this.damageClickLabel.Size = new System.Drawing.Size(139, 20);
            this.damageClickLabel.TabIndex = 6;
            this.damageClickLabel.Text = "Damage Per Click:";
            // 
            // damageSecondLabel
            // 
            this.damageSecondLabel.AutoSize = true;
            this.damageSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageSecondLabel.Location = new System.Drawing.Point(10, 363);
            this.damageSecondLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.damageSecondLabel.Name = "damageSecondLabel";
            this.damageSecondLabel.Size = new System.Drawing.Size(161, 20);
            this.damageSecondLabel.TabIndex = 7;
            this.damageSecondLabel.Text = "Damage Per Second:";
            // 
            // playerLevelLabel
            // 
            this.playerLevelLabel.AutoSize = true;
            this.playerLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLevelLabel.Location = new System.Drawing.Point(11, 279);
            this.playerLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLevelLabel.Name = "playerLevelLabel";
            this.playerLevelLabel.Size = new System.Drawing.Size(50, 20);
            this.playerLevelLabel.TabIndex = 8;
            this.playerLevelLabel.Text = "Level:";
            // 
            // levelUpLabel
            // 
            this.levelUpLabel.AutoSize = true;
            this.levelUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelUpLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.levelUpLabel.Location = new System.Drawing.Point(80, 232);
            this.levelUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levelUpLabel.Name = "levelUpLabel";
            this.levelUpLabel.Size = new System.Drawing.Size(75, 20);
            this.levelUpLabel.TabIndex = 9;
            this.levelUpLabel.Text = "Level Up!";
            // 
            // levelTimer
            // 
            this.levelTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // monsterButton
            // 
            this.monsterButton.AccessibleName = "monsterButton";
            this.monsterButton.BackgroundImage = global::MonsterClicker.Properties.Resources.img1;
            this.monsterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monsterButton.Location = new System.Drawing.Point(66, 132);
            this.monsterButton.Margin = new System.Windows.Forms.Padding(2);
            this.monsterButton.Name = "monsterButton";
            this.monsterButton.Size = new System.Drawing.Size(109, 99);
            this.monsterButton.TabIndex = 0;
            this.monsterButton.UseVisualStyleBackColor = true;
            this.monsterButton.Click += new System.EventHandler(this.MonsterButton_Click);
            // 
            // playNstop
            // 
            this.playNstop.Appearance = System.Windows.Forms.Appearance.Button;
            this.playNstop.BackgroundImage = global::MonsterClicker.Properties.Resources.soundOn;
            this.playNstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playNstop.Checked = true;
            this.playNstop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playNstop.Location = new System.Drawing.Point(684, 359);
            this.playNstop.Margin = new System.Windows.Forms.Padding(2);
            this.playNstop.Name = "playNstop";
            this.playNstop.Size = new System.Drawing.Size(30, 30);
            this.playNstop.TabIndex = 40;
            this.playNstop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playNstop.UseVisualStyleBackColor = true;
            this.playNstop.CheckedChanged += new System.EventHandler(this.PlayNstop_CheckedChanged);
            // 
            // farmerButton
            // 
            this.farmerButton.Location = new System.Drawing.Point(482, 34);
            this.farmerButton.Margin = new System.Windows.Forms.Padding(2);
            this.farmerButton.Name = "farmerButton";
            this.farmerButton.Size = new System.Drawing.Size(96, 23);
            this.farmerButton.TabIndex = 21;
            this.farmerButton.Text = "Buy Farm";
            this.farmerButton.UseVisualStyleBackColor = true;
            this.farmerButton.Click += new System.EventHandler(this.TestUnitButton_Click);
            // 
            // farmersLabel
            // 
            this.farmersLabel.AutoSize = true;
            this.farmersLabel.Location = new System.Drawing.Point(582, 37);
            this.farmersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.farmersLabel.Name = "farmersLabel";
            this.farmersLabel.Size = new System.Drawing.Size(34, 13);
            this.farmersLabel.TabIndex = 22;
            this.farmersLabel.Text = "Price:";
            // 
            // DPSTimer
            // 
            this.DPSTimer.Enabled = true;
            this.DPSTimer.Interval = 1000;
            this.DPSTimer.Tick += new System.EventHandler(this.TestTimer_Tick);
            // 
            // floatDamageLabel
            // 
            this.floatDamageLabel.AutoSize = true;
            this.floatDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatDamageLabel.ForeColor = System.Drawing.Color.Red;
            this.floatDamageLabel.Location = new System.Drawing.Point(250, 128);
            this.floatDamageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.floatDamageLabel.Name = "floatDamageLabel";
            this.floatDamageLabel.Size = new System.Drawing.Size(24, 26);
            this.floatDamageLabel.TabIndex = 23;
            this.floatDamageLabel.Text = "5";
            // 
            // floatDamageTimer
            // 
            this.floatDamageTimer.Tick += new System.EventHandler(this.FloatDamageTimer_Tick);
            // 
            // clickMeLabel
            // 
            this.clickMeLabel.AutoSize = true;
            this.clickMeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clickMeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickMeLabel.ForeColor = System.Drawing.Color.Orange;
            this.clickMeLabel.Location = new System.Drawing.Point(72, 233);
            this.clickMeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clickMeLabel.Name = "clickMeLabel";
            this.clickMeLabel.Size = new System.Drawing.Size(80, 20);
            this.clickMeLabel.TabIndex = 24;
            this.clickMeLabel.Text = "Click Me ↑";
            // 
            // bossButton
            // 
            this.bossButton.AccessibleName = "bossButton";
            this.bossButton.BackgroundImage = global::MonsterClicker.Properties.Resources.monster;
            this.bossButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bossButton.Location = new System.Drawing.Point(66, 132);
            this.bossButton.Margin = new System.Windows.Forms.Padding(2);
            this.bossButton.Name = "bossButton";
            this.bossButton.Size = new System.Drawing.Size(109, 99);
            this.bossButton.TabIndex = 25;
            this.bossButton.UseVisualStyleBackColor = true;
            this.bossButton.Visible = false;
            this.bossButton.Click += new System.EventHandler(this.BossButtonClick);
            // 
            // bossHPLabel
            // 
            this.bossHPLabel.AccessibleName = "bossHPLabel";
            this.bossHPLabel.AutoSize = true;
            this.bossHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bossHPLabel.Location = new System.Drawing.Point(61, 105);
            this.bossHPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bossHPLabel.Name = "bossHPLabel";
            this.bossHPLabel.Size = new System.Drawing.Size(0, 24);
            this.bossHPLabel.TabIndex = 26;
            this.bossHPLabel.Visible = false;
            this.bossHPLabel.Click += new System.EventHandler(this.BossHPLabel_Click);
            // 
            // monkButton
            // 
            this.monkButton.Location = new System.Drawing.Point(482, 57);
            this.monkButton.Name = "monkButton";
            this.monkButton.Size = new System.Drawing.Size(96, 23);
            this.monkButton.TabIndex = 27;
            this.monkButton.Text = "Buy Monastery";
            this.monkButton.UseVisualStyleBackColor = true;
            this.monkButton.Click += new System.EventHandler(this.MonkButton_Click);
            // 
            // monkLabel
            // 
            this.monkLabel.AutoSize = true;
            this.monkLabel.Location = new System.Drawing.Point(582, 59);
            this.monkLabel.Name = "monkLabel";
            this.monkLabel.Size = new System.Drawing.Size(34, 13);
            this.monkLabel.TabIndex = 28;
            this.monkLabel.Text = "Price:";
            // 
            // ninjasButton
            // 
            this.ninjasButton.Location = new System.Drawing.Point(482, 84);
            this.ninjasButton.Name = "ninjasButton";
            this.ninjasButton.Size = new System.Drawing.Size(96, 23);
            this.ninjasButton.TabIndex = 29;
            this.ninjasButton.Text = "Buy Dojo";
            this.ninjasButton.UseVisualStyleBackColor = true;
            this.ninjasButton.Click += new System.EventHandler(this.NinjasButton_Click);
            // 
            // ninjasLabel
            // 
            this.ninjasLabel.AutoSize = true;
            this.ninjasLabel.Location = new System.Drawing.Point(582, 87);
            this.ninjasLabel.Name = "ninjasLabel";
            this.ninjasLabel.Size = new System.Drawing.Size(34, 13);
            this.ninjasLabel.TabIndex = 30;
            this.ninjasLabel.Text = "Price:";
            // 
            // creatureName
            // 
            this.creatureName.AutoSize = true;
            this.creatureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatureName.Location = new System.Drawing.Point(58, 63);
            this.creatureName.Name = "creatureName";
            this.creatureName.Size = new System.Drawing.Size(116, 24);
            this.creatureName.TabIndex = 31;
            this.creatureName.Text = "Name: Bebe";
            // 
            // achievementLabel
            // 
            this.achievementLabel.AutoSize = true;
            this.achievementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievementLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.achievementLabel.Location = new System.Drawing.Point(276, 332);
            this.achievementLabel.Name = "achievementLabel";
            this.achievementLabel.Size = new System.Drawing.Size(121, 24);
            this.achievementLabel.TabIndex = 41;
            this.achievementLabel.Text = "Achievement";
            this.achievementLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // achievementTimer
            // 
            this.achievementTimer.Tick += new System.EventHandler(this.AchievementTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonsterClicker.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 406);
            this.Controls.Add(this.achievementLabel);
            this.Controls.Add(this.creatureName);
            this.Controls.Add(this.ninjasLabel);
            this.Controls.Add(this.ninjasButton);
            this.Controls.Add(this.monkLabel);
            this.Controls.Add(this.monkButton);
            this.Controls.Add(this.bossHPLabel);
            this.Controls.Add(this.bossButton);
            this.Controls.Add(this.clickMeLabel);
            this.Controls.Add(this.floatDamageLabel);
            this.Controls.Add(this.farmersLabel);
            this.Controls.Add(this.farmerButton);
            this.Controls.Add(this.playNstop);
            this.Controls.Add(this.levelUpLabel);
            this.Controls.Add(this.playerLevelLabel);
            this.Controls.Add(this.damageSecondLabel);
            this.Controls.Add(this.damageClickLabel);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.weaponButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.monsterHPlabel);
            this.Controls.Add(this.monsterButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Monster Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}