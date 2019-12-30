using System.Collections.Generic;
using System.Data;

namespace DietCenterApp
{
    public class User
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public string phoneNumber;
        public List<string> Roles = new List<string>();
    }
}
