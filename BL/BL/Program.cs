using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*UserService.authenticateUser("dfasdfsa", "mynewpassword");*/
            //UserService.registerUser("dfdudd", "mypass799", "maill@email.com", "4444", "rudy");
            //UserService.changePassword("dfdudd", "mypass799", "betterpass800");

            /*List<string> buildings = PermitService.retrievePermitsInAddress("Merkaz 5");
            foreach (var building in buildings)
            {
                Console.WriteLine(building);
            }*/

            /*List<string> addresses = AddressService.retrieveAllAddresses();
            foreach (var address in addresses)
            {
                Console.WriteLine(address);
            }*/

            //ImageService.insertImage("pictureBL.jpg", "hadror 8");
            /*string lastImageDir = ImageService.retrieveLastImageInAddress("d");
            Console.WriteLine(lastImageDir);
            string lastImageDir = ImageService.retrieveLastImageInAddress("Merkaz 5");
            string lastImageDir2 = ImageService.retrieveLastImageInAddress("street55");
            Console.WriteLine(lastImageDir);
            Console.WriteLine(lastImageDir2);*/

            //List<string> engineers = EmployeeService.retrieveEngineersList();
            //List<string> supervisors = EmployeeService.retrieveSupervisorsList();

            /*foreach (var engineer in engineers)
            {
                Console.WriteLine(engineer);
            }*/

            /*foreach (var supervisor in supervisors)
            {
                Console.WriteLine(supervisor);
            }*/

            /*DAL.Employee employee = EmployeeService.retrieveEmployee("dd@email.com");
            employee.PrintProperties();*/

            /*List<string> engineers = EmployeeService.retrieveEngineersOfSupervisorList("4444");
            foreach (var engineer in engineers)
            {
                Console.WriteLine(engineer);
            }*/

            //PermitService.addPermitToSystem("residence building", "hazait4");

            //UserService.changeUserStatus("rr@email.com");

            /*AuthenticationData authenticationData = UserService.authenticateUser("dfdudd", "betterpass800");
            authenticationData.PrintProperties();*/
            /*List<Report> reports = ReportService.getAllReportsSentToEmployee("555");
            foreach (var report in reports)
            {
                report.PrintProperties();
            }*/

            /*List<Address> addresses = AddressService.retrieveAllAddresses();
            foreach (var address in addresses)
            {
                address.PrintProperties();
            }*/

            /*string path = ImageService.returnMostRecentImagePathInAddress(1);
            Console.WriteLine(path);*/

            //ImageService.addImageToSystem("another-image-from-bl", 2);

            //Console.WriteLine(Constants.Images.numberOfImages);
            //Console.WriteLine(Constants.Path.basePath);

            //Console.WriteLine(Constants.Images.numberOfImages);

            /*List<string> buildings = PermitService.retrievePermitsInAddress(1);
            foreach (var building in buildings)
            {
                Console.WriteLine(building);
            }*/

            /*AuthenticationData authenticationData = UserService.authenticateUser("ccc", "betterccccpass800");
            authenticationData.PrintAuthenticationDataProperties();*/

            /*List<Employee> employees = EmployeeService.retrieveSupervisorsList();

            foreach (var employee in employees)
            {
                employee.PrintProperties();
                Console.WriteLine(" ");
            }*/

            /*EmployeeData employeeData = new EmployeeData() { empID = 1, empName = "haim" };
            Console.WriteLine(employeeData.empName);*/

            /*List<Address> addresses = AddressService.retrieveAllAddresses();
            foreach (var address in addresses)
            {
                address.PrintProperties();
            }*/

            /*string path = ImageService.retrieveImageInDatePath(27, "1/15/2021 22:10:51");
            Console.WriteLine(path);*/

            /*ProjectManager projectManager = new ProjectManager();
            string path = projectManager.retrieveImagePathInDate(27, "1/15/2021 22:10:51");
            Console.WriteLine(path);*/

            /*ProjectManager projectManager = new ProjectManager();
            List<Permit> permits = projectManager.permitsList(27);
            int a = 5;*/
        }
    }
}
