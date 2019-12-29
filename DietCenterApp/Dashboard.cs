using DietCenterApp.UserControls.Chef;
using DietCenterApp.UserControls.Manager;
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
        Recipes recipes;
        AddRecipe addRecipe;
        AddEmployee addEmployee;
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
            if (recipes == null) recipes = new Recipes();
            openChildForm(recipes);
            recipes.panel1.Hide();
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (addRecipe == null) addRecipe = new AddRecipe();
            openChildForm(addRecipe);
            
          
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }
       

        private void btnEmp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpSubMenu);
        }

        // EmployeesSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (addEmployee == null) addEmployee = new AddEmployee();
            openChildForm(addEmployee);
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
        }
       

        private void btnClients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientsSubMenu);
        }
       // ClientsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }
       

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

    }
}