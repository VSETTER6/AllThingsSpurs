namespace AllThingsSpursMain
{
    partial class PlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersForm));
            firstNameLabel = new Label();
            nationLabel = new Label();
            clubLabel = new Label();
            ageLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            clubTextBox = new TextBox();
            nationTextBox = new TextBox();
            backButton = new Button();
            ageNumeric = new NumericUpDown();
            addPlayersHeaderLabel = new Label();
            addPlayersInfoLabel = new Label();
            viewPlayersHeaderLabel = new Label();
            viewPlayersInfoLabel = new Label();
            playersListBox = new ListBox();
            addPlayerButton = new Button();
            playerInfoButton = new Button();
            removeButton = new Button();
            positionLabel = new Label();
            positionTextBox = new TextBox();
            loadPlayersButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumeric).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.White;
            firstNameLabel.Location = new Point(49, 156);
            firstNameLabel.Margin = new Padding(40, 10, 10, 10);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(77, 19);
            firstNameLabel.TabIndex = 17;
            firstNameLabel.Text = "FIRST NAME";
            // 
            // nationLabel
            // 
            nationLabel.AutoSize = true;
            nationLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nationLabel.ForeColor = Color.White;
            nationLabel.Location = new Point(49, 316);
            nationLabel.Margin = new Padding(40, 10, 10, 10);
            nationLabel.Name = "nationLabel";
            nationLabel.Size = new Size(50, 19);
            nationLabel.TabIndex = 18;
            nationLabel.Text = "NATION";
            // 
            // clubLabel
            // 
            clubLabel.AutoSize = true;
            clubLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            clubLabel.ForeColor = Color.White;
            clubLabel.Location = new Point(49, 276);
            clubLabel.Margin = new Padding(40, 10, 10, 10);
            clubLabel.Name = "clubLabel";
            clubLabel.Size = new Size(39, 19);
            clubLabel.TabIndex = 19;
            clubLabel.Text = "CLUB";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.ForeColor = Color.White;
            ageLabel.Location = new Point(49, 236);
            ageLabel.Margin = new Padding(40, 10, 10, 10);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(30, 19);
            ageLabel.TabIndex = 20;
            ageLabel.Text = "AGE";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.White;
            lastNameLabel.Location = new Point(49, 196);
            lastNameLabel.Margin = new Padding(40, 10, 10, 10);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(72, 19);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "LAST NAME";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            firstNameTextBox.Location = new Point(138, 156);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "John";
            firstNameTextBox.Size = new Size(175, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            lastNameTextBox.Location = new Point(138, 196);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Dough";
            lastNameTextBox.Size = new Size(175, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // clubTextBox
            // 
            clubTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clubTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            clubTextBox.Location = new Point(138, 276);
            clubTextBox.Name = "clubTextBox";
            clubTextBox.PlaceholderText = "Tottenham Hotspur";
            clubTextBox.Size = new Size(175, 23);
            clubTextBox.TabIndex = 3;
            // 
            // nationTextBox
            // 
            nationTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nationTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            nationTextBox.Location = new Point(138, 316);
            nationTextBox.Name = "nationTextBox";
            nationTextBox.PlaceholderText = "Sweden";
            nationTextBox.Size = new Size(175, 23);
            nationTextBox.TabIndex = 4;
            // 
            // backButton
            // 
            backButton.ForeColor = Color.FromArgb(0, 0, 64);
            backButton.Location = new Point(713, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 11;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ageNumeric
            // 
            ageNumeric.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ageNumeric.ForeColor = Color.FromArgb(0, 0, 64);
            ageNumeric.Location = new Point(138, 236);
            ageNumeric.Name = "ageNumeric";
            ageNumeric.Size = new Size(175, 23);
            ageNumeric.TabIndex = 2;
            // 
            // addPlayersHeaderLabel
            // 
            addPlayersHeaderLabel.BackColor = Color.Transparent;
            addPlayersHeaderLabel.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            addPlayersHeaderLabel.ForeColor = Color.White;
            addPlayersHeaderLabel.Location = new Point(49, 44);
            addPlayersHeaderLabel.Margin = new Padding(3, 20, 3, 0);
            addPlayersHeaderLabel.Name = "addPlayersHeaderLabel";
            addPlayersHeaderLabel.Size = new Size(264, 36);
            addPlayersHeaderLabel.TabIndex = 12;
            addPlayersHeaderLabel.Text = "ADD PLAYERS";
            addPlayersHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addPlayersInfoLabel
            // 
            addPlayersInfoLabel.BackColor = Color.Transparent;
            addPlayersInfoLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addPlayersInfoLabel.ForeColor = Color.White;
            addPlayersInfoLabel.Location = new Point(49, 85);
            addPlayersInfoLabel.Margin = new Padding(3, 5, 3, 0);
            addPlayersInfoLabel.Name = "addPlayersInfoLabel";
            addPlayersInfoLabel.Size = new Size(264, 40);
            addPlayersInfoLabel.TabIndex = 12;
            addPlayersInfoLabel.Text = "HERE YOU COULD ADD PLAYERS IF YOU THINK ANYONE IS MISSING\r\n";
            addPlayersInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewPlayersHeaderLabel
            // 
            viewPlayersHeaderLabel.BackColor = Color.Transparent;
            viewPlayersHeaderLabel.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            viewPlayersHeaderLabel.ForeColor = Color.White;
            viewPlayersHeaderLabel.Location = new Point(487, 44);
            viewPlayersHeaderLabel.Margin = new Padding(3, 3, 20, 0);
            viewPlayersHeaderLabel.Name = "viewPlayersHeaderLabel";
            viewPlayersHeaderLabel.Size = new Size(264, 36);
            viewPlayersHeaderLabel.TabIndex = 12;
            viewPlayersHeaderLabel.Text = "VIEW PLAYERS";
            viewPlayersHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewPlayersInfoLabel
            // 
            viewPlayersInfoLabel.BackColor = Color.Transparent;
            viewPlayersInfoLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewPlayersInfoLabel.ForeColor = Color.White;
            viewPlayersInfoLabel.Location = new Point(487, 85);
            viewPlayersInfoLabel.Margin = new Padding(3, 5, 3, 0);
            viewPlayersInfoLabel.Name = "viewPlayersInfoLabel";
            viewPlayersInfoLabel.Size = new Size(264, 57);
            viewPlayersInfoLabel.TabIndex = 12;
            viewPlayersInfoLabel.Text = "HERE YOU CAN VIEW ALL PLAYERS AND BY SELECTING ONE AND PRESSING  \"PLAYER INFO\"  YOU GET MORE INFO";
            viewPlayersInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playersListBox
            // 
            playersListBox.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            playersListBox.ForeColor = Color.FromArgb(0, 0, 64);
            playersListBox.FormattingEnabled = true;
            playersListBox.ItemHeight = 16;
            playersListBox.Location = new Point(487, 156);
            playersListBox.Margin = new Padding(3, 3, 40, 3);
            playersListBox.Name = "playersListBox";
            playersListBox.Size = new Size(264, 180);
            playersListBox.TabIndex = 7;
            // 
            // addPlayerButton
            // 
            addPlayerButton.ForeColor = Color.FromArgb(0, 0, 64);
            addPlayerButton.Location = new Point(188, 392);
            addPlayerButton.Margin = new Padding(10);
            addPlayerButton.Name = "addPlayerButton";
            addPlayerButton.Size = new Size(75, 23);
            addPlayerButton.TabIndex = 6;
            addPlayerButton.Text = "ADD";
            addPlayerButton.UseVisualStyleBackColor = true;
            addPlayerButton.Click += addPlayerButton_Click;
            // 
            // playerInfoButton
            // 
            playerInfoButton.ForeColor = Color.FromArgb(0, 0, 64);
            playerInfoButton.Location = new Point(487, 349);
            playerInfoButton.Margin = new Padding(0);
            playerInfoButton.Name = "playerInfoButton";
            playerInfoButton.Size = new Size(85, 23);
            playerInfoButton.TabIndex = 8;
            playerInfoButton.Text = "PLAYER INFO";
            playerInfoButton.UseVisualStyleBackColor = true;
            playerInfoButton.Click += playerInfoButton_Click;
            // 
            // removeButton
            // 
            removeButton.ForeColor = Color.FromArgb(0, 0, 64);
            removeButton.Location = new Point(676, 349);
            removeButton.Margin = new Padding(0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 9;
            removeButton.Text = "REMOVE";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            positionLabel.ForeColor = Color.White;
            positionLabel.Location = new Point(49, 356);
            positionLabel.Margin = new Padding(40, 10, 10, 10);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(64, 19);
            positionLabel.TabIndex = 37;
            positionLabel.Text = "POSITION";
            // 
            // positionTextBox
            // 
            positionTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            positionTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            positionTextBox.Location = new Point(138, 357);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.PlaceholderText = "Right back";
            positionTextBox.Size = new Size(175, 23);
            positionTextBox.TabIndex = 5;
            // 
            // loadPlayersButton
            // 
            loadPlayersButton.ForeColor = Color.FromArgb(0, 0, 64);
            loadPlayersButton.Location = new Point(588, 349);
            loadPlayersButton.Margin = new Padding(0);
            loadPlayersButton.Name = "loadPlayersButton";
            loadPlayersButton.Size = new Size(75, 23);
            loadPlayersButton.TabIndex = 10;
            loadPlayersButton.Text = "LOAD";
            loadPlayersButton.UseVisualStyleBackColor = true;
            loadPlayersButton.Click += loadPlayersButton_Click;
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = Properties.Resources.SpursLogoPng;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(loadPlayersButton);
            Controls.Add(positionTextBox);
            Controls.Add(positionLabel);
            Controls.Add(removeButton);
            Controls.Add(playerInfoButton);
            Controls.Add(addPlayerButton);
            Controls.Add(playersListBox);
            Controls.Add(viewPlayersInfoLabel);
            Controls.Add(viewPlayersHeaderLabel);
            Controls.Add(addPlayersInfoLabel);
            Controls.Add(addPlayersHeaderLabel);
            Controls.Add(ageNumeric);
            Controls.Add(backButton);
            Controls.Add(nationTextBox);
            Controls.Add(clubTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(ageLabel);
            Controls.Add(clubLabel);
            Controls.Add(nationLabel);
            Controls.Add(firstNameLabel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlayersForm";
            Text = "All Things Spurs Players";
            ((System.ComponentModel.ISupportInitialize)ageNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label firstNameLabel;
        private Label nationLabel;
        private Label clubLabel;
        private Label ageLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox textBox1;
        private TextBox lastNameTextBox;
        private TextBox clubTextBox;
        private TextBox nationTextBox;
        private Button backButton;
        private NumericUpDown ageNumeric;
        private Label addPlayersHeaderLabel;
        private Label addPlayersInfoLabel;
        private Label viewPlayersHeaderLabel;
        private Label viewPlayersInfoLabel;
        private ListBox playersListBox;
        private Button addPlayerButton;
        private Button playerInfoButton;
        private Button removeButton;
        private Label positionLabel;
        private TextBox positionTextBox;
        private Button loadPlayersButton;
    }
}