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
    public partial class GuessForm : Form
    {
        GuessTheScoreForm guessTheScoreForm;

        public GuessForm(GuessTheScoreForm guessTheScoreForm)
        {
            InitializeComponent();
            exitButton.Select();
            this.guessTheScoreForm = guessTheScoreForm;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<int> homeScorePrediction = new List<int>();
            List<int> awayScorePrediction = new List<int>();

            try
            {
                homeScorePrediction = new List<int>
                {
                    int.Parse(homeScoreTextBox1.Text),
                    int.Parse(homeScoreTextBox2.Text),
                    int.Parse(homeScoreTextBox3.Text),
                    int.Parse(homeScoreTextBox4.Text),
                    int.Parse(homeScoreTextBox5.Text)
                };

                awayScorePrediction = new List<int>
                {
                    int.Parse(awayScoreTextBox1.Text),
                    int.Parse(awayScoreTextBox2.Text),
                    int.Parse(awayScoreTextBox3.Text),
                    int.Parse(awayScoreTextBox4.Text),
                    int.Parse(awayScoreTextBox5.Text)
                };

                guessTheScoreForm.UpdateHomeScore(homeScorePrediction);
                guessTheScoreForm.UpdateAwayScore(awayScorePrediction);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fyll i alla resultat innan du klickar på submit." + "\n" + "\n" + "Error" + e);
            }
        }
    }
}
