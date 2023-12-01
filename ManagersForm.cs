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
    public partial class ManagersForm : Form
    {
        List<Managers> managersList = new List<Managers>();

        public ManagersForm()
        {
            InitializeComponent();
            backButton.Select();

            managersList.Add(new Managers("Ange", "Postecoglou", 58, "Tottenham Hotspur", "Australia", "Attacking, Possesion"));
            managersList.Add(new Managers("Jan Robert", "Vilahamn", 40, "Tottenham Hotspur", "Sweden", "Attacking"));
            managersList.Add(new Managers("Harry", "Redknapp", 76, "None", "England", "Good with people"));
            managersList.Add(new Managers("Mauricio", "Pochettino", 51, "Chelsea", "Argentina", "Attacking, High press"));
            managersList.Add(new Managers("José", "Mourinho", 60, "Roma", "Portugal", "Defensive"));

            foreach (Managers manager in managersList)
            {
                managersListBox.Items.Add(manager.LastName);
            }
        }

        string managersPath = "managers.csv";

        private void backButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(managersPath))
            {
                foreach (Managers managers in managersList)
                {
                    sw.WriteLine(managers.GetManagersInfoCSV());
                }
            }

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void managerInfoButton_Click(object sender, EventArgs e)
        {
            int mangersInfoIndex = managersListBox.SelectedIndex;
            if (mangersInfoIndex > -1)
            {
                Managers managers = managersList[mangersInfoIndex];
                MessageBox.Show(managers.GetManagersInfo());
            }
        }

        public void AddManager()
        {
            Managers newManager = new Managers(firstNameTextBox.Text, lastNameTextBox.Text, (int)ageNumeric.Value, clubTextBox.Text, nationTextBox.Text, philosophyTextBox.Text);
            managersList.Add(newManager);
            managersListBox.Items.Add(newManager.LastName);
            MessageBox.Show("Manager was successfully added.");
        }

        private void addManagerButton_Click(object sender, EventArgs e)
        {
            AddManager();
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageNumeric.Value = 0;
            clubTextBox.Text = "";
            nationTextBox.Text = "";
            philosophyTextBox.Text = "";
        }



        /*private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(managersPath))
            {
                foreach (Managers managers in managersList)
                {
                    sw.WriteLine(managers.GetManagersInfoCSV());
                }
            }
        }*/

        private void loadPlayersButton_Click(object sender, EventArgs e)
        {
            managersList.Clear();
            managersListBox.Items.Clear();

            FileInfo managers = new FileInfo(managersPath);
            if (managers.Exists)
            {
                using (StreamReader sr = new StreamReader(managersPath))
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
                        string philosophy = strings[5];

                        Managers newManagers = new Managers(firstName, lastName, age, club, nation, philosophy);
                        managersList.Add(newManagers);
                        managersListBox.Items.Add(newManagers.LastName);

                        line = sr.ReadLine();
                    }
                }

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int indexManagerRemove = managersListBox.SelectedIndex;
            if (indexManagerRemove > -1)
            {
                Managers managersRemove = managersList[indexManagerRemove];
                managersList.RemoveAt(indexManagerRemove);
                managersListBox.Items.RemoveAt(indexManagerRemove);
            }
        }

        private void philosophyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
