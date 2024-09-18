namespace FarmManagementApp
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
            this.addAnimalLabel = new System.Windows.Forms.Label();
            this.CowLabel = new System.Windows.Forms.Label();
            this.sheepLable = new System.Windows.Forms.Label();
            this.cowTextBox = new System.Windows.Forms.TextBox();
            this.sheepTextBox = new System.Windows.Forms.TextBox();
            this.goatLabel = new System.Windows.Forms.Label();
            this.goatTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCowLable = new System.Windows.Forms.Label();
            this.totalSheepLable = new System.Windows.Forms.Label();
            this.totalGoatLabel = new System.Windows.Forms.Label();
            this.totalCows = new System.Windows.Forms.Label();
            this.totalSheeps = new System.Windows.Forms.Label();
            this.totalGoats = new System.Windows.Forms.Label();
            this.totalGoatMilk = new System.Windows.Forms.Label();
            this.totalSheepMilk = new System.Windows.Forms.Label();
            this.totalCowMilk = new System.Windows.Forms.Label();
            this.totalGoatMilkLabel = new System.Windows.Forms.Label();
            this.totalSheepMilkLabel = new System.Windows.Forms.Label();
            this.totalCowMilkLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.hearFarmSoundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAnimalLabel
            // 
            this.addAnimalLabel.AutoSize = true;
            this.addAnimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimalLabel.Location = new System.Drawing.Point(12, 20);
            this.addAnimalLabel.Name = "addAnimalLabel";
            this.addAnimalLabel.Size = new System.Drawing.Size(180, 20);
            this.addAnimalLabel.TabIndex = 0;
            this.addAnimalLabel.Text = "Add or Remove Animal";
            // 
            // CowLabel
            // 
            this.CowLabel.AutoSize = true;
            this.CowLabel.Location = new System.Drawing.Point(19, 54);
            this.CowLabel.Name = "CowLabel";
            this.CowLabel.Size = new System.Drawing.Size(33, 16);
            this.CowLabel.TabIndex = 1;
            this.CowLabel.Text = "Cow";
            // 
            // sheepLable
            // 
            this.sheepLable.AutoSize = true;
            this.sheepLable.Location = new System.Drawing.Point(19, 82);
            this.sheepLable.Name = "sheepLable";
            this.sheepLable.Size = new System.Drawing.Size(47, 16);
            this.sheepLable.TabIndex = 2;
            this.sheepLable.Text = "Sheep";
            // 
            // cowTextBox
            // 
            this.cowTextBox.Location = new System.Drawing.Point(78, 51);
            this.cowTextBox.Name = "cowTextBox";
            this.cowTextBox.Size = new System.Drawing.Size(114, 22);
            this.cowTextBox.TabIndex = 3;
            // 
            // sheepTextBox
            // 
            this.sheepTextBox.Location = new System.Drawing.Point(78, 79);
            this.sheepTextBox.Name = "sheepTextBox";
            this.sheepTextBox.Size = new System.Drawing.Size(114, 22);
            this.sheepTextBox.TabIndex = 4;
            // 
            // goatLabel
            // 
            this.goatLabel.AutoSize = true;
            this.goatLabel.Location = new System.Drawing.Point(19, 113);
            this.goatLabel.Name = "goatLabel";
            this.goatLabel.Size = new System.Drawing.Size(36, 16);
            this.goatLabel.TabIndex = 5;
            this.goatLabel.Text = "Goat";
            // 
            // goatTextBox
            // 
            this.goatTextBox.Location = new System.Drawing.Point(78, 107);
            this.goatTextBox.Name = "goatTextBox";
            this.goatTextBox.Size = new System.Drawing.Size(114, 22);
            this.goatTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 135);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(103, 135);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Farm Info";
            // 
            // totalCowLable
            // 
            this.totalCowLable.AutoSize = true;
            this.totalCowLable.Location = new System.Drawing.Point(275, 54);
            this.totalCowLable.Name = "totalCowLable";
            this.totalCowLable.Size = new System.Drawing.Size(106, 16);
            this.totalCowLable.TabIndex = 11;
            this.totalCowLable.Text = "Number of cows:";
            // 
            // totalSheepLable
            // 
            this.totalSheepLable.AutoSize = true;
            this.totalSheepLable.Location = new System.Drawing.Point(275, 82);
            this.totalSheepLable.Name = "totalSheepLable";
            this.totalSheepLable.Size = new System.Drawing.Size(120, 16);
            this.totalSheepLable.TabIndex = 12;
            this.totalSheepLable.Text = "Number of sheeps:";
            // 
            // totalGoatLabel
            // 
            this.totalGoatLabel.AutoSize = true;
            this.totalGoatLabel.Location = new System.Drawing.Point(275, 113);
            this.totalGoatLabel.Name = "totalGoatLabel";
            this.totalGoatLabel.Size = new System.Drawing.Size(109, 16);
            this.totalGoatLabel.TabIndex = 13;
            this.totalGoatLabel.Text = "Number of goats:";
            // 
            // totalCows
            // 
            this.totalCows.AutoSize = true;
            this.totalCows.Location = new System.Drawing.Point(401, 54);
            this.totalCows.Name = "totalCows";
            this.totalCows.Size = new System.Drawing.Size(14, 16);
            this.totalCows.TabIndex = 14;
            this.totalCows.Text = "0";
            // 
            // totalSheeps
            // 
            this.totalSheeps.AutoSize = true;
            this.totalSheeps.Location = new System.Drawing.Point(401, 82);
            this.totalSheeps.Name = "totalSheeps";
            this.totalSheeps.Size = new System.Drawing.Size(14, 16);
            this.totalSheeps.TabIndex = 15;
            this.totalSheeps.Text = "0";
            // 
            // totalGoats
            // 
            this.totalGoats.AutoSize = true;
            this.totalGoats.Location = new System.Drawing.Point(401, 113);
            this.totalGoats.Name = "totalGoats";
            this.totalGoats.Size = new System.Drawing.Size(14, 16);
            this.totalGoats.TabIndex = 16;
            this.totalGoats.Text = "0";
            // 
            // totalGoatMilk
            // 
            this.totalGoatMilk.AutoSize = true;
            this.totalGoatMilk.Location = new System.Drawing.Point(401, 224);
            this.totalGoatMilk.Name = "totalGoatMilk";
            this.totalGoatMilk.Size = new System.Drawing.Size(14, 16);
            this.totalGoatMilk.TabIndex = 22;
            this.totalGoatMilk.Text = "0";
            // 
            // totalSheepMilk
            // 
            this.totalSheepMilk.AutoSize = true;
            this.totalSheepMilk.Location = new System.Drawing.Point(401, 193);
            this.totalSheepMilk.Name = "totalSheepMilk";
            this.totalSheepMilk.Size = new System.Drawing.Size(14, 16);
            this.totalSheepMilk.TabIndex = 21;
            this.totalSheepMilk.Text = "0";
            // 
            // totalCowMilk
            // 
            this.totalCowMilk.AutoSize = true;
            this.totalCowMilk.Location = new System.Drawing.Point(401, 165);
            this.totalCowMilk.Name = "totalCowMilk";
            this.totalCowMilk.Size = new System.Drawing.Size(14, 16);
            this.totalCowMilk.TabIndex = 20;
            this.totalCowMilk.Text = "0";
            // 
            // totalGoatMilkLabel
            // 
            this.totalGoatMilkLabel.AutoSize = true;
            this.totalGoatMilkLabel.Location = new System.Drawing.Point(275, 224);
            this.totalGoatMilkLabel.Name = "totalGoatMilkLabel";
            this.totalGoatMilkLabel.Size = new System.Drawing.Size(98, 16);
            this.totalGoatMilkLabel.TabIndex = 19;
            this.totalGoatMilkLabel.Text = "Total goat milk:";
            // 
            // totalSheepMilkLabel
            // 
            this.totalSheepMilkLabel.AutoSize = true;
            this.totalSheepMilkLabel.Location = new System.Drawing.Point(275, 193);
            this.totalSheepMilkLabel.Name = "totalSheepMilkLabel";
            this.totalSheepMilkLabel.Size = new System.Drawing.Size(109, 16);
            this.totalSheepMilkLabel.TabIndex = 18;
            this.totalSheepMilkLabel.Text = "Total sheep milk:";
            // 
            // totalCowMilkLabel
            // 
            this.totalCowMilkLabel.AutoSize = true;
            this.totalCowMilkLabel.Location = new System.Drawing.Point(275, 165);
            this.totalCowMilkLabel.Name = "totalCowMilkLabel";
            this.totalCowMilkLabel.Size = new System.Drawing.Size(95, 16);
            this.totalCowMilkLabel.TabIndex = 17;
            this.totalCowMilkLabel.Text = "Total cow milk:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(278, 261);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 23);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(387, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 23);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // hearFarmSoundButton
            // 
            this.hearFarmSoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hearFarmSoundButton.Location = new System.Drawing.Point(12, 386);
            this.hearFarmSoundButton.Name = "hearFarmSoundButton";
            this.hearFarmSoundButton.Size = new System.Drawing.Size(54, 52);
            this.hearFarmSoundButton.TabIndex = 25;
            this.hearFarmSoundButton.Text = "🔊";
            this.hearFarmSoundButton.UseVisualStyleBackColor = true;
            this.hearFarmSoundButton.Click += new System.EventHandler(this.hearFarmSoundButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.hearFarmSoundButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.totalGoatMilk);
            this.Controls.Add(this.totalSheepMilk);
            this.Controls.Add(this.totalCowMilk);
            this.Controls.Add(this.totalGoatMilkLabel);
            this.Controls.Add(this.totalSheepMilkLabel);
            this.Controls.Add(this.totalCowMilkLabel);
            this.Controls.Add(this.totalGoats);
            this.Controls.Add(this.totalSheeps);
            this.Controls.Add(this.totalCows);
            this.Controls.Add(this.totalGoatLabel);
            this.Controls.Add(this.totalSheepLable);
            this.Controls.Add(this.totalCowLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.goatTextBox);
            this.Controls.Add(this.goatLabel);
            this.Controls.Add(this.sheepTextBox);
            this.Controls.Add(this.cowTextBox);
            this.Controls.Add(this.sheepLable);
            this.Controls.Add(this.CowLabel);
            this.Controls.Add(this.addAnimalLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAnimalLabel;
        private System.Windows.Forms.Label CowLabel;
        private System.Windows.Forms.Label sheepLable;
        private System.Windows.Forms.TextBox cowTextBox;
        private System.Windows.Forms.TextBox sheepTextBox;
        private System.Windows.Forms.Label goatLabel;
        private System.Windows.Forms.TextBox goatTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalCowLable;
        private System.Windows.Forms.Label totalSheepLable;
        private System.Windows.Forms.Label totalGoatLabel;
        private System.Windows.Forms.Label totalCows;
        private System.Windows.Forms.Label totalSheeps;
        private System.Windows.Forms.Label totalGoats;
        private System.Windows.Forms.Label totalGoatMilk;
        private System.Windows.Forms.Label totalSheepMilk;
        private System.Windows.Forms.Label totalCowMilk;
        private System.Windows.Forms.Label totalGoatMilkLabel;
        private System.Windows.Forms.Label totalSheepMilkLabel;
        private System.Windows.Forms.Label totalCowMilkLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button hearFarmSoundButton;
    }
}

