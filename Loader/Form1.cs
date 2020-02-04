using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace Loader
{
    public partial class Form : MetroFramework.Forms.MetroForm
    {
    	// hardcoded credentials, please dont kill me
        string auth_username = "";
        string auth_password = "";


        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            // https authentication
            WebClient client2 = new WebClient();

            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth_username + ":" + auth_password));
            client2.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
            client2.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", credentials);

            string client_address = new WebClient().DownloadString("http://icanhazip.com");
            string authorized_address = client2.DownloadString("https://evil.site/files/loader/auth.txt");

            string authorized = client_address + usernameBox.Text;
            client2.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
            string banCheck = client2.DownloadString("https://evil.site/files/loader/disabled.txt");

            client2.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
            string gasVersion = client2.DownloadString("https://evil.site/files/loader/status.txt");

            if (authorized_address.Contains(authorized))
            {
                if (banCheck.Contains(usernameBox.Text))
                {
                    MessageBox.Show("Your account has been disabled, Contact Stabber for more information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (gasVersion.Contains("down"))
                    {
                        MessageBox.Show("Server is currently undergoing maintainence.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Authorized!, Welcome back: " + usernameBox.Text, "Success!");

                        this.Hide();

                        // Open new form if user is authenticated
                        var openForm = new Form2(usernameBox.Text);
                        openForm.Closed += (s, args) => this.Close();
                        openForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("You are not authorized!, Contact Liam", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(1000);
            }
        }

        private void usernameBox_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}
