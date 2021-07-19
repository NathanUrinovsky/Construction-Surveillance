using System;
using System.Linq;
using System.Text.RegularExpressions;
using DAL;

namespace BL
{
    public class UserService
    {

        private EmployeeService employeeService;
        private Regex regex;
        public UserService()
        {
            this.employeeService = new EmployeeService();
            this.regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        public UserService(EmployeeService employeeService, Regex regex)
        {
            this.employeeService = employeeService;
            this.regex = regex;
        }

        /// <summary>
        /// signing in a registered engineer
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public AuthenticationData AuthenticateUser(string username, string password, int roleID)
        {
            User user = new User(); //new instance of user
            AuthenticationData authenticationData = new AuthenticationData(user, 0); //new authenticationData
            DAL.User userDAL = UsersDAL.RetrieveAuthenticatedUser(username, password, roleID); //user from dal
            user.ConvertUserDALToUserBL(userDAL); //converting to user of bl from user of dal

            if (IsValid(user)) //if the user is valid
            {
                EmployeeData employee = this.employeeService.retrieveEmployee(user.GetEmail());
                authenticationData.SetUser(user);
                authenticationData.SetEmpID(employee.empID);
            }

            return authenticationData;
        }

        /// <summary>
        /// registration for engineers
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        public void RegisterUserEngineer(string username, string password, string email, string empName, int supervisorID, int roleID)
        { 
            bool doesExist = DoesUserExist(username, email); //variable that says whether the user exists or nto
            Match match = this.regex.Match(email);
            if (!doesExist && match.Success && !string.IsNullOrEmpty(LeaveOnlyCharacters(username)) && !string.IsNullOrEmpty(LeaveOnlyCharacters(password))) //if doesn't exist and email is correct
            {
                UsersDAL.RegisterUser(LeaveOnlyCharacters(username), LeaveOnlyCharacters(password), email.ToLower(), roleID); //register the user
                this.employeeService.RegisterEmployee(empName, email.ToLower(), supervisorID, roleID); //register the employee
            }
            else
            {
                throw new ArgumentException("invalid arguments");
            }
            
        }

        /// <summary>
        /// registeration for supervisors
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="empName"></param>
        /// <param name="supervisorID"></param>
        /// <param name="roleID"></param>
        public void RegisterUserSupervisor(string username, string password, string email, string empName, int supervisorID, int roleID)
        {
            bool doesExist = DoesUserExist(username, email); //variable that says whether the user exists or nto
            if (!doesExist)
            {
                UsersDAL.RegisterUser(LeaveOnlyCharacters(username), LeaveOnlyCharacters(password), email.ToLower(), roleID); //register the user
                this.employeeService.RegisterEmployee(empName, email.ToLower(), supervisorID, roleID); //register the employee
            }
            else
            {
                throw new ArgumentException("invalid arguments");
            }
        }

        /// <summary>
        /// changing the password of a user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        public void ChangePassword(string username, string oldPassword, string newPassword)
        {

            if (oldPassword == newPassword || newPassword.ToLower().Contains(' ') || string.IsNullOrEmpty(LeaveOnlyCharacters(newPassword)))
            {
                throw new ArgumentException("invalid arguements");
            }

            try
            {
                UsersDAL.ChangeUserPassword(username, oldPassword, newPassword);
            }
            catch(Exception e)
            {
                throw new ArgumentException("invalid user", e);
            }

        }

        /// <summary>
        /// cheking if a user is valid (=exists) by returning whether their roleID equals to 0 or not 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool IsValid(User user)
        {
            //if the role id equals 0, it means that the user is not valid
            return user.GetRoleID() != 0; 
        }

        /// <summary>
        /// suspending a user
        /// </summary>
        public void SuspendUser(string email)
        {
            UsersDAL.ChangeUserStatus(email, DAL.Status.Inactive);
        }

        /// <summary>
        /// activating a user
        /// </summary>
        /// <param name="email"></param>
        public void ActivateUser(string email)
        {
            UsersDAL.ChangeUserStatus(email, DAL.Status.Active);
        }

        public User retrieveUser(string username)
        {
            //converting user of bl to user of dal and retrieving it
            DAL.User userOfDAL = UsersDAL.RetrieveUser(username);
            User user = new User();
            user.ConvertUserDALToUserBL(userOfDAL);
            return user;
        }

        /// <summary>
        /// retrieving wether a user exists or not
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool DoesUserExist(string username, string email)
        {
            return UsersDAL.DoesUserExist(username, email);
        }

        /// <summary>
        /// returning a string without spaces in the sides
        /// </summary>
        /// <param name="givenText"></param>
        /// <returns></returns>
        public string LeaveOnlyCharacters(string givenText)
        {
            string password = givenText.ToString(); //text as it was given
            char[] charsToTrim = { ' ' }; //spaces are needed to be trimmed from the sides
            string trimmedPassword = password.Trim(charsToTrim); //password without spaces from the sides
            return trimmedPassword;
        }
    }
}


