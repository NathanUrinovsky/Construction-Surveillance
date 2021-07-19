using System;
using System.Configuration;
using System.Web;
using BL;


namespace SupervisorClientUI
{
    public partial class SendReportWebForm : System.Web.UI.Page
    {
        ProjectManager projectManager;
        AuthenticationData authenticationData;
        private string basePath;
        private string filePath;
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
        }

        /// <summary>
        /// returning wether the manager is valid or not
        /// </summary>
        /// <returns></returns>
        private bool IsManagerValid()
        {
            return (ProjectManager)Session[WebConstants.managerString] != null;
        }

        protected void sendReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SendMail();
                SaveMailFiles(this.projectManager.LastReportID());
                ClearAfterSending();
            }
            catch (ArgumentException)
            {
                this.successInSendingReportLabel.Text = "Couldn't send mail. make sure all fields are filled correctly";
            }
        }

        /// <summary>
        /// clearing text boxes after sending a mail
        /// </summary>
        private void ClearAfterSending()
        {
            addresseeEmailTextBox.Text = string.Empty;
            subjectTextBox.Text = string.Empty;
            contentTextBox.Text = string.Empty;
            this.successInSendingReportLabel.Text = "Mail sent successfullly";
        }

        /// <summary>
        /// sending a mail
        /// </summary>
        private void SendMail()
        {
            int empID = this.authenticationData.GetEmpID();
            string recieverEmail = addresseeEmailTextBox.Text;
            string subject = subjectTextBox.Text;
            string content = contentTextBox.Text;
            this.projectManager.SendReport(empID, recieverEmail, subject, content);
        }

        /// <summary>
        /// saving the files of the mail
        /// </summary>
        /// <param name="reportID"></param>
        private void SaveMailFiles(int reportID)
        {
            if (fileUpload.HasFiles)
            {
                foreach (HttpPostedFile uploadedFile in fileUpload.PostedFiles)
                {
                    string basePath = this.basePath + this.filePath;
                    string temptPath = basePath + uploadedFile.FileName; //this path does not exist but it is created in order to create the target path
                    string targetPath = this.projectManager.CreateNewPath(temptPath, reportID);
                    uploadedFile.SaveAs(targetPath);
                    this.projectManager.SaveFilePath(targetPath, reportID);
                }
            }
        }

        /// <summary>
        /// setting the properties of the page
        /// </summary>
        private void SetProperties()
        {    
            this.projectManager = (ProjectManager)Session[WebConstants.managerString];
            this.authenticationData = (AuthenticationData)Session[WebConstants.authenticationDataString];
            this.basePath = ConfigurationManager.AppSettings.Get(Paths.basePathKeyName);
            this.filePath = ConfigurationManager.AppSettings.Get(Paths.filesPathKeyName);
        }
    }
}