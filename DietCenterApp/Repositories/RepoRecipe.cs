using Newtonsoft.Json;

namespace DietCenterApp.Repositories
{
    class RepoRecipe
    {
        static RecipeGroup jsonObject;

        public static object GetAllRecipes()
        {
            return jsonObject = JsonConvert.DeserializeObject<RecipeGroup>(HttpRequests.Get("recipes"));
        }

        public static object GetAllRecipesNextPage()
        {
            return jsonObject = JsonConvert.DeserializeObject<RecipeGroup>(HttpRequests.Get(jsonObject.links.next, true));
        }
    }
}
