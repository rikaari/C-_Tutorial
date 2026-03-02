using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Voting_System
{
    public partial class loginForm : Form
    {
        string connString = "server=localhost;port=3306;database=voting_system;user=root;password=''";
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            if (userName == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    using (conn)
                    {
                        conn.Open();
                        string query = "SELECT * FROM users WHERE first_name = @username AND password = @password";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@password", HashPassword(password));
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Successful login
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new loginForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            // Invalid credentials
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void votingSystemTitle_Click(object sender, EventArgs e)
        {

        }

        private void registerLbl_Click(object sender, EventArgs e)
        {
            new Register_Form().Show();
            this.Hide();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }



        private void showPasswordCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPasswordCheck.Checked)
            {
                passwordBox.PasswordChar = '\0'; // Show password
            }
            else
            {
                passwordBox.PasswordChar = '*'; // Hide password
            }
        }
    }
}
