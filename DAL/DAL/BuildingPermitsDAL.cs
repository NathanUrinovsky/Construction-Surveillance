using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    /// <summary>
    /// class for taking or updating data from the BuildingPermits table
    /// </summary>
    public static class BuildingPermitsDAL
    {
        /// <summary>
        /// returning all the buildings in a certain address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static List<Permit> SelectPermitsInAddress(int addressID)
        {
            List<Permit> permits = new List<Permit>(); 
            string sql = "SELECT BuildingPermits.PermitDescription, permitDate, EmpName " +
                "FROM BuildingPermits " +
                "INNER JOIN Employees ON BuildingPermits.permitIssuerID = Employees.EmpID " +
                "WHERE BuildingAddressID = " + addressID + ";";

            DataTable dataTable = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Permit permit = new Permit(); //new instance of permit

                //storing properties of permit in variables
                string permitName = dataTable.Rows[i][0].ToString();
                string dateTimePermit = dataTable.Rows[i][1].ToString();
                string permitIssuerID = dataTable.Rows[i][2].ToString();

                //assigning properties of permit
                permit.permitName = permitName;
                permit.permitDate = dateTimePermit;
                permit.permitIssuer = permitIssuerID;

                permits.Add(permit);
            }

            return permits; //list of permits that will be retrieved
        }

        /// <summary>
        /// Inserts a new building that has a permit with its address
        /// </summary>
        /// <param name="BuildingName"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        public static void InsertPermittedBuilding(string BuildingName, int addressID, int permitIssuerID)
        {
            string sql = "INSERT INTO BuildingPermits (PermitDescription, BuildingAddressID, permitDate, permitIssuerID) " +
            "VALUES ('" + BuildingName + "', '" + addressID + "', '" + DateTime.UtcNow.ToString("MM-dd-yyyy") + "', '" + permitIssuerID + "');";
            DBHelper.ExecuteNonQuery(sql);
        }
    }
}
