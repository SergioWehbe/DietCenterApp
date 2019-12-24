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

        public static string Post(string api, Dictionary<string,string> variables, bool fullURL = false)
        {
            //Create HttpWebRequest with given api
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullURL? api : @API_BASE+api);

            //Fill postData of the Request
            string postData = "";
            foreach (var item in variables)
            {
                postData += "&" + item.Key + "=" + Uri.EscapeDataString(item.Value);
            }
            //Remove first "&"
            postData = postData.Substring(1);
            //Encode postData string as bytes
            var data = Encoding.ASCII.GetBytes(postData);

            //Set request attributes
            request.Method = "POST";
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
    }
}
