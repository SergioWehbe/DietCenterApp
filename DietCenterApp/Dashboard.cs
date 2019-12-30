using DietCenterApp.UserControls.Chef;
using DietCenterApp.UserControls.Manager;
using DietCenterApp.UserControls.Dietitian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCenterApp
{
    public partial class Dashboard : Form
    {
        //Variables
        //---Recipes---
        Recipes recipes;
        AddRecipe addRecipe;
        //---Employees---
        AddEmployee addEmployee;
        Employees employees;
        //---Clients---
        AddClient addClient;
        Clients clients;

        public Dashboard()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelRecipeSubMenu.Visible = false;
            panelEmpSubMenu.Visible = false;
            panelClientsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRecipeSubMenu);
        }

         // RecipeSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            if (recipes == null) recipes = new Recipes(this);
            openChildForm(recipes);
            recipes.panel1.Hide();
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (addRecipe == null) addRecipe = new AddRecipe(this);
            openChildForm(addRecipe);
            
          
            hideSubMenu();
        }
      
        private void btnEmp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpSubMenu);
        }

        // EmployeesSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            if (employees == null) employees = new Employees(this);
            openChildForm(employees);
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (addEmployee == null) addEmployee = new AddEmployee(this);
            openChildForm(addEmployee);
            hideSubMenu();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientsSubMenu);
        }
       // ClientsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {

            if (clients == null) clients = new Clients(this);
            openChildForm(clients);
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (addClient == null) addClient = new AddClient(this);
            openChildForm(addClient);
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //open forms over Main panel 
        private void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //-----Recipes-----
        public void AddRecipe_AddedRecipe(Recipe recipe)
        {
            button2_Click(new object(), EventArgs.Empty);
            recipes.AddRecipe_AddedRecipe(recipe);
        }

        public void AddRecipe_CanceledRecipe()
        {
            button2_Click(new object(), EventArgs.Empty);
        }

        //-----Employees-----
        public void AddEmployee_AddedEmployee(User user)
        {
            button2_Click(new object(), EventArgs.Empty);
            employees.AddEmployee_AddedEmployee(user);
        }

        public void AddEmployee_CanceledEmployee()
        {
            button2_Click(new object(), EventArgs.Empty);
        }

        //-----Clients-----
        public void AddClient_AddedClient(User user)
        {
            button2_Click(new object(), EventArgs.Empty);
            clients.AddClient_AddedClient(user);
        }

        public void AddClient_CanceledClient()
        {
            button2_Click(new object(), EventArgs.Empty);
        }
    }
}