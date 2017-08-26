using System;
using System.Configuration;
using System.Diagnostics;
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
            VisualizadorEventosLog eventLog = new VisualizadorEventosLog();
            var log = eventLog.Log("Backup Automático OpenLP");

            try
            {              
                var debbuger = ConfigurationManager.AppSettings["debbuger"].ToString();

                if (debbuger.Equals("S"))
                {
                    Service1 servico = new Service1(log);
                    servico.TestService(args);
                }
                else
                {
                    ServiceBase[] ServicesToRun;
                    ServicesToRun = new ServiceBase[]
                    {
                new Service1(log)
                    };
                    ServiceBase.Run(ServicesToRun);
                }
            }
            catch (Exception e)
            {                               
                log.WriteEntry(e.Message + e.StackTrace, EventLogEntryType.Error);
            }      
        }

    }
}
