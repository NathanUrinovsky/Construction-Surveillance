using System.IO;
using System.Configuration;
using DAL;

namespace BL
{
    public class FilesService
    {
        private string basePath; //path of the whole project
        private string filesPath; //folder of the files

        /// <summary>
        ///empty constructor that sets the default values
        /// </summary>
        public FilesService()
        {
            this.basePath = ConfigurationManager.AppSettings.Get(Paths.basePathKeyName);
            this.filesPath = ConfigurationManager.AppSettings.Get(Paths.filesPathKeyName);
        }

        public FilesService(string basePath, string filesPath)
        {
            this.basePath = basePath;
            this.filesPath = filesPath;
        }

        /// <summary>
        /// saving a file that was sent in a report
        /// </summary>
        /// <param name="originalPath"></param>
        /// <param name="reportID"></param>
        public void SaveFile(string originalPath, int reportID)
        {
            string newFilePath = CreateAndRetrieveNewPath(originalPath, reportID); //new path of the file
            File.Copy(originalPath, newFilePath); //copying to the folder of the files 
            SaveFilePath(newFilePath, reportID); //saving
        }

        /// <summary>
        /// creating a new path for a file in a certain address
        /// </summary>
        /// <param name="originalPath"></param>
        /// <returns></returns>
        public string CreateAndRetrieveNewPath(string originalPath, int reportID)
        {
            string filesBasicPath = this.basePath + this.filesPath; //directory of the folder with all the files
            string folderPath = filesBasicPath + "report" + reportID.ToString() + "\\"; //folder of the files of the report that was just sent
            Directory.CreateDirectory(folderPath); //creating the folder
            string newfilename = Path.GetFileNameWithoutExtension(originalPath);
            string fileExtension = Path.GetExtension(originalPath);
            string newFilePath = folderPath + newfilename + fileExtension; //newly created path
            return newFilePath;
        }


        /// <summary>
        /// saving the path of the saved file
        /// </summary>
        /// <param name="savingPath"></param>
        /// <param name="reportID"></param>
        public void SaveFilePath(string targetPath, int reportID)
        {
            FilesDAL.InsertFilePath(targetPath, reportID);
        }
    }
}
