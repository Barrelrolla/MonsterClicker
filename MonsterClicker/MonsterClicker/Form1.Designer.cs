namespace MonsterClicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.monsterButton = new System.Windows.Forms.Button();
            this.building01button = new System.Windows.Forms.Button();
            this.building02button = new System.Windows.Forms.Button();
            this.building03button = new System.Windows.Forms.Button();
            this.building04button = new System.Windows.Forms.Button();
            this.building05button = new System.Windows.Forms.Button();
            this.building06button = new System.Windows.Forms.Button();
            this.building07button = new System.Windows.Forms.Button();
            this.building08button = new System.Windows.Forms.Button();
            this.building09button = new System.Windows.Forms.Button();
            this.monsterHPLabel = new System.Windows.Forms.Label();
            this.unit01label = new System.Windows.Forms.Label();
            this.unit02label = new System.Windows.Forms.Label();
            this.unit03label = new System.Windows.Forms.Label();
            this.unit04label = new System.Windows.Forms.Label();
            this.unit05label = new System.Windows.Forms.Label();
            this.unit06label = new System.Windows.Forms.Label();
            this.unit07label = new System.Windows.Forms.Label();
            this.unit08label = new System.Windows.Forms.Label();
            this.unit09label = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.clickDamageLabel = new System.Windows.Forms.Label();
            this.dpsLabel = new System.Windows.Forms.Label();
            this.playerLevelLabel = new System.Windows.Forms.Label();
            this.playerXPLabel = new System.Windows.Forms.Label();
            this.weaponButton = new System.Windows.Forms.Button();
            this.weaponCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monsterButton
            // 
            this.monsterButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.monster;
            this.monsterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monsterButton.Location = new System.Drawing.Point(73, 104);
            this.monsterButton.Name = "monsterButton";
            this.monsterButton.Size = new System.Drawing.Size(143, 141);
            this.monsterButton.TabIndex = 0;
            this.monsterButton.UseVisualStyleBackColor = true;
            this.monsterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // building01button
            // 
            this.building01button.Location = new System.Drawing.Point(298, 24);
            this.building01button.Name = "building01button";
            this.building01button.Size = new System.Drawing.Size(95, 23);
            this.building01button.TabIndex = 1;
            this.building01button.Text = "Buy Unit";
            this.building01button.UseVisualStyleBackColor = true;
            // 
            // building02button
            // 
            this.building02button.Location = new System.Drawing.Point(298, 54);
            this.building02button.Name = "building02button";
            this.building02button.Size = new System.Drawing.Size(95, 23);
            this.building02button.TabIndex = 2;
            this.building02button.Text = "Build Building";
            this.building02button.UseVisualStyleBackColor = true;
            // 
            // building03button
            // 
            this.building03button.Location = new System.Drawing.Point(298, 84);
            this.building03button.Name = "building03button";
            this.building03button.Size = new System.Drawing.Size(95, 23);
            this.building03button.TabIndex = 3;
            this.building03button.Text = "building";
            this.building03button.UseVisualStyleBackColor = true;
            // 
            // building04button
            // 
            this.building04button.Location = new System.Drawing.Point(298, 114);
            this.building04button.Name = "building04button";
            this.building04button.Size = new System.Drawing.Size(95, 23);
            this.building04button.TabIndex = 4;
            this.building04button.Text = "building";
            this.building04button.UseVisualStyleBackColor = true;
            // 
            // building05button
            // 
            this.building05button.Location = new System.Drawing.Point(298, 144);
            this.building05button.Name = "building05button";
            this.building05button.Size = new System.Drawing.Size(95, 23);
            this.building05button.TabIndex = 5;
            this.building05button.Text = "building";
            this.building05button.UseVisualStyleBackColor = true;
            // 
            // building06button
            // 
            this.building06button.Location = new System.Drawing.Point(298, 174);
            this.building06button.Name = "building06button";
            this.building06button.Size = new System.Drawing.Size(95, 23);
            this.building06button.TabIndex = 6;
            this.building06button.Text = "building";
            this.building06button.UseVisualStyleBackColor = true;
            // 
            // building07button
            // 
            this.building07button.Location = new System.Drawing.Point(298, 204);
            this.building07button.Name = "building07button";
            this.building07button.Size = new System.Drawing.Size(95, 23);
            this.building07button.TabIndex = 7;
            this.building07button.Text = "building";
            this.building07button.UseVisualStyleBackColor = true;
            // 
            // building08button
            // 
            this.building08button.Location = new System.Drawing.Point(298, 234);
            this.building08button.Name = "building08button";
            this.building08button.Size = new System.Drawing.Size(95, 23);
            this.building08button.TabIndex = 8;
            this.building08button.Text = "building";
            this.building08button.UseVisualStyleBackColor = true;
            // 
            // building09button
            // 
            this.building09button.Location = new System.Drawing.Point(298, 264);
            this.building09button.Name = "building09button";
            this.building09button.Size = new System.Drawing.Size(95, 23);
            this.building09button.TabIndex = 9;
            this.building09button.Text = "building";
            this.building09button.UseVisualStyleBackColor = true;
            // 
            // monsterHPLabel
            // 
            this.monsterHPLabel.AutoSize = true;
            this.monsterHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.monsterHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterHPLabel.ForeColor = System.Drawing.Color.Red;
            this.monsterHPLabel.Location = new System.Drawing.Point(70, 88);
            this.monsterHPLabel.Name = "monsterHPLabel";
            this.monsterHPLabel.Size = new System.Drawing.Size(111, 13);
            this.monsterHPLabel.TabIndex = 13;
            this.monsterHPLabel.Text = "MONSTER HP: 10";
            this.monsterHPLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // unit01label
            // 
            this.unit01label.AutoSize = true;
            this.unit01label.BackColor = System.Drawing.Color.Transparent;
            this.unit01label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit01label.ForeColor = System.Drawing.Color.Red;
            this.unit01label.Location = new System.Drawing.Point(400, 33);
            this.unit01label.Name = "unit01label";
            this.unit01label.Size = new System.Drawing.Size(107, 13);
            this.unit01label.TabIndex = 14;
            this.unit01label.Text = "Unit 1 (or picture)";
            // 
            // unit02label
            // 
            this.unit02label.AutoSize = true;
            this.unit02label.BackColor = System.Drawing.Color.Transparent;
            this.unit02label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit02label.ForeColor = System.Drawing.Color.Red;
            this.unit02label.Location = new System.Drawing.Point(400, 63);
            this.unit02label.Name = "unit02label";
            this.unit02label.Size = new System.Drawing.Size(129, 13);
            this.unit02label.TabIndex = 15;
            this.unit02label.Text = "Building 2 (or picture)";
            // 
            // unit03label
            // 
            this.unit03label.AutoSize = true;
            this.unit03label.BackColor = System.Drawing.Color.Transparent;
            this.unit03label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit03label.ForeColor = System.Drawing.Color.Red;
            this.unit03label.Location = new System.Drawing.Point(399, 94);
            this.unit03label.Name = "unit03label";
            this.unit03label.Size = new System.Drawing.Size(28, 13);
            this.unit03label.TabIndex = 16;
            this.unit03label.Text = "unit";
            // 
            // unit04label
            // 
            this.unit04label.AutoSize = true;
            this.unit04label.BackColor = System.Drawing.Color.Transparent;
            this.unit04label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit04label.ForeColor = System.Drawing.Color.Red;
            this.unit04label.Location = new System.Drawing.Point(399, 124);
            this.unit04label.Name = "unit04label";
            this.unit04label.Size = new System.Drawing.Size(28, 13);
            this.unit04label.TabIndex = 17;
            this.unit04label.Text = "unit";
            // 
            // unit05label
            // 
            this.unit05label.AutoSize = true;
            this.unit05label.BackColor = System.Drawing.Color.Transparent;
            this.unit05label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit05label.ForeColor = System.Drawing.Color.Red;
            this.unit05label.Location = new System.Drawing.Point(399, 154);
            this.unit05label.Name = "unit05label";
            this.unit05label.Size = new System.Drawing.Size(28, 13);
            this.unit05label.TabIndex = 18;
            this.unit05label.Text = "unit";
            // 
            // unit06label
            // 
            this.unit06label.AutoSize = true;
            this.unit06label.BackColor = System.Drawing.Color.Transparent;
            this.unit06label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit06label.ForeColor = System.Drawing.Color.Red;
            this.unit06label.Location = new System.Drawing.Point(399, 184);
            this.unit06label.Name = "unit06label";
            this.unit06label.Size = new System.Drawing.Size(28, 13);
            this.unit06label.TabIndex = 19;
            this.unit06label.Text = "unit";
            // 
            // unit07label
            // 
            this.unit07label.AutoSize = true;
            this.unit07label.BackColor = System.Drawing.Color.Transparent;
            this.unit07label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit07label.ForeColor = System.Drawing.Color.Red;
            this.unit07label.Location = new System.Drawing.Point(399, 214);
            this.unit07label.Name = "unit07label";
            this.unit07label.Size = new System.Drawing.Size(28, 13);
            this.unit07label.TabIndex = 20;
            this.unit07label.Text = "unit";
            // 
            // unit08label
            // 
            this.unit08label.AutoSize = true;
            this.unit08label.BackColor = System.Drawing.Color.Transparent;
            this.unit08label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit08label.ForeColor = System.Drawing.Color.Red;
            this.unit08label.Location = new System.Drawing.Point(399, 244);
            this.unit08label.Name = "unit08label";
            this.unit08label.Size = new System.Drawing.Size(28, 13);
            this.unit08label.TabIndex = 21;
            this.unit08label.Text = "unit";
            this.unit08label.Click += new System.EventHandler(this.label9_Click);
            // 
            // unit09label
            // 
            this.unit09label.AutoSize = true;
            this.unit09label.BackColor = System.Drawing.Color.Transparent;
            this.unit09label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit09label.ForeColor = System.Drawing.Color.Red;
            this.unit09label.Location = new System.Drawing.Point(399, 274);
            this.unit09label.Name = "unit09label";
            this.unit09label.Size = new System.Drawing.Size(28, 13);
            this.unit09label.TabIndex = 22;
            this.unit09label.Text = "unit";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.Red;
            this.moneyLabel.Location = new System.Drawing.Point(13, 13);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(59, 13);
            this.moneyLabel.TabIndex = 23;
            this.moneyLabel.Text = "Money: 0";
            this.moneyLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // clickDamageLabel
            // 
            this.clickDamageLabel.AutoSize = true;
            this.clickDamageLabel.BackColor = System.Drawing.Color.Transparent;
            this.clickDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickDamageLabel.ForeColor = System.Drawing.Color.Red;
            this.clickDamageLabel.Location = new System.Drawing.Point(13, 26);
            this.clickDamageLabel.Name = "clickDamageLabel";
            this.clickDamageLabel.Size = new System.Drawing.Size(126, 13);
            this.clickDamageLabel.TabIndex = 24;
            this.clickDamageLabel.Text = "Damage per Click : 1";
            // 
            // dpsLabel
            // 
            this.dpsLabel.AutoSize = true;
            this.dpsLabel.BackColor = System.Drawing.Color.Transparent;
            this.dpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpsLabel.ForeColor = System.Drawing.Color.Red;
            this.dpsLabel.Location = new System.Drawing.Point(13, 42);
            this.dpsLabel.Name = "dpsLabel";
            this.dpsLabel.Size = new System.Drawing.Size(137, 13);
            this.dpsLabel.TabIndex = 25;
            this.dpsLabel.Text = "Damage per Second: 1";
            // 
            // playerLevelLabel
            // 
            this.playerLevelLabel.AutoSize = true;
            this.playerLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLevelLabel.ForeColor = System.Drawing.Color.Red;
            this.playerLevelLabel.Location = new System.Drawing.Point(13, 264);
            this.playerLevelLabel.Name = "playerLevelLabel";
            this.playerLevelLabel.Size = new System.Drawing.Size(92, 13);
            this.playerLevelLabel.TabIndex = 26;
            this.playerLevelLabel.Text = "Player Level: 1";
            this.playerLevelLabel.Click += new System.EventHandler(this.label14_Click);
            // 
            // playerXPLabel
            // 
            this.playerXPLabel.AutoSize = true;
            this.playerXPLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerXPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerXPLabel.ForeColor = System.Drawing.Color.Red;
            this.playerXPLabel.Location = new System.Drawing.Point(13, 289);
            this.playerXPLabel.Name = "playerXPLabel";
            this.playerXPLabel.Size = new System.Drawing.Size(119, 13);
            this.playerXPLabel.TabIndex = 27;
            this.playerXPLabel.Text = "XP to next level: 10";
            this.playerXPLabel.Click += new System.EventHandler(this.label15_Click);
            // 
            // weaponButton
            // 
            this.weaponButton.Location = new System.Drawing.Point(175, 24);
            this.weaponButton.Name = "weaponButton";
            this.weaponButton.Size = new System.Drawing.Size(100, 23);
            this.weaponButton.TabIndex = 28;
            this.weaponButton.Text = "Weapon lvl 1";
            this.weaponButton.UseVisualStyleBackColor = true;
            // 
            // weaponCostLabel
            // 
            this.weaponCostLabel.AutoSize = true;
            this.weaponCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.weaponCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weaponCostLabel.ForeColor = System.Drawing.Color.Red;
            this.weaponCostLabel.Location = new System.Drawing.Point(175, 54);
            this.weaponCostLabel.Name = "weaponCostLabel";
            this.weaponCostLabel.Size = new System.Drawing.Size(104, 13);
            this.weaponCostLabel.TabIndex = 29;
            this.weaponCostLabel.Text = "Weapon cost: 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 315);
            this.Controls.Add(this.weaponCostLabel);
            this.Controls.Add(this.weaponButton);
            this.Controls.Add(this.playerXPLabel);
            this.Controls.Add(this.playerLevelLabel);
            this.Controls.Add(this.dpsLabel);
            this.Controls.Add(this.clickDamageLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.unit09label);
            this.Controls.Add(this.unit08label);
            this.Controls.Add(this.unit07label);
            this.Controls.Add(this.unit06label);
            this.Controls.Add(this.unit05label);
            this.Controls.Add(this.unit04label);
            this.Controls.Add(this.unit03label);
            this.Controls.Add(this.unit02label);
            this.Controls.Add(this.unit01label);
            this.Controls.Add(this.monsterHPLabel);
            this.Controls.Add(this.building09button);
            this.Controls.Add(this.building08button);
            this.Controls.Add(this.building07button);
            this.Controls.Add(this.building06button);
            this.Controls.Add(this.building05button);
            this.Controls.Add(this.building04button);
            this.Controls.Add(this.building03button);
            this.Controls.Add(this.building02button);
            this.Controls.Add(this.building01button);
            this.Controls.Add(this.monsterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Monster Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monsterButton;
        private System.Windows.Forms.Button building01button;
        private System.Windows.Forms.Button building02button;
        private System.Windows.Forms.Button building03button;
        private System.Windows.Forms.Button building04button;
        private System.Windows.Forms.Button building05button;
        private System.Windows.Forms.Button building06button;
        private System.Windows.Forms.Button building07button;
        private System.Windows.Forms.Button building08button;
        private System.Windows.Forms.Button building09button;
        private System.Windows.Forms.Label monsterHPLabel;
        private System.Windows.Forms.Label unit01label;
        private System.Windows.Forms.Label unit02label;
        private System.Windows.Forms.Label unit03label;
        private System.Windows.Forms.Label unit04label;
        private System.Windows.Forms.Label unit05label;
        private System.Windows.Forms.Label unit06label;
        private System.Windows.Forms.Label unit07label;
        private System.Windows.Forms.Label unit08label;
        private System.Windows.Forms.Label unit09label;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label clickDamageLabel;
        private System.Windows.Forms.Label dpsLabel;
        private System.Windows.Forms.Label playerLevelLabel;
        private System.Windows.Forms.Label playerXPLabel;
        private System.Windows.Forms.Button weaponButton;
        private System.Windows.Forms.Label weaponCostLabel;
    }
}

