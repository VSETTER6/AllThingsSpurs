namespace AllThingsSpursMain
{
    partial class ManagersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagersForm));
            loadPlayersButton = new Button();
            philosophyTextBox = new TextBox();
            philosophyLabel = new Label();
            removeButton = new Button();
            managerInfoButton = new Button();
            addManagerButton = new Button();
            managersListBox = new ListBox();
            viewManagersInfoLabel = new Label();
            viewManagersHeaderLabel = new Label();
            addManagersInfoLabel = new Label();
            addManagersHeaderLabel = new Label();
            ageNumeric = new NumericUpDown();
            backButton = new Button();
            nationTextBox = new TextBox();
            clubTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            ageLabel = new Label();
            clubLabel = new Label();
            nationLabel = new Label();
            firstNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ageNumeric).BeginInit();
            SuspendLayout();
            // 
            // loadPlayersButton
            // 
            loadPlayersButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loadPlayersButton.ForeColor = Color.FromArgb(0, 0, 64);
            loadPlayersButton.Location = new Point(605, 353);
            loadPlayersButton.Margin = new Padding(0);
            loadPlayersButton.Name = "loadPlayersButton";
            loadPlayersButton.Size = new Size(65, 23);
            loadPlayersButton.TabIndex = 10;
            loadPlayersButton.Text = "LOAD";
            loadPlayersButton.UseVisualStyleBackColor = true;
            loadPlayersButton.Click += loadPlayersButton_Click;
            // 
            // philosophyTextBox
            // 
            philosophyTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            philosophyTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            philosophyTextBox.Location = new Point(136, 354);
            philosophyTextBox.Name = "philosophyTextBox";
            philosophyTextBox.PlaceholderText = "Possesion";
            philosophyTextBox.Size = new Size(175, 23);
            philosophyTextBox.TabIndex = 5;
            philosophyTextBox.TextChanged += philosophyTextBox_TextChanged;
            // 
            // philosophyLabel
            // 
            philosophyLabel.AutoSize = true;
            philosophyLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            philosophyLabel.ForeColor = Color.White;
            philosophyLabel.Location = new Point(49, 356);
            philosophyLabel.Margin = new Padding(40, 10, 10, 10);
            philosophyLabel.Name = "philosophyLabel";
            philosophyLabel.Size = new Size(81, 19);
            philosophyLabel.TabIndex = 60;
            philosophyLabel.Text = "PHILOSOPHY";
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.ForeColor = Color.FromArgb(0, 0, 64);
            removeButton.Location = new Point(686, 353);
            removeButton.Margin = new Padding(0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(65, 23);
            removeButton.TabIndex = 9;
            removeButton.Text = "REMOVE";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // managerInfoButton
            // 
            managerInfoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            managerInfoButton.ForeColor = Color.FromArgb(0, 0, 64);
            managerInfoButton.Location = new Point(487, 353);
            managerInfoButton.Margin = new Padding(0);
            managerInfoButton.Name = "managerInfoButton";
            managerInfoButton.Size = new Size(102, 23);
            managerInfoButton.TabIndex = 8;
            managerInfoButton.Text = "MANAGER INFO";
            managerInfoButton.UseVisualStyleBackColor = true;
            managerInfoButton.Click += managerInfoButton_Click;
            // 
            // addManagerButton
            // 
            addManagerButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addManagerButton.ForeColor = Color.FromArgb(0, 0, 64);
            addManagerButton.Location = new Point(170, 392);
            addManagerButton.Margin = new Padding(10);
            addManagerButton.Name = "addManagerButton";
            addManagerButton.Size = new Size(75, 23);
            addManagerButton.TabIndex = 6;
            addManagerButton.Text = "ADD";
            addManagerButton.UseVisualStyleBackColor = true;
            addManagerButton.Click += addManagerButton_Click;
            // 
            // managersListBox
            // 
            managersListBox.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            managersListBox.ForeColor = Color.FromArgb(0, 0, 64);
            managersListBox.FormattingEnabled = true;
            managersListBox.ItemHeight = 16;
            managersListBox.Location = new Point(487, 156);
            managersListBox.Margin = new Padding(3, 3, 40, 3);
            managersListBox.Name = "managersListBox";
            managersListBox.Size = new Size(264, 180);
            managersListBox.TabIndex = 7;
            // 
            // viewManagersInfoLabel
            // 
            viewManagersInfoLabel.BackColor = Color.Transparent;
            viewManagersInfoLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewManagersInfoLabel.ForeColor = Color.White;
            viewManagersInfoLabel.Location = new Point(487, 85);
            viewManagersInfoLabel.Margin = new Padding(3, 5, 3, 0);
            viewManagersInfoLabel.Name = "viewManagersInfoLabel";
            viewManagersInfoLabel.Size = new Size(264, 57);
            viewManagersInfoLabel.TabIndex = 12;
            viewManagersInfoLabel.Text = "HERE YOU CAN VIEW ALL MANAGERS AND BY SELECTING ONE AND PRESSING  \"MANAGER INFO\"  YOU GET MORE INFO";
            viewManagersInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewManagersHeaderLabel
            // 
            viewManagersHeaderLabel.BackColor = Color.Transparent;
            viewManagersHeaderLabel.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            viewManagersHeaderLabel.ForeColor = Color.White;
            viewManagersHeaderLabel.Location = new Point(487, 44);
            viewManagersHeaderLabel.Margin = new Padding(3, 3, 20, 0);
            viewManagersHeaderLabel.Name = "viewManagersHeaderLabel";
            viewManagersHeaderLabel.Size = new Size(264, 36);
            viewManagersHeaderLabel.TabIndex = 12;
            viewManagersHeaderLabel.Text = "VIEW MANAGERS";
            viewManagersHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addManagersInfoLabel
            // 
            addManagersInfoLabel.BackColor = Color.Transparent;
            addManagersInfoLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addManagersInfoLabel.ForeColor = Color.White;
            addManagersInfoLabel.Location = new Point(47, 85);
            addManagersInfoLabel.Margin = new Padding(3, 5, 3, 0);
            addManagersInfoLabel.Name = "addManagersInfoLabel";
            addManagersInfoLabel.Size = new Size(264, 40);
            addManagersInfoLabel.TabIndex = 12;
            addManagersInfoLabel.Text = "HERE YOU COULD ADD MANAGERS IF YOU THINK ANYONE IS MISSING\r\n";
            addManagersInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addManagersHeaderLabel
            // 
            addManagersHeaderLabel.BackColor = Color.Transparent;
            addManagersHeaderLabel.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            addManagersHeaderLabel.ForeColor = Color.White;
            addManagersHeaderLabel.Location = new Point(49, 44);
            addManagersHeaderLabel.Margin = new Padding(3, 20, 3, 0);
            addManagersHeaderLabel.Name = "addManagersHeaderLabel";
            addManagersHeaderLabel.Size = new Size(264, 36);
            addManagersHeaderLabel.TabIndex = 12;
            addManagersHeaderLabel.Text = "ADD MANAGERS";
            addManagersHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ageNumeric
            // 
            ageNumeric.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ageNumeric.ForeColor = Color.FromArgb(0, 0, 64);
            ageNumeric.Location = new Point(136, 236);
            ageNumeric.Name = "ageNumeric";
            ageNumeric.Size = new Size(175, 23);
            ageNumeric.TabIndex = 2;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(713, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 11;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // nationTextBox
            // 
            nationTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nationTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            nationTextBox.Location = new Point(136, 316);
            nationTextBox.Name = "nationTextBox";
            nationTextBox.PlaceholderText = "Sweden";
            nationTextBox.Size = new Size(175, 23);
            nationTextBox.TabIndex = 4;
            // 
            // clubTextBox
            // 
            clubTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clubTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            clubTextBox.Location = new Point(136, 276);
            clubTextBox.Name = "clubTextBox";
            clubTextBox.PlaceholderText = "Tottenham Hotspurs";
            clubTextBox.Size = new Size(175, 23);
            clubTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            lastNameTextBox.Location = new Point(136, 196);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Dough";
            lastNameTextBox.Size = new Size(175, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            firstNameTextBox.Location = new Point(136, 156);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "John";
            firstNameTextBox.Size = new Size(175, 23);
            firstNameTextBox.TabIndex = 0;
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
            lastNameLabel.TabIndex = 45;
            lastNameLabel.Text = "LAST NAME";
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
            ageLabel.TabIndex = 44;
            ageLabel.Text = "AGE";
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
            clubLabel.TabIndex = 43;
            clubLabel.Text = "CLUB";
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
            nationLabel.TabIndex = 42;
            nationLabel.Text = "NATION";
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
            firstNameLabel.TabIndex = 41;
            firstNameLabel.Text = "FIRST NAME";
            // 
            // ManagersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = Properties.Resources.SpursLogoPng;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(loadPlayersButton);
            Controls.Add(philosophyTextBox);
            Controls.Add(philosophyLabel);
            Controls.Add(removeButton);
            Controls.Add(managerInfoButton);
            Controls.Add(addManagerButton);
            Controls.Add(managersListBox);
            Controls.Add(viewManagersInfoLabel);
            Controls.Add(viewManagersHeaderLabel);
            Controls.Add(addManagersInfoLabel);
            Controls.Add(addManagersHeaderLabel);
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
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 0, 64);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagersForm";
            Text = "ManagersForm";
            ((System.ComponentModel.ISupportInitialize)ageNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadPlayersButton;
        private TextBox philosophyTextBox;
        private Label philosophyLabel;
        private Button removeButton;
        private Button managerInfoButton;
        private Button addManagerButton;
        private ListBox managersListBox;
        private Label viewManagersInfoLabel;
        private Label viewManagersHeaderLabel;
        private Label addManagersInfoLabel;
        private Label addManagersHeaderLabel;
        private NumericUpDown ageNumeric;
        private Button backButton;
        private TextBox nationTextBox;
        private TextBox clubTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label lastNameLabel;
        private Label ageLabel;
        private Label clubLabel;
        private Label nationLabel;
        private Label firstNameLabel;
    }
}