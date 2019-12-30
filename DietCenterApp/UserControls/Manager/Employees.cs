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
    public partial class Employees : Form
    {
        //Class Variables
        Dashboard parent;

        public Employees(Dashboard parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public void AddEmployee_AddedEmployee(User user)
        {

        }
    }
}
