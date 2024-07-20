using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinServiceCamera
{
    public partial class Form1 : Form
    {
        private string _nmService = "ServiceCam.Exe";
        string currentProjectPath = System.Reflection.Assembly.GetEntryAssembly().Location;

        public Form1()
        {
            InitializeComponent();
        }
        void SetInCenter()
        {
            filePath.Location = new System.Drawing.Point((this.Width - filePath.Width) / 2, filePath.Location.Y);
            label.Location = new System.Drawing.Point((this.Width - label.Width) / 2, label.Location.Y);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (buttonSend.Text != "Deactive Service")
            {
                string otherProjectPath = Path.Combine(Path.GetDirectoryName(currentProjectPath), _nmService);
                string command = $"sc create CheckCamActivity binPath= {otherProjectPath}";
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();
                process.StandardInput.WriteLine(command);
                process.StandardInput.WriteLine("exit");
                process.WaitForExit();
            }
            else
            {

                string command = $"sc delete {_nmService}";
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();
                process.StandardInput.WriteLine(command);
                process.StandardInput.WriteLine("exit");
                process.WaitForExit();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string serviceName = "CheckCamActivity"; // Ndryshoni me emrin e shërbimit tuaj

                ServiceController sc = new ServiceController(serviceName);

                buttonSend.Text = (sc.Status == ServiceControllerStatus.Running) ? "Deactive Service" : "Create Service";
                if (sc.Status == ServiceControllerStatus.Running)
                {
                    MessageBox.Show("False");
                }
            }
            catch (Exception ex)
            {

            }
           

        }
    }

}
