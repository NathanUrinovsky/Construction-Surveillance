using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using BL;

namespace EngineerClientUI
{
    public partial class SendReportForm : Form
    {
        private AuthenticationData authenticationData;
        private List<string> filesPaths;
        private ProjectManager projectManager;
        public SendReportForm(AuthenticationData authenticationData, ProjectManager projectManager)
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
            this.filesPaths = new List<string>();
            this.projectManager = projectManager;
        }

        private void SendReportForm_Load(object sender, EventArgs e)
        {
            SetControlsOnPageLoad();
        }

        /// <summary>
        /// setting the controls when the page loads
        /// </summary>
        private void SetControlsOnPageLoad()
        {
            this.addresseeEmailTextBox.Text = string.Empty;
            this.subjectTextBox.Text = string.Empty;
            this.contentRichTextBox.Text = string.Empty;
            this.filesPaths = new List<string>();
            this.uploadedFilesNames.Text = "Files uploaded: ";
        }

        private void BackToDetectImagesButton_Click(object sender, EventArgs e)
        {
            this.sendingStatusLabel.Text = string.Empty;
            SendReportForm_Load(sender, e);
        }

        private void SendReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SendReport();
                SaveFiles();
            }
            catch (ArgumentException)
            {
                RaiseError();
            }
        }

        /// <summary>
        /// clearing labels after sending the report
        /// </summary>
        private void ClearLabelsAftersaving()
        {
            this.addresseeEmailTextBox.Text = string.Empty;
            this.subjectTextBox.Text = string.Empty;
            this.contentRichTextBox.Text = string.Empty;
            this.uploadedFilesNames.Text = "Files uploaded: ";
            this.filesPaths = new List<string>();
            sendingStatusLabel.Text = "report sent";
        }

        /// <summary>
        /// sending the content of the report
        /// </summary>
        private void SendReport()
        {
            //details of the report that is about to be sent
            int empID = this.authenticationData.GetEmpID();
            string recieverEmail = addresseeEmailTextBox.Text;
            string subject = subjectTextBox.Text;
            string content = contentRichTextBox.Text;

            //sending the report
            projectManager.SendReport(empID, recieverEmail, subject, content);
        }

        /// <summary>
        /// raising an error
        /// </summary>
        private void RaiseError()
        {
            sendingStatusLabel.ForeColor = Color.Red;
            sendingStatusLabel.Text = "there was a problem sending this report. please make sure you have enterd all the details correctly";
        }

        private void SaveFiles()
        {
            int reportID = projectManager.LastReportID(); //id of the report that was just sent
            //saving each file
            foreach (var filePath in filesPaths)
            {
                projectManager.SaveFile(filePath, reportID);
            }
            ClearLabelsAftersaving();
        }

        private void UploadFilesButton_Click(object sender, EventArgs e)
        {
            uploadFile.Multiselect = false;
            if (uploadFile.ShowDialog() == DialogResult.OK)
            {
                string originalFilePath = uploadFile.FileName;
                this.filesPaths.Add(originalFilePath);
                uploadedFilesNames.Text += string.Empty + Path.GetFileName(uploadFile.FileName);

            }
        }

        private void UploadFilesButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void UploadFilesButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void SendReportButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void SendReportButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void BackToDetectImagesButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void BackToDetectImagesButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }
    }
}