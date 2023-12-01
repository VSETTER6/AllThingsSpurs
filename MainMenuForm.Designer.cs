namespace AllThingsSpursMain
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            backButton = new Button();
            playerButton = new Button();
            managerButton = new Button();
            guessTheScoreButton = new Button();
            clubInfoButton = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.ForeColor = Color.FromArgb(0, 0, 64);
            backButton.Location = new Point(713, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 4;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // playerButton
            // 
            playerButton.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playerButton.ForeColor = Color.FromArgb(0, 0, 64);
            playerButton.Location = new Point(169, 134);
            playerButton.Margin = new Padding(160, 125, 3, 3);
            playerButton.Name = "playerButton";
            playerButton.Size = new Size(206, 69);
            playerButton.TabIndex = 0;
            playerButton.Text = "PLAYERS";
            playerButton.UseVisualStyleBackColor = true;
            playerButton.Click += playerButton_Click;
            // 
            // managerButton
            // 
            managerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            managerButton.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            managerButton.ForeColor = Color.FromArgb(0, 0, 64);
            managerButton.Location = new Point(425, 134);
            managerButton.Margin = new Padding(3, 125, 160, 3);
            managerButton.Name = "managerButton";
            managerButton.Size = new Size(206, 69);
            managerButton.TabIndex = 1;
            managerButton.Text = "MANAGERS";
            managerButton.UseVisualStyleBackColor = true;
            managerButton.Click += managerButton_Click;
            // 
            // guessTheScoreButton
            // 
            guessTheScoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guessTheScoreButton.Font = new Font("Impact", 19F, FontStyle.Regular, GraphicsUnit.Point);
            guessTheScoreButton.ForeColor = Color.FromArgb(0, 0, 64);
            guessTheScoreButton.Location = new Point(425, 247);
            guessTheScoreButton.Margin = new Padding(3, 3, 160, 125);
            guessTheScoreButton.Name = "guessTheScoreButton";
            guessTheScoreButton.Size = new Size(206, 69);
            guessTheScoreButton.TabIndex = 3;
            guessTheScoreButton.Text = "GUESS THE SCORE";
            guessTheScoreButton.UseVisualStyleBackColor = true;
            guessTheScoreButton.Click += guessTheScoreButton_Click;
            // 
            // clubInfoButton
            // 
            clubInfoButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clubInfoButton.BackgroundImage = Properties.Resources.SpursLogoPng;
            clubInfoButton.Font = new Font("Impact", 19F, FontStyle.Regular, GraphicsUnit.Point);
            clubInfoButton.ForeColor = Color.FromArgb(0, 0, 64);
            clubInfoButton.Location = new Point(169, 247);
            clubInfoButton.Margin = new Padding(160, 3, 3, 125);
            clubInfoButton.Name = "clubInfoButton";
            clubInfoButton.Size = new Size(206, 69);
            clubInfoButton.TabIndex = 2;
            clubInfoButton.Text = "YOUR STARTING Xl";
            clubInfoButton.UseVisualStyleBackColor = true;
            clubInfoButton.Click += clubInfoButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = Properties.Resources.SpursLogoPng;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(clubInfoButton);
            Controls.Add(guessTheScoreButton);
            Controls.Add(managerButton);
            Controls.Add(playerButton);
            Controls.Add(backButton);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            Text = "All Things Spurs Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Button playerButton;
        private Button managerButton;
        private Button guessTheScoreButton;
        private Button clubInfoButton;
    }
}