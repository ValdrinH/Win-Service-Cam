using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ServiceCam
{
    public partial class CameraService : ServiceBase
    {
        private System.Timers.Timer timer;
        private bool isCameraOpen = false;

        protected override void OnStart(string[] args)
        {
            timer = new System.Timers.Timer(5000); // Kontrollo statusin çdo 5 sekonda
            timer.Elapsed += new ElapsedEventHandler(CheckCameraStatus);
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            timer.Enabled = false;
        }

        private void CheckCameraStatus(object sender, ElapsedEventArgs e)
        {
            // Simulimi i kontrollit të statusit të kameras
            Random random = new Random();
            isCameraOpen = random.Next(2) == 0;

            if (isCameraOpen)
            {
                ShowCameraOpenMessageBox();
            }
        }

        private void ShowCameraOpenMessageBox()
        {
           MessageBox.Show("Kamera është e hapur!");
        }
    }
}
