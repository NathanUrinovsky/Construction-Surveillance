using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using BL;

namespace SupervisorClientUI
{
    public partial class AddPermitWebForm : System.Web.UI.Page
    {
        private ProjectManager projectManager;
        private AuthenticationData authenticationData;

        public AddPermitWebForm()
        {
            
        }

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
                Session[WebConstants.addressIDstring] = 0;
            }

            
        }

        /// <summary>
        /// returningn wether manager is valid
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
        }

        protected void addressDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
           Session[WebConstants.addressIDstring] = Convert.ToInt32(this.addressDropDown.SelectedItem.Value);
        }


        /// <summary>
        /// populating the dropdown
        /// </summary>
        private void PopulateDropDown()
        {
            List<AddressData> addressDataList = this.projectManager.AddressDatasList(); //list of the addresses
            AddressData addressData = new AddressData() { address = "pick an address", addressID = -1 }; //address for UI purposes
            List<AddressData> fullAddressData = new List<AddressData>();
            fullAddressData.Add(addressData);
            //creating the full list of the addresses
            foreach (var item in addressDataList)
            {
                fullAddressData.Add(item);
            }

            foreach (var address in fullAddressData)
            {
                //populating the dropdown
                ListItem listItem = new ListItem(address.address, address.addressID.ToString());
                this.addressDropDown.Items.Add(listItem);
            }
        }

        protected void addPermitButton_Click(object sender, EventArgs e)
        {
            if (AreDetailsValid())
            {
                try
                {
                    SavePermit();
                    Clear();
                    this.addingPermitSuccessLabel.Text = "permit saved successfully!";
                }
                catch (Exception)
                {
                    this.addingPermitSuccessLabel.Text = "Couldn't add permit. Check you've filled everything correctly";
                }
                
            }

            else
            {
                this.addingPermitSuccessLabel.Text = "Couldn't add permit. Check you've filled everything correctly";
            }
        }

        /// <summary>
        /// returning wether the details of the permit the user wants to add are valid
        /// </summary>
        /// <returns></returns>
        private bool AreDetailsValid()
        {
            //is addressID is not 0 or -1, and the permit after trimming is not empty
            return (GetSessionAddressID() != 0) && (GetSessionAddressID() != -1);
        }

        /// <summary>
        /// saving the newly added permit
        /// </summary>
        private void SavePermit()
        {
            //char[] charsToTrim = { ' ' }; //characters that need to be trimmed
            this.projectManager.SavePermit(this.permitNameValueTextBox.Text, GetSessionAddressID(), this.authenticationData.GetEmpID());
        }

        protected void addressDropDown_TextChanged(object sender, EventArgs e)
        {
            this.addingPermitSuccessLabel.Text = string.Empty;
        }

        protected void clearingButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// clearing properties in the whole page
        /// </summary>
        private void Clear()
        {
            this.addingPermitSuccessLabel.Text = string.Empty;
            this.permitNameValueTextBox.Text = string.Empty;
            this.addressDropDown.SelectedIndex = 0;
            Session[WebConstants.addressIDstring] = -1;
        }

        /// <summary>
        /// returning the session's addressid value
        /// </summary>
        /// <returns></returns>
        private int GetSessionAddressID()
        {
            return (int)Session[WebConstants.addressIDstring];
        }
    }
}