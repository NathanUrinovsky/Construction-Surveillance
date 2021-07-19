namespace EngineerClientUI
{
    partial class SendReportForm
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
            this.emailToLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.addresseeEmailTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.uploadFilesButton = new System.Windows.Forms.Button();
            this.sendReportButton = new System.Windows.Forms.Button();
            this.backToDetectImagesButton = new System.Windows.Forms.Button();
            this.sendingStatusLabel = new System.Windows.Forms.Label();
            this.uploadFile = new System.Windows.Forms.OpenFileDialog();
            this.uploadedFilesNames = new System.Windows.Forms.Label();
            this.sendReportTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailToLabel
            // 
            this.emailToLabel.AutoSize = true;
            this.emailToLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailToLabel.Location = new System.Drawing.Point(49, 58);
            this.emailToLabel.Name = "emailToLabel";
            this.emailToLabel.Size = new System.Drawing.Size(29, 19);
            this.emailToLabel.TabIndex = 0;
            this.emailToLabel.Text = "To:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(49, 112);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(64, 19);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subject:";
            // 
            // addresseeEmailTextBox
            // 
            this.addresseeEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addresseeEmailTextBox.Location = new System.Drawing.Point(50, 80);
            this.addresseeEmailTextBox.Name = "addresseeEmailTextBox";
            this.addresseeEmailTextBox.Size = new System.Drawing.Size(150, 22);
            this.addresseeEmailTextBox.TabIndex = 2;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.subjectTextBox.Location = new System.Drawing.Point(50, 143);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(150, 22);
            this.subjectTextBox.TabIndex = 3;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLabel.Location = new System.Drawing.Point(46, 175);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(71, 19);
            this.contentLabel.TabIndex = 4;
            this.contentLabel.Text = "Content:";
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.contentRichTextBox.Location = new System.Drawing.Point(50, 207);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(692, 213);
            this.contentRichTextBox.TabIndex = 5;
            this.contentRichTextBox.Text = "";
            // 
            // uploadFilesButton
            // 
            this.uploadFilesButton.BackColor = System.Drawing.Color.White;
            this.uploadFilesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uploadFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uploadFilesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.uploadFilesButton.Location = new System.Drawing.Point(50, 455);
            this.uploadFilesButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadFilesButton.Name = "uploadFilesButton";
            this.uploadFilesButton.Size = new System.Drawing.Size(137, 59);
            this.uploadFilesButton.TabIndex = 6;
            this.uploadFilesButton.Text = "Upload file";
            this.uploadFilesButton.UseVisualStyleBackColor = false;
            this.uploadFilesButton.Click += new System.EventHandler(this.UploadFilesButton_Click);
            this.uploadFilesButton.MouseLeave += new System.EventHandler(this.UploadFilesButton_MouseLeave);
            this.uploadFilesButton.MouseHover += new System.EventHandler(this.UploadFilesButton_MouseHover);
            // 
            // sendReportButton
            // 
            this.sendReportButton.BackColor = System.Drawing.Color.White;
            this.sendReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sendReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.sendReportButton.Location = new System.Drawing.Point(50, 530);
            this.sendReportButton.Name = "sendReportButton";
            this.sendReportButton.Size = new System.Drawing.Size(137, 59);
            this.sendReportButton.TabIndex = 7;
            this.sendReportButton.Text = "Send Report";
            this.sendReportButton.UseVisualStyleBackColor = false;
            this.sendReportButton.Click += new System.EventHandler(this.SendReportButton_Click);
            this.sendReportButton.MouseLeave += new System.EventHandler(this.SendReportButton_MouseLeave);
            this.sendReportButton.MouseHover += new System.EventHandler(this.SendReportButton_MouseHover);
            // 
            // backToDetectImagesButton
            // 
            this.backToDetectImagesButton.BackColor = System.Drawing.Color.White;
            this.backToDetectImagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backToDetectImagesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(158)))));
            this.backToDetectImagesButton.Location = new System.Drawing.Point(218, 530);
            this.backToDetectImagesButton.Name = "backToDetectImagesButton";
            this.backToDetectImagesButton.Size = new System.Drawing.Size(137, 59);
            this.backToDetectImagesButton.TabIndex = 8;
            this.backToDetectImagesButton.Text = "Clear all";
            this.backToDetectImagesButton.UseVisualStyleBackColor = false;
            this.backToDetectImagesButton.Click += new System.EventHandler(this.BackToDetectImagesButton_Click);
            this.backToDetectImagesButton.MouseLeave += new System.EventHandler(this.BackToDetectImagesButton_MouseLeave);
            this.backToDetectImagesButton.MouseHover += new System.EventHandler(this.BackToDetectImagesButton_MouseHover);
            // 
            // sendingStatusLabel
            // 
            this.sendingStatusLabel.AutoSize = true;
            this.sendingStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sendingStatusLabel.Location = new System.Drawing.Point(49, 614);
            this.sendingStatusLabel.Name = "sendingStatusLabel";
            this.sendingStatusLabel.Size = new System.Drawing.Size(0, 20);
            this.sendingStatusLabel.TabIndex = 9;
            // 
            // uploadFile
            // 
            this.uploadFile.FileName = "new file";
            // 
            // uploadedFilesNames
            // 
            this.uploadedFilesNames.AutoSize = true;
            this.uploadedFilesNames.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadedFilesNames.Location = new System.Drawing.Point(205, 495);
            this.uploadedFilesNames.Name = "uploadedFilesNames";
            this.uploadedFilesNames.Size = new System.Drawing.Size(113, 19);
            this.uploadedFilesNames.TabIndex = 10;
            this.uploadedFilesNames.Text = "Files uploaded:";
            // 
            // sendReportTitle
            // 
            this.sendReportTitle.AutoSize = true;
            this.sendReportTitle.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendReportTitle.Location = new System.Drawing.Point(299, 9);
            this.sendReportTitle.Name = "sendReportTitle";
            this.sendReportTitle.Size = new System.Drawing.Size(275, 51);
            this.sendReportTitle.TabIndex = 11;
            this.sendReportTitle.Text = "Send a report";
            // 
            // SendReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1101, 656);
            this.Controls.Add(this.sendReportTitle);
            this.Controls.Add(this.uploadedFilesNames);
            this.Controls.Add(this.sendingStatusLabel);
            this.Controls.Add(this.backToDetectImagesButton);
            this.Controls.Add(this.sendReportButton);
            this.Controls.Add(this.uploadFilesButton);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.addresseeEmailTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.emailToLabel);
            this.Name = "SendReportForm";
            this.Text = "SendReportForm";
            this.Load += new System.EventHandler(this.SendReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailToLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox addresseeEmailTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button uploadFilesButton;
        private System.Windows.Forms.Button sendReportButton;
        private System.Windows.Forms.Button backToDetectImagesButton;
        private System.Windows.Forms.Label sendingStatusLabel;
        private System.Windows.Forms.OpenFileDialog uploadFile;
        private System.Windows.Forms.Label uploadedFilesNames;
        private System.Windows.Forms.Label sendReportTitle;
    }
}