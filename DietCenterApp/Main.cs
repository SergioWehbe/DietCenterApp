using DietCenterApp.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DietCenterApp.Employee;
using static DietCenterApp.Repositories.RepoLogin;

namespace DietCenterApp
{
    public partial class Main : Form
    {
        //Variables
        Dashboard dashboard;

        public Main()
        {
            InitializeComponent();
            tbUsername.Text = "sergiowehbe@gmail.com";
            tbPassword.Text = "secret";
        }

        //Login on Enter in tbUsername
        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnLogin.PerformClick();
        }

        //Login on Enter in tbPassword
        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Fill Dictionary to send variables(username,password) to Post function
                Dictionary<string, string> variables = new Dictionary<string, string>();
                variables.Add("username", tbUsername.Text);
                variables.Add("password", tbPassword.Text);

                //Attempt Login
                TokenGroup tokenGroup = RepoLogin.Login(variables);

                //On Successful Login, save access token and open UserControls
                UserSession.AccessToken = tokenGroup.access_token;
                UserSession.RefreshToken = tokenGroup.refresh_token;
                UserSession.TokenType = tokenGroup.token_type;
                UserSession.ExpiresIn = tokenGroup.expires_in;

                //Get Roles and save them in UserSession and check if User authorized
                RolesData roles = RepoLogin.GetRoles();
                bool authorized = false;
                foreach (var role in roles.data)
                {
                    UserSession.Roles.Add(role.name);
                    if (role.id > 1) authorized = true;
                }

                if (!authorized)
                {
                    UserSession.ClearAllFields();
                    MessageBox.Show("Unauthorized");
                    return;
                }

                //Tell Main Form that it's a valid login
                try
                {
                    dashboard = new Dashboard(this);
                    dashboard.Closed += (s, args) => this.Close();
                    dashboard.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    ExceptionHandling(ex);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
        }

        public void LoggedOut()
        {
            //Clear UserSession
            UserSession.ClearAllFields();

            //Release all resources on dashboard
            dashboard.Dispose();

            //Show Main form (Login)
            this.Show();
        }

        //Function to handle the Exception in one place instead of handling each function's exceptions
        private void ExceptionHandling(Exception ex)
        {
            if (ex.Message.Contains("The remote server returned an error: (400) Bad Request."))
            {
                MessageBox.Show("Invalid username or Password");
            }
            else if (ex.Message.Contains("Unable to connect to the remote server"))
            {
                MessageBox.Show("Could not connect to server, check your internet connection");
            }
            else
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

      
    }
}
