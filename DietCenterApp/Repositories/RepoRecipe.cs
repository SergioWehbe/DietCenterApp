using Newtonsoft.Json;

namespace DietCenterApp.Repositories
{
    class RepoRecipe
    {
        public static object GetAllRecipes()
        {
            return JsonConvert.DeserializeObject<Recipe>(HttpRequests.Get("http://127.0.0.1:8000/api/recipes"));
        }
    }
}
