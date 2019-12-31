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


namespace DietCenterApp.UserControls.Manager
{
    public partial class AddEmployee : Form
    {
        //Class Variables
        Dashboard parent;

        public AddEmployee(Dashboard parent)
        {
            this.parent = parent;
            InitializeComponent();
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

                //Initialize new employee
                Employee employee = new Employee()
                {
                    name = tbName.Text,
                    email = tbEmail.Text,
                    password = tbPassword.Text,
                    phoneNumber = tbPhoneNumber.Text
                };

                //Loop the checkboxes, if checked add role to employee.Roles
                foreach (var field in Controls)
                {
                    if (field is CheckBox)
                    {
                        if (((CheckBox)field).Checked)
                        {
                                int roleID = 0;
                                //Set roleID base on role string
                                switch (((CheckBox)field).Text.ToLower())
                                {
                                    case "manager":
                                        roleID = 2;
                                        break;

                                    case "dietitian":
                                        roleID = 3;
                                        break;

                                    case "chef":
                                        roleID = 4;
                                        break;
                                }
                            employee.Roles.Add(new Employee.Role(roleID, ((CheckBox)field).Text));
                        }
                    }
                }

                //Insert new employee into Database
                //If user Unauthorized, show Message
                if (RepoEmployee.AddEmployee(employee).Contains("Unauthorized"))
                {
                    MessageBox.Show("You are Unauthorized to add employees");
                    return;
                }

                //Tell Dashboard about the employee that was added
                parent.AddEmployee_AddedEmployee(employee);

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
                //Tell Dashboard that AddEmployee canceled
                parent.AddEmployee_CanceledEmployee();

                //Clear All fields
                ClearFields();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        private string[] InvalidInput()
        {
            //Check if Name is empty
            if (tbName.Text == "")  return new string[] { "Please insert a name for the employee", "Name is empty" };

            //Check if email contains spaces
            if(tbEmail.Text.Contains(" ")) return new string[] { "Email cannot contain spaces", "Invalid Email" };

            //Check if email is valid
            if(!Regex.IsMatch(tbEmail.Text, @".+@.+\..+")) return new string[] { "Please insert a valid email, e.g. example@kwalka.com", "Invalid Email" };

            //Check if email is valid
            if(tbPassword.Text == "") return new string[] { "Please insert a password for the employee", "Password is empty" };

            //Check if email is valid
            if(tbPhoneNumber.Text == "") return new string[] { "Please insert a phone number for the employee", "Phone number is empty" };

            //Check if email is valid
            if(!cbManager.Checked && !cbDietitian.Checked && !cbChef.Checked) return new string[] { "Please choose at least 1 role for the employee", "No role selected" };

            return null;
        }

        private void TrimFieldsTexts()
        {
            tbName.Text = tbName.Text.Trim();
            tbEmail.Text = tbEmail.Text.Trim();
            tbPassword.Text = tbPassword.Text.Trim();
            tbPhoneNumber.Text = tbPhoneNumber.Text.Trim();
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
                else if (field is CheckBox)
                {
                    var field2 = field as CheckBox;
                    field2.Checked = false;
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
