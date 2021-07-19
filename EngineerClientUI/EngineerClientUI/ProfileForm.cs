using System;
using System.Windows.Forms;
using BL;

namespace EngineerClientUI
{
    public partial class ProfileForm : Form
    {
        private AuthenticationData authenticationData;
        private EmployeeData employee;
        private ProjectManager projectManager;
        public ProfileForm(AuthenticationData authenticationData, ProjectManager projectManager)
        {
            InitializeComponent();
            SetProperties(authenticationData, projectManager);
        }

        /// <summary>
        /// setting the properties of the 
        /// </summary>
        private void SetProperties(AuthenticationData authenticationData, ProjectManager projectManager)
        {
            this.authenticationData = authenticationData;
            this.projectManager = projectManager;
            //the employee
            this.employee = projectManager.RetrieveEmployee(authenticationData.GetUser().GetEmail());
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            SetTitlesText();
        }


        /// <summary>
        /// setting the text in the titles of the profile
        /// </summary>
        private void SetTitlesText()
        {
            nameInputLabel.Text = this.employee.empName;
            idInputLabel.Text = this.employee.empID.ToString();
            emailInputLabel.Text = this.employee.empEmail;
            statusInputLabel.Text = this.authenticationData.GetUser().GetStatus();
            supervisorNameInputLabel.Text = this.employee.supervisorName;
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
