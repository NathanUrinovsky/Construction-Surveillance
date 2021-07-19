namespace EngineerClientUI
{
    partial class ReportDetails
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.nameAndEmailOfSenderInputLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectInputLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.contentInputBox = new System.Windows.Forms.RichTextBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.yourFilesTitle = new System.Windows.Forms.Label();
            this.mailDetailsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fromLabel.Location = new System.Drawing.Point(64, 114);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(50, 20);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // nameAndEmailOfSenderInputLabel
            // 
            this.nameAndEmailOfSenderInputLabel.AutoSize = true;
            this.nameAndEmailOfSenderInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameAndEmailOfSenderInputLabel.Location = new System.Drawing.Point(136, 114);
            this.nameAndEmailOfSenderInputLabel.Name = "nameAndEmailOfSenderInputLabel";
            this.nameAndEmailOfSenderInputLabel.Size = new System.Drawing.Size(51, 20);
            this.nameAndEmailOfSenderInputLabel.TabIndex = 1;
            this.nameAndEmailOfSenderInputLabel.Text = "label2";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.subjectLabel.Location = new System.Drawing.Point(64, 157);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(67, 20);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectInputLabel
            // 
            this.subjectInputLabel.AutoSize = true;
            this.subjectInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.subjectInputLabel.Location = new System.Drawing.Point(136, 157);
            this.subjectInputLabel.Name = "subjectInputLabel";
            this.subjectInputLabel.Size = new System.Drawing.Size(51, 20);
            this.subjectInputLabel.TabIndex = 3;
            this.subjectInputLabel.Text = "label4";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.contentLabel.Location = new System.Drawing.Point(64, 194);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(70, 20);
            this.contentLabel.TabIndex = 4;
            this.contentLabel.Text = "Content:";
            // 
            // contentInputBox
            // 
            this.contentInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.contentInputBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.contentInputBox.Location = new System.Drawing.Point(66, 227);
            this.contentInputBox.Name = "contentInputBox";
            this.contentInputBox.ReadOnly = true;
            this.contentInputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.contentInputBox.Size = new System.Drawing.Size(420, 175);
            this.contentInputBox.TabIndex = 6;
            this.contentInputBox.Text = "";
            // 
            // filesListBox
            // 
            this.filesListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 18;
            this.filesListBox.Location = new System.Drawing.Point(66, 464);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.ScrollAlwaysVisible = true;
            this.filesListBox.Size = new System.Drawing.Size(277, 94);
            this.filesListBox.TabIndex = 12;
            this.filesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilesListBox_MouseDoubleClick);
            // 
            // yourFilesTitle
            // 
            this.yourFilesTitle.AutoSize = true;
            this.yourFilesTitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourFilesTitle.Location = new System.Drawing.Point(63, 424);
            this.yourFilesTitle.Name = "yourFilesTitle";
            this.yourFilesTitle.Size = new System.Drawing.Size(69, 20);
            this.yourFilesTitle.TabIndex = 13;
            this.yourFilesTitle.Text = "Your files:";
            // 
            // mailDetailsTitle
            // 
            this.mailDetailsTitle.AutoSize = true;
            this.mailDetailsTitle.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailDetailsTitle.Location = new System.Drawing.Point(58, 42);
            this.mailDetailsTitle.Name = "mailDetailsTitle";
            this.mailDetailsTitle.Size = new System.Drawing.Size(332, 51);
            this.mailDetailsTitle.TabIndex = 14;
            this.mailDetailsTitle.Text = "Message Details";
            // 
            // ReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(673, 587);
            this.Controls.Add(this.mailDetailsTitle);
            this.Controls.Add(this.yourFilesTitle);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.contentInputBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.subjectInputLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.nameAndEmailOfSenderInputLabel);
            this.Controls.Add(this.fromLabel);
            this.Name = "ReportDetails";
            this.Text = "Mail Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportDetails_FormClosing);
            this.Load += new System.EventHandler(this.ReportDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label nameAndEmailOfSenderInputLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label subjectInputLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.RichTextBox contentInputBox;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label yourFilesTitle;
        private System.Windows.Forms.Label mailDetailsTitle;
    }
}