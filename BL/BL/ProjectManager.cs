using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    /// <summary>
    /// the manager class. the only class that will be used in the UI itself.
    /// contains all the function that are going to be useful in the UI.
    /// </summary>
    public class ProjectManager
    {
        private UserService userService;
        private EmployeeService employeeService;
        private ReportService reportService;
        private PermitService permitService;
        private AddressService addressService;
        private ImageService imageService;
        private FilesService filesService;
        private DetectImageService detectImageService;
        private int chiefSupervisorID;
        public ProjectManager()
        {
            this.userService = new UserService();
            this.employeeService = new EmployeeService();
            this.reportService = new ReportService();
            this.permitService = new PermitService();
            this.addressService = new AddressService();
            this.imageService = new ImageService();
            this.filesService = new FilesService();
            this.detectImageService = new DetectImageService();
            this.chiefSupervisorID = Roles.chiefSupervisor;
        }

        /// <summary>
        /// logging in an authorized user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public AuthenticationData LoginUser(string username, string password, int roleID)
        {
            //authentication data of the user with the given information
            AuthenticationData authenticationData = this.userService.AuthenticateUser(username, password, roleID);
            return authenticationData; 
        }
        

        /// <summary>
        /// retrieving a list of engineers that work under a certain supervisor
        /// </summary>
        /// <param name="supervisorID"></param>
        /// <returns></returns>
        public List<Engineer> EngineerList(int supervisorID)
        {
            //list of engineers that work under a certain supervisor
            List<Engineer> engineers = this.employeeService.retrieveEngineersOfSupervisorList(supervisorID);
            return engineers;
        }


        /// <summary>
        /// activating an engineer's account
        /// </summary>
        /// <param name="email"></param>
        public void ActivateAccount(string email)
        {
            this.userService.ActivateUser(email);
        }


        /// <summary>
        /// suspending an engineer
        /// </summary>
        /// <param name="email"></param>
        public void SuspendAccount(string email)
        {
            this.userService.SuspendUser(email);
        }


        /// <summary>
        /// retrieving a list of all the permits in a certain address
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns></returns>
        public List<Permit> PermitsList(int addressID)
        {
            List<Permit> permits = this.permitService.RetrievePermitsInAddress(addressID);
            permits.OrderBy(permit => permit.permitDate).Reverse(); //ordering by date and then reversing
            return permits;
        }
        
        /// <summary>
        /// retrieving a list of all the supervisors (excluding the chief supervisor)
        /// </summary>
        /// <returns></returns>
        public List<EmployeeData> SupervisorsList()
        {
            //list of supervisors
            List<EmployeeData> supervisors = this.employeeService.retrieveSupervisorsList();
            return supervisors;
        }


        /// <summary>
        /// registering an engineer to the system
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="empName"></param>
        /// <param name="superviosrID"></param>
        /// <param name="roleID"></param>
        public void UserRegisterEngineer(string username, string password, string email, string empName, int superviosrID, int roleID)
        {
            this.userService.RegisterUserEngineer(username, password, email, empName, superviosrID, roleID);
        }

        /// <summary>
        /// registering a supervisor to the system
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="empName"></param>
        /// <param name="superviosrID"></param>
        /// <param name="roleID"></param>
        public void UserRegisterSupervisor(string username, string password, string email, string empName, int superviosrID, int roleID)
        {
            this.userService.RegisterUserSupervisor(username, password, email, empName, superviosrID, roleID);
        }

        /// <summary>
        /// retriving the id of the chief supervisor
        /// </summary>
        /// <returns></returns>
        public int RetrieveChiefSupervisorID()
        {
            //the id of the chief supervisor
            int chiefSupervisorID = this.employeeService.retrieveEmployees(this.chiefSupervisorID)[0].empID;
            return chiefSupervisorID;
        }

        /// <summary>
        /// changing a password of a user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            this.userService.ChangePassword(username, oldPassword, newPassword);
        }
        
        /// <summary>
        /// retrieving an employee
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public EmployeeData RetrieveEmployee(string email)
        {
            //the retrieved employee
            EmployeeData employeeData = this.employeeService.retrieveEmployee(email);
            return employeeData;
        }
        

        /// <summary>
        /// retrieving a report
        /// </summary>
        /// <param name="reportID"></param>
        /// <returns>report with the given id</returns>
        public ReportData GetReport(int reportID)
        {
            //report with the given id
            ReportData reportData = this.reportService.GetReport(reportID);
            return reportData;
        }
        
        /// <summary>
        /// retrieving list of all the addresses
        /// </summary>
        /// <returns></returns>
        public List<AddressData> AddressDatasList()
        {
            //list of al the addresses
            List<AddressData> addressDatas = this.addressService.RetrieveAllAddresses();
            return addressDatas;
        }

        /// <summary>
        /// retrieving the parth of the image in a ceratin address
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns>url of the last image in the given address</returns>
        public string RetrieveLastImagePathInAddress(int addressID)
        {
            string lastImagePath = this.imageService.ReturnMostRecentImagePathInAddress(addressID);
            return lastImagePath;
        }

        /// <summary>
        /// retrieving details of an image that was taken in a certain address
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns>list of imageData from a certain address</returns>
        public List<ImageData> RetrieveImageDatasFromAddress(int addressID)
        {
            List<ImageData> imageDatas = this.imageService.RetrieveImagesDataInAddress(addressID);
            return imageDatas;
        }

        /// <summary>
        /// retrieving the path of an image in a certain date
        /// </summary>
        /// <param name="addressID"></param>
        /// <param name="date"></param>
        /// <returns>image path in the given address and date</returns>
        public string RetrieveImagePathInDate(int addressID, string date)
        {
            try
            {
                return this.imageService.RetrieveImageInDatePath(addressID, date);
            }
            catch (Exception)
            {
                throw new Exception("wrong details");
            }
            
        }
        

        /// <summary>
        /// sending a report
        /// </summary>
        /// <param name="senderID"></param>
        /// <param name="recieverEmail"></param>
        /// <param name="subject"></param>
        /// <param name="content"></param>
        public void SendReport(int senderID, string recieverEmail, string subject, string content)
        {
            this.reportService.SendReport(senderID, recieverEmail, subject, content);
        }

        /// <summary>
        /// retrieving the id of the last report
        /// </summary>
        /// <returns>id of the last report</returns>
        public int LastReportID()
        {
            int idOfLastReport = this.reportService.retrieveIDOfLastReport();
            return idOfLastReport;
        }

        /// <summary>
        /// saving a file that was sent in the report to the system
        /// </summary>
        /// <param name="originalPath"></param>
        /// <param name="reportID"></param>
        public void SaveFile(string originalPath, int reportID)
        {
            this.filesService.SaveFile(originalPath, reportID);
        }
        
        /// <summary>
        /// retrieving a list of reports of a certain employee
        /// </summary>
        /// <param name="recieverID"></param>
        /// <returns></returns>
        public List<ReportData> RetrieveReportsData(int recieverID)
        {
            List<ReportData> reportsDataList = this.reportService.GetAllReportsSentToEmployee(recieverID);
            //ordering by report id and reversing the list
            reportsDataList.OrderBy(report => report.reportID).Reverse(); 
            return reportsDataList;
        }

        /// <summary>
        /// the decision supporting method. detecting an image and retrieving its path
        /// </summary>
        /// <param name="originalImagePath"></param>
        /// <param name="addressID"></param>
        /// <returns>url of image with newly detected buildings</returns>
        public string DetectImage(string originalImagePath)
        {
            string detectedImagePath = this.detectImageService.Detect(originalImagePath);
            return detectedImagePath;
        }

        /// <summary>
        /// retrieving a list that contains the paths of all the files of a report
        /// </summary>
        /// <returns></returns>
        public List<string> GetFileListOfReport(int reportID)
        {
            List<string> pathsOfreportFiles = this.reportService.getFilesOfReport(reportID);
            return pathsOfreportFiles;
        }

        /// <summary>
        /// saving an image to the system
        /// </summary>
        /// <param name="newPath"></param>
        /// <param name="addressID"></param>
        public void SaveImage(string newPath, int addressID)
        {
            this.imageService.SaveImage(newPath, addressID);
        }

        /// <summary>
        /// saving an address to the system and returning it
        /// </summary>
        /// <param name="address"></param>
        public AddressData SaveAddress(string address)
        {
            return this.addressService.AddAddress(address);
        }

        /// <summary>
        /// saving a permit to the system
        /// </summary>
        /// <param name="permitName"></param>
        /// <param name="address"></param>
        public void SavePermit(string permitName, int addressID, int permitAdderID)
        {
            this.permitService.AddPermitToSystem(permitName, addressID, permitAdderID);
        }

        /// <summary>
        /// saving the path of the file to the system
        /// </summary>
        /// <param name="targetPath"></param>
        /// <param name="reportID"></param>
        public void SaveFilePath(string targetPath, int reportID)
        {
            this.filesService.SaveFilePath(targetPath, reportID);
        }

        /// <summary>
        /// creating a new path
        /// </summary>
        /// <param name="originalPath"></param>
        /// <returns>the newly created path</returns>
        public string CreateNewPath(string originalPath, int reportID)
        {
            string newlyCreatedPath = this.filesService.CreateAndRetrieveNewPath(originalPath, reportID);
            return newlyCreatedPath;
        }


        /// <summary>
        /// retrieving whether address exist or not
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool DoesAddressExist(string address)
        {
            return this.addressService.DoesAddressExist(address);
        }
    }
}