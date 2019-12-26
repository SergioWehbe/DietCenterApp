using DietCenterApp.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DietCenterApp
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> variables = new Dictionary<string, string>();
                variables.Add("username", tbUsername.Text);
                variables.Add("password", tbPassword.Text);
                TokenGroup tokenGroup = (TokenGroup)RepoLogin.Login(variables);

                //On Successful Login, save access token and open UserControls
                UserSession.AccessToken = tokenGroup.access_token;
                UserSession.RefreshToken = tokenGroup.refresh_token;
            }
            catch (Exception ex)
            {
                ExceptionHandling(ex);
            }
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
