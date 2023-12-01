namespace AllThingsSpursMain
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            createAccountLabel = new Label();
            createUsernameTextBox = new TextBox();
            createPasswordTextBox = new TextBox();
            enterPasswordLabel = new Label();
            enterUsernameLabel = new Label();
            createNewAccountButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // createAccountLabel
            // 
            createAccountLabel.BackColor = Color.Transparent;
            createAccountLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createAccountLabel.ForeColor = Color.White;
            createAccountLabel.Location = new Point(138, 121);
            createAccountLabel.Name = "createAccountLabel";
            createAccountLabel.Size = new Size(316, 57);
            createAccountLabel.TabIndex = 4;
            createAccountLabel.Text = "CHOOSE A USERNAME AND A PASSWORD\r\nPRESS  \"CREATE ACCOUNT\"  WHEN YOU ARE DONE";
            createAccountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createUsernameTextBox
            // 
            createUsernameTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createUsernameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            createUsernameTextBox.Location = new Point(245, 197);
            createUsernameTextBox.Name = "createUsernameTextBox";
            createUsernameTextBox.PlaceholderText = "Yiddo";
            createUsernameTextBox.Size = new Size(192, 23);
            createUsernameTextBox.TabIndex = 0;
            // 
            // createPasswordTextBox
            // 
            createPasswordTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createPasswordTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            createPasswordTextBox.Location = new Point(245, 233);
            createPasswordTextBox.Name = "createPasswordTextBox";
            createPasswordTextBox.PlaceholderText = "1882";
            createPasswordTextBox.Size = new Size(192, 23);
            createPasswordTextBox.TabIndex = 1;
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            enterPasswordLabel.ForeColor = Color.White;
            enterPasswordLabel.Location = new Point(156, 233);
            enterPasswordLabel.Name = "enterPasswordLabel";
            enterPasswordLabel.Size = new Size(71, 21);
            enterPasswordLabel.TabIndex = 9;
            enterPasswordLabel.Text = "PASSWORD";
            enterPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            enterUsernameLabel.ForeColor = Color.White;
            enterUsernameLabel.Location = new Point(156, 197);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(71, 21);
            enterUsernameLabel.TabIndex = 8;
            enterUsernameLabel.Text = "USERNAME";
            enterUsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createNewAccountButton
            // 
            createNewAccountButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            createNewAccountButton.ForeColor = Color.FromArgb(0, 0, 64);
            createNewAccountButton.Location = new Point(239, 284);
            createNewAccountButton.Name = "createNewAccountButton";
            createNewAccountButton.Size = new Size(114, 23);
            createNewAccountButton.TabIndex = 2;
            createNewAccountButton.Text = "CREATE ACCOUNT";
            createNewAccountButton.UseVisualStyleBackColor = true;
            createNewAccountButton.Click += createNewAccountButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor = Color.FromArgb(0, 0, 64);
            backButton.Location = new Point(505, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 3;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = Properties.Resources.SpursLogoPng;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(592, 450);
            Controls.Add(createAccountLabel);
            Controls.Add(backButton);
            Controls.Add(createNewAccountButton);
            Controls.Add(createUsernameTextBox);
            Controls.Add(createPasswordTextBox);
            Controls.Add(enterPasswordLabel);
            Controls.Add(enterUsernameLabel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateAccount";
            Text = "All Things Spurs Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createAccountLabel;
        private TextBox createUsernameTextBox;
        private TextBox createPasswordTextBox;
        private Label enterPasswordLabel;
        private Label enterUsernameLabel;
        private Button createNewAccountButton;
        private Button backButton;
    }
}