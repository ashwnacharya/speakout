using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;


namespace SpeakYourMind.ImgurHelper
{
    public class ImgurHelper
    {
        private static string IMGUR_ANONYMOUS_API_KEY = "4ac476e3022b6c9ff65382b0fa4a0c37";

        public static string PostToImgurAnonymously(string imagFilePath)
        {
            string imageURL = String.Empty;
            byte[] imageData;

            using (FileStream fileStream = File.OpenRead(imagFilePath))
            {

                imageData = new byte[fileStream.Length];

                fileStream.Read(imageData, 0, imageData.Length);

                fileStream.Close();
            }

            String uploadRequestString =

                HttpUtility.UrlEncode("image", Encoding.UTF8) + "=" +
                HttpUtility.UrlEncode(System.Convert.ToBase64String(imageData)) + "&" +
                HttpUtility.UrlEncode("key", Encoding.UTF8) + "=" +
                HttpUtility.UrlEncode(IMGUR_ANONYMOUS_API_KEY, Encoding.UTF8);

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://api.imgur.com/2/upload.json");


            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ServicePoint.Expect100Continue = false;

            using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                streamWriter.Write(uploadRequestString);
                streamWriter.Close();
            }



            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader responseReader = new StreamReader(responseStream))
                    {
                        string jsonData = responseReader.ReadToEnd();
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        IDictionary<string, object> jsonObject = serializer.Deserialize<IDictionary<string, object>>(jsonData);
                        IDictionary<string, object> upload = jsonObject["upload"] as IDictionary<string, object>;
                        IDictionary<string, object> links = upload["links"] as IDictionary<string, object>;
                        imageURL = links["imgur_page"] as string;

                    }
                }

            }

            return imageURL;

        }

    }
}
