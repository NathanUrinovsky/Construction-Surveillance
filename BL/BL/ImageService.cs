using System;
using System.Collections.Generic;
using DAL;

namespace BL
{
    /// <summary>
    /// class that contains function related to the pictures.
    /// </summary>
    public class ImageService
    {
        public ImageService()
        {

        }

        /// <summary>
        /// adding a new picture that was taken in a certain address to the system
        /// </summary>
        /// <param name="originalPath"></param> //original path of an image
        /// <param name="addressID"></param>
        public void SaveImage(string newPath, int addressID)
        {
            //adding the image's path to the system
            ImagesDAL.InsertImagePath(newPath, addressID);
        }
        
        /// <summary>
        /// retreiving the directory of the last image that was taken in a certain address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public string ReturnMostRecentImagePathInAddress(int addressID)
        {
            string mostRecentImagePath = ImagesDAL.ReturnMostRecentImagePathInAddress(addressID);
            return mostRecentImagePath;
        }
        
        /// <summary>
        /// retrieving details about images that were taken in a certain address
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns></returns>
        public List<ImageData>RetrieveImagesDataInAddress(int addressID)
        {
            List<DAL.ImageData> imageDatasDAL = ImagesDAL.RetrieveImageDataFromAddress(addressID);
            List<ImageData> imageDatas = new List<ImageData>();

            foreach (var imageData in imageDatasDAL)
            {
                //iterating throught the imagedata list of the dal and filling the imagedata list of the bl
                int idOfAddress = imageData.GetAddressID();
                string pathOfImage = imageData.GetPath();
                DateTime dateOfImage = imageData.GetDate();
                imageDatas.Add(new ImageData() { addressID = idOfAddress, path = pathOfImage, date = dateOfImage });
            }

            return imageDatas;
        }

        /// <summary>
        /// retrieving a path of an image in a certain address and date
        /// </summary>
        /// <param name="addressID"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public string RetrieveImageInDatePath(int addressID, string date)
        {
            try
            {
                string imagePath = ImagesDAL.RetrieveImageInDatePath(addressID, date); //image path in a certain address and date
                return imagePath;
            }
            catch (Exception)
            {
                throw new Exception("wrong details");
            }
        }
    }
}
