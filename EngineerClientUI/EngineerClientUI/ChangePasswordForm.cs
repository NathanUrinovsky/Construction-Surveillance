using System;
using System.Drawing;
using System.Windows.Forms;
using BL;

namespace EngineerClientUI
{
    
    public partial class ChangePasswordForm : Form
    {
        private AuthenticationData authenticationData;
        private ProjectManager projectManager;
        public ChangePasswordForm(AuthenticationData authenticationData, ProjectManager projectManager)
        {
            InitializeComponent();
            SetProperties(authenticationData, projectManager);
        }

        /// <summary>
        /// setting the properties of the page
        /// </summary>
        /// <param name="authenticationData"></param>
        /// <param name="projectManager"></param>
        private void SetProperties(AuthenticationData authenticationData, ProjectManager projectManager)
        {
            this.authenticationData = authenticationData;
            this.projectManager = projectManager;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePassword();
            }
            catch (ArgumentException)
            {

                RaiseError();
            }

        }

        /// <summary>
        /// changing the password
        /// </summary>
        private void ChangePassword()
        {
            this.projectManager.ChangePassword(this.authenticationData.GetUser().GetUserName(), oldPasswordTextBox.Text, newPasswordTextBox.Text);
            //emptying text boxes
            this.oldPasswordTextBox.Text = string.Empty;
            this.newPasswordTextBox.Text = string.Empty;
            this.changePasswordStatusLabel.ForeColor = Color.Green;
            this.changePasswordStatusLabel.Text = "successfully changed password";
        }

        //raising an error is the password could not be changed
        private void RaiseError()
        {
            this.changePasswordStatusLabel.ForeColor = Color.Red;
            this.changePasswordStatusLabel.Text = "could not change your password. one or more of the details you filled is incorrect";
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            changePasswordStatusLabel.Text = string.Empty;
        }

        private void ChangePasswordButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ChangePasswordButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }
    }
}
