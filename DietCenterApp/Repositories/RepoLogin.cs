using Newtonsoft.Json;
using System.Collections.Generic;

namespace DietCenterApp.Repositories
{
    class RepoLogin
    {
        static TokenGroup jsonObject;

        public static TokenGroup Login(Dictionary<string, string> variables)
        {
            return jsonObject = JsonConvert.DeserializeObject<TokenGroup>(HttpRequests.Send("login", variables, "Post"));
        }

        public static TokenGroup Logout(Dictionary<string, string> variables)
        {
            return jsonObject = JsonConvert.DeserializeObject<TokenGroup>(HttpRequests.Send("logout",variables, "Post"));
        }
    }
}
