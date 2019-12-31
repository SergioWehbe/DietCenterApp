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
        Main parent;
        //---Recipes---
        Recipes recipes;
        AddRecipe addRecipe;
        //---Employees---
        AddEmployee addEmployee;
        Employees employees;
        //---Clients---
        AddClient addClient;
        Clients clients;

        public Dashboard(Main parent)
        {
            this.parent = parent;
            InitializeComponent();
            if(!UserSession.Roles.Contains("manager")) btnEmployees.Hide();
            if(!UserSession.Roles.Contains("chef")) btnRecipes.Hide();
            if(!UserSession.Roles.Contains("dietitian")) btnClients.Hide();
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
        private void btnRecipes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRecipeSubMenu);
        }

         // RecipeSubMenu
        private void btnCheckRecipes_Click(object sender, EventArgs e)
        {
            if (recipes == null) recipes = new Recipes(this);
            openChildForm(recipes);
            recipes.panel1.Hide();
            hideSubMenu();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (addRecipe == null) addRecipe = new AddRecipe(this);
            openChildForm(addRecipe);
            hideSubMenu();
        }
      

        //-----Employees-----
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpSubMenu);
        }

        // EmployeesSubMenu
        private void btnCheckEmployees_Click(object sender, EventArgs e)
        {
            if (employees == null) employees = new Employees(this);
            openChildForm(employees);
            //employees.panel1.Hide();
            hideSubMenu();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (addEmployee == null) addEmployee = new AddEmployee(this);
            openChildForm(addEmployee);
            hideSubMenu();
        }


        //-----Clients-----
        private void btnClients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientsSubMenu);
        }
       // ClientsSubMenu
        private void btnCheckClients_Click(object sender, EventArgs e)
        {

            if (clients == null) clients = new Clients(this);
            openChildForm(clients);
            clients.panel1.Hide();
            hideSubMenu();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (addClient == null) addClient = new AddClient(this);
            openChildForm(addClient);
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            parent.LoggedOut();
        }


        //----------Communication between Forms----------
        //-----Recipes-----
        public void AddRecipe_AddedRecipe(Recipe recipe)
        {
            btnCheckRecipes_Click(new object(), EventArgs.Empty);
            recipes.AddRecipe_AddedRecipe(recipe);
        }

        public void AddRecipe_CanceledRecipe()
        {
            btnCheckRecipes_Click(new object(), EventArgs.Empty);
        }

        //-----Employees-----
        public void AddEmployee_AddedEmployee(Employee employee)
        {
            btnCheckEmployees_Click(new object(), EventArgs.Empty);
            employees.AddEmployee_AddedEmployee(employee);
        }

        public void AddEmployee_CanceledEmployee()
        {
            btnCheckEmployees_Click(new object(), EventArgs.Empty);
        }

        //-----Clients-----
        public void AddClient_AddedClient(Client client)
        {
            btnCheckClients_Click(new object(), EventArgs.Empty);
            clients.AddClient_AddedClient(client);
        }

        public void AddClient_CanceledClient()
        {
            btnCheckClients_Click(new object(), EventArgs.Empty);
        }
    }
}