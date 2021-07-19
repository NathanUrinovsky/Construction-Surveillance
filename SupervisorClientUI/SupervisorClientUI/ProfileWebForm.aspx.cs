using System;
using BL;

namespace SupervisorClientUI
{
    
    public partial class ProfileWebForm : System.Web.UI.Page
    {
        ProjectManager projectManager;
        AuthenticationData authenticationData;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsManagerValid())
            {
                SetProperties();
                PopulateLabels();
            }

            else
            {
                Response.Redirect("LoginWebForm.aspx");
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
        }

        /// <summary>
        /// setting text in the labels that display the data of the employee who has signed in
        /// </summary>
        private void PopulateLabels()
        {
            this.emailLabel.Text = this.authenticationData.GetUser().GetEmail();
            EmployeeData employee = this.projectManager.RetrieveEmployee(this.emailLabel.Text); //employee instance of the employee who logged in
            this.nameLabel.Text = employee.empName.ToString();
            this.idValueLabel.Text = employee.empID.ToString();
            this.statusValueLabel.Text = authenticationData.GetUser().GetStatus().ToString();
            this.supervisorNameValueLabel.Text = ChiefsupervisorDetails.chiefSupervisorName;
        }
    }
}