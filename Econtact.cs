using MySql.Data.MySqlClient;

namespace Econtact
{
    public partial class Econtact : Form
    {
        string connString = "server=localhost;port=3306;database=contactDetails;user=root;password=''";
        string imagePath = "";  // Store the image path
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");

        public Econtact()
        {
            InitializeComponent();

            // Create Images folder if it doesn't exist
            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }
        }

        private void closeLogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text.Trim();
            string lastName = lastNameBox.Text.Trim();
            string contactNumber = contactNumberBox.Text.Trim();
            string address = addressBox.Text.Trim();
            string gender = genderBox.Text.Trim();
            string picture = string.IsNullOrEmpty(imagePath) ? "" : Path.GetFileName(imagePath);  // Just the filename

            if (firstName == "" || lastName == "" || contactNumber == "" || address == "" || gender == "" || picture == "")
            {
                MessageBox.Show("Please fill in all fields.");
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
                        string query = "INSERT INTO contactDetails(firstName,lastName,contactNumber,address,gender,picture) VALUES (@first_name,@last_name,@contact_number,@address,@gender,@picture) ";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@first_name", firstName); // Add the first name as a parameter
                        cmd.Parameters.AddWithValue("@last_name", lastName); // Add the last name as a parameter
                        cmd.Parameters.AddWithValue("@contact_number", contactNumber); // Add the contact number as a parameter
                        cmd.Parameters.AddWithValue("@address", address); // Add the address as a parameter
                        cmd.Parameters.AddWithValue("@gender", gender); // Add the gender as a parameter
                        cmd.Parameters.AddWithValue("@picture", picture); // Add the picture data as a parameter

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Contact Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();

                            // Clear form fields for new entry
                            contactIDBox.Clear();
                            firstNameBox.Clear();
                            lastNameBox.Clear();
                            contactNumberBox.Clear();
                            addressBox.Clear();
                            genderBox.SelectedIndex = -1;
                            userPictureBox.Image = null;
                            imagePath = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to register contact. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while registering the contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void uploadPictureBtn_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select a Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFileDialog.FileName;
                    string extension = Path.GetExtension(sourceFile);

                    // Create unique filename using timestamp
                    string newFileName = $"contact_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                    string destinationPath = Path.Combine(imagesFolder, newFileName);

                    // Copy image to Images folder
                    File.Copy(sourceFile, destinationPath, true);

                    // Store the path and display image
                    imagePath = destinationPath;
                    userPictureBox.Image = Image.FromFile(destinationPath);
                    userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear form fields for new entry
            contactIDBox.Clear();
            firstNameBox.Clear();
            lastNameBox.Clear();
            contactNumberBox.Clear();
            addressBox.Clear();
            genderBox.SelectedIndex = -1;
            userPictureBox.Image = null;
            imagePath = "";
        }
    }
}
