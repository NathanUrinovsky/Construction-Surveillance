namespace DAL
{
    public class Address
    {
        private int addressID;
        private string address;

        /// <summary>
        /// empty constructor
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// constructor with arguements
        /// </summary>
        public Address(int addressID, string address)
        {
            this.addressID = addressID;
            this.address = address;
        }

        //-----Getters-----
        public int GetAddressID()
        {
            return this.addressID;
        }

        public string GetAddress()
        {
            return this.address;
        }

        //-----Setters-----
        public void SetAddressID(int addressID)
        {
            this.addressID = addressID;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }
    }
}
