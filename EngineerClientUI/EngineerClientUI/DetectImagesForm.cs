using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BL;
using System.Net;

namespace EngineerClientUI
{
    public partial class DetectImagesForm : Form
    {
        private const string imageTitle = "open image file";
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        private string uploadedImagePath;
        private string detectedImagePath;
        private string uploadedImagePathExAddress;
        private string detectedImagePathExAddress;
        private string addressName;
        private string addressNameExAddress;
        private AddressData address;
        public DetectImagesForm(AuthenticationData authenticationData, ProjectManager projectManager)
        {
            InitializeComponent();
            this.authenticationData = authenticationData;
            this.projectManager = projectManager;
        }
       
        private void UploadImageWithExistingAddress_Click(object sender, EventArgs e)
        {
            imageUpload.Title = imageTitle;
            imageUpload.Filter = ImageFilters.uploadFilter;
            if (imageUpload.ShowDialog() == DialogResult.OK) //if a file was selected
            {
                //setting the path of the uploaded image that should be detected in the existing image option
                //to the path of the image that was uploaded
                this.uploadedImagePathExAddress = imageUpload.FileName;
                detectedImageBoxInExistingAddress.Image = Image.FromStream(HttpWebRequest.Create(this.uploadedImagePathExAddress).GetResponse().GetResponseStream());
            }
        }

        private void UploadImageWithNewAddress_Click(object sender, EventArgs e)
        {
            imageUpload.Title = imageTitle;
            imageUpload.Filter = ImageFilters.uploadFilter;
            if (imageUpload.ShowDialog() == DialogResult.OK)
            {
                this.uploadedImagePath = imageUpload.FileName;
                //setting the image in the picture box
                this.detectedImageBoxInNewAddress.SizeMode = PictureBoxSizeMode.StretchImage;
                this.detectedImageBoxInNewAddress.Image = Image.FromStream(HttpWebRequest.Create(this.uploadedImagePath).GetResponse().GetResponseStream());
                if (this.newAddressTextBox.Text != string.Empty)
                {
                    this.detectNewImage.Enabled = true;
                }
            }
        }

        /// <summary>
        /// populating the address dropdown
        /// </summary>
        private void PopulateAddressropDown()
        {
            List<AddressData> addressDataList = this.projectManager.AddressDatasList(); //all addresses
            //another address for UI only
            AddressData addressData = new AddressData()
            { address = DropdownDefaultText.addressDefaultText, addressID = -1 };
            List<AddressData> fullAddressData = new List<AddressData>();
            if (addressDataList.Count > 0)
            {
                //making a list of all the addresses
                fullAddressData.Add(addressData);
                foreach (var item in addressDataList)
                {
                    fullAddressData.Add(item);
                }
            }

            addressesDropdown.DataSource = fullAddressData;
            addressesDropdown.DisplayMember = "address"; //property that will be displayed
            addressesDropdown.ValueMember = "addressID"; //property that will be hidden and will be the value of the selected item in the dropdown
        }

        private void DetectImagesForm_Load(object sender, EventArgs e)
        {
            //populating the dropdown
            PopulateAddressropDown();

            //setting all the paths to empty strings
            SetPropertiesEmpty();

            //setting the buttons to be either enabled or not enabled
            //in the tab of the existing addresses
            SetControlsOfExistingAddressInLoad();

            //in the tab of the new address
            SetControlsOfNewAddressInLoad();
        }

        private void ToPermitListButton_Click(object sender, EventArgs e)
        {
            //showing the permits form
            PermitsForm permitsForm = new PermitsForm(this.address, this.projectManager);
            permitsForm.Show();
        }

        private void UploadImageInExistingAddress_Click(object sender, EventArgs e)
        {
            imageUpload.Title = imageTitle;
            imageUpload.Filter = ImageFilters.uploadFilter;
            if (imageUpload.ShowDialog() == DialogResult.OK)
            {
                this.uploadedImagePathExAddress = imageUpload.FileName;
                //setting the image in the picturebox
                this.detectedImageBoxInExistingAddress.SizeMode = PictureBoxSizeMode.StretchImage;
                this.detectedImageBoxInExistingAddress.Image = Image.FromStream(HttpWebRequest.Create(this.uploadedImagePathExAddress).GetResponse().GetResponseStream());
                if (IsAddressSelected()) 
                {
                    //if an address was selected, then enable the button of the detect
                    this.detectBothImagesButton.Enabled = true;
                }
            }
        }

        private void SaveNewAddressButton_Click(object sender, EventArgs e)
        {
            SaveAndClearInNewAddress();
            EnableControlsAfterSaving();
        }

