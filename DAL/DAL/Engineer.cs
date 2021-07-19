namespace DAL
{
    public class Engineer
    {
        private int engID;
        private string engName;
        private Status status;
        private string email;

        public Engineer()
        {

        }

        public Engineer(int engID, string engName, Status status, string email)
        {
            this.engID = engID;
            this.engName = engName;
            this.status = status;
            this.email = email;

        }

        //-----Getters-----
        public int GetEngID()
        {
            return this.engID;
        }

        public string GetEngName()
        {
            return this.engName;
        }

        public Status GetStatus()
        {
            return this.status;
        }

        public string GetEmail()
        {
            return this.email;
        }

        //-----Setters-----

        public void SetEngID(int engID)
        {
            this.engID = engID;
        }

        public void SetEngName(string engName)
        {
            this.engName = engName;
        }

        public void SetStatus(Status status)
        {
            this.status = status;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
    }
}
