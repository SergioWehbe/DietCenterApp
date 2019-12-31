using Newtonsoft.Json;
using System.Collections.Generic;
using static DietCenterApp.Employee;

namespace DietCenterApp.Repositories
{
    class RepoLogin
    {
        public static TokenGroup Login(Dictionary<string, string> variables)
        {
            return JsonConvert.DeserializeObject<TokenGroup>(HttpRequests.Send("login", variables, "Post"));
        }

        public static RolesData GetRoles()
        {
            return JsonConvert.DeserializeObject<RolesData>(HttpRequests.Get("role"));
        }

        public static TokenGroup Logout(Dictionary<string, string> variables)
        {
            return JsonConvert.DeserializeObject<TokenGroup>(HttpRequests.Send("logout",variables, "Post"));
        }

        public class RolesData
        {
            public List<Role> data = new List<Role>();
        }
    }
}
