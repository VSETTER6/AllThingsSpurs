namespace AllThingsSpursMain
{
    partial class StartingXlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingXlForm));
            label1 = new Label();
            formationComboBox = new ComboBox();
            backButton = new Button();
            selectFormationLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 49);
            label1.Margin = new Padding(3, 20, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(621, 46);
            label1.TabIndex = 2;
            label1.Text = "CREATE YOUR FAVORITE STARTING ELEVEN";
            // 
            // formationComboBox
            // 
            formationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formationComboBox.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            formationComboBox.ForeColor = Color.FromArgb(0, 0, 64);
            formationComboBox.FormattingEnabled = true;
            formationComboBox.Items.AddRange(new object[] { "4-2-3-1", "4-4-2", "4-3-3", "3-5-2", "3-4-3" });
            formationComboBox.Location = new Point(57, 350);
            formationComboBox.Margin = new Padding(40, 3, 3, 3);
            formationComboBox.Name = "formationComboBox";
            formationComboBox.Size = new Size(136, 27);
            formationComboBox.TabIndex = 0;
            formationComboBox.TabStop = false;
            formationComboBox.Tag = "";
            formationComboBox.SelectedIndexChanged += formationComboBox_SelectedIndexChanged;
            // 
            // backButton
            // 
            backButton.Location = new Point(713, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // selectFormationLabel
            // 
            selectFormationLabel.AutoSize = true;
            selectFormationLabel.BackColor = Color.Transparent;
            selectFormationLabel.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectFormationLabel.ForeColor = Color.White;
            selectFormationLabel.Location = new Point(49, 318);
            selectFormationLabel.Name = "selectFormationLabel";
            selectFormationLabel.Size = new Size(152, 19);
            selectFormationLabel.TabIndex = 2;
            selectFormationLabel.Text = "SELECT YOUR FORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 124);
            label2.Name = "label2";
            label2.Size = new Size(174, 171);
            label2.TabIndex = 2;
            label2.Text = "1. SELECT YOUR FORMATION\r\n\r\n2. CLICK ON THE POSITION \r\n    YOU WANT TO CHANGE\r\n\r\n3. ENTER THE NAME OF THE \r\n    PLAYER YOU WANT TO ADD\r\n\r\n4. PRESS THE  \" OK \" BUTTON";
            // 
            // StartingXlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = Properties.Resources.SpursLogoPng;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(selectFormationLabel);
            Controls.Add(backButton);
            Controls.Add(formationComboBox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartingXlForm";
            Text = "StartingXlForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox formationComboBox;
        private Button backButton;
        private Label selectFormationLabel;
        private Label label2;
    }
}