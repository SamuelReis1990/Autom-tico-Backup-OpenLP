using System.Configuration;
using System.ServiceProcess;

namespace AutomaticoBackupOpenLP
{
    static class Program
    {        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            var debbuger = ConfigurationManager.AppSettings["debbuger"].ToString();

            if (debbuger.Equals("S"))
            {
                Service1 servico = new Service1();
                servico.TestService(args);
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new Service1()
                };
                ServiceBase.Run(ServicesToRun);
            }           
        }

    }
}
