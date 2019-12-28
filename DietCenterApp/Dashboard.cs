using DietCenterApp.UserControls.Chef;
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
        public Dashboard()
        {
            InitializeComponent();

            //We need to switch Navbar Components based on User Roles
            //The Best is yet to come...



            UCRecipes ucRecipes = new UCRecipes();
            this.Controls.Add(ucRecipes);
        }
    }
}
