using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DietCenterApp
{
    class HttpRequests
    {
        static string API_BASE = "http://dietcenter/api/";
        public static string Get(string api, bool fullURL = false)
        {
            //Create HttpWebRequest with given api
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullURL? api : @API_BASE+api);

            //Get Response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Return Response as a string
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        public static string Send(string api, Dictionary<string,string> variables, string requestMethod, bool fullURL = false)
        {
            //Create HttpWebRequest with given api
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullURL? api : @API_BASE+api);
            request.Headers.Add("Authorization", UserSession.TokenType + " " + UserSession.AccessToken);

            //Fill postData of the Request
            string postData = "";
            foreach (var item in variables)
            {
                postData += "&" + item.Key + "=" + UriEscapeDataString(item.Value);
            }
            //Remove first "&"
            postData = postData.Length>0? postData.Substring(1) : "";
            //Encode postData string as bytes
            var data = Encoding.ASCII.GetBytes(postData);

            //Set request attributes
            request.Method = requestMethod;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            //Execute Request (Write data)
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            //Get Response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Return Response as a string
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        private static string UriEscapeDataString(string value)
        {
            int limit = 2000;

            string uri = "";
            int loops = value.Length / limit;

            for (int i = 0; i <= loops; i++)
            {
                if (i < loops)
                {
                    uri += Uri.EscapeDataString(value.Substring(limit * i, limit));
                }
                else
                {
                    uri += Uri.EscapeDataString(value.Substring(limit * i));
                }
            }
            return uri;
        }
    }
}
