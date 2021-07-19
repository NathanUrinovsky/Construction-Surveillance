using System;
using System.Drawing;
using System.Windows.Forms;
using BL;

namespace EngineerClientUI
{
    public partial class LoginForm : Form
    {
        ProjectManager projectManager = new ProjectManager();
        private AuthenticationData authenticationData;
        public LoginForm()
        {
            InitializeComponent();
            authorizationLabel.Text = string.Empty;
        }

        
        private void LoginForm_Load(object sender, EventArgs e)
        {
                
        }

        private void TheLoginButton_Click(object sender, EventArgs e)
        {
            //the newly created authenticatoin data
            this.authenticationData = this.projectManager.LoginUser(usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString(), Roles.engineer);
            //employee id from the authentication data
            int empID = this.authenticationData.GetEmpID();
            if (DoesEmployeeExist(empID))
            {
                Login();
            }

            else
            {
                authorizationLabel.Text = "Unauthorized. One or more of the details you filled is incorrect";
            }
        }

        /// <summary>
        /// returning wether employee exists or not
        /// </summary>
        /// <param name="empID"></param>
        /// <returns></returns>
        private bool DoesEmployeeExist(int empID)
        {
            return empID != SpecialCharacters.illegalEmpID;
        }

        /// <summary>
        /// logging user in
        /// </summary>
        private void Login()
        {
            authorizationLabel.ForeColor = Color.Green;
            authorizationLabel.Text = "successful login. redirecting you...";
            Hide();
            MainForm mainForm = new MainForm(this.projectManager, this.authenticationData);
            mainForm.ShowDialog();
            Close();
        }

        private void TheExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToRegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm(this.projectManager);
            registerForm.ShowDialog();
            Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TheLoginButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void TheLoginButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }
    }
}
