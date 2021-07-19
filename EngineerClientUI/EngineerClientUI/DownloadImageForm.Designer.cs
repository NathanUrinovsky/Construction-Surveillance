namespace EngineerClientUI
{
    partial class DownloadImageForm
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
            this.addressList = new System.Windows.Forms.ComboBox();
            this.datesList = new System.Windows.Forms.ComboBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.showImageButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.datesLabel = new System.Windows.Forms.Label();
            this.successlable = new System.Windows.Forms.Label();
            this.downloadorviewLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addressList
            // 
            this.addressList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressList.FormattingEnabled = true;
            this.addressList.Location = new System.Drawing.Point(479, 111);
            this.addressList.Name = "addressList";
            this.addressList.Size = new System.Drawing.Size(177, 26);
            this.addressList.TabIndex = 0;
            this.addressList.SelectionChangeCommitted += new System.EventHandler(this.AddressList_SelectionChangeCommitted);
            // 
            // datesList
            // 
            this.datesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datesList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.datesList.FormattingEnabled = true;
            this.datesList.Location = new System.Drawing.Point(479, 199);
            this.datesList.Name = "datesList";
            this.datesList.Size = new System.Drawing.Size(177, 26);
            this.datesList.TabIndex = 1;
            this.datesList.SelectionChangeCommitted += new System.EventHandler(this.DatesList_SelectionChangeCommitted);
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.White;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.downloadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.downloadButton.Location = new System.Drawing.Point(479, 677);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(177, 62);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            this.downloadButton.MouseLeave += new System.EventHandler(this.DownloadButton_MouseLeave);
            this.downloadButton.MouseHover += new System.EventHandler(this.DownloadButton_MouseHover);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox.Location = new System.Drawing.Point(424, 362);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(300, 300);
            this.ImagePictureBox.TabIndex = 3;
            this.ImagePictureBox.TabStop = false;
            // 
            // showImageButton
            // 
            this.showImageButton.BackColor = System.Drawing.Color.White;
            this.showImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.showImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.showImageButton.Location = new System.Drawing.Point(479, 252);
            this.showImageButton.Name = "showImageButton";
            this.showImageButton.Size = new System.Drawing.Size(177, 62);
            this.showImageButton.TabIndex = 4;
            this.showImageButton.Text = "Show Image";
            this.showImageButton.UseVisualStyleBackColor = false;
            this.showImageButton.Click += new System.EventHandler(this.ShowImageButton_Click);
            this.showImageButton.MouseLeave += new System.EventHandler(this.ShowImageButton_MouseLeave);
            this.showImageButton.MouseHover += new System.EventHandler(this.ShowImageButton_MouseHover);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressLabel.Location = new System.Drawing.Point(475, 72);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(125, 20);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Pick an address:";
            // 
            // datesLabel
            // 
            this.datesLabel.AutoSize = true;
            this.datesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.datesLabel.Location = new System.Drawing.Point(475, 161);
            this.datesLabel.Name = "datesLabel";
            this.datesLabel.Size = new System.Drawing.Size(162, 20);
            this.datesLabel.TabIndex = 6;
            this.datesLabel.Text = "Dates in this address:";
            // 
            // successlable
            // 
            this.successlable.AutoSize = true;
            this.successlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.successlable.Location = new System.Drawing.Point(465, 330);
            this.successlable.Name = "successlable";
            this.successlable.Size = new System.Drawing.Size(51, 20);
            this.successlable.TabIndex = 7;
            this.successlable.Text = "label1";
            // 
            // downloadorviewLabel
            // 
            this.downloadorviewLabel.AutoSize = true;
            this.downloadorviewLabel.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadorviewLabel.Location = new System.Drawing.Point(343, 9);
            this.downloadorviewLabel.Name = "downloadorviewLabel";
            this.downloadorviewLabel.Size = new System.Drawing.Size(502, 51);
            this.downloadorviewLabel.TabIndex = 8;
            this.downloadorviewLabel.Text = "Download or view images";
            // 
            // DownloadImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1137, 810);
            this.Controls.Add(this.downloadorviewLabel);
            this.Controls.Add(this.successlable);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.showImageButton);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.datesList);
            this.Controls.Add(this.addressList);
            this.Name = "DownloadImageForm";
            this.Text = "Download or view an image";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addressList;
        private System.Windows.Forms.ComboBox datesList;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button showImageButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.Label successlable;
        private System.Windows.Forms.Label downloadorviewLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}