using System;
using System.Collections.Generic;
using DAL;

namespace BL
{
    public class AddressService
    {
        public AddressService()
        {

        }

        /// <summary>
        /// retrieving all the addresses stored in the system
        /// </summary>
        /// <returns></returns>
        public List<AddressData> RetrieveAllAddresses()
        {
            List<Address> addresses = AddressDAL.RetrieveAllAddresses(); //addresses from dal
            List<AddressData> addressesData = new List<AddressData>();
            //converting to addressData from BL
            foreach (var addresss in addresses)
            {
                AddressData addressData = new AddressData() { addressID = addresss.GetAddressID(), address = addresss.GetAddress().ToString() };
                addressesData.Add(addressData);
            }
            return addressesData;
        }

        /// <summary>
        /// adding an address that doesn't exist yet to the system
        /// </summary>
        /// <param name="address"></param>
        /// <returns>the data about the addressData or throws exception</returns>
        public AddressData AddAddress(string address)
        {
            if (string.IsNullOrEmpty(address) || AddressDAL.DoesAddressExist(address)) //if the address is not empty and it doesn't exist yet
            {
                throw new ArgumentException("invalid address details");
            }
            else
            {
                AddressDAL.AddNewAddress(address);
                int tempAddressID = AddressDAL.ReturnAddressIDInAddress(address);
                return new AddressData() {addressID=tempAddressID, address=address };
            }
        }

        /// <summary>
        /// returning whether an address exist or not
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool DoesAddressExist(string address)
        {
            return AddressDAL.DoesAddressExist(address);
        }
    }
}


