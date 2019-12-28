using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DietCenterApp.Repositories;

namespace DietCenterApp.UserControls.Chef
{
    public partial class UCEditRecipe : UserControl
    {
        //Class variables
        public string ImagePath;
        public string base64Image;
        public int SelectedRowID;

        //Event handlers
        public event EventHandler CanceledRecipe, SavedRecipe, BackToRecipesPressed;

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
                tbPrice.Enabled = true;
                btnChangeImage.Show();
                btnRemoveImage.Show();
                btnCancel.Show();
                btnSave.Show();
                btnBack.Hide();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
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
                Recipe recipe = new Recipe()
                {
                    id = SelectedRowID,
                    name = tbName.Text,
                    description = tbDecription.Text,
                    price = tbPrice.Text,
                    image = base64Image = pbRecipe.Image == null? "" : Conversion.ImageToBase64((Image)pbRecipe.Image.Clone())
                };

                //Insert new recipe into Database
                //If user Unauthorized, show Message
                if (RepoRecipe.UpdateRecipe(recipe).Contains("Unauthorized"))
                {
                    MessageBox.Show("You are Unauthorized to change the recipe");
                    return;
                }

                //Trigger save recipe event
                SavedRecipe?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            try
            {
                //Initialize file dialog
                OpenFileDialog file = new OpenFileDialog();

                //Set allowed files
                file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                //Set dialog initial directory to recipes images that is contained in the directory of the app
                if (System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Recipes Images"))
                {
                    file.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + @"Recipes Images";
                }
                else
                {
                    file.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                }

                //Open file dialog and check if user pressed OK
                if (file.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = file.FileName;
                    pbRecipe.ImageLocation = ImagePath;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
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
                ExceptionHandling(ex);
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbRecipe.Image = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToRecipesPressed?.Invoke(this, EventArgs.Empty);
        }

        //Function to handle the Exception in one place instead of handling each function's exceptions
        private void ExceptionHandling(Exception ex)
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
}
