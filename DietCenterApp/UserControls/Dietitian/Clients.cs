using DietCenterApp.Repositories;
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
    public partial class Clients : Form
    {
        //Class Variables
        Dashboard parent;
        EditClient editClient;
        ClientGroup clientGroup;
        List<Client> clients;
        DataTable clientsDT;
        int SelectedRowIndex;

        public Clients(Dashboard parent)
        {
            this.parent = parent;
            InitializeComponent();
            GetClients();
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

        private void GetClients()
        {
            try
            {
                //Get JsonObject from Api
                clientGroup = RepoClient.GetAlllCients();

                //Save Clients
                clients = clientGroup.data;

                //Convert List clients to DataTable
                dgvClients.DataSource = clientsDT = ClientGroup.ConvertDataIntoDataTable(clients);

                //Set id column visibility false
                dgvClients.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Check if jsonObject is not null
                if (clientGroup.links.next == null) return;

                //Get JsonObject from Api
                clientGroup = RepoClient.GetAllClientsNextPage();

                //Convert List clients in jsonObject to DataTable
                DataTable newClients = ClientGroup.ConvertDataIntoDataTable(clientGroup.data);

                //Add new clients to DataTable
                clientsDT.Merge(newClients);

                //Set new DataTable as Data Grid View DataSource
                dgvClients.DataSource = clientsDT;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //In case the header's row was double clicked, return
                if (e.RowIndex < 0) return;

                //Set SelectedRowIndex's values
                SelectedRowIndex = e.RowIndex;

                //Load the selected client
                LoadSelectedClient();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Load the selected client
        private void LoadSelectedClient()
        {
            //Clear EditClient fields
            editClient.ClearFields();

            //Set all data to selected client
            editClient.SelectedRowID = dgvClients.Rows[SelectedRowIndex].Cells["id"].Value.ToString();
            editClient.tbName.Text = dgvClients.Rows[SelectedRowIndex].Cells["Name"].Value.ToString();
            editClient.tbEmail.Text = dgvClients.Rows[SelectedRowIndex].Cells["Email"].Value.ToString();
            editClient.tbPhoneNumber.Text = dgvClients.Rows[SelectedRowIndex].Cells["Phone Number"].Value.ToString();

            //Bring ucEdit to front
            panel1.Show();
        }

        private void tbClientSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable searchedDT;
            try
            {
                if (tbClientSearch.Text == "")
                {
                    //If Empty search box, DataSource = All Clients
                    dgvClients.DataSource = clientsDT;
                    return;
                }

                searchedDT = clientsDT.Select("Name LIKE '%" + tbClientSearch.Text + "%'").CopyToDataTable();
            }
            catch (Exception)
            {
                //If search text is not Found, DataSource = Empty DataTable
                searchedDT = clientsDT.Clone();
                searchedDT.Clear();
            }

            dgvClients.DataSource = searchedDT;
        }

        //Event Saved Client
        public void EditClient_SavedClient()
        {
            try
            {
                //Update client in dgvClients
                dgvClients.Rows[SelectedRowIndex].Cells["Name"].Value = editClient.tbName.Text;
                dgvClients.Rows[SelectedRowIndex].Cells["Email"].Value = editClient.tbEmail.Text;
                dgvClients.Rows[SelectedRowIndex].Cells["Phone Number"].Value = editClient.tbPhoneNumber.Text;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }
        //Event Added Client
        public void AddClient_AddedClient(Client client)
        {
            try
            {
                GetClients();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Delete Client
        private void dgvClients_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                //Show Message box to confirm the deletion of the selected clients
                if (MessageBox.Show("Are you sure you want to delete the selected clients?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Cancel)
                {
                    //If deletion is canceled, exit function
                    e.Cancel = true;
                    return;
                }

                //Delete each selected client
                foreach (DataGridViewRow row in dgvClients.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        RepoClient.DeleteClient(row.Cells["id"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }


        //Function to handle the Exception in one place instead of handling each function's exceptions
        private void ExceptionHandling(Exception ex)
        {
            if (ex.Message.Contains("Unable to connect to the remote server"))
            {
                MessageBox.Show("Could not connect to server, check your internet connection");
            }
            else if (ex.Message.Contains("The request was aborted: The connection was closed unexpectedly."))
            {
                MessageBox.Show("Could not connect to Database on the server, please contact your Administrator", "Error");
            }
            else if (ex.Message.Contains("Error converting value {null} to"))
            {
                MessageBox.Show("There are no clients");
            }
            else
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
