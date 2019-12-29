using System.Collections.Generic;
using System.Data;

namespace DietCenterApp
{
    public class RecipeGroup
    {
        public List<Recipe> data;
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

        public static DataTable ConvertDataIntoDataTable(List<Recipe> recipes)
        {
            DataTable output = new DataTable();

            //Define data table columns
            output.Columns.Add("id", typeof(string));
            output.Columns.Add("Recipe", typeof(string));
            output.Columns.Add("Description", typeof(string));
            output.Columns.Add("Price", typeof(string));
            output.Columns.Add("Image", typeof(string));

            //Fill data table rows with recipes values
            foreach (var recipe in recipes)
            {
                object[] values = new object[5];
                values[0] = recipe.id;
                values[1] = recipe.name;
                values[2] = recipe.description;
                values[3] = recipe.price;
                values[4] = recipe.image.Substring("data:image/jpeg;base64,".Length);
                output.Rows.Add(values);
            }

            return output;
        }
    }
}
