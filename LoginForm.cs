namespace AllThingsSpursMain
{
    public partial class LoginForm : Form
    {
        public List<User> userList = new List<User>();

        public LoginForm()
        {
            InitializeComponent();
            exitButton.Select();

            LoadUsersCSV();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool loginSucessful = false;

            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            foreach (User user in userList)
            {
                if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                {
                    continue;
                }

                if (enteredUsername == user.Username && enteredPassword == user.Password)
                {
                    loginSucessful = true;
                    break;
                }
            }
            if (loginSucessful)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount(this);
            createAccount.Show();
            Hide();
        }

        public void AddUser(User newUser)
        {
            userList.Add(newUser);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string usersPath = "users.csv";

        private void LoadUsersCSV()
        {
            try
            {
                using (StreamReader sr = new StreamReader(usersPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split(",");

                        if (parts.Length >= 2)
                        {
                            string username = parts[0];
                            string password = parts[1];

                            User newUser = new User(username, password);
                            userList.Add(newUser);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}