using System;

namespace DAL
{
    public class ImageData
    {
        private int addressID;
        private string path;
        private DateTime date;

        /// <summary>
        /// emtpy constructor
        /// </summary>
        public ImageData()
        {

        }

        /// <summary>
        /// getting all the properties of an Image (list below)
        /// </summary>
        /// <param name="addressID"></param>
        /// <param name="path"></param>
        /// <param name="dateInput"></param>
        public ImageData(int addressID, string path, string date)
        {
            this.addressID = addressID;
            this.path = path;
            this.date = Convert.ToDateTime(date);
        }


        //-----Getters-----
        public int GetAddressID()
        {
            return this.addressID;
        }

        public string GetPath()
        {
            return this.path;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        //-----Setters-----

        public void SetAddressID(int addressID)
        {
            this.addressID = addressID;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }

        public void SetDate(DateTime dateTime)
        {
            this.date = dateTime;
        }
    }
}
