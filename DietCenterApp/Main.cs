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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ucLogin1_ValidLogin(object sender, EventArgs e)
        {
            try
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Closed += (s, args) => this.Close();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Function to handle the Exception in one place instead of handling each function's exceptions
        private void ExceptionHandling(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }
}
