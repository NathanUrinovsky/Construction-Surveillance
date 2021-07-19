namespace DAL
{
    public class Employee
    {
        private int id;
        private string name;
        private string email;
        private string supervisorName;
        private string supervisorEmail;
        /// <summary>
        /// empty constructor 
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// constructor with arguemnts
        /// </summary>
        /// <param name="name"></param>
        /// <param name="supervisorName"></param>
        /// <param name="supervisorEmail"></param>
        public Employee(int id, string name, string email, string supervisorName, string supervisorEmail)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.supervisorName = supervisorName;
            this.supervisorEmail = supervisorEmail;
        }
        //-----Getters-----
        public int GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetSupervisorName()
        {
            return this.supervisorName;
        }

        public string GetSupervisorEmail()
        {
            return this.supervisorEmail;
        }

        //-----Setters-----

        public void SetID(int id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetSupervisorName(string supervisorName)
        {
            this.supervisorName = supervisorName;
        }
        public void SetSupervisorEmail(string supervisorEmail)
        {
            this.supervisorEmail = supervisorEmail;
        }
    }
}
