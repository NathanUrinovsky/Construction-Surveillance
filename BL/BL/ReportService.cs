using System;
using System.Collections.Generic;
using DAL;

namespace BL
{
    public class ReportService
    {
        public ReportService()
        {

        }

        /// <summary>
        /// sending a report to employee
        /// </summary>
        /// <param name="senderID"></param>
        /// <param name="recieverEmail"></param>
        /// <param name="subject"></param>
        /// <param name="content"></param>
        public void SendReport(int senderID, string recieverEmail, string subject, string content)
        {
            try
            {
                if (IsTextEmpty(subject))
                {
                    //assigning the subject to no subject if the subject is empty
                    subject = "(No subject)";
                }
                else
                {
                    subject = LeaveOnlyCharacters(subject); //the subject but without spaces from the side if added
                }
                ReportsDAL.AddReport(senderID, recieverEmail, subject, content); //saving the report to the system
            }
            catch (Exception)
            {
                throw new ArgumentException("invalid report details");
            }
        }

        /// <summary>
        /// list of all reports that were sent to a certain employee
        /// </summary>
        /// <param name="recieverID"></param>
        /// <returns></returns>
        public List<ReportData> GetAllReportsSentToEmployee(int recieverID)
        {
            List<Report> reportsSentToEmployee = ReportsDAL.RetrieveReportsSentToEmployee(recieverID); //reports from dal
            List<ReportData> reportDatas = new List<ReportData>();
            //converting to reports of bl
            foreach (var report in reportsSentToEmployee)
            {
                reportDatas.Add(new ReportData() { reportID = report.GetReportID(), senderName = report.GetSenderName(), senderEmail = report.GetEmailSender(), subject = report.GetSubject(), content = report.GetContent() });
            }
            return reportDatas;
        }

        /// <summary>
        /// retreiving a specific report
        /// </summary>
        /// <param name="reportID"></param>
        /// <returns></returns>
        public ReportData GetReport(int reportID)
        {
            Report report = ReportsDAL.GetReport(reportID); //report of dal
            ReportData reportData = new ReportData() { reportID = report.GetReportID(), senderName = report.GetSenderName(), senderEmail = report.GetEmailSender(), subject = report.GetSubject(), content = report.GetContent() };
            return reportData;
        }

        /// <summary>
        /// retrieving the id of the last report
        /// </summary>
        /// <returns></returns>
        public int retrieveIDOfLastReport()
        {
            int idOfLastReport = ReportsDAL.RetrieveLastestReportID();
            return idOfLastReport;
        }

        /// <summary>
        /// retrieving a list with the name of the files of the report
        /// </summary>
        /// <param name="reportID"></param>
        /// <returns></returns>
        public List<string> getFilesOfReport(int reportID)
        {
            List<string> reportFiles = ReportsDAL.GetFilesOfReport(reportID);
            return reportFiles;
        }

        /// <summary>
        /// trimming a string so that it won't have any spaces in its sides
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string LeaveOnlyCharacters(string text)
        {
            char[] charsToTrim = { ' ' }; //chars that need to be trimmed if they exist on the side
            string actualText = text.Trim(charsToTrim); //trimmed text
            return actualText;
        }

        /// <summary>
        /// returning wether a text box is empty or not
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        private bool IsTextEmpty(string text)
        {
            string actualText = LeaveOnlyCharacters(text);
            bool isEmpty = actualText.Length == 0; //is the length of the trimmed text 0
            return isEmpty;
        }
    }
}
