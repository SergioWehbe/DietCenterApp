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

namespace DietCenterApp.UserControls.Manager
{
    public partial class Employees : Form
    {
        //Class Variables
        Dashboard parent;
        EmployeeGroup clientGroup;
        List<Employee> clients;
        DataTable clientsDT;

        public Employees(Dashboard parent)
        {
            this.parent = parent;
            InitializeComponent();
            GetEmployees();
        }

        private void GetEmployees()
        {
            try
            {
                //Get JsonObject from Api
                clientGroup = RepoEmployee.GetAlllCients();

                //Save Employees
                clients = clientGroup.data;

                //Convert List clients to DataTable
                dgvEmployees.DataSource = clientsDT = EmployeeGroup.ConvertDataIntoDataTable(clients);

                //Set id column visibility false
                dgvEmployees.Columns["id"].Visible = false;
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
                clientGroup = RepoEmployee.GetAllEmployeesNextPage();

                //Convert List clients in jsonObject to DataTable
                DataTable newEmployees = EmployeeGroup.ConvertDataIntoDataTable(clientGroup.data);

                //Add new clients to DataTable
                clientsDT.Merge(newEmployees);

                //Set new DataTable as Data Grid View DataSource
                dgvEmployees.DataSource = clientsDT;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        private void tbEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable searchedDT;
            try
            {
                if (tbEmployeeSearch.Text == "")
                {
                    //If Empty search box, DataSource = All Employees
                    dgvEmployees.DataSource = clientsDT;
                    return;
                }

                searchedDT = clientsDT.Select("Name LIKE '%" + tbEmployeeSearch.Text + "%'").CopyToDataTable();
            }
            catch (Exception)
            {
                //If search text is not Found, DataSource = Empty DataTable
                searchedDT = clientsDT.Clone();
                searchedDT.Clear();
            }

            dgvEmployees.DataSource = searchedDT;
        }


        //Event Added Employee
        public void AddEmployee_AddedEmployee(Employee employee)
        {
            try
            {
                GetEmployees();
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        //Delete Employee
        private void dgvEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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

                //Delete each selected employee
                foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        RepoEmployee.DeleteEmployee(row.Cells["id"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
                e.Cancel = true;
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
            else
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
