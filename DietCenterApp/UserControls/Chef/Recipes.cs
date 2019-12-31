using DietCenterApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCenterApp.UserControls.Chef
{
    public partial class Recipes : Form
    {
        //Class variables
        Dashboard parent;
        EditRecipe editRecipe;
        RecipeGroup jsonObject;
        List<Recipe> recipes;
        DataTable recipesDT;
        int SelectedRowIndex;

        public Recipes(Dashboard parent)
        {
            this.parent = parent;
            InitializeComponent();
            GetRecipes();
            InitializeEditRecipe();
        }

        private void InitializeEditRecipe()
        {
            editRecipe = new EditRecipe(this);
            editRecipe.TopLevel = false;
            editRecipe.FormBorderStyle = FormBorderStyle.None;
            panel1.Hide();
            panel1.BringToFront();
            panel1.Controls.Add(editRecipe);
            editRecipe.Show();
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
            editRecipe.SelectedRowID = SelectedRowIndex;
            editRecipe.tbName.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Recipe"].Value.ToString();
            editRecipe.tbDescription.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Description"].Value.ToString();
            editRecipe.tbPrice.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Price"].Value.ToString();
            editRecipe.base64Image = dgvRecipes.Rows[SelectedRowIndex].Cells["Image"].Value.ToString();
            editRecipe.pbRecipe.Image = editRecipe.base64Image == "" ? null : Conversion.Base64ToImage(editRecipe.base64Image);

            //Bring ucEdit to front
            panel1.Show();
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
        public void EditRecipe_SavedRecipe()
        {
            try
            {
                //Update recipe in dgvRecipes
                dgvRecipes.Rows[SelectedRowIndex].Cells["Recipe"].Value = editRecipe.tbName.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Description"].Value = editRecipe.tbDescription.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Price"].Value = editRecipe.tbPrice.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Image"].Value = editRecipe.base64Image;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Event Added Recipe
        public void AddRecipe_AddedRecipe(Recipe recipe)
        {
            try
            {
                GetRecipes();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Delete Recipe
        private void dgvRecipes_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                //Show Message box to confirm the deletion of the selected recipes
                if (MessageBox.Show("Are you sure you want to delete the selected recipes?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Cancel)
                {
                    //If deletion is canceled, exit function
                    e.Cancel = true;
                    return;
                }

                //Delete each selected recipe
                foreach (DataGridViewRow row in dgvRecipes.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        RepoRecipe.DeleteRecipe(Int16.Parse(row.Cells["id"].Value.ToString()));
                    }
                }
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
            else if (ex.Message.Contains("Error converting value {null} to type 'System.Int32'. Path 'meta.from', line 1, position 182."))
            {
                MessageBox.Show("There are no recipes");
            }
            else
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
