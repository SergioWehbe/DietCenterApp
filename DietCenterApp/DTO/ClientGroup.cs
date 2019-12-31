using System.Collections.Generic;
using System.Data;

namespace DietCenterApp
{
    public class ClientGroup
    {
        public List<Client> data;
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

        public static DataTable ConvertDataIntoDataTable(List<Client> clients)
        {
            DataTable output = new DataTable();

            //Define data table columns
            output.Columns.Add("id", typeof(string));
            output.Columns.Add("Name", typeof(string));
            output.Columns.Add("Email", typeof(string));
            output.Columns.Add("Phone Number", typeof(string));

            //Fill data table rows with clients values
            foreach (var client in clients)
            {
                object[] values = new object[4];
                values[0] = client.id;
                values[1] = client.name;
                values[2] = client.email;
                values[3] = client.phoneNumber;
                output.Rows.Add(values);
            }

            return output;
        }
    }
}
