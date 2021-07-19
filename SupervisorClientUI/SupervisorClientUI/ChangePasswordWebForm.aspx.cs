using System;
using BL;

namespace SupervisorClientUI
{
    public partial class ChangePasswordWebForm : System.Web.UI.Page
    {
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        private string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsManagerValid())
            {
                SetProperties();
            }

            else
            {
                Response.Redirect("LoginWebForm.aspx");
            }

            if (!IsPostBack)
            {
                this.changePasswordStatusLabel.Visible = false;
            }
        }

        /// <summary>
        /// returning wether manager is valid
        /// </summary>
        /// <returns></returns>
        private bool IsManagerValid()
        {
            return (ProjectManager)Session[WebConstants.managerString] != null;
        }

        /// <summary>
        /// setting the properties of the page
        /// </summary>
        private void SetProperties()
        {
            this.projectManager = (ProjectManager)Session[WebConstants.managerString];
            this.authenticationData = (AuthenticationData)Session[WebConstants.authenticationDataString];
            this.username = this.authenticationData.GetUser().GetUserName();
        }

        protected void changePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePassword();
            }
            catch (ArgumentException)
            {
                RaiseFailureInChangingPassword();
            }
        }

        /// <summary>
        /// changing the password and clearing some controls
        /// </summary>
        private void ChangePassword()
        {
            this.projectManager.ChangePassword(this.username, oldPasswordTextBox.Text, newPasswordTextBox.Text); //changing the password
            this.changePasswordStatusLabel.Text = "Password changed successfully";
            //reseting the controls in the page
            this.changePasswordStatusLabel.Visible = true;
            this.oldPasswordTextBox.Text = string.Empty;
            this.newPasswordTextBox.Text = string.Empty;
        }

        /// <summary>
        /// raising an error when changing a password
        /// </summary>
        private void RaiseFailureInChangingPassword()
        {
            this.changePasswordStatusLabel.Text = "could not change your password. one or more of the details you filled is incorrect";
            this.changePasswordStatusLabel.Visible = true;
        }
    }
}