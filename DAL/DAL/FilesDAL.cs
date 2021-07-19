namespace DAL
{
    /// <summary>
    /// class for taking or updating data from the files table
    /// </summary>
    public static class FilesDAL
    {
        /// <summary>
        /// inserting a path of a file of a certain report to the database
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="reportID"></param>
        public static void InsertFilePath(string newFilePath, int reportID)
        {
            string sql = "INSERT INTO Files (filePath, reportID) " +
                "VALUES ('" + newFilePath + "', " + reportID + ");";
            DBHelper.ExecuteNonQuery(sql);
        }
    }
}
