using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using BL;

namespace SupervisorClientUI
{
    public partial class AllReportsWebForm : System.Web.UI.Page
    {
        ProjectManager projectManager;
        AuthenticationData authenticationData;
        List<ReportData> reportDatas;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsManagerValid())
            {
                SetProperties();
                LoadReportsToPanel();
            }

            else
            {
                Response.Redirect("LoginWebForm.aspx");
            }
        }

        /// <summary>
        /// returning wether manager is valid
        /// </summary>
        /// <returns></returns>
        private bool IsManagerValid()
        {
            return (ProjectManager)Session[WebConstants.managerString] != null;
        }

        /// <summary>
        /// setting the properties of the page
        /// </summary>
        private void SetProperties()
        {
            this.projectManager = (ProjectManager)Session[WebConstants.managerString];
            this.authenticationData = (AuthenticationData)Session[WebConstants.authenticationDataString];
            this.reportDatas = this.projectManager.RetrieveReportsData(this.authenticationData.GetEmpID());
            this.reportsPanel.Visible = true;
        }

        /// <summary>
        /// loding the reports
        /// </summary>
        private void LoadReportsToPanel()
        {
            GenerateGridView();
        }

        /// <summary>
        /// /creating the table with the reports
        /// </summary>
        private void GenerateGridView()
        {
            DataTable dataTable = new DataTable(); //data table
            DataColumn[] dataColumns = new DataColumn[4]; //array of columns

            //populating an array of data columns
            dataColumns[0] = new DataColumn("Sender", typeof(string));
            dataColumns[1] = new DataColumn("Email", typeof(string));
            dataColumns[2] = new DataColumn("Subject", typeof(string));
            dataColumns[3] = new DataColumn("Report ID", typeof(int));

            dataTable.Columns.AddRange(dataColumns);
            DataRow dataRow;

            //filling the table
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
            this.reportsGridView.DataBind();
        }

        protected void reportsGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //creating a click event for the gridview
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(this.reportsGridView, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }

            //setting width for the columns
            e.Row.Cells[0].Width = new Unit("33.3%");
            e.Row.Cells[1].Width = new Unit("33.3%");
            e.Row.Cells[2].Width = new Unit("33.3%");
            e.Row.Cells[3].Width = new Unit("0%");
            e.Row.Cells[3].Font.Size = 0;
        }

        protected void reportsGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedirectToSelectedReport();
        }

        /// <summary>
        /// redirecting to the report that was selected
        /// </summary>
        private void RedirectToSelectedReport()
        {
            Session[WebConstants.reportIDstring] = this.reportsGridView.SelectedRow.Cells[3].Text;
            //opening the report details page in a new tab
            Response.Write("<script>");
            Response.Write("window.open('ReportDetailsWebForm.aspx','_blank')");
            Response.Write("</script>");
        }
    }
}