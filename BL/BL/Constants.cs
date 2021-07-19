namespace BL
{
    /// <summary>
    /// useful constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// ids of roles
        /// </summary>
        public static class Role
        {
            public const int supervisor = DAL.Constants.Role.supervisor; //constant of supervisor
            public const int engineer = DAL.Constants.Role.engineer; //constant of engineer
            public const int chiefSupervisor = DAL.Constants.Role.chiefSupervisor; //constant of chief supervisor
        }

        public const string chiefSupervisorName = DAL.Constants.chiefSupervisorName;
        public const string chiefSupervisorEmail = DAL.Constants.chiefSupervisorEmail;

        public static class Images
        {
            public const int numberOfImagesID = DAL.Constants.Images.numberOfImagesID;
        }

        /// <summary>
        /// names of the keys for the paths in the config file
        /// </summary>
        public static class Paths
        {
            public const string basePathKeyName = "basePath";
            public const string filesPathKeyName = "filesPath";
        }
    }
}
