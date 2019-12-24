using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DietCenterApp.Repositories;

namespace DietCenterApp
{
    public partial class UCRecipes : UserControl
    {
        //Class variables
        int SelectedRowIndex;

        public UCRecipes()
        {
            InitializeComponent();
            FillDGVRecipes();
        }


        //Global Variables
        RecipeGroup jsonObject;
        List<RecipeGroup.Data> recipes;
        DataTable recipesDT;

        private void FillDGVRecipes()
        {
            try
            {
                //Get JsonObject from Api
                jsonObject = (RecipeGroup)RepoRecipe.GetAllRecipes();

                //Save Recipes
                recipes = jsonObject.data;

                //Convert List recipes to DataTable
                dgvRecipes.DataSource = recipesDT = RecipeGroup.ConvertDataIntoDataTable(recipes);

                //Set id column visibility false
                dgvRecipes.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to the remote server"))
                {
                    MessageBox.Show("Could not connect to server, check your internet connection");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Check if jsonObject is not null
                if (jsonObject.links.next == null) return;

                //Get JsonObject from Api
                jsonObject = (RecipeGroup)RepoRecipe.GetAllRecipesNextPage();

                //Convert List recipes in jsonObject to DataTable
                DataTable newRecipes = RecipeGroup.ConvertDataIntoDataTable(jsonObject.data);

                //Add new recipes to DataTable
                foreach (var obj in newRecipes.Rows)
                {
                    recipesDT.Rows.Add(obj);
                }

                //Set new DataTable as Data Grid View DataSource
                dgvRecipes.DataSource = recipesDT;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to the remote server"))
                {
                    MessageBox.Show("Could not connect to server, check your internet connection");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void dgvRecipes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //In case the header's row was double clicked, return
                if (e.RowIndex < 0) return;

                //Set SelectedRowIndex's values
                SelectedRowIndex = e.RowIndex;

                //Load the selected recipe
                LoadSelectedRecipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //Load the selected recipe
        private void LoadSelectedRecipe()
        {
            //Set all data to selected recipe
            ucEditRecipe1.SelectedRowID = Int16.Parse(dgvRecipes.Rows[SelectedRowIndex].Cells["id"].Value.ToString());
            ucEditRecipe1.tbName.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Recipe"].Value.ToString();
            ucEditRecipe1.tbDecription.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Description"].Value.ToString();
            //ucEditRecipe1.ImageURL = ucEditRecipe1.pbRecipe.ImageLocation = dgvRecipes.Rows[SelectedRowIndex].Cells["ImageURL"].Value.ToString();   

            //Disbale editing in ucEditRecipe1
            UCSelectedRecipe1_DisableEditing();

            //Set uc to visible and bring to front
            ucEditRecipe1.Visible = true;
            ucEditRecipe1.BringToFront();
        }

        //UCSelectedRecipe disable editing mode, get back to the default view with editing disbaled
        private void UCSelectedRecipe1_DisableEditing()
        {
            //Disable editable fields
            ucEditRecipe1.tbName.Enabled = false;
            ucEditRecipe1.tbDecription.Enabled = false;

            //Hide editing buttons
            ucEditRecipe1.btnCancel.Visible = false;
            ucEditRecipe1.btnSave.Visible = false;
            ucEditRecipe1.btnChangeImage.Visible = false;
            ucEditRecipe1.btnRemoveImage.Visible = false;
        }

        private void tbRecipeSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable searchedDT;
            try
            {
                if (tbRecipeSearch.Text == "")
                {
                    //If Empty search box, DataSource = All Recipes
                    dgvRecipes.DataSource = recipesDT;
                    return;
                }

                searchedDT = recipesDT.Select("Recipe LIKE '%" + tbRecipeSearch.Text + "%'").CopyToDataTable();
            }
            catch (Exception)
            {
                //If search text is not Found, DataSource = Empty DataTable
                searchedDT = recipesDT.Clone();
                searchedDT.Clear();
            }

            dgvRecipes.DataSource = searchedDT;
        }

        //Event Saved Recipe
        private void ucEditRecipe1e1_SavedRecipe(object sender, EventArgs e)
        {
            try
            {
                //Return to disabled editing mode (default view)
                UCSelectedRecipe1_DisableEditing();

                //Refresh recipes in the background
                //LoadRecipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, better tell Sergio about it :P");
            }
        }

        //Event Canceled Recipe
        private void ucEditRecipe11_CanceledRecipe(object sender, EventArgs e)
        {
            try
            {
                //Reload the selected recipe to retreive original values of the recipes' variables before editing, and disable editing mode
                LoadSelectedRecipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, better tell Sergio about it :P");
            }
        }
    }
}
