using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DietCenterApp.Repositories;

namespace DietCenterApp.UserControls.Chef
{
    public partial class UCRecipes : UserControl
    {
        //Class variables
        RecipeGroup jsonObject;
        List<Recipe> recipes;
        DataTable recipesDT;
        int SelectedRowIndex;

        public UCRecipes()
        {
            InitializeComponent();
            ucAddRecipe1.SendToBack();
            ucEditRecipe1.SendToBack();
            GetRecipes();
        }

        private void GetRecipes()
        {
            try
            {
                //Get JsonObject from Api
                jsonObject = RepoRecipe.GetAllRecipes();

                //Save Recipes
                recipes = jsonObject.data;

                //Convert List recipes to DataTable
                dgvRecipes.DataSource = recipesDT = RecipeGroup.ConvertDataIntoDataTable(recipes);

                //Set id column visibility false
                dgvRecipes.Columns["id"].Visible = false;
                dgvRecipes.Columns["image"].Visible = false;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Check if jsonObject is not null
                if (jsonObject.links.next == null) return;

                //Get JsonObject from Api
                jsonObject = RepoRecipe.GetAllRecipesNextPage();

                //Convert List recipes in jsonObject to DataTable
                DataTable newRecipes = RecipeGroup.ConvertDataIntoDataTable(jsonObject.data);

                //Add new recipes to DataTable
                recipesDT.Merge(newRecipes);

                //Set new DataTable as Data Grid View DataSource
                dgvRecipes.DataSource = recipesDT;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
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
                ExceptionHandling(ex);
            }
        }

        //Load the selected recipe
        private void LoadSelectedRecipe()
        {
            //Set all data to selected recipe
            ucEditRecipe1.SelectedRowID = Int16.Parse(dgvRecipes.Rows[SelectedRowIndex].Cells["id"].Value.ToString());
            ucEditRecipe1.tbName.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Recipe"].Value.ToString();
            ucEditRecipe1.tbDecription.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Description"].Value.ToString();
            ucEditRecipe1.tbPrice.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Price"].Value.ToString();
            ucEditRecipe1.base64Image = dgvRecipes.Rows[SelectedRowIndex].Cells["Image"].Value.ToString();
            ucEditRecipe1.pbRecipe.Image = ucEditRecipe1.base64Image == "" ? null : Conversion.Base64ToImage(ucEditRecipe1.base64Image);

            //Disbale editing in ucEditRecipe1
            UCEditRecipe1_DisableEditing();

            //Bring ucEdit to front
            ucEditRecipe1.BringToFront();
        }

        //UCSelectedRecipe disable editing mode, get back to the default view with editing disbaled
        private void UCEditRecipe1_DisableEditing()
        {
            //Disable editable fields
            ucEditRecipe1.tbName.Enabled = false;
            ucEditRecipe1.tbDecription.Enabled = false;
            ucEditRecipe1.tbPrice.Enabled = false;

            //Show Edit and Back buttons
            ucEditRecipe1.btnEdit.Show();
            ucEditRecipe1.btnBack.Show();

            //Hide editing buttons
            ucEditRecipe1.btnCancel.Hide();
            ucEditRecipe1.btnSave.Hide();
            ucEditRecipe1.btnChangeImage.Hide();
            ucEditRecipe1.btnRemoveImage.Hide();
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
        private void UCEditRecipe1_SavedRecipe(object sender, EventArgs e)
        {
            try
            {
                //Update recipe in dgvRecipes
                dgvRecipes.Rows[SelectedRowIndex].Cells["Recipe"].Value = ucEditRecipe1.tbName.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Description"].Value = ucEditRecipe1.tbDecription.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Price"].Value = ucEditRecipe1.tbPrice.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Image"].Value = ucEditRecipe1.base64Image;

                //Return to disabled editing mode (default view)
                UCEditRecipe1_DisableEditing();

                //Bring ucEdit to front
                ucEditRecipe1.SendToBack();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Event Canceled Recipe
        private void UCEditRecipe1_CanceledRecipe(object sender, EventArgs e)
        {
            try
            {
                //Reload the selected recipe to retreive original values of the recipes' variables before editing, and disable editing mode
                LoadSelectedRecipe();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Event Canceled Recipe
        private void UCAddRecipe1_AddedRecipe(object sender, EventArgs e)
        {
            try
            {
                //Refresh Recipes Grid
                GetRecipes();

                //Send ucAdd to back and clear fields
                ucAddRecipe1.SendToBack();
                ucAddRecipe1.tbPrice.Clear();
                ucAddRecipe1.tbName.Clear();
                ucAddRecipe1.tbDecription.Clear();
                ucAddRecipe1.pbRecipe.Image = null;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAddRecipe1.BringToFront();
        }

        //Event Back To Recipes
        private void OnBackToRecipes(object sender, EventArgs e)
        {
            try
            {
                ucAddRecipe1.SendToBack();
                ucEditRecipe1.SendToBack();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);

            }
        }

        //Function to handle the Exception in one place instead of handling each function's exceptions
        private void ExceptionHandling(Exception ex)
        {
            if (ex.Message.Contains("Unable to connect to the remote server"))
            {
                MessageBox.Show("Could not connect to server, check your internet connection");
            }
            else if (ex.Message.Contains("The request was aborted: The connection was closed unexpectedly."))
            {
                MessageBox.Show("Could not connect to Database on the server, please contact your Administrator", "Error");
            }
            else
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
