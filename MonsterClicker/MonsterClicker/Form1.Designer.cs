namespace MonsterClicker
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button monsterButton;
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
            this.monsterButton = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // monsterButton
            // 
            this.monsterButton.BackgroundImage = global::MonsterClicker.Properties.Resources.monster;
            this.monsterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monsterButton.Location = new System.Drawing.Point(88, 93);
            this.monsterButton.Name = "monsterButton";
            this.monsterButton.Size = new System.Drawing.Size(145, 130);
            this.monsterButton.TabIndex = 0;
            this.monsterButton.UseVisualStyleBackColor = true;
            this.monsterButton.Click += new System.EventHandler(this.monsterButton_Click);
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
            this.weaponButton.Text = "Buy Weapon";
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
            this.levelUpLabel.Size = new System.Drawing.Size(80, 20);
            this.levelUpLabel.TabIndex = 9;
            this.levelUpLabel.Text = "Click Me ↑";
            // 
            // levelTimer
            // 
            this.levelTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonsterClicker.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 341);
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
    }
}