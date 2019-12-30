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

namespace DietCenterApp.UserControls.Dietitian
{
    public partial class Clients : Form
    {
        //Class Variables
        Dashboard parent;
        EditClient editClient;
        RecipeGroup jsonObject;
        List<Recipe> recipes;
        DataTable clientsDT;
        int SelectedRowIndex;

        public Clients(Dashboard parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void InitializeEditClient()
        {
            editClient = new EditClient(this);
            editClient.TopLevel = false;
            editClient.FormBorderStyle = FormBorderStyle.None;
            panel1.Hide();
            panel1.BringToFront();
            panel1.Controls.Add(editClient);
            editClient.Show();
        }

        private void GetRecipes()
        {
            try
            {
                //Get JsonObject from Api
                jsonObject = RepoClient.GetAllClients();

                //Save Recipes
                recipes = jsonObject.data;

                //Convert List recipes to DataTable
                dgvRecipes.DataSource = clientsDT = RecipeGroup.ConvertDataIntoDataTable(recipes);

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
                jsonObject = RepoClient.GetAllClientsNextPage();

                //Convert List recipes in jsonObject to DataTable
                DataTable newRecipes = RecipeGroup.ConvertDataIntoDataTable(jsonObject.data);

                //Add new recipes to DataTable
                clientsDT.Merge(newRecipes);

                //Set new DataTable as Data Grid View DataSource
                dgvRecipes.DataSource = clientsDT;
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
            editClient.SelectedRowID = SelectedRowIndex;
            editClient.tbName.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Recipe"].Value.ToString();
            editClient.tbDecription.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Description"].Value.ToString();
            editClient.tbPrice.Text = dgvRecipes.Rows[SelectedRowIndex].Cells["Price"].Value.ToString();

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
                    dgvRecipes.DataSource = clientsDT;
                    return;
                }

                searchedDT = clientsDT.Select("Recipe LIKE '%" + tbRecipeSearch.Text + "%'").CopyToDataTable();
            }
            catch (Exception)
            {
                //If search text is not Found, DataSource = Empty DataTable
                searchedDT = clientsDT.Clone();
                searchedDT.Clear();
            }

            dgvRecipes.DataSource = searchedDT;
        }

        //Event Saved Recipe
        public void EditClient_SavedRecipe()
        {
            try
            {
                //Update recipe in dgvRecipes
                dgvRecipes.Rows[SelectedRowIndex].Cells["Recipe"].Value = editClient.tbName.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Description"].Value = editClient.tbDecription.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Price"].Value = editClient.tbPrice.Text;
                dgvRecipes.Rows[SelectedRowIndex].Cells["Image"].Value = editClient.base64Image;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }
        //Event Added Recipe
        public void AddClient_AddedClient(User user)
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
                        RepoClient.DeleteRecipe(Int16.Parse(row.Cells["id"].Value.ToString()));
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
            else
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
