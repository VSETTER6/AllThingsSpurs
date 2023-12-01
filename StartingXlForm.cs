using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllThingsSpursMain
{
    public partial class StartingXlForm : Form
    {
        private List<Label> playerLabels = new List<Label>();
        private PictureBox footballPitchPictureBox;

        public StartingXlForm()
        {
            InitializeComponent();
            backButton.Select();

            formationComboBox.SelectionStart = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void formationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearPlayers();
            ClearPitch();
            UpdateFormation();
        }

        private void UpdateFormation()
        {
            string selectedFormation = formationComboBox.SelectedItem.ToString();

            switch (selectedFormation)
            {
                case "4-2-3-1":
                    Formation4231();
                    break;
                case "4-4-2":
                    Formation442();
                    break;
                case "4-3-3":
                    Formation433();
                    break;
                case "3-5-2":
                    Formation352();
                    break;
                case "3-4-3":
                    Formation343();
                    break;
            }
        }

        private void PlacePlayerPosition(string position, int x, int y)
        {
            Label playerLabel = new Label();
            playerLabel.ForeColor = Color.White;
            playerLabel.BackColor = Color.Green;
            playerLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerLabel.BringToFront();
            playerLabel.Text = position;
            playerLabel.AutoSize = true;
            playerLabel.Location = new Point(x, y);

            playerLabel.Click += (sender, e) => ChangePlayerName(playerLabel);

            playerLabels.Add(playerLabel);
            Controls.Add(playerLabel);
        }

        private void ChangePlayerName(Label label)
        {
            string newPlayerName = Microsoft.VisualBasic.Interaction.InputBox("What player would you like to add?");

            if (!string.IsNullOrWhiteSpace(newPlayerName))
            {
                label.Text = newPlayerName;
            }
        }

        private void ClearPlayers()
        {
            if (playerLabels != null && playerLabels.Count > 0)
            {
                foreach (Label control in playerLabels)
                {
                    Controls.Remove(control);
                }
                playerLabels.Clear();
            }
        }

        private void PlaceFootballPitch()
        {
            PictureBox footballPitchPixtureBox = new PictureBox();
            footballPitchPixtureBox.Image = Image.FromFile("C:\\Users\\vilhe\\Pictures\\Saved Pictures\\FootballPitch.png");
            footballPitchPixtureBox.Size = new Size(507, 293);
            footballPitchPixtureBox.Location = new Point(244, 108);
            footballPitchPixtureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            footballPitchPixtureBox.BringToFront();
            footballPitchPixtureBox.Tag = "FootballPitch";

            Controls.Add(footballPitchPixtureBox);
        }

        private void ClearPitch()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "FootballPitch")
                {
                    Controls.Remove(control);
                    break;
                }
            }
        }

        private void Formation4231()
        {
            PlacePlayerPosition("GK", 270, 245);
            PlacePlayerPosition("RB", 365, 368);
            PlacePlayerPosition("RCB", 343, 301);
            PlacePlayerPosition("LCB", 343, 192);
            PlacePlayerPosition("LB", 365, 120);
            PlacePlayerPosition("RCDM", 447, 301);
            PlacePlayerPosition("LCDM", 447, 192);
            PlacePlayerPosition("RM", 541, 368);
            PlacePlayerPosition("CAM", 541, 245);
            PlacePlayerPosition("LM", 541, 120);
            PlacePlayerPosition("ST", 643, 245);
            PlaceFootballPitch();
        }

        private void Formation442()
        {
            PlacePlayerPosition("GK", 270, 245);
            PlacePlayerPosition("RB", 365, 368);
            PlacePlayerPosition("RCB", 343, 301);
            PlacePlayerPosition("LCB", 343, 192);
            PlacePlayerPosition("LB", 365, 120);
            PlacePlayerPosition("RM", 506, 368);
            PlacePlayerPosition("RCM", 475, 301);
            PlacePlayerPosition("LCM", 475, 192);
            PlacePlayerPosition("LM", 506, 120);
            PlacePlayerPosition("RS", 627, 301);
            PlacePlayerPosition("LS", 627, 192);
            PlaceFootballPitch();
        }

        private void Formation433()
        {
            PlacePlayerPosition("GK", 270, 245);
            PlacePlayerPosition("RB", 365, 368);
            PlacePlayerPosition("RCB", 343, 301);
            PlacePlayerPosition("LCB", 343, 192);
            PlacePlayerPosition("LB", 365, 120);
            PlacePlayerPosition("CDM", 430, 245);
            PlacePlayerPosition("RCM", 500, 301);
            PlacePlayerPosition("LCM", 500, 192);
            PlacePlayerPosition("RW", 587, 368);
            PlacePlayerPosition("LW", 587, 120);
            PlacePlayerPosition("ST", 617, 245);
            PlaceFootballPitch();
        }

        private void Formation352()
        {
            PlacePlayerPosition("GK", 270, 245);
            PlacePlayerPosition("RCB", 343, 316);
            PlacePlayerPosition("CB", 343, 245);
            PlacePlayerPosition("LCB", 343, 174);
            PlacePlayerPosition("CDM", 445, 245);
            PlacePlayerPosition("RM", 484, 368);
            PlacePlayerPosition("RCM", 484, 301);
            PlacePlayerPosition("LCM", 484, 192);
            PlacePlayerPosition("LM", 484, 123);
            PlacePlayerPosition("RS", 615, 292);
            PlacePlayerPosition("LS", 615, 194);
            PlaceFootballPitch();
        }

        private void Formation343()
        {
            PlacePlayerPosition("GK", 270, 245);
            PlacePlayerPosition("RCB", 343, 316);
            PlacePlayerPosition("CB", 343, 245);
            PlacePlayerPosition("LCB", 343, 174);
            PlacePlayerPosition("RM", 505, 368);
            PlacePlayerPosition("RCM", 475, 301);
            PlacePlayerPosition("LCM", 475, 192);
            PlacePlayerPosition("LM", 505, 123);
            PlacePlayerPosition("RW", 581, 316);
            PlacePlayerPosition("LW", 581, 174);
            PlacePlayerPosition("ST", 627, 245);
            PlaceFootballPitch();
        }
    }
}
