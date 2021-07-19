using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Data;
using BL;

namespace SupervisorClientUI
{
    public partial class ViewPermitsInAddressWebForm : System.Web.UI.Page
    {
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;
        private List<Permit> permitsInAddress;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsManagerValid())
            {
                SetProperties();
            }

            else
            {
                Response.Redirect("LoginWebForm.aspx");
            }

            if (!IsPostBack)
            {
                PopulateDropDown();
                SetInitialTable();
                Session[WebConstants.addressIDPermitViewString] = 0;
            }
        }

        /// <summary>
        /// returning wether the manager is valid or not
        /// </summary>
        /// <returns></returns>
        private bool IsManagerValid()
        {
            return (ProjectManager)Session[WebConstants.managerString] != null;
        }

        /// <summary>
        /// setting the properties of the page
        /// </summary>
        private void SetProperties()
        {
            this.projectManager = (ProjectManager)Session[WebConstants.managerString];
            this.authenticationData = (AuthenticationData)Session[WebConstants.authenticationDataString];
            this.permitsInAddress = new List<Permit>();
        }

        /// <summary>
        /// creating the table that is being set in the first visit of the page
        /// </summary>
        /// <returns></returns>
        private DataTable CreateInitialDataTable()
        {
            DataTable dataTable = new DataTable(); //data table
            DataColumn[] dataColumns = new DataColumn[3]; //columns of the data table

            //poplulating an array of data columns
            dataColumns[0] = new DataColumn("Description", Type.GetType("System.String"));
            dataColumns[1] = new DataColumn("Date", Type.GetType("System.String"));
            dataColumns[2] = new DataColumn("Issuer", Type.GetType("System.String"));
            dataTable.Columns.AddRange(dataColumns);

            return dataTable;
        }

        /// <summary>
        /// creating a gridview without content
        /// </summary>
        /// <param name="dataTable"></param>
        private void CreateClearGrid(DataTable dataTable)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = " ";
            dataRow[1] = " ";
            dataRow[2] = " ";
            dataTable.Rows.Add(dataRow);
        }

        /// <summary>
        /// creating a gridview with content
        /// </summary>
        /// <param name="dataTable"></param>
        private void CreateFilledGrid(DataTable dataTable)
        {
            DataRow dataRow;
            //populating the datagrid
            foreach (var permit in this.permitsInAddress)
            {
                dataRow = dataTable.NewRow();
                dataRow[0] = permit.permitName;
                dataRow[1] = permit.permitDate;
                dataRow[2] = permit.permitIssuer;
                dataTable.Rows.Add(dataRow);
            }
        }

        /// <summary>
        /// creatin the empty table that the users see in the first visit of the page
        /// </summary>
        private void SetInitialTable()
        { 
            DataTable dataTable = CreateInitialDataTable();
            CreateClearGrid(dataTable);

            this.permitGridView.DataSource = dataTable;
            this.permitGridView.DataBind();
        }

        /// <summary>
        /// populating the dropdown
        /// </summary>
        private void PopulateDropDown()
        {
            List<AddressData> addressDataList = this.projectManager.AddressDatasList(); //list of addresses
            AddressData addressData = new AddressData() { address = "pick an address", addressID = -1 }; //address of UI purposes
            //creating a list of all addresses and populating it
            List<AddressData> fullAddressData = new List<AddressData>();
            fullAddressData.Add(addressData);
            foreach (var item in addressDataList)
            {
                fullAddressData.Add(item);
            }
            //populating the dropdown
            foreach (var address in fullAddressData)
            {
                ListItem listItem = new ListItem(address.address, address.addressID.ToString());
                this.addressDropdown.Items.Add(listItem);
            }
        }

        protected void addressDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session[WebConstants.addressIDPermitViewString] = Convert.ToInt32(this.addressDropdown.SelectedItem.Value);
        }

        protected void viewPermitsButton_Click(object sender, EventArgs e)
        {
            if (!(GetSessionAddressID() == -1 || GetSessionAddressID() == 0)) //if the address id is not -1 or 0 (an id of an actual address)
            {
                GenerateGridView(GetSessionAddressID());
            }
        }

        /// <summary>
        /// generating and returning a gridview
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns></returns>
        private void GenerateGridView(int addressID)
        {
            this.permitsInAddress = this.projectManager.PermitsList(addressID); //list of permits
            DataTable dataTable = CreateInitialDataTable(); //empty datatable
            

            if (this.permitsInAddress.Count > 0) //if there are permits in the selected address
            {
                CreateFilledGrid(dataTable); //fill the gridview
            }

            else
            {
                CreateClearGrid(dataTable);
            }
            //populating the gridview
            this.permitGridView.DataSource = dataTable;
            this.permitGridView.DataBind();
        }
        //getting the address id from the session
        private int GetSessionAddressID()
        {
            return (int)Session[WebConstants.addressIDPermitViewString];
        }

        protected void permitGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //setting width for the columns
            e.Row.Cells[0].Width = new Unit("33%");
            e.Row.Cells[1].Width = new Unit("33%");
            e.Row.Cells[2].Width = new Unit("33%");
            
        }
    }
}