        /// <summary>
        /// clearing the controls in the new address option
        /// </summary>
        private void SaveAndClearInNewAddress()
        {
            //assigning the address to the newly added adress
            this.address = this.projectManager.SaveAddress(this.addressName);
            this.projectManager.SaveImage(this.detectedImagePath, this.address.addressID);
            ClearPictureBox(this.detectedImageBoxInNewAddress);
            this.newAddressTextBox.Text = string.Empty;
            this.errorLabel.Visible = false;
            PopulateAddressropDown(); //populating the dropdown again 
        }

        /// <summary>
        /// enabling certain controls after saving the detected image 
        /// </summary>
        private void EnableControlsAfterSaving()
        {
            this.UploadImageWithNewAddress.Enabled = true;
            this.detectNewImage.Enabled = false;
            this.cancelButton.Enabled = true;
            this.saveNewAddressButton.Enabled = false;
            this.newAddressTextBox.Enabled = true;
        }

        private void DetectNewImage_Click(object sender, EventArgs e)
        {
            this.addressName = this.newAddressTextBox.Text;
            try
            {
                if (ThereIsAnImageAndValidNewAddress())
                {
                    DisableControlsAfterDetectionInNewAddress();
                    DetectInNewAddress();
                    EnableControlsAfterDection();
                }
            }
            catch (Exception)
            {
                EnableControlsInDetectError();
            }
            
        }

        /// <summary>
        /// enabling controls when an error is raised
        /// </summary>
        private void EnableControlsInDetectError()
        {
            this.errorLabel.Visible = true;
            this.standbyNewAddressLabel.Visible = false;
            this.cancelButton.Enabled = true;
        }

        /// <summary>
        /// returning wether the user oploaded an image and typed a valid address
        /// </summary>
        /// <returns></returns>
        private bool ThereIsAnImageAndValidNewAddress()
        {
            return (this.uploadedImagePath != string.Empty && this.newAddressTextBox.Text != string.Empty);
        }

        /// <summary>
        /// disabling certain controls after detection is the new address option
        /// </summary>
        private void DisableControlsAfterDetectionInNewAddress()
        {
            this.UploadImageWithNewAddress.Enabled = false;
            this.detectNewImage.Enabled = false;
            this.newAddressTextBox.Enabled = false;
            this.cancelButton.Enabled = false;
            this.saveNewAddressButton.Enabled = false;
            this.errorLabel.Visible = false;
        }

        /// <summary>
        /// detecting the image that was uploaded in the new address option
        /// </summary>
        private void DetectInNewAddress()
        {
            this.standbyNewAddressLabel.Text = "Image is being analyzed. please wait...";
            this.detectedImagePath = this.projectManager.DetectImage(this.uploadedImagePath);
            this.standbyNewAddressLabel.Text = string.Empty;
            //setting the detected image in the picture box
            this.detectedImageBoxInNewAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            this.detectedImageBoxInNewAddress.Image = Image.FromStream(HttpWebRequest.Create(this.detectedImagePath).GetResponse().GetResponseStream());
        }

        /// <summary>
        /// enabling cnotrols after detection
        /// </summary>
        private void EnableControlsAfterDection()
        {
            this.cancelButton.Enabled = true;
            this.saveNewAddressButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearControlsInNewAddressAfterClearing();
            SetControlsStateAfterClearing();
        }

        /// <summary>
        /// clearing controls after canceling
        /// </summary>
        private void ClearControlsInNewAddressAfterClearing()
        {
            this.uploadedImagePath = string.Empty;
            this.detectedImagePath = string.Empty;
            this.addressName = string.Empty;
            this.newAddressTextBox.Text = string.Empty;
            this.errorLabel.Visible = false;
            ClearPictureBox(this.detectedImageBoxInNewAddress);
        }

        /// <summary>
        /// setting the state of controls after canceling the detection in new address
        /// </summary>
        private void SetControlsStateAfterClearing()
        {
            this.newAddressTextBox.Enabled = true;
            this.UploadImageWithNewAddress.Enabled = true;
            this.detectNewImage.Enabled = false;
            this.saveNewAddressButton.Enabled = false;
        }

        private void SaveExistingAddressButton_Click(object sender, EventArgs e)
        {
            SaveAndClearInExistingImage();
            SetStateOfControlsInExistingImageAfterSaving();
        }

        /// <summary>
        /// saving detected image and clearing controls in the existing image option
        /// </summary>
        private void SaveAndClearInExistingImage()
        {
            int addressID = Convert.ToInt32(this.addressesDropdown.SelectedValue);
            
            this.projectManager.SaveImage(this.detectedImagePathExAddress, addressID);
            this.address = new AddressData() { addressID = addressID, address = ((AddressData)this.addressesDropdown.SelectedItem).address };
            ClearPictureBox(this.detectedImageBoxInExistingAddress);
            ClearPictureBox(this.lastImageBox);
        }

