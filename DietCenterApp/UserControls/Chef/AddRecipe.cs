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
    public partial class AddRecipe : Form
    {
        //Class variables
        Dashboard parent;
        
        public AddRecipe(Dashboard parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Remove white spaces from beginning and end of the Text of the fields
                TrimFieldsTexts();

                //Check if Input is Valid
                string[] invalid = InvalidInput();
                if (invalid != null)
                {
                    MessageBox.Show(invalid[0], invalid[1]);
                    return;
                }

                //Initialize new recipe
                Recipe recipe = new Recipe()
                {
                    name = tbName.Text,
                    description = tbDescription.Text,
                    price = tbPrice.Text,
                    image = pbRecipe.Image == null ? "" : Conversion.ImageToBase64((Image)pbRecipe.Image.Clone())
                };

                //Insert new recipe into Database
                //If user Unauthorized, show Message
                if (!RepoRecipe.AddRecipe(recipe).Contains("{\"name\""))
                {
                    MessageBox.Show("You are Unauthorized to add recipes");
                    return;
                }

                //Tell Dashboard about the recipe that was added
                parent.AddRecipe_AddedRecipe(recipe);

                //Clear All fields
                ClearFields();
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
                //Tell Dashboard that AddRecipe canceled
                parent.AddRecipe_CanceledRecipe();

                //Clear All fields
                ClearFields();
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
                    pbRecipe.ImageLocation = file.FileName;
                }
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

        private string[] InvalidInput()
        {
            //Check if Name is empty
            if (tbName.Text == "") return new string[] { "Please insert a name for the employee", "Name is empty" };

            //Check if email contains spaces
            if (tbPrice.Text.Contains(" ")) return new string[] { "Please insert a price for the employee", "Price is empty" };

            return null;
        }

        private void TrimFieldsTexts()
        {
            tbName.Text = tbName.Text.Trim();
            tbPrice.Text = tbPrice.Text.Trim();
            tbDescription.Text = tbDescription.Text.Trim();
        }

        private void ClearFields()
        {
            foreach (var field in Controls)
            {
                if (field is TextBox)
                {
                    var field2 = field as TextBox;
                    field2.Clear();
                }
                else if (field is PictureBox)
                {
                    var pb = field as PictureBox;
                    pb.Image = null;
                }
            }
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
