using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    /// <summary>
    /// class for taking or updating data from the addresses table
    /// </summary>
    public static class AddressDAL
    {
        /// <summary>
        /// adding a new address
        /// </summary>
        /// <param name="address"></param>
        public static void AddNewAddress(string address)
        {
            string sql = "INSERT INTO Addresses (AdressName)" +
                "VALUES('" + address + "');";
            DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// returns all the addresses
        /// </summary>
        /// <returns>list of addresses</returns>
        public static List<Address> RetrieveAllAddresses()
        {
            List<Address> addresses = new List<Address>(); //list of addresses that will be returned
            string sql = "SELECT * " +
                "FROM Addresses;";
            DataTable dataTable;
            dataTable = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Address address;
                address = new Address(Convert.ToInt32(dataTable.Rows[i][0].ToString()), dataTable.Rows[i][1].ToString());
                addresses.Add(address);
            }

            return addresses;
        }

        /// <summary>
        /// returns an address's ID of an address
        /// </summary>
        /// <param name="address"></param>
        /// <returns>the id of the address</returns>
        public static int ReturnAddressIDInAddress(string address)
        {
            string sql = "SELECT AddressID FROM Addresses " +
                "WHERE AdressName = '" + address + "';";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            int id = Convert.ToInt32(dataTable.Rows[0][0].ToString()); //address id that will be returned
            return id;
        }

        /// <summary>
        /// returning whether address exists
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static bool DoesAddressExist(string address)
        {
            string sql = "SELECT * FROM Addresses " +
                "WHERE AdressName = '" + address + "';";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            //if there are rows in the returned table, there is such address. otherwise, there isn't
            return dataTable.Rows.Count > 0;
        }
    }
}
