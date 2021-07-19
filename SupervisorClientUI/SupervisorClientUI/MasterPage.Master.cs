using System;

namespace SupervisorClientUI
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileWebForm.aspx");
        }

        protected void toAddPermit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPermitWebForm.aspx");
        }

        protected void toChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePasswordWebForm.aspx");
        }

        protected void toSendReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendReportWebForm.aspx");
        }

        protected void toAllReports_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllReportsWebForm.aspx");
        }

        protected void toChangeEngineerStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeEngineerStatusWebForm.aspx");
        }

        protected void toSignOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginWebForm.aspx");
        }
    }
}