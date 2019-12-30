using System.Collections.Generic;
using System.Data;

namespace DietCenterApp
{
    public class UserGroup
    {
        public List<User> data;
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

        public static DataTable ConvertDataIntoDataTable(List<User> users)
        {
            DataTable output = new DataTable();

            //Define data table columns
            output.Columns.Add("id", typeof(string));
            output.Columns.Add("Name", typeof(string));
            output.Columns.Add("Email", typeof(string));
            output.Columns.Add("Phone Number", typeof(string));

            //Fill data table rows with users values
            foreach (var user in users)
            {
                object[] values = new object[4];
                values[0] = user.id;
                values[1] = user.name;
                values[2] = user.email;
                values[3] = user.phoneNumber;
                output.Rows.Add(values);
            }

            return output;
        }
    }
}
