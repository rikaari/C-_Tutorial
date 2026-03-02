namespace Econtact
{
    partial class Econtact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            pictureBox1 = new PictureBox();
            lastNameBox = new TextBox();
            lastName = new Label();
            firstNameBox = new TextBox();
            firstName = new Label();
            contactNumberBox = new TextBox();
            contactNumber = new Label();
            addressBox = new TextBox();
            address = new Label();
            gender = new Label();
            genderBox = new ComboBox();
            addBtn = new Button();
            updateBtn = new Button();
            clearBtn = new Button();
            deleteBtn = new Button();
            search = new Label();
            searchBox = new TextBox();
            closeLogo = new PictureBox();
            imageLbl = new Label();
            userPictureBox = new PictureBox();
            contactIDBox = new TextBox();
            contactIDLbl = new Label();
            searchBtn = new Button();
            uploadPictureBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lastNameBox
            // 
            lastNameBox.BorderStyle = BorderStyle.None;
            lastNameBox.Location = new Point(151, 204);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(137, 20);
            lastNameBox.TabIndex = 4;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastName.Location = new Point(31, 202);
            lastName.Name = "lastName";
            lastName.RightToLeft = RightToLeft.Yes;
            lastName.Size = new Size(94, 23);
            lastName.TabIndex = 3;
            lastName.Text = "Last Name";
            // 
            // firstNameBox
            // 
            firstNameBox.BorderStyle = BorderStyle.None;
            firstNameBox.Location = new Point(151, 163);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(137, 20);
            firstNameBox.TabIndex = 6;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstName.Location = new Point(31, 160);
            firstName.Name = "firstName";
            firstName.RightToLeft = RightToLeft.Yes;
            firstName.Size = new Size(97, 23);
            firstName.TabIndex = 5;
            firstName.Text = "First Name";
            // 
            // contactNumberBox
            // 
            contactNumberBox.BorderStyle = BorderStyle.None;
            contactNumberBox.Location = new Point(151, 250);
            contactNumberBox.Name = "contactNumberBox";
            contactNumberBox.Size = new Size(137, 20);
            contactNumberBox.TabIndex = 8;
            // 
            // contactNumber
            // 
            contactNumber.AutoSize = true;
            contactNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNumber.Location = new Point(31, 247);
            contactNumber.Name = "contactNumber";
            contactNumber.RightToLeft = RightToLeft.Yes;
            contactNumber.Size = new Size(100, 23);
            contactNumber.TabIndex = 7;
            contactNumber.Text = "Contact No";
            // 
            // addressBox
            // 
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.Location = new Point(151, 293);
            addressBox.Multiline = true;
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(137, 53);
            addressBox.TabIndex = 10;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.Location = new Point(31, 290);
            address.Name = "address";
            address.RightToLeft = RightToLeft.Yes;
            address.Size = new Size(74, 23);
            address.TabIndex = 9;
            address.Text = "Address";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.Location = new Point(31, 401);
            gender.Name = "gender";
            gender.RightToLeft = RightToLeft.Yes;
            gender.Size = new Size(68, 23);
            gender.TabIndex = 11;
            gender.Text = "Gender";
            // 
            // genderBox
            // 
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(153, 396);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(135, 28);
            genderBox.TabIndex = 12;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.ForestGreen;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addBtn.ForeColor = SystemColors.ControlLightLight;
            addBtn.Location = new Point(101, 444);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(119, 36);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = SystemColors.Highlight;
            updateBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(221, 444);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(119, 36);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Gold;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(461, 444);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(119, 36);
            clearBtn.TabIndex = 16;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.Transparent;
            deleteBtn.Location = new Point(341, 444);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(119, 36);
            deleteBtn.TabIndex = 15;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.Location = new Point(422, 365);
            search.Name = "search";
            search.RightToLeft = RightToLeft.Yes;
            search.Size = new Size(134, 23);
            search.TabIndex = 18;
            search.Text = "Search For User";
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Location = new Point(379, 404);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(142, 20);
            searchBox.TabIndex = 19;
            // 
            // closeLogo
            // 
            closeLogo.BackColor = Color.Transparent;
            closeLogo.Image = (Image)resources.GetObject("closeLogo.Image");
            closeLogo.Location = new Point(613, 12);
            closeLogo.Name = "closeLogo";
            closeLogo.Size = new Size(33, 33);
            closeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            closeLogo.TabIndex = 20;
            closeLogo.TabStop = false;
            closeLogo.Click += closeLogo_Click;
            // 
            // imageLbl
            // 
            imageLbl.AutoSize = true;
            imageLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            imageLbl.Location = new Point(461, 114);
            imageLbl.Name = "imageLbl";
            imageLbl.RightToLeft = RightToLeft.Yes;
            imageLbl.Size = new Size(60, 23);
            imageLbl.TabIndex = 21;
            imageLbl.Text = "Image";
            // 
            // userPictureBox
            // 
            userPictureBox.BorderStyle = BorderStyle.FixedSingle;
            userPictureBox.Location = new Point(379, 153);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(215, 160);
            userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userPictureBox.TabIndex = 22;
            userPictureBox.TabStop = false;
            // 
            // contactIDBox
            // 
            contactIDBox.BorderStyle = BorderStyle.None;
            contactIDBox.Location = new Point(154, 117);
            contactIDBox.Name = "contactIDBox";
            contactIDBox.Size = new Size(137, 20);
            contactIDBox.TabIndex = 24;
            // 
            // contactIDLbl
            // 
            contactIDLbl.AutoSize = true;
            contactIDLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactIDLbl.Location = new Point(34, 114);
            contactIDLbl.Name = "contactIDLbl";
            contactIDLbl.RightToLeft = RightToLeft.Yes;
            contactIDLbl.Size = new Size(95, 23);
            contactIDLbl.TabIndex = 23;
            contactIDLbl.Text = "Contact ID";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Black;
            searchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = SystemColors.ButtonFace;
            searchBtn.Location = new Point(540, 401);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 25;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // uploadPictureBtn
            // 
            uploadPictureBtn.BackColor = Color.Black;
            uploadPictureBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadPictureBtn.ForeColor = SystemColors.ButtonFace;
            uploadPictureBtn.Location = new Point(413, 319);
            uploadPictureBtn.Name = "uploadPictureBtn";
            uploadPictureBtn.Size = new Size(153, 29);
            uploadPictureBtn.TabIndex = 26;
            uploadPictureBtn.Text = "Upload Picture";
            uploadPictureBtn.UseVisualStyleBackColor = false;
            uploadPictureBtn.Click += uploadPictureBtn_Click_1;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 492);
            Controls.Add(uploadPictureBtn);
            Controls.Add(searchBtn);
            Controls.Add(contactIDBox);
            Controls.Add(contactIDLbl);
            Controls.Add(userPictureBox);
            Controls.Add(imageLbl);
            Controls.Add(closeLogo);
            Controls.Add(searchBox);
            Controls.Add(search);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(genderBox);
            Controls.Add(gender);
            Controls.Add(addressBox);
            Controls.Add(address);
            Controls.Add(contactNumberBox);
            Controls.Add(contactNumber);
            Controls.Add(firstNameBox);
            Controls.Add(firstName);
            Controls.Add(lastNameBox);
            Controls.Add(lastName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Econtact";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox lastNameBox;
        private Label lastName;
        private TextBox firstNameBox;
        private Label firstName;
        private TextBox contactNumberBox;
        private Label contactNumber;
        private TextBox addressBox;
        private Label address;
        private Label gender;
        private ComboBox genderBox;
        private Button addBtn;
        private Button updateBtn;
        private Button clearBtn;
        private Button deleteBtn;
        private Label search;
        private TextBox searchBox;
        private PictureBox closeLogo;
        private Label imageLbl;
        private PictureBox userPictureBox;
        private TextBox contactIDBox;
        private Label contactIDLbl;
        private Button searchBtn;
        private Button uploadPictureBtn;
    }
}
