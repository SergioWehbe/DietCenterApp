using Newtonsoft.Json;
using System.Collections.Generic;

namespace DietCenterApp.Repositories
{
    static class RepoRecipe
    {
        static RecipeGroup jsonObject;

        /// <summary>
        /// Return first page of recipes
        /// </summary>
        /// <returns>RecipeGroup</returns>
        public static RecipeGroup GetAllRecipes()
        {
            return jsonObject = JsonConvert.DeserializeObject<RecipeGroup>(HttpRequests.Get("recipes"));
        }

        /// <summary>
        /// Return next page of recipes
        /// </summary>
        /// <returns>RecipeGroup</returns>
        public static RecipeGroup GetAllRecipesNextPage()
        {
            return jsonObject = JsonConvert.DeserializeObject<RecipeGroup>(HttpRequests.Get(jsonObject.links.next, true));
        }

        /// <summary>
        /// Add a Recipe to Database
        /// </summary>
        /// <param name="recipe">Recipe to Add</param>
        /// <returns>Response from the server</returns>
        public static string AddRecipe(Recipe recipe)
        {
            //Return Response
            return HttpRequests.Send("recipe", RecipetoDictionary(recipe), "Post");
        }

        /// <summary>
        /// Update a Recipe in the Database
        /// </summary>
        /// <param name="recipe">Recipe to Update</param>
        /// <returns>Response from the server</returns>
        public static string UpdateRecipe(Recipe recipe)
        {
            //Return Response
            return HttpRequests.Send("recipe/" + recipe.id, RecipetoDictionary(recipe), "Patch");
        }

        /// <summary>
        /// Delete a Recipe from the database
        /// </summary>
        /// <param name="recipe">Recipe to be Deleted</param>
        /// <returns>Response from the server</returns>
        public static string DeleteRecipe(Recipe recipe)
        {
            //Return Response
            return HttpRequests.Send("recipe/" + recipe.id, RecipetoDictionary(recipe), "Delete");
        }

        /// <summary>
        /// Converts the Recipe object into Dictionary string,string
        /// </summary>
        /// <param name="recipe">Recipe to be converted</param>
        /// <returns>Recipe converted to Dictionary string,string</returns>
        private static Dictionary<string, string> RecipetoDictionary(Recipe recipe)
        {
            //Fill Disctionary with recipe values to send them to Post function
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("name", recipe.name);
            variables.Add("description", recipe.description);
            variables.Add("price", recipe.price);
            variables.Add("image", "data:image/jpeg;base64," + recipe.image);

            //Return Dictionary
            return variables;
        }
    }
}
