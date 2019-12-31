using System.Collections.Generic;
using System.Data;

namespace DietCenterApp
{
    public class Employee : User
    {
        public List<Role> Roles = new List<Role>();

        public class Role
        {
            public int id;
            public string name;

            public Role(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
        }
    }
}
