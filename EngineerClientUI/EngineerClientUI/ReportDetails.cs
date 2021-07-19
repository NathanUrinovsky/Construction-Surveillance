using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using BL;

namespace EngineerClientUI
{
    public partial class ReportDetails : Form
    {
        private ReportData reportData;
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        private string basePath;
        private string filePath;
        public ReportDetails(int reportID, ProjectManager projectManager, AuthenticationData authenticationData)
        {
            InitializeComponent();
            SetProperties(reportID, projectManager, authenticationData);
        }


        /// <summary>
        /// setting the properties of the form
        /// </summary>
        /// <param name="reportID"></param>
        /// <param name="projectManager"></param>
        /// <param name="authenticationData"></param>
        private void SetProperties(int reportID, ProjectManager projectManager, AuthenticationData authenticationData)
        {
            this.projectManager = projectManager;
            this.reportData = this.projectManager.GetReport(reportID);
            this.authenticationData = authenticationData;
            this.basePath = ConfigurationManager.AppSettings.Get(Paths.basePathKeyName);
            this.filePath = ConfigurationManager.AppSettings.Get(Paths.filesPathKeyName);
        }

        private void ReportDetails_Load(object sender, EventArgs e)
        {
            FillTitlesAndLoadFiles();
        }

        /// <summary>
        /// filling the titles and loading the list of files
        /// </summary>
        private void FillTitlesAndLoadFiles()
        {
            string senderName = this.reportData.senderName;
            string senderEmail = this.reportData.senderEmail;
            string subject = this.reportData.subject;
            string content = this.reportData.content;
            this.nameAndEmailOfSenderInputLabel.Text = senderName + string.Empty + "(" + senderEmail + ")";
            this.subjectInputLabel.Text = subject;
            this.contentInputBox.Text = content;
            LoadFiles(this.reportData.reportID);
        }

        /// <summary>
        /// loading the list of the files
        /// </summary>
        /// <param name="reportID"></param>
        private void LoadFiles(int reportID)
        {
            List<string> files = this.projectManager.GetFileListOfReport(reportID);
            for (int i = 0; i < files.Count; i++)
            {
                string fileName = Path.GetFileName(files[i]);
                filesListBox.Items.Add(fileName);
            }
        }

        private void ReportDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void FilesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                OpenSelectedFile();
            }
            catch (Exception)
            {

            }
            
        }

        /// <summary>
        /// opening the file that was selected by the user
        /// </summary>
        private void OpenSelectedFile()
        {
            string fileName = filesListBox.GetItemText(filesListBox.SelectedItem).ToString(); //name of selected file
            string path = this.basePath + this.filePath + SpecialStrings.baseStringInReportFilesFolderNames + this.reportData.reportID.ToString() + "\\" + fileName; //its path
            Process.Start(path); //opening the file
        }
    }
}
