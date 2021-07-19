using System;
using BL;

namespace SupervisorClientUI
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        ProjectManager projectManager = new ProjectManager();
        AuthenticationData authenticationData;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loginSucceededLabel.Visible = false;
            }

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            this.authenticationData = this.projectManager.LoginUser(usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString(), BL.Roles.supervisor); //the authentication data
            if (DoesEmployeeExist())
            {
                Session[WebConstants.managerString] = this.projectManager;
                Session[WebConstants.authenticationDataString] = this.authenticationData;
                Response.Redirect("ProfileWebForm.aspx");
            }

            else
            {
                loginSucceededLabel.Visible = true;
            }
        }

        /// <summary>
        /// returning wether employee exists
        /// </summary>
        /// <returns>is the id of the employee equals to 0 or not</returns>
        private bool DoesEmployeeExist()
        {
            return authenticationData.GetEmpID() != WebConstants.forbiddenEmpID;
        }

        protected void toRegisterButton_Click(object sender, EventArgs e)
        {
            Session[WebConstants.managerString] = this.projectManager;
            Response.Redirect("RegisterWebForm.aspx");
        }
    }
}