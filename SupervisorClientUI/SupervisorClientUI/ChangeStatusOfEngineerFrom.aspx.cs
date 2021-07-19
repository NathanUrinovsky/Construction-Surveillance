using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using BL;

namespace SupervisorClientUI
{
    public partial class ChangeStatusOfEngineerFrom : System.Web.UI.Page
    {
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        private string status;
        private string email;
        private int supervisorID;
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
                PopulateDropDown();
            }
        }

        /// <summary>
        /// returning whether the manager is valid
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
            this.supervisorID = this.authenticationData.GetEmpID();
        }

        /// <summary>
        /// populating the dropdown
        /// </summary>
        private void PopulateDropDown()
        {
            List<Engineer> engineerList = this.projectManager.EngineerList(this.supervisorID); //list of engineers
            ListItem[] listItems = new ListItem[engineerList.Count]; //new array of listItems in the length of the list
            Dictionary<string, string> names = new Dictionary<string, string>(); //new dictionary

            //populating the dictionary
            for (int i = 0; i < engineerList.Count; i++)
            {
                Engineer engineer = engineerList[i];
                ListItem listItem = new ListItem(engineer.email, engineer.status.ToString());
                listItems[i] = listItem;
                names.Add(engineer.email, this.projectManager.RetrieveEmployee(engineer.email).empName);
            }

            //
            Session[WebConstants.subordinatesEngineersNamesDictionary] = names;
            Session[WebConstants.subordinatesEngineersList] = listItems;
            //populating the dropdown
            this.addressDropdown.DataSource = listItems;
            this.addressDropdown.DataBind();

        }

        protected void viewEngineerDetails_Click(object sender, EventArgs e)
        {
            try
            {
                //filling labels with data about selected engineer
                this.emailLabel.Text = GetEmailFromDDL();
                this.nameLabel.Text = GetNameFromDDL();
                this.statusLabel.Text = GetStatusFromDDL();
                this.succesLabel.Text = string.Empty;
            }
            catch (Exception)
            {

            }
            
        }

        //---getting the values of the session---//

        private string GetEmailFromDDL()
        {
            return ((ListItem[])Session[WebConstants.subordinatesEngineersList])
                [this.addressDropdown.SelectedIndex].Text;
        }

        private string GetStatusFromDDL()
        {
            return ((ListItem[])Session[WebConstants.subordinatesEngineersList])
                [this.addressDropdown.SelectedIndex].Value;
        }

        private string GetNameFromDDL()
        {
            Dictionary<string, string> names = (Dictionary<string, string>)
                Session[WebConstants.subordinatesEngineersNamesDictionary];
            return names[emailLabel.Text];
        }

        protected void changeEngineerStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.status = GetStatusFromDDL();
                this.email = GetEmailFromDDL();
                changeStatus();
                ResetLabels();
                Response.Redirect("ChangeStatusOfEngineerFrom.aspx");
            }
            catch (Exception)
            {

            }
            
        }

        /// <summary>
        /// clearing the text of the lables
        /// </summary>
        private void ResetLabels()
        {
            emailLabel.Text = string.Empty;
            nameLabel.Text = string.Empty;
            statusLabel.Text = string.Empty;
        }

        protected void addressDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetLabels();
        }

        /// <summary>
        /// changing the status of the selected engineer
        /// </summary>
        private void changeStatus()
        {
            if (this.status == Status.Active.ToString())
            {
                this.projectManager.SuspendAccount(this.email);
            }
            else
            {
                this.projectManager.ActivateAccount(this.email);
            }
        }
    }
}