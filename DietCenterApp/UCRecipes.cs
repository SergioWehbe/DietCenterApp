using System.Collections.Generic;
using System.Windows.Forms;
using DietCenterApp.Repositories;
using Newtonsoft.Json;

namespace DietCenterApp
{
    public partial class UCRecipes : UserControl
    {
        public UCRecipes()
        {
            InitializeComponent();
            FillDGVRecipes();
        }


        //Global Variables
        Recipe jsonObject;
        List<Recipe.Data> recipes;

        private void FillDGVRecipes()
        {
            //Get JsonObject from Api
            jsonObject = (Recipe) RepoRecipe.GetAllRecipes();

            //Save Recipes
            recipes = jsonObject.data;

            //Convert List recipes to DataTable
            dgvRecipes.DataSource = Recipe.ConvertDataIntoDataTable(recipes);

            //Set column visibility
            dgvRecipes.Columns["id"].Visible = false;
        }
    }
}
