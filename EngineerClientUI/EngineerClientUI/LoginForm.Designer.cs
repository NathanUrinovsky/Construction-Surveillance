namespace EngineerClientUI
{
    partial class LoginForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.theLoginButton = new System.Windows.Forms.Button();
            this.toRegisterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(269, 117);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 19);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(268, 188);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 19);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameTextBox.Location = new System.Drawing.Point(272, 144);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(216, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordTextBox.Location = new System.Drawing.Point(273, 221);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(216, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.AutoSize = true;
            this.authorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.authorizationLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.authorizationLabel.Location = new System.Drawing.Point(229, 363);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(138, 20);
            this.authorizationLabel.TabIndex = 7;
            this.authorizationLabel.Text = "authorization label";
            // 
            // theLoginButton
            // 
            this.theLoginButton.BackColor = System.Drawing.Color.White;
            this.theLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.theLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.theLoginButton.Location = new System.Drawing.Point(272, 267);
            this.theLoginButton.Name = "theLoginButton";
            this.theLoginButton.Size = new System.Drawing.Size(216, 46);
            this.theLoginButton.TabIndex = 11;
            this.theLoginButton.Text = "Login";
            this.theLoginButton.UseVisualStyleBackColor = false;
            this.theLoginButton.Click += new System.EventHandler(this.TheLoginButton_Click);
            this.theLoginButton.MouseLeave += new System.EventHandler(this.TheLoginButton_MouseLeave);
            this.theLoginButton.MouseHover += new System.EventHandler(this.TheLoginButton_MouseHover);
            // 
            // toRegisterLinkLabel
            // 
            this.toRegisterLinkLabel.AutoSize = true;
            this.toRegisterLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toRegisterLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toRegisterLinkLabel.Location = new System.Drawing.Point(256, 328);
            this.toRegisterLinkLabel.Name = "toRegisterLinkLabel";
            this.toRegisterLinkLabel.Size = new System.Drawing.Size(251, 20);
            this.toRegisterLinkLabel.TabIndex = 14;
            this.toRegisterLinkLabel.TabStop = true;
            this.toRegisterLinkLabel.Text = "Don\'t have an accout yet? Sign up";
            this.toRegisterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToRegisterLinkLabel_LinkClicked);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(306, 36);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(124, 51);
            this.loginTitle.TabIndex = 15;
            this.loginTitle.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.toRegisterLinkLabel);
            this.Controls.Add(this.theLoginButton);
            this.Controls.Add(this.authorizationLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.Button theLoginButton;
        private System.Windows.Forms.LinkLabel toRegisterLinkLabel;
        private System.Windows.Forms.Label loginTitle;
    }
}

