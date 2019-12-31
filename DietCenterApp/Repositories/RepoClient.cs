using Newtonsoft.Json;
using System.Collections.Generic;

namespace DietCenterApp.Repositories
{
    static class RepoClient
    {
        static ClientGroup jsonObject;

        /// <summary>
        /// Return first page of clients
        /// </summary>
        /// <returns>ClientGroup</returns>
        public static ClientGroup GetAlllCients()
        {
            return jsonObject = JsonConvert.DeserializeObject<ClientGroup>(HttpRequests.Get("clients"));
        }

        /// <summary>
        /// Return next page of clients
        /// </summary>
        /// <returns>ClientGroup</returns>
        public static ClientGroup GetAllClientsNextPage()
        {
            return jsonObject = JsonConvert.DeserializeObject<ClientGroup>(HttpRequests.Get(jsonObject.links.next, true));
        }

        /// <summary>
        /// Add a Client to Database
        /// </summary>
        /// <param name="client">Client to Add</param>
        /// <returns>Response from the server</returns>
        public static string AddClient(Client client)
        {
            //Return Response
            return HttpRequests.Send("client", ClienttoDictionary(client), "Post");
        }

        /// <summary>
        /// Update a Client in the Database
        /// </summary>
        /// <param name="client">Client to Update</param>
        /// <returns>Response from the server</returns>
        public static string UpdateClient(Client client)
        {
            //Return Response
            return HttpRequests.Send("client/" + client.id, ClienttoDictionary(client), "Patch");
        }

        /// <summary>
        /// Delete a Client from the database
        /// </summary>
        /// <param name="client">Client to be Deleted</param>
        /// <returns>Response from the server</returns>
        public static string DeleteClient(string clientID)
        {
            //Return Response
            return HttpRequests.Send("client/" + clientID, new Dictionary<string, string>() , "Delete");
        }

        /// <summary>
        /// Converts the Client object into Dictionary string,string
        /// </summary>
        /// <param name="client">Client to be converted</param>
        /// <returns>Client converted to Dictionary string,string</returns>
        private static Dictionary<string, string> ClienttoDictionary(Client client)
        {
            //Fill Disctionary with client values to send them to Post function
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("name", client.name);
            variables.Add("email", client.email);
            variables.Add("password", client.password);
            variables.Add("phonenumber", client.phoneNumber);

            //Return Dictionary
            return variables;
        }
    }
}
