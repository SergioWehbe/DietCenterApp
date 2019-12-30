using Newtonsoft.Json;
using System.Collections.Generic;

namespace DietCenterApp.Repositories
{
    static class RepoClient
    {
        static UserGroup jsonObject;

        /// <summary>
        /// Return first page of users
        /// </summary>
        /// <returns>UserGroup</returns>
        public static UserGroup GetAllUsers()
        {
            return jsonObject = JsonConvert.DeserializeObject<UserGroup>(HttpRequests.Get("users"));
        }

        /// <summary>
        /// Return next page of users
        /// </summary>
        /// <returns>UserGroup</returns>
        public static UserGroup GetAllUsersNextPage()
        {
            return jsonObject = JsonConvert.DeserializeObject<UserGroup>(HttpRequests.Get(jsonObject.links.next, true));
        }

        /// <summary>
        /// Add a User to Database
        /// </summary>
        /// <param name="user">User to Add</param>
        /// <returns>Response from the server</returns>
        public static string AddUser(User user)
        {
            //Return Response
            return HttpRequests.Send("user", UsertoDictionary(user), "Post");
        }

        /// <summary>
        /// Update a User in the Database
        /// </summary>
        /// <param name="user">User to Update</param>
        /// <returns>Response from the server</returns>
        public static string UpdateUser(User user)
        {
            //Return Response
            return HttpRequests.Send("user/" + user.id, UsertoDictionary(user), "Patch");
        }

        /// <summary>
        /// Delete a User from the database
        /// </summary>
        /// <param name="user">User to be Deleted</param>
        /// <returns>Response from the server</returns>
        public static string DeleteUser(int userID)
        {
            //Return Response
            return HttpRequests.Send("user/" + userID, new Dictionary<string, string>() , "Delete");
        }

        /// <summary>
        /// Converts the User object into Dictionary string,string
        /// </summary>
        /// <param name="user">User to be converted</param>
        /// <returns>User converted to Dictionary string,string</returns>
        private static Dictionary<string, string> UsertoDictionary(User user)
        {
            //Fill Disctionary with user values to send them to Post function
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("name", user.name);
            variables.Add("email", user.email);
            variables.Add("password", user.password);
            variables.Add("phoneNumber", user.phoneNumber);

            //Add roles this way because it is an array
            foreach (var item in user.Roles)
            {
                variables.Add("roles[]", item);
            }

            //Return Dictionary
            return variables;
        }
    }
}
