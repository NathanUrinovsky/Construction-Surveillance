using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BL;

namespace EngineerClientUI
{
    public partial class RegisterForm : Form
    {
        private ProjectManager projectManager;
        public RegisterForm(ProjectManager projectManager)
        {
            InitializeComponent();
            this.projectManager = projectManager;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //this.supervisorsList.SelectedIndex = 0;
            PopulateDropdown();
        }


        /// <summary>
        /// populating the supervisors' dropdown
        /// </summary>
        private void PopulateDropdown()
        {
            successInRegistrationLabel.Text = string.Empty;
            List<EmployeeData> supervisors = this.projectManager.SupervisorsList(); //list of supervisors
            supervisorsList.DataSource = supervisors; //data source
            supervisorsList.DisplayMember = "empName"; //property that will be displyed
            supervisorsList.ValueMember = "empID"; //property that will be the actual value
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        { 
            try
            {
                //registering the user and moving to the login form
                this.projectManager.UserRegisterEngineer(usernameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, empNameTextBox.Text, Convert.ToInt32(supervisorsList.SelectedValue), Roles.engineer);
                Hide();
                (new LoginForm()).ShowDialog();
                Close();
            }
            catch (ArgumentException)
            {
                successInRegistrationLabel.ForeColor = Color.Red;
                successInRegistrationLabel.Text = "registration failed";
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackToLoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }

        private void RegisterButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, ((Button)sender).Font.Size, FontStyle.Bold);
        }

        private void RegisterButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, ((Button)sender).Font.Size, FontStyle.Regular);
        }
    }
}
