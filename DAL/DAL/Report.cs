namespace DAL
{
    /// <summary>
    /// class that represents the reports sent by users
    /// </summary>
    public class Report
    {
        private int reportID;
        private string senderName; //name address of the sender
        private string recieverName; //name address of the reciever 
        private string senderEmail; //email address of the sender
        private string subject; //subject of the report
        private string content; //content of the report 

        /// <summary>
        /// empty constructor
        /// </summary>
        public Report()
        {

        }

        
        public Report(int reportID, string senderName, string recieverName, string senderEmail, string subject, string content)
        {
            this.reportID = reportID;
            this.senderName = senderName;
            this.recieverName = recieverName;
            this.senderEmail = senderEmail;
            this.subject = subject;
            this.content = content;
        }

        //-----Getters-----
        public int GetReportID()
        {
            return this.reportID;
        }

        public string GetSenderName()
        {
            return this.senderName;
        }

        public string GetRecieverName()
        {
            return this.recieverName;
        }

        public string GetEmailSender()
        {
            return this.senderEmail;
        }

        public string GetSubject()
        {
            return this.subject;
        }

        public string GetContent()
        {
            return this.content;
        }
        //-----Setters-----
        public void SetReportID(int reportID)
        {
            this.reportID = reportID;
        }
        public void SetSenderName(string senderName)
        {
            this.senderName = senderName;
        }
        public void SetRecieverName(string recieverName)
        {
            this.recieverName = recieverName;
        }
        public void SetSenderEmail(string senderEmail)
        {
            this.senderEmail = senderEmail;
        }
        public void SetSubject(string subject)
        {
            this.subject = subject;
        }
        public void SetContent(string content)
        {
            this.content = content;
        }
    }
}
