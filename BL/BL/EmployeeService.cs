using System.Collections.Generic;
using DAL;

namespace BL
{
    public class EmployeeService
    {
        private int supervisorID;
        public EmployeeService()
        {
            this.supervisorID = Roles.supervisor;
        }

        /// <summary>
        /// registering a new Employee
        /// </summary>
        public void RegisterEmployee(string empName, string email, int empSupervisorID, int roleID)
        {
           EmployeesDAL.RegisterEmployee(empName, email, roleID, empSupervisorID);
        }

        /// <summary>
        /// retrieving a list with all the name of existing supervisors
        /// </summary>
        /// <returns></returns>
        public List<EmployeeData> retrieveSupervisorsList()
        {
            List<Employee> supervisorsDAL = EmployeesDAL.RetrieveEmployees(this.supervisorID); //supervisors from dal
            List<EmployeeData> supervisors = new List<EmployeeData>();
            //converting to a list of employeeData
            foreach (var supervisor in supervisorsDAL)
            {
                EmployeeData superviosrBL = new EmployeeData() { empID = supervisor.GetID(), empName = supervisor.GetName(), empEmail = supervisor.GetEmail(), supervisorName = supervisor.GetSupervisorName(), supervisorEmail = supervisor.GetSupervisorEmail() };
                supervisors.Add(superviosrBL);
            }
            return supervisors;
        }

        /// <summary>
        /// retrieving a list with all the names of the engineers
        /// </summary>
        /// <returns></returns>
        public List<Engineer> retrieveEngineersOfSupervisorList(int supervisorID)
        {
            List<DAL.Engineer> engineersDAL = EmployeesDAL.ReturnEngineersOfSupervisor(supervisorID); //engineers from dal
            List<Engineer> engineers = new List<Engineer>();
            //converting to engineers of bl
            foreach (var engineer in engineersDAL)
            {
                engineers.Add(new Engineer() { engID = engineer.GetEngID(), engName = engineer.GetEngName(), status = (Status)engineer.GetStatus(), email = engineer.GetEmail() });
            }
            return engineers;
        }

        /// <summary>
        /// retrieving the details of an Employee
        /// </summary>
        public EmployeeData retrieveEmployee(string email)
        {
            Employee employeeOfDAL =  EmployeesDAL.RetrieveEmployee(email); //employee from dal
            //converting to employee of bl
            EmployeeData employee = new EmployeeData() { empID = employeeOfDAL.GetID(), empName = employeeOfDAL.GetName(), empEmail = employeeOfDAL.GetEmail(), supervisorName = employeeOfDAL.GetSupervisorName(), supervisorEmail = employeeOfDAL.GetSupervisorEmail() };

            return employee;
        }

        /// <summary>
        /// retrieving a list of all employees that have a certain role
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public List<EmployeeData> retrieveEmployees(int roleID)
        {
            List<Employee> employeesDAL = EmployeesDAL.RetrieveEmployees(roleID); //employees from dal
            List<EmployeeData> employees = new List<EmployeeData>();
            //converting to employees of bl
            foreach (var employeeOfDAL in employeesDAL)
            {
                EmployeeData superviosrBL = new EmployeeData() { empID = employeeOfDAL.GetID(), empName = employeeOfDAL.GetName(), empEmail = employeeOfDAL.GetEmail(), supervisorName = employeeOfDAL.GetSupervisorName(), supervisorEmail = employeeOfDAL.GetSupervisorEmail() };
                employees.Add(superviosrBL);
            }
            return employees;
        }
    }
}


