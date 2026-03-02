namespace Voting_System
{
    partial class loginForm
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
            votingSystemTitle = new Label();
            usernameLbl = new Label();
            usernameBox = new TextBox();
            loginBtn = new Button();
            passwordBox = new TextBox();
            passwordLbl = new Label();
            showPasswordCheck = new CheckBox();
            registerLbl = new Label();
            exitLbl = new Label();
            SuspendLayout();
            // 
            // votingSystemTitle
            // 
            votingSystemTitle.AutoSize = true;
            votingSystemTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            votingSystemTitle.Location = new Point(162, 45);
            votingSystemTitle.Name = "votingSystemTitle";
            votingSystemTitle.Size = new Size(235, 31);
            votingSystemTitle.TabIndex = 0;
            votingSystemTitle.Text = "Voting System Login";
            votingSystemTitle.Click += votingSystemTitle_Click;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.BackColor = SystemColors.ActiveCaption;
            usernameLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usernameLbl.Location = new Point(51, 94);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(104, 28);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Location = new Point(54, 141);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(385, 20);
            usernameBox.TabIndex = 2;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.YellowGreen;
            loginBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(181, 342);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(159, 29);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Location = new Point(54, 249);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(385, 20);
            passwordBox.TabIndex = 4;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.BackColor = SystemColors.ActiveCaption;
            passwordLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            passwordLbl.Location = new Point(54, 200);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(97, 28);
            passwordLbl.TabIndex = 5;
            passwordLbl.Text = "Password";
            // 
            // showPasswordCheck
            // 
            showPasswordCheck.AutoSize = true;
            showPasswordCheck.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPasswordCheck.Location = new Point(338, 300);
            showPasswordCheck.Name = "showPasswordCheck";
            showPasswordCheck.Size = new Size(136, 24);
            showPasswordCheck.TabIndex = 6;
            showPasswordCheck.Text = "Show Password";
            showPasswordCheck.UseVisualStyleBackColor = true;
            showPasswordCheck.CheckedChanged += showPasswordCheck_CheckedChanged_1;
            // 
            // registerLbl
            // 
            registerLbl.AutoSize = true;
            registerLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLbl.Location = new Point(51, 391);
            registerLbl.Name = "registerLbl";
            registerLbl.Size = new Size(132, 23);
            registerLbl.TabIndex = 7;
            registerLbl.Text = "Create Account";
            registerLbl.Click += registerLbl_Click;
            // 
            // exitLbl
            // 
            exitLbl.AutoSize = true;
            exitLbl.BackColor = SystemColors.ActiveCaption;
            exitLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLbl.ForeColor = Color.Red;
            exitLbl.Location = new Point(526, 9);
            exitLbl.Name = "exitLbl";
            exitLbl.Size = new Size(25, 28);
            exitLbl.TabIndex = 8;
            exitLbl.Text = "X";
            exitLbl.Click += exitLbl_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(563, 450);
            ControlBox = false;
            Controls.Add(exitLbl);
            Controls.Add(registerLbl);
            Controls.Add(showPasswordCheck);
            Controls.Add(passwordLbl);
            Controls.Add(passwordBox);
            Controls.Add(loginBtn);
            Controls.Add(usernameBox);
            Controls.Add(usernameLbl);
            Controls.Add(votingSystemTitle);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voting System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label votingSystemTitle;
        private Label usernameLbl;
        private TextBox usernameBox;
        private Button loginBtn;
        private TextBox passwordBox;
        private Label passwordLbl;
        private CheckBox showPasswordCheck;
        private Label registerLbl;
        private Label exitLbl;
    }
}
