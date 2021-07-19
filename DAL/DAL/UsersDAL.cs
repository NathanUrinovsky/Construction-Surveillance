using System;
using System.Data;

namespace DAL
{
    /// <summary>
    /// class for taking or updating data from the users table
    /// </summary>
    public static class UsersDAL
    {
        /// <summary>
        /// execute validation of user's credentials.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static User AuthenticateUser(string username, string password, int roleID)
        {                                       
            User user = RetrieveAuthenticatedUser(username, password, roleID);
            return user;
        }

        /// <summary>
        /// adding details of a user to the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="roleID"></param>
        public static void RegisterUser(string username, string password, string email, int roleID)
        {
            string sql = "INSERT INTO Users (dbPassword, RoleID, dbUsername, email, StatusID) " +
                "VALUES ('" + password + "', '" + roleID + "', '" + username + "', '" + email + "', " + (int)Status.Active + ");";
                DBHelper.ExecuteNonQuery(sql);
        }


        /// <summary>
        /// checks if user exists in database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns>whether user exists or not</returns>
        public static bool DoesUserExist(string username, string email)
        {
                string sql = "SELECT ID FROM Users " +
                    "WHERE dbUsername = '" + username + "' OR email = '" + email + "';";
                DataTable dataTable = DBHelper.GetDataTable(sql);
            
            return dataTable.Rows.Count > 0;
        }

        /// <summary>
        /// changes the password of the user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        public static void ChangeUserPassword(string username, string oldPassword, string newPassword)
        {
            string sql = "UPDATE Users " +
                "SET dbPassword = '" + newPassword + "' " +
                "WHERE dbUsername = '" + username + "' AND dbPassword = '" + oldPassword + "';";

            int rowsAffectd = DBHelper.ExecuteNonQuery(sql);

            if (rowsAffectd != 1)
            {
                throw new ArgumentException("Invalid arguments");
            }
        }

        /// <summary>
        /// retrieving user with a certain username and a password, used for the login.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User RetrieveAuthenticatedUser(string username, string password, int roleID)
        {
            User user;
            string sql = "SELECT RoleID, email, StatusID " +
                "FROM Users " +
                "WHERE dbUsername = '" + username + "' AND dbPassword = '" + password + "' AND StatusID = " + (int)Status.Active + " AND RoleID = " + roleID + ";";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            //if the retrieved table doesn't have rows, it means there is not such user with the exact information that was given
            //and so an empty user is retrieved
            if (dataTable.Rows.Count <= 0) 
            {
                user = new User();
            }

            else
            {
                Status status = (Status)Convert.ToInt32(dataTable.Rows[0][2].ToString());
                user = new User(roleID, username, dataTable.Rows[0][1].ToString(), status);
            }

            return user;
        } 

        /// <summary>
        /// changing the status of the engineer (either activating their accout or deactivating)
        /// </summary>
        /// <param name="email"></param>
        public static void ChangeUserStatus(string email, Status status)
        {
            string sql = "UPDATE Users " +
                "SET StatusID = " + (int)status + " " +
                "WHERE email = '" + email + "';";
            DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// retrieving user for general purposes
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static User RetrieveUser(string username) //there can be no duplicates of username, therefore we can retrieve user by only username
        {
            User user;
            string sql = "SELECT RoleID, email, StatusID " +
                "FROM Users " +
                "WHERE dbUsername = '" + username + "';";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable.Rows.Count == 0)
            {
                user = new User();
            }
            else
            {
                int roleID = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                Status status = (Status)Convert.ToInt32(dataTable.Rows[0][2].ToString());
                user = new User(roleID, username, dataTable.Rows[0][1].ToString(), status);
            }
            return user;
        }
    }
}


