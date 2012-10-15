using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections;
using System.Text.RegularExpressions;

namespace SpeakYourMind.BitlyHelper
{
    public class BitlyHelper
    {

        private static string BITLY_LOGIN_NAME = "speakyourmind";
        private static string BITLY_API_KEY = "R_6eae200db3d6730761306459ff5f245d";

        private static List<string> DO_NOT_SHORTEN_HOSTS = new List<string>();

        static BitlyHelper()
        {
            DO_NOT_SHORTEN_HOSTS.Add("IMGUR.COM");
            DO_NOT_SHORTEN_HOSTS.Add("BIT.LY");
        }
    

        private static string SHORTEN_REQUEST_FORMAT = @"http://api.bit.ly/v3/shorten?login={0}&apikey={1}&longurl={2}&format=json";

        //Copy pasta from here: http://www.regexguru.com/2008/11/detecting-urls-in-a-block-of-text/ 
        //I am no Regex Junkie!
        private static string URL_DETECTION_REGEX = @"\b(?:(?:https?|ftp|file)://|www\.|ftp\.)[-A-Z0-9+&@#/%=~_|$?!:,.]*[A-Z0-9+&@#/%=~_|$]";

        public static string GetShortenedURL(string longURL)
        {
            if (DoNotShorten(longURL))
            {
                return longURL;
            }

            string shortenRequest = String.Format(SHORTEN_REQUEST_FORMAT, BITLY_LOGIN_NAME, BITLY_API_KEY, longURL);
            string shortURL = longURL;

            WebRequest request = WebRequest.Create(shortenRequest);

            using (WebResponse response = request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(responseStream))
                    {
                        String jsonData = streamReader.ReadToEnd();
                        streamReader.Close();

                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        IDictionary<string, object> jsonObject =  serializer.Deserialize<IDictionary<string, object>>(jsonData);
                        IDictionary<string, object> data = jsonObject["data"] as IDictionary<string, object>;

                        shortURL = data["url"].ToString();


                    }
                }
            }

            return shortURL;

        }

        private static bool DoNotShorten(string longURL)
        {
            try
            {
                Uri uri = new Uri(longURL);
                if (DO_NOT_SHORTEN_HOSTS.Contains(uri.Host.ToUpperInvariant()))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            

            return false;

        }

        public static string GetURLsShortenedinBlockOFText(string blockOfText)
        {
            string output = blockOfText;
            if (Regex.IsMatch(blockOfText, URL_DETECTION_REGEX, RegexOptions.IgnoreCase))
            {
                MatchCollection matches = Regex.Matches(blockOfText, URL_DETECTION_REGEX, RegexOptions.IgnoreCase);
                
                foreach(Match match in matches)
                {
                    string urlMatch = match.Value;
                    string shortenedURL = GetShortenedURL(urlMatch);

                    output = output.Replace(urlMatch, shortenedURL);
                }
            }

            return output;

        }
    }
}
