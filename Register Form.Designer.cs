namespace Voting_System
{
    partial class Register_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitLbl = new Label();
            loginLbl = new Label();
            passwordLbl = new Label();
            passwordBox = new TextBox();
            RegisterBtn = new Button();
            firstNameBox = new TextBox();
            FirstNameLbl = new Label();
            votingSystemTitle = new Label();
            lastNameLbl = new Label();
            lastNameBox = new TextBox();
            confirmPassword = new Label();
            confirmPasswordBox = new TextBox();
            backLbl = new Label();
            SuspendLayout();
            // 
            // exitLbl
            // 
            exitLbl.AutoSize = true;
            exitLbl.BackColor = SystemColors.ActiveCaption;
            exitLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLbl.ForeColor = Color.Red;
            exitLbl.Location = new Point(582, 9);
            exitLbl.Name = "exitLbl";
            exitLbl.Size = new Size(25, 28);
            exitLbl.TabIndex = 17;
            exitLbl.Text = "X";
            exitLbl.Click += exitLbl_Click;
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLbl.Location = new Point(59, 405);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(55, 23);
            loginLbl.TabIndex = 16;
            loginLbl.Text = "Login";
            loginLbl.Click += loginLbl_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.BackColor = SystemColors.ActiveCaption;
            passwordLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            passwordLbl.Location = new Point(59, 231);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(97, 28);
            passwordLbl.TabIndex = 14;
            passwordLbl.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Location = new Point(59, 276);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(385, 20);
            passwordBox.TabIndex = 13;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.YellowGreen;
            RegisterBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterBtn.Location = new Point(214, 399);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(159, 29);
            RegisterBtn.TabIndex = 12;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // firstNameBox
            // 
            firstNameBox.BorderStyle = BorderStyle.None;
            firstNameBox.Location = new Point(59, 111);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(385, 20);
            firstNameBox.TabIndex = 11;
            // 
            // FirstNameLbl
            // 
            FirstNameLbl.AutoSize = true;
            FirstNameLbl.BackColor = SystemColors.ActiveCaption;
            FirstNameLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            FirstNameLbl.Location = new Point(59, 70);
            FirstNameLbl.Name = "FirstNameLbl";
            FirstNameLbl.Size = new Size(104, 28);
            FirstNameLbl.TabIndex = 10;
            FirstNameLbl.Text = "FirstName";
            // 
            // votingSystemTitle
            // 
            votingSystemTitle.AutoSize = true;
            votingSystemTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            votingSystemTitle.Location = new Point(183, 24);
            votingSystemTitle.Name = "votingSystemTitle";
            votingSystemTitle.Size = new Size(261, 31);
            votingSystemTitle.TabIndex = 9;
            votingSystemTitle.Text = "Voting System Register";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.BackColor = SystemColors.ActiveCaption;
            lastNameLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lastNameLbl.Location = new Point(59, 148);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(108, 28);
            lastNameLbl.TabIndex = 19;
            lastNameLbl.Text = "Last Name";
            // 
            // lastNameBox
            // 
            lastNameBox.BorderStyle = BorderStyle.None;
            lastNameBox.Location = new Point(59, 193);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(385, 20);
            lastNameBox.TabIndex = 18;
            // 
            // confirmPassword
            // 
            confirmPassword.AutoSize = true;
            confirmPassword.BackColor = SystemColors.ActiveCaption;
            confirmPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            confirmPassword.Location = new Point(59, 301);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(176, 28);
            confirmPassword.TabIndex = 21;
            confirmPassword.Text = "Confirm Password";
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.BorderStyle = BorderStyle.None;
            confirmPasswordBox.Location = new Point(59, 346);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.Size = new Size(385, 20);
            confirmPasswordBox.TabIndex = 20;
            confirmPasswordBox.TextChanged += confirmPasswordBox_TextChanged;
            // 
            // backLbl
            // 
            backLbl.AutoSize = true;
            backLbl.BackColor = SystemColors.ActiveCaption;
            backLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backLbl.ForeColor = Color.Red;
            backLbl.Location = new Point(523, 396);
            backLbl.Name = "backLbl";
            backLbl.Size = new Size(26, 28);
            backLbl.TabIndex = 22;
            backLbl.Text = "<";
            backLbl.Click += backLbl_Click;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(619, 450);
            Controls.Add(backLbl);
            Controls.Add(confirmPassword);
            Controls.Add(confirmPasswordBox);
            Controls.Add(lastNameLbl);
            Controls.Add(lastNameBox);
            Controls.Add(exitLbl);
            Controls.Add(loginLbl);
            Controls.Add(passwordLbl);
            Controls.Add(passwordBox);
            Controls.Add(RegisterBtn);
            Controls.Add(firstNameBox);
            Controls.Add(FirstNameLbl);
            Controls.Add(votingSystemTitle);
            Name = "Register_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitLbl;
        private Label loginLbl;
        private Label passwordLbl;
        private TextBox passwordBox;
        private Button RegisterBtn;
        private TextBox firstNameBox;
        private Label FirstNameLbl;
        private Label votingSystemTitle;
        private Label lastNameLbl;
        private TextBox lastNameBox;
        private Label confirmPassword;
        private TextBox confirmPasswordBox;
        private Label backLbl;
    }
}