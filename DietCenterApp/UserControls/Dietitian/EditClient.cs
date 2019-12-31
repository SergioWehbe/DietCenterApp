using DietCenterApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCenterApp.UserControls.Dietitian
{
    public partial class EditClient : Form
    {
        //Variables
        Clients parent;
        public string SelectedRowID;
        public EditClient(Clients parent)
        {
            this.parent = parent;
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

                //Initialize new client
                Client client = new Client()
                {
                    id = SelectedRowID,
                    name = tbName.Text,
                    email = tbEmail.Text,
                    password = tbPassword.Text,
                    phoneNumber = tbPhoneNumber.Text,
                };

                //Insert new client into Database
                //If user Unauthorized, show Message
                if (RepoClient.UpdateClient(client).Contains("Unauthorized"))
                {
                    MessageBox.Show("You are Unauthorized to change the client");
                    return;
                }

                //Trigger save client event
                parent.EditClient_SavedClient();

                //Send to back
                parent.panel1.Hide();
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

        private string[] InvalidInput()
        {
            //Check if Name is empty
            if (tbName.Text == "") return new string[] { "Please insert a name for the employee", "Name is empty" };

            //Check if email contains spaces
            if (tbEmail.Text.Contains(" ")) return new string[] { "Email cannot contain spaces", "Invalid Email" };

            //Check if email is valid
            if (!Regex.IsMatch(tbEmail.Text, @".+@.+\..+")) return new string[] { "Please insert a valid email, e.g. example@kwalka.com", "Invalid Email" };

            //Check if email is valid
            if (tbPhoneNumber.Text == "") return new string[] { "Please insert a phone number for the employee", "Phone number is empty" };

            return null;
        }

        private void TrimFieldsTexts()
        {
            tbName.Text = tbName.Text.Trim();
            tbEmail.Text = tbEmail.Text.Trim();
            tbPassword.Text = tbPassword.Text.Trim();
            tbPhoneNumber.Text = tbPhoneNumber.Text.Trim();
        }

        public void ClearFields()
        {
            foreach (var field in Controls)
            {
                if (field is TextBox)
                {
                    var field2 = field as TextBox;
                    field2.Clear();
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
            else if (ex.Message.Contains("The remote server returned an error: (500) Internal Server Error."))
            {
                MessageBox.Show("A user with this email already exists");
            }
            else
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
