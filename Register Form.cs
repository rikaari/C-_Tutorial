using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Voting_System
{
    public partial class Register_Form : Form
    {
        string connString = "server=localhost;port=3306;database=voting_system;user=root;password=''";
        public Register_Form()
        {
            InitializeComponent();
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Close();
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Close();
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Basic validation for the registration form
            string firstName = firstNameBox.Text.Trim();
            string lastName = lastNameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string confirmPassword = confirmPasswordBox.Text.Trim();

            if (firstName == "" || lastName == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string query = "INSERT INTO users (first_name, last_name, password) VALUES (@first_name, @last_name, @password)";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@first_name", firstName);
                        cmd.Parameters.AddWithValue("@last_name", lastName);
                        cmd.Parameters.AddWithValue("@password", HashPassword(password));

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                        {
                            MessageBox.Show("Account Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            new loginForm().Show();
                            this.Close();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while registering the account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void confirmPasswordBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordBox.PasswordChar = '*';
        }
    }
}
