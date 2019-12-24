using Newtonsoft.Json;
using System.Collections.Generic;

namespace DietCenterApp.Repositories
{
    class RepoLogin
    {
        static TokenGroup jsonObject;

        public static object Login(Dictionary<string, string> variables)
        {
            return jsonObject = JsonConvert.DeserializeObject<TokenGroup>(HttpRequests.Post("login", variables));
        }

        public static object Logout(Dictionary<string, string> variables)
        {
            return jsonObject = JsonConvert.DeserializeObject<TokenGroup>(HttpRequests.Post("logout",variables));
        }
    }
}
