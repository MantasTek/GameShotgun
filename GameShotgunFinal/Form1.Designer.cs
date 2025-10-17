namespace GameShotgunFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonShoot = new Button();
            buttonLoad = new Button();
            buttonBlock = new Button();
            buttonShotgun = new Button();
            labelHumanShots = new Label();
            labelComputerShots = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.Location = new Point(103, 136);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(112, 34);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(103, 96);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(112, 34);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(103, 176);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(112, 34);
            buttonBlock.TabIndex = 2;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.Location = new Point(87, 216);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(150, 43);
            buttonShotgun.TabIndex = 3;
            buttonShotgun.Text = "SHOTGUN";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // labelHumanShots
            // 
            labelHumanShots.AutoSize = true;
            labelHumanShots.Location = new Point(449, 105);
            labelHumanShots.Name = "labelHumanShots";
            labelHumanShots.Size = new Size(117, 25);
            labelHumanShots.TabIndex = 4;
            labelHumanShots.Text = "Players Shots";
            // 
            // labelComputerShots
            // 
            labelComputerShots.AutoSize = true;
            labelComputerShots.Location = new Point(449, 207);
            labelComputerShots.Name = "labelComputerShots";
            labelComputerShots.Size = new Size(142, 25);
            labelComputerShots.TabIndex = 5;
            labelComputerShots.Text = "Computer Shots";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(324, 317);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(59, 25);
            labelResult.TabIndex = 6;
            labelResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(labelComputerShots);
            Controls.Add(labelHumanShots);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonBlock);
            Controls.Add(buttonLoad);
            Controls.Add(buttonShoot);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShoot;
        private Button buttonLoad;
        private Button buttonBlock;
        private Button buttonShotgun;
        private Label labelHumanShots;
        private Label labelComputerShots;
        private Label labelResult;
    }
}
