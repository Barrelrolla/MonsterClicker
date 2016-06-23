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
            this.testUnitButton = new System.Windows.Forms.Button();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.floatDamageLabel = new System.Windows.Forms.Label();
            this.floatDamageTimer = new System.Windows.Forms.Timer(this.components);
            this.clickMeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monsterHPlabel
            // 
            this.monsterHPlabel.AutoSize = true;
            this.monsterHPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monsterHPlabel.Location = new System.Drawing.Point(84, 70);
            this.monsterHPlabel.Name = "monsterHPlabel";
            this.monsterHPlabel.Size = new System.Drawing.Size(119, 20);
            this.monsterHPlabel.TabIndex = 1;
            this.monsterHPlabel.Text = "Monster HP: 10";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(13, 13);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(73, 20);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Money: 0";
            // 
            // weaponButton
            // 
            this.weaponButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponButton.Location = new System.Drawing.Point(254, 9);
            this.weaponButton.Name = "weaponButton";
            this.weaponButton.Size = new System.Drawing.Size(115, 29);
            this.weaponButton.TabIndex = 3;
            this.weaponButton.Text = "Upgrade Weapon";
            this.weaponButton.UseVisualStyleBackColor = true;
            this.weaponButton.Click += new System.EventHandler(this.weaponButton_Click);
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponLabel.Location = new System.Drawing.Point(375, 13);
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
            this.warning.Location = new System.Drawing.Point(254, 45);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 20);
            this.warning.TabIndex = 5;
            // 
            // warningTimer
            // 
            this.warningTimer.Tick += new System.EventHandler(this.warningTimer_Tick);
            // 
            // damageClickLabel
            // 
            this.damageClickLabel.AutoSize = true;
            this.damageClickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageClickLabel.Location = new System.Drawing.Point(14, 285);
            this.damageClickLabel.Name = "damageClickLabel";
            this.damageClickLabel.Size = new System.Drawing.Size(139, 20);
            this.damageClickLabel.TabIndex = 6;
            this.damageClickLabel.Text = "Damage Per Click:";
            // 
            // damageSecondLabel
            // 
            this.damageSecondLabel.AutoSize = true;
            this.damageSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageSecondLabel.Location = new System.Drawing.Point(14, 308);
            this.damageSecondLabel.Name = "damageSecondLabel";
            this.damageSecondLabel.Size = new System.Drawing.Size(161, 20);
            this.damageSecondLabel.TabIndex = 7;
            this.damageSecondLabel.Text = "Damage Per Second:";
            // 
            // playerLevelLabel
            // 
            this.playerLevelLabel.AutoSize = true;
            this.playerLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLevelLabel.Location = new System.Drawing.Point(15, 263);
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
            this.levelUpLabel.Location = new System.Drawing.Point(123, 226);
            this.levelUpLabel.Name = "levelUpLabel";
            this.levelUpLabel.Size = new System.Drawing.Size(75, 20);
            this.levelUpLabel.TabIndex = 9;
            this.levelUpLabel.Text = "Level Up!";
            // 
            // levelTimer
            // 
            this.levelTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monsterButton
            // 
            this.monsterButton.AccessibleName = "monsterButton";
            this.monsterButton.BackgroundImage = global::MonsterClicker.Properties.Resources.img1;
            this.monsterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monsterButton.Location = new System.Drawing.Point(88, 93);
            this.monsterButton.Name = "monsterButton";
            this.monsterButton.Size = new System.Drawing.Size(145, 130);
            this.monsterButton.TabIndex = 0;
            this.monsterButton.UseVisualStyleBackColor = true;
            this.monsterButton.Click += new System.EventHandler(this.monsterButton_Click);
            // 
            // playNstop
            // 
            this.playNstop.Appearance = System.Windows.Forms.Appearance.Button;
            this.playNstop.AutoSize = true;
            this.playNstop.Checked = true;
            this.playNstop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playNstop.Location = new System.Drawing.Point(643, 305);
            this.playNstop.Name = "playNstop";
            this.playNstop.Size = new System.Drawing.Size(39, 23);
            this.playNstop.TabIndex = 20;
            this.playNstop.Text = "Stop";
            this.playNstop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playNstop.UseVisualStyleBackColor = true;
            this.playNstop.CheckedChanged += new System.EventHandler(this.playNstop_CheckedChanged);
            // 
            // testUnitButton
            // 
            this.testUnitButton.Location = new System.Drawing.Point(456, 45);
            this.testUnitButton.Name = "testUnitButton";
            this.testUnitButton.Size = new System.Drawing.Size(75, 23);
            this.testUnitButton.TabIndex = 21;
            this.testUnitButton.Text = "testUnit";
            this.testUnitButton.UseVisualStyleBackColor = true;
            this.testUnitButton.Click += new System.EventHandler(this.testUnitButton_Click);
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(538, 51);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.unitPriceLabel.TabIndex = 22;
            this.unitPriceLabel.Text = "Price:";
            // 
            // testTimer
            // 
            this.testTimer.Enabled = true;
            this.testTimer.Interval = 1000;
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // floatDamageLabel
            // 
            this.floatDamageLabel.AutoSize = true;
            this.floatDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatDamageLabel.ForeColor = System.Drawing.Color.Red;
            this.floatDamageLabel.Location = new System.Drawing.Point(333, 167);
            this.floatDamageLabel.Name = "floatDamageLabel";
            this.floatDamageLabel.Size = new System.Drawing.Size(24, 26);
            this.floatDamageLabel.TabIndex = 23;
            this.floatDamageLabel.Text = "5";
            // 
            // floatDamageTimer
            // 
            this.floatDamageTimer.Tick += new System.EventHandler(this.floatDamageTimer_Tick);
            // 
            // clickMeLabel
            // 
            this.clickMeLabel.AutoSize = true;
            this.clickMeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clickMeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickMeLabel.ForeColor = System.Drawing.Color.Orange;
            this.clickMeLabel.Location = new System.Drawing.Point(118, 226);
            this.clickMeLabel.Name = "clickMeLabel";
            this.clickMeLabel.Size = new System.Drawing.Size(80, 20);
            this.clickMeLabel.TabIndex = 24;
            this.clickMeLabel.Text = "Click Me ↑";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonsterClicker.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 341);
            this.Controls.Add(this.clickMeLabel);
            this.Controls.Add(this.floatDamageLabel);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.testUnitButton);
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
            this.Name = "Form1";
            this.Text = "Monster Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monsterButton;
        private System.Windows.Forms.CheckBox playNstop;
        private System.Windows.Forms.Button testUnitButton;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Label floatDamageLabel;
        private System.Windows.Forms.Timer floatDamageTimer;
        private System.Windows.Forms.Label clickMeLabel;
    }
}