using System;
using System.Configuration;
using System.ServiceProcess;
using System.Threading;
using AutomaticoBackupOpenLP.Model;
using System.Collections.Generic;
using System.Diagnostics;

namespace AutomaticoBackupOpenLP
{
    public partial class Service1 : ServiceBase
    {        
        private readonly int intervalo = Convert.ToInt32(ConfigurationManager.AppSettings["timer"].ToString());
        VisualizadorEventosLog eventLog = new VisualizadorEventosLog();
        EventLog log = null;

        public Service1()
        {
            InitializeComponent();
            log = eventLog.Log("Backup Automático OpenLP");
        }

        #region Método utilizado para realizar debbugs
        internal void TestService(string[] args)
        {
            this.OnStart(args);
        }
        #endregion

        protected override void OnStart(string[] args)
        {                        
            log.WriteEntry("O serviço Backup Automático OpenLP acaba de inicializar.");

            ThreadStart start = new ThreadStart(RealizaBackup);
            Thread thread = new Thread(start);
            thread.Start();
        }

        protected override void OnStop()
        {                        
            log.WriteEntry("O serviço Backup Automático OpenLP acaba de finalizar.");            
        }

        private void RealizaBackup()
        {
            try
            {
                int contador = 0;

                while (true)
                {
                    if (contador != 0)
                    {
                        Thread.Sleep(intervalo);
                    }

                    OpenLP openLp = new OpenLP(log);

                    List<RsMusicas> musicas = openLp.getDados();

                    foreach (var musica in musicas)
                    {
                        openLp.gravaMusica(musica);
                    }

                    contador++;
                }
            }
            catch (Exception e)
            {                
                log.WriteEntry(e.Message, EventLogEntryType.Error);
            }
        }
    }
}
