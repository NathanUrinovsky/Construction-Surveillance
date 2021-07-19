using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using BL;

namespace EngineerClientUI
{
    public partial class AllReportsForm : Form
    {
        private AuthenticationData authenticationData;
        private List<ReportData> reportDatas;
        private ProjectManager projectManager;
        public AllReportsForm(AuthenticationData authenticationData, ProjectManager projectManager)
        {
            InitializeComponent();
            SetProperties(authenticationData, projectManager);

            if (IsListEmpty())
            {
                DisableControls();
            }

            else 
            {
                EnableControls();
                GenerateGridView();
            }
        }

        /// <summary>
        /// setting the properties of the page
        /// </summary>
        /// <param name="authenticationData"></param>
        /// <param name="projectManager"></param>
        private void SetProperties(AuthenticationData authenticationData, ProjectManager projectManager)
        {
            this.authenticationData = authenticationData;
            this.projectManager = projectManager;
            this.reportDatas = projectManager.RetrieveReportsData(authenticationData.GetEmpID());
        }
        
        /// <summary>
        /// returning wether a list is empty or not
        /// </summary>
        /// <returns></returns>
        private bool IsListEmpty()
        {
            return this.reportDatas.Count == 0; //if the length of the list is 0, it means the list is empty
        }

        /// <summary>
        /// disabling controls
        /// </summary>
        private void DisableControls()
        {
            this.youDontHaveReportLabel.Visible = true;
            this.allReportSentToYouTitle.Visible = false;
            this.reportsGridView.Visible = false;
        }

        /// <summary>
        /// enabling controls
        /// </summary>
        private void EnableControls()
        {
            this.youDontHaveReportLabel.Visible = false;
        }

        /// <summary>
        /// generating the gridview with the reports
        /// </summary>
        private void GenerateGridView()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[4];

            //creating an array of data columns
            dataColumns[0] = new DataColumn("Sender", typeof(string));
            dataColumns[1] = new DataColumn("Email", typeof(string));
            dataColumns[2] = new DataColumn("Subject", typeof(string));
            dataColumns[3] = new DataColumn("Report ID", typeof(int));

            dataTable.Columns.AddRange(dataColumns);
            DataRow dataRow;

            foreach (var report in this.reportDatas)
            {
                dataRow = dataTable.NewRow();
                dataRow[0] = report.senderName;
                dataRow[1] = report.senderEmail;
                dataRow[2] = report.subject;
                dataRow[3] = report.reportID;
                dataTable.Rows.Add(dataRow);
            }

            this.reportsGridView.DataSource = dataTable;
        }

        private void AllReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ReportsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.reportsGridView.CurrentCell.RowIndex > -1 && this.reportsGridView.CurrentCell.ColumnIndex != 0)
                {
                    string reportIDStr = this.reportsGridView[3, this.reportsGridView.CurrentCell.RowIndex].FormattedValue.ToString();
                    int reportID = Convert.ToInt32(reportIDStr); //storing the reportID of the selected report
                    //creating an instance of the reportDetails screen and showing it
                    ReportDetails reportDetails = new ReportDetails(reportID, this.projectManager, this.authenticationData);
                    reportDetails.Show();
                }
            }
            catch (Exception)
            {
                
            }
            
            
        }

        private void ReportsGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                PaintRow(e.RowIndex, Color.Navy, Color.White); //paint the hoverd row
            }
        }

        private void ReportsGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                PaintRow(e.RowIndex, this.reportsGridView.BackgroundColor, Color.Black); //paint the row that was left
            }
        }

        /// <summary>
        /// painting a row that was hovered by the user
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="foreColor"></param>
        private void PaintRow(int rowIndex, Color backgroundColor, Color foreColor)
        {
            this.reportsGridView.Rows[rowIndex].DefaultCellStyle.BackColor = backgroundColor;
            this.reportsGridView.Rows[rowIndex].DefaultCellStyle.ForeColor = foreColor;
        }
    }
}
