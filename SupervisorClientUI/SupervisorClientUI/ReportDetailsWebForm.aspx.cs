using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using BL;

namespace SupervisorClientUI
{
    public partial class ReportDetailsWebForm : System.Web.UI.Page
    {
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        private int reportID;
        private ReportData reportData;
        private string fileName;
        private string basePath;
        private string filesPath;
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsManagerValid())
            {
                SetProperties();
                SetTextInControls();
            }

            else
            {
                Response.Redirect("LoginWebForm.aspx");
            }

            if (!IsPostBack)
            {
                LoadFiles(this.reportData.reportID);
            }
        }

        /// <summary>
        /// setting the properties of the page
        /// </summary>
        private void SetProperties()
        {
            //assigning values to the properties of the page
            this.projectManager = (ProjectManager)Session[WebConstants.managerString];
            this.authenticationData = (AuthenticationData)Session[WebConstants.authenticationDataString];
            this.reportID = Convert.ToInt32(Session[WebConstants.reportIDstring]);
            this.reportData = this.projectManager.GetReport(this.reportID);
            this.basePath = ConfigurationManager.AppSettings.Get(Paths.basePathKeyName);
            this.filesPath = ConfigurationManager.AppSettings.Get(Paths.filesPathKeyName);

        }

        /// <summary>
        /// returning wether the manager is valid
        /// </summary>
        /// <returns></returns>
        private bool IsManagerValid()
        {
            return (ProjectManager)Session[WebConstants.managerString] != null;
        }

        /// <summary>
        /// setting text in the titles
        /// </summary>
        private void SetTextInControls()
        {
            //storing text that will later be dispalyed in variables
            string senderName = this.reportData.senderName;
            string senderEmail = this.reportData.senderEmail;
            string subject = this.reportData.subject;
            string content = this.reportData.content;

            //setting the text that shows who sent the report
            this.fromInput.Text = senderName + " (" + senderEmail + ")";

            //setting the text of the subject title
            this.subjectInput.Text = subject;

            //setting the text of of the text box that contains the content itself
            this.contentTextBox.Text = content;

            this.fileName = string.Empty;
        }

        /// <summary>
        /// loading the files of the report in the list box
        /// </summary>
        private void LoadFiles(int reportID)
        {
            List<string> files = this.projectManager.GetFileListOfReport(reportID);
            for (int i = 0; i < files.Count; i++)
            {
                string fileName = Path.GetFileName(files[i]);
                fileListBox.Items.Add(fileName);
            }
            
        }

        protected void fileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fileName = fileListBox.SelectedValue.ToString();
        }

        protected void showFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (WasFileSelected())
                {
                    string path = this.basePath + this.filesPath + WebConstants.defaultBeginningOfReportFilesFolder + this.reportID.ToString() + "\\" + this.fileName;
                    Process.Start(path);
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// returning wether a file was selected
        /// </summary>
        /// <returns>is the filename empty or not</returns>
        private bool WasFileSelected()
        {
            return this.fileName != string.Empty;
        }
    }
}