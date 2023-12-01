namespace AllThingsSpursMain
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            allThingsSpursLabel = new Label();
            audereEstFacere = new Label();
            signinLabel = new Label();
            createAccountLabel = new Label();
            enterUsernameLabel = new Label();
            enterPasswordLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            createAccountButton = new Button();
            loginButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // allThingsSpursLabel
            // 
            allThingsSpursLabel.BackColor = Color.Transparent;
            allThingsSpursLabel.Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point);
            allThingsSpursLabel.ForeColor = Color.White;
            allThingsSpursLabel.Location = new Point(190, 53);
            allThingsSpursLabel.Name = "allThingsSpursLabel";
            allThingsSpursLabel.Size = new Size(420, 63);
            allThingsSpursLabel.TabIndex = 5;
            allThingsSpursLabel.Text = "ALL THINGS SPURS";
            allThingsSpursLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // audereEstFacere
            // 
            audereEstFacere.BackColor = Color.Transparent;
            audereEstFacere.Font = new Font("Impact", 20F, FontStyle.Italic, GraphicsUnit.Point);
            audereEstFacere.ForeColor = Color.White;
            audereEstFacere.Location = new Point(291, 116);
            audereEstFacere.Name = "audereEstFacere";
            audereEstFacere.Size = new Size(219, 35);
            audereEstFacere.TabIndex = 5;
            audereEstFacere.Text = "AUDERE EST FACERE";
            audereEstFacere.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signinLabel
            // 
            signinLabel.BackColor = Color.Transparent;
            signinLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            signinLabel.ForeColor = Color.White;
            signinLabel.Location = new Point(257, 178);
            signinLabel.Name = "signinLabel";
            signinLabel.Size = new Size(286, 21);
            signinLabel.TabIndex = 5;
            signinLabel.Text = "ENTER YOUR USERNAME AND PASSWORD TO SIGN IN";
            signinLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createAccountLabel
            // 
            createAccountLabel.BackColor = Color.Transparent;
            createAccountLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createAccountLabel.ForeColor = Color.White;
            createAccountLabel.Location = new Point(183, 327);
            createAccountLabel.Name = "createAccountLabel";
            createAccountLabel.Size = new Size(435, 38);
            createAccountLabel.TabIndex = 5;
            createAccountLabel.Text = "DON'T HAVE AN ACCOUNT?\r\nNO PROBLEM! JUST PRESS  \"CREATE ACCOUNT\"  AND FOLLOW THE INSTRUCTIONS\r\n";
            createAccountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.BackColor = Color.Transparent;
            enterUsernameLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            enterUsernameLabel.ForeColor = Color.White;
            enterUsernameLabel.Location = new Point(257, 209);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(71, 21);
            enterUsernameLabel.TabIndex = 5;
            enterUsernameLabel.Text = "USERNAME";
            enterUsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.BackColor = Color.Transparent;
            enterPasswordLabel.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            enterPasswordLabel.ForeColor = Color.White;
            enterPasswordLabel.Location = new Point(257, 245);
            enterPasswordLabel.Name = "enterPasswordLabel";
            enterPasswordLabel.Size = new Size(71, 21);
            enterPasswordLabel.TabIndex = 5;
            enterPasswordLabel.Text = "PASSWORD";
            enterPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            passwordTextBox.Location = new Point(346, 245);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(192, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.AutoCompleteCustomSource.AddRange(new string[] { "123" });
            usernameTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            usernameTextBox.Location = new Point(346, 209);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(192, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            createAccountButton.ForeColor = Color.FromArgb(0, 0, 64);
            createAccountButton.Location = new Point(343, 372);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(114, 23);
            createAccountButton.TabIndex = 3;
            createAccountButton.Text = "CREATE ACCOUNT";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(0, 0, 64);
            loginButton.Location = new Point(373, 276);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(55, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.FromArgb(0, 0, 64);
            exitButton.Location = new Point(713, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = Properties.Resources.SpursLogoPng;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(createAccountButton);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(enterPasswordLabel);
            Controls.Add(enterUsernameLabel);
            Controls.Add(createAccountLabel);
            Controls.Add(signinLabel);
            Controls.Add(audereEstFacere);
            Controls.Add(allThingsSpursLabel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "All Things Spurs Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label allThingsSpursLabel;
        private Label audereEstFacere;
        private Label signinLabel;
        private Label createAccountLabel;
        private Label enterUsernameLabel;
        private Label enterPasswordLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button createAccountButton;
        private Button loginButton;
        private Button exitButton;
    }
}