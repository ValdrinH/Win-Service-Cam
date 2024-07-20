using ServiceCam;
using System;
using System.ServiceProcess;

namespace ServiceBaseWin;
class Program
{
    static void Main(string[] args)
    {
        ServiceBase[] ServicesToRun;
        ServicesToRun = new ServiceBase[]
        {
                new CameraService()
        };
        ServiceBase.Run(ServicesToRun);
    }
}
