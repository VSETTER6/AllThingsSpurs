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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            backButton.Select();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.Show();
            Hide();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            ManagersForm managersForm = new ManagersForm();
            managersForm.Show();
            Hide();
        }

        private void clubInfoButton_Click(object sender, EventArgs e)
        {
            StartingXlForm startingXlForm = new StartingXlForm();
            startingXlForm.Show();
            Close();
        }

        private void guessTheScoreButton_Click(object sender, EventArgs e)
        {
            GuessTheScoreForm guessTheScoreForm = new GuessTheScoreForm();
            guessTheScoreForm.Show();
            Close();
        }
    }
}
