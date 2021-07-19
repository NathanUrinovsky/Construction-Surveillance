namespace DAL
{
    public class User
    {
        private int roleID;
        private string userName;
        private string email;
        private Status status;

        public User()
        {

        }

        public User(int roleID, string userName, string email, Status status)
        {
            this.roleID = roleID;
            this.userName = userName;
            this.email = email;
            this.status = status;
        }

        //-----Getters-----
        public int GetRoleID()
        {
            return this.roleID;
        }

        public string GetUserName()
        {
            return this.userName;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public Status GetStatus()
        {
            return this.status;
        }

        //-----Setters-----

        public void SetRoleID(int roleID)
        {
            this.roleID = roleID;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetStatus(Status status)
        {
            this.status = status;
        }
    }
}


