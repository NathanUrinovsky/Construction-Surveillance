using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    /// <summary>
    /// class for taking or updating data from the Employees table
    /// </summary>
    public static class EmployeesDAL
    {

        /// <summary>
        /// registering employee in database
        /// </summary>
        /// <param name="supervisorName"></param>
        /// <param name="empName"></param>
        /// <param name="email"></param>
        /// <param name="roleID"></param>
        public static void RegisterEmployee(string empName, string email, int roleID, int supervisorID)
        {
            string sql = "INSERT INTO Employees (RoleID, SupervisorID, EmpName, Email) " + 
                "VALUES (" + roleID + ", " + supervisorID + ", '" + empName + "', '" + email +"');";
            DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// retreiving employee's details with a certain email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Employee RetrieveEmployee(string email)
        {
            Employee emp = new Employee(); //new instance of employee
            string sql = "SELECT ENG.EmpID, ENG.EmpName, SUP.EmpName, SUP.Email " +
                "FROM Employees ENG " +
                "INNER JOIN Employees SUP ON ENG.SupervisorID = SUP.EmpID " +
                "WHERE ENG.Email = '" + email + "';";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            //if the newly retrieved table doesn't have any rows, it means that an employee with the given email does not exist
            if (dataTable.Rows.Count == 0)
            {
                return emp; //returning the empty employee
            }
            
            //otherwise, we will take all the values of the retrieved table and store them in variables
            int id = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            string empName = dataTable.Rows[0][1].ToString();
            string supName = dataTable.Rows[0][2].ToString();
            string supEmail = dataTable.Rows[0][3].ToString();

            //set all of them is the instance of employee, and return it
            emp.SetID(id);
            emp.SetName(empName);
            emp.SetEmail(email);
            emp.SetSupervisorName(supName);
            emp.SetSupervisorEmail(supEmail);
            
            return emp;
        } 

        /// <summary>
        /// retieving employee's name based on their email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string RetrieveEmployeeNameByEmail(string email)
        {
            string sql = "SELECT EmpName " + "FROM Employees " +
                "WHERE Email = '" + email + "';";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            string empName = dataTable.Rows[0][0].ToString();
            return empName;
        }

        /// <summary>
        /// retrieving a list with the names of all the engineers in the system that work under a certain supervisor
        /// </summary>
        /// <returns></returns>
        public static List<string> RetrieveAllEngineersOfSupervisor(int supervisorID)
        {
            string sql = "SELECT EmpName FROM Employees " + "" +
                "WHERE SupervisorID = " + supervisorID + ";";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            List<string> engineers = new List<string>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                engineers.Add(dataTable.Rows[i][0].ToString());
            }
            return engineers;
        }

        /// <summary>
        /// retrieving all the employees by roleID (either all the engineers or all supervisors)
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public static List<Employee> RetrieveEmployees(int roleID)
        {
            List<Employee> employees = new List<Employee>(); //new instance of employee
            string sql = "SELECT ENG.EmpID, ENG.EmpName, ENG.email, SUP.EmpName, SUP.Email " +
                "FROM Employees ENG " +
                "INNER JOIN Employees SUP ON ENG.SupervisorID = SUP.EmpID " +
                "WHERE ENG.RoleID = " + roleID + ";";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //properties of employee
                int empID = Convert.ToInt32(dataTable.Rows[i][0].ToString());
                string empName = dataTable.Rows[i][1].ToString();
                string empEmail = dataTable.Rows[i][2].ToString();
                string supName = dataTable.Rows[i][3].ToString();
                string supEmail = dataTable.Rows[i][4].ToString();
                Employee employee = new Employee(empID, empName, empEmail, supName, supEmail);
                employees.Add(employee);
            }

            return employees;
        }

        /// <summary>
        /// retrieving the id of a user with the email that was given as an arguement
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static int RetrieveEmployeeIDByEmail(string email)
        {
            string sql = "SELECT EmpID FROM Employees " +
                "WHERE Email = '" + email + "';";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable.Rows.Count < 0) //if the table doesn't have rows, it means there are no employees with that email
            {
                throw new ArgumentException("invalid addressee");
            }
            else
            {
                int id = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                return id;
            }
        }


        /// <summary>
        /// this method validates the supervisor of an engineer
        /// </summary>
        /// <param name="engID"></param>
        /// <param name="supID"></param>
        /// <returns>returns whether a certain engineer works under a certain supervisor</returns>
        public static bool MatchSupervisorAndEngineer(int engID, int supID)
        {
            string sql = "SELECT SupervisorID FROM Employees " +
                "WHERE EmpID = " + engID + ";";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            int supervisorID = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            if (supervisorID == supID)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// retrieving a list with the data about all the engineers with a specific supervisor
        /// </summary>
        /// <param name="supervisorID"></param>
        /// <returns>list of engineers with the data about all the engineers with a specific supervisor</returns>
        public static List<Engineer> ReturnEngineersOfSupervisor(int supervisorID)
        {
            //empty instance of engineer and list of engineers
            Engineer engineer;
            List<Engineer> engineers = new List<Engineer>();
            string sql = "SELECT Employees.EmpID, Employees.EmpName, Users.StatusID,Employees.Email " +
                "FROM Employees " +
                "INNER JOIN Users ON Employees.Email = Users.email " +
                "WHERE SupervisorID = " + supervisorID + ";";

            DataTable dataTable = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //taking the data from the table and storing it in variables
                int engID = Convert.ToInt32(dataTable.Rows[i][0].ToString());
                string engName = dataTable.Rows[i][1].ToString();
                Status status = (Status)Convert.ToInt32(dataTable.Rows[i][2].ToString()); //converting to status
                string engMail = dataTable.Rows[i][3].ToString();
                engineer = new Engineer(engID, engName, status, engMail);
                engineers.Add(engineer);
            }

            return engineers;
        }
    }
}
