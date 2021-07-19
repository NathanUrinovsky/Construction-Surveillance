using System;
using System.Collections.Generic;
using DAL;

namespace BL
{
    public class PermitService
    {
        public PermitService()
        {

        }

        /// <summary>
        /// retrieving a list with all the buildings that have a permit in a specific address
        /// </summary>
        /// <param name="address"></param>
        /// <returns>list of buildings that have a permit and are in the given address</returns>
        public List<Permit> RetrievePermitsInAddress(int addressID)
        {
            List<DAL.Permit> permitsDAL = BuildingPermitsDAL.SelectPermitsInAddress(addressID); //permits from dal
            List<Permit> permits = new List<Permit>();
            //converting to permits of bl
            foreach (var permitDAL in permitsDAL)
            {
                //creating new instance of permit and assigning new values to properties every time
                Permit permit = new Permit(); 
                permit.permitName = permitDAL.permitName;
                permit.permitDate = permitDAL.permitDate;
                permit.permitIssuer = permitDAL.permitIssuer;
                permits.Add(permit);
            }

            return permits;
        }

        /// <summary>
        /// adding a permitted building to the system (name of the building i.e Residence building, School etc. )
        /// </summary>
        /// <param name="buildingName"></param>
        /// <param name="addressID"></param>
        /// <param name="permitAdderID"></param>
        public void AddPermitToSystem(string buildingName, int addressID, int permitAdderID)
        {
            string buildingNameOnlyString = ReturnStringWithoutSpaces(buildingName);
            if (IsAnActualString(buildingName))
            {
                BuildingPermitsDAL.InsertPermittedBuilding(buildingNameOnlyString, addressID, permitAdderID);
            }
            else
            {
                throw new Exception("invalid permit");
            }
        }

        /// <summary>
        /// returns whether a string is only spaces or not
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool IsAnActualString(string text)
        {
            string trimmedText = ReturnStringWithoutSpaces(text);
            return trimmedText.Length > 0;
        }

        /// <summary>
        /// returning a string without spaces
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReturnStringWithoutSpaces(string text)
        {
            char[] charsToTrim = { ' ' }; //characters that need to be trimmed from the sides
            string trimmedText = text.Trim(charsToTrim); // text without spaces in the sides
            return trimmedText;
        }
    }
}
