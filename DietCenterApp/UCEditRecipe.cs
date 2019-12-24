using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCenterApp
{
    public partial class UCEditRecipe : UserControl
    {
        //Class variables
        public string ImageURL;
        public int SelectedRowID;

        //Event handlers
        public event EventHandler CanceledRecipe, SavedRecipe;

        public UCEditRecipe()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                tbName.Enabled = true;
                tbDecription.Enabled = true;
                btnChangeImage.Visible = true;
                btnRemoveImage.Visible = true;
                btnCancel.Visible = true;
                btnSave.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if Name is empty
                if (tbName.Text == "")
                {
                    MessageBox.Show("Please insert a name for the recipe", "Name is empty");
                    return;
                }

                //Initialize new recipe
                Recipe recipe = new Recipe();
                recipe.id = SelectedRowID;
                recipe.name = tbName.Text;
                recipe.description= tbDecription.Text;

                //Insert new recipe into Database

                //Trigger save recipe event
                SavedRecipe?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //Trigger cancel recipe event
                CanceledRecipe?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, better tell Sergio about it :P");
            }
        }
    }
}
