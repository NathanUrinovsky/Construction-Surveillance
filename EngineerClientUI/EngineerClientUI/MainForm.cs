using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BL;

namespace EngineerClientUI
{
    public partial class MainForm : Form
    {
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //creating round edges 
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
          );

        public MainForm(ProjectManager projectManager, AuthenticationData authenticationData)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //making the edges of the form round
            this.projectManager = projectManager;
            this.authenticationData = authenticationData;

            this.formLoaderPanel.Controls.Clear();
            DetectImagesForm detectImagesForm = new DetectImagesForm(this.authenticationData, this.projectManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            detectImagesForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(detectImagesForm);
            detectImagesForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EmployeeData employee = this.projectManager.RetrieveEmployee(this.authenticationData.GetUser().GetEmail());
            this.nameInputLabel.Text = "Hello," + "\n" + employee.empName;
        }

        //redirecting to another form on the click of a button (depends of the button)

        private void ToProfileFormButton_Click(object sender, EventArgs e)
        {
            this.formLoaderPanel.Controls.Clear();
            ProfileForm profileForm = new ProfileForm(this.authenticationData, this.projectManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            profileForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(profileForm);
            profileForm.Show();

        }

        private void ToDetectButton_Click(object sender, EventArgs e)
        {
            this.formLoaderPanel.Controls.Clear();
            DetectImagesForm detectImagesForm = new DetectImagesForm(this.authenticationData, this.projectManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            detectImagesForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(detectImagesForm);
            detectImagesForm.Show();
        }

        private void SendReportButton_Click(object sender, EventArgs e)
        {
            this.formLoaderPanel.Controls.Clear();
            SendReportForm sendReportForm = new SendReportForm(this.authenticationData, this.projectManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            sendReportForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(sendReportForm);
            sendReportForm.Show();
        }

        private void ToAllReportsButton_Click(object sender, EventArgs e)
        {
            this.formLoaderPanel.Controls.Clear();
            AllReportsForm allReportsForm = new AllReportsForm(this.authenticationData, this.projectManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            allReportsForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(allReportsForm);
            allReportsForm.Show();
        }

        private void ToViewAndDownloadImages_Click(object sender, EventArgs e)
        {
            this.formLoaderPanel.Controls.Clear();
            DownloadImageForm downloadImageForm  = new DownloadImageForm(this.projectManager, this.authenticationData) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            downloadImageForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(downloadImageForm);
            downloadImageForm.Show();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }

        private void ChangeWindowsSizeButtonfColor(Button button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
        }

        private void MinimizeMainFormButton_Leave(object sender, EventArgs e)
        {
            ChangeWindowsSizeButtonfColor(this.minimizeMainFormButton, Color.White, Color.Black);
        }

        private void MinimizeMainFormButton_MouseHover(object sender, EventArgs e)
        {
            ChangeWindowsSizeButtonfColor(this.minimizeMainFormButton, Color.LightBlue, Color.White);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //changing the style of buttons in hover/leave

        private void ToDetectButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ToDetectButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Bold);
        }

        private void ToProfileFormButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ToProfileFormButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Bold);
        }

        private void SendReportButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void SendReportButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Bold);
        }

        private void ToAllReportsButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ToAllReportsButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Bold);
        }

        private void ToViewAndDownloadImages_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ToViewAndDownloadImages_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Bold);
        }

        private void SignOutButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void SignOutButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Bold);
        }

        private void ToChangePasswordButton_Click(object sender, EventArgs e)
        {
            this.formLoaderPanel.Controls.Clear();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(this.authenticationData, this.projectManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            changePasswordForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(changePasswordForm);
            changePasswordForm.Show();
        }

        private void ToChangePasswordButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ToChangePasswordButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Bold);
        }
    }
}
