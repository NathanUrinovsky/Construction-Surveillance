namespace EngineerClientUI
{
    partial class AllReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.youDontHaveReportLabel = new System.Windows.Forms.Label();
            this.allReportSentToYouTitle = new System.Windows.Forms.Label();
            this.reportsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // youDontHaveReportLabel
            // 
            this.youDontHaveReportLabel.AutoSize = true;
            this.youDontHaveReportLabel.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youDontHaveReportLabel.Location = new System.Drawing.Point(336, 62);
            this.youDontHaveReportLabel.Name = "youDontHaveReportLabel";
            this.youDontHaveReportLabel.Size = new System.Drawing.Size(466, 39);
            this.youDontHaveReportLabel.TabIndex = 0;
            this.youDontHaveReportLabel.Text = "You don\'t have any messages yet";
            // 
            // allReportSentToYouTitle
            // 
            this.allReportSentToYouTitle.AutoSize = true;
            this.allReportSentToYouTitle.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allReportSentToYouTitle.Location = new System.Drawing.Point(325, 62);
            this.allReportSentToYouTitle.Name = "allReportSentToYouTitle";
            this.allReportSentToYouTitle.Size = new System.Drawing.Size(486, 51);
            this.allReportSentToYouTitle.TabIndex = 2;
            this.allReportSentToYouTitle.Text = "All messages sent to you ";
            // 
            // reportsGridView
            // 
            this.reportsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.reportsGridView.GridColor = System.Drawing.Color.Black;
            this.reportsGridView.Location = new System.Drawing.Point(79, 170);
            this.reportsGridView.Name = "reportsGridView";
            this.reportsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportsGridView.Size = new System.Drawing.Size(1030, 429);
            this.reportsGridView.TabIndex = 3;
            this.reportsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportsGridView_CellClick);
            this.reportsGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportsGridView_CellMouseLeave);
            this.reportsGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ReportsGridView_CellMouseMove);
            // 
            // AllReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1197, 687);
            this.Controls.Add(this.reportsGridView);
            this.Controls.Add(this.allReportSentToYouTitle);
            this.Controls.Add(this.youDontHaveReportLabel);
            this.Name = "AllReportsForm";
            this.Text = "All Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllReportsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label youDontHaveReportLabel;
        private System.Windows.Forms.Label allReportSentToYouTitle;
        private System.Windows.Forms.DataGridView reportsGridView;
    }
}