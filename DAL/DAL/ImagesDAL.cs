using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    /// <summary>
    /// class for taking or updating data from the pictures table
    /// </summary>
    public static class ImagesDAL
    {
        /// <summary>
        /// inserts the path of the image
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="address"></param>
        public static void InsertImagePath(string imagePath, int addressID)
        {
            string sql = "INSERT INTO Pictures (PicPath, PicAddressID, PicDate)" +
            "VALUES('" + imagePath + "', " + addressID + ", '" + DateTime.Now.ToString() + "'); ";
            DBHelper.ExecuteNonQuery(sql);
        }


        /// <summary>
        /// Returns all picture directories
        /// </summary>
        /// <returns></returns>
        public static DataTable AllPictures()
        {
            string sql = "SELECT * " +
                "FROM Pictures";
            DataTable dataTable;
            dataTable = DBHelper.GetDataTable(sql);
            return dataTable;
        }


        /// <summary>
        /// retrieving the image that was taken the most recently in a ceratin address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string ReturnMostRecentImagePathInAddress(int addressID)
        {
            string sql = "SELECT top 1 Pictures.PicPath " +
                "FROM Pictures " +
                "WHERE PicAddressID = " + addressID + " " +
                "ORDER BY PictureID DESC;";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable.Rows.Count <= 0) //if there are no such records
            {
                throw new ArgumentException("No image found");
            }
            //else

            string mostRecentImagePath = dataTable.Rows[0][0].ToString();
            return mostRecentImagePath;
        }

        /// <summary>
        /// retrieving all the data of all images that were taken in a certain address
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns>list of imageData of images in a certain address</returns>
        public static List<ImageData> RetrieveImageDataFromAddress(int addressID)
        {
            List<ImageData> imageDatas = new List<ImageData>();
            string sql = "SELECT PicPath, PicDate "  +
                "FROM Pictures " +
                "WHERE PicAddressID = " + addressID + ";";
            DataTable dataTable = DBHelper.GetDataTable(sql);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string path = dataTable.Rows[i][0].ToString();
                string date = dataTable.Rows[i][1].ToString();
                imageDatas.Add(new ImageData(addressID, path, date));
            }

            return imageDatas;
        }

        /// <summary>
        /// retrieving the path of an image with a certain addressID and that was added in a certain date 
        /// </summary>
        /// <param name="addressID"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string RetrieveImageInDatePath(int addressID, string date)
        {
            string sql = "SELECT PicPath " +
                "FROM Pictures " +
                "WHERE PicAddressID = " + addressID + " AND PicDate ='" + date + "';";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            string imagePath = dataTable.Rows[0][0].ToString();
            if (dataTable.Rows.Count <= 0)
            {
                throw new Exception("wrong details");
            }
            else
            {
                return imagePath;
            }
        }
    }
}
