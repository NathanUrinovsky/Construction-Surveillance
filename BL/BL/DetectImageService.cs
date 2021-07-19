using System;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;


namespace BL
{
    public class DetectImageService
    {

        private string urlTarget;
        public DetectImageService()
        {
            this.urlTarget = "http://localhost:5000/detections/"; //default value of urlTarget
        }

        public DetectImageService(string urlTarget)
        {
            this.urlTarget = urlTarget;
        }

        /// <summary>
        /// detecting buildings in an image
        /// </summary>
        /// <param name="originalImagePath"></param>
        /// <returns>returns the url of the detected image</returns>
        public string Detect(string originalImagePath)
        {
            //using makes sure httpClient will be deleted as soon as the function ends
            using (var httpClient = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                MultipartFormDataContent form = new MultipartFormDataContent();
                // url to which we are sending a request
                httpClient.BaseAddress = new Uri(this.urlTarget);
                //converting an image to a byte array
                ByteArrayContent fileContent = new ByteArrayContent(File.ReadAllBytes(originalImagePath));
                //multipart/form-data is encoding type for files
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data"); 
                form.Add(fileContent, "file", Path.GetFileName(originalImagePath));
                //making a post request
                HttpResponseMessage response = httpClient.PostAsync(new Uri(this.urlTarget), form).Result; 
                response.EnsureSuccessStatusCode();
                httpClient.Dispose();
                //storing what the request returned in a variable
                string imageUrl = response.Content.ReadAsStringAsync().Result;
                return imageUrl;
            }
        }

        //Getters and setters
        public string GetUrlTarget()
        {
            return this.urlTarget;
        }

        public void SetUrlTarget(string urlTarget)
        {
            this.urlTarget = urlTarget;
        }
    }
}


