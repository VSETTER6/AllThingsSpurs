using System;
using System.CodeDom.Compiler;
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
    public partial class GuessTheScoreForm : Form
    {
        private List<Label> homeScoreLabels;
        private List<Label> awayScoreLabels;

        public GuessTheScoreForm()
        {
            InitializeComponent();
            backButton.Select();
            homeScoreLabels = new List<Label> { homeLabel1, homeLabel2, homeLabel3, homeLabel4, homeLabel5};
            awayScoreLabels = new List<Label> { awayLabel1, awayLabel2, awayLabel3, awayLabel4, awayLabel5};
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            GuessForm guessForm = new GuessForm(this);
            guessForm.Show();
        }

        public void UpdateHomeScore(List<int> homeResults)
        {
            for (int i = 0; i < homeResults.Count; i++) 
            {
                homeScoreLabels[i].Text = homeResults[i].ToString();
            }
        }

        public void UpdateAwayScore(List<int> awayResults)
        {
            for (int i = 0; i < awayResults.Count; i++)
            {
                awayScoreLabels[i].Text = awayResults[i].ToString();
            }
        }
    }
}
