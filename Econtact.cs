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

            // Make Contact ID box readonly with placeholder
            contactIDBox.ReadOnly = true;
            contactIDBox.PlaceholderText = "Read-only (Auto-populated from search)";

            // Set focus to first name box on startup
            firstNameBox.Focus();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string contactID = contactIDBox.Text.Trim();
            string firstName = firstNameBox.Text.Trim();
            string lastName = lastNameBox.Text.Trim();
            string contactNumber = contactNumberBox.Text.Trim();
            string address = addressBox.Text.Trim();
            string gender = genderBox.Text.Trim();
            string picture = string.IsNullOrEmpty(imagePath) ? "" : Path.GetFileName(imagePath);

            // Check if contactID exists (must be populated from search first)
            if (string.IsNullOrEmpty(contactID))
            {
                MessageBox.Show("Please search for a contact first before updating.", "No Contact Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate all fields are filled
            if (firstName == "" || lastName == "" || contactNumber == "" || address == "" || gender == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                using (conn)
                {
                    conn.Open();

                    // Build UPDATE query - update all fields except contactID
                    string query;
                    if (!string.IsNullOrEmpty(picture))
                    {
                        // Update including picture
                        query = "UPDATE contactDetails SET firstName=@first_name, lastName=@last_name, contactNumber=@contact_number, address=@address, gender=@gender, picture=@picture WHERE contactID=@contact_id";
                    }
                    else
                    {
                        // Update without changing picture
                        query = "UPDATE contactDetails SET firstName=@first_name, lastName=@last_name, contactNumber=@contact_number, address=@address, gender=@gender WHERE contactID=@contact_id";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@contact_id", contactID);
                    cmd.Parameters.AddWithValue("@first_name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@contact_number", contactNumber);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    if (!string.IsNullOrEmpty(picture))
                    {
                        cmd.Parameters.AddWithValue("@picture", picture);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Contact Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();

                        // Clear form fields after update
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
                        MessageBox.Show("Failed to update contact. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a first name or last name to search.", "Search Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                using (conn)
                {
                    conn.Open();

                    // Search by first name or last name
                    string query = "SELECT contactID, firstName, lastName, contactNumber, address, gender, picture FROM contactDetails WHERE firstName LIKE @search_term OR lastName LIKE @search_term LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search_term", "%" + searchTerm + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate all form fields with found contact
                        contactIDBox.Text = reader["contactID"].ToString();
                        firstNameBox.Text = reader["firstName"].ToString();
                        lastNameBox.Text = reader["lastName"].ToString();
                        contactNumberBox.Text = reader["contactNumber"].ToString();
                        addressBox.Text = reader["address"].ToString();
                        genderBox.Text = reader["gender"].ToString();

                        // Load and display picture if exists
                        string pictureFileName = reader["picture"].ToString();
                        if (!string.IsNullOrEmpty(pictureFileName))
                        {
                            string picturePath = Path.Combine(imagesFolder, pictureFileName);
                            if (File.Exists(picturePath))
                            {
                                userPictureBox.Image = Image.FromFile(picturePath);
                                userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                imagePath = picturePath;
                            }
                        }
                        else
                        {
                            userPictureBox.Image = null;
                            imagePath = "";
                        }

                        MessageBox.Show($"Contact found: {reader["firstName"]} {reader["lastName"]}", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No contact found with name: {searchTerm}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string contactID = contactIDBox.Text.Trim();
            string firstName = firstNameBox.Text.Trim();
            string lastName = lastNameBox.Text.Trim();

            // Check if contactID exists (must be populated from search first)
            if (string.IsNullOrEmpty(contactID))
            {
                MessageBox.Show("Please search for a contact first before deleting.", "No Contact Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion with user
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the contact: {firstName} {lastName}?\n\nThis action cannot be undone.", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                using (conn)
                {
                    conn.Open();

                    // Delete contact by contactID
                    string query = "DELETE FROM contactDetails WHERE contactID=@contact_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@contact_id", contactID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Contact Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();

                        // Clear form fields after deletion
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
                        MessageBox.Show("Failed to delete contact. Please try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
