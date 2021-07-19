namespace EngineerClientUI
{
    partial class DetectImagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressDropdownLabel = new System.Windows.Forms.Label();
            this.addressesDropdown = new System.Windows.Forms.ComboBox();
            this.lastImageBox = new System.Windows.Forms.PictureBox();
            this.detectedImageBoxInNewAddress = new System.Windows.Forms.PictureBox();
            this.toPermitListButton = new System.Windows.Forms.Button();
            this.newAddressLabel = new System.Windows.Forms.Label();
            this.newAddressTextBox = new System.Windows.Forms.TextBox();
            this.detectBothImagesButton = new System.Windows.Forms.Button();
            this.imageUpload = new System.Windows.Forms.OpenFileDialog();
            this.detectNewImage = new System.Windows.Forms.Button();
            this.detectInNewAddressOrExistingAddressTabControl = new System.Windows.Forms.TabControl();
            this.existingAddressTab = new System.Windows.Forms.TabPage();
            this.newImagePictureBoxPanel = new System.Windows.Forms.Panel();
            this.detectedImageBoxInExistingAddress = new System.Windows.Forms.PictureBox();
            this.existingImagePictureBoxPanel = new System.Windows.Forms.Panel();
            this.detectErrorLabel = new System.Windows.Forms.Label();
            this.standbylabelExAddress = new System.Windows.Forms.Label();
            this.uploadNewImageLabel = new System.Windows.Forms.Label();
            this.cancelExistingAddressButton = new System.Windows.Forms.Button();
            this.saveExistingAddressButton = new System.Windows.Forms.Button();
            this.UploadImageInExistingAddress = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.standbyNewAddressLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveNewAddressButton = new System.Windows.Forms.Button();
            this.UploadImageWithNewAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lastImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedImageBoxInNewAddress)).BeginInit();
            this.detectInNewAddressOrExistingAddressTabControl.SuspendLayout();
            this.existingAddressTab.SuspendLayout();
            this.newImagePictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detectedImageBoxInExistingAddress)).BeginInit();
            this.existingImagePictureBoxPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressDropdownLabel
            // 
            this.addressDropdownLabel.AutoSize = true;
            this.addressDropdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressDropdownLabel.Location = new System.Drawing.Point(112, 13);
            this.addressDropdownLabel.Name = "addressDropdownLabel";
            this.addressDropdownLabel.Size = new System.Drawing.Size(227, 20);
            this.addressDropdownLabel.TabIndex = 0;
            this.addressDropdownLabel.Text = "Select existing Image Address:";
            // 
            // addressesDropdown
            // 
            this.addressesDropdown.BackColor = System.Drawing.Color.White;
            this.addressesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressesDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressesDropdown.FormattingEnabled = true;
            this.addressesDropdown.Location = new System.Drawing.Point(116, 47);
            this.addressesDropdown.Name = "addressesDropdown";
            this.addressesDropdown.Size = new System.Drawing.Size(134, 28);
            this.addressesDropdown.TabIndex = 1;
            this.addressesDropdown.SelectionChangeCommitted += new System.EventHandler(this.AddressesDropdown_SelectionChangeCommitted);
            // 
            // lastImageBox
            // 
            this.lastImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastImageBox.Location = new System.Drawing.Point(82, 32);
            this.lastImageBox.Name = "lastImageBox";
            this.lastImageBox.Size = new System.Drawing.Size(300, 300);
            this.lastImageBox.TabIndex = 8;
            this.lastImageBox.TabStop = false;
            // 
            // detectedImageBoxInNewAddress
            // 
            this.detectedImageBoxInNewAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detectedImageBoxInNewAddress.Location = new System.Drawing.Point(556, 120);
            this.detectedImageBoxInNewAddress.Name = "detectedImageBoxInNewAddress";
            this.detectedImageBoxInNewAddress.Size = new System.Drawing.Size(300, 300);
            this.detectedImageBoxInNewAddress.TabIndex = 9;
            this.detectedImageBoxInNewAddress.TabStop = false;
            // 
            // toPermitListButton
            // 
            this.toPermitListButton.BackColor = System.Drawing.Color.White;
            this.toPermitListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toPermitListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.toPermitListButton.Location = new System.Drawing.Point(423, 608);
            this.toPermitListButton.Name = "toPermitListButton";
            this.toPermitListButton.Size = new System.Drawing.Size(340, 64);
            this.toPermitListButton.TabIndex = 10;
            this.toPermitListButton.Text = "Check the permits in the address you picked";
            this.toPermitListButton.UseVisualStyleBackColor = false;
            this.toPermitListButton.Click += new System.EventHandler(this.ToPermitListButton_Click);
            this.toPermitListButton.MouseLeave += new System.EventHandler(this.ToPermitListButton_MouseLeave);
            this.toPermitListButton.MouseHover += new System.EventHandler(this.ToPermitListButton_MouseHover);
            // 
            // newAddressLabel
            // 
            this.newAddressLabel.AutoSize = true;
            this.newAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newAddressLabel.Location = new System.Drawing.Point(32, 32);
            this.newAddressLabel.Name = "newAddressLabel";
            this.newAddressLabel.Size = new System.Drawing.Size(113, 20);
            this.newAddressLabel.TabIndex = 11;
            this.newAddressLabel.Text = "Enter address:";
            // 
            // newAddressTextBox
            // 
            this.newAddressTextBox.Location = new System.Drawing.Point(160, 26);
            this.newAddressTextBox.Name = "newAddressTextBox";
            this.newAddressTextBox.Size = new System.Drawing.Size(119, 26);
            this.newAddressTextBox.TabIndex = 12;
            this.newAddressTextBox.TextChanged += new System.EventHandler(this.NewAddressTextBox_TextChanged);
            // 
            // detectBothImagesButton
            // 
            this.detectBothImagesButton.BackColor = System.Drawing.Color.White;
            this.detectBothImagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.detectBothImagesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.detectBothImagesButton.Location = new System.Drawing.Point(116, 513);
            this.detectBothImagesButton.Name = "detectBothImagesButton";
            this.detectBothImagesButton.Size = new System.Drawing.Size(182, 65);
            this.detectBothImagesButton.TabIndex = 15;
            this.detectBothImagesButton.Text = "Detect";
            this.detectBothImagesButton.UseVisualStyleBackColor = false;
            this.detectBothImagesButton.Click += new System.EventHandler(this.DetectBothImagesButton_Click);
            this.detectBothImagesButton.MouseLeave += new System.EventHandler(this.DetectBothImagesButton_MouseLeave);
            this.detectBothImagesButton.MouseHover += new System.EventHandler(this.DetectBothImagesButton_MouseHover);
            // 
            // imageUpload
            // 
            this.imageUpload.FileName = "new file";
            // 
            // detectNewImage
            // 
            this.detectNewImage.BackColor = System.Drawing.Color.White;
            this.detectNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.detectNewImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.detectNewImage.Location = new System.Drawing.Point(36, 207);
            this.detectNewImage.Name = "detectNewImage";
            this.detectNewImage.Size = new System.Drawing.Size(243, 64);
            this.detectNewImage.TabIndex = 16;
            this.detectNewImage.Text = "Detect new Image";
            this.detectNewImage.UseVisualStyleBackColor = false;
            this.detectNewImage.Click += new System.EventHandler(this.DetectNewImage_Click);
            this.detectNewImage.MouseLeave += new System.EventHandler(this.DetectNewImage_MouseLeave);
            this.detectNewImage.MouseHover += new System.EventHandler(this.DetectNewImage_MouseHover);
            // 
            // detectInNewAddressOrExistingAddressTabControl
            // 
            this.detectInNewAddressOrExistingAddressTabControl.Controls.Add(this.existingAddressTab);
            this.detectInNewAddressOrExistingAddressTabControl.Controls.Add(this.tabPage2);
            this.detectInNewAddressOrExistingAddressTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detectInNewAddressOrExistingAddressTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.detectInNewAddressOrExistingAddressTabControl.Location = new System.Drawing.Point(0, 0);
            this.detectInNewAddressOrExistingAddressTabControl.Name = "detectInNewAddressOrExistingAddressTabControl";
            this.detectInNewAddressOrExistingAddressTabControl.SelectedIndex = 0;
            this.detectInNewAddressOrExistingAddressTabControl.Size = new System.Drawing.Size(1182, 713);
            this.detectInNewAddressOrExistingAddressTabControl.TabIndex = 20;
            // 
            // existingAddressTab
            // 
            this.existingAddressTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.existingAddressTab.Controls.Add(this.newImagePictureBoxPanel);
            this.existingAddressTab.Controls.Add(this.existingImagePictureBoxPanel);
            this.existingAddressTab.Controls.Add(this.detectErrorLabel);
            this.existingAddressTab.Controls.Add(this.standbylabelExAddress);
            this.existingAddressTab.Controls.Add(this.uploadNewImageLabel);
            this.existingAddressTab.Controls.Add(this.cancelExistingAddressButton);
            this.existingAddressTab.Controls.Add(this.saveExistingAddressButton);
            this.existingAddressTab.Controls.Add(this.UploadImageInExistingAddress);
            this.existingAddressTab.Controls.Add(this.addressesDropdown);
            this.existingAddressTab.Controls.Add(this.toPermitListButton);
            this.existingAddressTab.Controls.Add(this.detectBothImagesButton);
            this.existingAddressTab.Controls.Add(this.addressDropdownLabel);
            this.existingAddressTab.Location = new System.Drawing.Point(4, 29);
            this.existingAddressTab.Name = "existingAddressTab";
            this.existingAddressTab.Padding = new System.Windows.Forms.Padding(3);
            this.existingAddressTab.Size = new System.Drawing.Size(1174, 680);
            this.existingAddressTab.TabIndex = 0;
            this.existingAddressTab.Text = "Match existing analysis";
            // 
            // newImagePictureBoxPanel
            // 
            this.newImagePictureBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newImagePictureBoxPanel.Controls.Add(this.detectedImageBoxInExistingAddress);
            this.newImagePictureBoxPanel.Location = new System.Drawing.Point(618, 128);
            this.newImagePictureBoxPanel.Name = "newImagePictureBoxPanel";
            this.newImagePictureBoxPanel.Size = new System.Drawing.Size(466, 350);
            this.newImagePictureBoxPanel.TabIndex = 29;
            // 
            // detectedImageBoxInExistingAddress
            // 
            this.detectedImageBoxInExistingAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detectedImageBoxInExistingAddress.Location = new System.Drawing.Point(82, 32);
            this.detectedImageBoxInExistingAddress.Name = "detectedImageBoxInExistingAddress";
            this.detectedImageBoxInExistingAddress.Size = new System.Drawing.Size(300, 300);
            this.detectedImageBoxInExistingAddress.TabIndex = 21;
            this.detectedImageBoxInExistingAddress.TabStop = false;
            // 
            // existingImagePictureBoxPanel
            // 
            this.existingImagePictureBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.existingImagePictureBoxPanel.Controls.Add(this.lastImageBox);
            this.existingImagePictureBoxPanel.Location = new System.Drawing.Point(116, 128);
            this.existingImagePictureBoxPanel.Name = "existingImagePictureBoxPanel";
            this.existingImagePictureBoxPanel.Size = new System.Drawing.Size(466, 350);
            this.existingImagePictureBoxPanel.TabIndex = 28;
            // 
            // detectErrorLabel
            // 
            this.detectErrorLabel.AutoSize = true;
            this.detectErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.detectErrorLabel.Location = new System.Drawing.Point(34, 88);
            this.detectErrorLabel.Name = "detectErrorLabel";
            this.detectErrorLabel.Size = new System.Drawing.Size(51, 20);
            this.detectErrorLabel.TabIndex = 27;
            this.detectErrorLabel.Text = "label1";
            // 
            // standbylabelExAddress
            // 
            this.standbylabelExAddress.AutoSize = true;
            this.standbylabelExAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.standbylabelExAddress.Location = new System.Drawing.Point(23, 490);
            this.standbylabelExAddress.Name = "standbylabelExAddress";
            this.standbylabelExAddress.Size = new System.Drawing.Size(51, 20);
            this.standbylabelExAddress.TabIndex = 25;
            this.standbylabelExAddress.Text = "label1";
            // 
            // uploadNewImageLabel
            // 
            this.uploadNewImageLabel.AutoSize = true;
            this.uploadNewImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uploadNewImageLabel.Location = new System.Drawing.Point(946, 13);
            this.uploadNewImageLabel.Name = "uploadNewImageLabel";
            this.uploadNewImageLabel.Size = new System.Drawing.Size(157, 20);
            this.uploadNewImageLabel.TabIndex = 24;
            this.uploadNewImageLabel.Text = "Upload a new image:";
            // 
            // cancelExistingAddressButton
            // 
            this.cancelExistingAddressButton.BackColor = System.Drawing.Color.White;
            this.cancelExistingAddressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cancelExistingAddressButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.cancelExistingAddressButton.Location = new System.Drawing.Point(902, 513);
            this.cancelExistingAddressButton.Name = "cancelExistingAddressButton";
            this.cancelExistingAddressButton.Size = new System.Drawing.Size(182, 65);
            this.cancelExistingAddressButton.TabIndex = 23;
            this.cancelExistingAddressButton.Text = "Clear";
            this.cancelExistingAddressButton.UseVisualStyleBackColor = false;
            this.cancelExistingAddressButton.Click += new System.EventHandler(this.CancelExistingAddressButton_Click);
            this.cancelExistingAddressButton.MouseLeave += new System.EventHandler(this.CancelExistingAddressButton_MouseLeave);
            this.cancelExistingAddressButton.MouseHover += new System.EventHandler(this.CancelExistingAddressButton_MouseHover);
            // 
            // saveExistingAddressButton
            // 
            this.saveExistingAddressButton.BackColor = System.Drawing.Color.White;
            this.saveExistingAddressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveExistingAddressButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.saveExistingAddressButton.Location = new System.Drawing.Point(482, 513);
            this.saveExistingAddressButton.Name = "saveExistingAddressButton";
            this.saveExistingAddressButton.Size = new System.Drawing.Size(182, 65);
            this.saveExistingAddressButton.TabIndex = 22;
            this.saveExistingAddressButton.Text = "Save";
            this.saveExistingAddressButton.UseVisualStyleBackColor = false;
            this.saveExistingAddressButton.Click += new System.EventHandler(this.SaveExistingAddressButton_Click);
            this.saveExistingAddressButton.MouseLeave += new System.EventHandler(this.SaveExistingAddressButton_MouseLeave);
            this.saveExistingAddressButton.MouseHover += new System.EventHandler(this.SaveExistingAddressButton_MouseHover);
            // 
            // UploadImageInExistingAddress
            // 
            this.UploadImageInExistingAddress.AutoSize = true;
            this.UploadImageInExistingAddress.BackColor = System.Drawing.Color.White;
            this.UploadImageInExistingAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UploadImageInExistingAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.UploadImageInExistingAddress.Location = new System.Drawing.Point(950, 47);
            this.UploadImageInExistingAddress.Name = "UploadImageInExistingAddress";
            this.UploadImageInExistingAddress.Size = new System.Drawing.Size(134, 30);
            this.UploadImageInExistingAddress.TabIndex = 21;
            this.UploadImageInExistingAddress.Text = "Upload Image";
            this.UploadImageInExistingAddress.UseVisualStyleBackColor = false;
            this.UploadImageInExistingAddress.Click += new System.EventHandler(this.UploadImageInExistingAddress_Click);
            this.UploadImageInExistingAddress.MouseLeave += new System.EventHandler(this.UploadImageInExistingAddress_MouseLeave);
            this.UploadImageInExistingAddress.MouseHover += new System.EventHandler(this.UploadImageInExistingAddress_MouseHover);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.tabPage2.Controls.Add(this.errorLabel);
            this.tabPage2.Controls.Add(this.standbyNewAddressLabel);
            this.tabPage2.Controls.Add(this.cancelButton);
            this.tabPage2.Controls.Add(this.saveNewAddressButton);
            this.tabPage2.Controls.Add(this.UploadImageWithNewAddress);
            this.tabPage2.Controls.Add(this.detectedImageBoxInNewAddress);
            this.tabPage2.Controls.Add(this.detectNewImage);
            this.tabPage2.Controls.Add(this.newAddressLabel);
            this.tabPage2.Controls.Add(this.newAddressTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 680);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New analysis";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(32, 483);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(296, 20);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.Text = "Detection is not available at the moment.";
            // 
            // standbyNewAddressLabel
            // 
            this.standbyNewAddressLabel.AutoSize = true;
            this.standbyNewAddressLabel.Location = new System.Drawing.Point(32, 526);
            this.standbyNewAddressLabel.Name = "standbyNewAddressLabel";
            this.standbyNewAddressLabel.Size = new System.Drawing.Size(51, 20);
            this.standbyNewAddressLabel.TabIndex = 26;
            this.standbyNewAddressLabel.Text = "label1";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.cancelButton.Location = new System.Drawing.Point(36, 391);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(243, 66);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            this.cancelButton.MouseLeave += new System.EventHandler(this.CancelButton_MouseLeave);
            this.cancelButton.MouseHover += new System.EventHandler(this.CancelButton_MouseHover);
            // 
            // saveNewAddressButton
            // 
            this.saveNewAddressButton.BackColor = System.Drawing.Color.White;
            this.saveNewAddressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveNewAddressButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.saveNewAddressButton.Location = new System.Drawing.Point(36, 301);
            this.saveNewAddressButton.Name = "saveNewAddressButton";
            this.saveNewAddressButton.Size = new System.Drawing.Size(243, 66);
            this.saveNewAddressButton.TabIndex = 17;
            this.saveNewAddressButton.Text = "Save it, I am happy with it";
            this.saveNewAddressButton.UseVisualStyleBackColor = false;
            this.saveNewAddressButton.Click += new System.EventHandler(this.SaveNewAddressButton_Click);
            this.saveNewAddressButton.MouseLeave += new System.EventHandler(this.SaveNewAddressButton_MouseLeave);
            this.saveNewAddressButton.MouseHover += new System.EventHandler(this.SaveNewAddressButton_MouseHover);
            // 
            // UploadImageWithNewAddress
            // 
            this.UploadImageWithNewAddress.BackColor = System.Drawing.Color.White;
            this.UploadImageWithNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UploadImageWithNewAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.UploadImageWithNewAddress.Location = new System.Drawing.Point(36, 120);
            this.UploadImageWithNewAddress.Name = "UploadImageWithNewAddress";
            this.UploadImageWithNewAddress.Size = new System.Drawing.Size(243, 64);
            this.UploadImageWithNewAddress.TabIndex = 14;
            this.UploadImageWithNewAddress.Text = "Upload Image";
            this.UploadImageWithNewAddress.UseVisualStyleBackColor = false;
            this.UploadImageWithNewAddress.Click += new System.EventHandler(this.UploadImageWithNewAddress_Click);
            this.UploadImageWithNewAddress.MouseLeave += new System.EventHandler(this.UploadImageWithNewAddress_MouseLeave);
            this.UploadImageWithNewAddress.MouseHover += new System.EventHandler(this.UploadImageWithNewAddress_MouseHover);
            // 
            // DetectImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1182, 713);
            this.Controls.Add(this.detectInNewAddressOrExistingAddressTabControl);
            this.Name = "DetectImagesForm";
            this.Text = "Detect an image";
            this.Load += new System.EventHandler(this.DetectImagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lastImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedImageBoxInNewAddress)).EndInit();
            this.detectInNewAddressOrExistingAddressTabControl.ResumeLayout(false);
            this.existingAddressTab.ResumeLayout(false);
            this.existingAddressTab.PerformLayout();
            this.newImagePictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detectedImageBoxInExistingAddress)).EndInit();
            this.existingImagePictureBoxPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addressDropdownLabel;
        private System.Windows.Forms.ComboBox addressesDropdown;
        private System.Windows.Forms.PictureBox lastImageBox;
        private System.Windows.Forms.PictureBox detectedImageBoxInNewAddress;
        private System.Windows.Forms.Button toPermitListButton;
        private System.Windows.Forms.Label newAddressLabel;
        private System.Windows.Forms.TextBox newAddressTextBox;
        private System.Windows.Forms.Button detectBothImagesButton;
        private System.Windows.Forms.OpenFileDialog imageUpload;
        private System.Windows.Forms.Button detectNewImage;
        private System.Windows.Forms.TabControl detectInNewAddressOrExistingAddressTabControl;
        private System.Windows.Forms.TabPage existingAddressTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button UploadImageInExistingAddress;
        private System.Windows.Forms.PictureBox detectedImageBoxInExistingAddress;
        private System.Windows.Forms.Button saveExistingAddressButton;
        private System.Windows.Forms.Button saveNewAddressButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button UploadImageWithNewAddress;
        private System.Windows.Forms.Button cancelExistingAddressButton;
        private System.Windows.Forms.Label uploadNewImageLabel;
        private System.Windows.Forms.Label standbylabelExAddress;
        private System.Windows.Forms.Label standbyNewAddressLabel;
        private System.Windows.Forms.Label detectErrorLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel existingImagePictureBoxPanel;
        private System.Windows.Forms.Panel newImagePictureBoxPanel;
    }
}