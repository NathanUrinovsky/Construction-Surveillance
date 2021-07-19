namespace EngineerClientUI
{
    partial class RegisterForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.supervisorNameLabel = new System.Windows.Forms.Label();
            this.supervisorsList = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.successInRegistrationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backToLoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.passwordTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameLabel.Location = new System.Drawing.Point(292, 66);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 18);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordLabel.Location = new System.Drawing.Point(290, 12);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 18);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel.Location = new System.Drawing.Point(295, 246);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 18);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // supervisorNameLabel
            // 
            this.supervisorNameLabel.AutoSize = true;
            this.supervisorNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supervisorNameLabel.Location = new System.Drawing.Point(295, 304);
            this.supervisorNameLabel.Name = "supervisorNameLabel";
            this.supervisorNameLabel.Size = new System.Drawing.Size(130, 18);
            this.supervisorNameLabel.TabIndex = 4;
            this.supervisorNameLabel.Text = "Supervisor name:";
            // 
            // supervisorsList
            // 
            this.supervisorsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supervisorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supervisorsList.FormattingEnabled = true;
            this.supervisorsList.Location = new System.Drawing.Point(295, 330);
            this.supervisorsList.Name = "supervisorsList";
            this.supervisorsList.Size = new System.Drawing.Size(143, 24);
            this.supervisorsList.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameTextBox.Location = new System.Drawing.Point(293, 93);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(145, 22);
            this.usernameTextBox.TabIndex = 7;
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.empNameTextBox.Location = new System.Drawing.Point(293, 273);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(143, 22);
            this.empNameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordTextBox.Location = new System.Drawing.Point(293, 153);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(145, 22);
            this.passwordTextBox.TabIndex = 9;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.registerButton.Location = new System.Drawing.Point(293, 372);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(145, 37);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            this.registerButton.MouseLeave += new System.EventHandler(this.RegisterButton_MouseLeave);
            this.registerButton.MouseHover += new System.EventHandler(this.RegisterButton_MouseHover);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailLabel.Location = new System.Drawing.Point(292, 188);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 18);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailTextBox.Location = new System.Drawing.Point(293, 216);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(145, 22);
            this.emailTextBox.TabIndex = 13;
            // 
            // successInRegistrationLabel
            // 
            this.successInRegistrationLabel.AutoSize = true;
            this.successInRegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.successInRegistrationLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.successInRegistrationLabel.Location = new System.Drawing.Point(305, 456);
            this.successInRegistrationLabel.Name = "successInRegistrationLabel";
            this.successInRegistrationLabel.Size = new System.Drawing.Size(104, 20);
            this.successInRegistrationLabel.TabIndex = 14;
            this.successInRegistrationLabel.Text = "success label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 51);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create Account";
            // 
            // backToLoginLinkLabel
            // 
            this.backToLoginLinkLabel.AutoSize = true;
            this.backToLoginLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backToLoginLinkLabel.Location = new System.Drawing.Point(222, 421);
            this.backToLoginLinkLabel.Name = "backToLoginLinkLabel";
            this.backToLoginLinkLabel.Size = new System.Drawing.Size(345, 20);
            this.backToLoginLinkLabel.TabIndex = 16;
            this.backToLoginLinkLabel.TabStop = true;
            this.backToLoginLinkLabel.Text = "I actually have an accout! Take me back to login";
            this.backToLoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToLoginLinkLabel_LinkClicked);
            // 
            // passwordTitle
            // 
            this.passwordTitle.AutoSize = true;
            this.passwordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordTitle.Location = new System.Drawing.Point(291, 130);
            this.passwordTitle.Name = "passwordTitle";
            this.passwordTitle.Size = new System.Drawing.Size(82, 20);
            this.passwordTitle.TabIndex = 17;
            this.passwordTitle.Text = "Password:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(862, 485);
            this.Controls.Add(this.passwordTitle);
            this.Controls.Add(this.backToLoginLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.successInRegistrationLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.supervisorsList);
            this.Controls.Add(this.supervisorNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label supervisorNameLabel;
        private System.Windows.Forms.ComboBox supervisorsList;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label successInRegistrationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel backToLoginLinkLabel;
        private System.Windows.Forms.Label passwordTitle;
    }
}