﻿using System;
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
    public partial class EditRecipe : Form
    {
        private Recipes parent = null;
        public string ImagePath;
        public string base64Image;
        public int SelectedRowID;

        public EditRecipe(Recipes recipes)
        {
            parent = recipes;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    id = SelectedRowID,
                    name = tbName.Text,
                    description = tbDescription.Text,
                    price = tbPrice.Text,
                    image = base64Image = pbRecipe.Image == null ? "" : Conversion.ImageToBase64((Image)pbRecipe.Image.Clone())
                };

                //Insert new recipe into Database
                //If user Unauthorized, show Message
                if (RepoRecipe.UpdateRecipe(recipe).Contains("Unauthorized"))
                {
                    MessageBox.Show("You are Unauthorized to change the recipe");
                    return;
                }

                //Trigger save recipe event
                parent.EditRecipe_SavedRecipe();

                //Send to back
                parent.panel1.Hide();
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
                parent.panel1.Hide();
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
