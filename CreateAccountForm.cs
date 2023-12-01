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
    public partial class CreateAccount : Form
    {
        public LoginForm loginForm { get; set; }

        public CreateAccount(LoginForm loginForm)
        {
            InitializeComponent();
            backButton.Select();
            ActiveControl = createUsernameTextBox;
            this.loginForm = loginForm;
        }

        string usersPath = "users.csv";

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            string newUsername = createUsernameTextBox.Text;
            bool usernameExistsInList = false;
            bool usernameExistsInFile = false;

            using (StreamReader sr = new StreamReader(usersPath))
            {
                while (!sr.EndOfStream) 
                { 
                    string line = sr.ReadLine();
                    string[] parts = line.Split(",");

                    if (parts.Length >= 2 && parts[0] == newUsername)
                    {
                        usernameExistsInFile = true;
                        break;
                    }
                }
            }

            foreach (User user in loginForm.userList)
            {
                if (newUsername == user.Username)
                {
                    usernameExistsInList = true;
                    break;
                }
            }

            if (usernameExistsInList || usernameExistsInFile)
            {
                MessageBox.Show("Username " + newUsername + " is already taken.");
            }
            else
            {   
                using (StreamWriter sw = new StreamWriter(usersPath, true))
                {                   
                    sw.WriteLine(newUsername + "," + createPasswordTextBox.Text);
                }
                
                User newUser = new User(newUsername, createPasswordTextBox.Text);
                loginForm.userList.Add(newUser);
                loginForm.AddUser(newUser);

                MessageBox.Show("User " + newUsername + " was successfully added.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }
    }
}
