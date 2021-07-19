namespace EngineerClientUI
{
    partial class ProfileForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.supervisorNameLabel = new System.Windows.Forms.Label();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.emailInputLabel = new System.Windows.Forms.Label();
            this.idInputLabel = new System.Windows.Forms.Label();
            this.statusInputLabel = new System.Windows.Forms.Label();
            this.supervisorNameInputLabel = new System.Windows.Forms.Label();
            this.profileTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel.Location = new System.Drawing.Point(90, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idLabel.Location = new System.Drawing.Point(94, 272);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 24);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailLabel.Location = new System.Drawing.Point(94, 203);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 25);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statusLabel.Location = new System.Drawing.Point(162, 275);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 20);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "| Status:";
            // 
            // supervisorNameLabel
            // 
            this.supervisorNameLabel.AutoSize = true;
            this.supervisorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supervisorNameLabel.Location = new System.Drawing.Point(286, 276);
            this.supervisorNameLabel.Name = "supervisorNameLabel";
            this.supervisorNameLabel.Size = new System.Drawing.Size(143, 20);
            this.supervisorNameLabel.TabIndex = 4;
            this.supervisorNameLabel.Text = "| Supervisor Name:";
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameInputLabel.Location = new System.Drawing.Point(88, 160);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(93, 33);
            this.nameInputLabel.TabIndex = 5;
            this.nameInputLabel.Text = "label5";
            // 
            // emailInputLabel
            // 
            this.emailInputLabel.AutoSize = true;
            this.emailInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailInputLabel.Location = new System.Drawing.Point(92, 227);
            this.emailInputLabel.Name = "emailInputLabel";
            this.emailInputLabel.Size = new System.Drawing.Size(93, 33);
            this.emailInputLabel.TabIndex = 6;
            this.emailInputLabel.Text = "label1";
            // 
            // idInputLabel
            // 
            this.idInputLabel.AutoSize = true;
            this.idInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idInputLabel.Location = new System.Drawing.Point(129, 275);
            this.idInputLabel.Name = "idInputLabel";
            this.idInputLabel.Size = new System.Drawing.Size(27, 20);
            this.idInputLabel.TabIndex = 7;
            this.idInputLabel.Text = "30";
            // 
            // statusInputLabel
            // 
            this.statusInputLabel.AutoSize = true;
            this.statusInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statusInputLabel.Location = new System.Drawing.Point(228, 276);
            this.statusInputLabel.Name = "statusInputLabel";
            this.statusInputLabel.Size = new System.Drawing.Size(52, 20);
            this.statusInputLabel.TabIndex = 8;
            this.statusInputLabel.Text = "Active";
            // 
            // supervisorNameInputLabel
            // 
            this.supervisorNameInputLabel.AutoSize = true;
            this.supervisorNameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supervisorNameInputLabel.Location = new System.Drawing.Point(425, 276);
            this.supervisorNameInputLabel.Name = "supervisorNameInputLabel";
            this.supervisorNameInputLabel.Size = new System.Drawing.Size(92, 20);
            this.supervisorNameInputLabel.TabIndex = 9;
            this.supervisorNameInputLabel.Text = "some name";
            // 
            // profileTitle
            // 
            this.profileTitle.AutoSize = true;
            this.profileTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.profileTitle.Location = new System.Drawing.Point(87, 50);
            this.profileTitle.Name = "profileTitle";
            this.profileTitle.Size = new System.Drawing.Size(123, 42);
            this.profileTitle.TabIndex = 10;
            this.profileTitle.Text = "Profile";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(898, 539);
            this.Controls.Add(this.profileTitle);
            this.Controls.Add(this.supervisorNameInputLabel);
            this.Controls.Add(this.statusInputLabel);
            this.Controls.Add(this.idInputLabel);
            this.Controls.Add(this.emailInputLabel);
            this.Controls.Add(this.nameInputLabel);
            this.Controls.Add(this.supervisorNameLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label supervisorNameLabel;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Label emailInputLabel;
        private System.Windows.Forms.Label idInputLabel;
        private System.Windows.Forms.Label statusInputLabel;
        private System.Windows.Forms.Label supervisorNameInputLabel;
        private System.Windows.Forms.Label profileTitle;
    }
}