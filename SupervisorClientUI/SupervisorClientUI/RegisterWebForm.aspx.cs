using System;
using BL;

namespace SupervisorClientUI
{
    public partial class RegisterWebForm : System.Web.UI.Page
    {
        private ProjectManager projectManager;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsManagerValid())
            {
                this.projectManager = (ProjectManager)Session["Manager"];
            }

            else
            {
                Response.Redirect("LoginWebForm.aspx");
            }

            if (!IsPostBack)
            {
                this.registrationStatusLabel.Visible = false;
            }
        }

        /// <summary>
        /// returning whether manager is valid or not
        /// </summary>
        /// <returns></returns>
        private bool IsManagerValid()
        {
            return Session[WebConstants.managerString] != null;
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            int chiefSupervisorID = this.projectManager.RetrieveChiefSupervisorID(); //the id of the chief supervisor
            try
            {
                this.projectManager.UserRegisterSupervisor(usernameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, empNameTextBox.Text, chiefSupervisorID, Roles.supervisor);
                Response.Redirect("LoginWebForm.aspx");
            }
            catch (ArgumentException)
            {
                registrationStatusLabel.Visible = true;
            }
        }

        protected void backToLoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginWebForm.aspx");
        }
    }
}