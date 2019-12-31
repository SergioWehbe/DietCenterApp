using Newtonsoft.Json;
using System.Collections.Generic;

namespace DietCenterApp.Repositories
{
    static class RepoEmployee
    {
        static EmployeeGroup jsonObject;

        /// <summary>
        /// Return first page of employees
        /// </summary>
        /// <returns>EmployeeGroup</returns>
        public static EmployeeGroup GetAlllCients()
        {
            return jsonObject = JsonConvert.DeserializeObject<EmployeeGroup>(HttpRequests.Get("employees"));
        }

        /// <summary>
        /// Return next page of employees
        /// </summary>
        /// <returns>EmployeeGroup</returns>
        public static EmployeeGroup GetAllEmployeesNextPage()
        {
            return jsonObject = JsonConvert.DeserializeObject<EmployeeGroup>(HttpRequests.Get(jsonObject.links.next, true));
        }

        /// <summary>
        /// Add a Employee to Database
        /// </summary>
        /// <param name="employee">Employee to Add</param>
        /// <returns>Response from the server</returns>
        public static string AddEmployee(Employee employee)
        {
            //Return Response
            return HttpRequests.Send("employee", EmployeetoDictionary(employee), "Post");
        }

        /// <summary>
        /// Update a Employee in the Database
        /// </summary>
        /// <param name="employee">Employee to Update</param>
        /// <returns>Response from the server</returns>
        public static string UpdateEmployee(Employee employee)
        {
            //Return Response
            return HttpRequests.Send("employee/" + employee.id, EmployeetoDictionary(employee), "Patch");
        }

        /// <summary>
        /// Delete a Employee from the database
        /// </summary>
        /// <param name="employee">Employee to be Deleted</param>
        /// <returns>Response from the server</returns>
        public static string DeleteEmployee(string employeeID)
        {
            //Return Response
            return HttpRequests.Send("employee/" + employeeID, new Dictionary<string, string>() , "Delete");
        }

        /// <summary>
        /// Converts the Employee object into Dictionary string,string
        /// </summary>
        /// <param name="employee">Employee to be converted</param>
        /// <returns>Employee converted to Dictionary string,string</returns>
        private static Dictionary<string, string> EmployeetoDictionary(Employee employee)
        {
            //Fill Disctionary with employee values to send them to Post function
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("name", employee.name);
            variables.Add("email", employee.email);
            variables.Add("password", employee.password);
            variables.Add("phonenumber", employee.phoneNumber);

            //Add roles
            for (int i = 0; i < employee.Roles.Count; i++)
            {
                variables.Add("roles[" + i + "]", employee.Roles[i].id.ToString());
            }

            //Return Dictionary
            return variables;
        }
    }
}
