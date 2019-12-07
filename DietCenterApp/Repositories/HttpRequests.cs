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

        public static string Get(string api)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@api);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
