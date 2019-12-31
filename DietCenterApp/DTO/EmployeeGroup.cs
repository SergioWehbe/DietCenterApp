using System.Collections.Generic;
using System.Data;

namespace DietCenterApp
{
    public class EmployeeGroup
    {
        public List<Employee> data;
        public Links links;
        public Meta meta;


        public class Links
        {
            public string first;
            public string last;
            public string prev;
            public string next;
        }
        public class Meta
        {
            public int current_page;
            public int from;
            public int last_page;
            public string path;
            public int per_page;
            public int to;
            public int total;
        }

        public static DataTable ConvertDataIntoDataTable(List<Employee> employees)
        {
            DataTable output = new DataTable();

            //Define data table columns
            output.Columns.Add("id", typeof(string));
            output.Columns.Add("Name", typeof(string));
            output.Columns.Add("Email", typeof(string));
            output.Columns.Add("Phone Number", typeof(string));
            output.Columns.Add("Roles", typeof(string));

            //Fill data table rows with employees values
            foreach (var employee in employees)
            {
                object[] values = new object[5];
                values[0] = employee.id;
                values[1] = employee.name;
                values[2] = employee.email;
                values[3] = employee.phoneNumber;
                values[4] = ConcatinateRoles(employee);
                output.Rows.Add(values);
            }

            return output;
        }

        //Concatinate Roles
        private static string ConcatinateRoles(Employee employee)
        {
            string output = "";
            foreach (var role in employee.Roles)
            {
                output += role.name + ",";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}
