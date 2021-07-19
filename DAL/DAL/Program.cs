using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*UsersDAL.RegisterUser("d45dd2444dd", "d44456ssdd", "aa54dfafd5a@email.com", Constants.Role.engineer);
            UsersDAL.RegisterUser("d45ddfsad2444dd", "d44sss456dd", "aadd545a@email.com", Constants.Role.engineer);
            UsersDAL.RegisterUser("d45adsfads2444dd", "d44ss456dd", "aa5dasfadfas45a@email.com", Constants.Role.engineer);
            UsersDAL.RegisterUser("d45dsfa2444dd", "d444ss56dd", "aa54599a@email.com", Constants.Role.supervisor);
            UsersDAL.RegisterUser("d45dd652444dd", "d444sss56dd", "aa588845a@email.com", Constants.Role.engineer);
            UsersDAL.RegisterUser("d452457444dd", "d4445ss6dd", "aa545a@777email.com", Constants.Role.engineer);
            UsersDAL.RegisterUser("d45756444452444dd", "d4s4dd56dd", "aa544445a@email.com", Constants.Role.engineer);
            UsersDAL.RegisterUser("d45564564562444dd", "d44dd56dd", "aa545a555@email.com", Constants.Role.engineer);*/



            /*BuildingPermitsDAL.InsertPermittedBuilding("building", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building3", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building5", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building6", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building8", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building10", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building22", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building23", 1);
            BuildingPermitsDAL.InsertPermittedBuilding("building24", 1);*/

            /*AddressDAL.addNewAddress("ddd");
            AddressDAL.addNewAddress("daf");
            AddressDAL.addNewAddress("dafd");
            AddressDAL.addNewAddress("adfaa");
            AddressDAL.addNewAddress("adfad");
            AddressDAL.addNewAddress("gkj");
            AddressDAL.addNewAddress("gjkg");
            AddressDAL.addNewAddress("jgkjg");
            AddressDAL.addNewAddress("hhhd");
            AddressDAL.addNewAddress("hfghd");
            AddressDAL.addNewAddress("gadf");
            AddressDAL.addNewAddress("aad");*/


            /*EmployeesDAL.Register(2, 1, "dfdgdd", "dd1d@email.com");
            EmployeesDAL.Register(2, 1, "dddfd", "dd2d@email.com");
            EmployeesDAL.Register(2, 1, "dsfdfdd", "dd3d@email.com");
            EmployeesDAL.Register(2, 1, "ddfdsgd", "dd54d@email.com");
            EmployeesDAL.Register(2, 1, "dsfsddd", "d7dd@email.com");
            EmployeesDAL.Register(2, 1, "ddssssd", "dd8d@email.com");*/

            /*AddressDAL.addNewAddress("ddd 5");
            AddressDAL.addNewAddress("gdh");
            AddressDAL.addNewAddress("dd");
            AddressDAL.addNewAddress("asdfasd");
            AddressDAL.addNewAddress("adfa5");
            AddressDAL.addNewAddress("adsfaa5");
            AddressDAL.addNewAddress("dadf");
            AddressDAL.addNewAddress("dsfa 5");
            AddressDAL.addNewAddress("ddafad5");*/


            /*ImagesDAL.InsertImage("picture9.jpg", 1, DateTime.Now);
            ImagesDAL.InsertImage("picture10.jpg", 1, DateTime.Now);
            ImagesDAL.InsertImage("picture11.jpg", 1, DateTime.Now);
            ImagesDAL.InsertImage("picture12.jpg", 1, DateTime.Now);
            ImagesDAL.InsertImage("picture13.jpg", 1, DateTime.Now);
            ImagesDAL.InsertImage("image14.jpg", 4,DateTime.Now);
            ImagesDAL.InsertImage("image15.jpg", 4, DateTime.Now);
            ImagesDAL.InsertImage("image16.jpg", 4, DateTime.Now);
            ImagesDAL.InsertImage("image17.jpg", 4, DateTime.Now);*/

            //testing the login function
            //Console.WriteLine(UsersDAL.Login("eli", "examplepassword")); //this one isn't going to work
            //Console.WriteLine(UsersDAL.Login("dfasdfsa", "ddd")); //this one is going to work

            //changing password
            //UsersDAL.ChangePassword("dfasdfsa", "ddd", "mynewpassword");

            //getting all building in a certain address
            /*BuildingPermitsDAL.SelectBuildingsInAddress(3);
            BuildingPermitsDAL.SelectBuildingsInAddress(2);*/

            //retriving employee
            //Console.WriteLine(EmployeesDAL.retrieveEmployee("AmnonLevi@email.com"));


            /*List<ImageData> images = ImagesDAL.retrieveImages();
            foreach (var image in images)
            {
                image.PrintProperties();
            }*/

            /*Console.WriteLine(ImagesDAL.ReturnLasterstImageDirFromAddress("Merkaz 5"));
            Console.WriteLine(ImagesDAL.ReturnLasterstImageDirFromAddress("qqq"));*/

            /*ReportsDAL.addReport(14, 15, "text, text, text");
            ReportsDAL.addReport(14, 16, "text, text, text");
            ReportsDAL.addReport(14, 15, "text, text, text");
            ReportsDAL.addReport(14, 17, "text, text, text");
            ReportsDAL.addReport(14, 15, "text, text, text");
            ReportsDAL.addReport(14, 15, "text, text, text");
            ReportsDAL.addReport(15, 18, "text, text, text");
            ReportsDAL.addReport(14, 15, "text, text, text");
            ReportsDAL.addReport(14, 15, "text, text, text");*/

            /*BuildingPermitsDAL.SelectBuildingsInAddress(1);
            BuildingPermitsDAL.SelectBuildingsInAddress(4);*/

            /*int num = AddressDAL.returnAddressIDInAddress("Merkaz 5");
            Console.WriteLine(num);*/
            //BuildingPermitsDAL.SelectBuildingsInAddress("Merkaz 5");
            //ReportsDAL.addReport("4444", "555", "text, text, text");

            //BuildingPermitsDAL.InsertPermittedBuilding("something", "Merkaz 5");

            //EmployeesDAL.RegisterEmpolyee("Engineer", "4444", "myname", "mail@email.com");

            //EmployeesDAL.retrieveEmployeeNameByEmail("dd@email.com");

            //EmployeesDAL.retrieveEmployee("dd@email.com");

            /*List<Report> reports =  ReportsDAL.retrieveReportsSentForEmployee("4444");

            foreach (var report in reports)
            {
                report.PrintProperties();
            }*/

            //ImagesDAL.InsertImagePath("picture20.jpg", 1);

            //UsersDAL.LoginUser("dfasdfsa", "mynewpassword");
            //UsersDAL.RegisterUser("ddafdafdd", "fgsfdddddhshf", "rrdfsdafaee@email.com", "4444");

            /*User user = UsersDAL.LoginUser("dfasdfsa", "mynewpassword");
            user.PrintProperties();*/

            //BuildingPermitsDAL.InsertPermittedBuilding("Gas station", "Merkaz 5");

            /*List<string> buildings = BuildingPermitsDAL.SelectBuildingsInAddress("Merkaz 5");
            foreach (var building in buildings)
            {
                Console.WriteLine(building);
            }*/

            //ImagesDAL.InsertImagePath("newimage.jpg", "Merkaz 5");
            //AddressDAL.addNewAddress("hadror 8");

            /*List<Report> reports = ReportsDAL.retrieveReportsSentToEmployee("555");

            foreach (var report in reports)
            {
                report.PrintProperties();
            }*/

            //ReportsDAL.addReport("555", "4444", "subject", "text");

            /*List<string> engineers = EmployeesDAL.retrieveAllEngineersName();
            List<string> supervisors = EmployeesDAL.retrieveAllSuperviorsName();

            foreach (var engineer in engineers)
            {
                Console.WriteLine(engineer);
            }

            foreach(var supervisor in supervisors)
            {
                Console.WriteLine(supervisor);
            }*/

            /* Employee employee = EmployeesDAL.retrieveEmployee("maill@email.com");
             employee.PrintProperties();*/

            //Console.WriteLine(EmployeesDAL.matchSupervisorAndEngineer(16, 14)); returns True
            //Console.WriteLine(EmployeesDAL.matchSupervisorAndEngineer(17, 14)); returns False

            //UsersDAL.changeUserStatus("maill@email.com");

            /*User user = UsersDAL.authenticateUser("ddd", "ddd");
            user.PrintProperties();*/

            /*User user = UsersDAL.authenticateUser("111", "111");
            user.PrintProperties();*/

            /*Employee employee = EmployeesDAL.retrieveEmployee("dd@email.com");
            employee.PrintProperties();*/

            /*List<Address> addresses = AddressDAL.retrieveAllAddresses();
            foreach (var address in addresses)
            {
                address.PrintProperties();
            }*/

            //ImagesDAL.InsertImagePath("anotherImage.jpg", 2);

            /*string image = ImagesDAL.ReturnMostRecentImagePathInAddress(1);
            Console.WriteLine(image);*/

            //ImagesDAL.updateNumberOfImages();
            //Console.WriteLine(ImagesDAL.retrieveNumberOfImages());

            /*Report report = ReportsDAL.GetReport(24);
            report.PrintProperties();*/

            /*Report report = ReportsDAL.GetReport(24);
            report.PrintProperties();*/

            /*ReportsDAL.addReport(14, "fff@email.com", "11", "22");
            ReportsDAL.addReport(17, "fff@email.com", "---", "dafdadf");
            ReportsDAL.addReport(19, "fff@email.com", "9999", "qqqq");*/

            /*List<Report> Reports = ReportsDAL.retrieveReportsSentToEmployee(14);
            foreach (var report in Reports)
            {
                report.PrintProperties();
            }*/

            //Report report = ReportsDAL.GetReport2(16);

            /*List<string> buildings = BuildingPermitsDAL.SelectBuildingsInAddress(1);
            foreach (var building in buildings)
            {
                Console.WriteLine(building);
            }*/

            /*List<Report> reports = ReportsDAL.retrieveReportsSentToEmployee(15);
            foreach (var report in reports)
            {
                report.PrintProperties();
            }*/

            //Console.WriteLine(Constants.Status.statusIDMeanings[Constants.Status.inactive]);

            //Console.WriteLine(Constants.Status.statusIDMeanings[1]);

            /*Engineer engineer = new Engineer(15, "dfdudd", Constants.Status.statusIDMeanings[Constants.Status.inactive], "aa545a@777email.com");
            UsersDAL.changeEngineerStatus(engineer);*/

            /*List<Engineer> engineers = EmployeesDAL.returnEngineersOfSupervisor(14);

            foreach (var engineer in engineers)
            {
                engineer.PrintProperties();
            }*/

            //User user = UsersDAL.authenticateUser("ddd", "adsfadfa");
            //User user = UsersDAL.authenticateUser("dfasdfsa", "mynewpassword");
            //user.PrintProperties();

            //UsersDAL.RegisterUser("fred", "greatestpasswordlol", "tasr@email.com", 1);

            /*List<Employee> sups = EmployeesDAL.retrieveAllSuperviors();
            foreach (var sup in sups)
            {
                sup.PrintProperties();
            }*/

            /*List<ImageData> imageDatas = ImagesDAL.retrieveImageDataFromAddress(1);
            foreach (var imagedata in imageDatas)
            {
                imagedata.PrintProperties();
                Console.WriteLine(" ");
            }*/

            //Console.WriteLine(DateTime.Now.ToString());

            //ImagesDAL.InsertImagePath("newtry555.jpg", 1);

            /*string imagePath = ImagesDAL.retrieveImageInDatePath(1, "12/25/2020 19:55:09");
            Console.WriteLine(imagePath);*/

            /*Employee employee = EmployeesDAL.retrieveEmployee("maill@email.com");
            employee.PrintProperties();*/

            /*List<Employee> employees = EmployeesDAL.retrieveEmployees(1);

            foreach (var employee in employees)
            {
                employee.PrintProperties();
                Console.WriteLine(" ");
            }*/

            //Console.WriteLine(ReportsDAL.retrieveLastestReportID());

            //FilesDAL.insertFilePath("filesomethig.doc", 29);

            /*List<string> files = ReportsDAL.getFilesOfReport(41);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }*/

            /*List<Address> addresses = AddressDAL.retrieveAllAddresses();
            foreach (var address in addresses)
            {
                address.PrintProperties();
            }*/

            /*string path = ImagesDAL.retrieveImageInDatePath(27, "1/15/2021 22:10:51");
            Console.WriteLine(path);*/

            /*List<Permit> permits = BuildingPermitsDAL.selectPermitsInAddress(27);
            foreach (var permit in permits)
            {
                Console.WriteLine(permit.permitName);
                Console.WriteLine(permit.permitDate);
                Console.WriteLine(permit.permitIssuer);
            }*/
        }
    }
}
