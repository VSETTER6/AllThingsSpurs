using Microsoft.VisualBasic;
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
    public partial class PlayersForm : Form
    {
        private List<Players> playersList = new List<Players>();

        public PlayersForm()
        {
            InitializeComponent();
            backButton.Select();

            playersList.Add(new Players("Guglielmo", "Vicario", 27, "Tottenham Hotspur", "Italy", "Goalkeeper"));
            playersList.Add(new Players("Pedro", "Porro", 24, "Tottenham Hotspur", "Spain", "Right back"));
            playersList.Add(new Players("Cristian", "Romero", 25, "Tottenham Hotspur", "Argentina", "Center back"));
            playersList.Add(new Players("Micky", "van de Ven", 22, "Tottenham Hotspur", "Netherlands", "Center back"));
            playersList.Add(new Players("Destiny", "Udogie", 20, "Tottenham Hotspur", "Italy", "Left back"));
            playersList.Add(new Players("Yves", "Bissouma", 27, "Tottenham Hotspur", "Mali", "Central midfield"));
            playersList.Add(new Players("Rodrigo", "Bentancur", 26, "Tottenham Hotspur", "Uruguay", "Central midfield"));
            playersList.Add(new Players("James", "Maddison", 26, "Tottenham Hotspur", "England", "Central midfield"));
            playersList.Add(new Players("Dejan", "Kulusevski", 23, "Tottenham Hotspur", "Sweden", "Right winger"));
            playersList.Add(new Players("Heung-min", "Son", 31, "Tottenham Hotspur", "South Korea", "Center forward"));
            playersList.Add(new Players("Brennan", "Johnson", 22, "Tottenham Hotspur", "Wales", "Left winger"));

            foreach (Players players in playersList)
            {
                playersListBox.Items.Add(players.LastName);
            }
        }

        string playersPath = "players.csv";

        private void backButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(playersPath))
            {
                foreach (Players players in playersList)
                {
                    sw.WriteLine(players.GetPlayerInfoCSV());
                }
            }

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void playerInfoButton_Click(object sender, EventArgs e)
        {
            int indexPlayerInfo = playersListBox.SelectedIndex;
            if (indexPlayerInfo > -1)
            {
                Players players = playersList[indexPlayerInfo];
                MessageBox.Show(players.GetPlayerInfo());
            }
        }

        private void AddPlayer()
        {
            Players newPlayer = new Players(firstNameTextBox.Text, lastNameTextBox.Text, (int)ageNumeric.Value, clubTextBox.Text, nationTextBox.Text, positionTextBox.Text);
            playersList.Add(newPlayer);
            playersListBox.Items.Add(newPlayer.LastName);
            MessageBox.Show("Players was successfully added.");
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayer();
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageNumeric.Value = 0;
            clubTextBox.Text = "";
            nationTextBox.Text = "";
            positionTextBox.Text = "";
        }

        /*private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(playersPath))
            {
                foreach (Players players in playersList)
                {
                    sw.WriteLine(players.GetPlayerInfoCSV());
                }
            }
        }*/

        private void loadPlayersButton_Click(object sender, EventArgs e)
        {
            playersList.Clear();
            playersListBox.Items.Clear();

            FileInfo players = new FileInfo(playersPath);
            if (players.Exists)
            {
                using (StreamReader sr = new StreamReader(playersPath))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] strings = line.Split(",");
                        string firstName = strings[0];
                        string lastName = strings[1];
                        int age = Convert.ToInt32(strings[2]);
                        string club = strings[3];
                        string nation = strings[4];
                        string position = strings[5];

                        Players player = new Players(firstName, lastName, age, club, nation, position);
                        playersList.Add(player);
                        playersListBox.Items.Add(player.LastName);

                        line = sr.ReadLine();
                    }
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int indexPlayerRemove = playersListBox.SelectedIndex;
            if (indexPlayerRemove > -1)
            {
                Players removePlayer = playersList[indexPlayerRemove];
                playersList.RemoveAt(indexPlayerRemove);
                playersListBox.Items.RemoveAt(indexPlayerRemove);
            }
        }
    }
}
