using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
