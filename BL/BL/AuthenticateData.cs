namespace BL
{
    /// <summary>
    /// this class uses for authenticating user when they login to the system
    /// </summary>
    public class AuthenticationData
    {
        private User user; //the user that was just authenticated
        private int empID; //employee id of the user

        public AuthenticationData()
        {

        }

        public AuthenticationData(User user, int empID)
        {
            this.user = user;
            this.empID = empID;
        }

        //-----Getters-----
        
        public User GetUser()
        {
            return user;
        }
        public int GetEmpID()
        {
            return this.empID;
        }

        //-----Setters-----

        public void SetUser(User user)
        {
            this.user = user;
        }

        public void SetEmpID(int empID)
        {
            this.empID = empID;
        }
    }
}


