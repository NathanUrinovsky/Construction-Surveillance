namespace DAL
{
    /// <summary>
    /// useful constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// constants related to the ids in the Roles table
        /// </summary>
        public static class Role
        {
            public const int supervisor = 1; //constant of supervisor
            public const int engineer = 2; //constant of engineer
            public const int chiefSupervisor = 4; //constant of chief supervisor
        }

        public const string chiefSupervisorName = "Chief Supervisor";
        public const string chiefSupervisorEmail = "chiefsuperviosr@email.com";

        public static class Images
        {
            public const int numberOfImagesID = 1;
        }

        /// <summary>
        /// names of the keys for the paths in the config file
        /// </summary>
        public static class Paths
        {
            public const string basePathKeyName = "basePath";
            public const string imagesPathKeyName = "imagesPath";
            public const string filesPathKeyName = "filesPath";
        }
    }
}
