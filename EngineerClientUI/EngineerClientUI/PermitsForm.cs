using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BL;

namespace EngineerClientUI
{
    public partial class PermitsForm : Form
    {
        private AddressData address;
        private ProjectManager projectManager;
        private List<Permit> permits;
        public PermitsForm(AddressData address, ProjectManager projectManager)
        {
            InitializeComponent();
            SetProperties(address, projectManager);
        }

        /// <summary>
        /// setting the prope
        /// </summary>
        /// <param name="address"></param>
        /// <param name="projectManager"></param>
        private void SetProperties(AddressData address, ProjectManager projectManager)
        {
            this.address = address;
            this.projectManager = projectManager;
        }

        private void PermitsForm_Load(object sender, EventArgs e)
        {
            StorePermits();
            GenerateGridView();
        }

        /// <summary>
        /// storing the permits in a list
        /// </summary>
        private void StorePermits()
        {
            this.addressInputLabel.Text = this.address.address;
            int addressID = this.address.addressID;
            this.permits = this.projectManager.PermitsList(addressID); //permits from address
        }


        /// <summary>
        /// generating the table with the permits
        /// </summary>
        private void GenerateGridView()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3];

            //creating an array of data columns
            dataColumns[0] = new DataColumn("Description", typeof(string));
            dataColumns[1] = new DataColumn("Date", typeof(string));
            dataColumns[2] = new DataColumn("Issuer", typeof(string));

            dataTable.Columns.AddRange(dataColumns);
            DataRow dataRow;

            foreach (var permit in this.permits)
            {
                dataRow = dataTable.NewRow();
                dataRow[0] = permit.permitName;
                dataRow[1] = permit.permitDate;
                dataRow[2] = permit.permitIssuer;
                dataTable.Rows.Add(dataRow);
            }

            this.permitsGridView.DataSource = dataTable;
        }
    }
}
