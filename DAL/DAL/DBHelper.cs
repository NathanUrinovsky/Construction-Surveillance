using System;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for DBHelper
/// this class manege the connection to the Data Base
/// it can return a query result or execute a query;
/// </summary>


public static class DBHelper
{
    private const string connectionstring = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                    @"Data Source = C:\Project\Data\FinalProjectDataBase.accdb;" +
                    @"Persist Security Info=False;";
    public static DataTable GetTableByName (string TableName)
    {
        OleDbConnection connection = GetConnectionToTheDB();
        if (connection == null)
            return null;
        string query = String.Format("select * from {0};", TableName);
        OleDbCommand command = new OleDbCommand(query, connection);
        OleDbDataAdapter d = new OleDbDataAdapter(command);
        DataSet ds = new DataSet();
        d.Fill(ds);
        connection.Close();
        return ds.Tables[0];
    }
    
    public static DataSet GetDataSet(string query)
    {
        OleDbConnection connection = GetConnectionToTheDB();
        if (connection == null)
            return null;

        OleDbCommand c = new OleDbCommand(query, connection);
        OleDbDataAdapter d = new OleDbDataAdapter(c);
        DataSet ds = new DataSet();
        d.Fill(ds);
        return ds;
    }

    /// <summary>
    /// return a data table frm the data base basen on an SQL query from the user
    /// </summary>
    /// <param name="query">an SQL QUERY</param>
    /// <returns>Data Table: one Data Table</returns>
    public static DataTable GetDataTable(string query)
    {
        try
        {
            OleDbConnection connection = GetConnectionToTheDB();
            if (connection == null)
                return null;

            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter d = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            d.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            //catch the error (if there is an error while connecting.
            return null;

        }
    }


   
    public static OleDbConnection GetConnectionToTheDB()
    {
        if (connectionstring == "")
        {
            return null;
        }

        OleDbConnection connection = new OleDbConnection();
        connection.ConnectionString = connectionstring;
        try
        {
            //open the connection to the data base
            connection.Open();
            return connection;

        }
        catch (Exception ex)
        {
            //catch the error (if there is an error while connecting.
            return null;

        }
    }

    public static int ExecuteNonQuery(string sql)
    {
        OleDbConnection connection = new OleDbConnection(connectionstring);
        OleDbCommand command = new OleDbCommand(sql, connection);
        connection.Open();
        int rowsAffected = command.ExecuteNonQuery();
        connection.Close();
        return rowsAffected;
    }
}
