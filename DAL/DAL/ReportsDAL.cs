using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    /// <summary>
    /// class for taking or updating data from the reports table
    /// </summary>
    public static class ReportsDAL
    {

        /// <summary>
        /// adding a report (ID of the sender, the reciever, and the content) to the database
        /// </summary>
        /// <param name="senderID"></param>
        /// <param name="recieverEmail"></param>
        /// <param name="subject"></param>
        /// <param name="content"></param>
        public static void AddReport(int senderID, string recieverEmail, string subject, string content)
        {
            try
            {
                int recieverID = EmployeesDAL.RetrieveEmployeeIDByEmail(recieverEmail); //id of the reciever
                string sql = "INSERT INTO Reports (senderID, recieverID, reportContent, reportSubject) "
                    + "VALUES(" + senderID + ", " + recieverID + ", '" + content + "', '" + subject + "');";
                DBHelper.ExecuteNonQuery(sql);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("invalid report arguements");
            }
        }


        /// <summary>
        /// retrieving all the reports that were sent to the employee
        /// </summary>
        /// <param name="senderName"></param>
        /// <returns>list of reports that were sent to the employee with the given id</returns>

        public static List<Report> RetrieveReportsSentToEmployee(int recipientEmpID)
        {
            List<Report> reports = new List<Report>();
            Report report;
            string sql = "SELECT EmpName, Email, reportSubject , reportContent,  senderID, recieverID, EmpID, ReportID " +
                "FROM Employees " +
                "INNER JOIN Reports ON Employees.EmpID = Reports.senderID OR Employees.EmpID = Reports.recieverID " +
                "WHERE Reports.recieverID = " + recipientEmpID +
                " ORDER BY ReportID ASC;";
            //this query returns pairs of entries about the same report, one for the sender and one for the reciever
            DataTable dataTable = DBHelper.GetDataTable(sql);

            string senderName;
            string recieverName;
            string senderEmail;
            string reportSubject;
            string reportContent;
            int reportID;
            for (int i = 0; i < dataTable.Rows.Count - 1;)
            {
                string senderID = dataTable.Rows[i][4].ToString();
                string empID = dataTable.Rows[i][6].ToString();
                if (senderID == empID) //if the id of the sender equals to the id of the employee
                {
                    senderName = dataTable.Rows[i][0].ToString();
                    senderEmail = dataTable.Rows[i][1].ToString();
                    recieverName = dataTable.Rows[i + 1][0].ToString();

                }
                else
                {
                    senderName = dataTable.Rows[i + 1][0].ToString();
                    senderEmail = dataTable.Rows[i + 1][1].ToString();
                    recieverName = dataTable.Rows[i][0].ToString();
                }
                reportSubject = dataTable.Rows[i][2].ToString();
                reportContent = dataTable.Rows[i][3].ToString();
                reportID = Convert.ToInt32(dataTable.Rows[i][7].ToString());
                report = new Report(reportID, senderName, recieverName, senderEmail, reportSubject, reportContent);
                reports.Add(report);
                //we oredered the rows in the query by reportID, and since there are two entries for every report,
                //we should skip a row
                i = i + 2; 
            }

            return reports;
        }

        /// <summary>
        /// retrieving a report
        /// </summary>
        /// <param name="reportID"></param>
        /// <returns>report with a certian id</returns>
        public static Report GetReport(int reportID)
        {
            string sql = "SELECT EmpName, Email, reportSubject , reportContent,  senderID, recieverID, EmpID " +
                "FROM Employees " +
                "INNER JOIN Reports ON Employees.EmpID = Reports.senderID OR Employees.EmpID = Reports.recieverID " +
                "WHERE Reports.ReportID = " + reportID + ";";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            Report report;

            //properties of a report
            string senderName = "";
            string recieverName = "";
            string senderEmail = "";
            string reportSubject = "";
            string reportContent = "";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int senderID = Convert.ToInt32(dataTable.Rows[i][4].ToString());
                int empID = Convert.ToInt32(dataTable.Rows[i][6].ToString());
                if (senderID == empID) //if the id of the sender equals to the id of the employee, we are the rows where the sender's name and email are stored
                { 
                    senderName = dataTable.Rows[i][0].ToString();  
                    senderEmail = dataTable.Rows[i][1].ToString();

                }
                else
                {
                    recieverName = dataTable.Rows[i][0].ToString(); //rows where the name of the reciever is stored
                }
                reportSubject = dataTable.Rows[i][2].ToString();
                reportContent = dataTable.Rows[i][3].ToString();
            }

            report = new Report(reportID, senderName, recieverName, senderEmail, reportSubject, reportContent);
            return report;
        }

        /// <summary>
        /// retrieving the id of the last report
        /// </summary>
        /// <returns>id of the last report in the reports table</returns>

        public static int RetrieveLastestReportID()
        {
            string sql = "SELECT TOP 1 * FROM Reports ORDER BY reportID DESC";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            int lastReportID = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            return lastReportID;
        }

        /// <summary>
        /// retrieving a list of the paths of the file of a report using its id
        /// </summary>
        /// <param name="reportID"></param>
        /// <returns></returns>
        public static List<string> GetFilesOfReport(int reportID)
        {
            List<string> fileList = new List<string>(); // list of strings that will store the names of the files
            string sql = "SELECT filePath FROM Files WHERE reportID = " + reportID + ";";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                fileList.Add(dataTable.Rows[i][0].ToString());
            }

            return fileList;
        }
    }
}
