using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BL;
using System.Net;
using System.Drawing.Imaging;

namespace EngineerClientUI
{
    public partial class DownloadImageForm : Form
    {
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        private string imagePath;
        private int addressID;
        private string date;
        public DownloadImageForm(ProjectManager projectManager, AuthenticationData authenticationData)
        {
            InitializeComponent();
            SetProperties(projectManager, authenticationData);
            SetAddressesDropdown();
            SetControlsState();
           
        }

        /// <summary>
        /// setting the properties when the page loads
        /// </summary>
        /// <param name="projectManager"></param>
        /// <param name="authenticationData"></param>
        private void SetProperties(ProjectManager projectManager, AuthenticationData authenticationData)
        {
            this.projectManager = projectManager;
            this.authenticationData = authenticationData;
            this.addressID = 0;
        }

        /// <summary>
        /// setting the state of the controls when the page loads
        /// </summary>
        private void SetControlsState()
        {
            datesLabel.Visible = false;
            datesList.Visible = false;
            showImageButton.Visible = false;
            this.imagePath = string.Empty;
            this.successlable.Text = string.Empty;
            this.date = string.Empty;
        }

        private void ShowImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowImage();
            }
            catch (Exception)
            {
                RaiseError();
            }
        }

        /// <summary>
        /// showing an image that was selected in a certain address and date
        /// </summary>
        private void ShowImage()
        {
            this.successlable.Visible = false;
            this.imagePath = projectManager.RetrieveImagePathInDate(this.addressID, this.date);
            this.ImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //setting image in picture box
            this.ImagePictureBox.Image = Image.FromStream(HttpWebRequest.Create(this.imagePath).GetResponse().GetResponseStream());
            this.downloadButton.Enabled = true;
        }

        /// <summary>
        /// raising an error if an image is not available
        /// </summary>
        private void RaiseError()
        {
            this.successlable.Visible = true;
            this.downloadButton.Enabled = false;
            this.successlable.Text = "Image is not available at the moment";
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            DownloadImage();
        }

        /// <summary>
        /// giving the user the option to download the selected image wherever they want on their computer
        /// </summary>
        private void DownloadImage()
        {
            this.saveFileDialog.Filter = ImageFilters.saveFilter;
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //saving in the the user chose
                ImagePictureBox.Image.Save(saveFileDialog.FileName, format);
            }
        }

        private void AddressList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //address id of the address that was selected
            string valueMember = ((AddressData)this.addressList.SelectedItem).addressID.ToString();
            if (IsAddressValid(valueMember))
            {
                FillDatesDropdown(valueMember);
            }

            else
            {
                HideAll();   
            }
        }

        /// <summary>
        /// checking if an actual address was selected or the "pick an address option"
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns></returns>
        private bool IsAddressValid(string addressIDStr)
        {
            return addressIDStr != "-1";
        }

        /// <summary>
        /// filling the dropdown with the dates of the images that were taken in the selected address
        /// </summary>
        private void FillDatesDropdown(string addressIDStr)
        {
            this.addressID = Convert.ToInt32(addressIDStr);
            //images from the selected address
            List<ImageData> imageDatas = this.projectManager.RetrieveImageDatasFromAddress(addressID);
            datesList.DataSource = imageDatas;
            datesList.DisplayMember = "date";
            datesList.ValueMember = "path";
            datesLabel.Visible = true;
            datesList.Visible = true;
            showImageButton.Visible = true;
            downloadButton.Visible = true;
            this.date = imageDatas[0].date.ToString();
            ClearPictureBox(ImagePictureBox);
        }

        /// <summary>
        /// hiding all the controls
        /// </summary>
        private void HideAll()
        {
            datesLabel.Visible = false;
            datesList.Visible = false;
            showImageButton.Visible = false;
            downloadButton.Visible = false;
            this.imagePath = string.Empty;
            ClearPictureBox(this.ImagePictureBox);
        }

        /// <summary>
        /// filling the dropdown of the addresses
        /// </summary>
        private void SetAddressesDropdown()
        {
            List<AddressData> addressDatas = this.projectManager.AddressDatasList();
            addressList.DataSource = addressDatas;
            addressList.DisplayMember = "address";
            addressList.ValueMember = "addressID";
        }

        private void DatesList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.addressID = ((ImageData)this.datesList.SelectedItem).addressID;
            this.date = ((ImageData)this.datesList.SelectedItem).date.ToString();
        }

        /// <summary>
        /// clearing a picturebox
        /// </summary>
        /// <param name="pictureBox"></param>
        private void ClearPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image = null;
            }
        }

        private void ShowImageButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ShowImageButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void DownloadButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void DownloadButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }
    }
}