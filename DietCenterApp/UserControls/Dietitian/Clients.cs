using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DietCenterApp.Repositories;

namespace DietCenterApp.UserControls.Dietitian
{
    public partial class Clients : Form
    {

        EditClient editClient;
        public Clients()
        {
            InitializeComponent();
            InitializeEditClient();
        }

        private void InitializeEditClient()
        {
           editClient = new EditClient(this);
           editClient.TopLevel = false;
           editClient.FormBorderStyle = FormBorderStyle.None;
            panel1.Hide();
            panel1.BringToFront();
            panel1.Controls.Add(editClient);
           editClient.Show();
        }
    }
}
