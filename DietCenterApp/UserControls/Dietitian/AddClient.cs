using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCenterApp.UserControls.Dietitian
{
    public partial class AddClient : Form
    {
        //Class Variables
        Dashboard parent;

        public AddClient(Dashboard parent)
        {
            this.parent = parent;
            InitializeComponent();
        }


    }
}