        /// <summary>
        /// setting the state of certain controls after saving in the existing image option
        /// </summary>
        private void SetStateOfControlsInExistingImageAfterSaving()
        {
            this.toPermitListButton.Visible = false;
            this.cancelExistingAddressButton.Enabled = true;
            this.addressesDropdown.Enabled = true;
            this.detectBothImagesButton.Enabled = false;
            this.UploadImageInExistingAddress.Enabled = true;
            this.saveExistingAddressButton.Enabled = false;
            this.detectErrorLabel.Visible = false;
            this.addressesDropdown.SelectedIndex = 0;
        }

        private void DetectBothImagesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsAddressSelected())
                {
                    DisableControlsToActivateDetection();
                    ActivateDetection();
                    EnableControlsAfterDetection();
                }
            }
            catch (Exception)
            {
                EnableControlsInErrorExAddress();
            }
        }

        /// <summary>
        /// enabling certain controls after raising error in the existing address option
        /// </summary>
        private void EnableControlsInErrorExAddress()
        {
            this.detectErrorLabel.Visible = true;
            this.detectErrorLabel.Text = "Detection is not available at the moment";
            this.standbylabelExAddress.Text = string.Empty;
            this.cancelExistingAddressButton.Enabled = true;
        }

        /// <summary>
        /// returning wether an valid address was selected in the address dropdown 
        /// </summary>
        /// <returns></returns>
        private bool IsAddressSelected()
        {
            this.addressNameExAddress = ((AddressData)this.addressesDropdown.SelectedItem).address.ToString();
            return this.uploadedImagePathExAddress != string.Empty && this.addressNameExAddress != DropdownDefaultText.addressDefaultText;
        }

        /// <summary>
        /// detecting in the existing address
        /// </summary>
        private void ActivateDetection()
        {
            this.standbylabelExAddress.Text = "Image is being analyzed. please wait...";
            this.detectedImagePathExAddress = this.projectManager.DetectImage(this.uploadedImagePathExAddress);
            this.standbylabelExAddress.Text = string.Empty;

            this.detectedImageBoxInExistingAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            this.detectedImageBoxInExistingAddress.Image = Image.FromStream(HttpWebRequest.Create(this.detectedImagePathExAddress).GetResponse().GetResponseStream());
            int addressID = Convert.ToInt32(this.addressesDropdown.SelectedValue);
            //this.address = new Address(addressID, addressesDropdown.DisplayMember);
            this.address = new AddressData() { addressID = addressID, address = ((AddressData)this.addressesDropdown.SelectedItem).address };
        }

        /// <summary>
        /// disabling controls when detecting in existing address
        /// </summary>
        private void DisableControlsToActivateDetection()
        {
            detectErrorLabel.Visible = false;
            this.addressesDropdown.Enabled = false;
            this.UploadImageInExistingAddress.Enabled = false;
            this.cancelExistingAddressButton.Enabled = false;
            this.saveExistingAddressButton.Enabled = false;
            this.toPermitListButton.Visible = false;
        }

        /// <summary>
        /// enabling controls after detecting in the existing address
        /// </summary>
        private void EnableControlsAfterDetection()
        {
            this.cancelExistingAddressButton.Enabled = true;
            this.saveExistingAddressButton.Enabled = true;
            this.toPermitListButton.Visible = true;
            this.detectBothImagesButton.Enabled = false;
        }

        private void CancelExistingAddressButton_Click(object sender, EventArgs e)
        {
            ResetScreenControls();
        }

        /// <summary>
        /// reseting all the controls to initial state
        /// </summary>
        private void ResetScreenControls()
        {
            this.detectBothImagesButton.Enabled = false;
            this.UploadImageInExistingAddress.Enabled = true;
            this.saveExistingAddressButton.Enabled = false;
            this.toPermitListButton.Visible = false;
            this.addressesDropdown.Enabled = true;
            ClearPictureBox(this.lastImageBox);
            ClearPictureBox(this.detectedImageBoxInExistingAddress);
            this.uploadedImagePathExAddress = string.Empty;
            this.detectedImagePathExAddress = string.Empty;
            this.detectErrorLabel.Visible = false;
            this.addressesDropdown.SelectedIndex = 0;
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

        private void AddressesDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.detectErrorLabel.Visible = false;
                //storing the value member and the address of the selected item
                string valueMember = ((AddressData)this.addressesDropdown.SelectedItem).addressID.ToString();
                int addressID = Convert.ToInt32(valueMember);
                string addressNameTempt = ((AddressData)this.addressesDropdown.SelectedItem).address.ToString();

                if (addressNameTempt != "pick an address")
                {
                    SetImageInlastImageBox(addressID, addressNameTempt);
                    if (this.uploadedImagePathExAddress != string.Empty) //if a new image was uploaded
                    {
                        this.detectBothImagesButton.Enabled = true; //make detection button available
                    }
                }

                else
                {
                    ClearLastImageBox();
                    this.detectBothImagesButton.Enabled = false;
                }
            }
            catch (Exception)
            {
                this.detectErrorLabel.Visible = true;
                this.detectErrorLabel.Text = "Image is not available at the moment, or selected address is invalid";
            }
            
        }

        /// <summary>
        /// putting the last image from the selected address in its image box.
        /// </summary>
        /// <param name="addressID"></param>
        /// <param name="addressNameTempt"></param>
        private void SetImageInlastImageBox(int addressID, string addressNameTempt)
        {
            this.addressNameExAddress = addressNameTempt;
            //path of last image in the selected address
            string path = this.projectManager.RetrieveLastImagePathInAddress(addressID);
            //setting the picture in the picture box
            this.lastImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.lastImageBox.Image = Image.FromStream(HttpWebRequest.Create(path).GetResponse().GetResponseStream());
        }

        /// <summary>
        /// clearing the image box of the most recent image from a certain address
        /// </summary>
        private void ClearLastImageBox()
        {
            this.addressNameExAddress = string.Empty;
            ClearPictureBox(lastImageBox);
        }

        /// <summary>
        /// setting the state of the controls on load in the tab of existing addresses
        /// </summary>
        private void SetControlsOfExistingAddressInLoad()
        {
            this.UploadImageInExistingAddress.Enabled = true;
            this.cancelExistingAddressButton.Enabled = true;
            this.detectBothImagesButton.Enabled = false;
            this.saveExistingAddressButton.Enabled = false;
            this.toPermitListButton.Visible = false;
            this.detectErrorLabel.Visible = false;
        }

        /// <summary>
        /// setting the state of the controls on load in the tab of new address
        /// </summary>
        private void SetControlsOfNewAddressInLoad()
        {
            this.UploadImageWithNewAddress.Enabled = true;
            this.detectNewImage.Enabled = false;
            this.newAddressTextBox.Enabled = true;
            this.cancelButton.Enabled = true;
            this.saveNewAddressButton.Enabled = false;
            this.errorLabel.Visible = false;
        }

        /// <summary>
        /// setting some strings as empty strings
        /// </summary>
        private void SetPropertiesEmpty()
        {
            this.uploadedImagePath = string.Empty;
            this.detectedImagePath = string.Empty;
            this.uploadedImagePathExAddress = string.Empty;
            this.detectedImagePathExAddress = string.Empty;
            this.addressName = string.Empty;
            this.addressNameExAddress = string.Empty;
            standbylabelExAddress.Text = string.Empty;
            standbyNewAddressLabel.Text = string.Empty;
        }


        private void DetectBothImagesButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void DetectBothImagesButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void SaveExistingAddressButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void SaveExistingAddressButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void CancelExistingAddressButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void CancelExistingAddressButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void ToPermitListButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void ToPermitListButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void DetectNewImage_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void DetectNewImage_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void UploadImageWithNewAddress_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void UploadImageWithNewAddress_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void SaveNewAddressButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void SaveNewAddressButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void CancelButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }

        private void NewAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            //if the text box with the new addres is empty or there wasn't uploaded a new image or the image exists
            if (IsTextBoxEmpty(this.newAddressTextBox) || this.uploadedImagePath == string.Empty || this.projectManager.DoesAddressExist(LeaveOnlyCharacters(this.newAddressTextBox.Text)))
            {
                this.detectNewImage.Enabled = false;
            }

            else
            {
                this.detectNewImage.Enabled = true;
            }
        }

        /// <summary>
        /// returning wether a text box is empty or not
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        private bool IsTextBoxEmpty(TextBox textBox)
        {
            string textBoxValue = textBox.Text.ToString();
            string actualText = LeaveOnlyCharacters(textBoxValue);
            bool isEmpty = actualText.Length == 0;
            return isEmpty;
        }

        /// <summary>
        /// trimming a string so that it won't have any spaces in its sides
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string LeaveOnlyCharacters(string text)
        {
            char[] charsToTrim = { ' ' }; //characters that need to be trimmed from the side
            string actualText = text.Trim(charsToTrim); //text without the spaces from the side
            return actualText;
        }

        private void UploadImageInExistingAddress_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 14, FontStyle.Bold);
        }

        private void UploadImageInExistingAddress_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.Name, 12, FontStyle.Regular);
        }
    }
}