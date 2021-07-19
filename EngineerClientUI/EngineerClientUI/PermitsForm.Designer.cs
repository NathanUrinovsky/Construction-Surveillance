namespace EngineerClientUI
{
    partial class PermitsForm
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressInputLabel = new System.Windows.Forms.Label();
            this.permitsTitle = new System.Windows.Forms.Label();
            this.permitsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.permitsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressLabel.Location = new System.Drawing.Point(80, 102);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(97, 25);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address:";
            // 
            // addressInputLabel
            // 
            this.addressInputLabel.AutoSize = true;
            this.addressInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressInputLabel.Location = new System.Drawing.Point(183, 102);
            this.addressInputLabel.Name = "addressInputLabel";
            this.addressInputLabel.Size = new System.Drawing.Size(70, 25);
            this.addressInputLabel.TabIndex = 1;
            this.addressInputLabel.Text = "label2";
            // 
            // permitsTitle
            // 
            this.permitsTitle.AutoSize = true;
            this.permitsTitle.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitsTitle.Location = new System.Drawing.Point(78, 37);
            this.permitsTitle.Name = "permitsTitle";
            this.permitsTitle.Size = new System.Drawing.Size(168, 51);
            this.permitsTitle.TabIndex = 4;
            this.permitsTitle.Text = "Permits";
            // 
            // permitsGridView
            // 
            this.permitsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.permitsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.permitsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.permitsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.permitsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.permitsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.permitsGridView.Location = new System.Drawing.Point(85, 154);
            this.permitsGridView.Name = "permitsGridView";
            this.permitsGridView.ReadOnly = true;
            this.permitsGridView.Size = new System.Drawing.Size(604, 239);
            this.permitsGridView.TabIndex = 5;
            // 
            // PermitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(182)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.permitsGridView);
            this.Controls.Add(this.permitsTitle);
            this.Controls.Add(this.addressInputLabel);
            this.Controls.Add(this.addressLabel);
            this.Name = "PermitsForm";
            this.Text = "Permits";
            this.Load += new System.EventHandler(this.PermitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permitsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label addressInputLabel;
        private System.Windows.Forms.Label permitsTitle;
        private System.Windows.Forms.DataGridView permitsGridView;
    }
}